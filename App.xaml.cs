using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using Todo_UserControls.MVVM.View;
using Todo_UserControls.MVVM.ViewModel;

namespace Todo_UserControls
{
    
    public partial class App : Application
    {
        private readonly ServiceProvider _serviceProvider;

        public App()
        {
            ServiceCollection serviceCollection = new();
            serviceCollection.ConfigureService();

            _serviceProvider = serviceCollection.BuildServiceProvider();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var mainWindow = _serviceProvider.GetRequiredService<MainWindow>();
            mainWindow.Show();
        }
    }

    public static class ServiceCollectionExtensions 
    {
        public static IServiceCollection ConfigureService(this IServiceCollection service)
        {
            // Add all services to the service collection

            service.AddSingleton<MainWindow>();
            service.AddSingleton<MainWindowViewModel>();
            service.AddSingleton<TaskListView>();
            service.AddSingleton<TaskListUpdate>();

            return service;
        }
    }

}
