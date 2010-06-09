/*******************************************************************************
 * Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2009-11-30
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// The Response from the CancelSpotInstanceRequests operation.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2009-11-30/", IsNullable = false)]
    public class CancelSpotInstanceRequestsResponse
    {
        private ResponseMetadata responseMetadataField;
        private CancelSpotInstanceRequestsResult cancelSpotInstanceRequestsResultField;

        /// <summary>
        /// Gets and sets the ResponseMetadata property.
        /// Response Metadata
        /// </summary>
        [XmlElementAttribute(ElementName = "ResponseMetadata")]
        public ResponseMetadata ResponseMetadata
        {
            get { return this.responseMetadataField; }
            set { this.responseMetadataField = value; }
        }

        /// <summary>
        /// Sets the ResponseMetadata property
        /// </summary>
        /// <param name="responseMetadata">Response Metadata</param>
        /// <returns>this instance</returns>
        public CancelSpotInstanceRequestsResponse WithResponseMetadata(ResponseMetadata responseMetadata)
        {
            this.responseMetadataField = responseMetadata;
            return this;
        }

        /// <summary>
        /// Checks if ResponseMetadata property is set
        /// </summary>
        /// <returns>true if ResponseMetadata property is set</returns>
        public bool IsSetResponseMetadata()
        {
            return this.responseMetadataField != null;
        }

        /// <summary>
        /// Gets and sets the CancelSpotInstanceRequestsResult property.
        /// The Cancel Spot Instance Requests Result.
        /// </summary>
        [XmlElementAttribute(ElementName = "CancelSpotInstanceRequestsResult")]
        public CancelSpotInstanceRequestsResult CancelSpotInstanceRequestsResult
        {
            get { return this.cancelSpotInstanceRequestsResultField; }
            set { this.cancelSpotInstanceRequestsResultField = value; }
        }

        /// <summary>
        /// Sets the CancelSpotInstanceRequestsResult property
        /// </summary>
        /// <param name="cancelSpotInstanceRequestsResult">The Cancel Spot Instance Requests Result.</param>
        /// <returns>this instance</returns>
        public CancelSpotInstanceRequestsResponse WithCancelSpotInstanceRequestsResult(CancelSpotInstanceRequestsResult cancelSpotInstanceRequestsResult)
        {
            this.cancelSpotInstanceRequestsResultField = cancelSpotInstanceRequestsResult;
            return this;
        }

        /// <summary>
        /// Checks if CancelSpotInstanceRequestsResult property is set
        /// </summary>
        /// <returns>true if CancelSpotInstanceRequestsResult property is set</returns>
        public bool IsSetCancelSpotInstanceRequestsResult()
        {
            return this.cancelSpotInstanceRequestsResultField != null;
        }

        /// <summary>
        /// XML Representation for this object
        /// </summary>
        /// <returns>XML String</returns>
        public string ToXML()
        {
            StringBuilder xml = new StringBuilder(1024);
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(this.GetType());
            using (StringWriter sw = new StringWriter(xml))
            {
                serializer.Serialize(sw, this);
            }
            return xml.ToString();
        }
    }
}