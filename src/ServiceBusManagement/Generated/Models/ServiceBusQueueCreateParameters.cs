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
using System.Linq;
using Microsoft.WindowsAzure.Management.ServiceBus.Models;

namespace Microsoft.WindowsAzure.Management.ServiceBus.Models
{
    public partial class ServiceBusQueueCreateParameters
    {
        private System.DateTime? _accessedAt;
        
        /// <summary>
        /// The time the queue was last accessed.
        /// </summary>
        public System.DateTime? AccessedAt
        {
            get { return this._accessedAt; }
            set { this._accessedAt = value; }
        }
        
        private IList<ServiceBusSharedAccessAuthorizationRule> _authorizationRules;
        
        /// <summary>
        /// Gets the authorization rules for the description.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/hh780773.aspx
        /// for more information)
        /// </summary>
        public IList<ServiceBusSharedAccessAuthorizationRule> AuthorizationRules
        {
            get { return this._authorizationRules; }
            set { this._authorizationRules = value; }
        }
        
        private string _autoDeleteOnIdle;
        
        /// <summary>
        /// Implemented.
        /// </summary>
        public string AutoDeleteOnIdle
        {
            get { return this._autoDeleteOnIdle; }
            set { this._autoDeleteOnIdle = value; }
        }
        
        private CountDetails _countDetails;
        
        /// <summary>
        /// Current queue statistics.
        /// </summary>
        public CountDetails CountDetails
        {
            get { return this._countDetails; }
            set { this._countDetails = value; }
        }
        
        private System.DateTime? _createdAt;
        
        /// <summary>
        /// The time the queue was created at.
        /// </summary>
        public System.DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }
        
        private bool _deadLetteringOnMessageExpiration;
        
        /// <summary>
        /// This field controls how the Service Bus handles a message whose TTL
        /// has expired. If it is enabled and a message expires, the Service
        /// Bus moves the message from the queue into the queue’s dead-letter
        /// sub-queue. If disabled, message will be permanently deleted from
        /// the queue. Settable only at queue creation time.* Default: false
        /// (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/hh780773.aspx
        /// for more information)
        /// </summary>
        public bool DeadLetteringOnMessageExpiration
        {
            get { return this._deadLetteringOnMessageExpiration; }
            set { this._deadLetteringOnMessageExpiration = value; }
        }
        
        private string _defaultMessageTimeToLive;
        
        /// <summary>
        /// Depending on whether DeadLettering is enabled, a message is
        /// automatically moved to the DeadLetterQueue or deleted if it has
        /// been stored in the queue for longer than the specified time. This
        /// value is overwritten by a TTL specified on the message if and only
        /// if the message TTL is smaller than the TTL set on the queue. This
        /// value is immutable after the Queue has been created:* Range: 1
        /// second - TimeSpan.MaxValue* Default: TimeSpan.MaxValue  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/hh780773.aspx
        /// for more information)
        /// </summary>
        public string DefaultMessageTimeToLive
        {
            get { return this._defaultMessageTimeToLive; }
            set { this._defaultMessageTimeToLive = value; }
        }
        
        private string _duplicateDetectionHistoryTimeWindow;
        
        /// <summary>
        /// Specifies the time span during which the Service Bus detects
        /// message duplication:* Range: 1 second - 7 days* Default: 10
        /// minutes  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/hh780773.aspx
        /// for more information)
        /// </summary>
        public string DuplicateDetectionHistoryTimeWindow
        {
            get { return this._duplicateDetectionHistoryTimeWindow; }
            set { this._duplicateDetectionHistoryTimeWindow = value; }
        }
        
        private bool _enableBatchedOperations;
        
        /// <summary>
        /// Enables or disables service side batching behavior when performing
        /// operations for the specific queue. When enabled, service bus will
        /// collect/batch multiple operations to the backend to be more
        /// connection efficient. If user wants lower operation latency then
        /// they can disable this feature.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/hh780773.aspx
        /// for more information)
        /// </summary>
        public bool EnableBatchedOperations
        {
            get { return this._enableBatchedOperations; }
            set { this._enableBatchedOperations = value; }
        }
        
        private string _entityAvailabilityStatus;
        
        /// <summary>
        /// The current availability status of the queue.
        /// </summary>
        public string EntityAvailabilityStatus
        {
            get { return this._entityAvailabilityStatus; }
            set { this._entityAvailabilityStatus = value; }
        }
        
