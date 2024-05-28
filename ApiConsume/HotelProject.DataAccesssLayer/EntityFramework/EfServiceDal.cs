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
    public class EfServiceDal:GenericRepository<Service>, IServiceDal
    {
        public EfServiceDal(Context context):base(context) 
        {
            
        }
    }
}
