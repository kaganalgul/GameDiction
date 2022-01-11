﻿using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Ardalis.Specification;
using Ardalis.Specification.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class EfRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly DatabaseContext _db;

        public EfRepository(DatabaseContext db)
        {
            _db = db;
        }

        public async Task<T> AddAsync(T entity)
        {
            _db.Add(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(T entity)
        {
            _db.Remove(entity);
            await _db.SaveChangesAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _db.FindAsync<T>(id);
        }

        public async Task<List<T>> ListAllAsync()
        {
            return await _db.Set<T>().ToListAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _db.Update(entity);
            await _db.SaveChangesAsync();
        }
    }
}
