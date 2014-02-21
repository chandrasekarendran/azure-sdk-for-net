// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Common;
using Microsoft.WindowsAzure.Common.Internals;
using Microsoft.WindowsAzure.Management.Monitoring.Metrics;
using Microsoft.WindowsAzure.Management.Monitoring.Metrics.Models;
using Newtonsoft.Json.Linq;

namespace Microsoft.WindowsAzure.Management.Monitoring.Metrics
{
    internal partial class MetricValueOperations : IServiceOperations<MetricsClient>, Microsoft.WindowsAzure.Management.Monitoring.Metrics.IMetricValueOperations
    {
        /// <summary>
        /// Initializes a new instance of the MetricValueOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        internal MetricValueOperations(MetricsClient client)
        {
            this._client = client;
        }
        
        private MetricsClient _client;
        
        /// <summary>
        /// Gets a reference to the
        /// Microsoft.WindowsAzure.Management.Monitoring.Metrics.MetricsClient.
        /// </summary>
        public MetricsClient Client
        {
            get { return this._client; }
        }
        
        /// <summary>
        /// The List Metric Value operation lists the metric value sets for the
        /// resource metrics.
        /// </summary>
        /// <param name='resourceId'>
        /// The id of the resource.
        /// </param>
        /// <param name='metricNames'>
        /// The names of the metrics.
        /// </param>
        /// <param name='metricNamespace'>
        /// The namespace of the metrics.
        /// </param>
        /// <param name='timeGrain'>
        /// The time grain of the metrics.
        /// </param>
        /// <param name='startTime'>
        /// The start time (in UTC) of the metrics.
        /// </param>
        /// <param name='endTime'>
        /// The end time (in UTC) of the metrics.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The List Metric values operation response.
        /// </returns>
        public async System.Threading.Tasks.Task<Microsoft.WindowsAzure.Management.Monitoring.Metrics.Models.MetricValueListResponse> ListAsync(string resourceId, IList<string> metricNames, string metricNamespace, TimeSpan timeGrain, DateTime startTime, DateTime endTime, CancellationToken cancellationToken)
        {
            // Validate
            if (resourceId == null)
            {
                throw new ArgumentNullException("resourceId");
            }
            if (metricNames == null)
            {
                throw new ArgumentNullException("metricNames");
            }
            if (metricNames.Count <= 0)
            {
                throw new ArgumentException("metricNames cannot be empty.");
            }
            
            // Tracing
            bool shouldTrace = CloudContext.Configuration.Tracing.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = Tracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("resourceId", resourceId);
                tracingParameters.Add("metricNames", metricNames);
                tracingParameters.Add("metricNamespace", metricNamespace);
                tracingParameters.Add("timeGrain", timeGrain);
                tracingParameters.Add("startTime", startTime);
                tracingParameters.Add("endTime", endTime);
                Tracing.Enter(invocationId, this, "ListAsync", tracingParameters);
            }
            
