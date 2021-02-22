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

namespace MACRO_WPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }


        private bool validaCadena(String cadena, String titulo)
        {

            if (cadena == "")
            {
                MessageBox.Show("TE FALTA EL DATO: " +" "+ titulo);
                return false;
            }
            else return true;
        }



        public void Button_Click(object sender, RoutedEventArgs e)
        {
            
            string dtmFechaRegistro;
            string strDescripcion;
            string strNombre;
            string strDescuento;
            string strIva;
            string strCantidad;
            string strPrecioUnitario;
            string strPagado;
           

            if ((validaCadena(dateRegistro.SelectedDate.ToString(), "FECHA DE REGISTRO") == true) && (validaCadena(tbMultiLine.Text, "DESCRIPCIÓN") == true) && (validaCadena(TxtNombre.Text, "NOMBRE") == true) && (validaCadena(Textdesc.SelectedItem.ToString(), "DESCUENTO") == true) && (validaCadena(TextIVA.SelectedItem.ToString(), "IVA") == true) && (validaCadena(TextPagado.ToString(), "PAGADO") == true) )
            {
                try 
                { 
                    dtmFechaRegistro = dateRegistro.SelectedDate.ToString().Substring(38);
                    strDescripcion = tbMultiLine.Text;
                    strNombre = TxtNombre.Text;
                    strDescuento = Textdesc.SelectedItem.ToString().Substring(38);
                    strIva = TextIVA.SelectedItem.ToString().Substring(38);
                    strPagado = TextPagado.Text;
                    strCantidad= TxtVenta.Text;
                    strPrecioUnitario = PrecioUnit.Text;

                    lvdatos.Items.Add(new
                    {
                        Nombre = TxtNombre.Text,
                        Venta = TxtVenta.Text,
                        PecUni = PrecioUnit.Text,
                        Descuento = Textdesc.Text
                    });
                }
                catch
                {
                    MessageBox.Show("Hay algún dato erróneo, revise los campos introducidos");
                }
            }

        }

        public void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
         
                double dblImporte;
                double dblDescuento;
                double dblIva;
                double dblAplicarDesc;
                double dblAplicarIva;
                double dblVenta = Convert.ToDouble(TxtVenta.Text);
                double dblPrecioUnidad = Convert.ToDouble(PrecioUnit.Text);
                dblImporte = dblVenta * dblPrecioUnidad;
                dblDescuento = Convert.ToDouble(Textdesc.SelectedItem); 
                dblIva = Convert.ToDouble(TextIVA.SelectedItem);
                dblAplicarDesc = dblImporte - (dblImporte * dblDescuento);
                dblAplicarIva = dblAplicarDesc + (dblIva * dblImporte);
                string strTotal = dblAplicarIva.ToString();
                strTotal = TextTotal.Text;
        }
            
            
            
           

        
    }
}
