using Microsoft.EntityFrameworkCore;
using Npgsql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFwithEFApp.Data.DbContexts;
using WPFwithEFApp.Data.IGenericRepositories;
using WPFwithEFApp.Domain.Commons;

namespace WPFwithEFApp.Data.GenericRepositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : Auditable
    {
        private readonly WPFwithEFAppDbContext _dbContext;

        private readonly DbSet<T> dbSet;
        public GenericRepository()
        {
            _dbContext = new WPFwithEFAppDbContext();
            dbSet = _dbContext.Set<T>();
        } 

        public async Task<bool> AddAsync(T entity)
        {
            entity.CreationTime = DateTime.UtcNow;
            entity.UpdatedTime = null;


            await dbSet.AddAsync(entity);

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                if (ex.InnerException is PostgresException pgEx && pgEx.SqlState == "23505")
                {
                    Console.WriteLine("Error: Unique constraint violation");

                    return false;
                }
            }
            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var entity = await GetAsync(id);
            
            dbSet.Remove(entity);
            
            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<bool> UpdateAsync(T entity)
        {

            dbSet.Update(entity);

            await _dbContext.SaveChangesAsync();

            return true;
        }

        public List<T> GetAll()
        {
                var list = dbSet.OrderBy(e => e.Id).ToList();

                
                return list;
            }
        //if (File.Exists(filePath))
        //{
        //    File.Delete(filePath);
        //}
        public async Task<T> GetAsync(int id)
        {
            var entity = await dbSet.FirstOrDefaultAsync(e => e.Id == id);
            
            return entity;
        }

       
    }
}
