using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevitAPITrainingRibbon
{
    [Transaction(TransactionMode.Manual)]
    public class Main : IExternalApplication
    {

        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }

        public Result OnStartup(UIControlledApplication application)
        {
            string tabName = "Revit API training";
            application.CreateRibbonTab(tabName);
            string utilsFolderPath = @"C:\ITMO\RevitAPITraining\";

            var panel = application.CreateRibbonPanel(tabName, "Раздел 5");

            var button1 = new PushButtonData("Задание 5.1", "Количество элементов", Path.Combine(utilsFolderPath, "M3Task51.dll"), "M3Task51.Main");
            var button2 = new PushButtonData("Задание 5.2", "Смена типа стены", Path.Combine(utilsFolderPath, "M3Task52.dll"), "M3Task52.Main");

            panel.AddItem(button1);
            panel.AddItem(button2);

            return Result.Succeeded;
        }
    }
}
