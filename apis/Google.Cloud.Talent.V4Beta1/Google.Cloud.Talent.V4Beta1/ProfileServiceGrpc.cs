// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/talent/v4beta1/profile_service.proto
// </auto-generated>
// Original file comments:
// Copyright 2019 Google LLC.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
//
#pragma warning disable 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Google.Cloud.Talent.V4Beta1 {
  /// <summary>
  /// A service that handles profile management, including profile CRUD,
  /// enumeration and search.
  /// </summary>
  public static partial class ProfileService
  {
    static readonly string __ServiceName = "google.cloud.talent.v4beta1.ProfileService";

    static readonly grpc::Marshaller<global::Google.Cloud.Talent.V4Beta1.ListProfilesRequest> __Marshaller_ListProfilesRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Talent.V4Beta1.ListProfilesRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Talent.V4Beta1.ListProfilesResponse> __Marshaller_ListProfilesResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Talent.V4Beta1.ListProfilesResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Talent.V4Beta1.CreateProfileRequest> __Marshaller_CreateProfileRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Talent.V4Beta1.CreateProfileRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Talent.V4Beta1.Profile> __Marshaller_Profile = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Talent.V4Beta1.Profile.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Talent.V4Beta1.GetProfileRequest> __Marshaller_GetProfileRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Talent.V4Beta1.GetProfileRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Talent.V4Beta1.UpdateProfileRequest> __Marshaller_UpdateProfileRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Talent.V4Beta1.UpdateProfileRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Talent.V4Beta1.DeleteProfileRequest> __Marshaller_DeleteProfileRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Talent.V4Beta1.DeleteProfileRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Talent.V4Beta1.SearchProfilesRequest> __Marshaller_SearchProfilesRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Talent.V4Beta1.SearchProfilesRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Talent.V4Beta1.SearchProfilesResponse> __Marshaller_SearchProfilesResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Talent.V4Beta1.SearchProfilesResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Cloud.Talent.V4Beta1.ListProfilesRequest, global::Google.Cloud.Talent.V4Beta1.ListProfilesResponse> __Method_ListProfiles = new grpc::Method<global::Google.Cloud.Talent.V4Beta1.ListProfilesRequest, global::Google.Cloud.Talent.V4Beta1.ListProfilesResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListProfiles",
        __Marshaller_ListProfilesRequest,
        __Marshaller_ListProfilesResponse);

    static readonly grpc::Method<global::Google.Cloud.Talent.V4Beta1.CreateProfileRequest, global::Google.Cloud.Talent.V4Beta1.Profile> __Method_CreateProfile = new grpc::Method<global::Google.Cloud.Talent.V4Beta1.CreateProfileRequest, global::Google.Cloud.Talent.V4Beta1.Profile>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateProfile",
        __Marshaller_CreateProfileRequest,
        __Marshaller_Profile);

    static readonly grpc::Method<global::Google.Cloud.Talent.V4Beta1.GetProfileRequest, global::Google.Cloud.Talent.V4Beta1.Profile> __Method_GetProfile = new grpc::Method<global::Google.Cloud.Talent.V4Beta1.GetProfileRequest, global::Google.Cloud.Talent.V4Beta1.Profile>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetProfile",
        __Marshaller_GetProfileRequest,
        __Marshaller_Profile);

    static readonly grpc::Method<global::Google.Cloud.Talent.V4Beta1.UpdateProfileRequest, global::Google.Cloud.Talent.V4Beta1.Profile> __Method_UpdateProfile = new grpc::Method<global::Google.Cloud.Talent.V4Beta1.UpdateProfileRequest, global::Google.Cloud.Talent.V4Beta1.Profile>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateProfile",
        __Marshaller_UpdateProfileRequest,
        __Marshaller_Profile);

    static readonly grpc::Method<global::Google.Cloud.Talent.V4Beta1.DeleteProfileRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_DeleteProfile = new grpc::Method<global::Google.Cloud.Talent.V4Beta1.DeleteProfileRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteProfile",
        __Marshaller_DeleteProfileRequest,
        __Marshaller_Empty);

    static readonly grpc::Method<global::Google.Cloud.Talent.V4Beta1.SearchProfilesRequest, global::Google.Cloud.Talent.V4Beta1.SearchProfilesResponse> __Method_SearchProfiles = new grpc::Method<global::Google.Cloud.Talent.V4Beta1.SearchProfilesRequest, global::Google.Cloud.Talent.V4Beta1.SearchProfilesResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SearchProfiles",
        __Marshaller_SearchProfilesRequest,
        __Marshaller_SearchProfilesResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Cloud.Talent.V4Beta1.ProfileServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ProfileService</summary>
    public abstract partial class ProfileServiceBase
    {
      /// <summary>
      /// Lists profiles by filter. The order is unspecified.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Talent.V4Beta1.ListProfilesResponse> ListProfiles(global::Google.Cloud.Talent.V4Beta1.ListProfilesRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Creates and returns a new profile.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Talent.V4Beta1.Profile> CreateProfile(global::Google.Cloud.Talent.V4Beta1.CreateProfileRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Gets the specified profile.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Talent.V4Beta1.Profile> GetProfile(global::Google.Cloud.Talent.V4Beta1.GetProfileRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Updates the specified profile and returns the updated result.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Talent.V4Beta1.Profile> UpdateProfile(global::Google.Cloud.Talent.V4Beta1.UpdateProfileRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Deletes the specified profile.
      /// Prerequisite: The profile has no associated applications or assignments
      /// associated.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> DeleteProfile(global::Google.Cloud.Talent.V4Beta1.DeleteProfileRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Searches for profiles within a tenant.
      ///
      /// For example, search by raw queries "software engineer in Mountain View" or
      /// search by structured filters (location filter, education filter, etc.).
      ///
      /// See
      /// [SearchProfilesRequest][google.cloud.talent.v4beta1.SearchProfilesRequest]
      /// for more information.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Talent.V4Beta1.SearchProfilesResponse> SearchProfiles(global::Google.Cloud.Talent.V4Beta1.SearchProfilesRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for ProfileService</summary>
    public partial class ProfileServiceClient : grpc::ClientBase<ProfileServiceClient>
    {
      /// <summary>Creates a new client for ProfileService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ProfileServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ProfileService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ProfileServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ProfileServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ProfileServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Lists profiles by filter. The order is unspecified.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Talent.V4Beta1.ListProfilesResponse ListProfiles(global::Google.Cloud.Talent.V4Beta1.ListProfilesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListProfiles(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lists profiles by filter. The order is unspecified.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Talent.V4Beta1.ListProfilesResponse ListProfiles(global::Google.Cloud.Talent.V4Beta1.ListProfilesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListProfiles, null, options, request);
      }
      /// <summary>
      /// Lists profiles by filter. The order is unspecified.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Talent.V4Beta1.ListProfilesResponse> ListProfilesAsync(global::Google.Cloud.Talent.V4Beta1.ListProfilesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListProfilesAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lists profiles by filter. The order is unspecified.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Talent.V4Beta1.ListProfilesResponse> ListProfilesAsync(global::Google.Cloud.Talent.V4Beta1.ListProfilesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListProfiles, null, options, request);
      }
      /// <summary>
      /// Creates and returns a new profile.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Talent.V4Beta1.Profile CreateProfile(global::Google.Cloud.Talent.V4Beta1.CreateProfileRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateProfile(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates and returns a new profile.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Talent.V4Beta1.Profile CreateProfile(global::Google.Cloud.Talent.V4Beta1.CreateProfileRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateProfile, null, options, request);
      }
      /// <summary>
      /// Creates and returns a new profile.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Talent.V4Beta1.Profile> CreateProfileAsync(global::Google.Cloud.Talent.V4Beta1.CreateProfileRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateProfileAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates and returns a new profile.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Talent.V4Beta1.Profile> CreateProfileAsync(global::Google.Cloud.Talent.V4Beta1.CreateProfileRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateProfile, null, options, request);
      }
      /// <summary>
      /// Gets the specified profile.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Talent.V4Beta1.Profile GetProfile(global::Google.Cloud.Talent.V4Beta1.GetProfileRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetProfile(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Gets the specified profile.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Talent.V4Beta1.Profile GetProfile(global::Google.Cloud.Talent.V4Beta1.GetProfileRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetProfile, null, options, request);
      }
      /// <summary>
      /// Gets the specified profile.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Talent.V4Beta1.Profile> GetProfileAsync(global::Google.Cloud.Talent.V4Beta1.GetProfileRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetProfileAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Gets the specified profile.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Talent.V4Beta1.Profile> GetProfileAsync(global::Google.Cloud.Talent.V4Beta1.GetProfileRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetProfile, null, options, request);
      }
      /// <summary>
      /// Updates the specified profile and returns the updated result.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Talent.V4Beta1.Profile UpdateProfile(global::Google.Cloud.Talent.V4Beta1.UpdateProfileRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateProfile(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Updates the specified profile and returns the updated result.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Talent.V4Beta1.Profile UpdateProfile(global::Google.Cloud.Talent.V4Beta1.UpdateProfileRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateProfile, null, options, request);
      }
      /// <summary>
      /// Updates the specified profile and returns the updated result.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Talent.V4Beta1.Profile> UpdateProfileAsync(global::Google.Cloud.Talent.V4Beta1.UpdateProfileRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateProfileAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Updates the specified profile and returns the updated result.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Talent.V4Beta1.Profile> UpdateProfileAsync(global::Google.Cloud.Talent.V4Beta1.UpdateProfileRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateProfile, null, options, request);
      }
      /// <summary>
      /// Deletes the specified profile.
      /// Prerequisite: The profile has no associated applications or assignments
      /// associated.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Protobuf.WellKnownTypes.Empty DeleteProfile(global::Google.Cloud.Talent.V4Beta1.DeleteProfileRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteProfile(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes the specified profile.
      /// Prerequisite: The profile has no associated applications or assignments
      /// associated.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Protobuf.WellKnownTypes.Empty DeleteProfile(global::Google.Cloud.Talent.V4Beta1.DeleteProfileRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteProfile, null, options, request);
      }
      /// <summary>
      /// Deletes the specified profile.
      /// Prerequisite: The profile has no associated applications or assignments
      /// associated.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> DeleteProfileAsync(global::Google.Cloud.Talent.V4Beta1.DeleteProfileRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteProfileAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes the specified profile.
      /// Prerequisite: The profile has no associated applications or assignments
      /// associated.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> DeleteProfileAsync(global::Google.Cloud.Talent.V4Beta1.DeleteProfileRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteProfile, null, options, request);
      }
      /// <summary>
      /// Searches for profiles within a tenant.
      ///
      /// For example, search by raw queries "software engineer in Mountain View" or
      /// search by structured filters (location filter, education filter, etc.).
      ///
      /// See
      /// [SearchProfilesRequest][google.cloud.talent.v4beta1.SearchProfilesRequest]
      /// for more information.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Talent.V4Beta1.SearchProfilesResponse SearchProfiles(global::Google.Cloud.Talent.V4Beta1.SearchProfilesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SearchProfiles(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Searches for profiles within a tenant.
      ///
      /// For example, search by raw queries "software engineer in Mountain View" or
      /// search by structured filters (location filter, education filter, etc.).
      ///
      /// See
      /// [SearchProfilesRequest][google.cloud.talent.v4beta1.SearchProfilesRequest]
      /// for more information.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Talent.V4Beta1.SearchProfilesResponse SearchProfiles(global::Google.Cloud.Talent.V4Beta1.SearchProfilesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SearchProfiles, null, options, request);
      }
      /// <summary>
      /// Searches for profiles within a tenant.
      ///
      /// For example, search by raw queries "software engineer in Mountain View" or
      /// search by structured filters (location filter, education filter, etc.).
      ///
      /// See
      /// [SearchProfilesRequest][google.cloud.talent.v4beta1.SearchProfilesRequest]
      /// for more information.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Talent.V4Beta1.SearchProfilesResponse> SearchProfilesAsync(global::Google.Cloud.Talent.V4Beta1.SearchProfilesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SearchProfilesAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Searches for profiles within a tenant.
      ///
      /// For example, search by raw queries "software engineer in Mountain View" or
      /// search by structured filters (location filter, education filter, etc.).
      ///
      /// See
      /// [SearchProfilesRequest][google.cloud.talent.v4beta1.SearchProfilesRequest]
      /// for more information.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Talent.V4Beta1.SearchProfilesResponse> SearchProfilesAsync(global::Google.Cloud.Talent.V4Beta1.SearchProfilesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SearchProfiles, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override ProfileServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ProfileServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(ProfileServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ListProfiles, serviceImpl.ListProfiles)
          .AddMethod(__Method_CreateProfile, serviceImpl.CreateProfile)
          .AddMethod(__Method_GetProfile, serviceImpl.GetProfile)
          .AddMethod(__Method_UpdateProfile, serviceImpl.UpdateProfile)
          .AddMethod(__Method_DeleteProfile, serviceImpl.DeleteProfile)
          .AddMethod(__Method_SearchProfiles, serviceImpl.SearchProfiles).Build();
    }

  }
}
#endregion
