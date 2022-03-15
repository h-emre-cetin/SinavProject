using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public  interface ISikService
    {
        IDataResult<List<Sik>> GetAll();
        IResult Add(Sik sik);

        IResult Update(Sik sik);

        IResult Delete(int id);
    }
}
