using System;
using Eto.Drawing;
using Eto.Forms;

namespace EtoWebView2Test
{

    class Startup
    {
        [STAThread]
        public static void Main(string[] args)
        {
            new Application().Run(MainForm.CreateNew());
        }
    }
    public class MainForm
    {
        public static Dialog CreateNew()
        {

            // controls
            var label = new Label { Text = "Hello in C#!" };
            var webView = new WebView { Height = 600 };
            webView.Url = new Uri("https://www.whatsmybrowser.org/");

            // layout
            var layout = new DynamicLayout
            {
                DefaultSpacing = new Size(5, 5),
                Padding = 10
            };
            layout.Add(label);
            layout.Add(webView);
            layout.AddSpace();


            // create form
            var form = new Dialog
            {
                ClientSize = new Size(1000, 600),
                BackgroundColor = Colors.White,
                Padding = 10,
                Resizable = true,
                Title = "Stand alone Eto",

                Content = layout

            };

            form.ShowModal();
            Environment.Exit(0);
            return form;
        }
    }
}