        private bool _isAnonymousAccessible;
        
        /// <summary>
        /// Gets whether anonymous access is allowed.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/hh780773.aspx
        /// for more information)
        /// </summary>
        public bool IsAnonymousAccessible
        {
            get { return this._isAnonymousAccessible; }
            set { this._isAnonymousAccessible = value; }
        }
        
        private string _lockDuration;
        
        /// <summary>
        /// Determines the amount of time in seconds in which a message should
        /// be locked for processing by a receiver. After this period, the
        /// message is unlocked and available for consumption by the next
        /// receiver. Settable only at queue creation time:* Range: 0 - 5
        /// minutes. 0 means that the message is not locked* Default: 30
        /// seconds  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/hh780773.aspx
        /// for more information)
        /// </summary>
        public string LockDuration
        {
            get { return this._lockDuration; }
            set { this._lockDuration = value; }
        }
        
        private int _maxDeliveryCount;
        
        /// <summary>
        /// The maximum number of times a message SB will try to deliver before
        /// being dead lettered or discarded.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/hh780773.aspx
        /// for more information)
        /// </summary>
        public int MaxDeliveryCount
        {
            get { return this._maxDeliveryCount; }
            set { this._maxDeliveryCount = value; }
        }
        
        private int _maxSizeInMegabytes;
        
        /// <summary>
        /// Specifies the maximum queue size in megabytes. Any attempt to
        /// enqueue a message that will cause the queue to exceed this value
        /// will fail. You can only set this parameter at queue creation time
        /// using the following values: * Range: 1 - 1024 (valid values are
        /// 1024, 2048, 3072, 4096, 5120) * Default: 1*1024 (valid values are
        /// 1024, 2048, 3072, 4096, 5120)  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/hh780773.aspx
        /// for more information)
        /// </summary>
        public int MaxSizeInMegabytes
        {
            get { return this._maxSizeInMegabytes; }
            set { this._maxSizeInMegabytes = value; }
        }
        
        private int _messageCount;
        
        /// <summary>
        /// Displays the number of messages currently in the queue.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/hh780773.aspx
        /// for more information)
        /// </summary>
        public int MessageCount
        {
            get { return this._messageCount; }
            set { this._messageCount = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// The name of the queue.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private bool _requiresDuplicateDetection;
        
        /// <summary>
        /// Settable only at queue creation time.* Default for durable queue:
        /// false  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/hh780773.aspx
        /// for more information)
        /// </summary>
        public bool RequiresDuplicateDetection
        {
            get { return this._requiresDuplicateDetection; }
            set { this._requiresDuplicateDetection = value; }
        }
        
        private bool _requiresSession;
        
        /// <summary>
        /// Settable only at queue creation time. If set to true, the queue
        /// will be session-aware and only SessionReceiver will be supported.
        /// Session-aware queues are not supported through REST.* Default for
        /// durable queue: false  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/hh780773.aspx
        /// for more information)
        /// </summary>
        public bool RequiresSession
        {
            get { return this._requiresSession; }
            set { this._requiresSession = value; }
        }
        
        private int _sizeInBytes;
        
        /// <summary>
        /// Reflects the actual bytes that messages in the queue currently
        /// occupy toward the queue’s quota.* Range: 0
        /// -MaxTopicSizeinMegaBytes  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/hh780773.aspx
        /// for more information)
        /// </summary>
        public int SizeInBytes
        {
            get { return this._sizeInBytes; }
            set { this._sizeInBytes = value; }
        }
        
        private string _status;
        
        /// <summary>
        /// Gets or sets the current status of the queue (enabled or disabled).
        /// When a queue is disabled, that queue cannot send or receive
        /// messages.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/hh780773.aspx
        /// for more information)
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }
        
        private bool _supportOrdering;
        
        /// <summary>
        /// Gets or sets whether the queue supports ordering.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/hh780773.aspx
        /// for more information)
        /// </summary>
        public bool SupportOrdering
        {
            get { return this._supportOrdering; }
            set { this._supportOrdering = value; }
        }
        
        private System.DateTime? _updatedAt;
        
        /// <summary>
        /// The time the queue was last updated.
        /// </summary>
        public System.DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ServiceBusQueueCreateParameters
        /// class.
        /// </summary>
        public ServiceBusQueueCreateParameters()
        {
            this._authorizationRules = new List<ServiceBusSharedAccessAuthorizationRule>();
        }
    }
}
