# com.precisely.apis.Api.NeighborhoodsServiceApi

All URIs are relative to *https://api.precisely.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetPlaceByLocation**](NeighborhoodsServiceApi.md#getplacebylocation) | **GET** /neighborhoods/v1/place/bylocation | Place By Location.



## GetPlaceByLocation

> NeighborhoodsResponse GetPlaceByLocation (string longitude = null, string latitude = null, string levelHint = null)

Place By Location.

Identifies and retrieves the nearest neighborhood around a specific location. This service accepts latitude & longitude as input and returns a place name.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetPlaceByLocationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NeighborhoodsServiceApi(Configuration.Default);
            var longitude = longitude_example;  // string | Longitude of the location. (optional) 
            var latitude = latitude_example;  // string | Latitude of the location. (optional) 
            var levelHint = levelHint_example;  // string | Numeric code of geographic hierarchy level which is classified at six levels.Allowed values 1,2,3,4,5,6 (optional) 

            try
            {
                // Place By Location.
                NeighborhoodsResponse result = apiInstance.GetPlaceByLocation(longitude, latitude, levelHint);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling NeighborhoodsServiceApi.GetPlaceByLocation: " + e.Message );
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
 **longitude** | **string**| Longitude of the location. | [optional] 
 **latitude** | **string**| Latitude of the location. | [optional] 
 **levelHint** | **string**| Numeric code of geographic hierarchy level which is classified at six levels.Allowed values 1,2,3,4,5,6 | [optional] 

### Return type

[**NeighborhoodsResponse**](NeighborhoodsResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/xml


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

