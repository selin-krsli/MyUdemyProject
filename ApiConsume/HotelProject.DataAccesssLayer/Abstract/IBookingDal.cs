﻿using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccesssLayer.Abstract
{
    public interface IBookingDal: IGenericDal<Booking>
    {
        void BookingStatusApproved(int id);
    }
}
