using ElPanelDeControl.Dominio.Contratos;
using SensorCaldera;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElPanelDeControl.Dominio.Entidades
{
    public class Sensor: ISensor
    {
        private Simulador _simulador;
        private double valorTemperatura;

        public Sensor()
        {
            _simulador = Simulador.Caldera;           
        }

        public void LeerLecturas(double valor)
        {
            valorTemperatura = valor;            
        }

        public double GetLectura()
        {
            return valorTemperatura;
        }     

        public int Conectar()
        {            
            return Simulador.Caldera.Conectar();
        }

        public void Desconectar()
        {
            Simulador.Caldera.Desconectar();
        }


    }
}
