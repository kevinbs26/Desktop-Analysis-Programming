using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Controller
{
    class RoomServiceController
    {
        DatabaseHotelEntities db = new DatabaseHotelEntities();

        public Order AddOrder(String Type, String orderFood, int orderQuantity)
        {
            Order order = new Order()
            {
                OrderType = Type,
                OrderFood = orderFood,
                OrderQuantity = orderQuantity,
            };
            db.Orders.Add(order);
            db.SaveChanges();

            return order;
        }

        public Order DeleteOrder(int OrderId)
        {
            Order order = db.Orders.Find(OrderId);
            order.OrderDelete = 1;
            db.SaveChanges();

            return order;
        }

        public object ViewAllOrder()
        {
            var data = (from Order in db.Orders
                        where Order.OrderDelete == 0
                        select new
                        {
                            OrderId = Order.OrderId,
                            OrderType = Order.OrderType,
                            OrderFood = Order.OrderFood,
                            OrderQuantity = Order.OrderQuantity,

                        }).ToList();
            return data;
        }
    }
}
