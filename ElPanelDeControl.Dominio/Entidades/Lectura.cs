using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SensorCaldera;

namespace ElPanelDeControl.Dominio.Entidades
{
    public class Lectura
    {
        public int Id { get; set; }
        public int CalderaId { get; set; }
        public DateTime Fecha { get; set; }
        public double Temperatura { get; set; }
        public Nivel Nivel { get; set; }

        public Nivel DeterminarNivel(double Temperatura)
        {
            if(Temperatura < 80.0)
            {
                return Nivel.Bajo;
            }
            else
            {
                if(Temperatura <= 150.0 && Temperatura>80.0)
                {
                    return Nivel.Normal;
                }
            }

            return Nivel.Alto;

            
        }


    }
}
