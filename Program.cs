using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arboBinario
{
    public class Nodo
    {
        public Nodo hi; // hi hijo izquierdo
        public Nodo hd; //hd hijo derecho
        public int valor;
      
        public Nodo()
        {
            hi = null;
            hd = null;
            valor = 0;
        }
        
    }
    
  
    class Program
    {   
        public static int LCI = 0, i=0, j = 1, altura = 0;
        static void Main(string[] args)
        {
            int opcionmenu = 0, dato = 0, LCIM = 0, numnodo = 0;
            Nodo raiz = null;

            do
            {
                Console.WriteLine("   MENU ARBOL BB");
                Console.WriteLine("");
                Console.WriteLine("1.- Registrar un nuevo nodo ");
                Console.WriteLine("2.- Mostrar/Recorrer el Arbol");
                Console.WriteLine("3.- Buscar Un Nodo");
                Console.WriteLine("4.- Eliminar un nodo");
                Console.WriteLine("5.- Calcular LCI");
                Console.WriteLine("6.- Calcular LCIM");
                Console.WriteLine("7.- calcular la Altura");
                 Console.WriteLine("8.- Finalizar");
                Console.WriteLine("");
                Console.Write("Opcion: ");

                
                opcionmenu = int.Parse(Console.ReadLine());

                switch (opcionmenu)
                {
                    case 1:
                        
                        Console.Write("Ingrese el Dato:  ");
                        dato = int.Parse(Console.ReadLine());

                        if(raiz == null)
                        {
                            Nodo nuevo = new Nodo();
                            nuevo.valor= dato;
                            raiz = nuevo;
                        }
                         else
                        {
                            insertar(raiz, dato);
                        }
                        numnodo ++ ;
                        Console.ReadLine();
                        Console.Clear();
                       
                    break;
                    case 2:
                        PreOrden(raiz);
                        Console.Write("...recorrido en preorden... ");
                        Console.ReadLine();
                        Console.Clear();
                        
                    break;

                    case 3:
                        Console.Write("Ingrese el Dato:  ");
                        dato = int.Parse(Console.ReadLine());
                        if(raiz == null)
                        {
                            Console.Write("No exisren nodo en el arbol");
                        }
                         else
                        {
                            Busqueda(raiz, dato);
                        }
                        Console.ReadLine();
                        Console.Clear();
                    break;

                    case 4:
                        
                    break;

                    case 5:
                        
                        CalcularLCI(raiz);
                        Console.Write("la LCI es: " + LCI);
                        LCI = 0;
                        i=0;
                        Console.ReadLine();
                        Console.Clear();
                    break;
                    case 6:
                        CalcularLCI(raiz);
                        LCIM = LCI/numnodo;
                        Console.Write("la LCIM es igual a : " + LCIM);
                        LCI = 0;
                        i=0;
                        LCIM = 0;
                        Console.ReadLine();
                        Console.Clear();

                        
                    break;
                    case 7:

                        if (raiz != null)
                        {
                            AlturaABB(raiz);
                            Console.WriteLine("La altura del arbol es: " + altura);
                        }
                        else
                        {
                            Console.Write("Arbol esta vacio");
                        }
                        Console.ReadLine();
                        j = 1;
                        i = 0;
                        altura = 0;
                        Console.Clear();

                    break;
                }
            }
            while (opcionmenu != 8);
            
            Console.ReadKey();
        }

        public static void insertar(Nodo raiz, int dato) // metodo insertar
        {
            if (dato < raiz.valor)
            {
                if (raiz.hi == null)
                {
                Nodo nuevo = new Nodo(); // viene null
                nuevo.valor = dato;
                raiz.hi= nuevo;

                }
                else
                {
                insertar(raiz.hi, dato);
                }
            }
            else
            {
                if(dato > raiz.valor)
                {
                    if(raiz.hd==null)
                    {
                        Nodo nuevo = new Nodo(); // viene null
                        nuevo.valor = dato;
                        raiz.hd= nuevo;
                         
                    }
                    else
                    {
                        insertar(raiz.hd, dato);
                    }
                }
                else
                {
                    Console.WriteLine("El nodo ya existe en el arbol");
                
                }
            
            }
        }
        public static void PreOrden(Nodo imprimir) // metodo recorre el arbol o imprimir en preorden
        {
            if (imprimir !=null)
            {
                Console.Write(imprimir.valor + " ");
                PreOrden(imprimir.hi);
                PreOrden(imprimir.hd);
            }
        }
        public static void Busqueda(Nodo raiz, int dato) 
        {
            if (dato < raiz.valor)
            {
                if (raiz.hi == null)
                {
                    Console.Write("La imformacion no se encuentra en el arbol");
                }
                else
                {
                    Busqueda(raiz.hi, dato);
                }
            }
            else
            {
                if (dato > raiz.valor)
                {
                    if(raiz.hd== null)
                    {
                        Console.Write("La imformacion no se encuentra en el arbol");
                    }
                    else
                    {
                        Busqueda(raiz.hd, dato);
                    }
                }
                else
                {
                    Console.Write("La imformacion esta en el arbol");
                }
            }
        }
        public static void CalcularLCI( Nodo raiz)
        {
            if(raiz !=null)
            {
                i++;
                LCI = LCI +i;
                CalcularLCI(raiz.hi);
                CalcularLCI(raiz.hd);
                i--;
            }
        }
        public static void AlturaABB(Nodo Altura)
        {
            if(Altura !=null)
            {
                i++;

                if (i == j)
                {
                    j++;
                    altura = j-1;
                }
                AlturaABB(Altura.hi);
                AlturaABB(Altura.hd);
                i--;
            }
        }
    }
}
