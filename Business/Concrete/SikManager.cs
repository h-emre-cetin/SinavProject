using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
   public class SikManager : ISikService
    {
        private ISikDal _sikDal;

        public SikManager(ISikDal sikDal)
        {
            _sikDal = sikDal;
        }

        public void Add(Sik sik)
        {
            _sikDal.Add(sik);   
        }

        public void Delete(Sik sik)
        {
            _sikDal.Delete(sik);
        }

        public List<Sik> GetAll()
        {
            return _sikDal.GetList();
        }


        public void Update(Sik sik)
        {
            _sikDal.Update(sik);
        }
    }
}
