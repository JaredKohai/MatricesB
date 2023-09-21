using System;

namespace MatricesB
{

    public class Matriz
        {
            private int[,] matriz;
            private int filas;
            private int columnas;

            public Matriz(int[,] matriz)
            {
                this.matriz = matriz;
                this.filas = matriz.GetLength(0);
                this.columnas = matriz.GetLength(1);
            }
            public Matriz(Matriz segundaMatriz)
            {
                this.filas = segundaMatriz.filas;
                this.columnas = segundaMatriz.columnas;
                this.matriz = new int[filas, columnas];
                Array.Copy(segundaMatriz.matriz, this.matriz, filas * columnas);
            }

            public void MostrarMatriz()
            {
                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        Console.Write(matriz[i, j].ToString().PadLeft(5)); 
                    }
                    Console.WriteLine();
                }
            }

            public Matriz Sumar(Matriz segundaMatriz)
            {
                if (filas == segundaMatriz.filas && columnas == segundaMatriz.columnas)
                {
                    int[,] resultado = new int[filas, columnas];
                    for (int i = 0; i < filas; i++)
                    {
                        for (int j = 0; j < columnas; j++)
                        {
                            resultado[i, j] = matriz[i, j] + segundaMatriz.matriz[i, j];
                        }
                    }
                    return new Matriz(resultado);
                }
                else
                {
                    return null;
                }
            }

            public Matriz Restar(Matriz segundaMatriz)
            {
                if (filas == segundaMatriz.filas && columnas == segundaMatriz.columnas)
                {
                    int[,] resultado = new int[filas, columnas];
                    for (int i = 0; i < filas; i++)
                    {
                        for (int j = 0; j < columnas; j++)
                        {
                            resultado[i, j] = matriz[i, j] - segundaMatriz.matriz[i, j];
                        }
                    }
                    return new Matriz(resultado);
                }
                else
                {
                    return null;
                }
            }

            public Matriz Multiplicar(Matriz segundaMatriz)
            {
                if (filas == segundaMatriz.filas && columnas == segundaMatriz.columnas)
                {
                    int[,] resultado = new int[filas, columnas];
                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        resultado[i, j] = matriz[i, j] * segundaMatriz.matriz[i, j];
                    }
                }
                return new Matriz(resultado);
                }
                else
                {
                    return null;
                }
            }

            public Matriz División(Matriz segundaMatriz)
            {
                if (filas == segundaMatriz.filas && columnas == segundaMatriz.columnas)
                {
                    int[,] resultado = new int[filas, columnas];
                    for (int i = 0; i < filas; i++)
                    {
                        for (int j = 0; j < columnas; j++)
                        {
                            resultado[i, j] = matriz[i, j] / segundaMatriz.matriz[i, j];
                        }
                    }
                    return new Matriz(resultado);
                }
                else
                {
                    return null;
                }
            }


        }
}

