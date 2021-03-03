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


namespace Ejercicio_WPF_1
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

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void buttonAceptar_Click(object sender, RoutedEventArgs e)
        {

         string strNombre;
         string strCorreo;
            //DateTime dtmFechaSalida;
            // DateTime dtmFechaSalida;
         string strEmpresa;
         string strSalida;
         string strLlegada;
         string strLugarSalida;
         string strLugarLlegada;
         

           

                strCorreo = textCorreoelectronico.Text;
                strNombre = textNombre.Text;
            try
            {
                strEmpresa = comboEmpresa.SelectedItem.ToString();
                
                strSalida = dateSalida.SelectedDate.ToString();
                strLlegada = dateLlegada.SelectedDate.ToString();
                
                if (strSalida == "")
                {
                    MessageBox.Show("debe seleccionar la fecha de salida");
                }
                else if (strLlegada == "")
                {
                    MessageBox.Show("debe seleccionar la fecha de llegada");
                }

                else if (radio1.IsChecked == false && radio2.IsChecked == false && radio3.IsChecked == false && radio4.IsChecked == false)
                    MessageBox.Show("hay que seleccionar numero de personas");
                else
                {
                    strLugarSalida = comboLugarSalida.SelectedItem.ToString();
                    strLugarLlegada = comboLugarLlegada.SelectedItem.ToString();
                    string cadena = "Estimado" + " " + strNombre + "\n" + "Reserva realizada para el día" + " " + "\n" + "Salidad desde" + " " + strLugarSalida + "\n" + "Llegada a" + " " + strLugarLlegada;
                    MessageBox.Show(cadena);
                }
            }

            catch
            {
                if (textNombre.Text=="") MessageBox.Show("Falta nombre de contacto");
                else if(textCorreoelectronico.Text=="") MessageBox.Show("Falta correo electronico de contacto");
                else if (comboEmpresa.SelectedItem==null) 
                {
                    MessageBox.Show("debe seleccionar una empresa");
                }
                else if (comboLugarLlegada.SelectedItem == null )
                {
                    MessageBox.Show("debe seleccionar un destino");
                }
                else if ( comboLugarSalida.SelectedItem == null)
                {
                    MessageBox.Show("debe seleccionar el lugar de origen");
                }
                

         


            }

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
           
        }

        private void textNombre_TextChanged(object sender, TextChangedEventArgs e)
        {
          
        }

        private void textcorreoelectronico_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void buttonCancelar_Click(object sender, RoutedEventArgs e)
        {
            //if (MessageBox.Show("¿Desea Salir", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            //{
            //    this.Close();
            //}
        }

        private void radio2_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
