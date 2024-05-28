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
    public class EfRoomDal:GenericRepository<Room>, IRoomDal
    {
        public EfRoomDal(Context context):base(context) 
        {

        }
    }
}
//Burada EfRoomDal sınıfının constructor'ı 'Context' türünden bir parametre alır ve bu parametreyi 'base'
//anahtar sözcüğü ile 'GenericRepository<Room>' sınıfının constructorına iletir. Böylece 'EfRoomDal' sınıfı 'GenericRepository<Room>' sınıfının işlevselliğini kullanabilir.