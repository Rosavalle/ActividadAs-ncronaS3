Console.Write("Ingrese el tamaño del arreglo (min 5): ");
int size = Convert.ToInt32(Console.ReadLine());

if (size < 5)
{
    Console.WriteLine("El mínimo del arreglo debe ser 5.");
    return;
}

float[] arreglo = new float[size];

for (int i = 0; i < size; i++)
{
    Console.Write($"Ingrese el valor {i + 1}: ");
    arreglo[i] = Convert.ToSingle(Console.ReadLine());
}
Console.WriteLine("Valores ingresados:");
foreach (float valor in arreglo)
{
    Console.WriteLine(valor);
}
