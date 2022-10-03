using ElPanelDeControl.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElPanelDeControl.Formularios.Interfaces
{
    public interface IPanelDeControl
    {
        void ActualizarPanel(int numeroCaldera, double temperatura,Nivel numeroNivel);
        void MostrarMensaje();        
       

    }
}
