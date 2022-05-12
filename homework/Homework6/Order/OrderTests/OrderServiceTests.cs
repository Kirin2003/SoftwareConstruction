using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;



namespace OrderManagement.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        Good apple;
        Good pear;
        Good banana;

        Customer hxq;
        Customer lgy;


        OrderDetail od1;
        OrderDetail od2;
        OrderDetail od3;

        List<OrderDetail> l1;
        List<OrderDetail> l2;
        Order o1;
        Order o2;
        Order o3;

        OrderService os;
        OrderService os2;
        OrderService os3;

        [TestInitialize]
        public void initialize()
        {
            apple = new Good("苹果", 1.0);
            pear = new Good("梨子", 1.2);
            banana = new Good("香蕉", 1.0);

            hxq = new Customer(1, "hxq");
            lgy = new Customer(2, "lgy");


            od1 = new OrderDetail(1, apple, 3);
            od2 = new OrderDetail(2, pear, 3);
            od3 = new OrderDetail(3, banana, 3);

            l1 = new List<OrderDetail> { od1, od2 };
            l2 = new List<OrderDetail> { od1, od3 };
            o1 = new Order(1, DateTime.Now, hxq, l1);
            o2 = new Order(2, DateTime.UtcNow, hxq, l2);
            o3 = new Order(3, DateTime.Now, lgy, l1);

            os = new OrderService();
            os2 = new OrderService() { Orders = { o1, o2 } };
            os3 = new OrderService()
            {
                Orders = { o1, o2, o3 }
            };
        }

            [TestMethod()]
        public void addOrderTest()
        {
            os.addOrder(o1);

            List<Order> result = new List<Order>();
            result.Add(o1);

            CollectionAssert.Equals(os.Orders, result);
        }

        [TestMethod()]
        public void deleteOrderTest()
        {
            
            os2.deleteOrder(1);

            List<Order> result = new List<Order>();
            result.Add(o2);

            CollectionAssert.Equals(os2.Orders, result);
        }

        [TestMethod()]
        [ExpectedException(typeof(Exception))]
        public void deleteOrderTest2()
        {
            
            os.deleteOrder(1);
           

        }

        [TestMethod()]
        public void modifyOrderTest()
        {
            
            os2.modifyOrder(o3, 1);

            List<Order> result = new List<Order> { o3,o2};
            CollectionAssert.Equals(os2.Orders, result);

        }

        [TestMethod()]
        [ExpectedException(typeof(Exception))]
        public void modifyOrderTest2()
        {
            
            os2.modifyOrder(o2,3);

        }

        [TestMethod()]
        public void selectByIdTest()
        {
            
            Assert.AreEqual( os2.selectById(1),o1);
        }

        [TestMethod()]
        public void selectByClientTest()
        {
            
            List<Order> result = new List<Order>();
            result = new List<Order>() { o1, o2 };
            CollectionAssert.Equals(os3.selectByClient("hxq"), result);
        }

        [TestMethod()]
        public void selectByClientTest2()
        {
          
            List<Order> result = new List<Order>();
            result.Add(o3);
            CollectionAssert.Equals(os3.selectByClient("lgy"), result);
        }

        [TestMethod()]
        public void selectByClientTest3()
        {
           
            CollectionAssert.Equals(os3.selectByClient("gyh"), null);
        }

        [TestMethod()]
        public void SortTest()
        {
            os2.Orders.Sort((o1, o2) => { return (int)(o1.TotalPrice - o2.TotalPrice); });
            CollectionAssert.Equals(os3.Orders, new List<Order>() { o1, o2 });
        }

        [TestMethod()]
        public void selectByStuffTest()
        {
            List<Order> test = os3.selectByStuff("苹果");
            List<Order> result;
            result = new List<Order>() { o1,o2} ;
            
            CollectionAssert.AreEqual(test, result);
        }

        [TestMethod()]
        public void ExportTest()
        {
            String path = "test.xml";
            os2.Export(path);
            // 判断是否存在
            Assert.IsTrue(File.Exists(path));
            // 判断文件内容是否正确
            String result = File.ReadAllText(path);
            String expect = File.ReadAllText("../../expectedOrder.xml");
            Assert.AreEqual(expect, result);

            // clear up
            File.Delete(path);

        }

        [TestMethod()]
        public void ImportTest()
        {
            List<Order> expect = os.Orders;
            os.Import("../../expectedOrders.xml");
            List<Order> result = os.Orders;
            CollectionAssert.AreEqual(expect, result);

            
        }

        // test for importing unExisting xml
        [TestMethod()]
        [ExpectedException(typeof(FileNotFoundException))]
        public void ImportTest2()
        {
            OrderService os = new OrderService();
            os.Import("../../orders.xml");


        }

        // test for importing invalid xml
        [TestMethod()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ImportTest3()
        {
            OrderService os = new OrderService();
            os.Import("../../invalid.xml");

        }


        }
    }