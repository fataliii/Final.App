﻿using Final.App.Core.Models.BaseModels;


namespace Final.App.Core.Repositories
{
    public interface IRepository<T> where T : BaseModel
    {
        public Task AddAsync(T model);
        public Task<T> GetAsync(Func< T , bool> expression);
        public Task<List<T>> GetAllAsync();
        public Task RemoveAsync (T model);


    }
}
