﻿namespace Tree_Logger_CSharp
{
    partial class TreeLogger
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnTree = new System.Windows.Forms.Button();
            this.lblLogsInfo = new System.Windows.Forms.Label();
            this.tmrLPS = new System.Windows.Forms.Timer(this.components);
            this.btnBuyClicker = new System.Windows.Forms.Button();
            this.btnSellClicker = new System.Windows.Forms.Button();
            this.lblClickerInfo = new System.Windows.Forms.Label();
            this.btnBuyLumberjack = new System.Windows.Forms.Button();
            this.btnSellLumberjack = new System.Windows.Forms.Button();
            this.lblLumberjackInfo = new System.Windows.Forms.Label();
            this.btnBuyLumberYard = new System.Windows.Forms.Button();
            this.btnSellLumberYard = new System.Windows.Forms.Button();
            this.lblLumberYardInfo = new System.Windows.Forms.Label();
            this.btnBuySawmill = new System.Windows.Forms.Button();
            this.btnSellSawmill = new System.Windows.Forms.Button();
            this.lblSawmillInfo = new System.Windows.Forms.Label();
            this.btnBuyForest = new System.Windows.Forms.Button();
            this.btnSellForest = new System.Windows.Forms.Button();
            this.lblForestInfo = new System.Windows.Forms.Label();
            this.btnBuyShipment = new System.Windows.Forms.Button();
            this.btnSellShipment = new System.Windows.Forms.Button();
            this.lblShipmentInfo = new System.Windows.Forms.Label();
            this.lblAlchemyLabInfo = new System.Windows.Forms.Label();
            this.btnSellAlchemyLab = new System.Windows.Forms.Button();
            this.btnBuyAlchemyLab = new System.Windows.Forms.Button();
            this.btnBuyPortal = new System.Windows.Forms.Button();
            this.btnSellPortal = new System.Windows.Forms.Button();
            this.lblPortalInfo = new System.Windows.Forms.Label();
            this.btnBuyExtractor = new System.Windows.Forms.Button();
            this.btnSellExtractor = new System.Windows.Forms.Button();
            this.lblExtractorInfo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuyBuildings = new System.Windows.Forms.Button();
            this.tmrAutoSave = new System.Windows.Forms.Timer(this.components);
            this.lblSaved = new System.Windows.Forms.Label();
            this.btnOption = new System.Windows.Forms.Button();
            this.pOptionsPanel = new System.Windows.Forms.Panel();
            this.btnManualSave = new System.Windows.Forms.Button();
            this.btnResetSave = new System.Windows.Forms.Button();
            this.btnBuyCondenser = new System.Windows.Forms.Button();
            this.btnSellCondenser = new System.Windows.Forms.Button();
            this.lblCondenserInfo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pOptionsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTree
            // 
            this.btnTree.BackColor = System.Drawing.Color.BurlyWood;
            this.btnTree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTree.Location = new System.Drawing.Point(2, 44);
            this.btnTree.Name = "btnTree";
            this.btnTree.Size = new System.Drawing.Size(100, 67);
            this.btnTree.TabIndex = 0;
            this.btnTree.TabStop = false;
            this.btnTree.Text = "Cut Tree!";
            this.btnTree.UseVisualStyleBackColor = false;
            this.btnTree.Click += new System.EventHandler(this.btnTree_Click);
            // 
            // lblLogsInfo
            // 
            this.lblLogsInfo.AutoSize = true;
            this.lblLogsInfo.Location = new System.Drawing.Point(-2, 2);
            this.lblLogsInfo.Name = "lblLogsInfo";
            this.lblLogsInfo.Size = new System.Drawing.Size(26, 39);
            this.lblLogsInfo.TabIndex = 1;
            this.lblLogsInfo.Text = "Res\r\nRes\r\nRes";
            // 
            // tmrLPS
            // 
            this.tmrLPS.Enabled = true;
            this.tmrLPS.Interval = 50;
            this.tmrLPS.Tick += new System.EventHandler(this.tmrLPS_Tick);
            // 
            // btnBuyClicker
            // 
            this.btnBuyClicker.BackColor = System.Drawing.Color.BurlyWood;
            this.btnBuyClicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuyClicker.Location = new System.Drawing.Point(3, 3);
            this.btnBuyClicker.Name = "btnBuyClicker";
            this.btnBuyClicker.Size = new System.Drawing.Size(99, 23);
            this.btnBuyClicker.TabIndex = 7;
            this.btnBuyClicker.TabStop = false;
            this.btnBuyClicker.Text = "Buy Clicker";
            this.btnBuyClicker.UseVisualStyleBackColor = false;
            this.btnBuyClicker.Click += new System.EventHandler(this.btnBuyClicker_Click);
            // 
            // btnSellClicker
            // 
            this.btnSellClicker.BackColor = System.Drawing.Color.BurlyWood;
            this.btnSellClicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSellClicker.Location = new System.Drawing.Point(101, 3);
            this.btnSellClicker.Name = "btnSellClicker";
            this.btnSellClicker.Size = new System.Drawing.Size(99, 23);
            this.btnSellClicker.TabIndex = 8;
            this.btnSellClicker.TabStop = false;
            this.btnSellClicker.Text = "Sell Clicker";
            this.btnSellClicker.UseVisualStyleBackColor = false;
            this.btnSellClicker.Click += new System.EventHandler(this.btnSellClicker_Click);
            // 
            // lblClickerInfo
            // 
            this.lblClickerInfo.AutoSize = true;
            this.lblClickerInfo.Location = new System.Drawing.Point(0, 29);
            this.lblClickerInfo.Name = "lblClickerInfo";
            this.lblClickerInfo.Size = new System.Drawing.Size(26, 26);
            this.lblClickerInfo.TabIndex = 9;
            this.lblClickerInfo.Text = "Res\r\nRes";
            // 
            // btnBuyLumberjack
            // 
            this.btnBuyLumberjack.BackColor = System.Drawing.Color.BurlyWood;
            this.btnBuyLumberjack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuyLumberjack.Location = new System.Drawing.Point(3, 58);
            this.btnBuyLumberjack.Name = "btnBuyLumberjack";
            this.btnBuyLumberjack.Size = new System.Drawing.Size(99, 23);
            this.btnBuyLumberjack.TabIndex = 10;
            this.btnBuyLumberjack.TabStop = false;
            this.btnBuyLumberjack.Text = "Buy Lumberjack";
            this.btnBuyLumberjack.UseVisualStyleBackColor = false;
            this.btnBuyLumberjack.Click += new System.EventHandler(this.btnBuyLumberjack_Click);
            // 
            // btnSellLumberjack
            // 
            this.btnSellLumberjack.BackColor = System.Drawing.Color.BurlyWood;
            this.btnSellLumberjack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSellLumberjack.Location = new System.Drawing.Point(101, 58);
            this.btnSellLumberjack.Name = "btnSellLumberjack";
            this.btnSellLumberjack.Size = new System.Drawing.Size(99, 23);
            this.btnSellLumberjack.TabIndex = 11;
            this.btnSellLumberjack.TabStop = false;
            this.btnSellLumberjack.Text = "Sell Lumberjack";
            this.btnSellLumberjack.UseVisualStyleBackColor = false;
            this.btnSellLumberjack.Click += new System.EventHandler(this.btnSellLumberjack_Click);
            // 
            // lblLumberjackInfo
            // 
            this.lblLumberjackInfo.AutoSize = true;
            this.lblLumberjackInfo.Location = new System.Drawing.Point(0, 83);
            this.lblLumberjackInfo.Name = "lblLumberjackInfo";
            this.lblLumberjackInfo.Size = new System.Drawing.Size(26, 26);
            this.lblLumberjackInfo.TabIndex = 12;
            this.lblLumberjackInfo.Text = "Res\r\nRes\r\n";
            // 
            // btnBuyLumberYard
            // 
            this.btnBuyLumberYard.BackColor = System.Drawing.Color.BurlyWood;
            this.btnBuyLumberYard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuyLumberYard.Location = new System.Drawing.Point(3, 114);
            this.btnBuyLumberYard.Name = "btnBuyLumberYard";
            this.btnBuyLumberYard.Size = new System.Drawing.Size(99, 23);
            this.btnBuyLumberYard.TabIndex = 14;
            this.btnBuyLumberYard.TabStop = false;
            this.btnBuyLumberYard.Text = "Buy Lumber Yard";
            this.btnBuyLumberYard.UseVisualStyleBackColor = false;
            this.btnBuyLumberYard.Click += new System.EventHandler(this.btnBuyLumberYard_Click);
            // 
            // btnSellLumberYard
            // 
            this.btnSellLumberYard.BackColor = System.Drawing.Color.BurlyWood;
            this.btnSellLumberYard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSellLumberYard.Location = new System.Drawing.Point(101, 114);
            this.btnSellLumberYard.Name = "btnSellLumberYard";
            this.btnSellLumberYard.Size = new System.Drawing.Size(99, 23);
            this.btnSellLumberYard.TabIndex = 15;
            this.btnSellLumberYard.TabStop = false;
            this.btnSellLumberYard.Text = "Sell Lumber Yard";
            this.btnSellLumberYard.UseVisualStyleBackColor = false;
            this.btnSellLumberYard.Click += new System.EventHandler(this.btnSellLumberYard_Click);
            // 
            // lblLumberYardInfo
            // 
            this.lblLumberYardInfo.AutoSize = true;
            this.lblLumberYardInfo.Location = new System.Drawing.Point(0, 139);
            this.lblLumberYardInfo.Name = "lblLumberYardInfo";
            this.lblLumberYardInfo.Size = new System.Drawing.Size(26, 26);
            this.lblLumberYardInfo.TabIndex = 16;
            this.lblLumberYardInfo.Text = "Res\r\nRes";
            // 
            // btnBuySawmill
            // 
            this.btnBuySawmill.BackColor = System.Drawing.Color.BurlyWood;
            this.btnBuySawmill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuySawmill.Location = new System.Drawing.Point(3, 167);
            this.btnBuySawmill.Name = "btnBuySawmill";
            this.btnBuySawmill.Size = new System.Drawing.Size(99, 23);
            this.btnBuySawmill.TabIndex = 17;
            this.btnBuySawmill.TabStop = false;
            this.btnBuySawmill.Text = "Buy Sawmill";
            this.btnBuySawmill.UseVisualStyleBackColor = false;
            this.btnBuySawmill.Click += new System.EventHandler(this.btnBuySawmill_Click);
            // 
            // btnSellSawmill
            // 
            this.btnSellSawmill.BackColor = System.Drawing.Color.BurlyWood;
            this.btnSellSawmill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSellSawmill.Location = new System.Drawing.Point(101, 167);
            this.btnSellSawmill.Name = "btnSellSawmill";
            this.btnSellSawmill.Size = new System.Drawing.Size(99, 23);
            this.btnSellSawmill.TabIndex = 18;
            this.btnSellSawmill.TabStop = false;
            this.btnSellSawmill.Text = "Sell Sawmill";
            this.btnSellSawmill.UseVisualStyleBackColor = false;
            this.btnSellSawmill.Click += new System.EventHandler(this.btnSellSawmill_Click);
            // 
            // lblSawmillInfo
            // 
            this.lblSawmillInfo.AutoSize = true;
            this.lblSawmillInfo.Location = new System.Drawing.Point(0, 192);
            this.lblSawmillInfo.Name = "lblSawmillInfo";
            this.lblSawmillInfo.Size = new System.Drawing.Size(26, 26);
            this.lblSawmillInfo.TabIndex = 19;
            this.lblSawmillInfo.Text = "Res\r\nRes";
            // 
            // btnBuyForest
            // 
            this.btnBuyForest.BackColor = System.Drawing.Color.BurlyWood;
            this.btnBuyForest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuyForest.Location = new System.Drawing.Point(3, 222);
            this.btnBuyForest.Name = "btnBuyForest";
            this.btnBuyForest.Size = new System.Drawing.Size(99, 23);
            this.btnBuyForest.TabIndex = 20;
            this.btnBuyForest.TabStop = false;
            this.btnBuyForest.Text = "Buy Forest";
            this.btnBuyForest.UseVisualStyleBackColor = false;
            this.btnBuyForest.Click += new System.EventHandler(this.btnBuyForest_Click);
            // 
            // btnSellForest
            // 
            this.btnSellForest.BackColor = System.Drawing.Color.BurlyWood;
            this.btnSellForest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSellForest.Location = new System.Drawing.Point(101, 222);
            this.btnSellForest.Name = "btnSellForest";
            this.btnSellForest.Size = new System.Drawing.Size(99, 23);
            this.btnSellForest.TabIndex = 21;
            this.btnSellForest.TabStop = false;
            this.btnSellForest.Text = "Sell Forest";
            this.btnSellForest.UseVisualStyleBackColor = false;
            this.btnSellForest.Click += new System.EventHandler(this.btnSellForest_Click);
            // 
            // lblForestInfo
            // 
            this.lblForestInfo.AutoSize = true;
            this.lblForestInfo.Location = new System.Drawing.Point(0, 247);
            this.lblForestInfo.Name = "lblForestInfo";
            this.lblForestInfo.Size = new System.Drawing.Size(26, 26);
            this.lblForestInfo.TabIndex = 22;
            this.lblForestInfo.Text = "Res\r\nRes";
            // 
            // btnBuyShipment
            // 
            this.btnBuyShipment.BackColor = System.Drawing.Color.BurlyWood;
            this.btnBuyShipment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuyShipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuyShipment.Location = new System.Drawing.Point(3, 277);
            this.btnBuyShipment.Name = "btnBuyShipment";
            this.btnBuyShipment.Size = new System.Drawing.Size(99, 23);
            this.btnBuyShipment.TabIndex = 23;
            this.btnBuyShipment.TabStop = false;
            this.btnBuyShipment.Text = "Buy Shipment";
            this.btnBuyShipment.UseVisualStyleBackColor = false;
            this.btnBuyShipment.Click += new System.EventHandler(this.btnBuyShipment_Click);
            // 
            // btnSellShipment
            // 
            this.btnSellShipment.BackColor = System.Drawing.Color.BurlyWood;
            this.btnSellShipment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSellShipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellShipment.Location = new System.Drawing.Point(101, 277);
            this.btnSellShipment.Name = "btnSellShipment";
            this.btnSellShipment.Size = new System.Drawing.Size(99, 23);
            this.btnSellShipment.TabIndex = 24;
            this.btnSellShipment.TabStop = false;
            this.btnSellShipment.Text = "Sell Shipment";
            this.btnSellShipment.UseVisualStyleBackColor = false;
            this.btnSellShipment.Click += new System.EventHandler(this.btnSellShipment_Click);
            // 
            // lblShipmentInfo
            // 
            this.lblShipmentInfo.AutoSize = true;
            this.lblShipmentInfo.Location = new System.Drawing.Point(0, 302);
            this.lblShipmentInfo.Name = "lblShipmentInfo";
            this.lblShipmentInfo.Size = new System.Drawing.Size(26, 26);
            this.lblShipmentInfo.TabIndex = 25;
            this.lblShipmentInfo.Text = "Res\r\nRes";
            // 
            // lblAlchemyLabInfo
            // 
            this.lblAlchemyLabInfo.AutoSize = true;
            this.lblAlchemyLabInfo.Location = new System.Drawing.Point(0, 357);
            this.lblAlchemyLabInfo.Name = "lblAlchemyLabInfo";
            this.lblAlchemyLabInfo.Size = new System.Drawing.Size(26, 26);
            this.lblAlchemyLabInfo.TabIndex = 29;
            this.lblAlchemyLabInfo.Text = "Res\r\nRes";
            // 
            // btnSellAlchemyLab
            // 
            this.btnSellAlchemyLab.BackColor = System.Drawing.Color.BurlyWood;
            this.btnSellAlchemyLab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSellAlchemyLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellAlchemyLab.Location = new System.Drawing.Point(101, 331);
            this.btnSellAlchemyLab.Name = "btnSellAlchemyLab";
            this.btnSellAlchemyLab.Size = new System.Drawing.Size(99, 23);
            this.btnSellAlchemyLab.TabIndex = 28;
            this.btnSellAlchemyLab.TabStop = false;
            this.btnSellAlchemyLab.Text = "Sell Alchemy Lab";
            this.btnSellAlchemyLab.UseVisualStyleBackColor = false;
            this.btnSellAlchemyLab.Click += new System.EventHandler(this.btnSellAlchemyLab_Click);
            // 
            // btnBuyAlchemyLab
            // 
            this.btnBuyAlchemyLab.BackColor = System.Drawing.Color.BurlyWood;
            this.btnBuyAlchemyLab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuyAlchemyLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuyAlchemyLab.Location = new System.Drawing.Point(3, 331);
            this.btnBuyAlchemyLab.Name = "btnBuyAlchemyLab";
            this.btnBuyAlchemyLab.Size = new System.Drawing.Size(99, 23);
            this.btnBuyAlchemyLab.TabIndex = 27;
            this.btnBuyAlchemyLab.TabStop = false;
            this.btnBuyAlchemyLab.Text = "Buy Alchemy Lab";
            this.btnBuyAlchemyLab.UseVisualStyleBackColor = false;
            this.btnBuyAlchemyLab.Click += new System.EventHandler(this.btnBuyAlchemyLab_Click);
            // 
            // btnBuyPortal
            // 
            this.btnBuyPortal.BackColor = System.Drawing.Color.BurlyWood;
            this.btnBuyPortal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuyPortal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuyPortal.Location = new System.Drawing.Point(3, 386);
            this.btnBuyPortal.Name = "btnBuyPortal";
            this.btnBuyPortal.Size = new System.Drawing.Size(99, 23);
            this.btnBuyPortal.TabIndex = 30;
            this.btnBuyPortal.TabStop = false;
            this.btnBuyPortal.Text = "Buy Portal";
            this.btnBuyPortal.UseVisualStyleBackColor = false;
            this.btnBuyPortal.Click += new System.EventHandler(this.btnBuyPortal_Click);
            // 
            // btnSellPortal
            // 
            this.btnSellPortal.BackColor = System.Drawing.Color.BurlyWood;
            this.btnSellPortal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSellPortal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellPortal.Location = new System.Drawing.Point(101, 386);
            this.btnSellPortal.Name = "btnSellPortal";
            this.btnSellPortal.Size = new System.Drawing.Size(99, 23);
            this.btnSellPortal.TabIndex = 31;
            this.btnSellPortal.TabStop = false;
            this.btnSellPortal.Text = "Sell Portal";
            this.btnSellPortal.UseVisualStyleBackColor = false;
            this.btnSellPortal.Click += new System.EventHandler(this.btnSellPortal_Click);
            // 
            // lblPortalInfo
            // 
            this.lblPortalInfo.AutoSize = true;
            this.lblPortalInfo.Location = new System.Drawing.Point(0, 412);
            this.lblPortalInfo.Name = "lblPortalInfo";
            this.lblPortalInfo.Size = new System.Drawing.Size(26, 26);
            this.lblPortalInfo.TabIndex = 32;
            this.lblPortalInfo.Text = "Res\r\nRes";
            // 
            // btnBuyExtractor
            // 
            this.btnBuyExtractor.BackColor = System.Drawing.Color.BurlyWood;
            this.btnBuyExtractor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuyExtractor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuyExtractor.Location = new System.Drawing.Point(3, 441);
            this.btnBuyExtractor.Name = "btnBuyExtractor";
            this.btnBuyExtractor.Size = new System.Drawing.Size(99, 23);
            this.btnBuyExtractor.TabIndex = 33;
            this.btnBuyExtractor.TabStop = false;
            this.btnBuyExtractor.Text = "Buy Extractor";
            this.btnBuyExtractor.UseVisualStyleBackColor = false;
            this.btnBuyExtractor.Click += new System.EventHandler(this.btnBuyExtractor_Click);
            // 
            // btnSellExtractor
            // 
            this.btnSellExtractor.BackColor = System.Drawing.Color.BurlyWood;
            this.btnSellExtractor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSellExtractor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellExtractor.Location = new System.Drawing.Point(101, 441);
            this.btnSellExtractor.Name = "btnSellExtractor";
            this.btnSellExtractor.Size = new System.Drawing.Size(99, 23);
            this.btnSellExtractor.TabIndex = 34;
            this.btnSellExtractor.TabStop = false;
            this.btnSellExtractor.Text = "Sell Extractor";
            this.btnSellExtractor.UseVisualStyleBackColor = false;
            this.btnSellExtractor.Click += new System.EventHandler(this.btnSellExtractor_Click);
            // 
            // lblExtractorInfo
            // 
            this.lblExtractorInfo.AutoSize = true;
            this.lblExtractorInfo.Location = new System.Drawing.Point(0, 467);
            this.lblExtractorInfo.Name = "lblExtractorInfo";
            this.lblExtractorInfo.Size = new System.Drawing.Size(26, 26);
            this.lblExtractorInfo.TabIndex = 35;
            this.lblExtractorInfo.Text = "Res\r\nRes";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.lblCondenserInfo);
            this.panel1.Controls.Add(this.lblClickerInfo);
            this.panel1.Controls.Add(this.btnSellCondenser);
            this.panel1.Controls.Add(this.btnBuyClicker);
            this.panel1.Controls.Add(this.btnBuyCondenser);
            this.panel1.Controls.Add(this.btnSellForest);
            this.panel1.Controls.Add(this.lblExtractorInfo);
            this.panel1.Controls.Add(this.btnBuyForest);
            this.panel1.Controls.Add(this.btnSellExtractor);
            this.panel1.Controls.Add(this.lblForestInfo);
            this.panel1.Controls.Add(this.btnBuyExtractor);
            this.panel1.Controls.Add(this.btnBuyShipment);
            this.panel1.Controls.Add(this.lblPortalInfo);
            this.panel1.Controls.Add(this.btnBuySawmill);
            this.panel1.Controls.Add(this.btnSellPortal);
            this.panel1.Controls.Add(this.btnSellShipment);
            this.panel1.Controls.Add(this.btnBuyPortal);
            this.panel1.Controls.Add(this.lblLumberYardInfo);
            this.panel1.Controls.Add(this.btnSellSawmill);
            this.panel1.Controls.Add(this.btnSellClicker);
            this.panel1.Controls.Add(this.btnBuyAlchemyLab);
            this.panel1.Controls.Add(this.lblAlchemyLabInfo);
            this.panel1.Controls.Add(this.btnSellLumberYard);
            this.panel1.Controls.Add(this.lblSawmillInfo);
            this.panel1.Controls.Add(this.btnBuyLumberjack);
            this.panel1.Controls.Add(this.lblShipmentInfo);
            this.panel1.Controls.Add(this.btnSellLumberjack);
            this.panel1.Controls.Add(this.btnBuyLumberYard);
            this.panel1.Controls.Add(this.btnSellAlchemyLab);
            this.panel1.Controls.Add(this.lblLumberjackInfo);
            this.panel1.Location = new System.Drawing.Point(253, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 222);
            this.panel1.TabIndex = 36;
            // 
            // btnBuyBuildings
            // 
            this.btnBuyBuildings.BackColor = System.Drawing.Color.BurlyWood;
            this.btnBuyBuildings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuyBuildings.Location = new System.Drawing.Point(2, 110);
            this.btnBuyBuildings.Name = "btnBuyBuildings";
            this.btnBuyBuildings.Size = new System.Drawing.Size(100, 24);
            this.btnBuyBuildings.TabIndex = 37;
            this.btnBuyBuildings.TabStop = false;
            this.btnBuyBuildings.Text = "Buy Buildings";
            this.btnBuyBuildings.UseVisualStyleBackColor = false;
            this.btnBuyBuildings.Click += new System.EventHandler(this.btnBuyBuildings_Click);
            // 
            // tmrAutoSave
            // 
            this.tmrAutoSave.Enabled = true;
            this.tmrAutoSave.Interval = 1000;
            this.tmrAutoSave.Tick += new System.EventHandler(this.tmrAutoSave_Tick);
            // 
            // lblSaved
            // 
            this.lblSaved.AutoSize = true;
            this.lblSaved.Location = new System.Drawing.Point(97, 208);
            this.lblSaved.Name = "lblSaved";
            this.lblSaved.Size = new System.Drawing.Size(61, 13);
            this.lblSaved.TabIndex = 38;
            this.lblSaved.Text = "Autosaved!";
            this.lblSaved.Visible = false;
            // 
            // btnOption
            // 
            this.btnOption.BackColor = System.Drawing.Color.BurlyWood;
            this.btnOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOption.Location = new System.Drawing.Point(2, 132);
            this.btnOption.Name = "btnOption";
            this.btnOption.Size = new System.Drawing.Size(100, 23);
            this.btnOption.TabIndex = 39;
            this.btnOption.TabStop = false;
            this.btnOption.Text = "Options";
            this.btnOption.UseVisualStyleBackColor = false;
            this.btnOption.Click += new System.EventHandler(this.btnOption_Click);
            // 
            // pOptionsPanel
            // 
            this.pOptionsPanel.Controls.Add(this.btnManualSave);
            this.pOptionsPanel.Controls.Add(this.btnResetSave);
            this.pOptionsPanel.Location = new System.Drawing.Point(2, 155);
            this.pOptionsPanel.Name = "pOptionsPanel";
            this.pOptionsPanel.Size = new System.Drawing.Size(77, 48);
            this.pOptionsPanel.TabIndex = 40;
            this.pOptionsPanel.Visible = false;
            // 
            // btnManualSave
            // 
            this.btnManualSave.Location = new System.Drawing.Point(-1, 23);
            this.btnManualSave.Name = "btnManualSave";
            this.btnManualSave.Size = new System.Drawing.Size(78, 23);
            this.btnManualSave.TabIndex = 1;
            this.btnManualSave.Text = "Manual Save";
            this.btnManualSave.UseVisualStyleBackColor = true;
            this.btnManualSave.Click += new System.EventHandler(this.btnManualSave_Click);
            // 
            // btnResetSave
            // 
            this.btnResetSave.Location = new System.Drawing.Point(-1, 0);
            this.btnResetSave.Name = "btnResetSave";
            this.btnResetSave.Size = new System.Drawing.Size(78, 23);
            this.btnResetSave.TabIndex = 0;
            this.btnResetSave.Text = "Reset Save";
            this.btnResetSave.UseVisualStyleBackColor = true;
            this.btnResetSave.Click += new System.EventHandler(this.btnResetSave_Click);
            // 
            // btnBuyCondenser
            // 
            this.btnBuyCondenser.BackColor = System.Drawing.Color.BurlyWood;
            this.btnBuyCondenser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuyCondenser.Location = new System.Drawing.Point(3, 496);
            this.btnBuyCondenser.Name = "btnBuyCondenser";
            this.btnBuyCondenser.Size = new System.Drawing.Size(99, 23);
            this.btnBuyCondenser.TabIndex = 41;
            this.btnBuyCondenser.TabStop = false;
            this.btnBuyCondenser.Text = "Buy Condenser";
            this.btnBuyCondenser.UseVisualStyleBackColor = false;
            this.btnBuyCondenser.Click += new System.EventHandler(this.btnBuyCondenser_Click);
            // 
            // btnSellCondenser
            // 
            this.btnSellCondenser.BackColor = System.Drawing.Color.BurlyWood;
            this.btnSellCondenser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSellCondenser.Location = new System.Drawing.Point(101, 496);
            this.btnSellCondenser.Name = "btnSellCondenser";
            this.btnSellCondenser.Size = new System.Drawing.Size(99, 23);
            this.btnSellCondenser.TabIndex = 42;
            this.btnSellCondenser.TabStop = false;
            this.btnSellCondenser.Text = "Sell Condenser";
            this.btnSellCondenser.UseVisualStyleBackColor = false;
            this.btnSellCondenser.Click += new System.EventHandler(this.btnSellCondenser_Click);
            // 
            // lblCondenserInfo
            // 
            this.lblCondenserInfo.AutoSize = true;
            this.lblCondenserInfo.Location = new System.Drawing.Point(0, 522);
            this.lblCondenserInfo.Name = "lblCondenserInfo";
            this.lblCondenserInfo.Size = new System.Drawing.Size(26, 26);
            this.lblCondenserInfo.TabIndex = 43;
            this.lblCondenserInfo.Text = "Res\r\nRes";
            // 
            // TreeLogger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 227);
            this.Controls.Add(this.pOptionsPanel);
            this.Controls.Add(this.btnOption);
            this.Controls.Add(this.lblSaved);
            this.Controls.Add(this.btnBuyBuildings);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblLogsInfo);
            this.Controls.Add(this.btnTree);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TreeLogger";
            this.Text = "0 Logs";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TreeLogger_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TreeLogger_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TreeLogger_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pOptionsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTree;
        private System.Windows.Forms.Label lblLogsInfo;
        private System.Windows.Forms.Timer tmrLPS;
        private System.Windows.Forms.Button btnBuyClicker;
        private System.Windows.Forms.Button btnSellClicker;
        private System.Windows.Forms.Label lblClickerInfo;
        private System.Windows.Forms.Button btnBuyLumberjack;
        private System.Windows.Forms.Button btnSellLumberjack;
        private System.Windows.Forms.Label lblLumberjackInfo;
        private System.Windows.Forms.Button btnBuyLumberYard;
        private System.Windows.Forms.Button btnSellLumberYard;
        private System.Windows.Forms.Label lblLumberYardInfo;
        private System.Windows.Forms.Button btnBuySawmill;
        private System.Windows.Forms.Button btnSellSawmill;
        private System.Windows.Forms.Label lblSawmillInfo;
        private System.Windows.Forms.Button btnBuyForest;
        private System.Windows.Forms.Button btnSellForest;
        private System.Windows.Forms.Label lblForestInfo;
        private System.Windows.Forms.Button btnBuyShipment;
        private System.Windows.Forms.Button btnSellShipment;
        private System.Windows.Forms.Label lblShipmentInfo;
        private System.Windows.Forms.Label lblAlchemyLabInfo;
        private System.Windows.Forms.Button btnSellAlchemyLab;
        private System.Windows.Forms.Button btnBuyAlchemyLab;
        private System.Windows.Forms.Button btnBuyPortal;
        private System.Windows.Forms.Button btnSellPortal;
        private System.Windows.Forms.Label lblPortalInfo;
        private System.Windows.Forms.Button btnBuyExtractor;
        private System.Windows.Forms.Button btnSellExtractor;
        private System.Windows.Forms.Label lblExtractorInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBuyBuildings;
        private System.Windows.Forms.Timer tmrAutoSave;
        private System.Windows.Forms.Label lblSaved;
        private System.Windows.Forms.Button btnOption;
        private System.Windows.Forms.Panel pOptionsPanel;
        private System.Windows.Forms.Button btnManualSave;
        private System.Windows.Forms.Button btnResetSave;
        private System.Windows.Forms.Label lblCondenserInfo;
        private System.Windows.Forms.Button btnSellCondenser;
        private System.Windows.Forms.Button btnBuyCondenser;
    }
}

