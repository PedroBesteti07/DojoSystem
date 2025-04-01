namespace DojoSystem.Services.Interfaces
{
    public class IAcademia <T> where T : class
    {
        Task<T> GetById (int id);
        Task Create(T entity);
        Task Update(T entity, int id);
        Task Remove(int id);
    }
}
