using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Controller
{
    class DiningRoomController
    {
        DatabaseHotelEntities db = new DatabaseHotelEntities();

        public String checkTicket(int id)
        {
            Reservation checkticket = db.Reservations.Find(id);
            if(checkticket.TicketAvaibility == 0)
            {
                return "ticket is available";
            }
            else
            {
                return "ticket is not available";
            }
            
        }

        public Reservation useTicket(int id)
        {
            Reservation checkticket = db.Reservations.Find(id);
            checkticket.TicketAvaibility = 1;

            db.SaveChanges();

            return checkticket;
        }

        public DiningRoomOrder AddOrder(String orderFood, int orderQuantity)
        {
            DiningRoomOrder order = new DiningRoomOrder()
            {
                DOrderFood = orderFood,
                DOrderQuantity = orderQuantity,
            };
            db.DiningRoomOrders.Add(order);
            db.SaveChanges();

            return order;
        }

        public DiningRoomOrder DeleteOrder(int OrderId)
        {
            DiningRoomOrder order = db.DiningRoomOrders.Find(OrderId);
            order.DOrderDelete = 1;
            db.SaveChanges();

            return order;
        }

        public object ViewAllOrder()
        {
            var data = (from DiningRoomOrder in db.DiningRoomOrders
                        where DiningRoomOrder.DOrderDelete == 0
                        select new
                        {
                            OrderId = DiningRoomOrder.DOrderId,
                            OrderFood = DiningRoomOrder.DOrderFood,
                            OrderQuantity = DiningRoomOrder.DOrderQuantity,

                        }).ToList();
            return data;
        }
    }
}
