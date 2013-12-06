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
using System.Linq;

namespace Microsoft.WindowsAzure.Management.Monitoring.Alerts.Models
{
    /// <summary>
    /// An alert incident indicates the activation status of an alert rule.
    /// </summary>
    public partial class Incident
    {
        private DateTime _activatedTime;
        
        /// <summary>
        /// The time at which the incident got activated.
        /// </summary>
        public DateTime ActivatedTime
        {
            get { return this._activatedTime; }
            set { this._activatedTime = value; }
        }
        
        private string _id;
        
        /// <summary>
        /// Incident identifier.
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }
        
        private bool _isActive;
        
        /// <summary>
        /// A boolean to indicate whether the incident is active or resolved.
        /// </summary>
        public bool IsActive
        {
            get { return this._isActive; }
            set { this._isActive = value; }
        }
        
        private System.DateTime? _resolvedTime;
        
        /// <summary>
        /// The time at which the incident got resolved. If null, it means the
        /// incident is still active.
        /// </summary>
        public System.DateTime? ResolvedTime
        {
            get { return this._resolvedTime; }
            set { this._resolvedTime = value; }
        }
        
        private string _ruleId;
        
        /// <summary>
        /// Rule identifier that is associated with the incident.
        /// </summary>
        public string RuleId
        {
            get { return this._ruleId; }
            set { this._ruleId = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the Incident class.
        /// </summary>
        public Incident()
        {
        }
    }
}
