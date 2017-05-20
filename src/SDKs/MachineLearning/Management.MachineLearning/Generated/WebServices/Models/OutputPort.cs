// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.MachineLearning.WebServices.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.MachineLearning;
    using Microsoft.Azure.Management.MachineLearning.WebServices;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Asset output port
    /// </summary>
    public partial class OutputPort
    {
        /// <summary>
        /// Initializes a new instance of the OutputPort class.
        /// </summary>
        public OutputPort()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OutputPort class.
        /// </summary>
        /// <param name="type">Port data type. Possible values include:
        /// 'Dataset'</param>
        public OutputPort(string type = default(string))
        {
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets port data type. Possible values include: 'Dataset'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

    }
}
