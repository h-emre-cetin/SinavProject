using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public  interface ISinavService
    {
        IDataResult<List<Sinav>>  GetAll();
        IResult Add(Sinav sinav);

        IResult Update(Sinav sinav);

        IResult Delete(Sinav sinav);
    }
}
