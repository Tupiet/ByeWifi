namespace CSArp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSaveSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemMinimize = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemChooseInterface = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBoxDevicelist = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ClientNametoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxClientName = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cutoffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemRefreshClients = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutCSArpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelSpringer = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusScan = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBarScan = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.clearStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderSN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderIP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMAC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCutoffStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderClientname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.richTextBoxLog = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.refreshButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Avenir Book", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(604, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSaveSettings,
            this.toolStripSeparator4,
            this.toolStripMenuItemMinimize,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.fileToolStripMenuItem.Text = "Archivo";
            // 
            // toolStripMenuItemSaveSettings
            // 
            this.toolStripMenuItemSaveSettings.Name = "toolStripMenuItemSaveSettings";
            this.toolStripMenuItemSaveSettings.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.toolStripMenuItemSaveSettings.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemSaveSettings.Text = "Guardar";
            this.toolStripMenuItemSaveSettings.ToolTipText = "Save current settings";
            this.toolStripMenuItemSaveSettings.Click += new System.EventHandler(this.toolStripMenuItemSaveSettings_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripMenuItemMinimize
            // 
            this.toolStripMenuItemMinimize.Name = "toolStripMenuItemMinimize";
            this.toolStripMenuItemMinimize.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.toolStripMenuItemMinimize.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemMinimize.Text = "Minimizar";
            this.toolStripMenuItemMinimize.ToolTipText = "Minimize to tray";
            this.toolStripMenuItemMinimize.Click += new System.EventHandler(this.toolStripMenuItemMinimize_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Salir";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemChooseInterface,
            this.toolStripSeparator3,
            this.ClientNametoolStripMenuItem,
            this.toolStripSeparator1,
            this.reconnectToolStripMenuItem,
            this.cutoffToolStripMenuItem,
            this.toolStripSeparator2,
            this.toolStripMenuItemRefreshClients});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.editToolStripMenuItem.Text = "Editar";
            // 
            // toolStripMenuItemChooseInterface
            // 
            this.toolStripMenuItemChooseInterface.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBoxDevicelist});
            this.toolStripMenuItemChooseInterface.Name = "toolStripMenuItemChooseInterface";
            this.toolStripMenuItemChooseInterface.Size = new System.Drawing.Size(193, 22);
            this.toolStripMenuItemChooseInterface.Text = "Selecciona interfaz";
            this.toolStripMenuItemChooseInterface.ToolTipText = "Select the network card to operate on";
            // 
            // toolStripComboBoxDevicelist
            // 
            this.toolStripComboBoxDevicelist.Name = "toolStripComboBoxDevicelist";
            this.toolStripComboBoxDevicelist.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(190, 6);
            // 
            // ClientNametoolStripMenuItem
            // 
            this.ClientNametoolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxClientName});
            this.ClientNametoolStripMenuItem.Name = "ClientNametoolStripMenuItem";
            this.ClientNametoolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.ClientNametoolStripMenuItem.Text = "Introduzca el apodo";
            this.ClientNametoolStripMenuItem.ToolTipText = "Enter a name for the selected client";
            // 
            // toolStripTextBoxClientName
            // 
            this.toolStripTextBoxClientName.Name = "toolStripTextBoxClientName";
            this.toolStripTextBoxClientName.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBoxClientName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBoxClientName_KeyUp);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(190, 6);
            // 
            // cutoffToolStripMenuItem
            // 
            this.cutoffToolStripMenuItem.Name = "cutoffToolStripMenuItem";
            this.cutoffToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutoffToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.cutoffToolStripMenuItem.Text = "Desconectar";
            this.cutoffToolStripMenuItem.ToolTipText = "Disconnect selected clients";
            this.cutoffToolStripMenuItem.Click += new System.EventHandler(this.cutoffToolStripMenuItem_Click);
            // 
            // reconnectToolStripMenuItem
            // 
            this.reconnectToolStripMenuItem.Name = "reconnectToolStripMenuItem";
            this.reconnectToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.reconnectToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.reconnectToolStripMenuItem.Text = "Conectar";
            this.reconnectToolStripMenuItem.ToolTipText = "Stop arp spoofing";
            this.reconnectToolStripMenuItem.Click += new System.EventHandler(this.reconnectToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(190, 6);
            // 
            // toolStripMenuItemRefreshClients
            // 
            this.toolStripMenuItemRefreshClients.Name = "toolStripMenuItemRefreshClients";
            this.toolStripMenuItemRefreshClients.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.toolStripMenuItemRefreshClients.Size = new System.Drawing.Size(193, 22);
            this.toolStripMenuItemRefreshClients.Text = "Recargar";
            this.toolStripMenuItemRefreshClients.ToolTipText = "Refresh active client list";
            this.toolStripMenuItemRefreshClients.Click += new System.EventHandler(this.toolStripMenuItemRefreshClients_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutCSArpToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.helpToolStripMenuItem.Text = "Ayuda";
            // 
            // aboutCSArpToolStripMenuItem
            // 
            this.aboutCSArpToolStripMenuItem.Name = "aboutCSArpToolStripMenuItem";
            this.aboutCSArpToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutCSArpToolStripMenuItem.Text = "Créditos";
            this.aboutCSArpToolStripMenuItem.Click += new System.EventHandler(this.aboutCSArpToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Avenir Book", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatus,
            this.toolStripStatusLabelSpringer,
            this.toolStripStatusScan,
            this.toolStripProgressBarScan,
            this.toolStripSplitButton1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 304);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(604, 29);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatus
            // 
            this.toolStripStatus.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.toolStripStatus.Margin = new System.Windows.Forms.Padding(11, 3, 0, 2);
            this.toolStripStatus.Name = "toolStripStatus";
            this.toolStripStatus.Size = new System.Drawing.Size(39, 24);
            this.toolStripStatus.Text = "Listo";
            // 
            // toolStripStatusLabelSpringer
            // 
            this.toolStripStatusLabelSpringer.Name = "toolStripStatusLabelSpringer";
            this.toolStripStatusLabelSpringer.Size = new System.Drawing.Size(199, 24);
            this.toolStripStatusLabelSpringer.Spring = true;
            // 
            // toolStripStatusScan
            // 
            this.toolStripStatusScan.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.toolStripStatusScan.Name = "toolStripStatusScan";
            this.toolStripStatusScan.Size = new System.Drawing.Size(145, 24);
            this.toolStripStatusScan.Text = "Recarga para escanear";
            // 
            // toolStripProgressBarScan
            // 
            this.toolStripProgressBarScan.Name = "toolStripProgressBarScan";
            this.toolStripProgressBarScan.Size = new System.Drawing.Size(117, 23);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearStripMenuItem,
            this.saveStripMenuItem,
            this.showLogToolStripMenuItem});
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(73, 27);
            this.toolStripSplitButton1.Text = "Registro";
            // 
            // clearStripMenuItem
            // 
            this.clearStripMenuItem.Name = "clearStripMenuItem";
            this.clearStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clearStripMenuItem.Text = "Limpiar";
            this.clearStripMenuItem.Click += new System.EventHandler(this.clearStripMenuItem_Click);
            // 
            // saveStripMenuItem
            // 
            this.saveStripMenuItem.Name = "saveStripMenuItem";
            this.saveStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveStripMenuItem.Text = "Guardar";
            this.saveStripMenuItem.Click += new System.EventHandler(this.saveStripMenuItem_Click);
            // 
            // showLogToolStripMenuItem
            // 
            this.showLogToolStripMenuItem.CheckOnClick = true;
            this.showLogToolStripMenuItem.Name = "showLogToolStripMenuItem";
            this.showLogToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showLogToolStripMenuItem.Text = "Ver registro";
            this.showLogToolStripMenuItem.CheckStateChanged += new System.EventHandler(this.showLogToolStripMenuItem_CheckStateChanged);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderSN,
            this.columnHeaderIP,
            this.columnHeaderMAC,
            this.columnHeaderCutoffStatus,
            this.columnHeaderClientname});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(15, 83);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView1.Name = "listView1";
            this.listView1.ShowItemToolTips = true;
            this.listView1.Size = new System.Drawing.Size(575, 217);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderSN
            // 
            this.columnHeaderSN.Text = "ID";
            this.columnHeaderSN.Width = 50;
            // 
            // columnHeaderIP
            // 
            this.columnHeaderIP.Text = "Dirección IP";
            this.columnHeaderIP.Width = 131;
            // 
            // columnHeaderMAC
            // 
            this.columnHeaderMAC.Text = "Dirección MAC";
            this.columnHeaderMAC.Width = 151;
            // 
            // columnHeaderCutoffStatus
            // 
            this.columnHeaderCutoffStatus.Text = "Estado";
            this.columnHeaderCutoffStatus.Width = 107;
            // 
            // columnHeaderClientname
            // 
            this.columnHeaderClientname.Text = "Apodo";
            this.columnHeaderClientname.Width = 151;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "CSArp";
            this.notifyIcon1.Visible = true;
            // 
            // richTextBoxLog
            // 
            this.richTextBoxLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxLog.Location = new System.Drawing.Point(14, 205);
            this.richTextBoxLog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBoxLog.Name = "richTextBoxLog";
            this.richTextBoxLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBoxLog.Size = new System.Drawing.Size(576, 93);
            this.richTextBoxLog.TabIndex = 3;
            this.richTextBoxLog.Text = "";
            this.richTextBoxLog.Visible = false;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(306, 27);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 45);
            this.refreshButton.TabIndex = 4;
            this.refreshButton.Text = "Escanear";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(417, 27);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 45);
            this.connectButton.TabIndex = 5;
            this.connectButton.Text = "Conectar";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // disconnectButton
            // 
            this.disconnectButton.Location = new System.Drawing.Point(498, 27);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(92, 45);
            this.disconnectButton.TabIndex = 6;
            this.disconnectButton.Text = "Desconectar";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 51);
            this.label1.TabIndex = 7;
            this.label1.Text = "ByeWifi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ready?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 333);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.disconnectButton);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.richTextBoxLog);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Avenir Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ByeWifi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutCSArpToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeaderSN;
        private System.Windows.Forms.ColumnHeader columnHeaderIP;
        private System.Windows.Forms.ColumnHeader columnHeaderMAC;
        private System.Windows.Forms.ColumnHeader columnHeaderCutoffStatus;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutoffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ColumnHeader columnHeaderClientname;
        private System.Windows.Forms.ToolStripMenuItem ClientNametoolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxClientName;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSaveSettings;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemChooseInterface;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxDevicelist;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemMinimize;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRefreshClients;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSpringer;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusScan;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBarScan;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem showLogToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBoxLog;
        private System.Windows.Forms.ToolStripMenuItem saveStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

