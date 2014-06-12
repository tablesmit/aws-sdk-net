/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.SQS.Model
{
    /// <summary>
    /// Configuration for accessing Amazon DeleteMessageBatch service
    /// </summary>
    public partial class DeleteMessageBatchResponse : DeleteMessageBatchResult
    {
        /// <summary>
        /// Gets and sets the DeleteMessageBatchResult property.
        /// Represents the output of a DeleteMessageBatch operation.
        /// </summary>
        [Obsolete(@"This property has been deprecated. All properties of the DeleteMessageBatchResult class are now available on the DeleteMessageBatchResponse class. You should use the properties on DeleteMessageBatchResponse instead of accessing them through DeleteMessageBatchResult.")]
        public DeleteMessageBatchResult DeleteMessageBatchResult
        {
            get
            {
                return this;
            }
        }
    }
}