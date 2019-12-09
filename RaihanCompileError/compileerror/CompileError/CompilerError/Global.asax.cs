using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using AutoMapper;
using CompileError.Model.Model;
using CompilerError.Models;

namespace CompilerError
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<CustomerViewModel, Customer>();
                cfg.CreateMap<Customer, CustomerViewModel>();

                cfg.CreateMap<CategoryViewModel, Category>();
                cfg.CreateMap<Category, CategoryViewModel>();

                //cfg.CreateMap<PurchaseReportViewModel, Purchase>();
                //cfg.CreateMap<Purchase, PurchaseReportViewModel>();

                //cfg.CreateMap<SalesReportViewModel, Sale>();
                //cfg.CreateMap<Sale, SalesReportViewModel>();

            });
        }
    }
}
