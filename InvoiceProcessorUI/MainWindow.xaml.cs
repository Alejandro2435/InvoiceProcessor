using InvoiceProcessor;
using InvoiceProcessor.Models.Entities;
using InvoiceProcessor.Utils;
using Microsoft.Win32;
using System.Diagnostics;
using System.IO;
using System.Windows;

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
            string[] _invoice = File.ReadAllLines(invoiceFiles[0]);
            List<(int, string)> _invoiceLines = _invoice.Select((line, idx) => (idx + 1 , line)).ToList();
            InvoiceParser inv = new(_invoiceLines, 1000);
            Invoice invv = await Task.FromResult(inv.ParseAsync().Result);
            sw.Stop();
            string timeElapsed = $"{Math.Round((double)sw.ElapsedMilliseconds / 60000, 3)} minutos";
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