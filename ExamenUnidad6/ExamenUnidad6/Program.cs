using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExamenUnidad6
{
    internal class Program
    {
        class inventario
        {
            //Campos de la clase 
            public string nombreProducto;
            public string descripsion;
            public float precio;
            public int CantidadStock;
           

            //Constructor de la clase
            public inventario(string nombreProducto, string descripsion, float precio, int cantidadStock)
            {
                this.nombreProducto = nombreProducto;
                this.descripsion = descripsion;
                this.precio = precio;
                CantidadStock = cantidadStock;
            }

            public void MostrarInventario()
            {
                Console.WriteLine("Nombre del proucto:" + nombreProducto);
                Console.WriteLine("Descripsion del producto: " + descripsion);
                Console.WriteLine("Precio: " + precio);
                Console.WriteLine("Cantidad en Stock: " + CantidadStock);   
            }
        }
        static void Main(string[] args)
        {
            //Declaracion de variables 
            string nombreProductos, descripsion;
            float precio;
            int cantidadStock;
            StreamWriter sw = null;

            try
            {
                //Creacion del archivo 
                sw = new StreamWriter("Productos.txt", true);

                //Asignacion de datos 
                Console.WriteLine("------- Inventario Amazon --------");
                Console.Write("Introduce el nombre del producto: ");
                nombreProductos = Console.ReadLine();

                Console.Write("Introduce la descripsion del producto: ");
                descripsion = Console.ReadLine();

                Console.Write("Introduce el precio del producto: ");
                precio = float.Parse(Console.ReadLine());

                Console.Write("Introduce la cantidad en stock del producto: ");
                cantidadStock = int.Parse(Console.ReadLine());
                Console.WriteLine("Presiona ENTER para continuar.");
                Console.ReadKey();
                Console.Clear();

                //Creacion del objeto 
                inventario i1 = new inventario(nombreProductos,descripsion,precio,cantidadStock);
                i1.MostrarInventario();
                sw.WriteLine(nombreProductos+ " "+ i1.descripsion + " {0:c}",precio + " "+cantidadStock);
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                Console.WriteLine("Ruta: " + ex.StackTrace);
            }
            finally
            {
                sw.Close();
            }

        }
    }
}
