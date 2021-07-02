﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModelBasedApproach.UserControl
{
    public static class MyCustomControl
    {
        public static IHtmlString MyLabel(string content)
        {
            string htmlstring = String.Format("<label>{0}</label>", content);
            return new HtmlString(htmlstring);
        }

        public static IHtmlString createUrControl(this HtmlHelper helper, string content,string fun,string Event)
        {
            string htmlstring = "<input type=" + content +" "+Event+"="+fun+">";
            return new HtmlString(htmlstring);
        }
    }
}