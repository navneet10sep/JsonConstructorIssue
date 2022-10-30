// See https://aka.ms/new-console-template for more information
using JsonConstructorIssue;
using Microsoft.Extensions.Configuration;

Console.WriteLine("Hello, World!");

IConfigurationRoot configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
   .AddJsonFile("datacenter.json", optional: false)
  .Build();


if (configuration.GetSection("dataCenter").Exists())
{

    var dataCenterJsonConfig = configuration.Get<DataCenterJsonConfig>();

    foreach (var location in dataCenterJsonConfig.DataCenter.DataCenterLocations)
    {
        Console.WriteLine(location.Name);
    }


}
else
{
    throw new Exception("Could not read datacenter.json!");
}