
using System.ComponentModel.DataAnnotations;

namespace Registro_de_Empleados
{
    public class Empleado
    {
        public Empleado()
        {
        }

        public int numero { get; set; }
       

        public Guid Id { get; set; }
  

        public string Nombre { get; set; }
        

        public string Apellido { get; set; }

        public string Departamento { get; set; }

        public string Puesto { get; set; }
    }
}