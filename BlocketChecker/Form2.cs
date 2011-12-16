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
    public partial class watch_add_form : Form
    {
        Form1 m_form;

        public watch_add_form(Form1 FORM)
        {
            InitializeComponent();
            GC.SuppressFinalize(this);
            m_form = FORM;
        }

        private void ok_Click(object sender, EventArgs e)
        {
            if (title_textbox.Text == "" || title_textbox.Text == null || url_textbox.Text == null || url_textbox.Text == "Default" || seconds_textbox.Text == "" || seconds_textbox.Text == null)
            {
                MessageBox.Show("Please fill every textbox..");
            }
            else
            {
                m_form.addWatch(url_textbox.Text, title_textbox.Text, int.Parse(seconds_textbox.Text));
                m_form.updateList();
                m_form.updateVisuals();
                Hide();
            }
        }
    }
}
