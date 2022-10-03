using ElPanelDeControl.Formularios.Interfaces;
using ElPanelDeControl.Formularios.Presentadores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElPanelDeControl.Formularios.Vistas
{
   

    public partial class HistorialLecturasVista : Form,IHistorialLecturas
    {
        PresentadorPrincipal _presentador;

        public HistorialLecturasVista()
        {
            InitializeComponent();            
        }

        public void SetPresentador(PresentadorPrincipal presentador)
        {
            _presentador = presentador;
        }


        public void ActualizarHistorial()
        {
            CheckForIllegalCrossThreadCalls = false;
            lecturaBindingSource.ResetBindings(false);
            lecturaBindingSource.DataSource = _presentador.ActualizarLecturas();
            CheckForIllegalCrossThreadCalls = true;
        }

        public void Mostrar()
        {
            ShowDialog();
        }
    }
}
