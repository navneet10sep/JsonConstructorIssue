using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace JsonConstructorIssue
{
    public class DataCenter
    {
        [JsonConstructor]
        public DataCenter(
             List<DataCenterLocation> dataCenterLocations
        )
        {
            this.DataCenterLocations = dataCenterLocations;
        }

       [JsonPropertyName("dataCenterLocations")]
        public List<DataCenterLocation> DataCenterLocations { get; }
    }
}
