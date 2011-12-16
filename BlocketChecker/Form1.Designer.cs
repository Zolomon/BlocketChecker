namespace BlocketChecker
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
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.listbox = new System.Windows.Forms.ListBox();
            this.info = new System.Windows.Forms.Label();
            this.watches_listbox = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.options_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.options_menu_popups = new System.Windows.Forms.ToolStripMenuItem();
            this.options_menu_refresh = new System.Windows.Forms.ToolStripMenuItem();
            this.options_menu_newwatch = new System.Windows.Forms.ToolStripMenuItem();
            this.info_groupbox = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.info_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Blocket checker";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // listbox
            // 
            this.listbox.FormattingEnabled = true;
            this.listbox.Location = new System.Drawing.Point(12, 129);
            this.listbox.Name = "listbox";
            this.listbox.ScrollAlwaysVisible = true;
            this.listbox.Size = new System.Drawing.Size(360, 303);
            this.listbox.TabIndex = 3;
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Font = new System.Drawing.Font("Courier New", 7.5F);
            this.info.Location = new System.Drawing.Point(6, 16);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(17, 12);
            this.info.TabIndex = 7;
            this.info.Text = "..";
            // 
            // watches_listbox
            // 
            this.watches_listbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.watches_listbox.FormattingEnabled = true;
            this.watches_listbox.Location = new System.Drawing.Point(270, 2);
            this.watches_listbox.Name = "watches_listbox";
            this.watches_listbox.Size = new System.Drawing.Size(102, 21);
            this.watches_listbox.TabIndex = 10;
            this.watches_listbox.SelectedIndexChanged += new System.EventHandler(this.watches_listbox_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.options_menu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(384, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // options_menu
            // 
            this.options_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.options_menu_popups,
            this.options_menu_refresh,
            this.options_menu_newwatch});
            this.options_menu.Name = "options_menu";
            this.options_menu.Size = new System.Drawing.Size(61, 20);
            this.options_menu.Text = "Options";
            // 
            // options_menu_popups
            // 
            this.options_menu_popups.Name = "options_menu_popups";
            this.options_menu_popups.Size = new System.Drawing.Size(154, 22);
            this.options_menu_popups.Text = "Popups is ON";
            this.options_menu_popups.Click += new System.EventHandler(this.popupsToolStripMenuItem_Click);
            // 
            // options_menu_refresh
            // 
            this.options_menu_refresh.Name = "options_menu_refresh";
            this.options_menu_refresh.Size = new System.Drawing.Size(154, 22);
            this.options_menu_refresh.Text = "Refresh current";
            this.options_menu_refresh.Click += new System.EventHandler(this.options_menu_refresh_Click);
            // 
            // options_menu_newwatch
            // 
            this.options_menu_newwatch.Name = "options_menu_newwatch";
            this.options_menu_newwatch.Size = new System.Drawing.Size(154, 22);
            this.options_menu_newwatch.Text = "New watch";
            this.options_menu_newwatch.Click += new System.EventHandler(this.options_menu_newwatch_Click);
            // 
            // info_groupbox
            // 
            this.info_groupbox.Controls.Add(this.info);
            this.info_groupbox.Location = new System.Drawing.Point(12, 28);
            this.info_groupbox.Name = "info_groupbox";
            this.info_groupbox.Size = new System.Drawing.Size(360, 95);
            this.info_groupbox.TabIndex = 12;
            this.info_groupbox.TabStop = false;
            this.info_groupbox.Text = "info";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 439);
            this.Controls.Add(this.info_groupbox);
            this.Controls.Add(this.watches_listbox);
            this.Controls.Add(this.listbox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BlocketChecker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.info_groupbox.ResumeLayout(false);
            this.info_groupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ListBox listbox;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.ComboBox watches_listbox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem options_menu;
        private System.Windows.Forms.ToolStripMenuItem options_menu_popups;
        private System.Windows.Forms.ToolStripMenuItem options_menu_newwatch;
        private System.Windows.Forms.GroupBox info_groupbox;
        private System.Windows.Forms.ToolStripMenuItem options_menu_refresh;
    }
}

