using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OrderManagement
{
    public class OrderService 
    {
       
        private List<Order> orders = new List<Order>();

        public List<Order> Orders { get { return orders; } }

        public void addOrder(Order o)
        {

            if (o != null && orders.Contains(o)) return;
            orders.Add(o);
        }
        public void deleteOrder(int orderId)
        {
            var order = selectById(orderId);
            if(order == null)
            {
                throw new Exception("订单不存在");
            } 
                orders.Remove(order);
            
        }

       
        public void modifyOrder(Order o, int orderId)
        {
            var order = selectById(orderId);
            if(order == null)
            {
                throw new Exception("订单不存在");

            }
                order = o;
            
        }

        public Order selectById(int orderId)
        {
            var query = orders
                .Where(o => o.OrderId == orderId)
                .OrderBy(o => o.TotalPrice).FirstOrDefault() ;
            return query;
        }

        public List<Order> selectByClient(string name)
        {
            var query = orders
                .Where(o => o.Customer.Name == name)
                .OrderBy(o => o.TotalPrice);
            return query.ToList();

           
        }

        public void Sort(Comparison<Order> comparison)
        {
            orders.Sort(comparison);
        }

        

       

        public List<Order> selectByStuff(String name) 
        {
            var query = orders.Where(o =>
            
                o.OrderDetails.Exists(d => d.Good.Name == name))
                .OrderBy(o => o.TotalPrice);
            return query.ToList();
            
        }

        public void Export(String path)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Order[]));
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                xmlSerializer.Serialize(fs, orders);
            }
        }

        public void Import(String path)
        {
            if (!File.Exists(path)) throw new ArgumentException("File Not Exist!");
            XmlSerializer serializer = new XmlSerializer(typeof(Order[]));
            using (FileStream fs = new FileStream(path,FileMode.Open, FileAccess.Read))
            {
                
                Order[] os = (Order[])serializer.Deserialize(fs);
                if (os == null) throw new ArgumentException("File Empty!");
                foreach (var order in os) orders.Add(order);

            }
        }

        

        
    }
}
