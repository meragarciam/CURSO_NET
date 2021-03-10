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

namespace Alumnos
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
        DataClasses1DataContext alumno = new DataClasses1DataContext();
        private void MyDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        void cargarCombo()
        {
            var cargaCombo = from a in alumno.ALUMNOS
                             select a.codigo;
            textCodigo.Text = cargaCombo.ToString();
        }
        void cargarGrid()
        {
            var cargaGrid = from a in alumno.ALUMNOS
                            select a;
            MyDataGrid.ItemsSource = cargaGrid;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cargarCombo();
            cargarGrid();
        }
        private void buttonAñadir_Click(object sender, EventArgs e)
        {
            ALUMNOS MyAlumno = new ALUMNOS();
            MyAlumno.codigo = textCodigo.Text;
            MyAlumno.dni = textDNI.Text;
            MyAlumno.nombre = textNombre.Text;
            MyAlumno.turno = comboTurno.SelectedItem.ToString();
            MyAlumno.sexo = comboSexo.SelectedItem.ToString();
            alumno.ALUMNOS.InsertOnSubmit(MyAlumno);
            alumno.SubmitChanges();
            cargarGrid();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textCodigo.Text);
            ALUMNOS MyAlumno = alumno.ALUMNOS.Single(a=> a.codigo== textCodigo1.Text);
            MyAlumno.codigo = textCodigo.Text;
            MyAlumno.dni = textDNI.Text;
            MyAlumno.nombre = textNombre.Text;
            MyAlumno.turno = comboTurno.SelectedItem.ToString();
            MyAlumno.sexo = comboSexo.SelectedItem.ToString();
            alumno.SubmitChanges();
            cargarGrid();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            ALUMNOS MyAlumno = alumno.ALUMNOS.Single(a => a.codigo == textCodigo1.Text);
            alumno.ALUMNOS.DeleteOnSubmit(MyAlumno);
            alumno.SubmitChanges();
            cargarGrid();
        }

        
    }
}
