using InvoiceParserLib;
using InvoiceParserLib.Models.Entities;
using InvoiceParserLib.Utils;
using Microsoft.Win32;
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
            InvoiceParser inv = new(invoiceFiles[0]);
            Invoice invv = await inv.ParseAsync();
            //List<InvoiceResult> invoiceErrors = await GetInvoiceWithErrorsAsync(invoiceFiles);
            //_invoiceErrors = invoiceErrors.Select(invoice =>
            //            new InvoiceResultViewModel
            //            {
            //                Nombre_Factura = invoice.invoiceName,
            //                Errores_de_Factura = invoice.recordsWithErrors.Select(record =>
            //                new RecordResultViewModel
            //                {
            //                    Nombre_Registro = record.recordName,
            //                    Tipo_Registro = record.recordType,
            //                    Linea_Registro = record.fileLine,
            //                    Errores_de_Registro = record.recordErrors
            //                }).ToList()z
            //            }
            //        ).ToList();
            //Application.Current.Dispatcher.Invoke(() => { GV_ErroresFacturas.ItemsSource = _invoiceErrors; });
            ChangeProgressBarVisibility(Visibility.Collapsed);
            int z = 0;
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
            catch(Exception ex) 
            {
                int x = 0;   
            }
        }
    }
}