// Copyright 2020 Confluent Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
// Refer to LICENSE for more information.

using System;


namespace Confluent.Kafka
{
    /// <summary>
    ///     Represents an error where the operation that caused it
    ///     may be retried.
    /// </summary>
    public class KafkaRetriableException : KafkaException
    {
        /// <summary>
        ///     Initialize a new instance of KafkaRetriableException
        ///     based on an existing Error instance.
        /// </summary>
        /// <param name="error">
        ///     The Error instance.
        /// </param>
        public KafkaRetriableException(Error error)
            : base(error)
        {
        }
    }
}