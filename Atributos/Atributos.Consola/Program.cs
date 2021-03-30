using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atributos.Libreria.Entidades;

namespace Atributos.Consola
{
    public class Program
    {
        static void Main(string[] args)
        {
            Carrera C = new Carrera();
            C.Avance();
            do
            {
                C.AprobarMateria();
            } while (!C.CarreraFinalizada);
            C.Avance();
            C.SolicitudTitulo();

            Console.ReadLine();
        }
    }
}
