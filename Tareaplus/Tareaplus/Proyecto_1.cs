using System;

public class Class1
{
	public Class1()
	{
        /*1.: Crear un programa que use el operador condicional para mostrar el valor absoluto 
            de un numero de la siguiente forma: si el numero es positivo, se mostrara tal cual; 
            si es negativo, se mostrara el signo cambiado.*/

        Console.Write(" \n ~ ");
        int n1 = Convert.ToInt32(Console.ReadLine());

        var result = n1 > 0 ? " El numero es " + n1 : " El numero es: " + n1 * -1;

        Console.WriteLine(result);
        Console.ReadKey();


    }
}
