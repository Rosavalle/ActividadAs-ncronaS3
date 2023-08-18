string[] nombreCompleto = { "Rosa", "Griselda", "Valle" };
Console.WriteLine("Valores en el arreglo:");
foreach (string valor in nombreCompleto)
{
    Console.WriteLine(valor);
}
int longitudArreglo = nombreCompleto.Length;
Console.WriteLine($"Tamaño del arreglo: {longitudArreglo}");

Console.WriteLine("Tamaño del arreglo y sus valores:");
for (int i = 0; i < longitudArreglo; i++)
{
    Console.WriteLine($"Posición {i}: {nombreCompleto[i]}");
}
