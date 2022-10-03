using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElPanelDeControl.Dominio.Contratos;
using ElPanelDeControl.Dominio.Entidades;
using ElPanelDeControl.Formularios.Interfaces;
using ElPanelDeControl.Formularios.Vistas;
using SensorCaldera;

namespace ElPanelDeControl.Formularios.Presentadores
{
    
    public class PresentadorPrincipal
    {
        private IPanelDeControl _panel;
        private IHistorialLecturas _historialLecturas;
        private ILecturas _repositorio;               
        private ISensor _sensor;
        ActualizarPanelDelegate actualizar;
        public event Action<double> Apagar;



        public PresentadorPrincipal(IHistorialLecturas historialLecturas, ILecturas repositorio,ISensor sensor)
        {
            _sensor = sensor;
            _historialLecturas = historialLecturas;
            _repositorio = repositorio;
            _historialLecturas.SetPresentador(this);
            _historialLecturas.ActualizarHistorial();
            Apagar += ApagadoEmergencia;

        }

        public void LeerLecturas(double valor)
        {
            var lectura = AgregarLectura(valor);
            Apagar(valor);
            _historialLecturas.ActualizarHistorial();
            actualizar(lectura.CalderaId, lectura.Temperatura, lectura.Nivel);
        }

        public void ApagadoEmergencia (double valor)
        {
            if (valor > 179.0)
            {
                _panel.MostrarMensaje();
                _sensor.Desconectar();
                return;
            }
        }

        public List<Lectura> ActualizarLecturas()
        {
            return _repositorio.GetLecturas();
        }


        public void SetVistaPanel(IPanelDeControl vista)
        {
            _panel = vista;
            actualizar += _panel.ActualizarPanel;
        }

       public void MostrarHistorialLecturas()
        {
            _historialLecturas.Mostrar();
        }

       public Lectura AgregarLectura(double valorTemperatura)
        {
            Lectura lectura = new Lectura();
            lectura.CalderaId = Simulador.Caldera.Numero;
            lectura.Fecha = DateTime.Now;
            lectura.Temperatura = valorTemperatura;
            lectura.Nivel = lectura.DeterminarNivel(valorTemperatura);
            _repositorio.AgregarLectura(lectura);            
            return lectura;
        }

        public void Conectar()
        {
            _sensor.Conectar();
            Simulador.Caldera.LecturaTomada += LeerLecturas;
        }

        public void Desconectar()
        {
            _sensor.Desconectar();
        }

        public void ActualizarPanel(Lectura lectura)
        {
            _panel.ActualizarPanel(lectura.CalderaId,lectura.Temperatura,lectura.Nivel);

        }
        
    
    }
}
