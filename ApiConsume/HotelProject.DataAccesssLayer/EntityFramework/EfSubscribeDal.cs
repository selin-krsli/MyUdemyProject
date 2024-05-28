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
    public class EfSubscribeDal:GenericRepository<Subscribe>, ISubscribeDal
    {
        public EfSubscribeDal(Context context):base(context) 
        {
            
        }
    }
}
