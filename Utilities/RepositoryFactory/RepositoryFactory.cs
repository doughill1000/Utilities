using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Utilities.RepositoryFactory.Repositories;

namespace Utilities.RepositoryFactory
{
    /// <summary>
    /// Use as utilities for Repository
    /// </summary>
    public static class RepositoryFactory
    {
        public static SqlRepository GetSQLRepository()
        {
            SqlRepository repo = new SqlRepository();
            return repo;
        }

        public static ServiceRepository GetServiceRepository()
        {
            ServiceRepository repo = new ServiceRepository();
            return repo;
        }
    }
}