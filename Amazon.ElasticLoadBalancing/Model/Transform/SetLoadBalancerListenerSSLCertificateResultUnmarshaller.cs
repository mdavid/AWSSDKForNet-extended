/*
 * Copyright 2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System.Collections.Generic;

using Amazon.ElasticLoadBalancing.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ElasticLoadBalancing.Model.Transform
{
     /// <summary>
     ///   SetLoadBalancerListenerSSLCertificateResult Unmarshaller
     /// </summary>
    internal class SetLoadBalancerListenerSSLCertificateResultUnmarshaller : IUnmarshaller<SetLoadBalancerListenerSSLCertificateResult, UnmarshallerContext> 
    {
        public SetLoadBalancerListenerSSLCertificateResult Unmarshall(UnmarshallerContext context) 
        {
            SetLoadBalancerListenerSSLCertificateResult setLoadBalancerListenerSSLCertificateResult = new SetLoadBalancerListenerSSLCertificateResult();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return setLoadBalancerListenerSSLCertificateResult;
                }
            }

            return setLoadBalancerListenerSSLCertificateResult;
        }

        private static SetLoadBalancerListenerSSLCertificateResultUnmarshaller instance;

        public static SetLoadBalancerListenerSSLCertificateResultUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new SetLoadBalancerListenerSSLCertificateResultUnmarshaller();

            return instance;
        }
    }
}
    
