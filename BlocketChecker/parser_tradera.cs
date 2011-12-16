using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace BlocketChecker
{
    class parser_tradera : parser
    {
        public parser_tradera(string url)
            : base(url)
        {
        }

        public override void update()
        {
            // Resets globals that are relevant for every site
            // .. (meaning for now - new items on update)
            base.update();
            posts.Clear();
             //GC.Collect();

            // Get stuff from tradera. First page only.
            fetch(website_url);
            parse();
        }

        public override void fetch(string url)
        {
            base.fetch(url);
        }

        public override void parse()
        {
            // Get every ITEM
            int place = website.IndexOf("object-table");   // This is where the posts starts
            Regex items = new Regex("(class='itemrow)");
            MatchCollection mc = items.Matches(website, place);

            // Get every info of ITEM
            Regex id = new Regex("(auktion_[0-9]+_[0-9]+)");
            Regex url = new Regex("(/(.*)'><IMG)");
            Regex date = new Regex("([0-9]+\\sminut)|([0-9]+\\sminuter)|([0-9]+\\stim\\s[0-9]+\\smin)|([0-9]+\\smin)|([0-9]{2}\\s[a-z]{3}\\s[0-9]{2}:[0-9]{2})");
            Match item_id;
            Match item_url;
            Match item_date;
            string str_url;
            
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
                item_id     = id.Match(website, m.Index);
                item_url    = url.Match(website, m.Index); // get url
                str_url     = item_url.Value;
                str_url     = "http://www.tradera.com/" + str_url.Substring(0, str_url.Length - 6); // fix url
                item_date   = date.Match(website, m.Index);

                if (!posts.ContainsKey(item_id.Value))
                {
                    temp.Add(item_id.Value, new post(item_id.Value, "http://www.tradera.com/", "", "-", str_url, "NULL", "", item_date.Value));

                        string[] howmany = item_date.Value.Split(' ');
                        if (howmany.Length == 2)
                        {
                            new_since_last_update++;
                        }
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
            return new_since_last_update.ToString() + " items with under 1 hour left";
        }

    }
}
