using System;
using System.Collections.Generic;
using System.Text;
using MvvmDemo.Model;
using Xamarin.Forms;

namespace MvvmDemo.ViewModels
{
   public class NuevoEmpleadoViewModel
    {
        // Que va a tener este VM. Propiedades, expone.
        public Empleado NuevoEmpleado { get; set; }

        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }

        public Command NuevoEmpleadoCommand { get; set; }

        public NuevoEmpleadoViewModel()
        {
            NuevoEmpleadoCommand = new Command(OnNuevoEmpleado);
        }

        private void OnNuevoEmpleado()
        {
            NuevoEmpleado = new Empleado();
            NuevoEmpleado.Id = int.Parse(this.Id);
            NuevoEmpleado.Nombre = this.Nombre;
            NuevoEmpleado.CargoEmpleado = this.Cargo;

            RepositorioEmpleados RE = new RepositorioEmpleados();
            RE.AgregarEmpleado(NuevoEmpleado);
        }

    }
}
