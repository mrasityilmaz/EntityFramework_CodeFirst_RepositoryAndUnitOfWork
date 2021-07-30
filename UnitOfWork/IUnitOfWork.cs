using EF_EXAMPLE.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_EXAMPLE.UnitOfWork
{
    public interface IUnitOfWork:IDisposable
    {
   
        int SaveChanges();
    }
}
