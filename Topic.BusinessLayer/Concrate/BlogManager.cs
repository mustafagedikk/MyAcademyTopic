using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topic.BusinessLayer.Abstract;
using Topic.DataAccessLayer.Abstract;
using Topic.EntityLayer.Entities;

namespace Topic.BusinessLayer.Concrate
{
    public class BlogManager : GenericManager<Blog>,IBlogService
    {
        public BlogManager(IGenericDal<Blog> genericDal) : base(genericDal)
        {
        }
    }
}
