using InvoiceProcessor;
using InvoiceProcessor.Models.Entities;
using InvoiceProcessor.Utils;
using Microsoft.Win32;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace InvoiceProcessorUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ValidatingProgress.Visibility = Visibility.Collapsed;
        }

        List<string> invoiceFiles = [];
        protected async Task FillGrid(List<string> invoiceFiles)
        {
            Stopwatch sw = Stopwatch.StartNew();
            InvoiceParser inv = new(invoiceFiles[0], Enums.OriginOfInvoiceContent.FromFilePath, 10);
            Invoice invv = await Task.FromResult(inv.ParseAsync().Result);
            sw.Stop();
            string timeElapsed = $"{Math.Round(sw.Elapsed.TotalMinutes,3)} minutos";
            //Application.Current.Dispatcher.Invoke(() => { GV_ErroresFacturas.ItemsSource = _invoiceErrors; });
            ChangeProgressBarVisibility(Visibility.Collapsed);
        }
        protected void ChangeProgressBarVisibility(Visibility visibility)
        {
            Application.Current.Dispatcher.Invoke(() => { ValidatingProgress.Visibility = visibility; });
        }

        private void btnSeleccionarFactura_Click(object sender, RoutedEventArgs e)
        {
            try{
                OpenFileDialog fileDialog = new()
                {
                    Multiselect = false,
                    Filter = "Text files (*.txt) | *.txt"
                };

                if (fileDialog.ShowDialog() == true)
                {
                    invoiceFiles = fileDialog.FileNames.ToList();
                    if (invoiceFiles.HasElements())
                    {
                        ChangeProgressBarVisibility(Visibility.Visible);
                        Task.Run(() => FillGrid(invoiceFiles));
                    }
                } 
            }
            catch(Exception) 
            {
                
            }
        }
    }
}