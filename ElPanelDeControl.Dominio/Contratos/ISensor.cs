using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElPanelDeControl.Dominio.Contratos
{
    public interface ISensor
    {
        void LeerLecturas(double valor);
        double GetLectura();
        int Conectar();
        void Desconectar();

    }
}
