using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
    public class Program
    {
         static void Main(String[] args)
        {
            Good apple = new Good("苹果", 1.0);
            Good pear = new Good("梨子", 1.2);
            Good banana = new Good("香蕉", 1.0);

            Customer hxq = new Customer(1, "hxq");


            OrderDetail od1 = new OrderDetail(1, apple, 3);
            OrderDetail od2 = new OrderDetail(2, pear, 3); 
            OrderDetail od3 = new OrderDetail(3, banana, 3) ;

            List<OrderDetail> l1 = new List<OrderDetail> { od1, od2 };
            List<OrderDetail> l2 = new List<OrderDetail> { od1, od3};
            Order o1 = new Order(1, DateTime.Now,hxq ,l1) ;
            Order o2 = new Order(2, DateTime.UtcNow, hxq, l2);

            OrderService os = new OrderService();

            os.addOrder(o1);
            Console.WriteLine(os);
            OrderService osResult = new OrderService();
            osResult.Orders.Add(o2);
            Console.WriteLine(osResult);
            //Assert.IsTrue(os.Equals(osResult));

            os.addOrder(o1);
            os.addOrder(o2);
            

            Order o = os.selectById(2);
            Console.WriteLine("select by id = 2:\n"+o);
            

            List<Order> lo2 = os.selectByClient(hxq.Name);
            Console.WriteLine("select  by customer name = hxq:\n");
            lo2.ForEach(o2 => Console.WriteLine(o2));

            Console.WriteLine("sort by IComparable, test!");
            lo2.Sort();
            Console.WriteLine(os);



            Console.WriteLine("sort by total price:\n");
            lo2.Sort(new MoneyComparator());
            lo2.ForEach(o => Console.WriteLine(o));

            Console.WriteLine("sort by total price (lambda):\n");
            lo2.Sort((o1, o2) => { return (int)(o1.TotalPrice - o2.TotalPrice); });
            lo2.ForEach(o => Console.WriteLine(o));

            Console.WriteLine("test xml serializer:\n");
            os.Export("test.xml");
            
            

            Console.ReadLine();

        }
    }
}
