using System;

namespace CalculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual seu nome?");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual a sua altura em metros? ex: 1,72");
            float altura = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Qual o seu peso em kg? ex: 59,3");
            float peso = Convert.ToSingle(Console.ReadLine());

            double imc = peso / (altura * altura);

            Console.WriteLine("{0} sua altura é {1} e seu peso é {2}", nome, altura, peso);

            Console.WriteLine("Seu IMC É {0}", imc);    

            if(imc < 17){
            Console.WriteLine("Muito abaixo do peso");

            }else if (imc <= 18.49){
            Console.WriteLine("Abaixo do peso");

            }else if(imc < 25){
            Console.WriteLine("normal");    
            
            }else if(imc <=35){
            Console.WriteLine("Obesidade I");
        
            }else if(imc < 39){
            Console.WriteLine("Obesidade II(severa)");

            }else if(imc > 40)
            Console.WriteLine("Obesidade III (mórbida)");

            double pesoIdeal= 0;

           if(imc < 18.5)
           {
              pesoIdeal= (18.5*(altura*altura)) -  peso;
              console.WriteLine("você precisa ganhar {0} Kg para atigir o peso ideal",pesoIdeal);

           }else if (imc >= 25)
           {
               pesoIdeal= peso - (24.99*(altura*altura));
               console.WriteLine("Você precisa perder {0} Kg para atingir o peso ideal", pesoIdeal);
               
           }

            }
            
        }
    }

