using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace JsonConstructorIssue
{

    public class DataCenterLocation
    {
        [JsonConstructor]
        public DataCenterLocation(
           string name
        )
        {
            this.Name = name;
        }

        [JsonPropertyName("name")]
        public string Name { get; }
    }
}
