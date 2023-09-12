// See https://aka.ms/new-console-template for more information

// 1. 建立依賴注入的容器
using LeetCodeConsole;
using LeetCodeConsole.inteface;
using Microsoft.Extensions.DependencyInjection;

var serviceCollection = new ServiceCollection();
    // 2. 註冊服務
    serviceCollection.AddTransient<ISolution, Solution>();
    // 建立依賴服務提供者
    var serviceProvider = serviceCollection.BuildServiceProvider();

    // 3. 執行主服務
    var solution = serviceProvider.GetRequiredService<ISolution>();
    Console.WriteLine(solution.MinDeletions("aab") == 0);
    Console.WriteLine(solution.MinDeletions("aaabbbcc") == 2);
    Console.WriteLine(solution.MinDeletions("ceabaacb") == 2);

