//1. Leer 10 enteros, almacenarlos en un arreglo y determinar en qué posición del arreglo está el mayor número leído.
List<int> Numbers = new List<int>();
int A = 10;
Console.WriteLine("A continuación, introduzca 10 números enteros: ");
for (int i = 0;i < A; i++)
{
    Console.WriteLine("Introduzca un número entero cualquiera: ");
    int numero = Convert.ToInt32(Console.ReadLine());
    Numbers.Add(numero);
}
Console.WriteLine("Esta es su lista: ");
for (int i = 0;i < Numbers.Count; i++)
{
    Console.WriteLine(Numbers[i]);
}
int B = Numbers.Max();
Console.WriteLine("Y el número más grande está en la posición: " + Numbers.IndexOf(B));