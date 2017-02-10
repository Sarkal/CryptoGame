namespace CryptoGame
{
    partial class FormCrypto
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxAPI = new System.Windows.Forms.TextBox();
            this.buttonEditAPI = new System.Windows.Forms.Button();
            this.labelAPI = new System.Windows.Forms.Label();
            this.listBoxCoin = new System.Windows.Forms.ListBox();
            this.labelCoinInfo = new System.Windows.Forms.Label();
            this.buttonPoloniex = new System.Windows.Forms.Button();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.labelLOutput = new System.Windows.Forms.Label();
            this.buttonBet = new System.Windows.Forms.Button();
            this.buttonBalance = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonCoinStats = new System.Windows.Forms.Button();
            this.buttonBetSettings = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelBalance = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxUnderOver = new System.Windows.Forms.CheckBox();
            this.labelMinMaxPayout = new System.Windows.Forms.Label();
            this.numericUpDownPayout = new System.Windows.Forms.NumericUpDown();
            this.labelPayout = new System.Windows.Forms.Label();
            this.labelMinMaxBet = new System.Windows.Forms.Label();
            this.labelCoin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.numericUpDownBet = new System.Windows.Forms.NumericUpDown();
            this.labelInfo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBet)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxAPI
            // 
            this.textBoxAPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAPI.Location = new System.Drawing.Point(12, 25);
            this.textBoxAPI.Name = "textBoxAPI";
            this.textBoxAPI.ReadOnly = true;
            this.textBoxAPI.Size = new System.Drawing.Size(138, 21);
            this.textBoxAPI.TabIndex = 0;
            // 
            // buttonEditAPI
            // 
            this.buttonEditAPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditAPI.Location = new System.Drawing.Point(75, 1);
            this.buttonEditAPI.Name = "buttonEditAPI";
            this.buttonEditAPI.Size = new System.Drawing.Size(75, 23);
            this.buttonEditAPI.TabIndex = 1;
            this.buttonEditAPI.Text = "EDIT API";
            this.buttonEditAPI.UseVisualStyleBackColor = true;
            this.buttonEditAPI.Click += new System.EventHandler(this.buttonEditAPI_Click);
            // 
            // labelAPI
            // 
            this.labelAPI.AutoSize = true;
            this.labelAPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAPI.Location = new System.Drawing.Point(12, 9);
            this.labelAPI.Name = "labelAPI";
            this.labelAPI.Size = new System.Drawing.Size(48, 15);
            this.labelAPI.TabIndex = 2;
            this.labelAPI.Text = "API Key";
            // 
            // listBoxCoin
            // 
            this.listBoxCoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCoin.FormattingEnabled = true;
            this.listBoxCoin.ItemHeight = 15;
            this.listBoxCoin.Items.AddRange(new object[] {
            "BTC",
            "DOGE"});
            this.listBoxCoin.Location = new System.Drawing.Point(12, 68);
            this.listBoxCoin.Name = "listBoxCoin";
            this.listBoxCoin.Size = new System.Drawing.Size(152, 49);
            this.listBoxCoin.TabIndex = 5;
            this.listBoxCoin.SelectedIndexChanged += new System.EventHandler(this.listBoxCoin_SelectedIndexChanged);
            // 
            // labelCoinInfo
            // 
            this.labelCoinInfo.AutoSize = true;
            this.labelCoinInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoinInfo.Location = new System.Drawing.Point(12, 52);
            this.labelCoinInfo.Name = "labelCoinInfo";
            this.labelCoinInfo.Size = new System.Drawing.Size(32, 15);
            this.labelCoinInfo.TabIndex = 6;
            this.labelCoinInfo.Text = "Coin";
            // 
            // buttonPoloniex
            // 
            this.buttonPoloniex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPoloniex.Location = new System.Drawing.Point(217, 34);
            this.buttonPoloniex.Name = "buttonPoloniex";
            this.buttonPoloniex.Size = new System.Drawing.Size(103, 50);
            this.buttonPoloniex.TabIndex = 7;
            this.buttonPoloniex.Text = "POLONIEX";
            this.buttonPoloniex.UseVisualStyleBackColor = true;
            this.buttonPoloniex.Click += new System.EventHandler(this.buttonPoloniex_Click);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOutput.Location = new System.Drawing.Point(352, 25);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput.Size = new System.Drawing.Size(372, 216);
            this.textBoxOutput.TabIndex = 8;
            // 
            // labelLOutput
            // 
            this.labelLOutput.AutoSize = true;
            this.labelLOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLOutput.Location = new System.Drawing.Point(349, 5);
            this.labelLOutput.Name = "labelLOutput";
            this.labelLOutput.Size = new System.Drawing.Size(43, 15);
            this.labelLOutput.TabIndex = 9;
            this.labelLOutput.Text = "Output";
            // 
            // buttonBet
            // 
            this.buttonBet.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBet.Location = new System.Drawing.Point(3, 161);
            this.buttonBet.Name = "buttonBet";
            this.buttonBet.Size = new System.Drawing.Size(328, 50);
            this.buttonBet.TabIndex = 10;
            this.buttonBet.Text = "PLACE BET";
            this.buttonBet.UseVisualStyleBackColor = true;
            this.buttonBet.Click += new System.EventHandler(this.buttonBet_Click);
            // 
            // buttonBalance
            // 
            this.buttonBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBalance.Location = new System.Drawing.Point(6, 19);
            this.buttonBalance.Name = "buttonBalance";
            this.buttonBalance.Size = new System.Drawing.Size(103, 50);
            this.buttonBalance.TabIndex = 11;
            this.buttonBalance.Text = "COIN BALANCE";
            this.buttonBalance.UseVisualStyleBackColor = true;
            this.buttonBalance.Click += new System.EventHandler(this.buttonBalance_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCoinStats);
            this.groupBox1.Controls.Add(this.buttonBetSettings);
            this.groupBox1.Controls.Add(this.buttonBalance);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 82);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Coin Info";
            // 
            // buttonCoinStats
            // 
            this.buttonCoinStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCoinStats.Location = new System.Drawing.Point(224, 19);
            this.buttonCoinStats.Name = "buttonCoinStats";
            this.buttonCoinStats.Size = new System.Drawing.Size(103, 50);
            this.buttonCoinStats.TabIndex = 13;
            this.buttonCoinStats.Text = "COIN STATS";
            this.buttonCoinStats.UseVisualStyleBackColor = true;
            this.buttonCoinStats.Click += new System.EventHandler(this.buttonCoinStats_Click);
            // 
            // buttonBetSettings
            // 
            this.buttonBetSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBetSettings.Location = new System.Drawing.Point(115, 19);
            this.buttonBetSettings.Name = "buttonBetSettings";
            this.buttonBetSettings.Size = new System.Drawing.Size(103, 50);
            this.buttonBetSettings.TabIndex = 12;
            this.buttonBetSettings.Text = "COIN BET SETTINGS";
            this.buttonBetSettings.UseVisualStyleBackColor = true;
            this.buttonBetSettings.Click += new System.EventHandler(this.buttonBetSettings_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.labelBalance);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.checkBoxUnderOver);
            this.groupBox2.Controls.Add(this.labelMinMaxPayout);
            this.groupBox2.Controls.Add(this.numericUpDownPayout);
            this.groupBox2.Controls.Add(this.labelPayout);
            this.groupBox2.Controls.Add(this.labelMinMaxBet);
            this.groupBox2.Controls.Add(this.labelCoin);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.labelAmount);
            this.groupBox2.Controls.Add(this.numericUpDownBet);
            this.groupBox2.Controls.Add(this.buttonBet);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 214);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Place Bet";
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBalance.Location = new System.Drawing.Point(202, 22);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(40, 18);
            this.labelBalance.TabIndex = 24;
            this.labelBalance.Text = "0,00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(138, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Balance :";
            // 
            // checkBoxUnderOver
            // 
            this.checkBoxUnderOver.AutoSize = true;
            this.checkBoxUnderOver.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxUnderOver.Checked = true;
            this.checkBoxUnderOver.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxUnderOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxUnderOver.Location = new System.Drawing.Point(6, 135);
            this.checkBoxUnderOver.Name = "checkBoxUnderOver";
            this.checkBoxUnderOver.Size = new System.Drawing.Size(88, 19);
            this.checkBoxUnderOver.TabIndex = 22;
            this.checkBoxUnderOver.Text = "Over target ";
            this.checkBoxUnderOver.UseVisualStyleBackColor = true;
            // 
            // labelMinMaxPayout
            // 
            this.labelMinMaxPayout.AutoSize = true;
            this.labelMinMaxPayout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinMaxPayout.Location = new System.Drawing.Point(6, 117);
            this.labelMinMaxPayout.Name = "labelMinMaxPayout";
            this.labelMinMaxPayout.Size = new System.Drawing.Size(60, 15);
            this.labelMinMaxPayout.TabIndex = 20;
            this.labelMinMaxPayout.Text = "(1 - 1000)";
            // 
            // numericUpDownPayout
            // 
            this.numericUpDownPayout.DecimalPlaces = 2;
            this.numericUpDownPayout.Location = new System.Drawing.Point(63, 93);
            this.numericUpDownPayout.Name = "numericUpDownPayout";
            this.numericUpDownPayout.Size = new System.Drawing.Size(189, 24);
            this.numericUpDownPayout.TabIndex = 19;
            this.numericUpDownPayout.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownPayout.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // labelPayout
            // 
            this.labelPayout.AutoSize = true;
            this.labelPayout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPayout.Location = new System.Drawing.Point(6, 95);
            this.labelPayout.Name = "labelPayout";
            this.labelPayout.Size = new System.Drawing.Size(50, 15);
            this.labelPayout.TabIndex = 18;
            this.labelPayout.Text = "Payout :";
            // 
            // labelMinMaxBet
            // 
            this.labelMinMaxBet.AutoSize = true;
            this.labelMinMaxBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinMaxBet.Location = new System.Drawing.Point(6, 70);
            this.labelMinMaxBet.Name = "labelMinMaxBet";
            this.labelMinMaxBet.Size = new System.Drawing.Size(60, 15);
            this.labelMinMaxBet.TabIndex = 17;
            this.labelMinMaxBet.Text = "(1 - 1000)";
            // 
            // labelCoin
            // 
            this.labelCoin.AutoSize = true;
            this.labelCoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoin.Location = new System.Drawing.Point(60, 22);
            this.labelCoin.Name = "labelCoin";
            this.labelCoin.Size = new System.Drawing.Size(43, 18);
            this.labelCoin.TabIndex = 16;
            this.labelCoin.Text = "Coin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Coin :";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmount.Location = new System.Drawing.Point(6, 49);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(31, 15);
            this.labelAmount.TabIndex = 14;
            this.labelAmount.Text = "Bet :";
            // 
            // numericUpDownBet
            // 
            this.numericUpDownBet.DecimalPlaces = 8;
            this.numericUpDownBet.Location = new System.Drawing.Point(63, 45);
            this.numericUpDownBet.Name = "numericUpDownBet";
            this.numericUpDownBet.Size = new System.Drawing.Size(189, 24);
            this.numericUpDownBet.TabIndex = 11;
            this.numericUpDownBet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.Location = new System.Drawing.Point(349, 244);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(48, 15);
            this.labelInfo.TabIndex = 15;
            this.labelInfo.Text = "Info Bet";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(349, 262);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(372, 166);
            this.textBox1.TabIndex = 14;
            // 
            // FormCrypto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 440);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelLOutput);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.buttonPoloniex);
            this.Controls.Add(this.labelCoinInfo);
            this.Controls.Add(this.listBoxCoin);
            this.Controls.Add(this.labelAPI);
            this.Controls.Add(this.buttonEditAPI);
            this.Controls.Add(this.textBoxAPI);
            this.Name = "FormCrypto";
            this.Text = "CryptoGame";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAPI;
        private System.Windows.Forms.Button buttonEditAPI;
        private System.Windows.Forms.Label labelAPI;
        private System.Windows.Forms.ListBox listBoxCoin;
        private System.Windows.Forms.Label labelCoinInfo;
        private System.Windows.Forms.Button buttonPoloniex;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Label labelLOutput;
        private System.Windows.Forms.Button buttonBet;
        private System.Windows.Forms.Button buttonBalance;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonCoinStats;
        private System.Windows.Forms.Button buttonBetSettings;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.NumericUpDown numericUpDownBet;
        private System.Windows.Forms.CheckBox checkBoxUnderOver;
        private System.Windows.Forms.Label labelMinMaxPayout;
        private System.Windows.Forms.NumericUpDown numericUpDownPayout;
        private System.Windows.Forms.Label labelPayout;
        private System.Windows.Forms.Label labelMinMaxBet;
        private System.Windows.Forms.Label labelCoin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.TextBox textBox1;
    }
}

