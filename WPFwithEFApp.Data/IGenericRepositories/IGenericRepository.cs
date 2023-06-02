using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFwithEFApp.Domain.Commons;

namespace WPFwithEFApp.Data.IGenericRepositories
{
    public interface IGenericRepository<T> where T : Auditable
    {
        Task<bool> AddAsync(T entity);
        Task<bool> UpdateAsync(T entity);
        Task<bool> DeleteAsync(int id);
        Task<T> GetAsync(int id);
        List<T> GetAll();
    }
}
