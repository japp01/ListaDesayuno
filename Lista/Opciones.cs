using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    public class Opciones
    {
        public void Crear(ref Desayuno[] desayunos)
        {
            Array.Resize(ref desayunos, desayunos.Length + 1);

            Desayuno d = new Desayuno();
            Console.Write("Nombre: ");
            d.Nombre = Console.ReadLine();
            Console.Write("Cantidad: ");
            d.Cantidad = Convert.ToInt32(Console.ReadLine());

            desayunos[desayunos.Length - 1] = d;
        }

        public void Mostrar(Desayuno[] desayunos)
        {
            for (int i = 0; i < desayunos.Length; i++)
            {
                Console.WriteLine($"Desayuno {i + 1}");
                Console.WriteLine($"Nombre: {desayunos[i].Nombre}");
                Console.WriteLine($"Cantidad: {desayunos[i].Cantidad} \n");
            }
        }
        public void Eliminar(ref Desayuno[] desayunos)
        {
            Console.WriteLine("Ingrese numero de desayuno a eliminar: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = n - 1; i < desayunos.Length - 1; i++)
            {
                desayunos[i] = desayunos[i + 1];
            }
            Array.Resize(ref desayunos, desayunos.Length - 1);
        }
    }
}
