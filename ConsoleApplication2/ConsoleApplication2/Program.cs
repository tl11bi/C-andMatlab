using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathWorks.MATLAB.NET.Arrays;//在MWArray.dll中，最常用的
using MathWorks.MATLAB.NET.Utility;//在MWArray.dll中，最常用的
using MatrixOpera; 
namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            MatrixOpera.Matrixes test = new MatrixOpera.Matrixes(); //将myMathClass类实例化

            double[] a = { 1, 2, 3, 4, 5, 6 };//定义两个输入参数
            double[] b = { 1, 1, 1, 1, 1, 1 };//它们是两个一维静态数组

            double[,] c = new double[3, 2];//定义C#中接收输出参数的类型
            double[,] d = new double[3, 2];//是两个二维数组

            //把两个输入参数都转换成中间类型，中间类型也是矩阵所以要指明维数
            //这里将两个输入参数转换为两个三行两列的矩阵
            MWNumericArray matlab_a = new MWNumericArray(3, 2, a);
            MWNumericArray matlab_b = new MWNumericArray(3, 2, b);

            //输入参数成功转化为两个MWArray元素类型
            MWArray[] agrsIn = new MWArray[] { matlab_a, matlab_b };

            //声明输出参数是两个MWArray元素类型，一定要写数量
            MWArray[] agrsOut = new MWArray[2];

            //调用matlab函数，2表示输出参数的个数，输出参数前需要加 ref 关键字
            //此例实现了两个三行两列的矩阵相加减
            test.MatrixOpera(2, ref agrsOut, agrsIn);

            //把两个输出参数转换成中间类型
            MWNumericArray net_c = agrsOut[0] as MWNumericArray;//matlab函数第一个输出参数
            MWNumericArray net_d = agrsOut[1] as MWNumericArray;//第二个输出参数

            //转换成C#中的接收参数
            c = (double[,])net_c.ToArray();//转化为二维数组
            d = (double[,])net_d.ToArray();
            //一定要注意最后接收参数的转化，不同类型的接收参数用的转换函数不同
            //二维数组用ToArray()函数转换
            //一维数组用ToVector(MWArrayComponent.Real)函数转换
            //单个double值用ToScalarDouble()函数转换
            //单个int值用ToScalarInteger()函数转换

            
        }
    }
}
