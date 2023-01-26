//8. Leer 10 números enteros, almacenarlos en un arreglo y determinar
//cuántos números negativos hay.
using static System.Runtime.InteropServices.JavaScript.JSType;

List<int> Numbers = new List<int>();
Console.WriteLine("A continuación, introduzca 10 números enteros.");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Introduzca el valor " + i);
    int numero = Convert.ToInt32(Console.ReadLine());
    Numbers.Add(numero);
}
int NegativeCK = -1;
int Amount = 0;
for (int i = 0; i < Numbers.Count; i++)
{
    Numbers[i] = int.Parse(Numbers[i].ToString());
    if (Numbers[i] <= NegativeCK)
    {
        Amount = (Amount + 1);
    }
}
if (Amount == 0)
{
    Console.WriteLine("No hay números negativos en la lista.");
}
else
{
    Console.WriteLine("Hay " + Amount + " números negativos en la lista.");
}