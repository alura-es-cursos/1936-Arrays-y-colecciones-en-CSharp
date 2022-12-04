// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
/*
int edad1 = 18;
int edad2 = 25;
int edad3 = 29;
int edad4 = 38;
int edad5 = 19;
int edad6 = 62;

int mediaEdades = (edad1 + edad2 + edad3 + edad4 + edad5 + edad6) / 6;

Console.WriteLine("La media de las edades es: " + mediaEdades);
*/

void TestEnteros()
{

    int[] edades = new int[6];
    edades[0] = 18;
    edades[1] = 25;
    edades[2] = 29;
    edades[3] = 38;
    edades[4] = 19;
    edades[5] = 62;

    int totalEdades = 0;
    for (int i = 0; i < edades.Length; i++)
    {
        //totalEdades = totalEdades + edades[i];
        totalEdades += edades[i];
    }

    int mediaEdades = totalEdades / edades.Length;


    Console.WriteLine("La media de las edades es: " + mediaEdades);
}

void TestCadenas()
{
    string[] listaNombres = new string[5];

    for(int i = 0;i < listaNombres.Length;i++)
    {
        Console.Write($"Nombre {i+1}:");
        listaNombres[i] = Console.ReadLine();
    }

    Console.Write("Nombre a buscar: ");
    string nombreABuscar = Console.ReadLine();

    foreach(string nombre in listaNombres)
    {
        if (nombre.Equals(nombreABuscar))
        {
            Console.WriteLine($"La persona con nombre {nombreABuscar} fue encontrada");
            break;
        } 
    }

}

void TestClaseArray()
{
    Array lista = Array.CreateInstance(typeof(double), 7);

    lista.SetValue(1.8, 0);
    lista.SetValue(7.4, 1);
    lista.SetValue(3.4, 2);
    lista.SetValue(2.8, 3);
    lista.SetValue(5.7, 4);
    lista.SetValue(6.8, 5);
    lista.SetValue(4.9, 6);

    double[] listaOrdenada = (double[])lista.Clone();

    Array.Sort(listaOrdenada);

    int elementoMedio = listaOrdenada.Length / 2;

    double mediana = (listaOrdenada.Length % 2 != 0) ? listaOrdenada[elementoMedio] : (listaOrdenada[elementoMedio-1] + listaOrdenada[elementoMedio]) / 2;

    Console.WriteLine($"La mediana del conjunto es: {mediana}");

}


int[] valores = { 4, 5, 6, 8, 9 };

for(int i = 0;i < 10;i++)
{
    Console.WriteLine($"{valores[i]}");
}