using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Controller
{
    class HouseKeepingController
    {
        DatabaseHotelEntities db = new DatabaseHotelEntities();

        public object ViewAllReservation()
        {
            var data = (from reservation in db.Reservations
                        where reservation.DeleteReservation == 0
                        select new
                        {
                            ReservationId = reservation.ReservationId,
                            Room = reservation.RoomId,
                        }).ToList();
            return data;
        }


        public Supply CreateSupply(String supplyName, int supplyStock, int supplyMinimum)
        {
            Supply supply = new Supply()
            {
                SupplyName = supplyName,
                SupplyStock = supplyStock,
                SetSupplyMinimumStock = supplyMinimum,
            };
            db.Supplies.Add(supply);
            db.SaveChanges();

            return supply;
        }

        public object ViewAllSupply()
        {
            var data = (from supply in db.Supplies
                        where supply.DeleteSupply == 0
                        select new
                        {
                            SupplyId = supply.SupplyId,
                            SupplyName = supply.SupplyName,
                            SupplyStock = supply.SupplyStock,
                            SupplyMinimum = supply.SetSupplyMinimumStock,


                        }).ToList();
            return data;
        }

        public Supply UpdateSupply(int supplyId, String supplyName, int supplyStock, int supplyMinimum)
        {
            Supply supply = db.Supplies.Find(supplyId);
            supply.SupplyName = supplyName;
            supply.SupplyStock = supplyStock;
            supply.SetSupplyMinimumStock = supplyMinimum;
            db.SaveChanges();

            return supply;
        }

        public Supply DeleteSupply(int SupplyId)
        {
            Supply supply = db.Supplies.Find(SupplyId);
            supply.DeleteSupply = 1;

            db.SaveChanges();

            return supply;
        }

        public Deduction UpdateDeduction(int ReserveId, int used, int supplyId , int price)
        {
            Supply supply = db.Supplies.Find(supplyId);
            Reservation rs = db.Reservations.Find(ReserveId);

            supply.SupplyStock -= used;
            int total = used * price;
            rs.DepositMoney -= total;

            Deduction deduction = new Deduction()
            {
                DeductionFee = total,
                DeductionReason = "used minibar " + supply.SupplyName,
                ReservationId = ReserveId,
            };
            db.Deductions.Add(deduction);

            db.SaveChanges();

            return deduction;

        }
       
    }
}
