using CommonProject.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonProject.Domain.Services.TestFacade
{
    public interface ITestService 
    {
        List<TestModel> GetAll();

    }
}
