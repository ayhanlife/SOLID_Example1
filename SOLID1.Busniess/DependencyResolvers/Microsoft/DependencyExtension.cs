using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SOLID1.Business.Services.Abstract;
using SOLID1.Business.Services.Concrate;
using SOLID1.DataAccess.Abstract;
using SOLID1.DataAccess.Concrate.EntityFramework;
using SOLID1.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SOLID1.Business.DependencyResolvers.Microsoft
{
    public static class DependencyExtension
    {
        public static void AddDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            //var connectionSTring = builder.Configuration.GetConnectionString("Local");
            //builder.Services.AddDbContext<Context>(options => options.UseSqlServer(connectionSTring));

            services.AddDbContext<Context>(opt =>
            {
                opt.UseSqlServer(configuration.GetConnectionString("Local"));
            });


            //AUTOMAPPER DEPENDENCY INJECTİON  OTOMATIK AYAR
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            //VEYA BÖYLE KULLANILABILIR
            //var mapperConfiguration = new MapperConfiguration(opt =>
            //{
            //    //opt.AddProfile();
            //});
            //var mapper = mapperConfiguration.CreateMapper();
            //services.AddSingleton(mapper);


            services.AddScoped<IStokDal, EfStokDal>();
            services.AddScoped<IStokService, StokService>();

        }
    }
}
