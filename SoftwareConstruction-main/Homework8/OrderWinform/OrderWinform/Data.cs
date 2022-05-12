using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderApp
{
    public class Data
    {
        OrderApp.Goods apple = new OrderApp.Goods(1, "苹果", 2);
        OrderApp.Goods banana = new OrderApp.Goods(2, "香蕉", 1);
        List<Goods> GoodList = new List<OrderApp.Goods>();

        OrderApp.Customer customer = new OrderApp.Customer(1, "abd");
        OrderApp.Customer customer2 = new OrderApp.Customer(2, "cba");
        List<OrderApp.Customer> customers = new List<Customer>();

        OrderApp.Order order;
        OrderApp.Order order1;
        List<OrderApp.Order> orders;

        public Data()
        {
            GoodList.Add(apple);
            GoodList.Add(banana);

            customers.Add(customer);
            customers.Add(customer2);

            order =  new OrderApp.Order(1, customer, System.DateTime.Now);
            order1 =  new OrderApp.Order(2, customer2, System.DateTime.Now);
            orders.Add(order);
            orders.Add(order1);


            OrderApp.OrderDetail orderDetail = new OrderApp.OrderDetail(apple, 1);
            OrderApp.OrderDetail orderDetail2 = new OrderApp.OrderDetail(banana, 1);
            order.AddDetails(orderDetail);
            order.AddDetails(orderDetail2);

            order1.AddDetails(orderDetail);
        }

    }
}
