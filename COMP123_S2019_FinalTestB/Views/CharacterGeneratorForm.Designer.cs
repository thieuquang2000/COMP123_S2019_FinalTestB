﻿namespace COMP123_S2019_FinalTestB.Views
{
    partial class CharacterGeneratorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterGeneratorForm));
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.IdentityPage = new System.Windows.Forms.TabPage();
            this.AbilityPage = new System.Windows.Forms.TabPage();
            this.BackButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.InventoryPage = new System.Windows.Forms.TabPage();
            this.CharacterSheetPage = new System.Windows.Forms.TabPage();
            this.IdentityTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.GenerrateNameButton = new System.Windows.Forms.Button();
            this.ChracterNameLabel = new System.Windows.Forms.Label();
            this.FirstNameLable = new System.Windows.Forms.Label();
            this.LastNameLable = new System.Windows.Forms.Label();
            this.CharacterNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameDataLabel = new System.Windows.Forms.Label();
            this.LastNameDataLabel = new System.Windows.Forms.Label();
            this.AbilitiedTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.GenerateAbilitesButton = new System.Windows.Forms.Button();
            this.AbilityStrengthLabel = new System.Windows.Forms.Label();
            this.IntelligenceLabel = new System.Windows.Forms.Label();
            this.DexterityLabel = new System.Windows.Forms.Label();
            this.CharismaLabel = new System.Windows.Forms.Label();
            this.ConsitutionLabel = new System.Windows.Forms.Label();
            this.WisdomLabel = new System.Windows.Forms.Label();
            this.StrengthDataLabel = new System.Windows.Forms.Label();
            this.ConsitutionDataLabel = new System.Windows.Forms.Label();
            this.WisdomDataLabel = new System.Windows.Forms.Label();
            this.DexterityDataLabel = new System.Windows.Forms.Label();
            this.IntelligenceDataLabel = new System.Windows.Forms.Label();
            this.CharismaDataLabel = new System.Windows.Forms.Label();
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainToolStrip = new System.Windows.Forms.ToolStrip();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.MainTabControl.SuspendLayout();
            this.IdentityPage.SuspendLayout();
            this.AbilityPage.SuspendLayout();
            this.CharacterSheetPage.SuspendLayout();
            this.IdentityTableLayoutPanel.SuspendLayout();
            this.AbilitiedTableLayoutPanel.SuspendLayout();
            this.MainMenuStrip.SuspendLayout();
            this.MainToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.IdentityPage);
            this.MainTabControl.Controls.Add(this.AbilityPage);
            this.MainTabControl.Controls.Add(this.InventoryPage);
            this.MainTabControl.Controls.Add(this.CharacterSheetPage);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(784, 465);
            this.MainTabControl.TabIndex = 4;
            // 
            // IdentityPage
            // 
            this.IdentityPage.Controls.Add(this.IdentityTableLayoutPanel);
            this.IdentityPage.Location = new System.Drawing.Point(4, 33);
            this.IdentityPage.Name = "IdentityPage";
            this.IdentityPage.Padding = new System.Windows.Forms.Padding(3);
            this.IdentityPage.Size = new System.Drawing.Size(776, 428);
            this.IdentityPage.TabIndex = 0;
            this.IdentityPage.Text = "Indentity";
            this.IdentityPage.UseVisualStyleBackColor = true;
            // 
            // AbilityPage
            // 
            this.AbilityPage.Controls.Add(this.AbilitiedTableLayoutPanel);
            this.AbilityPage.Location = new System.Drawing.Point(4, 33);
            this.AbilityPage.Name = "AbilityPage";
            this.AbilityPage.Padding = new System.Windows.Forms.Padding(3);
            this.AbilityPage.Size = new System.Drawing.Size(776, 428);
            this.AbilityPage.TabIndex = 1;
            this.AbilityPage.Text = "Abilities";
            this.AbilityPage.UseVisualStyleBackColor = true;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 493);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(119, 56);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(653, 493);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(119, 56);
            this.NextButton.TabIndex = 4;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // InventoryPage
            // 
            this.InventoryPage.Location = new System.Drawing.Point(4, 33);
            this.InventoryPage.Name = "InventoryPage";
            this.InventoryPage.Padding = new System.Windows.Forms.Padding(3);
            this.InventoryPage.Size = new System.Drawing.Size(776, 428);
            this.InventoryPage.TabIndex = 2;
            this.InventoryPage.Text = "Inventory";
            this.InventoryPage.UseVisualStyleBackColor = true;
            // 
            // CharacterSheetPage
            // 
            this.CharacterSheetPage.Controls.Add(this.MainToolStrip);
            this.CharacterSheetPage.Controls.Add(this.MainMenuStrip);
            this.CharacterSheetPage.Location = new System.Drawing.Point(4, 33);
            this.CharacterSheetPage.Name = "CharacterSheetPage";
            this.CharacterSheetPage.Padding = new System.Windows.Forms.Padding(3);
            this.CharacterSheetPage.Size = new System.Drawing.Size(776, 428);
            this.CharacterSheetPage.TabIndex = 3;
            this.CharacterSheetPage.Text = "Character Sheet";
            this.CharacterSheetPage.UseVisualStyleBackColor = true;
            // 
            // IdentityTableLayoutPanel
            // 
            this.IdentityTableLayoutPanel.ColumnCount = 4;
            this.IdentityTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.IdentityTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.IdentityTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IdentityTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IdentityTableLayoutPanel.Controls.Add(this.GenerrateNameButton, 2, 4);
            this.IdentityTableLayoutPanel.Controls.Add(this.CharacterNameTextBox, 1, 0);
            this.IdentityTableLayoutPanel.Controls.Add(this.ChracterNameLabel, 0, 0);
            this.IdentityTableLayoutPanel.Controls.Add(this.FirstNameLable, 0, 1);
            this.IdentityTableLayoutPanel.Controls.Add(this.LastNameLable, 0, 2);
            this.IdentityTableLayoutPanel.Controls.Add(this.FirstNameDataLabel, 1, 1);
            this.IdentityTableLayoutPanel.Controls.Add(this.LastNameDataLabel, 1, 2);
            this.IdentityTableLayoutPanel.Location = new System.Drawing.Point(0, 6);
            this.IdentityTableLayoutPanel.Name = "IdentityTableLayoutPanel";
            this.IdentityTableLayoutPanel.RowCount = 5;
            this.IdentityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.IdentityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.IdentityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.IdentityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.IdentityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.IdentityTableLayoutPanel.Size = new System.Drawing.Size(776, 359);
            this.IdentityTableLayoutPanel.TabIndex = 2;
            // 
            // GenerrateNameButton
            // 
            this.GenerrateNameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IdentityTableLayoutPanel.SetColumnSpan(this.GenerrateNameButton, 2);
            this.GenerrateNameButton.Location = new System.Drawing.Point(390, 287);
            this.GenerrateNameButton.Name = "GenerrateNameButton";
            this.GenerrateNameButton.Size = new System.Drawing.Size(383, 69);
            this.GenerrateNameButton.TabIndex = 5;
            this.GenerrateNameButton.Text = "Generate Name";
            this.GenerrateNameButton.UseVisualStyleBackColor = true;
            // 
            // ChracterNameLabel
            // 
            this.ChracterNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChracterNameLabel.Location = new System.Drawing.Point(3, 0);
            this.ChracterNameLabel.Name = "ChracterNameLabel";
            this.ChracterNameLabel.Size = new System.Drawing.Size(226, 71);
            this.ChracterNameLabel.TabIndex = 6;
            this.ChracterNameLabel.Text = "Character Name";
            this.ChracterNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FirstNameLable
            // 
            this.FirstNameLable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstNameLable.Location = new System.Drawing.Point(3, 71);
            this.FirstNameLable.Name = "FirstNameLable";
            this.FirstNameLable.Size = new System.Drawing.Size(226, 71);
            this.FirstNameLable.TabIndex = 7;
            this.FirstNameLable.Text = "First Name";
            this.FirstNameLable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LastNameLable
            // 
            this.LastNameLable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LastNameLable.Location = new System.Drawing.Point(3, 142);
            this.LastNameLable.Name = "LastNameLable";
            this.LastNameLable.Size = new System.Drawing.Size(226, 71);
            this.LastNameLable.TabIndex = 8;
            this.LastNameLable.Text = "Last Name";
            this.LastNameLable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CharacterNameTextBox
            // 
            this.CharacterNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.IdentityTableLayoutPanel.SetColumnSpan(this.CharacterNameTextBox, 3);
            this.CharacterNameTextBox.Location = new System.Drawing.Point(235, 21);
            this.CharacterNameTextBox.Name = "CharacterNameTextBox";
            this.CharacterNameTextBox.Size = new System.Drawing.Size(538, 29);
            this.CharacterNameTextBox.TabIndex = 9;
            // 
            // FirstNameDataLabel
            // 
            this.FirstNameDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstNameDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FirstNameDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IdentityTableLayoutPanel.SetColumnSpan(this.FirstNameDataLabel, 3);
            this.FirstNameDataLabel.Location = new System.Drawing.Point(235, 71);
            this.FirstNameDataLabel.Name = "FirstNameDataLabel";
            this.FirstNameDataLabel.Size = new System.Drawing.Size(538, 71);
            this.FirstNameDataLabel.TabIndex = 7;
            this.FirstNameDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LastNameDataLabel
            // 
            this.LastNameDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LastNameDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LastNameDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IdentityTableLayoutPanel.SetColumnSpan(this.LastNameDataLabel, 3);
            this.LastNameDataLabel.Location = new System.Drawing.Point(235, 142);
            this.LastNameDataLabel.Name = "LastNameDataLabel";
            this.LastNameDataLabel.Size = new System.Drawing.Size(538, 71);
            this.LastNameDataLabel.TabIndex = 7;
            this.LastNameDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AbilitiedTableLayoutPanel
            // 
            this.AbilitiedTableLayoutPanel.ColumnCount = 4;
            this.AbilitiedTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.AbilitiedTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.AbilitiedTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.AbilitiedTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.AbilitiedTableLayoutPanel.Controls.Add(this.DexterityDataLabel, 1, 1);
            this.AbilitiedTableLayoutPanel.Controls.Add(this.StrengthDataLabel, 1, 0);
            this.AbilitiedTableLayoutPanel.Controls.Add(this.ConsitutionLabel, 0, 2);
            this.AbilitiedTableLayoutPanel.Controls.Add(this.DexterityLabel, 0, 1);
            this.AbilitiedTableLayoutPanel.Controls.Add(this.AbilityStrengthLabel, 0, 0);
            this.AbilitiedTableLayoutPanel.Controls.Add(this.GenerateAbilitesButton, 2, 7);
            this.AbilitiedTableLayoutPanel.Controls.Add(this.IntelligenceLabel, 0, 3);
            this.AbilitiedTableLayoutPanel.Controls.Add(this.WisdomLabel, 0, 4);
            this.AbilitiedTableLayoutPanel.Controls.Add(this.CharismaLabel, 0, 5);
            this.AbilitiedTableLayoutPanel.Controls.Add(this.ConsitutionDataLabel, 1, 2);
            this.AbilitiedTableLayoutPanel.Controls.Add(this.IntelligenceDataLabel, 1, 3);
            this.AbilitiedTableLayoutPanel.Controls.Add(this.WisdomDataLabel, 1, 4);
            this.AbilitiedTableLayoutPanel.Controls.Add(this.CharismaDataLabel, 1, 5);
            this.AbilitiedTableLayoutPanel.Location = new System.Drawing.Point(4, 7);
            this.AbilitiedTableLayoutPanel.Name = "AbilitiedTableLayoutPanel";
            this.AbilitiedTableLayoutPanel.RowCount = 8;
            this.AbilitiedTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AbilitiedTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AbilitiedTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AbilitiedTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AbilitiedTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AbilitiedTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AbilitiedTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AbilitiedTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AbilitiedTableLayoutPanel.Size = new System.Drawing.Size(764, 379);
            this.AbilitiedTableLayoutPanel.TabIndex = 0;
            // 
            // GenerateAbilitesButton
            // 
            this.GenerateAbilitesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AbilitiedTableLayoutPanel.SetColumnSpan(this.GenerateAbilitesButton, 2);
            this.GenerateAbilitesButton.Location = new System.Drawing.Point(385, 332);
            this.GenerateAbilitesButton.Name = "GenerateAbilitesButton";
            this.GenerateAbilitesButton.Size = new System.Drawing.Size(376, 44);
            this.GenerateAbilitesButton.TabIndex = 7;
            this.GenerateAbilitesButton.Text = "Generate Abilities";
            this.GenerateAbilitesButton.UseVisualStyleBackColor = true;
            // 
            // AbilityStrengthLabel
            // 
            this.AbilityStrengthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AbilityStrengthLabel.Location = new System.Drawing.Point(3, 0);
            this.AbilityStrengthLabel.Name = "AbilityStrengthLabel";
            this.AbilityStrengthLabel.Size = new System.Drawing.Size(185, 47);
            this.AbilityStrengthLabel.TabIndex = 9;
            this.AbilityStrengthLabel.Text = "Strength";
            this.AbilityStrengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // IntelligenceLabel
            // 
            this.IntelligenceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IntelligenceLabel.Location = new System.Drawing.Point(3, 141);
            this.IntelligenceLabel.Name = "IntelligenceLabel";
            this.IntelligenceLabel.Size = new System.Drawing.Size(185, 47);
            this.IntelligenceLabel.TabIndex = 10;
            this.IntelligenceLabel.Text = "Intelligence";
            this.IntelligenceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DexterityLabel
            // 
            this.DexterityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DexterityLabel.Location = new System.Drawing.Point(3, 47);
            this.DexterityLabel.Name = "DexterityLabel";
            this.DexterityLabel.Size = new System.Drawing.Size(185, 47);
            this.DexterityLabel.TabIndex = 13;
            this.DexterityLabel.Text = "Dexterity";
            this.DexterityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CharismaLabel
            // 
            this.CharismaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CharismaLabel.Location = new System.Drawing.Point(3, 235);
            this.CharismaLabel.Name = "CharismaLabel";
            this.CharismaLabel.Size = new System.Drawing.Size(185, 47);
            this.CharismaLabel.TabIndex = 14;
            this.CharismaLabel.Text = "Charisma";
            this.CharismaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ConsitutionLabel
            // 
            this.ConsitutionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsitutionLabel.Location = new System.Drawing.Point(3, 94);
            this.ConsitutionLabel.Name = "ConsitutionLabel";
            this.ConsitutionLabel.Size = new System.Drawing.Size(185, 47);
            this.ConsitutionLabel.TabIndex = 17;
            this.ConsitutionLabel.Text = "Consitution";
            this.ConsitutionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // WisdomLabel
            // 
            this.WisdomLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WisdomLabel.Location = new System.Drawing.Point(3, 188);
            this.WisdomLabel.Name = "WisdomLabel";
            this.WisdomLabel.Size = new System.Drawing.Size(185, 47);
            this.WisdomLabel.TabIndex = 18;
            this.WisdomLabel.Text = "Wisdom";
            this.WisdomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StrengthDataLabel
            // 
            this.StrengthDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StrengthDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.StrengthDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StrengthDataLabel.Location = new System.Drawing.Point(194, 0);
            this.StrengthDataLabel.Name = "StrengthDataLabel";
            this.StrengthDataLabel.Size = new System.Drawing.Size(185, 47);
            this.StrengthDataLabel.TabIndex = 10;
            this.StrengthDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ConsitutionDataLabel
            // 
            this.ConsitutionDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsitutionDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ConsitutionDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConsitutionDataLabel.Location = new System.Drawing.Point(194, 94);
            this.ConsitutionDataLabel.Name = "ConsitutionDataLabel";
            this.ConsitutionDataLabel.Size = new System.Drawing.Size(185, 47);
            this.ConsitutionDataLabel.TabIndex = 19;
            this.ConsitutionDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WisdomDataLabel
            // 
            this.WisdomDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WisdomDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.WisdomDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WisdomDataLabel.Location = new System.Drawing.Point(194, 188);
            this.WisdomDataLabel.Name = "WisdomDataLabel";
            this.WisdomDataLabel.Size = new System.Drawing.Size(185, 47);
            this.WisdomDataLabel.TabIndex = 20;
            this.WisdomDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DexterityDataLabel
            // 
            this.DexterityDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DexterityDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DexterityDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DexterityDataLabel.Location = new System.Drawing.Point(194, 47);
            this.DexterityDataLabel.Name = "DexterityDataLabel";
            this.DexterityDataLabel.Size = new System.Drawing.Size(185, 47);
            this.DexterityDataLabel.TabIndex = 21;
            this.DexterityDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // IntelligenceDataLabel
            // 
            this.IntelligenceDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IntelligenceDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.IntelligenceDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IntelligenceDataLabel.Location = new System.Drawing.Point(194, 141);
            this.IntelligenceDataLabel.Name = "IntelligenceDataLabel";
            this.IntelligenceDataLabel.Size = new System.Drawing.Size(185, 47);
            this.IntelligenceDataLabel.TabIndex = 22;
            this.IntelligenceDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CharismaDataLabel
            // 
            this.CharismaDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CharismaDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CharismaDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CharismaDataLabel.Location = new System.Drawing.Point(194, 235);
            this.CharismaDataLabel.Name = "CharismaDataLabel";
            this.CharismaDataLabel.Size = new System.Drawing.Size(185, 47);
            this.CharismaDataLabel.TabIndex = 23;
            this.CharismaDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(3, 3);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(770, 24);
            this.MainMenuStrip.TabIndex = 0;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(177, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // MainToolStrip
            // 
            this.MainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator6,
            this.helpToolStripButton});
            this.MainToolStrip.Location = new System.Drawing.Point(3, 27);
            this.MainToolStrip.Name = "MainToolStrip";
            this.MainToolStrip.Size = new System.Drawing.Size(770, 25);
            this.MainToolStrip.TabIndex = 1;
            this.MainToolStrip.Text = "toolStrip1";
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "&Open";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // CharacterGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.MainTabControl);
            this.MainMenuStrip = this.MainMenuStrip;
            this.Name = "CharacterGeneratorForm";
            this.Text = "Character Generator";
            this.MainTabControl.ResumeLayout(false);
            this.IdentityPage.ResumeLayout(false);
            this.AbilityPage.ResumeLayout(false);
            this.CharacterSheetPage.ResumeLayout(false);
            this.CharacterSheetPage.PerformLayout();
            this.IdentityTableLayoutPanel.ResumeLayout(false);
            this.IdentityTableLayoutPanel.PerformLayout();
            this.AbilitiedTableLayoutPanel.ResumeLayout(false);
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.MainToolStrip.ResumeLayout(false);
            this.MainToolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage IdentityPage;
        private System.Windows.Forms.TabPage AbilityPage;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TabPage InventoryPage;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.TableLayoutPanel IdentityTableLayoutPanel;
        private System.Windows.Forms.Button GenerrateNameButton;
        private System.Windows.Forms.TextBox CharacterNameTextBox;
        private System.Windows.Forms.Label ChracterNameLabel;
        private System.Windows.Forms.Label FirstNameLable;
        private System.Windows.Forms.Label LastNameLable;
        private System.Windows.Forms.Label FirstNameDataLabel;
        private System.Windows.Forms.Label LastNameDataLabel;
        private System.Windows.Forms.TabPage CharacterSheetPage;
        private System.Windows.Forms.TableLayoutPanel AbilitiedTableLayoutPanel;
        private System.Windows.Forms.Label DexterityDataLabel;
        private System.Windows.Forms.Label StrengthDataLabel;
        private System.Windows.Forms.Label ConsitutionLabel;
        private System.Windows.Forms.Label DexterityLabel;
        private System.Windows.Forms.Label AbilityStrengthLabel;
        private System.Windows.Forms.Button GenerateAbilitesButton;
        private System.Windows.Forms.Label IntelligenceLabel;
        private System.Windows.Forms.Label WisdomLabel;
        private System.Windows.Forms.Label CharismaLabel;
        private System.Windows.Forms.Label ConsitutionDataLabel;
        private System.Windows.Forms.Label IntelligenceDataLabel;
        private System.Windows.Forms.Label WisdomDataLabel;
        private System.Windows.Forms.Label CharismaDataLabel;
        private System.Windows.Forms.ToolStrip MainToolStrip;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}
