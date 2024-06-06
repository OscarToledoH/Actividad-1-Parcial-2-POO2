
using System.ComponentModel.DataAnnotations;

namespace Registro_de_Empleados.Models;

public class EmpleadosModel
{
    public EmpleadosModel()
    {
    }

    public Guid Id { get; set; }
    
    public string Nombre { get; set; }
    [Required(ErrorMessage = "Se requiere un Nombre")]
    [Range(0,20)]
    public string Apellido { get; set; }
    [Required(ErrorMessage = "Se requiere un Apellido")]
    [Range(0,20)]

    public int Edad { get; set; }
    [Required(ErrorMessage = "Se requiere una Edad")]

    public string Departamento { get; set; }
    [Required(ErrorMessage = "Se requiere un Departamento")]

    public string Puesto { get; set; }
    

    

}