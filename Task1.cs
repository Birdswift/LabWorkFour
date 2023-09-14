using System.Collections;

namespace LabWorkFour
{
    class MyMatrix
    {
        public int _m;
        public int _n;
        public int[,] _data;
        public MyMatrix(int m, int n)
        {
            _m = m;
            _n = n;
            Console.WriteLine("Please, input random generation key");
            int ch = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            _data = new int[_m, _n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    _data[i, j] = random.Next(ch);
                }
            }
        }

        static public MyMatrix operator +(MyMatrix a, MyMatrix b)
        {
            if (a._m != b._m || a._n != b._n) throw new Exception("Impossible to sum");
            MyMatrix c = new MyMatrix(a._m, a._n);
            for (int i = 0; i < c._m; i++)
            {
                for (int j = 0; j < c._n; j++)
                {
                    c._data[i, j] = a._data[i, j] + b._data[i, j];
                }

            }
            return c;
        }

        static public MyMatrix operator -(MyMatrix a, MyMatrix b)
        {
            if (a._m != b._m || a._n != b._n) throw new Exception("Impossible to sub");
            MyMatrix c = new MyMatrix(a._m, a._n);
            for (int i = 0; i < c._m; i++)
            {
                for (int j = 0; j < c._n; j++)
                {
                    c._data[i, j] = a._data[i, j] - b._data[i, j];
                }

            }
            return c;
        }

        static public MyMatrix operator *(MyMatrix a, MyMatrix b)
        {
            if (a._n != b._m) throw new Exception("Матрицы нельзя перемножить");
            MyMatrix c = new MyMatrix(a._m, b._n);
            for (int i = 0; i < a._m; i++)
            {
                for (int j = 0; j < b._n; j++)
                {
                    for (int k = 0; k < b._m; k++)
                    {
                        c._data[i, j] += a._data[i, k] * b._data[k, j];
                    }
                }
            }
            return c;
        }

        static public MyMatrix operator *(int a, MyMatrix b)
        {
            MyMatrix c = new MyMatrix(b._m, b._n);
            for (int i = 0; i < b._m; i++)
            {
                for (int j = 0; j < b._n; j++)
                {
                    c._data[i, j] = a * b._data[i, j];
                }
            }
            return c;
        }

        static public MyMatrix operator /(MyMatrix b, int a)
        {
            MyMatrix c = new MyMatrix(b._m, b._n);
            for (int i = 0; i < b._m; i++)
            {
                for (int j = 0; j < b._n; j++)
                {
                    c._data[i, j] = b._data[i, j] / a;
                }
            }
            return c;
        }

        public int this[int index1, int index2]
        {
            get { return this._data[index1, index2]; }
            set { this._data[index1, index2] = value; }
        }
        public void PrintMyMatrix()
        {
            for (int i = 0; i < _m; i++)
            {
                for (int j = 0; j < _n; j++)
                {
                    Console.Write(" " + _data[i, j]);
                }
                Console.WriteLine();
            }
        }

    }
}



    
