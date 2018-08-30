using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reinas
{
    class ClsMetodos
    {

        public void Ensayar(int i,
                        int[] solucion,
                        bool[] columnas,
                        bool[] diagonalD,
                        bool[] diagonalI,
                        ref int reina)
        {
            int j;
            for (j = 0; j < 8; j++)
            {
                if (columnas[j] && diagonalD[i + j] && diagonalI[i - j + 7])
                {
                    solucion[i] = j;
                    columnas[j] = false;
                    diagonalD[i + j] = false;
                    diagonalI[i - j + 7] = false;
                    reina++;
                    if (i < 7)
                    {
                        Ensayar(i + 1, solucion, columnas, diagonalD, diagonalI, ref reina);
                        if (reina < 8)
                        {
                            columnas[j] = true;
                            diagonalD[i + j] = true;
                            diagonalI[i - j + 7] = true;
                            reina--;
                        }
                    }
                }
            }
        } //ensayar
        public void Inicializar(int[] solucion,
                                bool[] columnas,
                                bool[] diagonalD,
                                bool[] diagonalI)
        {

            for (int i = 0; i < solucion.Length; i++)
            {
                solucion[i] = 0;
                columnas[i] = true;
            }
            for (int i = 0; i < diagonalD.Length; i++)
            {
                diagonalD[i] = true;
                diagonalI[i] = true;
            }
        }//inicializar
        public void Mostrar(int[] solucion)
        {

            for (int i = 0; i < solucion.Length; i++)
            {
                for (int j = 0; j < solucion.Length; j++)
                {
                    if (j == solucion[i])
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("[X]");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("[0]");
                    }
                }//j
                Console.WriteLine();
                Console.WriteLine();
            }//i
        }//Mostrar
    }//class
}