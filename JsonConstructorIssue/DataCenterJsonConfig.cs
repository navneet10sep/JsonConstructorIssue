using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace JsonConstructorIssue
{ 
    public class DataCenterJsonConfig
    {
        [JsonConstructor]
        public DataCenterJsonConfig(
            DataCenter dataCenter
        )
        {
            this.DataCenter = dataCenter;
        }

        [JsonPropertyName("dataCenter")]
        public DataCenter DataCenter { get; }
    }


}
