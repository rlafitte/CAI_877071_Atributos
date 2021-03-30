using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atributos.Libreria.Entidades
{
    public class Carrera
    {
        private int _cantidadMaterias;
        private int _cantidadAprobadas;
        private bool _carreraFinalizada;

        public int CantidadMaterias
        {
            get
            {
                return this._cantidadMaterias;
            }
            set
            {
                this._cantidadMaterias = value;
            }
        }
        public int CantidadAprobadas
        {
            get
            {
                return this._cantidadAprobadas;
            }
            set
            {
                this._cantidadAprobadas = value;
            }
        }

        public bool CarreraFinalizada
        {
            get
            {
                return this._carreraFinalizada;
            }
            set
            {
                this._carreraFinalizada = value;
            }
        }
        public Carrera() 
        {
            this._cantidadMaterias = 32; //seteo por defecto la cantidad de materias de una carrera
            this._carreraFinalizada = false; //seteo por defecto que no está finalizada
        }
        public void AprobarMateria()  
        {                                 
            this._cantidadAprobadas = this._cantidadAprobadas+ 1;  
            if (this._cantidadAprobadas == this._cantidadMaterias)
            {
            this._carreraFinalizada = true;
            }    

        }

        public void SolicitudTitulo()
        {
            if (this._carreraFinalizada)
            {
                Console.WriteLine("Diríjase a departamento de alumnos a solicitar su título.");
            }
            else
            {
                Console.WriteLine("Aún no ha completado el total de materias para la carrera asociada.");
            }
        }
    }
}
