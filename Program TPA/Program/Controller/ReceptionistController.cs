using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Controller
{
    class ReceptionistController
    {
        DatabaseHotelEntities db = new DatabaseHotelEntities();

        public Reservation CreateReservation(DateTime CheckIn, DateTime CheckOut, int RoomId, int DepositMoney, int ReservationFee)
        {
            Reservation reservation = new Reservation()
            {
                CheckIn = CheckIn,
                CheckOut = CheckOut,
                RoomId = RoomId,
                DepositMoney = DepositMoney,
                ReservationFee = ReservationFee,
            };
            db.Reservations.Add(reservation);
            db.SaveChanges();

            return reservation;
        }

        public object ViewAllReservation()
        {
            var data = (from reservation in db.Reservations
                        where reservation.DeleteReservation == 0
                        select new
                        {
                            ReservationId = reservation.ReservationId,
                            CheckIn = reservation.CheckIn,
                            CheckOut = reservation.CheckOut,
                            DepositMoney = reservation.DepositMoney,
                            ReservationFee = reservation.ReservationFee,
                            room = reservation.RoomId,
                            ticket = reservation.TicketAvaibility,
            
                        }).ToList();
            return data;
        }

        public Reservation UpdateReservation(int ReservationId, DateTime CheckIn, DateTime CheckOut, int RoomId, int DepositMoney, int ReservationFee)
        {
            Reservation updateReservation = db.Reservations.Find(ReservationId);
            updateReservation.CheckIn = CheckIn;
            updateReservation.CheckOut = CheckOut;
            updateReservation.RoomId = RoomId;
            updateReservation.DepositMoney = DepositMoney;
            updateReservation.ReservationFee = ReservationFee;
            db.SaveChanges();

            return updateReservation;
        }

        public Reservation DeleteReservation(int ReservationId)
        {
            Reservation delReservation = db.Reservations.Find(ReservationId);
            delReservation.DeleteReservation = 1;

            db.SaveChanges();

            return delReservation;
        }

        public Guest AddGuest(String guestname, String guestDataId)
        {
            Guest guest = new Guest()
            {
                GuestName = guestname,
                GuestDataId = guestDataId,
            };
            db.Guests.Add(guest);
            db.SaveChanges();

            return guest;
        }


        public Guest UpdateGuest(int GuestId, String guestname, String guestdataId)
        {
            Guest updateguest = db.Guests.Find(GuestId);
            updateguest.GuestName = guestname;
            updateguest.GuestDataId = guestdataId;

            db.SaveChanges();

            return updateguest;
        }

        public object ViewAllGuest()
        {
            var data = (from guest in db.Guests
                        select new
                        {
                            GuestId = guest.GuestId,
                            GuestName = guest.GuestName,
                            GuestDataId = guest.GuestDataId,

                        }).ToList();
            return data;
        }

        public object ViewAllDeduction()
        {
            var data = (from deduct in db.Deductions
                        select new
                        {
                            DeductionId = deduct.DeductionId,
                            DeductionFee = deduct.DeductionFee,
                            DeductionReason = deduct.DeductionReason,
                            ReservationId = deduct.ReservationId,

                        }).ToList();
            return data;
        }

        public Deduction TicketDeduction(int ReserveId, int quantity,  int price)
        {
            Reservation rs = db.Reservations.Find(ReserveId);
            int total = quantity * price;
            rs.DepositMoney -= total;
            rs.TicketAvaibility = 0;

            Deduction deduction = new Deduction()
            {
                DeductionFee = total,
                DeductionReason = "renew ticket (" + quantity  + ")",
                ReservationId = ReserveId,
            };
            db.Deductions.Add(deduction);

            db.SaveChanges();

            return deduction;

        }
    }
}
