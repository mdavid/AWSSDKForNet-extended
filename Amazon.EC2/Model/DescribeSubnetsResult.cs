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
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describe Subnets Result
    /// </summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2009-11-30/", IsNullable = false)]
    public class DescribeSubnetsResult
    {
        private List<Subnet> subnetField;
        /// <summary>
        /// Gets and sets the Subnet property.
        /// List of subnets
        /// </summary>
        [XmlElementAttribute(ElementName = "Subnet")]
        public List<Subnet> Subnet
        {
            get
            {
                if (this.subnetField == null)
                {
                    this.subnetField = new List<Subnet>();
                }
                return this.subnetField;
            }
            set { this.subnetField = value; }
        }

        /// <summary>
        /// Sets the Subnet property
        /// </summary>
        /// <param name="list">List of subnets</param>
        /// <returns>this instance</returns>
        public DescribeSubnetsResult WithSubnet(params Subnet[] list)
        {
            foreach (Subnet item in list)
            {
                Subnet.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if Subnet property is set
        /// </summary>
        /// <returns>true if Subnet property is set</returns>
        public bool IsSetSubnet()
        {
            return (Subnet.Count > 0);
        }

    }
}