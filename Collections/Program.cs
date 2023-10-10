// Crear una coleccion generica de 5 frutas 

// Imprimir o desplegar la informacion de la coleccion (elementos, tamaño)

//Buscar en la coleccion la fruta naranja

// Insertar por indice una nueva fruta 

//Remover la fruta insertada y remover la fruta con el indice [0]

//Imprimir 


using System.Collections.ObjectModel;

Collection<string> Frutas = new Collection<string>();

Frutas.Add("Manzana");
Frutas.Add("Mango");
Frutas.Add("Sandía");
Frutas.Add("Fresa");
Frutas.Add("Piña");

Console.WriteLine("{0} Frutas: ", Frutas.Count);
Display(Frutas);

Console.WriteLine("\n La colección contiene(\"Naranja\"):{0}", Frutas.Contains("Naranja"));

Console.WriteLine("\n Se ha agragado(2, \"Pera\")");
Frutas.Insert(2, "Pera"); 
Display(Frutas);

Console.WriteLine("\nRemoveAt(2)");
Frutas.RemoveAt(2);
Display(Frutas);

Console.WriteLine("\nRemoveAt(0)");
Frutas.RemoveAt(0);
Display(Frutas);




static void Display(Collection<string> frutas)
{
    Console.WriteLine();

    foreach (string fr in frutas) {

        Console.WriteLine(fr);
    
    }
}