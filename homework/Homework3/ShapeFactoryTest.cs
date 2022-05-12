using System;
namespace Shape;

    public class ShapeFactoryTest
    {
        static void Main(String[] args)
        {

            Shape[] shapes = new Shape[10];

            double sum = 0;
            for(int i = 0; i < 10; i ++)

            { 
                
                shapes[i] = ShapeFactory.ShapeRandomGenerator();
                sum += shapes[i].getArea();
            }

            Console.WriteLine(Math.Round(sum, 2));
            

        }
    }

    

