using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aporte.bailon
{
    class Profesorxnombramiento : Profesor
    {
        
        public int Sueldofijo { get; set; }
        public Profesorxnombramiento(string nombre, string apellido, int dirreccion, string cedula) : base(nombre, apellido, dirreccion, cedula)
        {
            this.Sueldofijo = Sueldofijo;
        }
        public int getSueldofijo()
        {
            return Sueldofijo;
        }
        public void sethorasquetrabajo(int Sueldofijo)
        {
            this.Sueldofijo = Sueldofijo;
        }
        public void imprimirsueldofijo()
        {
            Console.WriteLine("\n**Profesor por  contrato **" + "\nNombre: " + nombre + "\nApellido "
               + apellido + "\ndireccion: " + dirreccion + "\ncedula: " + cedula + "\nSueldo " + Sueldofijo );
        }

    }

}
