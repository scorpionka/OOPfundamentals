using LibraryClient.PresentationServices;
using LibraryClient.PresentationServices.Interfaces;
using LibraryData.FileSystemRepositories;
using LibraryDomain.DomainServices;
using LibraryDomain.DomainServices.Interfaces;
using LibraryDomain.Repositories.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace LibraryClient
{
    public class ProgramServicesProvider
    {
        public static void RunServicesProvider(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            host.Services.GetRequiredService<Program>().Run();
        }

        private static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureServices(services =>
                {
                    services.AddTransient<Program>();
                    services.AddTransient<IBasePresentationService, BasePresentationService>();
                    services.AddTransient<IBaseDomainService, BaseDomainService>();
                    services.AddTransient<IBaseRepository, BaseFileSystemRepository>();
                    services.AddTransient<IBookPresentationService, BookPresentationService>();
                    services.AddTransient<IBookDomainService, BookDomainService>();
                    services.AddTransient<IBookRepository, BookFileSystemRepository>();
                    services.AddTransient<ILocalizedBookPresentationService, LocalizedBookPresentationService>();
                    services.AddTransient<ILocalizedBookDomainService, LocalizedBookDomainService>();
                    services.AddTransient<ILocalizedBookRepository, LocalizedBookFileSystemRepository>();
                    services.AddTransient<IMagazinePresentationService, MagazinePresentationService>();
                    services.AddTransient<IMagazineDomainService, MagazineDomainService>();
                    services.AddTransient<IMagazineRepository, MagazineFileSystemRepository>();
                    services.AddTransient<IPatentPresentationService, PatentPresentationService>();
                    services.AddTransient<IPatentDomainService, PatentDomainService>();
                    services.AddTransient<IPatentRepository, PatentFileSystemRepository>();
                });
        }
    }
}
