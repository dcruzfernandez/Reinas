using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Reinas
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Solucion = new int[8];
            bool[] Columnas = new bool[8];
            bool[] DiagonalD = new bool[15];
            bool[] DiagonalI=new bool[15];
            int reina = 0;
            ClsMetodos Calculos = new ClsMetodos();
            Calculos.Inicializar(Solucion, Columnas, DiagonalD, DiagonalI);
            Calculos.Ensayar(0, Solucion, Columnas, DiagonalD, DiagonalI, ref reina);
            Calculos.Mostrar(Solucion);
            Console.Read();
        }
    }
}
