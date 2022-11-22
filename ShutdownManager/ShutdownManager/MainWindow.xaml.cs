using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Security.AccessControl;
using System.Diagnostics;
using System.Xml.Linq;
using System.ComponentModel;

namespace ShutdownManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonDisableShutdown_Click(object sender, RoutedEventArgs e)
        {
            if (LaunchProcessToUpdate(false))
            {
                MessageBox.Show("The 'Shut down' option is now hidden in the Start menu.", "Shutdown Manager");
            }
            else
            {
                MessageBox.Show("The 'Shut down' option was not hidden. Please allow the process to with admin rights.", "Shutdown Manager");
            }
        }

        private void ButtonEnableShutdown_Click(object sender, RoutedEventArgs e)
        {
            if (LaunchProcessToUpdate(true))
            {
                MessageBox.Show("The 'Shut down' option is now shown in the Start menu.", "Shutdown Manager");
            }
            else
            {
                MessageBox.Show("The 'Shut down' option was not made visible in the Start menu. Please allow the process to with admin rights.", "Shutdown Manager");
            }
        }

        private void ButtonPerformShutdown_Click(object sender, RoutedEventArgs e)
        {
            //MessageBoxResult MsgBoxResult = MessageBox.Show("Are you sure that you want to shutdown the machine?", "Shutdown Manager", MessageBoxButton.YesNo, MessageBoxImage.Question);

            //if (MsgBoxResult == MessageBoxResult.Yes)
            {
                ConfirmShutdown confirm = new ConfirmShutdown();
                confirm.Show();
            }
        }

        private bool LaunchProcessToUpdate(bool MakeVisible)
        {
            // Prepare the process to run
            ProcessStartInfo start = new ProcessStartInfo();
            // Enter in the command line arguments, everything you would enter after the executable name itself
            start.Arguments = MakeVisible ? "enable" : "disable";

            // Enter the executable to run, including the complete path
            start.FileName = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;

            // Do you want to show a console window?
            start.UseShellExecute = true;
            start.Verb = "runas";
            int exitCode;

            // Run the external process & wait for it to finish
            const int ERROR_CANCELLED = 1223; //The operation was canceled by the user.

            try
            {
                Process proc = Process.Start(start);

                proc.WaitForExit(2000);

                // Retrieve the app's exit code
                exitCode = proc.ExitCode;
            }
            catch (Win32Exception ex)
            {
                if (ex.NativeErrorCode == ERROR_CANCELLED)
                    return false;
                else
                    throw;
            }

            return true;
        }
    }
}
