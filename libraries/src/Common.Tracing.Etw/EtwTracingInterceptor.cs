﻿//
// Copyright (c) Microsoft.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

using System;
using System.Collections.Generic;
using System.Net.Http;

namespace Microsoft.WindowsAzure.Common.Tracing.Etw
{
    /// <summary>
    /// Implementation for ICloudTracingInterceptor that raises ETW events.
    /// </summary>
    public class EtwTracingInterceptor : ICloudTracingInterceptor
    {
        public void Information(string message)
        {
            CloudTracingEventSource.Log.Information(message);
        }

        public void Configuration(string source, string name, string value)
        {
            CloudTracingEventSource.Log.Configuration(source, name, value);
        }

        public void Enter(string invocationId, object instance, string method, IDictionary<string, object> parameters)
        {
            string instanceAsString = instance == null ? string.Empty : instance.ToString();
            string parametersAsString = parameters == null ? string.Empty : parameters.AsFormattedString();

            CloudTracingEventSource.Log.Enter(invocationId, instanceAsString, method, parametersAsString);
        }

        /// <summary>
        /// Send an HTTP request.
        /// </summary>
        /// <param name="invocationId">Method invocation identifier.</param>
        /// <param name="request">The request about to be sent.</param>
        public virtual void SendRequest(string invocationId, HttpRequestMessage request)
        {
            string requestAsString = request == null ? string.Empty : request.AsFormattedString();

            CloudTracingEventSource.Log.SendRequest(invocationId, requestAsString);
        }

        /// <summary>
        /// Receive an HTTP reponse.
        /// </summary>
        /// <param name="invocationId">Method invocation identifier.</param>
        /// <param name="response">The response instance.</param>
        public virtual void ReceiveResponse(string invocationId, HttpResponseMessage response)
        {
            string responseAsString = response == null ? string.Empty : response.AsFormattedString();

            CloudTracingEventSource.Log.ReceiveResponse(invocationId, responseAsString);
        }

        public void Error(string invocationId, Exception exception)
        {
            string exceptionAsString = exception == null ? string.Empty : exception.ToString();

            CloudTracingEventSource.Log.Error(invocationId, exceptionAsString);
        }

        public void Exit(string invocationId, object returnValue)
        {
            string returnValueAsString = returnValue == null ? string.Empty : returnValue.ToString();

            CloudTracingEventSource.Log.Exit(invocationId, returnValueAsString);
        }
    }
}
