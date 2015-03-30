using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Utilities.RepositoryFactory.Repositories
{
    public class ServiceRepository : IExampleRepository
    {
        public ServiceRepository()
        {

        }

        void IExampleRepository.GetExamples()
        {
            throw new NotImplementedException();
        }
    }
}