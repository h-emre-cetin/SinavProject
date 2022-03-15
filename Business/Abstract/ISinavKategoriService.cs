using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public  interface ISinavKategoriService
    {
        IDataResult<List<SinavKategori>> GetAll();
        IResult Add(SinavKategori sinavKategori);

        IResult Update(SinavKategori sinavKategori);

        IResult Delete(int id);
    }
}
