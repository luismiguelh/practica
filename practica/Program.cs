public class TresVariable
{
    static void Main(string[] args)

    {
        double num1, num2, num3, potencia, raizcuadrada, raizcubica;

        Console.WriteLine("ingrese su primer número: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("ingrese su primer número: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("ingrese su primer número: ");
        num3 = Convert.ToInt32(Console.ReadLine());

        potencia = Math.Pow(num1, 2);
        raizcuadrada = (double)Math.Sqrt(num2);
        raizcubica =  (double)Math.Cbrt(num3);
        

        Console.Write("El cuadrado de " +num1 +" es: " + potencia);
        Console.Write("\n");

        Console.Write("La Raiz cuadrada es: " + raizcuadrada);
        Console.Write('\n');

        Console.WriteLine("La raiz cubica es: " + raizcubica);




    }   

}