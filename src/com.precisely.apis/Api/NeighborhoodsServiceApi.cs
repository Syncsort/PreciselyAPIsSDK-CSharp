/*
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * The version of the OpenAPI document: 12.0.1
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using RestSharp;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace com.precisely.apis.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface INeighborhoodsServiceApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Place By Location.
        /// </summary>
        /// <remarks>
        /// Identifies and retrieves the nearest neighborhood around a specific location. This service accepts latitude &amp; longitude as input and returns a place name.
        /// </remarks>
        /// <exception cref="com.precisely.apis.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="longitude">Longitude of the location. (optional)</param>
        /// <param name="latitude">Latitude of the location. (optional)</param>
        /// <param name="levelHint">Numeric code of geographic hierarchy level which is classified at six levels.Allowed values 1,2,3,4,5,6 (optional)</param>
        /// <returns>NeighborhoodsResponse</returns>
        NeighborhoodsResponse GetPlaceByLocation (string longitude = default(string), string latitude = default(string), string levelHint = default(string));

        /// <summary>
        /// Place By Location.
        /// </summary>
        /// <remarks>
        /// Identifies and retrieves the nearest neighborhood around a specific location. This service accepts latitude &amp; longitude as input and returns a place name.
        /// </remarks>
        /// <exception cref="com.precisely.apis.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="longitude">Longitude of the location. (optional)</param>
        /// <param name="latitude">Latitude of the location. (optional)</param>
        /// <param name="levelHint">Numeric code of geographic hierarchy level which is classified at six levels.Allowed values 1,2,3,4,5,6 (optional)</param>
        /// <returns>ApiResponse of NeighborhoodsResponse</returns>
        ApiResponse<NeighborhoodsResponse> GetPlaceByLocationWithHttpInfo (string longitude = default(string), string latitude = default(string), string levelHint = default(string));
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Place By Location.
        /// </summary>
        /// <remarks>
        /// Identifies and retrieves the nearest neighborhood around a specific location. This service accepts latitude &amp; longitude as input and returns a place name.
        /// </remarks>
        /// <exception cref="com.precisely.apis.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="longitude">Longitude of the location. (optional)</param>
        /// <param name="latitude">Latitude of the location. (optional)</param>
        /// <param name="levelHint">Numeric code of geographic hierarchy level which is classified at six levels.Allowed values 1,2,3,4,5,6 (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of NeighborhoodsResponse</returns>
        System.Threading.Tasks.Task<NeighborhoodsResponse> GetPlaceByLocationAsync (string longitude = default(string), string latitude = default(string), string levelHint = default(string), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Place By Location.
        /// </summary>
        /// <remarks>
        /// Identifies and retrieves the nearest neighborhood around a specific location. This service accepts latitude &amp; longitude as input and returns a place name.
        /// </remarks>
        /// <exception cref="com.precisely.apis.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="longitude">Longitude of the location. (optional)</param>
        /// <param name="latitude">Latitude of the location. (optional)</param>
        /// <param name="levelHint">Numeric code of geographic hierarchy level which is classified at six levels.Allowed values 1,2,3,4,5,6 (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (NeighborhoodsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<NeighborhoodsResponse>> GetPlaceByLocationWithHttpInfoAsync (string longitude = default(string), string latitude = default(string), string levelHint = default(string), CancellationToken cancellationToken = default(CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class NeighborhoodsServiceApi : INeighborhoodsServiceApi
    {
        private com.precisely.apis.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="NeighborhoodsServiceApi"/> class.
        /// </summary>
        /// <returns></returns>
        public NeighborhoodsServiceApi(String basePath)
        {
            this.Configuration = new com.precisely.apis.Client.Configuration { BasePath = basePath };

            ExceptionFactory = com.precisely.apis.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NeighborhoodsServiceApi"/> class
        /// </summary>
        /// <returns></returns>
        public NeighborhoodsServiceApi()
        {
            this.Configuration = com.precisely.apis.Client.Configuration.Default;

            ExceptionFactory = com.precisely.apis.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NeighborhoodsServiceApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public NeighborhoodsServiceApi(com.precisely.apis.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = com.precisely.apis.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = com.precisely.apis.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public com.precisely.apis.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public com.precisely.apis.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Place By Location. Identifies and retrieves the nearest neighborhood around a specific location. This service accepts latitude &amp; longitude as input and returns a place name.
        /// </summary>
        /// <exception cref="com.precisely.apis.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="longitude">Longitude of the location. (optional)</param>
        /// <param name="latitude">Latitude of the location. (optional)</param>
        /// <param name="levelHint">Numeric code of geographic hierarchy level which is classified at six levels.Allowed values 1,2,3,4,5,6 (optional)</param>
        /// <returns>NeighborhoodsResponse</returns>
        public NeighborhoodsResponse GetPlaceByLocation (string longitude = default(string), string latitude = default(string), string levelHint = default(string))
        {
             ApiResponse<NeighborhoodsResponse> localVarResponse = GetPlaceByLocationWithHttpInfo(longitude, latitude, levelHint);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Place By Location. Identifies and retrieves the nearest neighborhood around a specific location. This service accepts latitude &amp; longitude as input and returns a place name.
        /// </summary>
        /// <exception cref="com.precisely.apis.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="longitude">Longitude of the location. (optional)</param>
        /// <param name="latitude">Latitude of the location. (optional)</param>
        /// <param name="levelHint">Numeric code of geographic hierarchy level which is classified at six levels.Allowed values 1,2,3,4,5,6 (optional)</param>
        /// <returns>ApiResponse of NeighborhoodsResponse</returns>
        public ApiResponse<NeighborhoodsResponse> GetPlaceByLocationWithHttpInfo (string longitude = default(string), string latitude = default(string), string levelHint = default(string))
        {

            var localVarPath = "/neighborhoods/v1/place/bylocation";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "application/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (longitude != null) localVarQueryParams.Add("longitude", Configuration.ApiClient.ParameterToString(longitude)); // query parameter
            if (latitude != null) localVarQueryParams.Add("latitude", Configuration.ApiClient.ParameterToString(latitude)); // query parameter
            if (levelHint != null) localVarQueryParams.Add("levelHint", Configuration.ApiClient.ParameterToString(levelHint)); // query parameter

            // authentication (oAuth2Password) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }
                    else if (!String.IsNullOrEmpty(Configuration.OAuthApiKey) && !String.IsNullOrEmpty(Configuration.OAuthSecret))
                    {
                    Configuration.ApiClient.GenerateAndSetAccessToken(Configuration.OAuthApiKey,Configuration.OAuthSecret);
                    localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
                    }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetPlaceByLocation", localVarResponse);
                if (exception != null) throw exception;
            }

           return new ApiResponse<NeighborhoodsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x1 => x1.Name, x1 => x1.Value.ToString()),
                (NeighborhoodsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(NeighborhoodsResponse)));
            
            
        }

        /// <summary>
        /// Place By Location. Identifies and retrieves the nearest neighborhood around a specific location. This service accepts latitude &amp; longitude as input and returns a place name.
        /// </summary>
        /// <exception cref="com.precisely.apis.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="longitude">Longitude of the location. (optional)</param>
        /// <param name="latitude">Latitude of the location. (optional)</param>
        /// <param name="levelHint">Numeric code of geographic hierarchy level which is classified at six levels.Allowed values 1,2,3,4,5,6 (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of NeighborhoodsResponse</returns>
        public async System.Threading.Tasks.Task<NeighborhoodsResponse> GetPlaceByLocationAsync (string longitude = default(string), string latitude = default(string), string levelHint = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<NeighborhoodsResponse> localVarResponse = await GetPlaceByLocationWithHttpInfoAsync(longitude, latitude, levelHint, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Place By Location. Identifies and retrieves the nearest neighborhood around a specific location. This service accepts latitude &amp; longitude as input and returns a place name.
        /// </summary>
        /// <exception cref="com.precisely.apis.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="longitude">Longitude of the location. (optional)</param>
        /// <param name="latitude">Latitude of the location. (optional)</param>
        /// <param name="levelHint">Numeric code of geographic hierarchy level which is classified at six levels.Allowed values 1,2,3,4,5,6 (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (NeighborhoodsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<NeighborhoodsResponse>> GetPlaceByLocationWithHttpInfoAsync (string longitude = default(string), string latitude = default(string), string levelHint = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/neighborhoods/v1/place/bylocation";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "application/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

           if (longitude != null) localVarQueryParams.Add("longitude", Configuration.ApiClient.ParameterToString(longitude)); // query parameter
           if (latitude != null) localVarQueryParams.Add("latitude", Configuration.ApiClient.ParameterToString(latitude)); // query parameter
           if (levelHint != null) localVarQueryParams.Add("levelHint", Configuration.ApiClient.ParameterToString(levelHint)); // query parameter

            // authentication (oAuth2Password) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }
                    else if (!String.IsNullOrEmpty(Configuration.OAuthApiKey) && !String.IsNullOrEmpty(Configuration.OAuthSecret))
                    {
                    Configuration.ApiClient.GenerateAndSetAccessToken(Configuration.OAuthApiKey,Configuration.OAuthSecret);
                    localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
                    }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetPlaceByLocation", localVarResponse);
                if (exception != null) throw exception;
            }

           return new ApiResponse<NeighborhoodsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x1 => x1.Name, x1 => x1.Value.ToString()),
                (NeighborhoodsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(NeighborhoodsResponse)));
            
        }

    }
}