using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public  interface ISoruKategoriService
    {

        IDataResult<List<SoruKategori>> GetAll();
        IResult Add(SoruKategori soruKategori);

        IResult Update(SoruKategori soruKategori);

        IResult Delete(SoruKategori soruKategori);

    }
}
