using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDBVersion
{
    public class Program
    {

        public void init()
        {
            
        }
        public static void Main(String[] args)
        {

            Goods apple = new Goods(1, "苹果", 2);
            Goods banana = new Goods(2, "香蕉", 1);
            List<Goods> GoodList = new List<Goods>();

            Customer customer = new Customer(1, "abd");
            Customer customer2 = new Customer(2, "cba");
            List<Customer> customers = new List<Customer>();

            Order order;
            Order order1;
            List<Order> orders = new List<Order>();
            GoodList.Add(apple);
            GoodList.Add(banana);

            customers.Add(customer);
            customers.Add(customer2);

            order = new Order(1, customer, System.DateTime.Now);
            order1 = new Order(2, customer2, System.DateTime.Now);
            orders.Add(order);
            orders.Add(order1);


            OrderDetail orderDetail = new OrderDetail(apple, 1);
            OrderDetail orderDetail2 = new OrderDetail(banana, 1);
            order.AddDetails(orderDetail);
            order.AddDetails(orderDetail2);

            order1.AddDetails(orderDetail);

            Program p = new Program();
            p.init();
            p.addOrder(order);
            p.addOrder(order1);
            p.deleteOrder(order);
            p.updateOrder(order1);

            p.QueryByCustomerName("hxq");
        }
        public void addOrder(Order o)
        {

            using (var context = new OrderContext())
            {
                if(context.Orders.Contains(o))
                {
                    throw new ApplicationException($"the order Id already exists!");
                }

                context.Orders.Add(o);
                context.SaveChanges();
            }
        }

        public void deleteOrder(Order o)
        {

            using (var context = new OrderContext())
            {
                if(!context.Orders.Contains(o))
                {
                    throw new ApplicationException($"the order doesn't exist!");
                }
                context.Orders.Remove(o);
                context.SaveChanges();
            }
        }
        public void updateOrder(Order o)
        {
            using (var context = new OrderContext())
            {

               

                var ord = context.Orders.FirstOrDefault(p => p.Id == o.Id);
                if (ord != null)
                {
                    ord = o;
                    context.SaveChanges();
                }
            }
        }

        public IEnumerable<Order> Query(Predicate<Order> condition)
        {
            using (var context = new OrderContext())
            {
                return context.Orders.Where(o => condition(o));
            }
        }

        public List<Order> QueryByGoodsName(string goodsName)
        {
            using(var context = new OrderContext())
            {
                var query = context.Orders.Where(
              o => o.Details.Any(d => d.Goods.Name == goodsName));
                return query.ToList();
            }
        }

        public List<Order> QueryByTotalAmount(float totalAmount)
        {
            using(var context = new OrderContext())
            {
                var query = context.Orders.Where(o => o.TotalAmount >= totalAmount);
                return query.ToList();
            }
        }

        public List<Order> QueryByCustomerName(string customerName)
        {using (var context = new OrderContext())
            {
                var query = context.Orders.Where(o => o.Customer.Name == customerName);
                return query.ToList();
            } 
        }


    }
}
