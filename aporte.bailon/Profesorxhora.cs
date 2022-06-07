
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aporte.bailon
{
    class Profesorxhora: Profesor  //herencia
    {


        public int horasquetrabajo { get; set; }
        private int valorxhora { get; set; }
        public int sueldoxhora { get; set; }

        public Profesorxhora(string nombre, string apellido, int dirreccion, string cedula, int horasquetrabajo, int valorxhora) : base(nombre, apellido, dirreccion, cedula: cedula)
        {

            this.valorxhora = valorxhora;
            this.horasquetrabajo = horasquetrabajo;


        }


        public int gethorasquetrabajo()
        {
            return horasquetrabajo;
        }
        public void sethorasquetrabajo(int horasquetrabajo)
        {
            this.horasquetrabajo = horasquetrabajo;
        }

        public int getvalorxhora()
        {
            return horasquetrabajo;
        }
        public void setvalorxhora(int valorxhora)
        {
            this.valorxhora = valorxhora;
        }




        public void calcularsueldoporhora()
        {
            sueldoxhora = horasquetrabajo * valorxhora;
        }
        public void imprimirempleadoporhoras()
        {

            Console.WriteLine("\n**Profesor por horas Por Horas**" + "\nNombre: " + nombre + "\nApellido "
                + apellido + "\ndirreccion: " + dirreccion + "\ncedula: " + cedula + "\nHoras Trabajadas: " + horasquetrabajo + "\nValor por Hora: " + valorxhora + "\nSueldo de Horas " + sueldoxhora);

        }


    }


}

