using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlocketChecker
{
    class parser
    {
        protected Dictionary<string,post>   posts;
        public Dictionary<string,post>      Posts
        {
            get
            {
                return posts;
            }
        }
        public string[]                     PostsAsStrings
        {
            get
            {
                string[] results = new string[Posts.Count];

                int i = 0;
                foreach (KeyValuePair<string, post> p in Posts)
                {
                    results[i++] = p.Value.ToString();
                }

                return results;
            }
        }
        protected string                    website_url;
        public string                       Website_url
        {
            get 
            {
                return website_url;
            }
        }
        protected int                       new_since_last_update;
        public int                          New_since_last_update
        {
            get { return new_since_last_update; }
        }
        protected string                    website;
        public string                       Website
        {
            get
            {
                return website;
            }
        }

        // Constructor initiates stuff
        public parser(string url)
        {
            website_url = url;
            posts       = new Dictionary<string,post>();
        }

        public virtual void update()
        {
            // Reset "global variables"
            new_since_last_update = 0;
        }

        // Get source-code
        public virtual void fetch(string url)
        {
            if (url == "") return;

            // Get urls source
            System.Net.WebClient webClient  = new System.Net.WebClient();
            website                         = webClient.DownloadString(url);
            webClient.Dispose();
        }

        public virtual void parse()
        {   
        }

        public virtual string getNotify()
        {
            return "";
        }
    }
}
