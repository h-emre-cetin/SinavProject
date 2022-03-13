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
        List<Sinav> GetAll();
        void Add(Sinav sinav);

        void Update(Sinav sinav);

        void Delete(Sinav sinav);
    }
}
