using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
    [Serializable]
    public class Order : IComparable
    {
        public int OrderId { get; set; }
        public DateTime Time { get; set; }
        public Customer Customer { get; set; }
        private List<OrderDetail> orderDetails = new List<OrderDetail>();

        public Order() { }
        public Order(int orderId, DateTime time, Customer customer, List<OrderDetail> orderDetails)
        {
            OrderId = orderId;
            Time = time;
            Customer = customer;
            this.orderDetails = orderDetails;
        }

        public List<OrderDetail> OrderDetails { get { return orderDetails; } set { orderDetails = value; } }

        public void addOrderDetail (OrderDetail orderDetail)
        {
            if (orderDetails.Contains(orderDetail)) return;
            orderDetails.Add(orderDetail);
        }

        public override bool Equals(object? obj)
        {
            return obj is Order order &&
                order != null && OrderId == order.OrderId;
        }

        public override int GetHashCode()
        {
            return 2108834+OrderId.GetHashCode();
        }

        public Double TotalPrice {
            get
            {
                double sum = 0;
                orderDetails.ForEach(o => sum += o.Amount);
                return sum;
            }
           
        }

        public override string? ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append( String.Format("OrderId:{0}\nTime:{1}\nCustomer:{2}\n", OrderId, Time, Customer));
            sb.Append("OrderDetails:\n");
            orderDetails.ForEach(o => sb.Append(o.ToString()+"\n"));
            sb.Append("Price:"+TotalPrice.ToString()+"\n");
            sb.Append("\n");
            
            return sb.ToString();
        }


        public int CompareTo(object obj2)
        {
            Order rec2 = obj2 as Order;
            if (rec2 == null)
                throw new System.ArgumentException();
            return this.OrderId.CompareTo(rec2.OrderId);
        }


    }
}
