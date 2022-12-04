// See https://aka.ms/new-console-template for more information

#region Manipulación de arreglos
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

using ByteBank.Atendimiento;
using ByteBank.Atendimiento.ByteBank.Exceptions;
using ByteBank.Modelos;
using System.Collections;

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

/*
int[] valores = { 4, 5, 6, 8, 9 };

for(int i = 0;i < 10;i++)
{
    Console.WriteLine($"{valores[i]}");
}
*/

/*
void TestArregloCuentasBancarias()
{
    CuentaBancaria[] listaCuentasBancarias = new CuentaBancaria[]
    {
        new CuentaBancaria("123232","213434"),
        new CuentaBancaria("454532","345344"),
        new CuentaBancaria("343433","576788"),
        new CuentaBancaria("989895","232323"),
    };

    for(int i = 0;i < listaCuentasBancarias.Length;i++)
    {
        Console.WriteLine($"Cuenta {i} - Nro. {listaCuentasBancarias[i].NumeroCuenta} - Agencia {listaCuentasBancarias[i].NumeroAgencia}");
    }
}
*/

void TestArregloListaCuentasBancarias()
{
    ListaCuentasBancarias listaCuentasBancarias = new ListaCuentasBancarias();

    CuentaBancaria cuenta1 = new CuentaBancaria("454532", "345344");
    //0
    listaCuentasBancarias.agregar(new CuentaBancaria("123232", "213434"));
    //1
    listaCuentasBancarias.agregar(cuenta1);
    listaCuentasBancarias.agregar(new CuentaBancaria("343433", "576788"));
    listaCuentasBancarias.agregar(new CuentaBancaria("989895", "232323"));
    listaCuentasBancarias.agregar(new CuentaBancaria("665654", "696556"));
    listaCuentasBancarias.agregar(new CuentaBancaria("666524", "979841"));
    //Mostra Lista
    Console.WriteLine("Cuentas agregadas ***********");
    listaCuentasBancarias.mostrarLista();

    Console.WriteLine("Eliminando 1 cuenta ***********");
    listaCuentasBancarias.remover(cuenta1);
    //Mostra lista
    //listaCuentasBancarias.mostrarLista();
    Console.WriteLine("Iterando la listaCuentasBancarias como arreglo  ***********");
    for (int i = 0;i < listaCuentasBancarias.Tamano;i++)
    {
        CuentaBancaria obj = listaCuentasBancarias[i];

        Console.WriteLine($"Cuenta {i} - Nro. {obj.NumeroCuenta} - Agencia {obj.NumeroAgencia}");
    }


}

//TestArregloListaCuentasBancarias();
#endregion

#region métodos de List
/*
//Colección


List<CuentaBancaria> lstCuentasBancarias2 = new List<CuentaBancaria>()
{
    new CuentaBancaria("123232-B","21343422"),
    new CuentaBancaria("454532-B","34534422"),
    new CuentaBancaria("343433-B","57678822"),
};

List<CuentaBancaria> lstCuentasBancarias3 = new List<CuentaBancaria>()
{
    new CuentaBancaria("123232-C","21343433"),
    new CuentaBancaria("454532-C","34534433"),
    new CuentaBancaria("343433-C","57678833"),
};

var rango = lstCuentasBancarias3.GetRange(0,1);

lstCuentasBancarias2.AddRange(rango);

for (int i = 0; i < lstCuentasBancarias2.Count; i++)
{
    Console.WriteLine($"Indice[{i}] = Cuenta [{lstCuentasBancarias2[i].NumeroCuenta}]");
}

//Modo reverso
lstCuentasBancarias2.Reverse();
Console.WriteLine("Modo reverso:");
for (int i = 0; i < lstCuentasBancarias2.Count; i++)
{
    Console.WriteLine($"Indice[{i}] = Cuenta [{lstCuentasBancarias2[i].NumeroCuenta}]");
}

//Limpiar lista
lstCuentasBancarias2.Clear();
Console.WriteLine("Limpiamos:");
for (int i = 0; i < lstCuentasBancarias2.Count; i++)
{
    Console.WriteLine($"Indice[{i}] = Cuenta [{lstCuentasBancarias2[i].NumeroCuenta}]");
}
*/
#endregion

