using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    class Program
    {
        static bool lista(int numero)
        {
            return numero != 0;
        }

        class cliente
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
        }
        class Factura
        {
            public int Id { get; set; }
            public string Observacion { get; set; }
            public int IdCliente { get; set; }
            public DateTime Fecha { get; set; }
            public int Total { get; set; }
        }

        static void Main(string[] args)
        {
            int suma = 0, cuadrado = 0, mayores = 0, promedio = 0, contador2 = 0, 
                pares = 0, contador3=0, impares=0, unicos=0, residuo, a, b;
            

            Random nAleatorio = new Random();

            List<Int32> ListaNumero = new List<Int32> { };
            List<Int32> ListaCuadrados = new List<Int32> { };
            List<Int32> ListaPrimos = new List<Int32> { };
            List<Int32> ListaUnicos = new List<Int32> { };

            for (int i = 0; i < 50; i++)
            {
                ListaNumero.Add(nAleatorio.Next(0, 100));
            }

            var n = from l in ListaNumero where lista(1) select l;
            var c = from m in ListaCuadrados where lista(1) select m;

            Console.WriteLine("***************LISTA DE NÚMEROS ALEATORIOS*****************");
            foreach (var item in n)
            {
                Console.WriteLine(item);

            }


            //PRIMOS
            foreach (int item in n)
            {
                
                a = 2;
                b = 0;
                while (((a < item) & (b == 0)))
                {
                    residuo = item % a;
                    if ((residuo == 0))
                    {
                        b = 1;
                    }
                    else
                    {
                        a++;
                    }
                }
                if ((b == 0))
                {
                    Console.WriteLine("*******************PRIMOS******************");
                    Console.WriteLine(item);
                }
                else
                {

                }
            }

            //SUMA
            foreach (var item in n)
            {
                 suma = ListaNumero.Sum();
            }
            Console.WriteLine("*******************SUMA TOTAL**********************");
            Console.WriteLine("SUMA TOTAL: " + suma);


            //LISTA CUADRADOS
            Console.WriteLine("*******************LISTA CUADRADOS**********************");
            foreach (var item in n)
            {
                cuadrado = item * item;
                ListaCuadrados.Add(cuadrado);
                Console.WriteLine(cuadrado);
            }

            //LISTA PRIMOS
            Console.WriteLine("*******************LISTA PRIMOS**********************");
            foreach (int item in n)
            {

                a = 2;
                b = 0;
                while (((a < item) & (b == 0)))
                {
                    residuo = item % a;
                    if ((residuo == 0))
                    {
                        b = 1;
                    }
                    else
                    {
                        a++;
                    }
                }
                if ((b == 0))
                {
                    ListaPrimos.Add(item);
                    Console.WriteLine(item);
                }
                else
                {

                }
            }

            //PROMEDIO
            foreach (var item in n)
            {
                if (item > 50)
                {
                    mayores = mayores + item;
                    contador2++;
                }
            }
            promedio = mayores / contador2;
            Console.WriteLine("*******************PROMEDIO**********************");
            Console.WriteLine("PROMEDIO: " + promedio);

            //PARES E IMPARES
            foreach (var item in n)
            {
                
                if (item % 2 == 0)
                {
                    pares = pares + 1;
                }
                else
                {
                    impares = impares + 1;
                }
                
            }
            Console.WriteLine("*******************PARES E IMPARES**********************");
            Console.WriteLine("PARES: " +pares);
            Console.WriteLine("IMPARES: " +impares);


            //NÚMERO Y CANTIDAD DE VECES
            Console.WriteLine("*******************CANTIDAD DE VECES REPETIDO**********************");
            foreach (var item in n)
            {
                if (item == item)
                {
                    
                    contador3++;
                }
            }
            Console.WriteLine("CONTADOR: "+contador3);

            //DESCENDENTE
            Console.WriteLine("*******************LISTA DESCENDENTE**********************");
            (from l in ListaNumero where l>0 orderby l descending select l).ToList().ForEach(i => Console.WriteLine(i)); ;


            //NÚMEROS ÚNICOS
            Console.WriteLine("*******************NÚMEROS ÚNICOS**********************");
            for (int i = 0; i < ListaNumero.Count; i++)
            {
                if (!(ListaUnicos.Contains(ListaNumero[i])))
                {
                    ListaUnicos.Add(ListaNumero[i]);
                }
            }
            (from l in ListaNumero where l > 0 orderby l ascending select l).ToList().ForEach(i => Console.WriteLine(i)); ;


            //SUMA NÚMEROS ÚNICOS
            Console.WriteLine("****************SUMA NÚMEROS ÚNICOS*******************");
            for (int i = 0; i < ListaNumero.Count; i++)
            {
                if (!(ListaUnicos.Contains(ListaNumero[i])))
                {
                    ListaUnicos.Add(ListaNumero[i]);
                }
            }
            foreach (var item in ListaUnicos)
            {
                unicos = unicos + item;
            }
            Console.WriteLine("SUMA DE NÚMEROS ÚNICOS: " + unicos);


            Console.WriteLine("****************************************************");
            Console.WriteLine("*******************SEGUNDO EJERCICIO****************");
            Console.WriteLine("****************************************************");

            //LISTA CLIENTE
            List<cliente> ListaCliente = new List<cliente>
            {
                new cliente{Id=1, Nombre="EMMELY" },
                new cliente{Id=2, Nombre="MARIA" },
                new cliente{Id=3, Nombre="MERCEDES" },
                new cliente{Id=4, Nombre="NEIVIS" },
                new cliente{Id=5, Nombre="BRYAN" },
                new cliente{Id=6, Nombre="JOEL" },
                new cliente{Id=7, Nombre="JESUS" },
                new cliente{Id=8, Nombre="SANTIAGO" },
                new cliente{Id=9, Nombre="DAYANNA" },
                new cliente{Id=10, Nombre="MARENA" },

            };

            //LISTA FACTURA
            List<Factura> ListaFactura = new List<Factura>
            {
                new Factura{Id=1, Observacion="Articulo 1", IdCliente=1, Fecha=new DateTime(2018,01,2,14,50,20), Total=90},
                new Factura{Id=2, Observacion="Articulo 2", IdCliente=2, Fecha=new DateTime(2018,03,4,12,33,40), Total=40},
                new Factura{Id=3, Observacion="Articulo 3", IdCliente=1, Fecha=new DateTime(2018,04,2,13,12,34), Total=200},
                new Factura{Id=4, Observacion="Articulo 4", IdCliente=3, Fecha=new DateTime(2018,01,2,9,11,23), Total=60},
                new Factura{Id=5, Observacion="Articulo 5", IdCliente=6, Fecha=new DateTime(2019,01,3,14,12,56), Total=420},
                new Factura{Id=6, Observacion="Articulo 6", IdCliente=2, Fecha=new DateTime(2018,10,5,20,33,29), Total=80},
                new Factura{Id=7, Observacion="Articulo 7", IdCliente=3, Fecha=new DateTime(2017,01,2,16,23,10), Total=110},
                new Factura{Id=8, Observacion="Articulo 8", IdCliente=8, Fecha=new DateTime(2018,11,2,16,13,59), Total=200},
                new Factura{Id=9, Observacion="Articulo 9", IdCliente=10, Fecha=new DateTime(2018,01,6,13,12,36), Total=100},
                new Factura{Id=10, Observacion="Articulo 10", IdCliente=9, Fecha=new DateTime(2018,12,2,18,10,01), Total=20},
            };

            var resultado = from i in ListaCliente orderby i.Nombre select i;
            var resultado2 = from i in ListaFactura orderby i.Fecha select i;
            var factura = from i in ListaFactura orderby i.Fecha select i;

            //ORDEN POR NOMBRES
            Console.WriteLine("********CLIENTES ORDENADOS POR NOMBRES********");
            foreach (var item in resultado)
            {
                Console.WriteLine(item.Nombre);
            }

            //ORDEN POR FECHAS
            Console.WriteLine("*********VENTAS ORDENADAS POR FECHAS**********");
            foreach (var item in resultado2)
            {
                Console.WriteLine(item.Fecha);
            }

            int mayor1 = 0;
            int mayor2 = 0;
            int mayor3 = 0;

            string primero = "";
            string segundo = "";
            string tercero = "";

            //1ER MAYOR VENTAS
            foreach (var item in factura)
            {
                if (item.Total > mayor1)
                {
                    mayor1 = item.Total;
                    primero = item.Observacion;
                }
            }

            //2DO MAYOR VENTAS
            foreach (var item in factura)
            {
                if (item.Total > mayor2 && item.Total != mayor1)
                {
                    mayor2 = item.Total;
                    segundo = item.Observacion;
                }
            }

            //3ER MAYOR VENTAS
            foreach (var item in factura)
            {
                if (item.Total > mayor3 && item.Total != mayor1 && item.Total != mayor2)
                {
                    mayor3 = item.Total;
                    tercero = item.Observacion;
                }
            }

            Console.WriteLine("************TRES CLIENTES CON MAYORES VENTAS*******");
            Console.WriteLine("EL" + primero + "  " + "VENTA:" + mayor1);
            Console.WriteLine("EL" + segundo + "  " + "VENTA:" + mayor2);
            Console.WriteLine("EL" + tercero + "  " + "VENTA:" + mayor3);

            int mayor = 0;
            int x = 0, y = 0, z = 0;

            int menor1 = 0;
            int menor2 = 0;
            int menor3 = 0;

            string priMenor = "";
            string seguMenor = "";
            string terMenor = "";


            foreach (var item in factura)
            {
                if (item.Total > mayor)
                {
                    mayor = item.Total;
                    x = item.Total;
                    y = item.Total;
                    z = item.Total;
                }
            }

            //1ER MENOR
            foreach (var item in factura)
            {
                if (item.Total < x)
                {
                    x = item.Total;
                    menor1 = item.Total;
                    priMenor = item.Observacion;
                }
            }

            //2DO MENOR
            foreach (var item in factura)
            {
                if (item.Total < y && item.Total != menor1)
                {
                    y = item.Total;
                    menor2 = item.Total;
                    seguMenor = item.Observacion;
                }
            }

            //3ER MENOR
            foreach (var item in factura)
            {
                if (item.Total < z && item.Total != menor1 && item.Total != menor2)
                {
                    z = item.Total;
                    menor3 = item.Total;
                    terMenor = item.Observacion;
                }
            }

            Console.WriteLine("************TRES CLIENTES CON MENOS VENTAS*********");
            Console.WriteLine("EL" + priMenor + "  " + "VENTA:" + menor1);
            Console.WriteLine("EL" + seguMenor + "  " + "VENTA:" + menor2);
            Console.WriteLine("EL" + terMenor + "  " + "VENTA:" + menor3);

            Console.WriteLine("*********CLIENTE CON MÁS VENTAS REALIZADAS**************");
            var Mayor = factura.Max(i => i.Total);
            Console.WriteLine("CLIENTE CON MAYOR VENTAS: " + "  " + primero + "  " + " VENTA: " + "  " + Mayor);

            var r = from i in factura select i;
            System.DateTime afecha = new DateTime(2018, 05, 12);
            var RangoFecha = from i in factura where i.Fecha >= afecha select i;
            Console.WriteLine("*******VENTAS REALIZADAS HACE MENOS DE UN AÑO**********");
            foreach (var item in RangoFecha)
            {
                Console.WriteLine("CLIENTE: " + item.IdCliente + " FECHA:" + "  " + item.Fecha);
            }
            

            System.DateTime bfecha = new DateTime(2017, 05, 12);
            var Rf = from i in factura where i.Fecha < bfecha select i;
            Console.WriteLine("*******LAS VENTA MÁS ANTIGUA**********");
            foreach (var item in Rf)
            {
                Console.WriteLine("CLIENTE: " + item.IdCliente + " FECHA:" + "  " + item.Fecha);
            }


            System.DateTime cfecha = new DateTime(2019, 01, 1);
            var CF = from i in factura where i.Fecha > cfecha select i;
            Console.WriteLine("");
            Console.WriteLine("*******LA ULTIMA VENTA REALIZADA**********");
            foreach (var item in CF)
            {
                Console.WriteLine("CLIENTE: " + item.IdCliente + " FECHA:" + "  " + item.Fecha);
            }

            Console.ReadKey();


        }

    }  
}
