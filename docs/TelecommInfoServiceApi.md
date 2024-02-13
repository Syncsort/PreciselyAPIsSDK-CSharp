# com.precisely.apis.Api.TelecommInfoServiceApi

All URIs are relative to *https://api.precisely.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetRateCenterByAddress**](TelecommInfoServiceApi.md#getratecenterbyaddress) | **GET** /telecomm/v1/ratecenter/byaddress | Rate Center By Address.
[**GetRateCenterByLocation**](TelecommInfoServiceApi.md#getratecenterbylocation) | **GET** /telecomm/v1/ratecenter/bylocation | Rate Center By Location.



## GetRateCenterByAddress

> RateCenterResponse GetRateCenterByAddress (string address = null, string country = null, string areaCodeInfo = null, string level = null)

Rate Center By Address.

Accepts addresses as input and returns Incumbent Local Exchange Carrier (ILEC) doing-business-as names.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetRateCenterByAddressExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TelecommInfoServiceApi(Configuration.Default);
            var address = address_example;  // string | The address to be searched (optional) 
            var country = country_example;  // string | 3 letter ISO code of the country to be searched. Allowed values USA,CAN (optional) 
            var areaCodeInfo = areaCodeInfo_example;  // string | Specifies whether area code information will be part of response.Allowed values True,False. (optional) 
            var level = level_example;  // string | Level (basic/detail).Allowed values detail,basic. (optional) 

            try
            {
                // Rate Center By Address.
                RateCenterResponse result = apiInstance.GetRateCenterByAddress(address, country, areaCodeInfo, level);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TelecommInfoServiceApi.GetRateCenterByAddress: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **string**| The address to be searched | [optional] 
 **country** | **string**| 3 letter ISO code of the country to be searched. Allowed values USA,CAN | [optional] 
 **areaCodeInfo** | **string**| Specifies whether area code information will be part of response.Allowed values True,False. | [optional] 
 **level** | **string**| Level (basic/detail).Allowed values detail,basic. | [optional] 

### Return type

[**RateCenterResponse**](RateCenterResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetRateCenterByLocation

> RateCenterResponse GetRateCenterByLocation (string longitude = null, string latitude = null, string areaCodeInfo = null, string level = null)

Rate Center By Location.

Accepts latitude & longitude as input and returns Incumbent Local Exchange Carrier (ILEC) doing-business-as names.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetRateCenterByLocationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TelecommInfoServiceApi(Configuration.Default);
            var longitude = longitude_example;  // string | Longitude of the location (optional) 
            var latitude = latitude_example;  // string | Latitude of the location (optional) 
            var areaCodeInfo = areaCodeInfo_example;  // string | Specifies whether area code information will be part of response.Allowed values True,False. (optional) 
            var level = level_example;  // string | Level (basic/detail).Allowed values detail,basic. (optional) 

            try
            {
                // Rate Center By Location.
                RateCenterResponse result = apiInstance.GetRateCenterByLocation(longitude, latitude, areaCodeInfo, level);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TelecommInfoServiceApi.GetRateCenterByLocation: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **longitude** | **string**| Longitude of the location | [optional] 
 **latitude** | **string**| Latitude of the location | [optional] 
 **areaCodeInfo** | **string**| Specifies whether area code information will be part of response.Allowed values True,False. | [optional] 
 **level** | **string**| Level (basic/detail).Allowed values detail,basic. | [optional] 

### Return type

[**RateCenterResponse**](RateCenterResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

