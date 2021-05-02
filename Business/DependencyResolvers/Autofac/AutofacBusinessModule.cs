using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //procedure
            builder.RegisterType<ProcedureManager>().As<IProcedureService>();
            builder.RegisterType<EfProcedureDal>().As<IProcedureDal>();
            //product
            builder.RegisterType<ProductManager>().As<IProductService>();
            builder.RegisterType<EfProductDal>().As<IProductDal>();
            //query
            builder.RegisterType<QueryManager>().As<IQueryService>();
            builder.RegisterType<EfQueryDal>().As<IQueryDal>();

            //retailcustomer
            builder.RegisterType<RetailCustomerManager>().As<IRetailCustomerService>();
            builder.RegisterType<EfRetailCustomerDal>().As<IRetailCustomerDal>();
            //retailinvoice
            builder.RegisterType<RetailInvoiceManager>().As<IRetailInvoiceService>();
            builder.RegisterType<EfRetailInvoiceDal>().As<IRetailInvoiceDal>();
            //retailorder
            builder.RegisterType<RetailOrderManager>().As<IRetailOrderService>();
            builder.RegisterType<EfRetailOrderDal>().As<IRetailOrderDal>();

            //wholesalecustomer
            builder.RegisterType<WholesaleCustomerManager>().As<IWholesaleCustomerService>();
            builder.RegisterType<EfWholesaleCustomerDal>().As<IWholesaleCustomerDal>();
            //wholesaleinvoice
            builder.RegisterType<WholesaleInvoiceManager>().As<IWholesaleInvoiceService>();
            builder.RegisterType<EfWholesaleInvoiceDal>().As<IWholesaleInvoiceDal>();
            //wholesaleorder
            builder.RegisterType<WholesaleOrderManager>().As<IWholesaleOrderService>();
            builder.RegisterType<EfWholesaleOrderDal>().As<IWholesaleOrderDal>();


            //jwt, autharization
            //builder.RegisterType<AuthManager>().As<IAuthService>();
            //builder.RegisterType<JwtHelper>().As<ITokenHelper>();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces().EnableInterfaceInterceptors(
                new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}