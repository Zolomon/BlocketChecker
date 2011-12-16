namespace BlocketChecker
{
    partial class watch_add_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(watch_add_form));
            this.url_textbox = new System.Windows.Forms.TextBox();
            this.ok = new System.Windows.Forms.Button();
            this.seconds_textbox = new System.Windows.Forms.TextBox();
            this.title_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // url_textbox
            // 
            this.url_textbox.Location = new System.Drawing.Point(109, 19);
            this.url_textbox.Name = "url_textbox";
            this.url_textbox.Size = new System.Drawing.Size(355, 20);
            this.url_textbox.TabIndex = 1;
            this.url_textbox.Text = "http://www.blocket.se/hela_sverige?q=hund";
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(526, 19);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(53, 19);
            this.ok.TabIndex = 3;
            this.ok.Text = "ok";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // seconds_textbox
            // 
            this.seconds_textbox.Location = new System.Drawing.Point(471, 19);
            this.seconds_textbox.Name = "seconds_textbox";
            this.seconds_textbox.Size = new System.Drawing.Size(49, 20);
            this.seconds_textbox.TabIndex = 2;
            // 
            // title_textbox
            // 
            this.title_textbox.Location = new System.Drawing.Point(3, 19);
            this.title_textbox.Name = "title_textbox";
            this.title_textbox.Size = new System.Drawing.Size(100, 20);
            this.title_textbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Title                             URL                                            " +
                "                                                                     s.";
            // 
            // watch_add_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 43);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title_textbox);
            this.Controls.Add(this.seconds_textbox);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.url_textbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "watch_add_form";
            this.Text = "Add watch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox url_textbox;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.TextBox seconds_textbox;
        private System.Windows.Forms.TextBox title_textbox;
        private System.Windows.Forms.Label label1;
    }
}