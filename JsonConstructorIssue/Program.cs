using JsonConstructorIssue;
using Microsoft.Extensions.Configuration;
using System.Text.Json;

IConfigurationRoot configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
   .AddJsonFile("datacenter.json", optional: false)
  .Build();

// Using Raw Json 
/*var json = @"{ ""dataCenter"": { ""dataCenterLocations"": [ { ""name"": ""United States"" } ] } }";
var options = new JsonSerializerOptions(JsonSerializerDefaults.Web);
var dataCenter = JsonSerializer.Deserialize<DataCenter>(json, options);
*/
// Using ConfigurationBuilder
var dataCenter = configuration.GetSection("dataCenter").Get<DataCenter>();


foreach (var location in  dataCenter.DataCenterLocations)
{
    Console.WriteLine(location.Name);
}
 