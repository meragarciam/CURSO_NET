﻿using System;
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

namespace VideoClub_Madison
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

        private bool validaCadena(String cadena, String titulo)
        {

            if (cadena == "")
            {
                MessageBox.Show("TE FALTA EL DATO: " + " " + titulo);
                return false;
            }
            else return true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string strCodigo;
            string strPrecio;
            string strDescripcion;
            string strCompacDisc;
            string strLibro;
            string strArtista;
            string strDisco;
            string strAutor;
            string strIsbn;


            if (((validaCadena(TxtCodigo.Text, "CODIGO") == true) && (validaCadena(TxtDescripcion.Text, "DESCRIPCIÓN") == true) && (validaCadena(TxtPrecio.Text, "PRECIO") == true)) && ((validaCadena(TxtArtista.Text, "ARTISTA") == true) && (validaCadena(TxtDisco.Text, "DISCO") == true)) || ((validaCadena(TxtAutor.Text, "AUTOR") == true) && (validaCadena(TxtIsbn.Text, "ISBN") == true)))
            {
                if ((RadioDisc.IsChecked != false) || (RadioLibro.IsChecked != false))
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

                    int intCont = 1 + Convert.ToInt32(TextCont.Text);
                    TextCont.Text = intCont.ToString();

                }
                else MessageBox.Show("O BIEN TE FALTA EL IVA O EL DESCUENTO...");


            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar la aplicación?", "Confirmación", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                App.Current.Shutdown();
        }
    }
}
