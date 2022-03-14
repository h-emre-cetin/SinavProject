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
    public class SinavKategoriManager : ISinavKategoriService
    {

        private ISinavKategoriDal _sinavKategoriDal;

        public SinavKategoriManager(ISinavKategoriDal sinavKategoriDal)
        {
            _sinavKategoriDal = sinavKategoriDal;
        }

        public IResult Add(SinavKategori sinavKategori)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(SinavKategori sinavKategori)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<SinavKategori>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IResult Update(SinavKategori sinavKategori)
        {
            throw new NotImplementedException();
        }
    }
}
