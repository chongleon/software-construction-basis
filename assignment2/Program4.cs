
    using System;
class Matrix
{
    double[,] matrix;
    public int row = 0, col = 0;
    //int i=0,j=0;
    //int count=1;
    //定义三个不同情况下的构造函数
    public Matrix()
    {
    }
    public Matrix(int row)
    {
        matrix = new double[row, row];
    }
    public Matrix(int row, int col)
    {
        this.row = row;
        this.col = col;
        matrix = new double[row, col];
    }
    //复制构造函数
    public Matrix(Matrix m)
    {
        int row = m.row;
        int col = m.col;
        matrix = new double[row, col];
        for (int i = 0; i < row; i++)
            for (int j = 0; j < col; j++)
                matrix[i, j] = m.getNum(i, j);
    }
    //输入相应的值，对矩阵进行设置
    public void SetNum(int i, int j, double num)
    {
        matrix[i, j] = num;
    }
    //得到相应的矩阵某个数
    public double getNum(int i, int j)
    {
        return matrix[i, j];
    }
    //输出矩阵
    public void OutputM()
    {
        Console.WriteLine("矩阵为：");
        for (int p = 0; p < row; p++)
        {
            for (int q = 0; q < col; q++)
            {
                Console.Write("\t" + matrix[p, q]);
            }
            Console.Write("\n");
        }
    }
    //输入矩阵具体数字实现
    public void InputM(int Row, int Col)
    {
        for (int a = 0; a < Col; a++)
        {
            for (int b = 0; b < Col; b++)
            {
                Console.WriteLine("第{0}行，第{1}列", a + 1, b + 1);
                double value = Convert.ToDouble(Console.ReadLine());
                this.SetNum(a, b, value);
            }
        }
    }

    //得到matrix
    public double[,] Detail
    {
        get { return matrix; }
        set { matrix = value; }
    }

    public bool IsToeplitzMatrix(int[][] matrix)
    {
        //每个元素都与左上角的数字比较
        for (var i = 0; i < matrix.Length; i++)
        {
            for (var j = 0; j < matrix[i].Length; j++)
            {
                if (i != 0 && j != 0 && matrix[i][j] != matrix[i - 1][j - 1])
                {
                    return false;
                }
            }
        }
        return true;
    }

    //主函数
    public static void Main()
    {
        int Row, Col;
        Console.WriteLine("请输入想要的矩阵行数与列数");
        Row = Convert.ToInt32(Console.ReadLine());
        Col = Convert.ToInt32(Console.ReadLine());
        Matrix m = new Matrix(Row, Col);
        Console.WriteLine("输入矩阵数据");
        m.InputM(Row, Col);
        m.OutputM();

    }

}


