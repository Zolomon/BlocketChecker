using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BlocketChecker
{
    class watch
    {
        private parser m_parser;
        private Timer m_timer;
        private string m_title;
        private Form1 m_form;

        public watch( string TITLE, parser PARSER, int SECONDS, Form1 FORM )
        {
            m_title         = TITLE;
            m_parser        = PARSER;
            m_form          = FORM;
            m_timer         = new Timer();
            m_timer.Interval = SECONDS * 1000;
            m_timer.Tick    += new EventHandler(timerTick);
            m_timer.Start();
        }

        private void timerTick(object sender, EventArgs e)
        {
            update();
        }

        public void update()
        {
            m_parser.update();

            if (m_parser.New_since_last_update > 0)
            {
                m_form.updateVisuals();
                m_form.makeBalloon(100, m_title, m_parser.getNotify());
            }
        }

        public string[] getPosts()
        {
            return m_parser.PostsAsStrings;
        }

        public string getNew()
        {
            return m_parser.New_since_last_update + " updated";
        }

        public string getTotal()
        {
            return m_parser.Posts.Count + " total items";
        }

        public string getTitle()
        {
            return m_title;
        }

        public string getURL()
        {
            return m_parser.Website_url;
        }

        public string getTimeout()
        {
            return (m_timer.Interval / 1000).ToString() + " seconds";
        }

        public string getAllInfo()
        {
            return    "Total:   " + getTotal()
                  + "\nNew:     " + getNew()
                  + "\nUpdates: " + getTimeout()
                  + "\nURL:\n" + getURL();
        }

        public override string ToString()
        {
            return m_title;
        }

    }
}
