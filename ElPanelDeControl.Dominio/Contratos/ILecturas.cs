using ElPanelDeControl.Dominio.Entidades;
using SensorCaldera;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElPanelDeControl.Dominio.Contratos
{
    public interface ILecturas
    {
       
        List<Lectura> GetLecturas();     
        void AgregarLectura(Lectura lectura);

        

    }
}
