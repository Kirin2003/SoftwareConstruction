using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 获得输入和检查合法性

            //先输入第一个数
            Console.WriteLine("请输入第一个数：");
            string num1 = Console.ReadLine();
            //接着判断输入的这个数是否为整数，如果不是整数，提示重新输入第一个数
            //实参：真正进行方法中使用的参数
            double number1 = CheckNum(num1);
            //先输入第二个数
            Console.WriteLine("请输入第二个数：");
            string num2 = Console.ReadLine();
            double  number2 = CheckNum(num2);
            //选择运算符
            Console.WriteLine("请选择运算符：+, -, *, /");
            string fun = Console.ReadLine();
            string op = CheckOp(fun);
            //如果是除法，检查合法性：除数是否为零
            if(op == "/")
            {
                number2 = CheckDivision(num2);

            }


            // 计算

            double result = Calculate(fun, number1, number2);

            // 输出，按指定格式
            
            Console.WriteLine("{0}{2}{1}={3}", number1, number2, op, result);

            Console.ReadKey();
        }

        /// <summary>
        /// 检测这个字符串是否能够转换为32位有符号整数
        /// </summary>
        /// <param name="num">要进行判断的字符串</param>
        static double CheckNum(string num)
        {
            try
            {
                double i = double.Parse(num);
                return i;
            }
            catch (Exception e)
            {
                Console.WriteLine("数字不合法，请重新输入：");
                string str = Console.ReadLine();
                //递归算法
                return CheckNum(str);
            }
        }

        static double CheckDivision(string num)
        {
            // 如果是除法，先检查输入数字是否合法，再检查是否为零
            double i = CheckNum(num);

            
            
                if (i != 0)
                {
                    return i;
                } else
                {
                    Console.WriteLine("除数为零！请重新输入第二个数");
                    string str = Console.ReadLine();
                    //递归算法
                    return CheckDivision(str);
                }
           
            
        }

        static string CheckOp(string input_op)
        {
            if((input_op == "+" || input_op == "-" || input_op == "*" || input_op == "/"))
            {
                return input_op;
            } else
            {
                Console.WriteLine("运算符不合法，请重新输入");
                Console.WriteLine("请选择运算符：+, -, *, /");
                string input_again = Console.ReadLine();
                return CheckOp(input_again);
            }
        }

        

        static double Calculate(string fun, double num1, double num2)
        {
            double res = 0;
            
            switch (fun)
            {
                case "+":
                    res = num1 + num2;
                    
                   
                    break;
                case "-":
                    res = num1 - num2;
                    
                    break;
                case "*":
                    res = num1 * num2;
                    ;
                    break;
                case "/":
                    

                    res = num1 / num2;
                   
                    break;
               
            }
           
            return res;
            
        }
    }

}
