using Utilities.RepositoryFactory.Repositories;

namespace Utilities.RepositoryFactory
{
    public class MainMethod
    {
        static void Main(string[] args)
        {
            IExampleRepository sqlRepo = RepositoryFactory.GetSQLRepository();
            IExampleRepository serviceRepo = RepositoryFactory.GetServiceRepository();
        }
    }
}