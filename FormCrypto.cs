using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Formatting;
using System.Diagnostics;
using System.Globalization;
using System.Web.Script.Serialization;

namespace CryptoGame
{
    public partial class FormCrypto : Form
    {
        static HttpClient client = new HttpClient();
        private static string APIKey = "";

        public FormCrypto()
        {
            InitializeComponent();
            buttonBet.Enabled = false;
        }

        private void buttonEditAPI_Click(object sender, EventArgs e)
        {
            buttonEditAPI.Text = textBoxAPI.ReadOnly ? "Lock API" : "Edit API";
            textBoxAPI.ReadOnly = !textBoxAPI.ReadOnly;
        }

        // Y'a plein de commentaires du coup j'ai remarqué que la fonction est très dure à lire x) je l'ai recopié en dessous
        // sans les commentaires
        private void buttonPoloniex_Click(object sender, EventArgs e)
        {
            // Chronometre
            Stopwatch w = new Stopwatch();
            w.Start();

            string url = "https://poloniex.com/public?command=returnTicker";

            // On créé une WebRequest qui va prendre notre url
            WebRequest req = WebRequest.Create(url);
            // On récupère la réponse
            WebResponse res = req.GetResponse();

            // using est un bloc qui prend une ressource et s'assure qu'elle soit détruite à la fin 
            // (peu importe ce qui arrive, elle sera détruite, ça évite les fuites de mémoires)
            // la ressource est disponible uniquement dans la portée des { } et est détruite à la fin
            using (var reader = new StreamReader(res.GetResponseStream()))
            {
                // On récupère la réponse entière ici
                string responseJSON = reader.ReadToEnd();

                // On utilise le Parser pour créer un objet JSON dynamic 
                // (c'est un truc que je viens de découvrir ! il est résolu uniquement en runtime)
                dynamic json = System.Web.Helpers.Json.Decode(responseJSON);

                // On créé et on instancie notre liste de PoloniexResult
                List<PoloniexResult> listPX = new List<PoloniexResult>();

                // On utilise un foreach pour cycler sur tous les résultats du parser
                // Ici "item" est un KeyValuePair (encore un truc que je viens de découvrir, c'est cool)
                // il est décomposé en <Key> et <Value>. 
                // Key c'est une string, c'est le nom de l'item
                // Value c'est un object, donc ça peut être n'importe quoi
                foreach (var item in json)
                {
                    // J'ai écrit une méthode qui convertit direct l'item en PoloniexResult, va la voir, 
                    // c'est important de comprendre comment utiliser ce KeyValuePair si tu veux utiliser ce Parser !
                    PoloniexResult pxRes = PoloniexResult.FromJSONDynamic(item);
                    listPX.Add(pxRes);
                }
                w.Stop();
                AddOutputLine("Time of query, parsing and inventoring " + listPX.Count + " objects : " + w.ElapsedMilliseconds + " ms");
            }
        }

        /// <summary>
        /// Ajoute une ligne dans la textBoxOutput
        /// </summary>
        private void AddOutputLine(string text)
        {
            if (textBoxOutput.InvokeRequired)
                this.Invoke((MethodInvoker)(() => AddOutputLine(text)));
            else
                textBoxOutput.AppendText(text + "\r\n");
        }

        /*
         var input = { Bet: 0.00001024, Payout: 2.0, UnderOver: true, ClientSeed: "somerandomseed" };
         {
          url: "https://api.crypto-games.net/v1/placebet/<Coin>/<Key>",
          data: JSON.stringify(input),
          dataType: "json",
          contentType: "application/json",
          type: "POST",
          success: function (r) {
                console.log(r);
          }
         }
        */

