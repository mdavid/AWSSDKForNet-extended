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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.IdentityManagement.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.IdentityManagement.Model.Transform
{
    /// <summary>
    /// Create Access Key Request Marshaller
    /// </summary>       
    public class CreateAccessKeyRequestMarshaller : IMarshaller<IRequest<CreateAccessKeyRequest>, CreateAccessKeyRequest> 
    {

        public IRequest<CreateAccessKeyRequest> Marshall(CreateAccessKeyRequest createAccessKeyRequest) 
        {
            IRequest<CreateAccessKeyRequest> request = new DefaultRequest<CreateAccessKeyRequest>(createAccessKeyRequest, "AmazonIdentityManagementService");
            request.Parameters.Add("Action", "CreateAccessKey");
            request.Parameters.Add("Version", "2010-05-08");
            if (createAccessKeyRequest != null && createAccessKeyRequest.IsSetUserName()) 
            {
                request.Parameters.Add("UserName", StringUtils.FromString(createAccessKeyRequest.UserName));
            }


            return request;
        }
    }
}
