﻿using Maetup_Data.DAL;
using Meatup_Business.RepositoryAbstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maetup_Data.RepositoryContans
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class, new()
    {
        AppDbContext _dbContext;

        public GenericRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(T entity)
        {
            _dbContext.Set<T>().Add(entity);
        }

        public void Commit()
        {
            _dbContext.SaveChanges();
        }

        public T Get(Func<T, bool>? func = null)
        {
            return func == null ? _dbContext.Set<T>().FirstOrDefault() :
                                  _dbContext.Set<T>().Where(func).FirstOrDefault();
        }

        public List<T> GetAll(Func<T, bool>? func = null)
        {
            return func == null ? _dbContext.Set<T>().ToList() :
                                  _dbContext.Set<T>().Where(func).ToList();
        }

        public void Remove(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
        }
    }
}
