using eTickets.Models;

namespace eTickets.Data.Base
{
	public interface IEntityBaseRepository<T> where T : class,IEntityBase,new()
	{
		Task<IEnumerable<T>> GetAllAsync();
		Task<T> GetByIdAsync(int id);
		Task AddAsync(T entity);  // Corrected method signature for adding an actor
		Task UpdateAsync(int id, T entity); // Updated to async method
		Task DeleteAsync(T id);  // Made Delete async to be consistent

	}
}
