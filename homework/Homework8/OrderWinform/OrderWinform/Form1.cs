using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderWinform
{
    public partial class Form1 : Form
    {
        public OrderApp.OrderService orderService = new OrderApp.OrderService();

        public int OrderId { get; set; }

        public List<OrderApp.Goods> GoodList { get; set; }

        public DateTime currentTime = System.DateTime.Now;

        public List<OrderApp.Customer> customers = new List<OrderApp.Customer>();
        public Form1()
        {
            InitializeComponent();

            // 初始化订单列表
            OrderId = 2;
            OrderApp.Goods apple = new OrderApp.Goods(1, "苹果", 2);
            OrderApp.Goods banana = new OrderApp.Goods(2, "香蕉", 1);
            GoodList = new List<OrderApp.Goods>();
            GoodList.Add(apple);
            GoodList.Add(banana);
            OrderApp.OrderDetail orderDetail = new OrderApp.OrderDetail(apple, 1);
            OrderApp.OrderDetail orderDetail2 = new OrderApp.OrderDetail(banana, 1);
            OrderApp.Customer customer = new OrderApp.Customer(1, "abd");
            OrderApp.Order order = new OrderApp.Order(1, customer, System.DateTime.Now);
            order.AddDetails(orderDetail);
            order.AddDetails(orderDetail2);

            OrderApp.Customer customer2 = new OrderApp.Customer(2, "cba");
            OrderApp.Order order1 = new OrderApp.Order(2, customer2, System.DateTime.Now);
            order1.AddDetails(orderDetail);
            

            orderService.AddOrder(order);
            orderService.AddOrder(order1);

            customers.Add(customer);
            customers.Add(customer2);

           
            
            
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            OrderApp.Order pre = (OrderApp.Order)orderBindingSource.Current;
            if(pre == null)
            {
                MessageBox.Show("请选择一个订单修改");
                return;
            }
            Form2 form = new Form2(pre,orderService);

            if (form.ShowDialog() == DialogResult.OK)
            {
                orderBindingSource.DataSource = orderService.orders;
            }
            

        }

        private void buttonQuery_Click(object sender, EventArgs e)
        {
            String Keyword = txtQueryInput.Text;
            String Cate = (string)combQueryCate.SelectedItem;
            if (Keyword == null || Keyword == "")
            {
                orderBindingSource.DataSource = orderService.orders;
                return;
            }
            
                List<OrderApp.Order> list = new List<OrderApp.Order>(); 
                if(Cate == "订单号")
                {
                    OrderApp.Order order = orderService.GetById(Int32.Parse(Keyword));
                    list.Add(order);
                    
                }
                if(Cate == "客户")
                {
                    list = orderService.QueryByCustomerName(Keyword);
                    
                }
                if(Cate == "商品")
                {
                    list = orderService.QueryByGoodsName(Keyword);
                }
                if(Cate == "总价")
                {
                    list = orderService.QueryByTotalAmount(float.Parse(Keyword));
                }
                orderBindingSource.DataSource = list;
            

            
        }

        

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            OrderApp.Order o = (OrderApp.Order)orderBindingSource.Current;
            if(o == null)
            {
                MessageBox.Show("请选择一个订单删除");
                return;
            }
            if (MessageBox.Show("确定删除该订单吗?", "警告", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                orderService.RemoveOrder(o.Id);
                orderBindingSource.ResetBindings(false);
            }
        }

        private void button_export_Click(object sender, EventArgs e)
        {
            
            if(saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                orderService.Export(saveFileDialog1.FileName);
            }
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                orderService.Import(openFileDialog1.FileName);
            }
        }

       

       

        

        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            Form2 newForm = new Form2(orderService);
            if (newForm.ShowDialog() == DialogResult.OK)
            {
                if (newForm.newOrder != null) orderService.orders.Add(newForm.newOrder);
                orderBindingSource.DataSource = orderService.orders;
            }

        }
    }
}
