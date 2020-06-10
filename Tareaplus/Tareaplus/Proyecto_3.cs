using System;

public class Class3
{
	public Class3()
	{

        /*3.: Crear un programa que lea una letra tecleada por el usuario 
 y diga si se trata de un signo de puntuacion, una cifra numerica
 o algun otro caracter.*/

        Console.Write(" \n ~ ");

        string hi = Convert.ToString(Console.ReadLine());



        if (hi.Length == 1)
        {
            char hola = Convert.ToChar(hi);

            if (Char.IsNumber(hola) == true) Console.WriteLine(" ~ Usted ha ingresado un numero ");
            else if (Char.IsLetter(hola) == true) Console.WriteLine(" ~ Usted ha ingresado una letra ");
            else if (Char.IsPunctuation(hola) == true) Console.WriteLine(" ~ Usted ha ingresado un signo de puntuacion ");
            else Console.WriteLine(" ~ Usted ha ingresado otro caracter ~ ");

        }
        else
        {
            Console.WriteLine(" ~ Usted ha ingresado mas de un digito ~ ");
        }


        Console.ReadKey();




    }
}
