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
    /// Describe Snapshots Result
    /// </summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2009-11-30/", IsNullable = false)]
    public class DescribeSnapshotsResult
    {
        private List<Snapshot> snapshotField;
        /// <summary>
        /// Gets and sets the Snapshot property.
        /// List of snapshots
        /// </summary>
        [XmlElementAttribute(ElementName = "Snapshot")]
        public List<Snapshot> Snapshot
        {
            get
            {
                if (this.snapshotField == null)
                {
                    this.snapshotField = new List<Snapshot>();
                }
                return this.snapshotField;
            }
            set { this.snapshotField = value; }
        }

        /// <summary>
        /// Sets the Snapshot property
        /// </summary>
        /// <param name="list">List of snapshots</param>
        /// <returns>this instance</returns>
        public DescribeSnapshotsResult WithSnapshot(params Snapshot[] list)
        {
            foreach (Snapshot item in list)
            {
                Snapshot.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if Snapshot property is set
        /// </summary>
        /// <returns>true if Snapshot property is set</returns>
        public bool IsSetSnapshot()
        {
            return (Snapshot.Count > 0);
        }

    }
}