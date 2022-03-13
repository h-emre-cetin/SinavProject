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
        List<Sik> GetAll();
        void Add(Sik sik);

        void Update(Sik sik);

        void Delete(Sik sik);
    }
}
