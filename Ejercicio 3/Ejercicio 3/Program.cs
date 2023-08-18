string[] palabras = { "Perro", "Casa", "Cebra", "Tortuga", "Burro", "Mar", "Dedo", "Tasa", "Nube", "Sol" };

Console.WriteLine("Arreglo con posiciones inicializadas:");
for (int i = 0; i < palabras.Length; i++)
{
    Console.WriteLine($"Posición {i}: {palabras[i]}");
}
Array.Sort(palabras);

Console.WriteLine("\nArreglo ordenado:");
foreach (string palabra in palabras)
{
    Console.WriteLine(palabra);
}