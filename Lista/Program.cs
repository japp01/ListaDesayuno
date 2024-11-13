using Lista;

int opcion = 0;

Desayuno d1 = new Desayuno();
d1.Nombre = "Pan con huevo";
d1.Cantidad = 3;

Desayuno d2 = new Desayuno();
d2.Nombre = "Pan con palta";
d2.Cantidad = 5;

Opciones opciones = new Opciones();
Desayuno[] lista = new Desayuno[2];
lista[0] = d1;
lista[1] = d2;

string txt = @"
******************************************
*     Bienvenido al menu de Opciones     *
*                                        *
* Eliga una opcion:                      *
*                                        *
* 1. Agregar desayuno                    *
* 2. Eliminar desayuno                   *
* 3. Mostrar lista de desayunos          *
* 4. Salir                               *
*                                        *
******************************************
";

do
{
    Console.WriteLine(txt);
    opcion = Convert.ToInt32(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.Clear();
            opciones.Crear(ref lista);
            Console.WriteLine("\n¡Desayuno añadido!");
            Console.WriteLine("Presione cualquier tecla para volver al menu...");
            Console.ReadKey();
            break;
        case 2:
            Console.Clear();
            opciones.Eliminar(ref lista);
            Console.WriteLine("\n¡Desayuno eliminado!");
            Console.WriteLine("Presione cualquier tecla para volver al menu...");
            Console.ReadKey();
            break;
        case 3:
            Console.Clear();
            opciones.Mostrar(lista);
            Console.WriteLine("\nPresione cualquier tecla para volver al menu...");
            Console.ReadKey();
            break;
    }
    Console.Clear();

} while (opcion != 4);