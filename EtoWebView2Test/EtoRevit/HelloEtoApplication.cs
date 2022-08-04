using System.IO;
using System.Reflection;
using Autodesk.Revit.UI;
using Eto.Forms;

namespace EtoRevit
{
    class HelloEtoApplication : IExternalApplication
    {
        public static Application EtoApp;
        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;

        }

        public Result OnStartup(UIControlledApplication application)
        {
            //Create Rebbon Tab
            application.CreateRibbonTab("HellowEtoTest");

            string path = Assembly.GetExecutingAssembly().Location;

            PushButtonData helloEtoButton = new PushButtonData("HelloETO", "Launch ETO", path, "EtoRevit.HelloEtoCommand");

            RibbonPanel panel = application.CreateRibbonPanel("HellowEtoTest", "EtoCommands");

            PushButton button = panel.AddItem(helloEtoButton) as PushButton;

            try
            {
                EtoApp = new Application();

            }
            catch
            {
                EtoApp = Application.Instance;

            }

            return Result.Succeeded;
        }

    }
}