        /// <summary>
        /// Place un pari avec les différents paramètres
        /// </summary>
        /// <param name="bet">Montant du pari</param>
        /// <param name="payout">Retour sur le pari</param>
        /// <param name="underOver">true : over, false : under</param>
        /// <param name="clientSeed">Graine pour le random</param>
        /// <param name="coin">Monnaie pour le pari</param>
        /// <param name="key">Clef d'accès API</param>
        /// <source>http://stackoverflow.com/questions/9145667/how-to-post-json-to-the-server</source>
        private void JsonPlaceBet(decimal bet, decimal payout, bool underOver,
            string coin, string key, string clientSeed = "somerandomseed")
        {
            string url = "https://api.crypto-games.net/v1/placebet/";
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url + coin + "/" + key);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            string json = "";
            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                json = new JavaScriptSerializer().Serialize(new
                {
                    Bet = bet,
                    Payout = payout,
                    UnderOver = underOver,
                    ClientSeed = clientSeed
                });
                AddOutputLine("Bet placed : " + json);
                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                dynamic resJson = System.Web.Helpers.Json.Decode(result); // TODO Faire une classe pour recup le result en json de PlaceBet
                BetResult b = BetResult.FromJSONDynamic(resJson, coin);
                AddOutputLine("Result: " + b);
            }
        }

        private CoinBalance JsonGetBalance(string coin, string key)
        {
            if (coin != null && key != "")
            {
                string url = "https://api.crypto-games.net/v1/balance/" + coin + "/" + key;

                WebRequest req = WebRequest.Create(url);
                WebResponse res = req.GetResponse();

                using (var reader = new StreamReader(res.GetResponseStream()))
                {
                    string responseJSON = reader.ReadToEnd();
                    dynamic json = System.Web.Helpers.Json.Decode(responseJSON);

                    CoinBalance bal = CoinBalance.FromJSONDynamic(json, coin);
                    return bal;
                }
            }
            else
                AddOutputLine("Coin or API Key invalid.");
            return new CoinBalance();
        }

        private BetSettings JsonGetBetSettings(string coin)
        {
            if (coin != null)
            {
                string url = "https://api.crypto-games.net/v1/settings/" + coin;

                WebRequest req = WebRequest.Create(url);
                WebResponse res = req.GetResponse();

                using (var reader = new StreamReader(res.GetResponseStream()))
                {
                    string responseJSON = reader.ReadToEnd();
                    dynamic json = System.Web.Helpers.Json.Decode(responseJSON);

                    BetSettings betSet = BetSettings.FromJSONDynamic(json);
                    return betSet;
                }
            }
            else
                AddOutputLine("Select a Coin first");
            return new BetSettings();
        }

        private CoinStats JsonGetCoinStats(string coin)
        {
            if (coin != null)
            {
                string url = "https://api.crypto-games.net/v1/coinstats/" + coin;

                WebRequest req = WebRequest.Create(url);
                WebResponse res = req.GetResponse();

                using (var reader = new StreamReader(res.GetResponseStream()))
                {
                    string responseJSON = reader.ReadToEnd();
                    dynamic json = System.Web.Helpers.Json.Decode(responseJSON);

                    CoinStats coinStats = CoinStats.FromJSONDynamic(json);
                    return coinStats;
                }
            }
            else
                AddOutputLine("Select a Coin first");
            return new CoinStats();
        }

        private string GetSelectedCoin()
        {
            if (listBoxCoin.SelectedIndex != -1)
            {
                return (string)listBoxCoin.SelectedItem;
            }
            return null;
        }
        private decimal GetBetAmount()
        {
            return numericUpDownBet.Value;
        }
        private decimal GetBetPayout()
        {
            return numericUpDownPayout.Value;
        }
        private bool GetUnderOver()
        {
            return checkBoxUnderOver.Checked;
        }
        private string GetAPIKey()
        {
            return textBoxAPI.Text;
        }

        private void buttonBet_Click(object sender, EventArgs e)
        {
            string coin = GetSelectedCoin();
            string key = GetAPIKey();
            if (coin != null && key != "")
            {
                buttonBet.Enabled = false;
                decimal betAmount = GetBetAmount();
                decimal betPayout = GetBetPayout();
                bool underOver = GetUnderOver();
                JsonPlaceBet(betAmount, betPayout, underOver, coin, key);
                buttonBet.Enabled = true;
            }
            else
                AddOutputLine("Coin or API Key invalid.");
        }

        private void buttonBalance_Click(object sender, EventArgs e)
        {
            string coin = GetSelectedCoin();
            string key = GetAPIKey();
            if (coin != null && key != "")
            {
                CoinBalance bal = JsonGetBalance(coin, key);
                AddOutputLine(bal.ToString());
            }
            else
                AddOutputLine("Coin or API Key invalid.");
        }

        private void buttonBetSettings_Click(object sender, EventArgs e)
        {
            string coin = GetSelectedCoin();
            if (coin != null)
            {
                BetSettings betSet = JsonGetBetSettings(coin);
                AddOutputLine(betSet.ToString());
            }
            else
                AddOutputLine("Select a Coin first");
        }

        private void buttonCoinStats_Click(object sender, EventArgs e)
        {
            string coin = GetSelectedCoin();
            if (coin != null)
            {
                CoinStats coinStats = JsonGetCoinStats(coin);
                AddOutputLine(coinStats.ToString());
            }
            else
                AddOutputLine("Select a Coin first");
        }

        /// <summary>
        /// A chaque changement de monnaie dans la ListBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxCoin_SelectedIndexChanged(object sender, EventArgs e)
        {
            string coin = GetSelectedCoin();
            string key = GetAPIKey();
            if (coin != null && key != "")
            {
                buttonBet.Enabled = false;
                labelCoin.Text = coin;
                labelBalance.Text = JsonGetBalance(coin, key).Balance.ToString();
                BetSettings b = JsonGetBetSettings(coin);
                numericUpDownBet.Minimum = b.MinBet;
                numericUpDownBet.Increment = b.MinBet;
                numericUpDownPayout.Minimum = b.MinRatio;
                numericUpDownPayout.Maximum = b.MaxRatio;
                //if (numericUpDownBet.Value < b.MinBet)
                    numericUpDownBet.Value = b.MinBet;
                if (numericUpDownPayout.Value < b.MinRatio)
                    numericUpDownPayout.Value = b.MinRatio;
                labelMinMaxBet.Text = "(" + b.MinBet + " - ???)";
                labelMinMaxPayout.Text = "(" + b.MinRatio + " - " + b.MaxRatio + ")";
                buttonBet.Enabled = true;
            }
            else
                AddOutputLine("Coin or API Key invalid.");
        }
    }

    public class BetSettings
    {
        public string Coin { get; set; } = "Coin";
        public decimal MinBet { get; set; } = 0;
        public decimal MaxWin { get; set; } = 0;
        public decimal MinRatio { get; set; } = 0;
        public decimal MaxRatio { get; set; } = 0;
        public decimal Edge { get; set; } = 0;

        public static BetSettings FromJSONDynamic(dynamic json)
        {
            BetSettings s = new BetSettings();
            s.Coin = json.Coin;
            s.MinBet = json.MinBet;
            s.MaxWin = json.MaxWin;
            s.MinRatio = json.MinRatio;
            s.MaxRatio = json.MaxRatio;
            s.Edge = json.Edge;
            return s;
        }

        public override string ToString()
        {
            string output = "Coin: " + this.Coin + "\r\n";
            output += "Min Bet: " + this.MinBet + "\r\n";
            output += "Max Win: " + this.MaxWin + "\r\n";
            output += "Min Payout: " + this.MinRatio + "\r\n";
            output += "Max Payout: " + this.MaxRatio + "\r\n";
            output += "House Edge: " + this.Edge;
            return output;
        }
    }

    public class CoinStats
    {
        public string Coin { get; set; }
        public int Bets { get; set; }
        public decimal Wagered { get; set; }
        public decimal Profit { get; set; }
        public decimal Bankroll { get; set; }

        public static CoinStats FromJSONDynamic(dynamic json)
        {
            CoinStats cs = new CoinStats();
            cs.Coin = json.Coin;
            cs.Bets = json.Bets;
            cs.Wagered = json.Wagered;
            cs.Profit = json.Profit;
            cs.Bankroll = json.Bankroll;
            return cs;
        }

        public override string ToString()
        {
            string output = "Coin: " + this.Coin + "\r\n";
            output += "Bets: " + this.Bets + "\r\n";
            output += "Amount Wagered: " + this.Wagered + "\r\n";
            output += "Total Profit: " + this.Profit + "\r\n";
            output += "Bankroll: " + this.Bankroll;
            return output;
        }
    }

    public class CoinBalance
    {
        public string Coin { get; set; } = "";
        public decimal Balance { get; set; } = 0;
        public static CoinBalance FromJSONDynamic(dynamic json, string coin)
        {
            CoinBalance cs = new CoinBalance();
            cs.Balance = json.Balance;
            cs.Coin = coin;
            return cs;
        }

        public override string ToString()
        {
            return "Balance : " + this.Balance + " " + this.Coin;
        }
    }

    public class PoloniexResult
    {
        public string Coin { get; set; } = "Coin";
        public int ID { get; set; } = 0;
        public decimal Last { get; set; } = 0;
        public decimal LowestAsk { get; set; } = 0;
        public decimal HighestBid { get; set; } = 0;
        public decimal PercentChange { get; set; } = 0;
        public decimal BaseVolume { get; set; } = 0;
        public decimal QuoteVolume { get; set; } = 0;
        public int IsFrozen { get; set; } = 0;
        public decimal High24hr { get; set; } = 0;
        public decimal Low24hr { get; set; } = 0;

        /// <summary>
        /// Les résultats qu'on récupère depuis Poloniex sont sous cette forme :
        /// 
        /// "BTC_BBR":{"id":6,"last":"0.00015809","lowestAsk":"0.00015858","highestBid":"0.00015809",
        /// "percentChange":"-0.11140464","baseVolume":"25.02305421","quoteVolume":"146999.50952728",
        /// "isFrozen":"0","high24hr":"0.00018692","low24hr":"0.00015012"} 
        /// 
        /// Si tu as vu mes commentaires plus haut, j'ai parlé de KeyValuePair
        /// 
        /// Ici <Key> c'est BTC_BBR et <Value> c'est tout le reste entre { }
        /// donc pour l'utiliser, faut faire "item.Key" pour avoir son nom, 
        /// et "item.Value.Champ" pour avoir le champ qui t'intéresse (Champ = lowestAsk par exemple)
        /// 
        /// Au final, cette fonction prend un objet json et le parse en objet PoloniexResult pour etre plus facile à manipuler
        /// </summary>
        public static PoloniexResult FromJSONDynamic(dynamic item)
        {
            // Sert à faire comprendre à cte connerie d'ordi que le séparateur de décimal c'est un point et pas une virgule *^ù*$ù*ù
            NumberFormatInfo numberFormatInfo = new NumberFormatInfo { NumberDecimalSeparator = "." };

            PoloniexResult pxRes = new PoloniexResult();
            pxRes.Coin = item.Key;
            pxRes.ID = item.Value.id;

            // Chaque valeur est récupérée en string, donc je la parse en decimal pour la récupérer et pouvoir la manipuler
            pxRes.Last = decimal.Parse(item.Value.last, numberFormatInfo);
            pxRes.LowestAsk = decimal.Parse(item.Value.lowestAsk, numberFormatInfo);
            pxRes.HighestBid = decimal.Parse(item.Value.highestBid, numberFormatInfo);
            pxRes.PercentChange = decimal.Parse(item.Value.percentChange, numberFormatInfo);
            pxRes.BaseVolume = decimal.Parse(item.Value.baseVolume, numberFormatInfo);
            pxRes.QuoteVolume = decimal.Parse(item.Value.quoteVolume, numberFormatInfo);
            pxRes.IsFrozen = int.Parse(item.Value.isFrozen, numberFormatInfo);
            pxRes.High24hr = decimal.Parse(item.Value.high24hr, numberFormatInfo);
            pxRes.Low24hr = decimal.Parse(item.Value.low24hr, numberFormatInfo);
            return pxRes;
        }
    }

    public class BetResult
    {
        public string Coin { get; set; }
        public int BetID { get; set; } = 0;
        public decimal Roll { get; set; } = 0;
        public bool UnderOver { get; set; } = true;
        public string ClientSeed { get; set; } = "";
        public string Target { get; set; } = "";
        public decimal Profit { get; set; } = 0;
        public string ServerSeed { get; set; } = "";
        public string NextServerSeedHash { get; set; } = "";

        public static BetResult FromJSONDynamic(dynamic json, string coin)
        {
            BetResult s = new BetResult();
            s.Coin = coin;
            s.BetID = json.BetID;
            s.Roll = json.Roll;
            s.UnderOver = json.UnderOver;
            s.ClientSeed = json.ClientSeed;
            s.Target = json.Target;
            s.Profit = json.Profit;
            s.ServerSeed = json.ServerSeed;
            s.NextServerSeedHash = json.NextServerSeedHash;
            return s;
        }

        public override string ToString()
        {
            string output = "Coin: " + this.Coin + "\r\n";
            output += "BetID: " + this.BetID + "\r\n";
            output += "Roll: " + this.Roll + "\r\n";
            output += "UnderOver: " + this.UnderOver + "\r\n";
            output += "Target: " + this.Target + "\r\n";
            output += "Profit: " + this.Profit;
            return output;
        }
    }
}
