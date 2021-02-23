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
           

            if ((validaCadena(dateRegistro.SelectedDate.ToString(), "FECHA DE REGISTRO") == true) && (validaCadena(tbMultiLine.Text, "DESCRIPCIÓN") == true) && (validaCadena(TxtNombre.Text, "NOMBRE") == true)   && (validaCadena(TextPagado.Text, "PAGADO") == true) && (validaCadena(TxtVenta.Text, "CANTIDAD") == true) && (validaCadena(PrecioUnit.Text, "PRECIO UNITARIO") == true))
            {
                if ((Textdesc.SelectedItem != null) && (TextIVA.SelectedItem != null))
                {

                    dtmFechaRegistro = dateRegistro.SelectedDate.ToString();
                    strDescripcion = tbMultiLine.Text;
                    strNombre = TxtNombre.Text;

                    strPagado = TextPagado.Text;
                    strCantidad = TxtVenta.Text;
                    strPrecioUnitario = PrecioUnit.Text;

                    lvdatos.Items.Add(new
                    {
                        Nombre = TxtNombre.Text,
                        Venta = TxtVenta.Text,
                        PecUni = PrecioUnit.Text,
                        Descuento = Textdesc.Text
                    });
                }
                else MessageBox.Show("O BIEN TE FALTA EL IVA O EL DESCUENTO...");


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
            String cadena = Textdesc.SelectedItem.ToString();
            String cadena2 = TextIVA.SelectedItem.ToString();
            dblDescuento = Convert.ToDouble(cadena.Substring(38,2));
                dblIva = Convert.ToDouble(cadena2.Substring(38, 2));
            dblAplicarDesc = dblImporte - (dblImporte * dblDescuento);
                dblAplicarIva = dblAplicarDesc + (dblIva * dblImporte);
                string strTotal = dblAplicarIva.ToString();
                TextTotal.Text = strTotal;
          
          
                MessageBox.Show("Algo ha fallado");
          
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                lvdatos.Items.RemoveAt(lvdatos.SelectedIndex);
            }
            catch 
                { MessageBox.Show("LA LISTA ESTA VACIA");
            }
          
        }
    }
}