List<CuentaBancaria> lstCuentasBancarias = new List<CuentaBancaria>()
{
    new CuentaBancaria("123232","21343411")
    {
        Cliente = new Cliente
        {
            Dni= "13804050",
            Nombre = "Leonardo"
        }
    },
    new CuentaBancaria("454532","34534411")  {
        Cliente = new Cliente
        {
            Dni= "8001879",
            Nombre = "Maria"
        }
    },
    new CuentaBancaria("343433","57678811")  {
        Cliente = new Cliente
        {
            Dni= "21183783",
            Nombre = "Pedro"
        }
    },
};

void menuAtendimiento()
{
    try
    {
        char opcion = '0';
        while (opcion != '6')
        {
            Console.Clear();
            Console.WriteLine("***************************");
            Console.WriteLine("** 1 - Incluir cuenta   ***");
            Console.WriteLine("** 2 - Mostrar cuentas  ***");
            Console.WriteLine("** 3 - Eliminar cuenta  ***");
            Console.WriteLine("** 4 - Ordenar cuentas  ***");
            Console.WriteLine("** 5 - Consultar cuenta ***");
            Console.WriteLine("** 6 - Salir            ***");
            Console.WriteLine("***************************");
            Console.Write("Seleccione una opción: ");
            try
            {
                opcion = Console.ReadLine()[0];
            } catch(Exception e)
            {
                throw new ByteBankException(e.Message);
            }

            switch (opcion)
            {
                case '1':
                    IncluirCuenta();
                    break;
                case '2':
                    MostrarCuentas();
                    break;
                case '3':
                    EliminarCuentas();
                    break;
                case '4':
                    OrdenarCuentas();
                    break;
                case '5':
                    ConsultarCuentas();
                    break;
                case '6': break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }
    } catch (ByteBankException e)
    {
        Console.WriteLine($"{e.Message}");
    }
}

void ConsultarCuentas()
{
    try
    {
        char opcion = '0';
        while (opcion != '6')
        {
            Console.Clear();
            Console.WriteLine("***************************");
            Console.WriteLine("***  CONSULTAR CUENTAS  ***");
            Console.WriteLine("***************************");
            Console.WriteLine("** 1 - Por DNI          ***");
            Console.WriteLine("** 2 - Por No. de cuenta***");
            Console.WriteLine("** 3 - Menu principal   ***");
            Console.WriteLine("***************************");
            Console.Write("Seleccione una opción: ");
            try
            {
                opcion = Console.ReadLine()[0];
            }
            catch (Exception e)
            {
                throw new ByteBankException(e.Message);
            }

            CuentaBancaria cuentaBancaria = null;

            switch (opcion)
            {
                case '1':
                    cuentaBancaria = ConsultarPorDNI();

                    if (cuentaBancaria != null)
                    {
                        Console.WriteLine(cuentaBancaria.ToString());
                    } else
                    {
                        Console.WriteLine("No hay cuentas para este DNI");
                    }
                    break;
                case '2':
                    cuentaBancaria = ConsultarPorNumeroCuenta();
                    if (cuentaBancaria != null)
                    {
                        Console.WriteLine(cuentaBancaria.ToString());
                    }
                    else
                    {
                        Console.WriteLine("No hay cuentas con este número");
                    }
                    break;
                
                case '3':
                    return;
                    
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
            Console.ReadLine();
        }
    }
    catch (ByteBankException e)
    {
        Console.WriteLine($"{e.Message}");
    }
}

CuentaBancaria ConsultarPorNumeroCuenta()
{
    Console.Clear();
    Console.WriteLine("***************************");
    Console.WriteLine("***   CONSULTAR POR DNI ***");
    Console.WriteLine("***************************");
    Console.Write("Número de cuenta:");

    string numeroCuenta = Console.ReadLine();

    CuentaBancaria cuentaBancaria = null;

    foreach (var item in lstCuentasBancarias)
    {
        if (item.NumeroCuenta.Equals(numeroCuenta))
        {
            cuentaBancaria = item;
            break;
        }
    }
    return cuentaBancaria;
}

CuentaBancaria ConsultarPorDNI()
{
    Console.Clear();
    Console.WriteLine("***************************");
    Console.WriteLine("***   CONSULTAR POR DNI ***");
    Console.WriteLine("***************************");
    Console.Write("DNI:");

    string dni = Console.ReadLine();

    CuentaBancaria cuentaBancaria = null;

    foreach (var item in lstCuentasBancarias)
    {
        if (item.Cliente.Dni.Equals(dni))
        {
            cuentaBancaria = item;
            break;
        }
    }
    return cuentaBancaria;

}

void OrdenarCuentas()
{
    lstCuentasBancarias.Sort();
    Console.WriteLine("------- LISTA DE CUENTAS ORDENADA ---");
    Console.ReadLine();

}

void EliminarCuentas()
{
    Console.Clear();
    Console.WriteLine("***************************");
    Console.WriteLine("***   ELIMINAR CUENTA   ***");
    Console.WriteLine("***************************");
    Console.Write("Numero de cuenta:");

    string numeroCuenta = Console.ReadLine();

    CuentaBancaria cuentaBancaria = null;

    foreach(var item in lstCuentasBancarias)
    {
        if (item.NumeroCuenta.Equals(numeroCuenta))
        {
            cuentaBancaria = item;
            break;
        }
    }

    if (cuentaBancaria != null)
    {
        lstCuentasBancarias.Remove(cuentaBancaria);
        Console.WriteLine($"Se eliminó la cuenta bancaria con número {numeroCuenta}");
    } else
    {
        Console.WriteLine($"No fue encontrada una cuenta con el número {numeroCuenta}");
    }
    Console.ReadLine();

}

void IncluirCuenta()
{
    Console.Clear();
    Console.WriteLine("***************************");
    Console.WriteLine("***   INCLUIR CUENTA    ***");
    Console.WriteLine("***************************");
    Console.Write("Numero de cuenta:");
    string numeroCuenta = Console.ReadLine();

    Console.Write("Numero de agencia:");
    string numeroAgencia = Console.ReadLine();

    CuentaBancaria obj = new CuentaBancaria(numeroCuenta, numeroAgencia);


    Console.Write("Saldo inicial:");
    obj.Saldo = double.Parse(Console.ReadLine());

    Console.Write("Nombre cliente:");
    obj.Cliente.Nombre = Console.ReadLine();

    Console.Write("DNI:");
    obj.Cliente.Dni = Console.ReadLine();

    lstCuentasBancarias.Add(obj);
}

void MostrarCuentas()
{
    Console.Clear();
    Console.WriteLine("***************************");
    Console.WriteLine("***   MOSTRAR CUENTAS   ***");
    Console.WriteLine("***************************");

    if (lstCuentasBancarias.Count <= 0)
    {
        Console.WriteLine("No hay cuentas registradas");
    } else
    {
        foreach(CuentaBancaria obj in lstCuentasBancarias)
        {
            Console.WriteLine("********************");
            Console.Write("Numero de cuenta:");
            Console.WriteLine(obj.NumeroCuenta);

            Console.Write("Numero de agencia:");
            Console.WriteLine(obj.NumeroAgencia);

            Console.Write("Saldo inicial:");
            Console.WriteLine(obj.Saldo);

            Console.Write("Nombre cliente:");
            Console.WriteLine(obj.Cliente.Nombre);

            Console.Write("DNI:");
            Console.WriteLine(obj.Cliente.Dni);

            Console.WriteLine("********************");
            Console.ReadLine();
        }
    }
}


#region clase genérica
/*
Generica<int> obj = new Generica<int>();

obj.mostrarMensaje(3);

Generica<string> objS = new Generica<string>();

objS.mostrarMensaje("Este es un texto");

public class Generica<T>
{
    public void mostrarMensaje(T t)
    {
        Console.WriteLine($"Mostrando {t}");
    }
}
*/
#endregion


menuAtendimiento();


