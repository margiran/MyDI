// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

var serviceProvider = new MyServiceProvider();

serviceProvider.AddSingelton(new GuidGenerator());

var services = serviceProvider.BuildServiceCollection();
var first=services.GetService<GuidGenerator> ();
var second=services.GetService<GuidGenerator> ();


System.Console.WriteLine(first.GeneratedGuid);
System.Console.WriteLine(second.GeneratedGuid);