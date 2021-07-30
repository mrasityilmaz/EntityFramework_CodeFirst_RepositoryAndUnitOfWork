using EF_EXAMPLE.Model.Context;
using EF_EXAMPLE.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_EXAMPLE.UnitOfWork
{
    public class UnitOfWorkEf:IUnitOfWork
    {

        private readonly MyContext Context;

        public UnitOfWorkEf(MyContext myContext)
        {
            Database.SetInitializer<MyContext>(null);

            if (myContext == null)
                throw new ArgumentNullException("Context can not be null.");

            Context = myContext;

            
        }

        #region IUnitOfWork Members
        public IRepository<T> GetRepository<T>() where T : class
        {
            return new RepositoryEf<T>(Context);
        }

        public int SaveChanges()
        {
            try
            {

                return Context.SaveChanges();
            }
            catch
            {
                
                throw;
            }
        }
        #endregion

        #region IDisposable Members
        // Burada IUnitOfWork arayüzüne implemente ettiğimiz IDisposable arayüzünün Dispose Patternini implemente ediyoruz.
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    Context.Dispose();
                }
            }

            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion

    }
}
