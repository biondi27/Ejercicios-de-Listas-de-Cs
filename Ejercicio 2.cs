//2. Leer 10 enteros, almacenarlos en un arreglo y determinar
//en qué posición del arreglo está el mayor número par leído.
List<int> Numbers = new List<int>();
Console.WriteLine("A continuación, introduzca 10 números enteros.");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Introduzca el valor " + i);
    int numero = Convert.ToInt32(Console.ReadLine());
    Numbers.Add(numero);
}
int MaxPar = int.MinValue;
int Pos = -1;

for (int i = 0; i < Numbers.Count; i++)
{
    Numbers[i] = int.Parse(Numbers[i].ToString());
    if (Numbers[i]%2==0 && Numbers[i] > MaxPar)
    {
        MaxPar = Numbers[i];
        Pos = i;
    }
}
if (Pos == -1)
{
    Console.WriteLine("No hay números pares en la lista.");
}
else
{
    Console.WriteLine("El número par más grande es " + MaxPar + ", en la posición: " + Pos);
}