using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace ShutdownManager
{
    /// <summary>
    /// Interaction logic for ConfirmShutdown.xaml
    /// </summary>
    public partial class ConfirmShutdown : Window
    {
        private string validationCode;
        private string prevValidationCodeEntry = "";
        public ConfirmShutdown()
        {
            InitializeComponent();
        }

        private void TextValidation_Changed(object sender, TextChangedEventArgs e)
        {
            string enteredCode = txtBoxConfirmShutdown.Text; // String.Format("{0}{1}{2}-{3}{4}{5}", txtBox1.Text, txtBox2.Text, txtBox3.Text, txtBox4.Text, txtBox5.Text, txtBox6.Text);
            if (validationCode.Equals(enteredCode))
            {
                // Shut down
                Process.Start("shutdown", "/s /t 2");

                lblShuttingDown.Visibility = Visibility.Visible;
            }


            if (prevValidationCodeEntry.Length == 2 && txtBoxConfirmShutdown.Text.Length == 3)
            {
                txtBoxConfirmShutdown.Text += "-";
            }

            txtBoxConfirmShutdown.TextChanged -= TextValidation_Changed;

            prevValidationCodeEntry = enteredCode;
            txtBoxConfirmShutdown.Select(txtBoxConfirmShutdown.Text.Length, 0);

            txtBoxConfirmShutdown.TextChanged += TextValidation_Changed;
        }

        private void CancelShutdown_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DateTime now = DateTime.Now;

            long code = now.Ticks % 1000000;

            validationCode = code.ToString().Insert(3, "-");

            validationCode += new string('0', 7 - validationCode.Length);

            this.lblValidationCode.Content = validationCode;
        }
    }
}
