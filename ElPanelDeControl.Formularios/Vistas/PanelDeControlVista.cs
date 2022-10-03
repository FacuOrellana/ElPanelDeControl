using ElPanelDeControl.Formularios.Interfaces;
using ElPanelDeControl.Formularios.Presentadores;
using ElPanelDeControl.Dominio.Entidades;
using SensorCaldera;
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
    public delegate void ActualizarPanelDelegate(int a, double b, Nivel n);

    public partial class PanelDeControlVista : Form, IPanelDeControl
    {
        public PresentadorPrincipal _presentador;
        
        public PanelDeControlVista(PresentadorPrincipal presentador)
        {
            _presentador = presentador;
            _presentador.SetVistaPanel(this);
            InitializeComponent();
        }

        private void VerLecturas_Click(object sender, EventArgs e)
        {
            _presentador.MostrarHistorialLecturas();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            _presentador.Desconectar();
            Dispose();
        }

        public void ActualizarPanel(int numeroCaldera, double temperatura, Nivel numeroNivel)
        {
            if (InvokeRequired)
            {
                BeginInvoke((Action)(() => NewMethod(numeroCaldera, temperatura, numeroNivel)));
            }
            else
            {
                NewMethod(numeroCaldera, temperatura, numeroNivel);
            }
            //  CheckForIllegalCrossThreadCalls = false;

            
           
        }

        private void NewMethod(int numeroCaldera, double temperatura, Nivel numeroNivel)
        {
            lblNumeroCaldera.Text = $"{numeroCaldera}";
            lblTemperatura.Text = $"{temperatura}";
            if (numeroNivel == Nivel.Bajo)
            {
                ColorPanel.BackColor = Color.Blue;
            }
            else
            {
                if (numeroNivel == Nivel.Normal)
                {
                    ColorPanel.BackColor = Color.Green;
                }
                else
                {
                    ColorPanel.BackColor = Color.Red;
                }
            }
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            _presentador.Conectar();
            btnConectar.Enabled = false;
        }

        public void MostrarMensaje()
        {
            MessageBox.Show("“Por seguridad, se apagó la caldera debido a que se superó la temperatura límite", "PRECAUCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

    }
}
