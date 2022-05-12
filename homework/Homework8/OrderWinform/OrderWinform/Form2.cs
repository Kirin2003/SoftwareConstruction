using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderWinform
{
    public partial class Form2 : Form
    {

        private OrderApp.OrderService orderService = new OrderApp.OrderService();
        public OrderApp.Order newOrder { get; set; } = new OrderApp.Order();



        public List<OrderApp.Customer> Customers { get; set; } = new List<OrderApp.Customer>();
        public List<OrderApp.Goods> GoodList { get; set; } = new List<OrderApp.Goods>();

        public Form2(OrderApp.OrderService os) {
            InitializeComponent();
            
            orderService = os;
            newOrder.Id = os.orders.Count+1;
            newOrder.CreateTime = DateTime.Now;
            Customers.Add(new OrderApp.Customer(1, "abd"));
            Customers.Add(new OrderApp.Customer(2, "cba"));
            GoodList.Add(new OrderApp.Goods(1, "苹果", 2));
            GoodList.Add(new OrderApp.Goods(2, "香蕉", 1));

            bindingSource1.DataSource = newOrder;
            bdGoods.DataSource = GoodList;
            bdCustomers.DataSource = Customers;
            


        }

        public Form2(OrderApp.Order o, OrderApp.OrderService os) :this(os){
            newOrder = o;
            bindingSource1.DataSource = newOrder;
            
        }
       

        [MethodImpl(MethodImplOptions.Synchronized)]
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            OrderApp.OrderDetail orderDetail = new OrderApp.OrderDetail((OrderApp.Goods)comboBoxGood.SelectedItem, (int)numericUpDownNum.Value);
            newOrder.Details.Add(orderDetail);
            orderDetailBindingSource.ResetBindings(false);

        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            OrderApp.OrderDetail detail = (OrderApp.OrderDetail)orderDetailBindingSource.Current;
            if(detail == null)
            {
                MessageBox.Show("请选择一个订单明细删除");
                return;
            }
            if (MessageBox.Show("确定删除该订单吗？", "警告", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                newOrder.Details.Remove(detail);
                orderDetailBindingSource.ResetBindings(false);
            }

        }



        private void buttonConf_Click(object sender, EventArgs e)
        {
            
            OrderApp.Order o = new OrderApp.Order(Int32.Parse(labelId.Text),(OrderApp.Customer) comboBoxCustomer.SelectedItem, DateTime.Now);
            newOrder.Details.ForEach(detail => o.AddDetails(detail));
            orderService.AddOrder(o);
            this.Close();
        }

        

       
    }
}
