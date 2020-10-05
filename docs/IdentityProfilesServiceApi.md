# com.precisely.apis.Api.IdentityProfilesServiceApi

All URIs are relative to *https://api.precisely.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetIdentityByAddress**](IdentityProfilesServiceApi.md#getidentitybyaddress) | **GET** /identityprofiles/v1/identity/byaddress | Identities By Address
[**GetIdentityByEmail**](IdentityProfilesServiceApi.md#getidentitybyemail) | **GET** /identityprofiles/v1/identity/byemail | Identity By Email
[**GetIdentityByTwitter**](IdentityProfilesServiceApi.md#getidentitybytwitter) | **GET** /identityprofiles/v1/identity/bytwitter | Identity By Twitter


<a name="getidentitybyaddress"></a>
# **GetIdentityByAddress**
> IdentityResponse GetIdentityByAddress (string address, string confidence = null, string maxCandidates = null, string theme = null, string filter = null)

Identities By Address

Accepts an Address as input and returns rich localized Identity profiles, demographics, lifestyle segmentations, neighborhood names, property ownership & values, and social affinity insights from twitter, linkedin, and more along with education, job history and other identity information.

### Example
```csharp
using System;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetIdentityByAddressExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new IdentityProfilesServiceApi();
            var address = address_example;  // string | free form address text
            var confidence = confidence_example;  // string | To adjust quality threshold of data returned. Default is HIGH (optional) 
            var maxCandidates = maxCandidates_example;  // string | Number of identities returned in response (optional) 
            var theme = theme_example;  // string | theme parameter for filtering results (optional) 
            var filter = filter_example;  // string | filter params (optional) 

            try
            {
                // Identities By Address
                IdentityResponse result = apiInstance.GetIdentityByAddress(address, confidence, maxCandidates, theme, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProfilesServiceApi.GetIdentityByAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **string**| free form address text | 
 **confidence** | **string**| To adjust quality threshold of data returned. Default is HIGH | [optional] 
 **maxCandidates** | **string**| Number of identities returned in response | [optional] 
 **theme** | **string**| theme parameter for filtering results | [optional] 
 **filter** | **string**| filter params | [optional] 

### Return type

[**IdentityResponse**](IdentityResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getidentitybyemail"></a>
# **GetIdentityByEmail**
> Identity GetIdentityByEmail (string email, string confidence = null, string theme = null, string filter = null)

Identity By Email

Accepts an Email address as input and returns rich localized Identity profiles and social affinity insights from twitter, linkedin, and more along with education, job history and other identity information.

### Example
```csharp
using System;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetIdentityByEmailExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new IdentityProfilesServiceApi();
            var email = email_example;  // string | This specifies the email address
            var confidence = confidence_example;  // string | To adjust quality threshold of data returned. Default is HIGH (optional) 
            var theme = theme_example;  // string | theme parameter for filtering results (optional) 
            var filter = filter_example;  // string | filter params (optional) 

            try
            {
                // Identity By Email
                Identity result = apiInstance.GetIdentityByEmail(email, confidence, theme, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProfilesServiceApi.GetIdentityByEmail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **email** | **string**| This specifies the email address | 
 **confidence** | **string**| To adjust quality threshold of data returned. Default is HIGH | [optional] 
 **theme** | **string**| theme parameter for filtering results | [optional] 
 **filter** | **string**| filter params | [optional] 

### Return type

[**Identity**](Identity.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getidentitybytwitter"></a>
# **GetIdentityByTwitter**
> Identity GetIdentityByTwitter (string twitter, string confidence = null, string theme = null, string filter = null)

Identity By Twitter

Accepts a Twiiter handle as input and returns rich localized Identity profiles and social affinity insights from twitter, linkedin, and more along with education, job history and other identity information.

### Example
```csharp
using System;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetIdentityByTwitterExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new IdentityProfilesServiceApi();
            var twitter = twitter_example;  // string | Twitter handle of the identity.
            var confidence = confidence_example;  // string | To adjust quality threshold of data returned. Default is HIGH (optional) 
            var theme = theme_example;  // string | theme parameter for filtering results (optional) 
            var filter = filter_example;  // string | filter params (optional) 

            try
            {
                // Identity By Twitter
                Identity result = apiInstance.GetIdentityByTwitter(twitter, confidence, theme, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProfilesServiceApi.GetIdentityByTwitter: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **twitter** | **string**| Twitter handle of the identity. | 
 **confidence** | **string**| To adjust quality threshold of data returned. Default is HIGH | [optional] 
 **theme** | **string**| theme parameter for filtering results | [optional] 
 **filter** | **string**| filter params | [optional] 

### Return type

[**Identity**](Identity.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

