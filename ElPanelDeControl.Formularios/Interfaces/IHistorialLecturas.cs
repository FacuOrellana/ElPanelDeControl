using ElPanelDeControl.Formularios.Presentadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElPanelDeControl.Formularios.Interfaces
{
    public interface IHistorialLecturas
    {

        void Mostrar();
        void ActualizarHistorial();
        void SetPresentador(PresentadorPrincipal presentador);

    }
}
