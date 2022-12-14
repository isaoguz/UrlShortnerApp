﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UrlShortnerApps.Entities.Concrate;

namespace UrlShortnerApps.DataAccess.Abstract
{
    public interface IUriRepository
    {
        Task<List<UriDetails>> GetAllAsync();
        Task<UriDetails> GetByIdAsync(string id);
        Task<UriDetails> CreateAsync(UriDetails customer);
        Task UpdateAsync(string id, UriDetails customer);
        Task DeleteAsync(string id);
    }
}
