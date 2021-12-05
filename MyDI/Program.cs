// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using MyDI.DependencyInjectionLogic;
using MyDI.Services;

var serviceProvider = new MyServiceProvider();

// serviceProvider.AddSingelton(new DateTimeProvider());
//serviceProvider.AddSingelton<IGuidProvider, GuidProvider>();
serviceProvider.AddTransiant<IGuidProvider, GuidProvider>();
//serviceProvider.AddTransiant<GuidGenerator>();

serviceProvider.AddSingelton<IGuidGenerator, GuidGenerator>();


var services = serviceProvider.BuildServiceCollection();
var first=services.GetService<IGuidProvider> ();
var second=services.GetService<IGuidProvider> ();


System.Console.WriteLine(first.GetGuid());
System.Console.WriteLine(second.GetGuid());