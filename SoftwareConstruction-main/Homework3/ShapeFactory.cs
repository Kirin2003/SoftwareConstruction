using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public class ShapeFactory
    {

        //在生产形状时检查输入合法性
        public static Shape ShapeRandomGenerator()
        {

            string[] types = { "triangle", "square", "rectangle" };
            Random r = new Random();
            string randomTypes = types[r.Next(types.Length)];

            double[] randomParameters = new double[3];

            Shape s;


            switch (randomTypes)
            {
                case "rectangle":
                    if (randomParameters.Length < 2) { throw new ArgumentException("参数数量不对，无法构造长方形"); }

                    do
                    {
                        randomParameters[0] = r.NextDouble();
                        randomParameters[1] = r.NextDouble();
                        randomParameters[2] = r.NextDouble();

                        s = new Rectangle(randomParameters[0], randomParameters[1]);
                    } while (!s.isLegal());


                    break;
                case "square":
                    if (randomParameters.Length < 1) { throw new ArgumentException("参数数量不对，无法构造正方形"); }

                    do
                    {
                        randomParameters[0] = r.NextDouble();
                        randomParameters[1] = r.NextDouble();
                        randomParameters[2] = r.NextDouble();

                        s = new Square(randomParameters[0]);
                    } while (!s.isLegal());

                    break;
                case "triangle":
                    if (randomParameters.Length < 3) { throw new ArgumentException("参数数量不对，无法构造三角形"); }

                    do
                    {


                        randomParameters[0] = r.NextDouble();
                        randomParameters[1] = r.NextDouble();
                        randomParameters[2] = r.NextDouble();


                        s = new Triangle(randomParameters[0], randomParameters[1], randomParameters[2]);
                    } while (!s.isLegal());

                    break;
                default:
                    throw new ArgumentException("输入形状不是长方形，正方形，三角形");

            }

            return s;
        }
    }
}
