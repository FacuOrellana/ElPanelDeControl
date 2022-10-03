using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ElPanelDeControl.Dominio.Contratos;
using ElPanelDeControl.Formularios.Interfaces;
using ElPanelDeControl.Formularios.Vistas;
using ElPanelDeControl.AccesoADatos;
using Unity;
using ElPanelDeControl.Dominio.Entidades;

namespace ElPanelDeControl.Formularios
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
            var contenedor = new UnityContainer();
            contenedor.RegisterType<IHistorialLecturas, HistorialLecturasVista>();
            contenedor.RegisterType<ILecturas, Repositorio>();
            contenedor.RegisterType<ISensor, Sensor>();
            var vista = contenedor.Resolve<PanelDeControlVista>();

            Application.Run(vista);
        }
    }
}
