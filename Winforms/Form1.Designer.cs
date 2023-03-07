
namespace Winforms
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.checkBoxPrimary = new System.Windows.Forms.CheckBox();
            this.checkBoxSecondary = new System.Windows.Forms.CheckBox();
            this.checkBoxMelee = new System.Windows.Forms.CheckBox();
            this.listBoxMelee = new System.Windows.Forms.CheckedListBox();
            this.listBoxSpecial = new System.Windows.Forms.CheckedListBox();
            this.listBoxPrimary = new System.Windows.Forms.CheckedListBox();
            this.checkBoxSpecial = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxSecondary = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCrosshairsCustom = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxCrosshairsQuake = new System.Windows.Forms.ComboBox();
            this.comboBoxCrosshairsCPMA = new System.Windows.Forms.ComboBox();
            this.comboBoxCrosshairsXhairshadow = new System.Windows.Forms.ComboBox();
            this.comboBoxCrosshairsTobs = new System.Windows.Forms.ComboBox();
            this.labelQuake = new System.Windows.Forms.Label();
            this.labelCPMA = new System.Windows.Forms.Label();
            this.labelXhairShadow = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxCrosshairsLeth = new System.Windows.Forms.ComboBox();
            this.buttonApply = new System.Windows.Forms.Button();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.buttonReset = new System.Windows.Forms.Button();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.buttonPyro = new System.Windows.Forms.Button();
            this.buttonHeavy = new System.Windows.Forms.Button();
            this.buttonEngie = new System.Windows.Forms.Button();
            this.buttonDemo = new System.Windows.Forms.Button();
            this.buttonMedic = new System.Windows.Forms.Button();
            this.buttonSoldier = new System.Windows.Forms.Button();
            this.buttonSniper = new System.Windows.Forms.Button();
            this.buttonScout = new System.Windows.Forms.Button();
            this.buttonSpy = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBoxCrosshair = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCrosshair)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxPrimary
            // 
            this.checkBoxPrimary.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxPrimary.AutoSize = true;
            this.checkBoxPrimary.BackColor = System.Drawing.Color.Gainsboro;
            this.checkBoxPrimary.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBoxPrimary.Location = new System.Drawing.Point(5, 23);
            this.checkBoxPrimary.Name = "checkBoxPrimary";
            this.checkBoxPrimary.Size = new System.Drawing.Size(61, 23);
            this.checkBoxPrimary.TabIndex = 4;
            this.checkBoxPrimary.Text = "Select All";
            this.checkBoxPrimary.UseVisualStyleBackColor = false;
            this.checkBoxPrimary.CheckedChanged += new System.EventHandler(this.checkBoxPrimary_CheckedChanged);
            // 
            // checkBoxSecondary
            // 
            this.checkBoxSecondary.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxSecondary.AutoSize = true;
            this.checkBoxSecondary.BackColor = System.Drawing.Color.Gainsboro;
            this.checkBoxSecondary.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBoxSecondary.Location = new System.Drawing.Point(5, 108);
            this.checkBoxSecondary.Name = "checkBoxSecondary";
            this.checkBoxSecondary.Size = new System.Drawing.Size(61, 23);
            this.checkBoxSecondary.TabIndex = 5;
            this.checkBoxSecondary.Text = "Select All";
            this.checkBoxSecondary.UseVisualStyleBackColor = false;
            this.checkBoxSecondary.CheckedChanged += new System.EventHandler(this.checkBoxSecondary_CheckedChanged);
            // 
            // checkBoxMelee
            // 
            this.checkBoxMelee.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxMelee.AutoSize = true;
            this.checkBoxMelee.BackColor = System.Drawing.Color.Gainsboro;
            this.checkBoxMelee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBoxMelee.Location = new System.Drawing.Point(5, 193);
            this.checkBoxMelee.Name = "checkBoxMelee";
            this.checkBoxMelee.Size = new System.Drawing.Size(61, 23);
            this.checkBoxMelee.TabIndex = 6;
            this.checkBoxMelee.Text = "Select All";
            this.checkBoxMelee.UseVisualStyleBackColor = false;
            this.checkBoxMelee.CheckedChanged += new System.EventHandler(this.checkBoxMelee_CheckedChanged);
            // 
            // listBoxMelee
            // 
            this.listBoxMelee.BackColor = System.Drawing.SystemColors.Control;
            this.listBoxMelee.CheckOnClick = true;
            this.listBoxMelee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxMelee.FormattingEnabled = true;
            this.listBoxMelee.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listBoxMelee.Location = new System.Drawing.Point(73, 177);
            this.listBoxMelee.Name = "listBoxMelee";
            this.listBoxMelee.Size = new System.Drawing.Size(424, 79);
            this.listBoxMelee.TabIndex = 13;
            // 
            // listBoxSpecial
            // 
            this.listBoxSpecial.BackColor = System.Drawing.SystemColors.Control;
            this.listBoxSpecial.CheckOnClick = true;
            this.listBoxSpecial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSpecial.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listBoxSpecial.FormattingEnabled = true;
            this.listBoxSpecial.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listBoxSpecial.Location = new System.Drawing.Point(73, 262);
            this.listBoxSpecial.Name = "listBoxSpecial";
            this.listBoxSpecial.Size = new System.Drawing.Size(424, 79);
            this.listBoxSpecial.TabIndex = 14;
            // 
            // listBoxPrimary
            // 
            this.listBoxPrimary.BackColor = System.Drawing.SystemColors.Control;
            this.listBoxPrimary.CheckOnClick = true;
            this.listBoxPrimary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPrimary.FormattingEnabled = true;
            this.listBoxPrimary.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listBoxPrimary.Location = new System.Drawing.Point(73, 7);
            this.listBoxPrimary.Name = "listBoxPrimary";
            this.listBoxPrimary.Size = new System.Drawing.Size(424, 79);
            this.listBoxPrimary.TabIndex = 13;
            // 
            // checkBoxSpecial
            // 
            this.checkBoxSpecial.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxSpecial.AutoSize = true;
            this.checkBoxSpecial.BackColor = System.Drawing.Color.Gainsboro;
            this.checkBoxSpecial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBoxSpecial.Location = new System.Drawing.Point(5, 278);
            this.checkBoxSpecial.Name = "checkBoxSpecial";
            this.checkBoxSpecial.Size = new System.Drawing.Size(61, 23);
            this.checkBoxSpecial.TabIndex = 12;
            this.checkBoxSpecial.Text = "Select All";
            this.checkBoxSpecial.UseVisualStyleBackColor = false;
            this.checkBoxSpecial.CheckedChanged += new System.EventHandler(this.checkBoxSpecial_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(24, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Special";
            // 
            // listBoxSecondary
            // 
            this.listBoxSecondary.BackColor = System.Drawing.SystemColors.Control;
            this.listBoxSecondary.CheckOnClick = true;
            this.listBoxSecondary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSecondary.FormattingEnabled = true;
            this.listBoxSecondary.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listBoxSecondary.Location = new System.Drawing.Point(73, 92);
            this.listBoxSecondary.Name = "listBoxSecondary";
            this.listBoxSecondary.Size = new System.Drawing.Size(424, 79);
            this.listBoxSecondary.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(31, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Melee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(9, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Secondary";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(25, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Primary";
            // 
            // comboBoxCrosshairsCustom
            // 
            this.comboBoxCrosshairsCustom.FormattingEnabled = true;
            this.comboBoxCrosshairsCustom.Location = new System.Drawing.Point(9, 141);
            this.comboBoxCrosshairsCustom.Name = "comboBoxCrosshairsCustom";
            this.comboBoxCrosshairsCustom.Size = new System.Drawing.Size(113, 21);
            this.comboBoxCrosshairsCustom.TabIndex = 11;
            this.comboBoxCrosshairsCustom.SelectedIndexChanged += new System.EventHandler(this.comboBoxCrosshairsCustom_SelectedIndexChanged);
            this.comboBoxCrosshairsCustom.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBoxCrosshairsCustom_MouseClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(128, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Custom";
            // 
            // comboBoxCrosshairsQuake
            // 
            this.comboBoxCrosshairsQuake.FormattingEnabled = true;
            this.comboBoxCrosshairsQuake.Location = new System.Drawing.Point(9, 115);
            this.comboBoxCrosshairsQuake.Name = "comboBoxCrosshairsQuake";
            this.comboBoxCrosshairsQuake.Size = new System.Drawing.Size(113, 21);
            this.comboBoxCrosshairsQuake.TabIndex = 9;
            this.comboBoxCrosshairsQuake.SelectedIndexChanged += new System.EventHandler(this.comboBoxCrosshairsQuake_SelectedIndexChanged);
            this.comboBoxCrosshairsQuake.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBoxCrosshairsQuake_MouseClick);
            // 
            // comboBoxCrosshairsCPMA
            // 
            this.comboBoxCrosshairsCPMA.FormattingEnabled = true;
            this.comboBoxCrosshairsCPMA.Location = new System.Drawing.Point(9, 88);
            this.comboBoxCrosshairsCPMA.Name = "comboBoxCrosshairsCPMA";
            this.comboBoxCrosshairsCPMA.Size = new System.Drawing.Size(113, 21);
            this.comboBoxCrosshairsCPMA.TabIndex = 8;
            this.comboBoxCrosshairsCPMA.SelectedIndexChanged += new System.EventHandler(this.comboBoxCrosshairsCPMA_SelectedIndexChanged);
            this.comboBoxCrosshairsCPMA.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBoxCrosshairsCPMA_MouseClick);
            // 
            // comboBoxCrosshairsXhairshadow
            // 
            this.comboBoxCrosshairsXhairshadow.FormattingEnabled = true;
            this.comboBoxCrosshairsXhairshadow.Location = new System.Drawing.Point(8, 61);
            this.comboBoxCrosshairsXhairshadow.Name = "comboBoxCrosshairsXhairshadow";
            this.comboBoxCrosshairsXhairshadow.Size = new System.Drawing.Size(113, 21);
            this.comboBoxCrosshairsXhairshadow.TabIndex = 7;
            this.comboBoxCrosshairsXhairshadow.SelectedIndexChanged += new System.EventHandler(this.comboBoxCrosshairsXhairshadow_SelectedIndexChanged);
            this.comboBoxCrosshairsXhairshadow.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBoxCrosshairsXhairshadow_MouseClick);
            // 
            // comboBoxCrosshairsTobs
            // 
            this.comboBoxCrosshairsTobs.FormattingEnabled = true;
            this.comboBoxCrosshairsTobs.Location = new System.Drawing.Point(8, 34);
            this.comboBoxCrosshairsTobs.Name = "comboBoxCrosshairsTobs";
            this.comboBoxCrosshairsTobs.Size = new System.Drawing.Size(113, 21);
            this.comboBoxCrosshairsTobs.TabIndex = 6;
            this.comboBoxCrosshairsTobs.SelectedIndexChanged += new System.EventHandler(this.comboBoxCrosshairsTobs_SelectedIndexChanged);
            this.comboBoxCrosshairsTobs.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBoxCrosshairsTobs_MouseClick);
            // 
            // labelQuake
            // 
            this.labelQuake.AutoSize = true;
            this.labelQuake.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelQuake.Location = new System.Drawing.Point(128, 118);
            this.labelQuake.Name = "labelQuake";
            this.labelQuake.Size = new System.Drawing.Size(39, 13);
            this.labelQuake.TabIndex = 5;
            this.labelQuake.Text = "Quake";
            // 
            // labelCPMA
            // 
            this.labelCPMA.AutoSize = true;
            this.labelCPMA.BackColor = System.Drawing.Color.Transparent;
            this.labelCPMA.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCPMA.Location = new System.Drawing.Point(128, 91);
            this.labelCPMA.Name = "labelCPMA";
            this.labelCPMA.Size = new System.Drawing.Size(37, 13);
            this.labelCPMA.TabIndex = 4;
            this.labelCPMA.Text = "CPMA";
            // 
            // labelXhairShadow
            // 
            this.labelXhairShadow.AutoSize = true;
            this.labelXhairShadow.BackColor = System.Drawing.Color.Transparent;
            this.labelXhairShadow.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelXhairShadow.Location = new System.Drawing.Point(128, 64);
            this.labelXhairShadow.Name = "labelXhairShadow";
            this.labelXhairShadow.Size = new System.Drawing.Size(66, 13);
            this.labelXhairShadow.TabIndex = 3;
            this.labelXhairShadow.Text = "xhairshadow";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(128, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tob\'s black brackets";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(128, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Leth xhair pack";
            // 
            // comboBoxCrosshairsLeth
            // 
            this.comboBoxCrosshairsLeth.FormattingEnabled = true;
            this.comboBoxCrosshairsLeth.Location = new System.Drawing.Point(8, 7);
            this.comboBoxCrosshairsLeth.Name = "comboBoxCrosshairsLeth";
            this.comboBoxCrosshairsLeth.Size = new System.Drawing.Size(113, 21);
            this.comboBoxCrosshairsLeth.TabIndex = 0;
            this.comboBoxCrosshairsLeth.SelectedIndexChanged += new System.EventHandler(this.comboBoxCrosshairsLeth_SelectedIndexChanged);
            this.comboBoxCrosshairsLeth.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBoxCrosshairsLeth_MouseClick);
            // 
            // buttonApply
            // 
            this.buttonApply.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonApply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApply.Location = new System.Drawing.Point(423, 602);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(88, 23);
            this.buttonApply.TabIndex = 10;
            this.buttonApply.Text = "Apply Changes";
            this.buttonApply.UseVisualStyleBackColor = false;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(445, 150);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonReset.Location = new System.Drawing.Point(342, 602);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 12;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.fileToolStripMenuItem.Text = "Select Directory";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(517, 24);
            this.menuStrip2.TabIndex = 14;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // buttonPyro
            // 
            this.buttonPyro.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonPyro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPyro.Location = new System.Drawing.Point(118, 6);
            this.buttonPyro.Name = "buttonPyro";
            this.buttonPyro.Size = new System.Drawing.Size(49, 23);
            this.buttonPyro.TabIndex = 2;
            this.buttonPyro.Text = "Pyro";
            this.buttonPyro.UseVisualStyleBackColor = false;
            this.buttonPyro.Click += new System.EventHandler(this.buttonPyro_Click);
            // 
            // buttonHeavy
            // 
            this.buttonHeavy.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonHeavy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonHeavy.Location = new System.Drawing.Point(228, 6);
            this.buttonHeavy.Name = "buttonHeavy";
            this.buttonHeavy.Size = new System.Drawing.Size(49, 23);
            this.buttonHeavy.TabIndex = 4;
            this.buttonHeavy.Text = "Heavy";
            this.buttonHeavy.UseVisualStyleBackColor = false;
            this.buttonHeavy.Click += new System.EventHandler(this.buttonHeavy_Click);
            // 
            // buttonEngie
            // 
            this.buttonEngie.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonEngie.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEngie.Location = new System.Drawing.Point(283, 6);
            this.buttonEngie.Name = "buttonEngie";
            this.buttonEngie.Size = new System.Drawing.Size(49, 23);
            this.buttonEngie.TabIndex = 5;
            this.buttonEngie.Text = "Engie";
            this.buttonEngie.UseVisualStyleBackColor = false;
            this.buttonEngie.Click += new System.EventHandler(this.buttonEngie_Click);
            // 
            // buttonDemo
            // 
            this.buttonDemo.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonDemo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDemo.Location = new System.Drawing.Point(173, 6);
            this.buttonDemo.Name = "buttonDemo";
            this.buttonDemo.Size = new System.Drawing.Size(49, 23);
            this.buttonDemo.TabIndex = 3;
            this.buttonDemo.Text = "Demo";
            this.buttonDemo.UseVisualStyleBackColor = false;
            this.buttonDemo.Click += new System.EventHandler(this.buttonDemo_Click);
            // 
            // buttonMedic
            // 
            this.buttonMedic.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonMedic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMedic.Location = new System.Drawing.Point(338, 6);
            this.buttonMedic.Name = "buttonMedic";
            this.buttonMedic.Size = new System.Drawing.Size(49, 23);
            this.buttonMedic.TabIndex = 6;
            this.buttonMedic.Text = "Medic";
            this.buttonMedic.UseVisualStyleBackColor = false;
            this.buttonMedic.Click += new System.EventHandler(this.buttonMedic_Click);
            // 
            // buttonSoldier
            // 
            this.buttonSoldier.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonSoldier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSoldier.Location = new System.Drawing.Point(63, 6);
            this.buttonSoldier.Name = "buttonSoldier";
            this.buttonSoldier.Size = new System.Drawing.Size(49, 23);
            this.buttonSoldier.TabIndex = 1;
            this.buttonSoldier.Text = "Soldier";
            this.buttonSoldier.UseVisualStyleBackColor = false;
            this.buttonSoldier.Click += new System.EventHandler(this.buttonSoldier_Click);
            // 
            // buttonSniper
            // 
            this.buttonSniper.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonSniper.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSniper.Location = new System.Drawing.Point(393, 6);
            this.buttonSniper.Name = "buttonSniper";
            this.buttonSniper.Size = new System.Drawing.Size(49, 23);
            this.buttonSniper.TabIndex = 7;
            this.buttonSniper.Text = "Sniper";
            this.buttonSniper.UseVisualStyleBackColor = false;
            this.buttonSniper.Click += new System.EventHandler(this.buttonSniper_Click);
            // 
            // buttonScout
            // 
            this.buttonScout.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonScout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonScout.Location = new System.Drawing.Point(8, 6);
            this.buttonScout.Name = "buttonScout";
            this.buttonScout.Size = new System.Drawing.Size(49, 23);
            this.buttonScout.TabIndex = 0;
            this.buttonScout.Text = "Scout";
            this.buttonScout.UseVisualStyleBackColor = false;
            this.buttonScout.Click += new System.EventHandler(this.buttonScout_Click);
            // 
            // buttonSpy
            // 
            this.buttonSpy.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonSpy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSpy.Location = new System.Drawing.Point(448, 6);
            this.buttonSpy.Name = "buttonSpy";
            this.buttonSpy.Size = new System.Drawing.Size(49, 23);
            this.buttonSpy.TabIndex = 8;
            this.buttonSpy.Text = "Spy";
            this.buttonSpy.UseVisualStyleBackColor = false;
            this.buttonSpy.Click += new System.EventHandler(this.buttonSpy_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.BackColor = System.Drawing.Color.Transparent;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelStatus.Location = new System.Drawing.Point(51, 607);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(84, 13);
            this.labelStatus.TabIndex = 11;
            this.labelStatus.Text = "Waiting for input";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.buttonSpy);
            this.panel1.Controls.Add(this.buttonSniper);
            this.panel1.Controls.Add(this.buttonPyro);
            this.panel1.Controls.Add(this.buttonMedic);
            this.panel1.Controls.Add(this.buttonEngie);
            this.panel1.Controls.Add(this.buttonHeavy);
            this.panel1.Controls.Add(this.buttonDemo);
            this.panel1.Controls.Add(this.buttonSoldier);
            this.panel1.Controls.Add(this.buttonScout);
            this.panel1.Location = new System.Drawing.Point(6, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(505, 35);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.checkBoxSpecial);
            this.panel2.Controls.Add(this.listBoxSpecial);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.listBoxMelee);
            this.panel2.Controls.Add(this.listBoxPrimary);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.checkBoxMelee);
            this.panel2.Controls.Add(this.checkBoxSecondary);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.checkBoxPrimary);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.listBoxSecondary);
            this.panel2.Location = new System.Drawing.Point(6, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(505, 348);
            this.panel2.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.labelCPMA);
            this.panel3.Controls.Add(this.comboBoxCrosshairsLeth);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.comboBoxCrosshairsCustom);
            this.panel3.Controls.Add(this.labelQuake);
            this.panel3.Controls.Add(this.comboBoxCrosshairsTobs);
            this.panel3.Controls.Add(this.comboBoxCrosshairsXhairshadow);
            this.panel3.Controls.Add(this.labelXhairShadow);
            this.panel3.Controls.Add(this.comboBoxCrosshairsQuake);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.comboBoxCrosshairsCPMA);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.pictureBoxCrosshair);
            this.panel3.Location = new System.Drawing.Point(6, 422);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(505, 174);
            this.panel3.TabIndex = 18;
            // 
            // pictureBoxCrosshair
            // 
            this.pictureBoxCrosshair.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCrosshair.Location = new System.Drawing.Point(248, 0);
            this.pictureBoxCrosshair.Name = "pictureBoxCrosshair";
            this.pictureBoxCrosshair.Size = new System.Drawing.Size(257, 174);
            this.pictureBoxCrosshair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxCrosshair.TabIndex = 13;
            this.pictureBoxCrosshair.TabStop = false;
            this.pictureBoxCrosshair.MouseEnter += new System.EventHandler(this.pictureBoxCrosshair_MouseEnter);
            this.pictureBoxCrosshair.MouseLeave += new System.EventHandler(this.pictureBoxCrosshair_MouseLeave);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(245, 418);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 178);
            this.panel4.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(6, 607);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Status:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(517, 632);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(533, 671);
            this.MinimumSize = new System.Drawing.Size(533, 671);
            this.Name = "Form1";
            this.Text = "Crosshair Switcher";
            this.TopMost = true;
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCrosshair)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBoxPrimary;
        private System.Windows.Forms.CheckBox checkBoxSecondary;
        private System.Windows.Forms.CheckBox checkBoxMelee;
        private System.Windows.Forms.CheckBox checkBoxSpecial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.PictureBox pictureBoxCrosshair;
        private System.Windows.Forms.ComboBox comboBoxCrosshairsCustom;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxCrosshairsQuake;
        private System.Windows.Forms.ComboBox comboBoxCrosshairsCPMA;
        private System.Windows.Forms.ComboBox comboBoxCrosshairsXhairshadow;
        private System.Windows.Forms.ComboBox comboBoxCrosshairsTobs;
        private System.Windows.Forms.Label labelQuake;
        private System.Windows.Forms.Label labelCPMA;
        private System.Windows.Forms.Label labelXhairShadow;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxCrosshairsLeth;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.CheckedListBox listBoxPrimary;
        private System.Windows.Forms.CheckedListBox listBoxSpecial;
        private System.Windows.Forms.CheckedListBox listBoxMelee;
        private System.Windows.Forms.CheckedListBox listBoxSecondary;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.Button buttonPyro;
        private System.Windows.Forms.Button buttonHeavy;
        private System.Windows.Forms.Button buttonEngie;
        private System.Windows.Forms.Button buttonDemo;
        private System.Windows.Forms.Button buttonMedic;
        private System.Windows.Forms.Button buttonSoldier;
        private System.Windows.Forms.Button buttonSniper;
        private System.Windows.Forms.Button buttonScout;
        private System.Windows.Forms.Button buttonSpy;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
    }
}

