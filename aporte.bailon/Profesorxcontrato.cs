using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aporte.bailon
{ 
    class Profesorxcontrato : Profesor
    {
      
        public int salariobasico { get; set; }
        public int horaextras { get; set; }
        int salariototal;
        public Profesorxcontrato(string nombre, string apellido, int dirreccion, string cedula) : base(nombre, apellido, dirreccion, cedula)
        {
            this.salariobasico = salariobasico;
            this.horaextras = horaextras;
        }
        public int getsalariobasico()
        {
            return salariobasico;
        }
        public void setslariobasico(int salariobasico)
        {
            this.salariobasico= salariobasico;
        }

       

        public void sueldofinal()
        {
            salariototal = salariobasico+ horaextras;

        }
        public void imprimisalario()
        {

            Console.WriteLine("\n**Profesor por  contrato **" + "\nNombre: " + nombre + "\nApellido "
                + apellido + "\ndireccion: " + dirreccion + "\ncedula: " + cedula + "\nSalario: " + salariobasico + "\nHoras extras: " + horaextras);

        }

    }
}
