﻿using System;
using System.Threading.Tasks;
using EPTS.Repositories.WebServices.WebAPI.Infrastructure.Entities.Catalogs;
using EPTS.Repositories.WebServices.WebAPI.Infrastructure.Core;

namespace EPTS.Repositories.WebServices.WebAPI.Infrastructure.Interfaces
{
    public interface IBusinessUnitRepository : IGenericRepositoryEntities<BusinessUnit>
    {
        /// <summary>
        /// Get the Business Unit By Id
        /// </summary>
        /// <param name="id">Is the Id from the database</param>
        /// <returns>Return a object type Business</returns>
        Task<BusinessUnit> GetById(Guid id);

    }
}
