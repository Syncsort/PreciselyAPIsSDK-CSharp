# com.precisely.apis.Api.StreetsServiceApi

All URIs are relative to *https://api.precisely.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetIntersectionByAddress**](StreetsServiceApi.md#getintersectionbyaddress) | **GET** /streets/v1/intersection/byaddress | Nearest Intesection By Address.
[**GetIntersectionByLocation**](StreetsServiceApi.md#getintersectionbylocation) | **GET** /streets/v1/intersection/bylocation | Nearest Intesection By Location.
[**GetNearestSpeedLimit**](StreetsServiceApi.md#getnearestspeedlimit) | **GET** /streets/v1/speedlimit | Nearest Speedlimit.



## GetIntersectionByAddress

> IntersectionResponse GetIntersectionByAddress (string address = null, string roadClass = null, string driveTime = null, string driveTimeUnit = null, string searchRadius = null, string searchRadiusUnit = null, string historicSpeed = null, string maxCandidates = null)

Nearest Intesection By Address.

This service accepts an address as input and returns the Nearest Intersection.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetIntersectionByAddressExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StreetsServiceApi(Configuration.Default);
            var address = address_example;  // string | Address (optional) 
            var roadClass = roadClass_example;  // string | Filters roads with specified class, allowed values are (Major, Secondary, Other and All), default is All (optional) 
            var driveTime = driveTime_example;  // string | Returns Intersection in specified drive time (optional) 
            var driveTimeUnit = driveTimeUnit_example;  // string | Drive time unit, allowed values are (hours, minutes, seconds and milliseconds), default is minutes (optional) 
            var searchRadius = searchRadius_example;  // string | Search radius within which user wants to search, default is 50 miles (optional) 
            var searchRadiusUnit = searchRadiusUnit_example;  // string | Search radius unit, allowed values are (feet, meter, kilometers and miles) (optional) 
            var historicSpeed = historicSpeed_example;  // string | Traffic flow in peak time, allowed values are (AMPEAK,PMPEAK,OFFPEAK,NIGHT) (optional) 
            var maxCandidates = maxCandidates_example;  // string | max candidates to be returned default is 1 (optional) 

            try
            {
                // Nearest Intesection By Address.
                IntersectionResponse result = apiInstance.GetIntersectionByAddress(address, roadClass, driveTime, driveTimeUnit, searchRadius, searchRadiusUnit, historicSpeed, maxCandidates);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling StreetsServiceApi.GetIntersectionByAddress: " + e.Message );
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
 **address** | **string**| Address | [optional] 
 **roadClass** | **string**| Filters roads with specified class, allowed values are (Major, Secondary, Other and All), default is All | [optional] 
 **driveTime** | **string**| Returns Intersection in specified drive time | [optional] 
 **driveTimeUnit** | **string**| Drive time unit, allowed values are (hours, minutes, seconds and milliseconds), default is minutes | [optional] 
 **searchRadius** | **string**| Search radius within which user wants to search, default is 50 miles | [optional] 
 **searchRadiusUnit** | **string**| Search radius unit, allowed values are (feet, meter, kilometers and miles) | [optional] 
 **historicSpeed** | **string**| Traffic flow in peak time, allowed values are (AMPEAK,PMPEAK,OFFPEAK,NIGHT) | [optional] 
 **maxCandidates** | **string**| max candidates to be returned default is 1 | [optional] 

### Return type

[**IntersectionResponse**](IntersectionResponse.md)

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


## GetIntersectionByLocation

> IntersectionResponse GetIntersectionByLocation (string longitude = null, string latitude = null, string roadClass = null, string driveTime = null, string driveTimeUnit = null, string searchRadius = null, string searchRadiusUnit = null, string historicSpeed = null, string maxCandidates = null)

Nearest Intesection By Location.

This service accepts latitude/longitude as input and returns the Nearest Intersection.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetIntersectionByLocationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StreetsServiceApi(Configuration.Default);
            var longitude = longitude_example;  // string | Longitude of the location. (optional) 
            var latitude = latitude_example;  // string | Latitude of the location. (optional) 
            var roadClass = roadClass_example;  // string | Filters roads with specified class, allowed values are (Major, Secondary, Other and All), default is All (optional) 
            var driveTime = driveTime_example;  // string | Returns Intersection in specified drive time (optional) 
            var driveTimeUnit = driveTimeUnit_example;  // string | Drive time unit, allowed values are (hours, minutes, seconds and milliseconds), default is minutes (optional) 
            var searchRadius = searchRadius_example;  // string | Search radius within which user wants to search, default is 50 miles (optional) 
            var searchRadiusUnit = searchRadiusUnit_example;  // string | Search radius unit, allowed values are (feet, meter, kilometers and miles) (optional) 
            var historicSpeed = historicSpeed_example;  // string | Traffic flow in peak time, allowed values are (AMPEAK,PMPEAK,OFFPEAK,NIGHT) (optional) 
            var maxCandidates = maxCandidates_example;  // string | max candidates to be returned default is 1 (optional) 

            try
            {
                // Nearest Intesection By Location.
                IntersectionResponse result = apiInstance.GetIntersectionByLocation(longitude, latitude, roadClass, driveTime, driveTimeUnit, searchRadius, searchRadiusUnit, historicSpeed, maxCandidates);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling StreetsServiceApi.GetIntersectionByLocation: " + e.Message );
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
 **roadClass** | **string**| Filters roads with specified class, allowed values are (Major, Secondary, Other and All), default is All | [optional] 
 **driveTime** | **string**| Returns Intersection in specified drive time | [optional] 
 **driveTimeUnit** | **string**| Drive time unit, allowed values are (hours, minutes, seconds and milliseconds), default is minutes | [optional] 
 **searchRadius** | **string**| Search radius within which user wants to search, default is 50 miles | [optional] 
 **searchRadiusUnit** | **string**| Search radius unit, allowed values are (feet, meter, kilometers and miles) | [optional] 
 **historicSpeed** | **string**| Traffic flow in peak time, allowed values are (AMPEAK,PMPEAK,OFFPEAK,NIGHT) | [optional] 
 **maxCandidates** | **string**| max candidates to be returned default is 1 | [optional] 

### Return type

[**IntersectionResponse**](IntersectionResponse.md)

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


## GetNearestSpeedLimit

> SpeedLimit GetNearestSpeedLimit (string path = null)

Nearest Speedlimit.

This service accepts point coordinates of a path as input and returns the posted speed limit of the road segment on which this path will snap.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetNearestSpeedLimitExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StreetsServiceApi(Configuration.Default);
            var path = path_example;  // string | Accepts multiple points which will be snapped to the nearest road segment. Longitude and Latitude will be comma separated (longitude,latitude) and Point Coordinates will be separated by semi-colon(;) (optional) 

            try
            {
                // Nearest Speedlimit.
                SpeedLimit result = apiInstance.GetNearestSpeedLimit(path);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling StreetsServiceApi.GetNearestSpeedLimit: " + e.Message );
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
 **path** | **string**| Accepts multiple points which will be snapped to the nearest road segment. Longitude and Latitude will be comma separated (longitude,latitude) and Point Coordinates will be separated by semi-colon(;) | [optional] 

### Return type

[**SpeedLimit**](SpeedLimit.md)

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

