using Microsoft.Extensions.Configuration;

var configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .Build();

var connectionString = configuration
    .GetSection("ConnectionString").Value;


Console.WriteLine(connectionString);


