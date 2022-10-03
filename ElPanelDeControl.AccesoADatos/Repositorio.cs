using ElPanelDeControl.Dominio.Contratos;
using ElPanelDeControl.Dominio.Entidades;
using SensorCaldera;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElPanelDeControl.AccesoADatos
{
    public class Repositorio : ILecturas
    {


        public Repositorio()
        {
            
        }
               
        public void AgregarLectura(Lectura lectura)
        {
            using(var context = new LecturasContext())
            {
                context.Lecturas.Add(lectura);
                context.SaveChanges();
            }
        }

        public List<Lectura> GetLecturas()
        {

            using (var context = new LecturasContext())
            {
                var items = from b in context.Lecturas
                            select b;
                return items.ToList();
            }
        }

        
    }
}