            // Construct URL
            string url = new Uri(this.Client.BaseUri, "/").ToString() + this.Client.Credentials.SubscriptionId + "/services/monitoring/metricvalues/query?";
            url = url + "&resourceId=" + Uri.EscapeUriString(resourceId);
            if (metricNamespace != null)
            {
                url = url + "&namespace=" + Uri.EscapeUriString(metricNamespace);
            }
            url = url + "&names=" + Uri.EscapeUriString(string.Join(",", metricNames));
            url = url + "&timeGrain=" + Uri.EscapeUriString(TypeConversion.To8601String(timeGrain));
            url = url + "&startTime=" + Uri.EscapeUriString(string.Format(CultureInfo.InvariantCulture, "{0:O}", startTime.ToUniversalTime()));
            url = url + "&endTime=" + Uri.EscapeUriString(string.Format(CultureInfo.InvariantCulture, "{0:O}", endTime.ToUniversalTime()));
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Get;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                httpRequest.Headers.Add("Accept", "application/json");
                httpRequest.Headers.Add("x-ms-version", "2013-10-01");
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        Tracing.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        Tracing.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, null, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false), CloudExceptionType.Json);
                        if (shouldTrace)
                        {
                            Tracing.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    MetricValueListResponse result = null;
                    // Deserialize Response
                    cancellationToken.ThrowIfCancellationRequested();
                    string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                    result = new MetricValueListResponse();
                    JToken responseDoc = JToken.Parse(responseContent);
                    
                    if (responseDoc != null && responseDoc.Type != JTokenType.Null)
                    {
                        MetricValueSetCollection metricValueSetCollectionInstance = new MetricValueSetCollection();
                        result.MetricValueSetCollection = metricValueSetCollectionInstance;
                        
                        JToken valueArray = responseDoc["Value"];
                        if (valueArray != null && valueArray.Type != JTokenType.Null)
                        {
                            foreach (JToken valueValue in (JArray)valueArray)
                            {
                                MetricValueSet metricValueSetInstance = new MetricValueSet();
                                metricValueSetCollectionInstance.Value.Add(metricValueSetInstance);
                                
                                JToken nameValue = valueValue["Name"];
                                if (nameValue != null && nameValue.Type != JTokenType.Null)
                                {
                                    string nameInstance = (string)nameValue;
                                    metricValueSetInstance.Name = nameInstance;
                                }
                                
                                JToken namespaceValue = valueValue["Namespace"];
                                if (namespaceValue != null && namespaceValue.Type != JTokenType.Null)
                                {
                                    string namespaceInstance = (string)namespaceValue;
                                    metricValueSetInstance.Namespace = namespaceInstance;
                                }
                                
                                JToken displayNameValue = valueValue["DisplayName"];
                                if (displayNameValue != null && displayNameValue.Type != JTokenType.Null)
                                {
                                    string displayNameInstance = (string)displayNameValue;
                                    metricValueSetInstance.DisplayName = displayNameInstance;
                                }
                                
                                JToken unitValue = valueValue["Unit"];
                                if (unitValue != null && unitValue.Type != JTokenType.Null)
                                {
                                    string unitInstance = (string)unitValue;
                                    metricValueSetInstance.Unit = unitInstance;
                                }
                                
                                JToken primaryAggregationValue = valueValue["PrimaryAggregation"];
                                if (primaryAggregationValue != null && primaryAggregationValue.Type != JTokenType.Null)
                                {
                                    string primaryAggregationInstance = (string)primaryAggregationValue;
                                    metricValueSetInstance.PrimaryAggregation = primaryAggregationInstance;
                                }
                                
                                JToken timeGrainValue = valueValue["TimeGrain"];
                                if (timeGrainValue != null && timeGrainValue.Type != JTokenType.Null)
                                {
                                    TimeSpan timeGrainInstance = TypeConversion.From8601TimeSpan((string)timeGrainValue);
                                    metricValueSetInstance.TimeGrain = timeGrainInstance;
                                }
                                
                                JToken startTimeValue = valueValue["StartTime"];
                                if (startTimeValue != null && startTimeValue.Type != JTokenType.Null)
                                {
                                    DateTime startTimeInstance = (DateTime)startTimeValue;
                                    metricValueSetInstance.StartTime = startTimeInstance;
                                }
                                
                                JToken endTimeValue = valueValue["EndTime"];
                                if (endTimeValue != null && endTimeValue.Type != JTokenType.Null)
                                {
                                    DateTime endTimeInstance = (DateTime)endTimeValue;
                                    metricValueSetInstance.EndTime = endTimeInstance;
                                }
                                
                                JToken metricValuesArray = valueValue["MetricValues"];
                                if (metricValuesArray != null && metricValuesArray.Type != JTokenType.Null)
                                {
                                    foreach (JToken metricValuesValue in (JArray)metricValuesArray)
                                    {
                                        MetricValue metricValueInstance = new MetricValue();
                                        metricValueSetInstance.MetricValues.Add(metricValueInstance);
                                        
                                        JToken timestampValue = metricValuesValue["Timestamp"];
                                        if (timestampValue != null && timestampValue.Type != JTokenType.Null)
                                        {
                                            DateTime timestampInstance = (DateTime)timestampValue;
                                            metricValueInstance.Timestamp = timestampInstance;
                                        }
                                        
                                        JToken averageValue = metricValuesValue["Average"];
                                        if (averageValue != null && averageValue.Type != JTokenType.Null)
                                        {
                                            double averageInstance = (double)averageValue;
                                            metricValueInstance.Average = averageInstance;
                                        }
                                        
                                        JToken minimumValue = metricValuesValue["Minimum"];
                                        if (minimumValue != null && minimumValue.Type != JTokenType.Null)
                                        {
                                            double minimumInstance = (double)minimumValue;
                                            metricValueInstance.Minimum = minimumInstance;
                                        }
                                        
                                        JToken maximumValue = metricValuesValue["Maximum"];
                                        if (maximumValue != null && maximumValue.Type != JTokenType.Null)
                                        {
                                            double maximumInstance = (double)maximumValue;
                                            metricValueInstance.Maximum = maximumInstance;
                                        }
                                        
                                        JToken totalValue = metricValuesValue["Total"];
                                        if (totalValue != null && totalValue.Type != JTokenType.Null)
                                        {
                                            double totalInstance = (double)totalValue;
                                            metricValueInstance.Total = totalInstance;
                                        }
                                        
                                        JToken annotationValue = metricValuesValue["Annotation"];
                                        if (annotationValue != null && annotationValue.Type != JTokenType.Null)
                                        {
                                            string annotationInstance = (string)annotationValue;
                                            metricValueInstance.Annotation = annotationInstance;
                                        }
                                        
                                        JToken countValue = metricValuesValue["Count"];
                                        if (countValue != null && countValue.Type != JTokenType.Null)
                                        {
                                            int countInstance = (int)countValue;
                                            metricValueInstance.Count = countInstance;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-request-id"))
                    {
                        result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                    }
                    
                    if (shouldTrace)
                    {
                        Tracing.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
    }
}
