using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace BlocketChecker
{
    class parser_blocket : parser
    {
        private int pages;

        public parser_blocket(string url) : base(url)
        {
            pages = 10;
        }

        public override void update()
        {
            // Resets globals that are relevant for every site
            // .. (meaning for now - new items on update)
            base.update();

            // Fetches from pagesite "pages" and gets every site
            // .. towards the beginning
            for (int i = pages; i > 0; i--)
            {
                fetch(website_url + "&o=" + i.ToString());
                parse();
            }
        }

        public override void fetch(string url)
        {
            base.fetch(url);
        }

        public override void parse()
        {
            // Get every ITEM_XXXXXXX
            int place           = website.IndexOf("list_mode_thumb");   // This is where the posts starts
            Regex items         = new Regex("(item_[0-9]+)");
            MatchCollection mc  = items.Matches(website, place);

            // Get every info of ITEM_XXXXXXX
            Regex url           = new Regex("(http://.+htm)");
            Regex date          = new Regex("(Idag|Igår|([0-9]+ [a-zA-Z]{3}))");
            Regex date_detail   = new Regex("([0-9]{2}:[0-9]{2})");
            Match item_url;
            Match item_date;
            Match item_date_detail;

            // The following code does the following
            // .. Find every date/time/url
            // .. Post these in a temporary list
            // .. Post the "last/real" list at the end
            // .. .. of the temp-list (for right order)
            // .. Make the temp-list the main list
            // .. .. because it is in the right order.
            Dictionary<string, post> temp = new Dictionary<string, post>();

            foreach (Match m in mc)
            {
                item_url            = url.Match(website, m.Index);
                item_date           = date.Match(website, m.Index);
                item_date_detail    = date_detail.Match(website, m.Index);

                string id           = m.Value.Substring(5);   // Removes "item_"

                if (!posts.ContainsKey(id))
                {
                    temp.Add(id, new post(id, "http://www.blocket.se/", ".htm", "_", item_url.Value, "NULL", item_date.Value, item_date_detail.Value));
                    new_since_last_update++;
                }
            }

            foreach (KeyValuePair<string, post> p in posts)
            {
                temp.Add(p.Key, p.Value);
            }

            posts.Clear();
            posts = temp;
        }

        public override string getNotify()
        {
            return new_since_last_update.ToString() + " newly added items";
        }

    }
}
