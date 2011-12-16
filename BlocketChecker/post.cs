using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlocketChecker
{
    class post
    {
        private string id;
        private string url;
        private string title;
        private string date;
        private string time;

        public post(string ID, string BASEURL, string EXTRAURLLENGTH, string CHAR, string URL, string TITLE, string DATE, string TIME)
        {
            id = ID;                                               // ID har item_

            url = URL;
            
            title = URL;                                            // Title finns i url
            title = title.Substring( title.IndexOf("/", BASEURL.Length) + 1 );  // Title har alltid http://..../..
                                                                    //  21 ger skane/titel
                                                                    //  22 ger titel
            title = title.Substring( 0, title.Length-id.Length-EXTRAURLLENGTH.Length ); // Title har alltid ID.htm
            title = title.Replace(CHAR, " ");

            date = DATE;
            if (date == "Idag")      date = (DateTime.Today.ToString()).Substring(0, 10);               // 0000-00-00 ....
            else if (date == "Igår") date = (DateTime.Today.AddDays(-1).ToString()).Substring(0, 10);   // Föregående dag
            else if (date == "")     date = date;
            else                     date = (DateTime.Parse(date).ToString()).Substring(0, 10);         // 00-feb -> 0000-00-00

            time = TIME;
        }

        public override string  ToString()
        {
            return date + " " + time +  " - " + title;// +" - " + url;
        }
    }
}
