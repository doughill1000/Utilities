using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Utilities.RepositoryFactory.Repositories
{
    public class SqlRepository : IExampleRepository
    {
        public SqlRepository()
        {

        }

        void IExampleRepository.GetExamples()
        {
            throw new NotImplementedException();
        }
    }
}