using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfPosada
{
    public class Function
    {
        //Aqui hacemos uso de los metodos anteriormente creados 
        //Con la excepcion de que utilizaremos una aplicacion de windows 
        //creamos los datos que vamos a buscar con la aplicacion
        //así que de igual forma, establecemos los datos de cada espacio 
        
        
        public string[] ver_alumno(string id) {
            string[] alumno_info = new string[6];
            Alumnos data_alumno = new Alumnos();
            if (id == "1")
            {
                data_alumno.Matricula_alumno = "17030034";
                alumno_info[0] = data_alumno.Matricula_alumno;

                data_alumno.Nombre_alumno = "Jennifer";
                alumno_info[1] = data_alumno.Nombre_alumno;

                data_alumno.Apellidos_alumno = "Lopez";
                alumno_info[2] = data_alumno.Apellidos_alumno;

                data_alumno.Carrera_alumno = "Industrial";
                alumno_info[3] = data_alumno.Carrera_alumno;
            }
            else {
                if (id == "2")
                {
                    data_alumno.Matricula_alumno = "17030089";
                    alumno_info[0] = data_alumno.Matricula_alumno;

                    data_alumno.Nombre_alumno = "Angel";
                    alumno_info[1] = data_alumno.Nombre_alumno;

                    data_alumno.Apellidos_alumno = "De los Santos Posada";
                    alumno_info[2] = data_alumno.Apellidos_alumno;

                    data_alumno.Carrera_alumno = "Informatica";
                    alumno_info[3] = data_alumno.Carrera_alumno;
                }
                else {
                    if (id == "3") {
                        data_alumno.Matricula_alumno = "17030102";
                        alumno_info[0] = data_alumno.Matricula_alumno;

                        data_alumno.Nombre_alumno = "Fernando";
                        alumno_info[1] = data_alumno.Nombre_alumno;

                        data_alumno.Apellidos_alumno = "Gonzales";
                        alumno_info[2] = data_alumno.Apellidos_alumno;

                        data_alumno.Carrera_alumno = "Mecatronica";
                        alumno_info[3] = data_alumno.Carrera_alumno;
                    }
                }
            }
            return alumno_info;
        
        }
    }
}