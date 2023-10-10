string[] colores = { "Magneta ", "Rojo ", "Blanco ", "Azul ", "Cyan " };

string[] eliminaColores = { "Rojo ", "Blanco", "Azul " }; 

List<string> list = new List<string>();

foreach ( string item in colores)
{
    list.Add(item); 
}

List<string> List2 = new List<string>(eliminaColores);

MostrarInformacion(list);
EliminarColores(list, eliminaColores);

MostrarInformacion(list); 


void MostrarInformacion(List<string> list)
{
    foreach (var item in list) {

        Console.WriteLine($"{item} ");
    
    }

    Console.WriteLine($"\nTamaño = {list.Count}; " + $"Capacidad = {list.Capacity}");

    int index = list.IndexOf("Azul");

    if (index != -1) Console.WriteLine("La lista contiene Azul " + "en el indice {0}", index);

    else Console.WriteLine("No contiene Azul" );

}


void EliminarColores(List<string> list, string[] eliminaColores)
{
    foreach (var item in eliminaColores)
    {
        list.Remove(item);
    }
}
