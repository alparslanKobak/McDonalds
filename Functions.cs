using McDonalds.Controllers;
using McDonalds.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace McDonalds
{
    public class Functions
    {
        Form1 form1;
        ProductCrud pc = new ProductCrud();
        OrderProductCrud opc = new OrderProductCrud();
        OrderCrud oc = new OrderCrud();






        public void BuyProduct(List<Product> basket)
        {

            if (basket.Count()<1)
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



           

        }

        
    }



}
