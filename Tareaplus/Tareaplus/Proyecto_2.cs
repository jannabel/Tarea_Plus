using System;

public class Class2
{
	public Class2()
	{

        //Usar el operador condicional para calcular el menor de dos numeros.

        Console.Write(" \n ~ ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write(" \n ~ ");
        int n2 = Convert.ToInt32(Console.ReadLine());


        var result = n1 < n2 ? " ~El menor es: " + n1 : " ~ El menor es:" + n2;


        Console.WriteLine("\n " + result);
        Console.ReadKey();
    }
}
