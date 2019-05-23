using CommonProject.Domain.Data;
using CommonProject.Domain.Data.Entity;
using CommonProject.Domain.Models;
using CommonProject.Framework.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonProject.Domain.Services.TestFacade.Implementation
{
    public class TestService : ITestService
    {
        IEntityRepository<Test, DomainContext> _testRepository = new EntityRepository<Test, DomainContext>();

       

        public List<TestModel> GetAll()
        {
            var result = _testRepository.Fetch();
            return null;
        }
    }
}
