using System;
using System.Reflection;
using System.Threading.Tasks;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using CommonProject.Domain.Data;
using CommonProject.Domain.Services.TestFacade;
using CommonProject.Domain.Services.TestFacade.Implementation;
using CommonProject.Framework.Data;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Common.MVC.App_Start.Startup))]

namespace Common.MVC.App_Start
{
    public class Startup
    {
        //public void Configuration(IAppBuilder app)
        //{
        //    ConfigAutofac(app);
        //}

        //private void ConfigAutofac(IAppBuilder app)
        //{
        //    var builder = new ContainerBuilder();
        //    builder.RegisterControllers(Assembly.GetExecutingAssembly());

        //    builder.RegisterAssemblyTypes(typeof(DomainContext).Assembly).AsSelf().InstancePerRequest();

        //    builder.RegisterAssemblyTypes(typeof(TestService).Assembly)
        //        .AsImplementedInterfaces().InstancePerRequest();
        //    //builder.RegisterType<TestService>().InstancePerRequest().As<ITestService>().InstancePerLifetimeScope();

        //    builder.RegisterType(typeof(EntityRepository<,>)).As(typeof(IEntityRepository<,>));

        //    //builder.RegisterGenericDecorator(typeof(EntityRepository<,>),typeof(IEntityRepository<,>));

        //    var container = builder.Build();
        //    DependencyResolver.SetResolver(container);


        //}

        
    }
}
