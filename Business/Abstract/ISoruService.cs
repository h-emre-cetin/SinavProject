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
        List<Soru> GetAll();
        void Add(Soru soru);

        void Update(Soru soru);

        void Delete(Soru soru);
    }
}
