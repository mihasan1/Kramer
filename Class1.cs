using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KramerVisual
{
    class Class1
    {
        // переменные класса
        public int n { get; set; }
        private double[,] arr=new double[3,3];
        private double[] right=new double[3];
        public double[] solve=new double[3];

        public Class1(int n_,double[,] a, double[] b)// конструктор класса
        {
            n = n_;
            for(int i=0; i<n; i++)
            {
                right[i] = b[i];
                for(int j=0; j<n; j++)
                {
                    arr[i,j] = a[i,j];
                }
            }
        }

        private static double Determinant(double[,] A, int n)//метод поиска детерминанта (определителя матрицы)
        {
            double det = 0;
            if (n == 2) // формула для матрицы 2х2
            {
                det = (A[0, 0] * A[1, 1]) - (A[1, 0] * A[0, 1]);
            }
            else // для матрицы 3х3
                det = (A[0, 0] * A[1, 1] * A[2, 2]) + (A[2, 0] * A[0, 1] * A[1, 2]) + (A[1, 0] * A[2, 1] * A[0, 2]) -
                    (A[2, 0] * A[1, 1] * A[0, 2]) - (A[0, 0] * A[2, 1] * A[1, 2]) - (A[1, 0] * A[0, 1] * A[2, 2]);
            return det;
        }


        private static void equal(int n, double[,] A, double[,] B)//Метод присвоения A = B
        {
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    A[i, j] = B[i, j];
        }
        private static void change(int n, int N, double[,] A, double[] b)//Метод для подстановки правой стороны СЛАР в матрицу
        {
            for (int i = 0; i < n; i++)
                A[i, N] = b[i];
        }
        public int SLAU_kramer() // Главный метод решения СЛАУ методом Крамера
        {
            double[,] An = new double[n, n];
            double det1 = Determinant(arr, n); //поиск определителя
            if (det1 == 0) return 1;//определитель = 0 то СЛАУ не решается.
            for (int i = 0; i < n; i++) // подстановка правой части СЛАУ в матрицы, и нахождение ответов
            {
                equal(n, An, arr);
                change(n, i, An, right);
                solve[i] = Determinant(An, n) / det1;
            }
            return 0;
        }
    }
}
