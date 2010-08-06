/*******************************************************************************
 *  Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2010-06-01
 *
 */

using System.Xml.Serialization;

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// The SetDistributionConfigResponse contains the distribution's modified
    /// information structure along with any other headers returned by 
    /// CloudFront.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://cloudfront.amazonaws.com/doc/2010-06-01/", IsNullable = false)]
    public class SetDistributionConfigResponse : GetDistributionInfoResponse
    {
        #region ETag

        /// <summary>
        /// Gets and sets the ETag property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ETag")]
        public override string ETag
        {
            set
            {
                this.etagHeader = value;
                CloudFrontDistributionConfig config = Distribution.DistributionConfig;
                if (null != config)
                {
                    config.ETag = value;
                }
            }
        }

        #endregion
    }
}