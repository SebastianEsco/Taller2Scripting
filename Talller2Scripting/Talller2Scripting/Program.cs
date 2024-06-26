﻿namespace Talller2Scripting
{
    internal class Program
    {
        delegate float DelegadoCalculadora(float x, float y);
        static void Main(string[] args)
        {
            DelegadoCalculadora delegadoSuma = Sumar; //Incializar y asignación
            DelegadoCalculadora delegadoResta = Restar;
            DelegadoCalculadora delegadoMultiplicacion = Multiplicar;
            DelegadoCalculadora delegadoDivision = Dividir;
            DelegadoCalculadora delegadoPotencia = Elevar;

            Operacion(3, 2, delegadoSuma);
            Operacion(3, 2, delegadoResta);
            Operacion(3, 2, delegadoMultiplicacion);
            Operacion(3, 2, delegadoDivision);
            Operacion(3, 2, delegadoPotencia);


            //-----------------------------------------//

            DelegadoCalculadora delegadoCalculadora;
            delegadoCalculadora = Sumar;
            delegadoCalculadora += Restar;
            delegadoCalculadora += Multiplicar;
            delegadoCalculadora += Dividir;
            delegadoCalculadora += Elevar;

            float x = 3;
            x += delegadoCalculadora(3, 2);

            Console.WriteLine("X es igual a: " + x);


            delegadoCalculadora.Invoke(3, 4);


            Operacion(3, 2, delegadoCalculadora);

        }

        static void Operacion(float a, float b, DelegadoCalculadora delegado)
        {
            Console.WriteLine("El resultado de la operación es " + delegado(a, b));
        }

        static float Sumar(float a, float b)
        {
            return a + b;
        } 

        static float Restar(float a, float b)
        {
            return a - b;
        }

        static float Multiplicar(float a, float b)
        {
            return a * b;
        }

        static float Dividir(float a, float b)
        {
            if(b != 0)
            {
                return (a / b);
            }
            else
            {
                return 0;
            }
        }

        static float Elevar(float a, float b)
        {
            return(Convert.ToSingle(Math.Pow(a,b)));
        }
    }
}