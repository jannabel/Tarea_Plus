using System;

public class Class4
{
	public Class4()
	{

        /* 4.: Crear un programa que lea una letra tecleada por el usuario y diga si se trata de una vocal, 
            una cifra numerica o una consonante. Tips: usar dato tipo "char".*/


        Console.Write(" \n ~ ");
        char[] vocales = { 'A', 'E', 'I', 'O', 'U', 'a', 'e', 'i', 'o', 'u' };
        char[] consonantes = { 'B', 'C', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'Ñ', 'P', 'Q', 'R', 'S', 'T', 'V', 'W', 'X', 'Y', 'Z', 'b', 'c', 'd', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'ñ', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };
        string hi = Convert.ToString(Console.ReadLine());



        if (hi.Length == 1)
        {
            char hola = Convert.ToChar(hi);


            foreach (var item in vocales)
            {

                if (hola == item)
                {
                    Console.WriteLine(" ~ Usted ha ingresado una vocal "); break;
                }

                else if (Char.IsNumber(hola) == true)
                {
                    Console.WriteLine(" ~ Usted ha ingresado un numero "); break;
                }
            }

            foreach (var item in consonantes)
            {

                if (hola == item)
                {
                    Console.WriteLine(" ~ Usted ha ingresado una consonante "); break;
                }
            }
        }
        else
        {
            Console.WriteLine(" ~ Usted ha ingresado mas de un digito ~ ");
        }

        Console.ReadKey();


    }
}
