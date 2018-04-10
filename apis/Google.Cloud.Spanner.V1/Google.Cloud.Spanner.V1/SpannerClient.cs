// Copyright 2018 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using proto = Google.Protobuf;
using protowkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using s = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.Spanner.V1
{
    /// <summary>
    /// Settings for a <see cref="SpannerClient"/>.
    /// </summary>
    public sealed partial class SpannerSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="SpannerSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="SpannerSettings"/>.
        /// </returns>
        public static SpannerSettings GetDefault() => new SpannerSettings();

        /// <summary>
        /// Constructs a new <see cref="SpannerSettings"/> object with default settings.
        /// </summary>
        public SpannerSettings() { }

        private SpannerSettings(SpannerSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateSessionSettings = existing.CreateSessionSettings;
            GetSessionSettings = existing.GetSessionSettings;
            ListSessionsSettings = existing.ListSessionsSettings;
            DeleteSessionSettings = existing.DeleteSessionSettings;
            ExecuteSqlSettings = existing.ExecuteSqlSettings;
            ExecuteStreamingSqlSettings = existing.ExecuteStreamingSqlSettings;
            ReadSettings = existing.ReadSettings;
            StreamingReadSettings = existing.StreamingReadSettings;
            BeginTransactionSettings = existing.BeginTransactionSettings;
            CommitSettings = existing.CommitSettings;
            RollbackSettings = existing.RollbackSettings;
            PartitionQuerySettings = existing.PartitionQuerySettings;
            PartitionReadSettings = existing.PartitionReadSettings;
            OnCopy(existing);
        }

        partial void OnCopy(SpannerSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="SpannerClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// The eligible RPC <see cref="grpccore::StatusCode"/>s for retry for "Idempotent" RPC methods are:
        /// <list type="bullet">
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// </remarks>
        public static s::Predicate<grpccore::RpcException> IdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "NonIdempotent" <see cref="SpannerClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static s::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "LongRunning" <see cref="SpannerClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// The eligible RPC <see cref="grpccore::StatusCode"/>s for retry for "LongRunning" RPC methods are:
        /// <list type="bullet">
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// </remarks>
        public static s::Predicate<grpccore::RpcException> LongRunningRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable);

        /// <summary>
        /// "Default" retry backoff for <see cref="SpannerClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="SpannerClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="SpannerClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 1000 milliseconds</description></item>
        /// <item><description>Maximum delay: 32000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.3</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetDefaultRetryBackoff() => new gaxgrpc::BackoffSettings(
            delay: s::TimeSpan.FromMilliseconds(1000),
            maxDelay: s::TimeSpan.FromMilliseconds(32000),
            delayMultiplier: 1.3
        );

        /// <summary>
        /// "Default" timeout backoff for <see cref="SpannerClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="SpannerClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="SpannerClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 60000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetDefaultTimeoutBackoff() => new gaxgrpc::BackoffSettings(
            delay: s::TimeSpan.FromMilliseconds(60000),
            maxDelay: s::TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// "LongRunning" retry backoff for <see cref="SpannerClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "LongRunning" retry backoff for <see cref="SpannerClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "LongRunning" retry backoff for <see cref="SpannerClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 1000 milliseconds</description></item>
        /// <item><description>Maximum delay: 32000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.3</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetLongRunningRetryBackoff() => new gaxgrpc::BackoffSettings(
            delay: s::TimeSpan.FromMilliseconds(1000),
            maxDelay: s::TimeSpan.FromMilliseconds(32000),
            delayMultiplier: 1.3
        );

        /// <summary>
        /// "LongRunning" timeout backoff for <see cref="SpannerClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "LongRunning" timeout backoff for <see cref="SpannerClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "LongRunning" timeout backoff for <see cref="SpannerClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 3600000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 3600000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetLongRunningTimeoutBackoff() => new gaxgrpc::BackoffSettings(
            delay: s::TimeSpan.FromMilliseconds(3600000),
            maxDelay: s::TimeSpan.FromMilliseconds(3600000),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SpannerClient.CreateSession</c> and <c>SpannerClient.CreateSessionAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SpannerClient.CreateSession</c> and
        /// <c>SpannerClient.CreateSessionAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 32000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings CreateSessionSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(s::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SpannerClient.GetSession</c> and <c>SpannerClient.GetSessionAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SpannerClient.GetSession</c> and
        /// <c>SpannerClient.GetSessionAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 32000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings GetSessionSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(s::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SpannerClient.ListSessions</c> and <c>SpannerClient.ListSessionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SpannerClient.ListSessions</c> and
        /// <c>SpannerClient.ListSessionsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 32000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings ListSessionsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(s::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SpannerClient.DeleteSession</c> and <c>SpannerClient.DeleteSessionAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SpannerClient.DeleteSession</c> and
        /// <c>SpannerClient.DeleteSessionAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 32000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSessionSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(s::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SpannerClient.ExecuteSql</c> and <c>SpannerClient.ExecuteSqlAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SpannerClient.ExecuteSql</c> and
        /// <c>SpannerClient.ExecuteSqlAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 32000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings ExecuteSqlSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(s::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for calls to <c>SpannerClient.ExecuteStreamingSql</c>.
        /// </summary>
        /// <remarks>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings ExecuteStreamingSqlSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromTimeout(s::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SpannerClient.Read</c> and <c>SpannerClient.ReadAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SpannerClient.Read</c> and
        /// <c>SpannerClient.ReadAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 32000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings ReadSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(s::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for calls to <c>SpannerClient.StreamingRead</c>.
        /// </summary>
        /// <remarks>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings StreamingReadSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromTimeout(s::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SpannerClient.BeginTransaction</c> and <c>SpannerClient.BeginTransactionAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SpannerClient.BeginTransaction</c> and
        /// <c>SpannerClient.BeginTransactionAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 32000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings BeginTransactionSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(s::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SpannerClient.Commit</c> and <c>SpannerClient.CommitAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SpannerClient.Commit</c> and
        /// <c>SpannerClient.CommitAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 32000 milliseconds</description></item>
        /// <item><description>Initial timeout: 3600000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 3600000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 3600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings CommitSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetLongRunningRetryBackoff(),
                timeoutBackoff: GetLongRunningTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(s::TimeSpan.FromMilliseconds(3600000)),
                retryFilter: LongRunningRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SpannerClient.Rollback</c> and <c>SpannerClient.RollbackAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SpannerClient.Rollback</c> and
        /// <c>SpannerClient.RollbackAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 32000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings RollbackSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(s::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SpannerClient.PartitionQuery</c> and <c>SpannerClient.PartitionQueryAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SpannerClient.PartitionQuery</c> and
        /// <c>SpannerClient.PartitionQueryAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 32000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings PartitionQuerySettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(s::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SpannerClient.PartitionRead</c> and <c>SpannerClient.PartitionReadAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SpannerClient.PartitionRead</c> and
        /// <c>SpannerClient.PartitionReadAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 32000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings PartitionReadSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(s::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="SpannerSettings"/> object.</returns>
        public SpannerSettings Clone() => new SpannerSettings(this);
    }

    /// <summary>
    /// Spanner client wrapper, for convenient use.
    /// </summary>
    public abstract partial class SpannerClient
    {
        /// <summary>
        /// The default endpoint for the Spanner service, which is a host of "spanner.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("spanner.googleapis.com", 443);

        /// <summary>
        /// The default Spanner scopes.
        /// </summary>
        /// <remarks>
        /// The default Spanner scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/spanner.data"</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/spanner.data",
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        // Note: we could have parameterless overloads of Create and CreateAsync,
        // documented to just use the default endpoint, settings and credentials.
        // Pros:
        // - Might be more reassuring on first use
        // - Allows method group conversions
        // Con: overloads!

        /// <summary>
        /// Asynchronously creates a <see cref="SpannerClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="SpannerSettings"/>.</param>
        /// <returns>The task representing the created <see cref="SpannerClient"/>.</returns>
        public static async stt::Task<SpannerClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, SpannerSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="SpannerClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="SpannerSettings"/>.</param>
        /// <returns>The created <see cref="SpannerClient"/>.</returns>
        public static SpannerClient Create(gaxgrpc::ServiceEndpoint endpoint = null, SpannerSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="SpannerClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="SpannerSettings"/>.</param>
        /// <returns>The created <see cref="SpannerClient"/>.</returns>
        public static SpannerClient Create(grpccore::Channel channel, SpannerSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            Spanner.SpannerClient grpcClient = new Spanner.SpannerClient(channel);
            return new SpannerClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, SpannerSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, SpannerSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, SpannerSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, SpannerSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC Spanner client.
        /// </summary>
        public virtual Spanner.SpannerClient GrpcClient
        {
            get { throw new s::NotImplementedException(); }
        }

        /// <summary>
        /// Creates a new session. A session can be used to perform
        /// transactions that read and/or modify data in a Cloud Spanner database.
        /// Sessions are meant to be reused for many consecutive
        /// transactions.
        ///
        /// Sessions can only execute one transaction at a time. To execute
        /// multiple concurrent read-write/write-only transactions, create
        /// multiple sessions. Note that standalone reads and queries use a
        /// transaction internally, and count toward the one transaction
        /// limit.
        ///
        /// Cloud Spanner limits the number of sessions that can exist at any given
        /// time; thus, it is a good idea to delete idle and/or unneeded sessions.
        /// Aside from explicit deletes, Cloud Spanner can delete sessions for which no
        /// operations are sent for more than an hour. If a session is deleted,
        /// requests to it return `NOT_FOUND`.
        ///
        /// Idle sessions can be kept alive by sending a trivial SQL query
        /// periodically, e.g., `"SELECT 1"`.
        /// </summary>
        /// <param name="database">
        /// Required. The database in which the new session is created.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Session> CreateSessionAsync(
            DatabaseName database,
            gaxgrpc::CallSettings callSettings = null) => CreateSessionAsync(
                new CreateSessionRequest
                {
                    DatabaseAsDatabaseName = gax::GaxPreconditions.CheckNotNull(database, nameof(database)),
                },
                callSettings);

        /// <summary>
        /// Creates a new session. A session can be used to perform
        /// transactions that read and/or modify data in a Cloud Spanner database.
        /// Sessions are meant to be reused for many consecutive
        /// transactions.
        ///
        /// Sessions can only execute one transaction at a time. To execute
        /// multiple concurrent read-write/write-only transactions, create
        /// multiple sessions. Note that standalone reads and queries use a
        /// transaction internally, and count toward the one transaction
        /// limit.
        ///
        /// Cloud Spanner limits the number of sessions that can exist at any given
        /// time; thus, it is a good idea to delete idle and/or unneeded sessions.
        /// Aside from explicit deletes, Cloud Spanner can delete sessions for which no
        /// operations are sent for more than an hour. If a session is deleted,
        /// requests to it return `NOT_FOUND`.
        ///
        /// Idle sessions can be kept alive by sending a trivial SQL query
        /// periodically, e.g., `"SELECT 1"`.
        /// </summary>
        /// <param name="database">
        /// Required. The database in which the new session is created.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Session> CreateSessionAsync(
            DatabaseName database,
            st::CancellationToken cancellationToken) => CreateSessionAsync(
                database,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new session. A session can be used to perform
        /// transactions that read and/or modify data in a Cloud Spanner database.
        /// Sessions are meant to be reused for many consecutive
        /// transactions.
        ///
        /// Sessions can only execute one transaction at a time. To execute
        /// multiple concurrent read-write/write-only transactions, create
        /// multiple sessions. Note that standalone reads and queries use a
        /// transaction internally, and count toward the one transaction
        /// limit.
        ///
        /// Cloud Spanner limits the number of sessions that can exist at any given
        /// time; thus, it is a good idea to delete idle and/or unneeded sessions.
        /// Aside from explicit deletes, Cloud Spanner can delete sessions for which no
        /// operations are sent for more than an hour. If a session is deleted,
        /// requests to it return `NOT_FOUND`.
        ///
        /// Idle sessions can be kept alive by sending a trivial SQL query
        /// periodically, e.g., `"SELECT 1"`.
        /// </summary>
        /// <param name="database">
        /// Required. The database in which the new session is created.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Session CreateSession(
            DatabaseName database,
            gaxgrpc::CallSettings callSettings = null) => CreateSession(
                new CreateSessionRequest
                {
                    DatabaseAsDatabaseName = gax::GaxPreconditions.CheckNotNull(database, nameof(database)),
                },
                callSettings);

        /// <summary>
        /// Creates a new session. A session can be used to perform
        /// transactions that read and/or modify data in a Cloud Spanner database.
        /// Sessions are meant to be reused for many consecutive
        /// transactions.
        ///
        /// Sessions can only execute one transaction at a time. To execute
        /// multiple concurrent read-write/write-only transactions, create
        /// multiple sessions. Note that standalone reads and queries use a
        /// transaction internally, and count toward the one transaction
        /// limit.
        ///
        /// Cloud Spanner limits the number of sessions that can exist at any given
        /// time; thus, it is a good idea to delete idle and/or unneeded sessions.
        /// Aside from explicit deletes, Cloud Spanner can delete sessions for which no
        /// operations are sent for more than an hour. If a session is deleted,
        /// requests to it return `NOT_FOUND`.
        ///
        /// Idle sessions can be kept alive by sending a trivial SQL query
        /// periodically, e.g., `"SELECT 1"`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Session> CreateSessionAsync(
            CreateSessionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new s::NotImplementedException();
        }

        /// <summary>
        /// Creates a new session. A session can be used to perform
        /// transactions that read and/or modify data in a Cloud Spanner database.
        /// Sessions are meant to be reused for many consecutive
        /// transactions.
        ///
        /// Sessions can only execute one transaction at a time. To execute
        /// multiple concurrent read-write/write-only transactions, create
        /// multiple sessions. Note that standalone reads and queries use a
        /// transaction internally, and count toward the one transaction
        /// limit.
        ///
        /// Cloud Spanner limits the number of sessions that can exist at any given
        /// time; thus, it is a good idea to delete idle and/or unneeded sessions.
        /// Aside from explicit deletes, Cloud Spanner can delete sessions for which no
        /// operations are sent for more than an hour. If a session is deleted,
        /// requests to it return `NOT_FOUND`.
        ///
        /// Idle sessions can be kept alive by sending a trivial SQL query
        /// periodically, e.g., `"SELECT 1"`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Session> CreateSessionAsync(
            CreateSessionRequest request,
            st::CancellationToken cancellationToken) => CreateSessionAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new session. A session can be used to perform
        /// transactions that read and/or modify data in a Cloud Spanner database.
        /// Sessions are meant to be reused for many consecutive
        /// transactions.
        ///
        /// Sessions can only execute one transaction at a time. To execute
        /// multiple concurrent read-write/write-only transactions, create
        /// multiple sessions. Note that standalone reads and queries use a
        /// transaction internally, and count toward the one transaction
        /// limit.
        ///
        /// Cloud Spanner limits the number of sessions that can exist at any given
        /// time; thus, it is a good idea to delete idle and/or unneeded sessions.
        /// Aside from explicit deletes, Cloud Spanner can delete sessions for which no
        /// operations are sent for more than an hour. If a session is deleted,
        /// requests to it return `NOT_FOUND`.
        ///
        /// Idle sessions can be kept alive by sending a trivial SQL query
        /// periodically, e.g., `"SELECT 1"`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Session CreateSession(
            CreateSessionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new s::NotImplementedException();
        }

        /// <summary>
        /// Gets a session. Returns `NOT_FOUND` if the session does not exist.
        /// This is mainly useful for determining whether a session is still
        /// alive.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the session to retrieve.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Session> GetSessionAsync(
            SessionName name,
            gaxgrpc::CallSettings callSettings = null) => GetSessionAsync(
                new GetSessionRequest
                {
                    SessionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets a session. Returns `NOT_FOUND` if the session does not exist.
        /// This is mainly useful for determining whether a session is still
        /// alive.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the session to retrieve.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Session> GetSessionAsync(
            SessionName name,
            st::CancellationToken cancellationToken) => GetSessionAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a session. Returns `NOT_FOUND` if the session does not exist.
        /// This is mainly useful for determining whether a session is still
        /// alive.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the session to retrieve.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Session GetSession(
            SessionName name,
            gaxgrpc::CallSettings callSettings = null) => GetSession(
                new GetSessionRequest
                {
                    SessionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets a session. Returns `NOT_FOUND` if the session does not exist.
        /// This is mainly useful for determining whether a session is still
        /// alive.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Session> GetSessionAsync(
            GetSessionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new s::NotImplementedException();
        }

        /// <summary>
        /// Gets a session. Returns `NOT_FOUND` if the session does not exist.
        /// This is mainly useful for determining whether a session is still
        /// alive.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Session> GetSessionAsync(
            GetSessionRequest request,
            st::CancellationToken cancellationToken) => GetSessionAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a session. Returns `NOT_FOUND` if the session does not exist.
        /// This is mainly useful for determining whether a session is still
        /// alive.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Session GetSession(
            GetSessionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new s::NotImplementedException();
        }

        /// <summary>
        /// Lists all sessions in a given database.
        /// </summary>
        /// <param name="database">
        /// Required. The database in which to list sessions.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Session"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListSessionsResponse, Session> ListSessionsAsync(
            string database,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListSessionsAsync(
                new ListSessionsRequest
                {
                    Database = gax::GaxPreconditions.CheckNotNullOrEmpty(database, nameof(database)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists all sessions in a given database.
        /// </summary>
        /// <param name="database">
        /// Required. The database in which to list sessions.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Session"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListSessionsResponse, Session> ListSessions(
            string database,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListSessions(
                new ListSessionsRequest
                {
                    Database = gax::GaxPreconditions.CheckNotNullOrEmpty(database, nameof(database)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists all sessions in a given database.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Session"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListSessionsResponse, Session> ListSessionsAsync(
            ListSessionsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new s::NotImplementedException();
        }

        /// <summary>
        /// Lists all sessions in a given database.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Session"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListSessionsResponse, Session> ListSessions(
            ListSessionsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new s::NotImplementedException();
        }

        /// <summary>
        /// Ends a session, releasing server resources associated with it.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the session to delete.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteSessionAsync(
            SessionName name,
            gaxgrpc::CallSettings callSettings = null) => DeleteSessionAsync(
                new DeleteSessionRequest
                {
                    SessionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Ends a session, releasing server resources associated with it.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the session to delete.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteSessionAsync(
            SessionName name,
            st::CancellationToken cancellationToken) => DeleteSessionAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Ends a session, releasing server resources associated with it.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the session to delete.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteSession(
            SessionName name,
            gaxgrpc::CallSettings callSettings = null) => DeleteSession(
                new DeleteSessionRequest
                {
                    SessionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Ends a session, releasing server resources associated with it.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteSessionAsync(
            DeleteSessionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new s::NotImplementedException();
        }

        /// <summary>
        /// Ends a session, releasing server resources associated with it.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteSessionAsync(
            DeleteSessionRequest request,
            st::CancellationToken cancellationToken) => DeleteSessionAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Ends a session, releasing server resources associated with it.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteSession(
            DeleteSessionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new s::NotImplementedException();
        }

        /// <summary>
        /// Executes an SQL query, returning all rows in a single reply. This
        /// method cannot be used to return a result set larger than 10 MiB;
        /// if the query yields more data than that, the query fails with
        /// a `FAILED_PRECONDITION` error.
        ///
        /// Queries inside read-write transactions might return `ABORTED`. If
        /// this occurs, the application should restart the transaction from
        /// the beginning. See [Transaction][google.spanner.v1.Transaction] for more details.
        ///
        /// Larger result sets can be fetched in streaming fashion by calling
        /// [ExecuteStreamingSql][google.spanner.v1.Spanner.ExecuteStreamingSql] instead.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ResultSet> ExecuteSqlAsync(
            ExecuteSqlRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new s::NotImplementedException();
        }

        /// <summary>
        /// Executes an SQL query, returning all rows in a single reply. This
        /// method cannot be used to return a result set larger than 10 MiB;
        /// if the query yields more data than that, the query fails with
        /// a `FAILED_PRECONDITION` error.
        ///
        /// Queries inside read-write transactions might return `ABORTED`. If
        /// this occurs, the application should restart the transaction from
        /// the beginning. See [Transaction][google.spanner.v1.Transaction] for more details.
        ///
        /// Larger result sets can be fetched in streaming fashion by calling
        /// [ExecuteStreamingSql][google.spanner.v1.Spanner.ExecuteStreamingSql] instead.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ResultSet> ExecuteSqlAsync(
            ExecuteSqlRequest request,
            st::CancellationToken cancellationToken) => ExecuteSqlAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Executes an SQL query, returning all rows in a single reply. This
        /// method cannot be used to return a result set larger than 10 MiB;
        /// if the query yields more data than that, the query fails with
        /// a `FAILED_PRECONDITION` error.
        ///
        /// Queries inside read-write transactions might return `ABORTED`. If
        /// this occurs, the application should restart the transaction from
        /// the beginning. See [Transaction][google.spanner.v1.Transaction] for more details.
        ///
        /// Larger result sets can be fetched in streaming fashion by calling
        /// [ExecuteStreamingSql][google.spanner.v1.Spanner.ExecuteStreamingSql] instead.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ResultSet ExecuteSql(
            ExecuteSqlRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new s::NotImplementedException();
        }

        /// <summary>
        /// Like [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql], except returns the result
        /// set as a stream. Unlike [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql], there
        /// is no limit on the size of the returned result set. However, no
        /// individual row in the result set can exceed 100 MiB, and no
        /// column value can exceed 10 MiB.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The server stream.
        /// </returns>
        public virtual ExecuteStreamingSqlStream ExecuteStreamingSql(
            ExecuteSqlRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new s::NotImplementedException();
        }

        /// <summary>
        /// Server streaming methods for <c>ExecuteStreamingSql</c>.
        /// </summary>
        public abstract partial class ExecuteStreamingSqlStream : gaxgrpc::ServerStreamingBase<PartialResultSet>
        {
        }

        /// <summary>
        /// Reads rows from the database using key lookups and scans, as a
        /// simple key/value style alternative to
        /// [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql].  This method cannot be used to
        /// return a result set larger than 10 MiB; if the read matches more
        /// data than that, the read fails with a `FAILED_PRECONDITION`
        /// error.
        ///
        /// Reads inside read-write transactions might return `ABORTED`. If
        /// this occurs, the application should restart the transaction from
        /// the beginning. See [Transaction][google.spanner.v1.Transaction] for more details.
        ///
        /// Larger result sets can be yielded in streaming fashion by calling
        /// [StreamingRead][google.spanner.v1.Spanner.StreamingRead] instead.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ResultSet> ReadAsync(
            ReadRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new s::NotImplementedException();
        }

        /// <summary>
        /// Reads rows from the database using key lookups and scans, as a
        /// simple key/value style alternative to
        /// [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql].  This method cannot be used to
        /// return a result set larger than 10 MiB; if the read matches more
        /// data than that, the read fails with a `FAILED_PRECONDITION`
        /// error.
        ///
        /// Reads inside read-write transactions might return `ABORTED`. If
        /// this occurs, the application should restart the transaction from
        /// the beginning. See [Transaction][google.spanner.v1.Transaction] for more details.
        ///
        /// Larger result sets can be yielded in streaming fashion by calling
        /// [StreamingRead][google.spanner.v1.Spanner.StreamingRead] instead.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ResultSet> ReadAsync(
            ReadRequest request,
            st::CancellationToken cancellationToken) => ReadAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Reads rows from the database using key lookups and scans, as a
        /// simple key/value style alternative to
        /// [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql].  This method cannot be used to
        /// return a result set larger than 10 MiB; if the read matches more
        /// data than that, the read fails with a `FAILED_PRECONDITION`
        /// error.
        ///
        /// Reads inside read-write transactions might return `ABORTED`. If
        /// this occurs, the application should restart the transaction from
        /// the beginning. See [Transaction][google.spanner.v1.Transaction] for more details.
        ///
        /// Larger result sets can be yielded in streaming fashion by calling
        /// [StreamingRead][google.spanner.v1.Spanner.StreamingRead] instead.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ResultSet Read(
            ReadRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new s::NotImplementedException();
        }

        /// <summary>
        /// Like [Read][google.spanner.v1.Spanner.Read], except returns the result set as a
        /// stream. Unlike [Read][google.spanner.v1.Spanner.Read], there is no limit on the
        /// size of the returned result set. However, no individual row in
        /// the result set can exceed 100 MiB, and no column value can exceed
        /// 10 MiB.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The server stream.
        /// </returns>
        public virtual StreamingReadStream StreamingRead(
            ReadRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new s::NotImplementedException();
        }

        /// <summary>
        /// Server streaming methods for <c>StreamingRead</c>.
        /// </summary>
        public abstract partial class StreamingReadStream : gaxgrpc::ServerStreamingBase<PartialResultSet>
        {
        }

        /// <summary>
        /// Begins a new transaction. This step can often be skipped:
        /// [Read][google.spanner.v1.Spanner.Read], [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql] and
        /// [Commit][google.spanner.v1.Spanner.Commit] can begin a new transaction as a
        /// side-effect.
        /// </summary>
        /// <param name="session">
        /// Required. The session in which the transaction runs.
        /// </param>
        /// <param name="options">
        /// Required. Options for the new transaction.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Transaction> BeginTransactionAsync(
            SessionName session,
            TransactionOptions options,
            gaxgrpc::CallSettings callSettings = null) => BeginTransactionAsync(
                new BeginTransactionRequest
                {
                    SessionAsSessionName = gax::GaxPreconditions.CheckNotNull(session, nameof(session)),
                    Options = gax::GaxPreconditions.CheckNotNull(options, nameof(options)),
                },
                callSettings);

        /// <summary>
        /// Begins a new transaction. This step can often be skipped:
        /// [Read][google.spanner.v1.Spanner.Read], [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql] and
        /// [Commit][google.spanner.v1.Spanner.Commit] can begin a new transaction as a
        /// side-effect.
        /// </summary>
        /// <param name="session">
        /// Required. The session in which the transaction runs.
        /// </param>
        /// <param name="options">
        /// Required. Options for the new transaction.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Transaction> BeginTransactionAsync(
            SessionName session,
            TransactionOptions options,
            st::CancellationToken cancellationToken) => BeginTransactionAsync(
                session,
                options,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Begins a new transaction. This step can often be skipped:
        /// [Read][google.spanner.v1.Spanner.Read], [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql] and
        /// [Commit][google.spanner.v1.Spanner.Commit] can begin a new transaction as a
        /// side-effect.
        /// </summary>
        /// <param name="session">
        /// Required. The session in which the transaction runs.
        /// </param>
        /// <param name="options">
        /// Required. Options for the new transaction.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Transaction BeginTransaction(
            SessionName session,
            TransactionOptions options,
            gaxgrpc::CallSettings callSettings = null) => BeginTransaction(
                new BeginTransactionRequest
                {
                    SessionAsSessionName = gax::GaxPreconditions.CheckNotNull(session, nameof(session)),
                    Options = gax::GaxPreconditions.CheckNotNull(options, nameof(options)),
                },
                callSettings);

        /// <summary>
        /// Begins a new transaction. This step can often be skipped:
        /// [Read][google.spanner.v1.Spanner.Read], [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql] and
        /// [Commit][google.spanner.v1.Spanner.Commit] can begin a new transaction as a
        /// side-effect.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Transaction> BeginTransactionAsync(
            BeginTransactionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new s::NotImplementedException();
        }

        /// <summary>
        /// Begins a new transaction. This step can often be skipped:
        /// [Read][google.spanner.v1.Spanner.Read], [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql] and
        /// [Commit][google.spanner.v1.Spanner.Commit] can begin a new transaction as a
        /// side-effect.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Transaction> BeginTransactionAsync(
            BeginTransactionRequest request,
            st::CancellationToken cancellationToken) => BeginTransactionAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Begins a new transaction. This step can often be skipped:
        /// [Read][google.spanner.v1.Spanner.Read], [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql] and
        /// [Commit][google.spanner.v1.Spanner.Commit] can begin a new transaction as a
        /// side-effect.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Transaction BeginTransaction(
            BeginTransactionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new s::NotImplementedException();
        }

        /// <summary>
        /// Commits a transaction. The request includes the mutations to be
        /// applied to rows in the database.
        ///
        /// `Commit` might return an `ABORTED` error. This can occur at any time;
        /// commonly, the cause is conflicts with concurrent
        /// transactions. However, it can also happen for a variety of other
        /// reasons. If `Commit` returns `ABORTED`, the caller should re-attempt
        /// the transaction from the beginning, re-using the same session.
        /// </summary>
        /// <param name="session">
        /// Required. The session in which the transaction to be committed is running.
        /// </param>
        /// <param name="transactionId">
        /// Commit a previously-started transaction.
        /// </param>
        /// <param name="mutations">
        /// The mutations to be executed when this transaction commits. All
        /// mutations are applied atomically, in the order they appear in
        /// this list.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<CommitResponse> CommitAsync(
            SessionName session,
            proto::ByteString transactionId,
            scg::IEnumerable<Mutation> mutations,
            gaxgrpc::CallSettings callSettings = null) => CommitAsync(
                new CommitRequest
                {
                    SessionAsSessionName = gax::GaxPreconditions.CheckNotNull(session, nameof(session)),
                    TransactionId = transactionId ?? Google.Protobuf.ByteString.Empty, // Optional
                    Mutations = { gax::GaxPreconditions.CheckNotNull(mutations, nameof(mutations)) },
                },
                callSettings);

        /// <summary>
        /// Commits a transaction. The request includes the mutations to be
        /// applied to rows in the database.
        ///
        /// `Commit` might return an `ABORTED` error. This can occur at any time;
        /// commonly, the cause is conflicts with concurrent
        /// transactions. However, it can also happen for a variety of other
        /// reasons. If `Commit` returns `ABORTED`, the caller should re-attempt
        /// the transaction from the beginning, re-using the same session.
        /// </summary>
        /// <param name="session">
        /// Required. The session in which the transaction to be committed is running.
        /// </param>
        /// <param name="transactionId">
        /// Commit a previously-started transaction.
        /// </param>
        /// <param name="mutations">
        /// The mutations to be executed when this transaction commits. All
        /// mutations are applied atomically, in the order they appear in
        /// this list.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<CommitResponse> CommitAsync(
            SessionName session,
            proto::ByteString transactionId,
            scg::IEnumerable<Mutation> mutations,
            st::CancellationToken cancellationToken) => CommitAsync(
                session,
                transactionId,
                mutations,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Commits a transaction. The request includes the mutations to be
        /// applied to rows in the database.
        ///
        /// `Commit` might return an `ABORTED` error. This can occur at any time;
        /// commonly, the cause is conflicts with concurrent
        /// transactions. However, it can also happen for a variety of other
        /// reasons. If `Commit` returns `ABORTED`, the caller should re-attempt
        /// the transaction from the beginning, re-using the same session.
        /// </summary>
        /// <param name="session">
        /// Required. The session in which the transaction to be committed is running.
        /// </param>
        /// <param name="transactionId">
        /// Commit a previously-started transaction.
        /// </param>
        /// <param name="mutations">
        /// The mutations to be executed when this transaction commits. All
        /// mutations are applied atomically, in the order they appear in
        /// this list.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual CommitResponse Commit(
            SessionName session,
            proto::ByteString transactionId,
            scg::IEnumerable<Mutation> mutations,
            gaxgrpc::CallSettings callSettings = null) => Commit(
                new CommitRequest
                {
                    SessionAsSessionName = gax::GaxPreconditions.CheckNotNull(session, nameof(session)),
                    TransactionId = transactionId ?? Google.Protobuf.ByteString.Empty, // Optional
                    Mutations = { gax::GaxPreconditions.CheckNotNull(mutations, nameof(mutations)) },
                },
                callSettings);

        /// <summary>
        /// Commits a transaction. The request includes the mutations to be
        /// applied to rows in the database.
        ///
        /// `Commit` might return an `ABORTED` error. This can occur at any time;
        /// commonly, the cause is conflicts with concurrent
        /// transactions. However, it can also happen for a variety of other
        /// reasons. If `Commit` returns `ABORTED`, the caller should re-attempt
        /// the transaction from the beginning, re-using the same session.
        /// </summary>
        /// <param name="session">
        /// Required. The session in which the transaction to be committed is running.
        /// </param>
        /// <param name="singleUseTransaction">
        /// Execute mutations in a temporary transaction. Note that unlike
        /// commit of a previously-started transaction, commit with a
        /// temporary transaction is non-idempotent. That is, if the
        /// `CommitRequest` is sent to Cloud Spanner more than once (for
        /// instance, due to retries in the application, or in the
        /// transport library), it is possible that the mutations are
        /// executed more than once. If this is undesirable, use
        /// [BeginTransaction][google.spanner.v1.Spanner.BeginTransaction] and
        /// [Commit][google.spanner.v1.Spanner.Commit] instead.
        /// </param>
        /// <param name="mutations">
        /// The mutations to be executed when this transaction commits. All
        /// mutations are applied atomically, in the order they appear in
        /// this list.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<CommitResponse> CommitAsync(
            SessionName session,
            TransactionOptions singleUseTransaction,
            scg::IEnumerable<Mutation> mutations,
            gaxgrpc::CallSettings callSettings = null) => CommitAsync(
                new CommitRequest
                {
                    SessionAsSessionName = gax::GaxPreconditions.CheckNotNull(session, nameof(session)),
                    SingleUseTransaction = singleUseTransaction, // Optional
                    Mutations = { gax::GaxPreconditions.CheckNotNull(mutations, nameof(mutations)) },
                },
                callSettings);

        /// <summary>
        /// Commits a transaction. The request includes the mutations to be
        /// applied to rows in the database.
        ///
        /// `Commit` might return an `ABORTED` error. This can occur at any time;
        /// commonly, the cause is conflicts with concurrent
        /// transactions. However, it can also happen for a variety of other
        /// reasons. If `Commit` returns `ABORTED`, the caller should re-attempt
        /// the transaction from the beginning, re-using the same session.
        /// </summary>
        /// <param name="session">
        /// Required. The session in which the transaction to be committed is running.
        /// </param>
        /// <param name="singleUseTransaction">
        /// Execute mutations in a temporary transaction. Note that unlike
        /// commit of a previously-started transaction, commit with a
        /// temporary transaction is non-idempotent. That is, if the
        /// `CommitRequest` is sent to Cloud Spanner more than once (for
        /// instance, due to retries in the application, or in the
        /// transport library), it is possible that the mutations are
        /// executed more than once. If this is undesirable, use
        /// [BeginTransaction][google.spanner.v1.Spanner.BeginTransaction] and
        /// [Commit][google.spanner.v1.Spanner.Commit] instead.
        /// </param>
        /// <param name="mutations">
        /// The mutations to be executed when this transaction commits. All
        /// mutations are applied atomically, in the order they appear in
        /// this list.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<CommitResponse> CommitAsync(
            SessionName session,
            TransactionOptions singleUseTransaction,
            scg::IEnumerable<Mutation> mutations,
            st::CancellationToken cancellationToken) => CommitAsync(
                session,
                singleUseTransaction,
                mutations,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Commits a transaction. The request includes the mutations to be
        /// applied to rows in the database.
        ///
        /// `Commit` might return an `ABORTED` error. This can occur at any time;
        /// commonly, the cause is conflicts with concurrent
        /// transactions. However, it can also happen for a variety of other
        /// reasons. If `Commit` returns `ABORTED`, the caller should re-attempt
        /// the transaction from the beginning, re-using the same session.
        /// </summary>
        /// <param name="session">
        /// Required. The session in which the transaction to be committed is running.
        /// </param>
        /// <param name="singleUseTransaction">
        /// Execute mutations in a temporary transaction. Note that unlike
        /// commit of a previously-started transaction, commit with a
        /// temporary transaction is non-idempotent. That is, if the
        /// `CommitRequest` is sent to Cloud Spanner more than once (for
        /// instance, due to retries in the application, or in the
        /// transport library), it is possible that the mutations are
        /// executed more than once. If this is undesirable, use
        /// [BeginTransaction][google.spanner.v1.Spanner.BeginTransaction] and
        /// [Commit][google.spanner.v1.Spanner.Commit] instead.
        /// </param>
        /// <param name="mutations">
        /// The mutations to be executed when this transaction commits. All
        /// mutations are applied atomically, in the order they appear in
        /// this list.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual CommitResponse Commit(
            SessionName session,
            TransactionOptions singleUseTransaction,
            scg::IEnumerable<Mutation> mutations,
            gaxgrpc::CallSettings callSettings = null) => Commit(
                new CommitRequest
                {
                    SessionAsSessionName = gax::GaxPreconditions.CheckNotNull(session, nameof(session)),
                    SingleUseTransaction = singleUseTransaction, // Optional
                    Mutations = { gax::GaxPreconditions.CheckNotNull(mutations, nameof(mutations)) },
                },
                callSettings);

        /// <summary>
        /// Commits a transaction. The request includes the mutations to be
        /// applied to rows in the database.
        ///
        /// `Commit` might return an `ABORTED` error. This can occur at any time;
        /// commonly, the cause is conflicts with concurrent
        /// transactions. However, it can also happen for a variety of other
        /// reasons. If `Commit` returns `ABORTED`, the caller should re-attempt
        /// the transaction from the beginning, re-using the same session.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<CommitResponse> CommitAsync(
            CommitRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new s::NotImplementedException();
        }

        /// <summary>
        /// Commits a transaction. The request includes the mutations to be
        /// applied to rows in the database.
        ///
        /// `Commit` might return an `ABORTED` error. This can occur at any time;
        /// commonly, the cause is conflicts with concurrent
        /// transactions. However, it can also happen for a variety of other
        /// reasons. If `Commit` returns `ABORTED`, the caller should re-attempt
        /// the transaction from the beginning, re-using the same session.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<CommitResponse> CommitAsync(
            CommitRequest request,
            st::CancellationToken cancellationToken) => CommitAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Commits a transaction. The request includes the mutations to be
        /// applied to rows in the database.
        ///
        /// `Commit` might return an `ABORTED` error. This can occur at any time;
        /// commonly, the cause is conflicts with concurrent
        /// transactions. However, it can also happen for a variety of other
        /// reasons. If `Commit` returns `ABORTED`, the caller should re-attempt
        /// the transaction from the beginning, re-using the same session.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual CommitResponse Commit(
            CommitRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new s::NotImplementedException();
        }

        /// <summary>
        /// Rolls back a transaction, releasing any locks it holds. It is a good
        /// idea to call this for any transaction that includes one or more
        /// [Read][google.spanner.v1.Spanner.Read] or [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql] requests and
        /// ultimately decides not to commit.
        ///
        /// `Rollback` returns `OK` if it successfully aborts the transaction, the
        /// transaction was already aborted, or the transaction is not
        /// found. `Rollback` never returns `ABORTED`.
        /// </summary>
        /// <param name="session">
        /// Required. The session in which the transaction to roll back is running.
        /// </param>
        /// <param name="transactionId">
        /// Required. The transaction to roll back.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task RollbackAsync(
            SessionName session,
            proto::ByteString transactionId,
            gaxgrpc::CallSettings callSettings = null) => RollbackAsync(
                new RollbackRequest
                {
                    SessionAsSessionName = gax::GaxPreconditions.CheckNotNull(session, nameof(session)),
                    TransactionId = gax::GaxPreconditions.CheckNotNull(transactionId, nameof(transactionId)),
                },
                callSettings);

        /// <summary>
        /// Rolls back a transaction, releasing any locks it holds. It is a good
        /// idea to call this for any transaction that includes one or more
        /// [Read][google.spanner.v1.Spanner.Read] or [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql] requests and
        /// ultimately decides not to commit.
        ///
        /// `Rollback` returns `OK` if it successfully aborts the transaction, the
        /// transaction was already aborted, or the transaction is not
        /// found. `Rollback` never returns `ABORTED`.
        /// </summary>
        /// <param name="session">
        /// Required. The session in which the transaction to roll back is running.
        /// </param>
        /// <param name="transactionId">
        /// Required. The transaction to roll back.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task RollbackAsync(
            SessionName session,
            proto::ByteString transactionId,
            st::CancellationToken cancellationToken) => RollbackAsync(
                session,
                transactionId,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Rolls back a transaction, releasing any locks it holds. It is a good
        /// idea to call this for any transaction that includes one or more
        /// [Read][google.spanner.v1.Spanner.Read] or [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql] requests and
        /// ultimately decides not to commit.
        ///
        /// `Rollback` returns `OK` if it successfully aborts the transaction, the
        /// transaction was already aborted, or the transaction is not
        /// found. `Rollback` never returns `ABORTED`.
        /// </summary>
        /// <param name="session">
        /// Required. The session in which the transaction to roll back is running.
        /// </param>
        /// <param name="transactionId">
        /// Required. The transaction to roll back.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void Rollback(
            SessionName session,
            proto::ByteString transactionId,
            gaxgrpc::CallSettings callSettings = null) => Rollback(
                new RollbackRequest
                {
                    SessionAsSessionName = gax::GaxPreconditions.CheckNotNull(session, nameof(session)),
                    TransactionId = gax::GaxPreconditions.CheckNotNull(transactionId, nameof(transactionId)),
                },
                callSettings);

        /// <summary>
        /// Rolls back a transaction, releasing any locks it holds. It is a good
        /// idea to call this for any transaction that includes one or more
        /// [Read][google.spanner.v1.Spanner.Read] or [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql] requests and
        /// ultimately decides not to commit.
        ///
        /// `Rollback` returns `OK` if it successfully aborts the transaction, the
        /// transaction was already aborted, or the transaction is not
        /// found. `Rollback` never returns `ABORTED`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task RollbackAsync(
            RollbackRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new s::NotImplementedException();
        }

        /// <summary>
        /// Rolls back a transaction, releasing any locks it holds. It is a good
        /// idea to call this for any transaction that includes one or more
        /// [Read][google.spanner.v1.Spanner.Read] or [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql] requests and
        /// ultimately decides not to commit.
        ///
        /// `Rollback` returns `OK` if it successfully aborts the transaction, the
        /// transaction was already aborted, or the transaction is not
        /// found. `Rollback` never returns `ABORTED`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task RollbackAsync(
            RollbackRequest request,
            st::CancellationToken cancellationToken) => RollbackAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Rolls back a transaction, releasing any locks it holds. It is a good
        /// idea to call this for any transaction that includes one or more
        /// [Read][google.spanner.v1.Spanner.Read] or [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql] requests and
        /// ultimately decides not to commit.
        ///
        /// `Rollback` returns `OK` if it successfully aborts the transaction, the
        /// transaction was already aborted, or the transaction is not
        /// found. `Rollback` never returns `ABORTED`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void Rollback(
            RollbackRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new s::NotImplementedException();
        }

        /// <summary>
        /// Creates a set of partition tokens that can be used to execute a query
        /// operation in parallel.  Each of the returned partition tokens can be used
        /// by [ExecuteStreamingSql][google.spanner.v1.Spanner.ExecuteStreamingSql] to specify a subset
        /// of the query result to read.  The same session and read-only transaction
        /// must be used by the PartitionQueryRequest used to create the
        /// partition tokens and the ExecuteSqlRequests that use the partition tokens.
        /// Partition tokens become invalid when the session used to create them
        /// is deleted or begins a new transaction.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<PartitionResponse> PartitionQueryAsync(
            PartitionQueryRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new s::NotImplementedException();
        }

        /// <summary>
        /// Creates a set of partition tokens that can be used to execute a query
        /// operation in parallel.  Each of the returned partition tokens can be used
        /// by [ExecuteStreamingSql][google.spanner.v1.Spanner.ExecuteStreamingSql] to specify a subset
        /// of the query result to read.  The same session and read-only transaction
        /// must be used by the PartitionQueryRequest used to create the
        /// partition tokens and the ExecuteSqlRequests that use the partition tokens.
        /// Partition tokens become invalid when the session used to create them
        /// is deleted or begins a new transaction.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<PartitionResponse> PartitionQueryAsync(
            PartitionQueryRequest request,
            st::CancellationToken cancellationToken) => PartitionQueryAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a set of partition tokens that can be used to execute a query
        /// operation in parallel.  Each of the returned partition tokens can be used
        /// by [ExecuteStreamingSql][google.spanner.v1.Spanner.ExecuteStreamingSql] to specify a subset
        /// of the query result to read.  The same session and read-only transaction
        /// must be used by the PartitionQueryRequest used to create the
        /// partition tokens and the ExecuteSqlRequests that use the partition tokens.
        /// Partition tokens become invalid when the session used to create them
        /// is deleted or begins a new transaction.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual PartitionResponse PartitionQuery(
            PartitionQueryRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new s::NotImplementedException();
        }

        /// <summary>
        /// Creates a set of partition tokens that can be used to execute a read
        /// operation in parallel.  Each of the returned partition tokens can be used
        /// by [StreamingRead][google.spanner.v1.Spanner.StreamingRead] to specify a subset of the read
        /// result to read.  The same session and read-only transaction must be used by
        /// the PartitionReadRequest used to create the partition tokens and the
        /// ReadRequests that use the partition tokens.
        /// Partition tokens become invalid when the session used to create them
        /// is deleted or begins a new transaction.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<PartitionResponse> PartitionReadAsync(
            PartitionReadRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new s::NotImplementedException();
        }

        /// <summary>
        /// Creates a set of partition tokens that can be used to execute a read
        /// operation in parallel.  Each of the returned partition tokens can be used
        /// by [StreamingRead][google.spanner.v1.Spanner.StreamingRead] to specify a subset of the read
        /// result to read.  The same session and read-only transaction must be used by
        /// the PartitionReadRequest used to create the partition tokens and the
        /// ReadRequests that use the partition tokens.
        /// Partition tokens become invalid when the session used to create them
        /// is deleted or begins a new transaction.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<PartitionResponse> PartitionReadAsync(
            PartitionReadRequest request,
            st::CancellationToken cancellationToken) => PartitionReadAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a set of partition tokens that can be used to execute a read
        /// operation in parallel.  Each of the returned partition tokens can be used
        /// by [StreamingRead][google.spanner.v1.Spanner.StreamingRead] to specify a subset of the read
        /// result to read.  The same session and read-only transaction must be used by
        /// the PartitionReadRequest used to create the partition tokens and the
        /// ReadRequests that use the partition tokens.
        /// Partition tokens become invalid when the session used to create them
        /// is deleted or begins a new transaction.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual PartitionResponse PartitionRead(
            PartitionReadRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new s::NotImplementedException();
        }

    }

    /// <summary>
    /// Spanner client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class SpannerClientImpl : SpannerClient
    {
        private readonly gaxgrpc::ApiCall<CreateSessionRequest, Session> _callCreateSession;
        private readonly gaxgrpc::ApiCall<GetSessionRequest, Session> _callGetSession;
        private readonly gaxgrpc::ApiCall<ListSessionsRequest, ListSessionsResponse> _callListSessions;
        private readonly gaxgrpc::ApiCall<DeleteSessionRequest, protowkt::Empty> _callDeleteSession;
        private readonly gaxgrpc::ApiCall<ExecuteSqlRequest, ResultSet> _callExecuteSql;
        private readonly gaxgrpc::ApiServerStreamingCall<ExecuteSqlRequest, PartialResultSet> _callExecuteStreamingSql;
        private readonly gaxgrpc::ApiCall<ReadRequest, ResultSet> _callRead;
        private readonly gaxgrpc::ApiServerStreamingCall<ReadRequest, PartialResultSet> _callStreamingRead;
        private readonly gaxgrpc::ApiCall<BeginTransactionRequest, Transaction> _callBeginTransaction;
        private readonly gaxgrpc::ApiCall<CommitRequest, CommitResponse> _callCommit;
        private readonly gaxgrpc::ApiCall<RollbackRequest, protowkt::Empty> _callRollback;
        private readonly gaxgrpc::ApiCall<PartitionQueryRequest, PartitionResponse> _callPartitionQuery;
        private readonly gaxgrpc::ApiCall<PartitionReadRequest, PartitionResponse> _callPartitionRead;

        /// <summary>
        /// Constructs a client wrapper for the Spanner service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="SpannerSettings"/> used within this client </param>
        public SpannerClientImpl(Spanner.SpannerClient grpcClient, SpannerSettings settings)
        {
            GrpcClient = grpcClient;
            SpannerSettings effectiveSettings = settings ?? SpannerSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callCreateSession = clientHelper.BuildApiCall<CreateSessionRequest, Session>(
                GrpcClient.CreateSessionAsync, GrpcClient.CreateSession, effectiveSettings.CreateSessionSettings);
            _callGetSession = clientHelper.BuildApiCall<GetSessionRequest, Session>(
                GrpcClient.GetSessionAsync, GrpcClient.GetSession, effectiveSettings.GetSessionSettings);
            _callListSessions = clientHelper.BuildApiCall<ListSessionsRequest, ListSessionsResponse>(
                GrpcClient.ListSessionsAsync, GrpcClient.ListSessions, effectiveSettings.ListSessionsSettings);
            _callDeleteSession = clientHelper.BuildApiCall<DeleteSessionRequest, protowkt::Empty>(
                GrpcClient.DeleteSessionAsync, GrpcClient.DeleteSession, effectiveSettings.DeleteSessionSettings);
            _callExecuteSql = clientHelper.BuildApiCall<ExecuteSqlRequest, ResultSet>(
                GrpcClient.ExecuteSqlAsync, GrpcClient.ExecuteSql, effectiveSettings.ExecuteSqlSettings);
            _callExecuteStreamingSql = clientHelper.BuildApiCall<ExecuteSqlRequest, PartialResultSet>(
                GrpcClient.ExecuteStreamingSql, effectiveSettings.ExecuteStreamingSqlSettings);
            _callRead = clientHelper.BuildApiCall<ReadRequest, ResultSet>(
                GrpcClient.ReadAsync, GrpcClient.Read, effectiveSettings.ReadSettings);
            _callStreamingRead = clientHelper.BuildApiCall<ReadRequest, PartialResultSet>(
                GrpcClient.StreamingRead, effectiveSettings.StreamingReadSettings);
            _callBeginTransaction = clientHelper.BuildApiCall<BeginTransactionRequest, Transaction>(
                GrpcClient.BeginTransactionAsync, GrpcClient.BeginTransaction, effectiveSettings.BeginTransactionSettings);
            _callCommit = clientHelper.BuildApiCall<CommitRequest, CommitResponse>(
                GrpcClient.CommitAsync, GrpcClient.Commit, effectiveSettings.CommitSettings);
            _callRollback = clientHelper.BuildApiCall<RollbackRequest, protowkt::Empty>(
                GrpcClient.RollbackAsync, GrpcClient.Rollback, effectiveSettings.RollbackSettings);
            _callPartitionQuery = clientHelper.BuildApiCall<PartitionQueryRequest, PartitionResponse>(
                GrpcClient.PartitionQueryAsync, GrpcClient.PartitionQuery, effectiveSettings.PartitionQuerySettings);
            _callPartitionRead = clientHelper.BuildApiCall<PartitionReadRequest, PartitionResponse>(
                GrpcClient.PartitionReadAsync, GrpcClient.PartitionRead, effectiveSettings.PartitionReadSettings);
            Modify_ApiCall(ref _callCreateSession);
            Modify_CreateSessionApiCall(ref _callCreateSession);
            Modify_ApiCall(ref _callGetSession);
            Modify_GetSessionApiCall(ref _callGetSession);
            Modify_ApiCall(ref _callListSessions);
            Modify_ListSessionsApiCall(ref _callListSessions);
            Modify_ApiCall(ref _callDeleteSession);
            Modify_DeleteSessionApiCall(ref _callDeleteSession);
            Modify_ApiCall(ref _callExecuteSql);
            Modify_ExecuteSqlApiCall(ref _callExecuteSql);
            Modify_ApiCall(ref _callExecuteStreamingSql);
            Modify_ExecuteStreamingSqlApiCall(ref _callExecuteStreamingSql);
            Modify_ApiCall(ref _callRead);
            Modify_ReadApiCall(ref _callRead);
            Modify_ApiCall(ref _callStreamingRead);
            Modify_StreamingReadApiCall(ref _callStreamingRead);
            Modify_ApiCall(ref _callBeginTransaction);
            Modify_BeginTransactionApiCall(ref _callBeginTransaction);
            Modify_ApiCall(ref _callCommit);
            Modify_CommitApiCall(ref _callCommit);
            Modify_ApiCall(ref _callRollback);
            Modify_RollbackApiCall(ref _callRollback);
            Modify_ApiCall(ref _callPartitionQuery);
            Modify_PartitionQueryApiCall(ref _callPartitionQuery);
            Modify_ApiCall(ref _callPartitionRead);
            Modify_PartitionReadApiCall(ref _callPartitionRead);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        // Partial methods are named to (mostly) ensure there cannot be conflicts with RPC method names.

        // Partial methods called for every ApiCall on construction.
        // Allows modification of all the underlying ApiCall objects.
        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call)
            where TRequest : class, proto::IMessage<TRequest>
            where TResponse : class, proto::IMessage<TResponse>;
        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiServerStreamingCall<TRequest, TResponse> call)
            where TRequest : class, proto::IMessage<TRequest>
            where TResponse : class, proto::IMessage<TResponse>;

        // Partial methods called for each ApiCall on construction.
        // Allows per-RPC-method modification of the underlying ApiCall object.
        partial void Modify_CreateSessionApiCall(ref gaxgrpc::ApiCall<CreateSessionRequest, Session> call);
        partial void Modify_GetSessionApiCall(ref gaxgrpc::ApiCall<GetSessionRequest, Session> call);
        partial void Modify_ListSessionsApiCall(ref gaxgrpc::ApiCall<ListSessionsRequest, ListSessionsResponse> call);
        partial void Modify_DeleteSessionApiCall(ref gaxgrpc::ApiCall<DeleteSessionRequest, protowkt::Empty> call);
        partial void Modify_ExecuteSqlApiCall(ref gaxgrpc::ApiCall<ExecuteSqlRequest, ResultSet> call);
        partial void Modify_ExecuteStreamingSqlApiCall(ref gaxgrpc::ApiServerStreamingCall<ExecuteSqlRequest, PartialResultSet> call);
        partial void Modify_ReadApiCall(ref gaxgrpc::ApiCall<ReadRequest, ResultSet> call);
        partial void Modify_StreamingReadApiCall(ref gaxgrpc::ApiServerStreamingCall<ReadRequest, PartialResultSet> call);
        partial void Modify_BeginTransactionApiCall(ref gaxgrpc::ApiCall<BeginTransactionRequest, Transaction> call);
        partial void Modify_CommitApiCall(ref gaxgrpc::ApiCall<CommitRequest, CommitResponse> call);
        partial void Modify_RollbackApiCall(ref gaxgrpc::ApiCall<RollbackRequest, protowkt::Empty> call);
        partial void Modify_PartitionQueryApiCall(ref gaxgrpc::ApiCall<PartitionQueryRequest, PartitionResponse> call);
        partial void Modify_PartitionReadApiCall(ref gaxgrpc::ApiCall<PartitionReadRequest, PartitionResponse> call);
        partial void OnConstruction(Spanner.SpannerClient grpcClient, SpannerSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC Spanner client.
        /// </summary>
        public override Spanner.SpannerClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_CreateSessionRequest(ref CreateSessionRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetSessionRequest(ref GetSessionRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListSessionsRequest(ref ListSessionsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_DeleteSessionRequest(ref DeleteSessionRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ExecuteSqlRequest(ref ExecuteSqlRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ReadRequest(ref ReadRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_BeginTransactionRequest(ref BeginTransactionRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_CommitRequest(ref CommitRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_RollbackRequest(ref RollbackRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_PartitionQueryRequest(ref PartitionQueryRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_PartitionReadRequest(ref PartitionReadRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a new session. A session can be used to perform
        /// transactions that read and/or modify data in a Cloud Spanner database.
        /// Sessions are meant to be reused for many consecutive
        /// transactions.
        ///
        /// Sessions can only execute one transaction at a time. To execute
        /// multiple concurrent read-write/write-only transactions, create
        /// multiple sessions. Note that standalone reads and queries use a
        /// transaction internally, and count toward the one transaction
        /// limit.
        ///
        /// Cloud Spanner limits the number of sessions that can exist at any given
        /// time; thus, it is a good idea to delete idle and/or unneeded sessions.
        /// Aside from explicit deletes, Cloud Spanner can delete sessions for which no
        /// operations are sent for more than an hour. If a session is deleted,
        /// requests to it return `NOT_FOUND`.
        ///
        /// Idle sessions can be kept alive by sending a trivial SQL query
        /// periodically, e.g., `"SELECT 1"`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<Session> CreateSessionAsync(
            CreateSessionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSessionRequest(ref request, ref callSettings);
            return _callCreateSession.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new session. A session can be used to perform
        /// transactions that read and/or modify data in a Cloud Spanner database.
        /// Sessions are meant to be reused for many consecutive
        /// transactions.
        ///
        /// Sessions can only execute one transaction at a time. To execute
        /// multiple concurrent read-write/write-only transactions, create
        /// multiple sessions. Note that standalone reads and queries use a
        /// transaction internally, and count toward the one transaction
        /// limit.
        ///
        /// Cloud Spanner limits the number of sessions that can exist at any given
        /// time; thus, it is a good idea to delete idle and/or unneeded sessions.
        /// Aside from explicit deletes, Cloud Spanner can delete sessions for which no
        /// operations are sent for more than an hour. If a session is deleted,
        /// requests to it return `NOT_FOUND`.
        ///
        /// Idle sessions can be kept alive by sending a trivial SQL query
        /// periodically, e.g., `"SELECT 1"`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override Session CreateSession(
            CreateSessionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSessionRequest(ref request, ref callSettings);
            return _callCreateSession.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a session. Returns `NOT_FOUND` if the session does not exist.
        /// This is mainly useful for determining whether a session is still
        /// alive.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<Session> GetSessionAsync(
            GetSessionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSessionRequest(ref request, ref callSettings);
            return _callGetSession.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a session. Returns `NOT_FOUND` if the session does not exist.
        /// This is mainly useful for determining whether a session is still
        /// alive.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override Session GetSession(
            GetSessionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSessionRequest(ref request, ref callSettings);
            return _callGetSession.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists all sessions in a given database.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Session"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListSessionsResponse, Session> ListSessionsAsync(
            ListSessionsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSessionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSessionsRequest, ListSessionsResponse, Session>(_callListSessions, request, callSettings);
        }

        /// <summary>
        /// Lists all sessions in a given database.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Session"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<ListSessionsResponse, Session> ListSessions(
            ListSessionsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSessionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSessionsRequest, ListSessionsResponse, Session>(_callListSessions, request, callSettings);
        }

        /// <summary>
        /// Ends a session, releasing server resources associated with it.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public override stt::Task DeleteSessionAsync(
            DeleteSessionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSessionRequest(ref request, ref callSettings);
            return _callDeleteSession.Async(request, callSettings);
        }

        /// <summary>
        /// Ends a session, releasing server resources associated with it.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void DeleteSession(
            DeleteSessionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSessionRequest(ref request, ref callSettings);
            _callDeleteSession.Sync(request, callSettings);
        }

        /// <summary>
        /// Executes an SQL query, returning all rows in a single reply. This
        /// method cannot be used to return a result set larger than 10 MiB;
        /// if the query yields more data than that, the query fails with
        /// a `FAILED_PRECONDITION` error.
        ///
        /// Queries inside read-write transactions might return `ABORTED`. If
        /// this occurs, the application should restart the transaction from
        /// the beginning. See [Transaction][google.spanner.v1.Transaction] for more details.
        ///
        /// Larger result sets can be fetched in streaming fashion by calling
        /// [ExecuteStreamingSql][google.spanner.v1.Spanner.ExecuteStreamingSql] instead.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<ResultSet> ExecuteSqlAsync(
            ExecuteSqlRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExecuteSqlRequest(ref request, ref callSettings);
            return _callExecuteSql.Async(request, callSettings);
        }

        /// <summary>
        /// Executes an SQL query, returning all rows in a single reply. This
        /// method cannot be used to return a result set larger than 10 MiB;
        /// if the query yields more data than that, the query fails with
        /// a `FAILED_PRECONDITION` error.
        ///
        /// Queries inside read-write transactions might return `ABORTED`. If
        /// this occurs, the application should restart the transaction from
        /// the beginning. See [Transaction][google.spanner.v1.Transaction] for more details.
        ///
        /// Larger result sets can be fetched in streaming fashion by calling
        /// [ExecuteStreamingSql][google.spanner.v1.Spanner.ExecuteStreamingSql] instead.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override ResultSet ExecuteSql(
            ExecuteSqlRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExecuteSqlRequest(ref request, ref callSettings);
            return _callExecuteSql.Sync(request, callSettings);
        }

        /// <summary>
        /// Like [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql], except returns the result
        /// set as a stream. Unlike [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql], there
        /// is no limit on the size of the returned result set. However, no
        /// individual row in the result set can exceed 100 MiB, and no
        /// column value can exceed 10 MiB.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The server stream.
        /// </returns>
        public override ExecuteStreamingSqlStream ExecuteStreamingSql(
            ExecuteSqlRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExecuteSqlRequest(ref request, ref callSettings);
            return new ExecuteStreamingSqlStreamImpl(_callExecuteStreamingSql.Call(request, callSettings));
        }

        internal sealed partial class ExecuteStreamingSqlStreamImpl : ExecuteStreamingSqlStream
        {
            /// <summary>
            /// Construct the server-streaming method for <c>ExecuteStreamingSql</c>.
            /// </summary>
            /// <param name="call">The underlying gRPC server-streaming call.</param>
            internal ExecuteStreamingSqlStreamImpl(grpccore::AsyncServerStreamingCall<PartialResultSet> call)
            {
                GrpcCall = call;
            }

            /// <inheritdoc/>
            public override grpccore::AsyncServerStreamingCall<PartialResultSet> GrpcCall { get; }

            /// <inheritdoc/>
            public override scg::IAsyncEnumerator<PartialResultSet> ResponseStream => GrpcCall.ResponseStream;
        }

        /// <summary>
        /// Reads rows from the database using key lookups and scans, as a
        /// simple key/value style alternative to
        /// [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql].  This method cannot be used to
        /// return a result set larger than 10 MiB; if the read matches more
        /// data than that, the read fails with a `FAILED_PRECONDITION`
        /// error.
        ///
        /// Reads inside read-write transactions might return `ABORTED`. If
        /// this occurs, the application should restart the transaction from
        /// the beginning. See [Transaction][google.spanner.v1.Transaction] for more details.
        ///
        /// Larger result sets can be yielded in streaming fashion by calling
        /// [StreamingRead][google.spanner.v1.Spanner.StreamingRead] instead.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<ResultSet> ReadAsync(
            ReadRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReadRequest(ref request, ref callSettings);
            return _callRead.Async(request, callSettings);
        }

        /// <summary>
        /// Reads rows from the database using key lookups and scans, as a
        /// simple key/value style alternative to
        /// [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql].  This method cannot be used to
        /// return a result set larger than 10 MiB; if the read matches more
        /// data than that, the read fails with a `FAILED_PRECONDITION`
        /// error.
        ///
        /// Reads inside read-write transactions might return `ABORTED`. If
        /// this occurs, the application should restart the transaction from
        /// the beginning. See [Transaction][google.spanner.v1.Transaction] for more details.
        ///
        /// Larger result sets can be yielded in streaming fashion by calling
        /// [StreamingRead][google.spanner.v1.Spanner.StreamingRead] instead.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override ResultSet Read(
            ReadRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReadRequest(ref request, ref callSettings);
            return _callRead.Sync(request, callSettings);
        }

        /// <summary>
        /// Like [Read][google.spanner.v1.Spanner.Read], except returns the result set as a
        /// stream. Unlike [Read][google.spanner.v1.Spanner.Read], there is no limit on the
        /// size of the returned result set. However, no individual row in
        /// the result set can exceed 100 MiB, and no column value can exceed
        /// 10 MiB.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The server stream.
        /// </returns>
        public override StreamingReadStream StreamingRead(
            ReadRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReadRequest(ref request, ref callSettings);
            return new StreamingReadStreamImpl(_callStreamingRead.Call(request, callSettings));
        }

        internal sealed partial class StreamingReadStreamImpl : StreamingReadStream
        {
            /// <summary>
            /// Construct the server-streaming method for <c>StreamingRead</c>.
            /// </summary>
            /// <param name="call">The underlying gRPC server-streaming call.</param>
            internal StreamingReadStreamImpl(grpccore::AsyncServerStreamingCall<PartialResultSet> call)
            {
                GrpcCall = call;
            }

            /// <inheritdoc/>
            public override grpccore::AsyncServerStreamingCall<PartialResultSet> GrpcCall { get; }

            /// <inheritdoc/>
            public override scg::IAsyncEnumerator<PartialResultSet> ResponseStream => GrpcCall.ResponseStream;
        }

        /// <summary>
        /// Begins a new transaction. This step can often be skipped:
        /// [Read][google.spanner.v1.Spanner.Read], [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql] and
        /// [Commit][google.spanner.v1.Spanner.Commit] can begin a new transaction as a
        /// side-effect.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<Transaction> BeginTransactionAsync(
            BeginTransactionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BeginTransactionRequest(ref request, ref callSettings);
            return _callBeginTransaction.Async(request, callSettings);
        }

        /// <summary>
        /// Begins a new transaction. This step can often be skipped:
        /// [Read][google.spanner.v1.Spanner.Read], [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql] and
        /// [Commit][google.spanner.v1.Spanner.Commit] can begin a new transaction as a
        /// side-effect.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override Transaction BeginTransaction(
            BeginTransactionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BeginTransactionRequest(ref request, ref callSettings);
            return _callBeginTransaction.Sync(request, callSettings);
        }

        /// <summary>
        /// Commits a transaction. The request includes the mutations to be
        /// applied to rows in the database.
        ///
        /// `Commit` might return an `ABORTED` error. This can occur at any time;
        /// commonly, the cause is conflicts with concurrent
        /// transactions. However, it can also happen for a variety of other
        /// reasons. If `Commit` returns `ABORTED`, the caller should re-attempt
        /// the transaction from the beginning, re-using the same session.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<CommitResponse> CommitAsync(
            CommitRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CommitRequest(ref request, ref callSettings);
            return _callCommit.Async(request, callSettings);
        }

        /// <summary>
        /// Commits a transaction. The request includes the mutations to be
        /// applied to rows in the database.
        ///
        /// `Commit` might return an `ABORTED` error. This can occur at any time;
        /// commonly, the cause is conflicts with concurrent
        /// transactions. However, it can also happen for a variety of other
        /// reasons. If `Commit` returns `ABORTED`, the caller should re-attempt
        /// the transaction from the beginning, re-using the same session.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override CommitResponse Commit(
            CommitRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CommitRequest(ref request, ref callSettings);
            return _callCommit.Sync(request, callSettings);
        }

        /// <summary>
        /// Rolls back a transaction, releasing any locks it holds. It is a good
        /// idea to call this for any transaction that includes one or more
        /// [Read][google.spanner.v1.Spanner.Read] or [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql] requests and
        /// ultimately decides not to commit.
        ///
        /// `Rollback` returns `OK` if it successfully aborts the transaction, the
        /// transaction was already aborted, or the transaction is not
        /// found. `Rollback` never returns `ABORTED`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public override stt::Task RollbackAsync(
            RollbackRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RollbackRequest(ref request, ref callSettings);
            return _callRollback.Async(request, callSettings);
        }

        /// <summary>
        /// Rolls back a transaction, releasing any locks it holds. It is a good
        /// idea to call this for any transaction that includes one or more
        /// [Read][google.spanner.v1.Spanner.Read] or [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql] requests and
        /// ultimately decides not to commit.
        ///
        /// `Rollback` returns `OK` if it successfully aborts the transaction, the
        /// transaction was already aborted, or the transaction is not
        /// found. `Rollback` never returns `ABORTED`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void Rollback(
            RollbackRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RollbackRequest(ref request, ref callSettings);
            _callRollback.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a set of partition tokens that can be used to execute a query
        /// operation in parallel.  Each of the returned partition tokens can be used
        /// by [ExecuteStreamingSql][google.spanner.v1.Spanner.ExecuteStreamingSql] to specify a subset
        /// of the query result to read.  The same session and read-only transaction
        /// must be used by the PartitionQueryRequest used to create the
        /// partition tokens and the ExecuteSqlRequests that use the partition tokens.
        /// Partition tokens become invalid when the session used to create them
        /// is deleted or begins a new transaction.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<PartitionResponse> PartitionQueryAsync(
            PartitionQueryRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PartitionQueryRequest(ref request, ref callSettings);
            return _callPartitionQuery.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a set of partition tokens that can be used to execute a query
        /// operation in parallel.  Each of the returned partition tokens can be used
        /// by [ExecuteStreamingSql][google.spanner.v1.Spanner.ExecuteStreamingSql] to specify a subset
        /// of the query result to read.  The same session and read-only transaction
        /// must be used by the PartitionQueryRequest used to create the
        /// partition tokens and the ExecuteSqlRequests that use the partition tokens.
        /// Partition tokens become invalid when the session used to create them
        /// is deleted or begins a new transaction.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override PartitionResponse PartitionQuery(
            PartitionQueryRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PartitionQueryRequest(ref request, ref callSettings);
            return _callPartitionQuery.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a set of partition tokens that can be used to execute a read
        /// operation in parallel.  Each of the returned partition tokens can be used
        /// by [StreamingRead][google.spanner.v1.Spanner.StreamingRead] to specify a subset of the read
        /// result to read.  The same session and read-only transaction must be used by
        /// the PartitionReadRequest used to create the partition tokens and the
        /// ReadRequests that use the partition tokens.
        /// Partition tokens become invalid when the session used to create them
        /// is deleted or begins a new transaction.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<PartitionResponse> PartitionReadAsync(
            PartitionReadRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PartitionReadRequest(ref request, ref callSettings);
            return _callPartitionRead.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a set of partition tokens that can be used to execute a read
        /// operation in parallel.  Each of the returned partition tokens can be used
        /// by [StreamingRead][google.spanner.v1.Spanner.StreamingRead] to specify a subset of the read
        /// result to read.  The same session and read-only transaction must be used by
        /// the PartitionReadRequest used to create the partition tokens and the
        /// ReadRequests that use the partition tokens.
        /// Partition tokens become invalid when the session used to create them
        /// is deleted or begins a new transaction.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override PartitionResponse PartitionRead(
            PartitionReadRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PartitionReadRequest(ref request, ref callSettings);
            return _callPartitionRead.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming

    public partial class ListSessionsRequest : gaxgrpc::IPageRequest { }
    public partial class ListSessionsResponse : gaxgrpc::IPageResponse<Session>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<Session> GetEnumerator() => Sessions.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }


}
