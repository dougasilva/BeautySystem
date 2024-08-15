using BeautySystem.Domain.Exceptions;
using BeautySystem.Domain.Interfaces;
using BeautySystem.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace BeautySystem.Infra.Data.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        protected readonly ApplicationDbContext _context;

        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<T> GetByIdAsync(int id)
        {
            try
            {
                return await _context.Set<T>().FindAsync(id);
            }
            catch (Exception ex)
            {
                throw new RepositoryException("Erro ao obter o registro por ID.", ex);
            }
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            try
            {
                return await _context.Set<T>().ToListAsync();
            }
            catch (Exception ex)
            {
                throw new RepositoryException("Erro ao obter todos os registros.", ex);
            }
        }

        public async Task AddAsync(T entity)
        {
            try
            {
                await _context.Set<T>().AddAsync(entity);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new RepositoryException("Erro ao adicionar o registro.", ex);
            }
        }

        public async Task UpdateAsync(T entity)
        {
            try
            {
                _context.Set<T>().Update(entity);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new RepositoryException("Erro ao atualizar o registro.", ex);
            }
        }

        public async Task DeleteAsync(T entity)
        {
            try
            {
                var entityEntry = _context.Entry(entity);

                _context.Set<T>().Update(entity);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new RepositoryException("Erro ao excluir o registro.", ex);
            }
        }
    }
}
