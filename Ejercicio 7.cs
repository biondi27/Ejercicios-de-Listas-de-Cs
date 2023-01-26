//7. Leer 10 números enteros, almacenarlos en un arreglo y determinar
//a cuánto es igual el promedio entero de los datos del arreglo
using static System.Runtime.InteropServices.JavaScript.JSType;

List<int> Numbers = new List<int>();
Console.WriteLine("A continuación, introduzca 10 números enteros.");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Introduzca el valor " + i);
    int numero = Convert.ToInt32(Console.ReadLine());
    Numbers.Add(numero);
}
int Amount = 0;
for (int i = 0; i < Numbers.Count; i++)
{
    Numbers[i] = int.Parse(Numbers[i].ToString());
    Amount = Amount + Numbers[i];
}
double Promedio = (double) Amount / Numbers.Count;
Console.WriteLine("El promedio entero de su lista es: " + Promedio);