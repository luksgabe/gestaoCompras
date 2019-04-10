using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SafeWeb.Data.Data;
using SafeWeb_Domain.Interfaces.Repository;

namespace SafeWeb.Data.Repositories {
    public class Repository<T> : IRepository<T> where T : class {

        private DbSet<T> Set => Context.Set<T> ();

        private DbContext Context { get; }

        public Repository (SafeWebContext context) {
            Context = context;
            Context.ChangeTracker.LazyLoadingEnabled = false;
        }

        public void Add (T obj) {
            Set.Add (obj);
            Context.SaveChanges();
        }

        public T Select (object key) {
            return Set.Find (key);
        }

        public T GetById (int id) {
            return Set.Find (id);
        }

        public IEnumerable<T> GetAll () {
            return Set.ToList ();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await Set.ToListAsync();
        }

        public void Update (T item, object key) {
            Context.Entry (Select (key)).CurrentValues.SetValues (item);
        }

        public void Remove (T obj, object key) {
            Set.Remove (Select (key));
            Context.SaveChanges();
        }
    }
}