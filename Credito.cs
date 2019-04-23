using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Inicializamos variables de tipodouble ya que haremos operaciones matematicas con dinero
            double prestamo=17000000/12;
            double interes=prestamo*0.02;
            double cuota=prestamo+interes;
            
            // El primer contador es para llevar las veces ejecutadas en el for
            int count1=0;
            //Iterador
            int i=0;
            //Comprobamos el valor
            Console.WriteLine("la cuota es: {0}",cuota);
            //Inicializamos la fecha del prestamo
            var fecha=new DateTime(2017,01,01);
            Console.WriteLine("format: {0}",fecha.ToString("dd/MM/yyyy"));
            //For para entrar los datos de las 12 fechas
            for(i=1;i<=12;i++){
            var fecha1=new DateTime();
            Console.WriteLine("Digite la fecha a cancelar:");
            fecha1=Convert.ToDateTime(Console.ReadLine());
                //Formateamos la fecha digitado a nuestro gusto
            var fechaForm1=Console.WriteLine("fecha a cancelar:{0}",fecha1.ToString("dd/MM/yyyy"));
                //Intetamos convertirla fecha de tipo string en tipo int para comparar los dias
            var fechaForm=Convert.ToInt32(fechaForm1);
                //Para tomar las tres primeras fechas que son las puntuales para efectuar el valor de la cuota
            count1++;
             while(count1<=3){
              Console.WriteLine("la Cuota puntual del mes {0},es {1}",b,cuota);
              }
                //Las otras nueve cuotas con el interes adicional con respecto al ejercicio planteado
                while(count1>3 && count1<=12){
                var fecha2=new DateTime();
                Console.WriteLine("Digite la fecha a cancelar:");
                fecha2=Convert.ToDateTime(Console.ReadLine());
                var fechaForm=Console.WriteLine("fecha a cancelar:{0}",fecha2.ToString("dd/MM/yyyy"));
                //If para mostrar la cuota de interes de los meses que sobrepasan la fecha de pago puntual
                if(fechaForm>"05/04/2017" || fechaForm>"05/05/2017" || fechaForm>"05/06/2017" || fechaForm>"05/07/2017" || fechaForm>"05/08/2017" ||fechaForm>"05/09/2017" || fechaForm>"05/10/2017" || fechaForm>"05/11/2017" || fechaForm>"05/12/2017")
                {
                  var valint=(cuota*0.02)+cuota;
                  Console.WriteLine("Digite la fecha a cancelar por demora en el pago es:{0}",valint);
                  // Intemamos Hacer un for para contar los dias que sobrepasaban la fecha de pago
                    /*for(a=1;a<=31;a++){
                    
                    Console.WriteLine("Entro al Ciclo:{0}",fechaForm);
                    valor=
                    
                    }*/
                    
                }
                }
            }
        }
    }
}
