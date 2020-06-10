using System;

public class Class5
{
	public Class5()
	{
        /*5.: Crear un programa que escriba en pantalla los numeros pares del 23 al 7 en orden descendente,
           usando while.*/

        int i = 23;
        while (i != 7)
        {

            if (i % 2 == 0)
            {
                Console.WriteLine(" ~ " + i);
            }
            i--;
        }

        Console.ReadKey();

    }
}
