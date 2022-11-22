using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ShutdownManager
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        /// <summary>
        /// InitializeComponent
        /// </summary>
        // [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        // [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.0.0")]
        // public void InitializeComponent()
        /* {

 #line 5 "..\..\..\App.xaml"
             this.StartupUri = new System.Uri("MainWindow.xaml", System.UriKind.Relative);

 #line default
 #line hidden
         }*/

        /// <summary>
        /// Application Entry Point.
        /// </summary>
        [System.STAThreadAttribute()]
        //[System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.0.0")]
        public static void Main()
        {
            string[] args = Environment.GetCommandLineArgs();

            if (args.Length > 1)
            {
                if (args[1].Equals("enable"))
                {
                    UpdateRegistry(true);
                }
                else if (args[1].Equals("disable"))
                {
                    UpdateRegistry(false);
                }

                return;
            }

            ShutdownManager.App app = new ShutdownManager.App();
            app.InitializeComponent();
            app.Run();
        }

        private static void UpdateRegistry(bool enable)
        {
            try
            {
                RegistryKey HideShutdownKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\PolicyManager\\default\\Start\\HideShutDown", true);

                if (enable)
                        HideShutdownKey.SetValue("value", 0);
                else
                        HideShutdownKey.SetValue("value", 1);
            }
            catch (UnauthorizedAccessException UnAuthAccessException)
            {
                MessageBox.Show(String.Format("{0}", UnAuthAccessException.Message), "Error!");

                return;
            }
        }
    }
}
