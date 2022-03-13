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
    public class SoruManager : ISoruService
    {

        private ISoruDal _soruDal;

        public SoruManager(ISoruDal soruDal)
        {
            _soruDal = soruDal;
        }

        public void Add(Soru soru)
        {
            _soruDal.Add(soru);
        }

        public void Delete(Soru soru)
        {
            _soruDal.Delete(soru);
        }

        public List<Soru> GetAll()
        {
            return _soruDal.GetList();
        }

        public void Update(Soru soru)
        {
            _soruDal.Update(soru);
        }
    }
}
