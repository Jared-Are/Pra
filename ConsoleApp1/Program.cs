string[] colores = { "Azul", "Rojo", "Verde", "Amarillo", "Negro", "Blanco", "Morado" };
string[] eliminarColores = { "Negro", "Blanco", "Verde" };

List<string> lista = new List<string>();

foreach (var color in colores)
{
    lista.Add(color);
}


Display(lista);

void Display(List<string> lista)
{
    foreach (var color in lista)
    {
        Console.WriteLine("-" + color);
    }

    Console.WriteLine("\nTamaño: {0} \nCapacidad: {1}", lista.Count, lista.Capacity);
    int index = lista.IndexOf("Verde");

    if (index == -1)
        Console.WriteLine("La lista no contiene el verde");
    else
        Console.WriteLine("La lista contiene el verde en el indice {0}", index);
    Console.WriteLine();

}

List<string> eliminarLista = new List<string>();

eliminarColoresDeLista(lista, eliminarLista);

void eliminarColoresDeLista(List<string> lista, List<string> eliminarLista)
{
    foreach (var color in eliminarColores)
    {
        eliminarLista.Add(color);
    }
    foreach (var item in eliminarLista)
    {
        if (lista.Contains(item))
            lista.Remove(item);
    }
}

Display(lista);