using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eto.Forms;
using Eto.Drawing;
using Microsoft.Web.WebView2.Core;

namespace EtoRevit
{
    internal class HelloWebView2 : Form
    {
        public HelloWebView2()
        {
            Title = "Hello Web View2";
            ClientSize = new Size(800, 600);
            BackgroundColor = Colors.White;
            Resizable = true;

            Eto.Wpf.Forms.Controls.WebView2Loader.InstallMode = Eto.Wpf.Forms.Controls.WebView2InstallMode.Automatic;
            // controls
            var label = new Label { Text = "Hello in C#!222" };
            var webView = new WebView { Height = 600 };

            webView.Url = new Uri("https://www.whatsmybrowser.org/");

            //uncomment this line to test WebView2Loader Creation
            //var h2 = Eto.Wpf.Forms.Controls.WebView2Loader.Create();
            
            // layout
            var layout = new DynamicLayout
            {
                DefaultSpacing = new Size(5, 5),
                Padding = 10
            };
            layout.Add(label);
            layout.Add(webView);
            layout.AddSpace();
            Content = layout;
        }
    }
}
