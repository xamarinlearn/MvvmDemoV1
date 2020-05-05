using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using MvvmDemo.Model;

namespace MvvmDemo.ViewModels
{
    public class EmpleadoViewModel
    {
        RepositorioEmpleados R;
        public ObservableCollection<Empleado> Empleados { get; set; }

        public EmpleadoViewModel()
        {
            R = new RepositorioEmpleados();

            Empleados = new ObservableCollection<Empleado>(
                R.ObtenerEmpleados().Select(e => e));
        }
    }
}
