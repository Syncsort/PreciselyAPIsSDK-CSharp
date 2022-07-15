/*
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * The version of the OpenAPI document: 11.9.4
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
    public interface ITelecommInfoServiceApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Rate Center By Address.
        /// </summary>
        /// <remarks>
        /// Accepts addresses as input and returns Incumbent Local Exchange Carrier (ILEC) doing-business-as names.
        /// </remarks>
        /// <exception cref="com.precisely.apis.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">The address to be searched (optional)</param>
        /// <param name="country">3 letter ISO code of the country to be searched. Allowed values USA,CAN (optional)</param>
        /// <param name="areaCodeInfo">Specifies whether area code information will be part of response.Allowed values True,False. (optional)</param>
        /// <param name="level">Level (basic/detail).Allowed values detail,basic. (optional)</param>
        /// <returns>RateCenterResponse</returns>
        RateCenterResponse GetRateCenterByAddress (string address = default(string), string country = default(string), string areaCodeInfo = default(string), string level = default(string));

        /// <summary>
        /// Rate Center By Address.
        /// </summary>
        /// <remarks>
        /// Accepts addresses as input and returns Incumbent Local Exchange Carrier (ILEC) doing-business-as names.
        /// </remarks>
        /// <exception cref="com.precisely.apis.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">The address to be searched (optional)</param>
        /// <param name="country">3 letter ISO code of the country to be searched. Allowed values USA,CAN (optional)</param>
        /// <param name="areaCodeInfo">Specifies whether area code information will be part of response.Allowed values True,False. (optional)</param>
        /// <param name="level">Level (basic/detail).Allowed values detail,basic. (optional)</param>
        /// <returns>ApiResponse of RateCenterResponse</returns>
        ApiResponse<RateCenterResponse> GetRateCenterByAddressWithHttpInfo (string address = default(string), string country = default(string), string areaCodeInfo = default(string), string level = default(string));
        /// <summary>
        /// Rate Center By Location.
        /// </summary>
        /// <remarks>
        /// Accepts latitude &amp; longitude as input and returns Incumbent Local Exchange Carrier (ILEC) doing-business-as names.
        /// </remarks>
        /// <exception cref="com.precisely.apis.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="longitude">Longitude of the location (optional)</param>
        /// <param name="latitude">Latitude of the location (optional)</param>
        /// <param name="areaCodeInfo">Specifies whether area code information will be part of response.Allowed values True,False. (optional)</param>
        /// <param name="level">Level (basic/detail).Allowed values detail,basic. (optional)</param>
        /// <returns>RateCenterResponse</returns>
        RateCenterResponse GetRateCenterByLocation (string longitude = default(string), string latitude = default(string), string areaCodeInfo = default(string), string level = default(string));

        /// <summary>
        /// Rate Center By Location.
        /// </summary>
        /// <remarks>
        /// Accepts latitude &amp; longitude as input and returns Incumbent Local Exchange Carrier (ILEC) doing-business-as names.
        /// </remarks>
        /// <exception cref="com.precisely.apis.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="longitude">Longitude of the location (optional)</param>
        /// <param name="latitude">Latitude of the location (optional)</param>
        /// <param name="areaCodeInfo">Specifies whether area code information will be part of response.Allowed values True,False. (optional)</param>
        /// <param name="level">Level (basic/detail).Allowed values detail,basic. (optional)</param>
        /// <returns>ApiResponse of RateCenterResponse</returns>
        ApiResponse<RateCenterResponse> GetRateCenterByLocationWithHttpInfo (string longitude = default(string), string latitude = default(string), string areaCodeInfo = default(string), string level = default(string));
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Rate Center By Address.
        /// </summary>
        /// <remarks>
        /// Accepts addresses as input and returns Incumbent Local Exchange Carrier (ILEC) doing-business-as names.
        /// </remarks>
        /// <exception cref="com.precisely.apis.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">The address to be searched (optional)</param>
        /// <param name="country">3 letter ISO code of the country to be searched. Allowed values USA,CAN (optional)</param>
        /// <param name="areaCodeInfo">Specifies whether area code information will be part of response.Allowed values True,False. (optional)</param>
        /// <param name="level">Level (basic/detail).Allowed values detail,basic. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of RateCenterResponse</returns>
        System.Threading.Tasks.Task<RateCenterResponse> GetRateCenterByAddressAsync (string address = default(string), string country = default(string), string areaCodeInfo = default(string), string level = default(string), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Rate Center By Address.
        /// </summary>
        /// <remarks>
        /// Accepts addresses as input and returns Incumbent Local Exchange Carrier (ILEC) doing-business-as names.
        /// </remarks>
        /// <exception cref="com.precisely.apis.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">The address to be searched (optional)</param>
        /// <param name="country">3 letter ISO code of the country to be searched. Allowed values USA,CAN (optional)</param>
        /// <param name="areaCodeInfo">Specifies whether area code information will be part of response.Allowed values True,False. (optional)</param>
        /// <param name="level">Level (basic/detail).Allowed values detail,basic. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (RateCenterResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<RateCenterResponse>> GetRateCenterByAddressWithHttpInfoAsync (string address = default(string), string country = default(string), string areaCodeInfo = default(string), string level = default(string), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Rate Center By Location.
        /// </summary>
        /// <remarks>
        /// Accepts latitude &amp; longitude as input and returns Incumbent Local Exchange Carrier (ILEC) doing-business-as names.
        /// </remarks>
        /// <exception cref="com.precisely.apis.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="longitude">Longitude of the location (optional)</param>
        /// <param name="latitude">Latitude of the location (optional)</param>
        /// <param name="areaCodeInfo">Specifies whether area code information will be part of response.Allowed values True,False. (optional)</param>
        /// <param name="level">Level (basic/detail).Allowed values detail,basic. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of RateCenterResponse</returns>
        System.Threading.Tasks.Task<RateCenterResponse> GetRateCenterByLocationAsync (string longitude = default(string), string latitude = default(string), string areaCodeInfo = default(string), string level = default(string), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Rate Center By Location.
        /// </summary>
        /// <remarks>
        /// Accepts latitude &amp; longitude as input and returns Incumbent Local Exchange Carrier (ILEC) doing-business-as names.
        /// </remarks>
        /// <exception cref="com.precisely.apis.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="longitude">Longitude of the location (optional)</param>
        /// <param name="latitude">Latitude of the location (optional)</param>
        /// <param name="areaCodeInfo">Specifies whether area code information will be part of response.Allowed values True,False. (optional)</param>
        /// <param name="level">Level (basic/detail).Allowed values detail,basic. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (RateCenterResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<RateCenterResponse>> GetRateCenterByLocationWithHttpInfoAsync (string longitude = default(string), string latitude = default(string), string areaCodeInfo = default(string), string level = default(string), CancellationToken cancellationToken = default(CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TelecommInfoServiceApi : ITelecommInfoServiceApi
    {
        private com.precisely.apis.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="TelecommInfoServiceApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TelecommInfoServiceApi(String basePath)
        {
            this.Configuration = new com.precisely.apis.Client.Configuration { BasePath = basePath };

            ExceptionFactory = com.precisely.apis.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TelecommInfoServiceApi"/> class
        /// </summary>
        /// <returns></returns>
        public TelecommInfoServiceApi()
        {
            this.Configuration = com.precisely.apis.Client.Configuration.Default;

            ExceptionFactory = com.precisely.apis.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TelecommInfoServiceApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TelecommInfoServiceApi(com.precisely.apis.Client.Configuration configuration = null)
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
        /// Rate Center By Address. Accepts addresses as input and returns Incumbent Local Exchange Carrier (ILEC) doing-business-as names.
        /// </summary>
        /// <exception cref="com.precisely.apis.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">The address to be searched (optional)</param>
        /// <param name="country">3 letter ISO code of the country to be searched. Allowed values USA,CAN (optional)</param>
        /// <param name="areaCodeInfo">Specifies whether area code information will be part of response.Allowed values True,False. (optional)</param>
        /// <param name="level">Level (basic/detail).Allowed values detail,basic. (optional)</param>
        /// <returns>RateCenterResponse</returns>
        public RateCenterResponse GetRateCenterByAddress (string address = default(string), string country = default(string), string areaCodeInfo = default(string), string level = default(string))
        {
             ApiResponse<RateCenterResponse> localVarResponse = GetRateCenterByAddressWithHttpInfo(address, country, areaCodeInfo, level);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Rate Center By Address. Accepts addresses as input and returns Incumbent Local Exchange Carrier (ILEC) doing-business-as names.
        /// </summary>
        /// <exception cref="com.precisely.apis.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">The address to be searched (optional)</param>
        /// <param name="country">3 letter ISO code of the country to be searched. Allowed values USA,CAN (optional)</param>
        /// <param name="areaCodeInfo">Specifies whether area code information will be part of response.Allowed values True,False. (optional)</param>
        /// <param name="level">Level (basic/detail).Allowed values detail,basic. (optional)</param>
        /// <returns>ApiResponse of RateCenterResponse</returns>
        public ApiResponse<RateCenterResponse> GetRateCenterByAddressWithHttpInfo (string address = default(string), string country = default(string), string areaCodeInfo = default(string), string level = default(string))
        {

            var localVarPath = "/telecomm/v1/ratecenter/byaddress";
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

            if (address != null) localVarQueryParams.Add("address", Configuration.ApiClient.ParameterToString(address)); // query parameter
            if (country != null) localVarQueryParams.Add("country", Configuration.ApiClient.ParameterToString(country)); // query parameter
            if (areaCodeInfo != null) localVarQueryParams.Add("areaCodeInfo", Configuration.ApiClient.ParameterToString(areaCodeInfo)); // query parameter
            if (level != null) localVarQueryParams.Add("level", Configuration.ApiClient.ParameterToString(level)); // query parameter

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
                Exception exception = ExceptionFactory("GetRateCenterByAddress", localVarResponse);
                if (exception != null) throw exception;
            }

           return new ApiResponse<RateCenterResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x1 => x1.Name, x1 => x1.Value.ToString()),
                (RateCenterResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RateCenterResponse)));
            
            
        }

        /// <summary>
        /// Rate Center By Address. Accepts addresses as input and returns Incumbent Local Exchange Carrier (ILEC) doing-business-as names.
        /// </summary>
        /// <exception cref="com.precisely.apis.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">The address to be searched (optional)</param>
        /// <param name="country">3 letter ISO code of the country to be searched. Allowed values USA,CAN (optional)</param>
        /// <param name="areaCodeInfo">Specifies whether area code information will be part of response.Allowed values True,False. (optional)</param>
        /// <param name="level">Level (basic/detail).Allowed values detail,basic. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of RateCenterResponse</returns>
        public async System.Threading.Tasks.Task<RateCenterResponse> GetRateCenterByAddressAsync (string address = default(string), string country = default(string), string areaCodeInfo = default(string), string level = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<RateCenterResponse> localVarResponse = await GetRateCenterByAddressWithHttpInfoAsync(address, country, areaCodeInfo, level, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Rate Center By Address. Accepts addresses as input and returns Incumbent Local Exchange Carrier (ILEC) doing-business-as names.
        /// </summary>
        /// <exception cref="com.precisely.apis.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">The address to be searched (optional)</param>
        /// <param name="country">3 letter ISO code of the country to be searched. Allowed values USA,CAN (optional)</param>
        /// <param name="areaCodeInfo">Specifies whether area code information will be part of response.Allowed values True,False. (optional)</param>
        /// <param name="level">Level (basic/detail).Allowed values detail,basic. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (RateCenterResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RateCenterResponse>> GetRateCenterByAddressWithHttpInfoAsync (string address = default(string), string country = default(string), string areaCodeInfo = default(string), string level = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/telecomm/v1/ratecenter/byaddress";
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

           if (address != null) localVarQueryParams.Add("address", Configuration.ApiClient.ParameterToString(address)); // query parameter
           if (country != null) localVarQueryParams.Add("country", Configuration.ApiClient.ParameterToString(country)); // query parameter
           if (areaCodeInfo != null) localVarQueryParams.Add("areaCodeInfo", Configuration.ApiClient.ParameterToString(areaCodeInfo)); // query parameter
           if (level != null) localVarQueryParams.Add("level", Configuration.ApiClient.ParameterToString(level)); // query parameter

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
                Exception exception = ExceptionFactory("GetRateCenterByAddress", localVarResponse);
                if (exception != null) throw exception;
            }

           return new ApiResponse<RateCenterResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x1 => x1.Name, x1 => x1.Value.ToString()),
                (RateCenterResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RateCenterResponse)));
            
        }

        /// <summary>
        /// Rate Center By Location. Accepts latitude &amp; longitude as input and returns Incumbent Local Exchange Carrier (ILEC) doing-business-as names.
        /// </summary>
        /// <exception cref="com.precisely.apis.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="longitude">Longitude of the location (optional)</param>
        /// <param name="latitude">Latitude of the location (optional)</param>
        /// <param name="areaCodeInfo">Specifies whether area code information will be part of response.Allowed values True,False. (optional)</param>
        /// <param name="level">Level (basic/detail).Allowed values detail,basic. (optional)</param>
        /// <returns>RateCenterResponse</returns>
        public RateCenterResponse GetRateCenterByLocation (string longitude = default(string), string latitude = default(string), string areaCodeInfo = default(string), string level = default(string))
        {
             ApiResponse<RateCenterResponse> localVarResponse = GetRateCenterByLocationWithHttpInfo(longitude, latitude, areaCodeInfo, level);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Rate Center By Location. Accepts latitude &amp; longitude as input and returns Incumbent Local Exchange Carrier (ILEC) doing-business-as names.
        /// </summary>
        /// <exception cref="com.precisely.apis.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="longitude">Longitude of the location (optional)</param>
        /// <param name="latitude">Latitude of the location (optional)</param>
        /// <param name="areaCodeInfo">Specifies whether area code information will be part of response.Allowed values True,False. (optional)</param>
        /// <param name="level">Level (basic/detail).Allowed values detail,basic. (optional)</param>
        /// <returns>ApiResponse of RateCenterResponse</returns>
        public ApiResponse<RateCenterResponse> GetRateCenterByLocationWithHttpInfo (string longitude = default(string), string latitude = default(string), string areaCodeInfo = default(string), string level = default(string))
        {

            var localVarPath = "/telecomm/v1/ratecenter/bylocation";
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
            if (areaCodeInfo != null) localVarQueryParams.Add("areaCodeInfo", Configuration.ApiClient.ParameterToString(areaCodeInfo)); // query parameter
            if (level != null) localVarQueryParams.Add("level", Configuration.ApiClient.ParameterToString(level)); // query parameter

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
                Exception exception = ExceptionFactory("GetRateCenterByLocation", localVarResponse);
                if (exception != null) throw exception;
            }

           return new ApiResponse<RateCenterResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x1 => x1.Name, x1 => x1.Value.ToString()),
                (RateCenterResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RateCenterResponse)));
            
            
        }

        /// <summary>
        /// Rate Center By Location. Accepts latitude &amp; longitude as input and returns Incumbent Local Exchange Carrier (ILEC) doing-business-as names.
        /// </summary>
        /// <exception cref="com.precisely.apis.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="longitude">Longitude of the location (optional)</param>
        /// <param name="latitude">Latitude of the location (optional)</param>
        /// <param name="areaCodeInfo">Specifies whether area code information will be part of response.Allowed values True,False. (optional)</param>
        /// <param name="level">Level (basic/detail).Allowed values detail,basic. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of RateCenterResponse</returns>
        public async System.Threading.Tasks.Task<RateCenterResponse> GetRateCenterByLocationAsync (string longitude = default(string), string latitude = default(string), string areaCodeInfo = default(string), string level = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<RateCenterResponse> localVarResponse = await GetRateCenterByLocationWithHttpInfoAsync(longitude, latitude, areaCodeInfo, level, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Rate Center By Location. Accepts latitude &amp; longitude as input and returns Incumbent Local Exchange Carrier (ILEC) doing-business-as names.
        /// </summary>
        /// <exception cref="com.precisely.apis.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="longitude">Longitude of the location (optional)</param>
        /// <param name="latitude">Latitude of the location (optional)</param>
        /// <param name="areaCodeInfo">Specifies whether area code information will be part of response.Allowed values True,False. (optional)</param>
        /// <param name="level">Level (basic/detail).Allowed values detail,basic. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (RateCenterResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RateCenterResponse>> GetRateCenterByLocationWithHttpInfoAsync (string longitude = default(string), string latitude = default(string), string areaCodeInfo = default(string), string level = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/telecomm/v1/ratecenter/bylocation";
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
           if (areaCodeInfo != null) localVarQueryParams.Add("areaCodeInfo", Configuration.ApiClient.ParameterToString(areaCodeInfo)); // query parameter
           if (level != null) localVarQueryParams.Add("level", Configuration.ApiClient.ParameterToString(level)); // query parameter

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
                Exception exception = ExceptionFactory("GetRateCenterByLocation", localVarResponse);
                if (exception != null) throw exception;
            }

           return new ApiResponse<RateCenterResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x1 => x1.Name, x1 => x1.Value.ToString()),
                (RateCenterResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RateCenterResponse)));
            
        }

    }
}