using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BlocketChecker
{
    public partial class Form1 : Form
    {
        private List<watch> watches;
        private watch current_watch;
        private bool option_popups;
        private watch_add_form add_form;

        public Form1()
        {
            InitializeComponent();

            // Skapar en form för att adda watches redan nu.
            add_form            = new watch_add_form(this);
            add_form.Visible    = false;

            // Set some options
            option_popups = true;

            // Create some default watches/parsers
            watches = new List<watch>();
            watches.Add(new watch("Blocket - Allt", new parser_blocket("http://www.blocket.se/hela_sverige?q="), 3600, this));
            //watches.Add(new watch("Blocket - Iphone", new parser_blocket("http://www.blocket.se/hela_sverige?q=iphone"), 120, this));
            //watches.Add(new watch("Tradera - Sista minuten", new parser_tradera("http://www.tradera.com/category/category.aspx?special=1"), 2, this));
            current_watch = watches[0];
            watches_listbox.DataSource = watches;
            watches_listbox.SelectedIndex = 0;

            // Manual gets the first round of items
            //foreach (watch w in watches)
            //{
            //    w.update();
            //}
            updateVisuals();
        }

        public void updateVisuals()
        {
            listbox.DataSource  = current_watch.getPosts();
            info.Text           = current_watch.getAllInfo();
        }

        public void updateList()
        {
            watches_listbox.DataSource = null;
            watches_listbox.DataSource = watches;
        }

        public void addWatch(string URL, string TITLE, int SECONDS)
        {
            if (URL[11] == 't') //..Tradera..
            {
                watches.Add(new watch(TITLE, new parser_tradera(URL), SECONDS, this));
            }
            else if (URL[11] == 'b') // ..Blocket..
            {
                watches.Add(new watch(TITLE, new parser_blocket(URL), SECONDS, this));
            }
            else
            {
                MessageBox.Show("Adress MUST be in this form\nhttp://www.tradera.com or blocket.se");
            }
        }

        public void makeBalloon(int MILLISECONDS, string TITLE, string TEXT)
        {
            if (option_popups)
            {
                notifyIcon.ShowBalloonTip(MILLISECONDS, TITLE, TEXT, ToolTipIcon.None);
            }
        }

        // Hide if minimized ( still in tray )
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                Hide();
            }
        }

        // Show if doubleclicking the icon.
        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void watches_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (watches_listbox.SelectedIndex == -1)
            {
                watches_listbox.SelectedIndex = 0;
            }
            current_watch = watches[watches_listbox.SelectedIndex];
            updateVisuals();
        }

        private void popupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            option_popups = !option_popups;
            options_menu_popups.Text = option_popups ? "Popups is ON" : "Popups is OFF";
        }

        private void options_menu_newwatch_Click(object sender, EventArgs e)
        {
            add_form.Visible = true;
        }

        private void options_menu_refresh_Click(object sender, EventArgs e)
        {
            // Manually update
            watches[watches_listbox.SelectedIndex].update();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }    
    }
}
