using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cesar_9
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Alumno());
            Alumno alumno1 = new Alumno();
            alumno1.Inicializar();
            alumno1.AsignarCurso();
            alumno1.Imprimir();
        }
    }
}
