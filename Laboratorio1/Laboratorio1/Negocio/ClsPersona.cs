using Laboratorio1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Laboratorio1.Negocio
{
    public class ClsPersona
    {
        List<Persona> Persona = new List<Persona>();
        public  void PesodePersonas(Persona per)
        {
            double pro = per.peso / Math.Pow(per.altura,2);

            if (pro < 24) 
            {
                Console.WriteLine("Su peso es ideal");
            } else if (pro > 25)
            {
                Console.WriteLine("Tiene sobre peso");
            }
            
        }
        public List<Persona> ListadoDePeso()
        {
            return Persona;
        }
        public void MayordeEdad(Persona perso)
        {

            if (perso.edad >= 18)
            {
                Console.WriteLine("Es Mayor de edad");

            }
            else 
            {
                Console.WriteLine("No es Mayor de edad");
            }
        }
        public List<Persona> ListadoDeEdad()
        {
            return Persona;
        }


    }

        
}

