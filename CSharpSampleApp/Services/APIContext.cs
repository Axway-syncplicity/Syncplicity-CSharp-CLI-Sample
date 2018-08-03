﻿using System;

using CSharpSampleApp.OAuth;

namespace CSharpSampleApp.Services
{
    /// <summary>
    /// The class to store current API context.
    /// </summary>
    public class ApiContext
    {
        #region Public Properties

        /// <summary>
        /// Gets the flag which indicate what current context is authenticated.
        /// </summary>
        public static bool Authenticated => !string.IsNullOrEmpty(AccessToken);

        /// <summary>
        /// Gets the current context access token.
        /// </summary>
        public static string AccessToken => OAuthResponse != null ? OAuthResponse.AccessToken : string.Empty;

        /// <summary>
        /// Gets the current context refresh token.
        /// </summary>
        public static string RefreshToken => OAuthResponse != null ? OAuthResponse.RefreshToken : string.Empty;

        /// <summary>
        /// Gets the current context user's email.
        /// </summary>
        public static string UserEmail => OAuthResponse != null ? OAuthResponse.UserEmail : string.Empty;

        /// <summary>
        /// Gets the current context user company Id.
        /// </summary>
        public static Guid? CompanyGuid => OAuthResponse?.CompanyGuid;

        public static TokenResponse OAuthResponse { private get;  set; }

        public static bool HasStorageEndpoint { get; set; }

        /// <summary>
        /// Machine token is used to perform API calls with the security token tied to specific machine id.
        /// </summary>
        public static string MachineToken { get; set; }

        /// <summary>
        /// If set then request will be performed OnBehalfOf user.
        /// </summary>
        public static Guid? OnBehalfOfUser { get; set; }

        #endregion Public Properties
    }
}