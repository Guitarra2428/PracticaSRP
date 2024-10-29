using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaSRP
{
    public class Persona
    {
        //Refactorisado
        //private string Nombre;
        //private int Edad;
        //private string Direccion;
        //private string CorreoElectronico;

        //public  void  EnviarCorreoElectronico(string mensaje)
        //{

        //} 

        //public  void  ImpreimirData()
        //{
        //    Console.WriteLine($"Nombre:{ Nombre}");
        //    Console.WriteLine($"Edad:{Edad}");
        //    Console.WriteLine($"Direccion:{Direccion}");
        //    Console.WriteLine($"CorreoElectronico:{CorreoElectronico}");
        //}

        private string Nombre;
        private int Edad;
        private string Direccion;
        private string CorreoElectronico;

     
        public void ImpreimirData()
        {
            Console.WriteLine($"Nombre:{Nombre}");
            Console.WriteLine($"Edad:{Edad}");
            Console.WriteLine($"Direccion:{Direccion}");
            Console.WriteLine($"CorreoElectronico:{CorreoElectronico}");
        }
    }

    public class Correo
    {
        public void EnviarCorreoElectronico(string mensaje)
        {

        }       


    }
}
