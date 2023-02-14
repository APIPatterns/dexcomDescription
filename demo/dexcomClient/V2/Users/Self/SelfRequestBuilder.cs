using Dexcom.V2.Users.Self.Calibrations;
using Dexcom.V2.Users.Self.DataRange;
using Dexcom.V2.Users.Self.Devices;
using Dexcom.V2.Users.Self.Egvs;
using Dexcom.V2.Users.Self.Events;
using Dexcom.V2.Users.Self.Statistics;
using Microsoft.Kiota.Abstractions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace Dexcom.V2.Users.Self {
    /// <summary>
    /// Builds and executes requests for operations under \v2\users\self
    /// </summary>
    public class SelfRequestBuilder {
        /// <summary>The calibrations property</summary>
        public CalibrationsRequestBuilder Calibrations { get =>
            new CalibrationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The dataRange property</summary>
        public DataRangeRequestBuilder DataRange { get =>
            new DataRangeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The devices property</summary>
        public DevicesRequestBuilder Devices { get =>
            new DevicesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The egvs property</summary>
        public EgvsRequestBuilder Egvs { get =>
            new EgvsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The events property</summary>
        public EventsRequestBuilder Events { get =>
            new EventsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>The statistics property</summary>
        public StatisticsRequestBuilder Statistics { get =>
            new StatisticsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Instantiates a new SelfRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SelfRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/v2/users/self";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new SelfRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SelfRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/v2/users/self";
            var urlTplParams = new Dictionary<string, object>();
            if (!string.IsNullOrWhiteSpace(rawUrl)) urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
    }
}
