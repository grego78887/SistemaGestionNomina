using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.ComponentModel.Com2Interop;

namespace SistemaGestionNomina
{
    internal class Empleados
    {
       string nombre { get; set; }
       string Puesto { get; set; }
       int sueldo  { get; set; }
    }
}

public class Puestos
{
    string nombrePuesto { get; set; }
    int salarioPuesto { get; set; }
}
public class Salarios
{
    int salarioBase { get; set; }
    int bono { get; set; }
    int deducciones { get; set; }
}
public class Departamentos
{
    string nombreDepartamento { get; set; }
    string ubicacion { get; set; }
}
public class Nominas
{
    string periodoPago { get; set; }
    DateTime fechaPago { get; set; }
    int totalPagar { get; set; }
}
public class Empleados( string nombre, string Puesto, int sueldo ) 
{

    //Empleados.nombre = nombre;
    //Empleados.Puesto = Puesto;
    //Empleados.sueldo = sueldo;

}
