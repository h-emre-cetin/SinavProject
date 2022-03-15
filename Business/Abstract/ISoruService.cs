using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public  interface ISoruService
    {
        IDataResult<List<Soru>> GetAll();
        IResult Add(Soru soru);

        IResult Update(Soru soru);

        IResult Delete(int id);
    }
}
