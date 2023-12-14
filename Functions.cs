using McDonalds.Controllers;
using McDonalds.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

namespace McDonalds
{
    public class Functions
    {
        Form1 form1;
        ProductCrud pc = new ProductCrud();
        OrderProductCrud opc = new OrderProductCrud();
        OrderCrud oc = new OrderCrud();

        List<SendOrder> _sendOrders = new List<SendOrder>();



        public void TcpJsonGonder(List<SendOrder> _orders, string IpAdress = "192.168.88.1", int serverPort = 1453)
        {
            IPAddress serverAddr = IPAddress.Parse(IpAdress);


            // İstemci
            Task.Run(() =>
            {

                using (TcpClient client = new TcpClient(serverAddr.ToString(), serverPort))
                using (NetworkStream stream = client.GetStream())
                {
                    // List<Order> nesnesini JSON'a dönüştür
                    string json = JsonSerializer.Serialize(_orders);

                    // JSON string'ini byte dizisine dönüştür
                    byte[] jsonBytes = Encoding.UTF8.GetBytes(json);

                    // Byte dizisinin uzunluğunu gönder (opsiyonel, ancak alıcı tarafın ne kadar veri okuyacağını bilmek için yararlı olabilir)
                    byte[] lengthPrefix = BitConverter.GetBytes(jsonBytes.Length);
                    stream.Write(lengthPrefix, 0, lengthPrefix.Length);

                    // JSON verisini gönder
                    stream.Write(jsonBytes, 0, jsonBytes.Length);
                }

            });

        }


        public void BuyProduct(List<Product> basket)
        {
            _sendOrders.Clear();
            if (basket.Count() < 1)
            {
                MessageBox.Show("Basket is empty");
                return;
            }


            Order order = new Order();
            order.Status = "hazırlanıyor";
            order.CreationTime = DateTime.Now;
            order.PreparationTime = 0;
            oc.Add(order);

            
            foreach (var item in basket)
            {
                var currentItem = opc.GetAll().Where(x => x.ProductId == item.Id && x.OrderId == order.Id).FirstOrDefault();
                if (currentItem != null)
                {
                    int preperationTime = pc.GetById(item.Id).PreparationTime;
                    opc.Update(currentItem, currentItem.Id);
                    Order updatedOrder = new Order();
                    updatedOrder.PreparationTime = oc.GetById(order.Id).PreparationTime + pc.GetById(item.Id).PreparationTime;
                    updatedOrder.Status = "hazırlanıyor";
                    oc.Update(updatedOrder, order.Id);



                }
                else
                {
                    OrderProduct op = new OrderProduct();
                    Order updatedOrder = new Order();

                    op.ProductId = item.Id;
                    op.OrderId = order.Id;
                    op.Quantity = 1;
                    opc.Add(op);

                    updatedOrder.PreparationTime = oc.GetById(order.Id).PreparationTime + pc.GetById(item.Id).PreparationTime;
                    updatedOrder.Status = "hazırlanıyor";
                    oc.Update(updatedOrder, order.Id);

                    

                  


                }

                

            }
            List<OrderProduct> orderProducts = opc.GetAll().Where(x => x.OrderId == order.Id).ToList();

            foreach (OrderProduct orderProduct in orderProducts)
            {
                orderProduct.Name = pc.GetById(orderProduct.ProductId).Name;
            }
            _sendOrders.Add(new SendOrder()
            {
                Id = order.Id,
                OrderStatus = "hazırlanıyor",
                Products = orderProducts
            }
            );



            TcpJsonGonder(_sendOrders);

            MessageBox.Show(_sendOrders.Count().ToString());





        }


    }



}
