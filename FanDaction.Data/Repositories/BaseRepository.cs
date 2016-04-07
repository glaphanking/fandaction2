using FanDaction.Core.Models.Base;
using FanDaction.Data.Interfaces;
using PagedList;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FanDaction.Data.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseModel
    {
        private readonly bool _shareContext;
        public FandDbContext Context = null;
        protected IFandDataAccess FandDataAccess = null;
        protected DbSet<T> DbSet => Context.Set<T>();

        public BaseRepository()
        {
            Context = new FandDbContext();
        }

        public BaseRepository(FandDbContext context)
        {
            Context = context;
            _shareContext = true;
        }

        public BaseRepository(FandDbContext context, IFandDataAccess fandDataAccess)
        {
            Context = context;
            FandDataAccess = fandDataAccess;
            _shareContext = true;
        }

        public void Dispose()
        {
            if (_shareContext)
                Context?.Dispose();
        }

        public virtual IQueryable<T> AsQueryable()
        {
            return DbSet.AsQueryable();
        }

        public virtual IEnumerable<T> All()
        {
            return DbSet.ToList();
        }

        public virtual async Task<IEnumerable<T>> AllAsync()
        {
            return await DbSet.ToListAsync();
        }

        public virtual bool AsQueryable(Expression<Func<T, bool>> predicate)
        {
            return DbSet.All(predicate);
        }

        public virtual bool Any(Expression<Func<T, bool>> predicate)
        {
            return DbSet.Any(predicate);
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> predicate)
        {
            return await DbSet.AnyAsync(predicate);
        }

        public virtual IQueryable<T> Where(Expression<Func<T, bool>> predicate)
        {
            return DbSet.Where(predicate).AsQueryable();
        }

        public IPagedList<T> Where(Expression<Func<T, bool>> predicate, int pageNumber, int pageSize)
        {
            return DbSet.Where(predicate).ToPagedList(pageNumber, pageSize);
        }

        public virtual T Find(Expression<Func<T, bool>> predicate)
        {
            return DbSet.FirstOrDefault(predicate);
        }

        public async Task<T> FindAsync(Expression<Func<T, bool>> predicate)
        {
            return await DbSet.FirstOrDefaultAsync(predicate);
        }

        public T FindById(int id)
        {
            return DbSet.Find(id);
        }

        public async Task<T> FindByIdAsync(int id)
        {
            return await DbSet.FindAsync(id);
        }

        public virtual bool Contains(Expression<Func<T, bool>> predicate)
        {
            return DbSet.Any(predicate);
        }

        public virtual async Task<bool> ContainsAsync(Expression<Func<T, bool>> predicate)
        {
            return await DbSet.AnyAsync(predicate);
        }

        public virtual int Count => DbSet.Count();

        public virtual T Create(T obj)
        {
            var newEntry = DbSet.Add(obj);

            if (!_shareContext)
                Context.SaveChanges();

            return newEntry;
        }

        public virtual async Task<T> CreateAsync(T obj)
        {
            var newEntry = DbSet.Add(obj);

            if (!_shareContext)
                await Context.SaveChangesAsync();

            return newEntry;
        }

        public virtual int Update(T obj)
        {
            var entry = Context.Entry(obj);

            if (entry.State == EntityState.Detached)
            {
                var attachedEntity = DbSet.Find(obj.Id);  // You need to have access to key

                if (attachedEntity != null)
                {
                    var attachedEntry = Context.Entry(attachedEntity);
                    attachedEntry.CurrentValues.SetValues(obj);
                }
                else
                {
                    entry.State = EntityState.Modified; // This should attach entity
                }
            }

            return !_shareContext ? Context.SaveChanges() : 0;
        }

        public async Task<int> UpdateAsync(T obj)
        {
            var entry = Context.Entry(obj);

            if (entry.State == EntityState.Detached)
            {
                var attachedEntity = await DbSet.FindAsync(obj.Id);  // You need to have access to key

                if (attachedEntity != null)
                {
                    var attachedEntry = Context.Entry(attachedEntity);
                    attachedEntry.CurrentValues.SetValues(obj);
                }
                else
                {
                    entry.State = EntityState.Added; // This should attach entity
                }
            }

            return !_shareContext ? await Context.SaveChangesAsync() : 0;
        }

        public virtual int Delete(T obj)
        {
            DbSet.Remove(obj);

            return !_shareContext ? Context.SaveChanges() : 0;
        }

        public virtual async Task<int> DeleteAsync(T obj)
        {
            DbSet.Remove(obj);

            return !_shareContext ? await Context.SaveChangesAsync() : 0;
        }

        public virtual int Delete(Expression<Func<T, bool>> predicate)
        {
            var objects = Where(predicate);
            foreach (var obj in objects)
                DbSet.Remove(obj);

            return !_shareContext ? Context.SaveChanges() : 0;
        }

        public virtual async Task<int> DeleteAsync(Expression<Func<T, bool>> predicate)
        {
            var objects = Where(predicate);
            foreach (var obj in objects)
                DbSet.Remove(obj);

            return !_shareContext ? await Context.SaveChangesAsync() : 0;
        }
    }

    public class FandReadOnlyRepository<T> where T : class
    {
        private readonly bool _shareContext;
        public FandDbContext Context = null;
        protected IFandDataAccess FandDataAccess = null;

        protected DbSet<T> DbSet => Context.Set<T>();

        public FandReadOnlyRepository()
        {
            Context = new FandDbContext();
        }

        public FandReadOnlyRepository(FandDbContext context)
        {

            Context = context;
            _shareContext = true;
        }

        public FandReadOnlyRepository(FandDbContext context, IFandDataAccess fandDataAccess)
        {
            Context = context;
            FandDataAccess = fandDataAccess;
            _shareContext = true;
        }

        public void Dispose()
        {
            if (_shareContext)
                Context?.Dispose();
        }

        public virtual IQueryable<T> AsQueryable()
        {
            return DbSet.AsQueryable();
        }

        public virtual IEnumerable<T> All()
        {
            return DbSet.ToList();
        }

        public virtual bool AsQueryable(Expression<Func<T, bool>> predicate)
        {
            return DbSet.All(predicate);
        }

        public virtual bool Any(Expression<Func<T, bool>> predicate)
        {
            return DbSet.Any(predicate);
        }

        public virtual IQueryable<T> Where(Expression<Func<T, bool>> predicate)
        {
            return DbSet.Where(predicate).AsQueryable();
        }
        public virtual bool Contains(Expression<Func<T, bool>> predicate)
        {
            return DbSet.Any(predicate);
        }

        public virtual int Count => DbSet.Count();
    }
}
