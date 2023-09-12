using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeetCodeConsole;
using LeetCodeConsole.inteface;
using Microsoft.Extensions.DependencyInjection;

namespace SolutionTests
{
    public class TestStartup
    {
        public static IServiceProvider ConfigureServices()
    {
        var serviceCollection = new ServiceCollection();
        
        // Register your services and dependencies here
        serviceCollection.AddTransient<ISolution, Solution>();
        
        return serviceCollection.BuildServiceProvider();
    }
    }
}