using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aporte.bailon
{ 
public class Profesor
{

    public string nombre { get; set; }
    public string apellido { get; set; }
    public int dirreccion { get; set; }
    public string  cedula { get; set; }
        public int sueldo { get; set; }

        public Profesor(string nombre, string apellido, int edad, string departamento, int sueldo)  
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.dirreccion = dirreccion;
        this.cedula = cedula;
            this.sueldo = sueldo;
    }

        public Profesor(string nombre, string apellido, int dirreccion, string cedula)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dirreccion = dirreccion;
            this.cedula = cedula;
        }

        public void imprimirprofesor()
    {
        Console.WriteLine("\n**Datos Profesor **" + "\nNombre: " + nombre + "\nApellido: " + apellido + "\nEdad: " + dirreccion
            + "\nDepartamento: " + cedula);
    }





    public string getnombre()
    {
        return nombre;
    }
    public void setnombre(string nombre)
    {
        this.nombre = nombre;
    }

    public string getapellido()
    {
        return apellido;
    }
    public void setapellido(string apellido)
    {
        this.apellido = apellido;
    }

    public int getdirreccion()
    {
        return dirreccion;
    }
    public void setdirreccion(int dirreccion)
    {
        this.dirreccion = dirreccion;
    }

    public string getcedula()
    {
        return cedula;
    }
    public void setcedula(string cedula)
    {
        this.cedula = cedula;
    }
        public int getsueldo()
        {
            return sueldo;
        }
        public void setsueldo(int sueldo)
        {
            this.sueldo = sueldo;
        }

    }

}