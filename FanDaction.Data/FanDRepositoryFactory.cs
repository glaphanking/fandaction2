using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanDaction.Data
{
    public class FanDRepositoryFactory
    {
        private static Func<IFandDataAccess> _repositoryContructor = () => new FandDataAccess();

        public static Func<IFandDataAccess> RepositoryConstructor
        {
            set { _repositoryContructor = value; }
        }

        public static IFandDataAccess GetInstance()
        {
            return _repositoryContructor.Invoke();
        }
    }
}
