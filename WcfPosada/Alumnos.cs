using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfPosada
{
    //en la clase alumnos establecemos los get y set, uno establece valores
    //y get lo obtiene 
    //por lo tanto cada espacio en el formulario hace uso de cada string aqui programado
    //necesitamos mostrar una matricula, un nombre, apellido y su carrera correspondiente
    public class Alumnos
    {
        string matricula_alumno;
        public string Matricula_alumno {
            set { matricula_alumno = value; }
            get { return matricula_alumno; }
        }

        string nombre_alumno;
        public string Nombre_alumno {
            set { nombre_alumno = value; }
            get { return nombre_alumno; }
        
        }

        string apellidos_alumno;
        public string Apellidos_alumno {
            set { apellidos_alumno = value; }
            get { return apellidos_alumno; }
        }

        string carrera_alumno;
        public string Carrera_alumno {
            set { carrera_alumno = value; }
            get { return carrera_alumno; }
        }

    }
}