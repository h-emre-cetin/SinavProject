using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class SoruKategoriManager : ISoruKategoriService
    {
        private ISoruKategoriDal _soruKategoriDal;

        public SoruKategoriManager(ISoruKategoriDal soruKategoriDal)
        {
            _soruKategoriDal = soruKategoriDal;
        }

        public IResult Add(SoruKategori soruKategori)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(SoruKategori soruKategori)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<SoruKategori>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IResult Update(SoruKategori soruKategori)
        {
            throw new NotImplementedException();
        }
    }
}
