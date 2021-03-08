using MusicStore.DataAccess.Abstract;
using MusicStore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore.DataAccess.Concrete.EntityFramework
{
    public class EfOrderDal : EfEntityRepositoryBase<Order, MusicStoreContext>, IOrderDal
    {
    }
}
