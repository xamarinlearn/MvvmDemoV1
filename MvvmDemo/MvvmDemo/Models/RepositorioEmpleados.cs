using System;
using System.Collections.Generic;
using System.Text;

namespace MvvmDemo.Model
{
   public class RepositorioEmpleados
    {
        public static List<Empleado> TodosLosEmpleados;
        public List<Empleado> ObtenerEmpleados()
        {
            return TodosLosEmpleados;
               
                   
                
        }
        public RepositorioEmpleados()
        {
            TodosLosEmpleados = new List<Empleado>()
            {
                 new Empleado{ Id=1,Nombre="Juan",CargoEmpleado="Contador"},
                 new Empleado{ Id=2,Nombre="Maria",CargoEmpleado="Gerente"}
            };
        }

        public void AgregarEmpleado(Empleado ne)
        {
            TodosLosEmpleados.Add(ne);
        }
    }
}
