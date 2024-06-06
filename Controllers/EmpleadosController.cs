
using Registro_de_Empleados.Models;
using Microsoft.AspNetCore.Mvc;
using Registro_de_Empleados;
using Microsoft.Data.SqlClient;

public class EmpleadosController : Controller
{
    public EmpleadosController()
    {
    }

    public IActionResult Empleadoslist()
    {
        List<Empleado> list = new List<Empleado>();
        return View(list);
        
    }

    public IActionResult EmpleadosAdd()
    {
        return View();
    }

    public IActionResult Registrar()
    {
        return View();
    }
    



}