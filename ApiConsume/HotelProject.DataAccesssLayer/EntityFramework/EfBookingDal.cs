using HotelProject.DataAccesssLayer.Abstract;
using HotelProject.DataAccesssLayer.Concrete;
using HotelProject.DataAccesssLayer.Repository;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccesssLayer.EntityFramework
{
    public class EfBookingDal:GenericRepository<Booking>, IBookingDal
    {
        public EfBookingDal(Context context):base(context)
        {
            
        }
        public void BookingStatusApproved(int id)
        {
            var context = new Context();
            var value = context.Bookings.Find(id);
            value.Status = "Onaylandı";
            context.SaveChanges();
        }
    }
}
