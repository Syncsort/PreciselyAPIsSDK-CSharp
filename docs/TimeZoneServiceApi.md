# com.precisely.apis.Api.TimeZoneServiceApi

All URIs are relative to *https://api.precisely.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetBatchTimezoneByLocation**](TimeZoneServiceApi.md#getbatchtimezonebylocation) | **POST** /timezone/v1/timezone/bylocation | Timezone Batch by Location.
[**GetTimezoneByAddress**](TimeZoneServiceApi.md#gettimezonebyaddress) | **GET** /timezone/v1/timezone/byaddress | Timezone By Address.
[**GetTimezoneByAddressBatch**](TimeZoneServiceApi.md#gettimezonebyaddressbatch) | **POST** /timezone/v1/timezone/byaddress | Timezone Batch by Address.
[**GetTimezoneByLocation**](TimeZoneServiceApi.md#gettimezonebylocation) | **GET** /timezone/v1/timezone/bylocation | Timezone By Location.



## GetBatchTimezoneByLocation

> TimezoneResponseList GetBatchTimezoneByLocation (TimezoneLocationRequest timezoneLocationRequest)

Timezone Batch by Location.

Identifies and retrieves the local time of any location in the world for a given latitude, longitude and time. The input and retrieved time format is in milliseconds.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetBatchTimezoneByLocationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TimeZoneServiceApi(Configuration.Default);
            var timezoneLocationRequest = new TimezoneLocationRequest(); // TimezoneLocationRequest | 

            try
            {
                // Timezone Batch by Location.
                TimezoneResponseList result = apiInstance.GetBatchTimezoneByLocation(timezoneLocationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TimeZoneServiceApi.GetBatchTimezoneByLocation: " + e.Message );
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
 **timezoneLocationRequest** | [**TimezoneLocationRequest**](TimezoneLocationRequest.md)|  | 

### Return type

[**TimezoneResponseList**](TimezoneResponseList.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

- **Content-Type**: application/json, application/xml
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


## GetTimezoneByAddress

> TimezoneResponse GetTimezoneByAddress (string timestamp, string address, string matchMode = null, string country = null)

Timezone By Address.

Identifies and retrieves the local time of any location in the world for a given address and time. The input and retrieved time format is in milliseconds.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetTimezoneByAddressExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TimeZoneServiceApi(Configuration.Default);
            var timestamp = timestamp_example;  // string | Timestamp in miliseconds.
            var address = address_example;  // string | The address to be searched.
            var matchMode = Relaxed;  // string | Match modes determine the leniency used to make a match between the input address and the reference data (Default is relaxed) (optional) 
            var country = USA;  // string | Country ISO code (Default is USA) (optional) 

            try
            {
                // Timezone By Address.
                TimezoneResponse result = apiInstance.GetTimezoneByAddress(timestamp, address, matchMode, country);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TimeZoneServiceApi.GetTimezoneByAddress: " + e.Message );
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
 **timestamp** | **string**| Timestamp in miliseconds. | 
 **address** | **string**| The address to be searched. | 
 **matchMode** | **string**| Match modes determine the leniency used to make a match between the input address and the reference data (Default is relaxed) | [optional] 
 **country** | **string**| Country ISO code (Default is USA) | [optional] 

### Return type

[**TimezoneResponse**](TimezoneResponse.md)

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


## GetTimezoneByAddressBatch

> TimezoneResponseList GetTimezoneByAddressBatch (TimezoneAddressRequest timezoneAddressRequest)

Timezone Batch by Address.

Identifies and retrieves the local time of any location in the world for a given address and time. The input and retrieved time format is in milliseconds.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetTimezoneByAddressBatchExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TimeZoneServiceApi(Configuration.Default);
            var timezoneAddressRequest = new TimezoneAddressRequest(); // TimezoneAddressRequest | 

            try
            {
                // Timezone Batch by Address.
                TimezoneResponseList result = apiInstance.GetTimezoneByAddressBatch(timezoneAddressRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TimeZoneServiceApi.GetTimezoneByAddressBatch: " + e.Message );
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
 **timezoneAddressRequest** | [**TimezoneAddressRequest**](TimezoneAddressRequest.md)|  | 

### Return type

[**TimezoneResponseList**](TimezoneResponseList.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

- **Content-Type**: application/json, application/xml
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


## GetTimezoneByLocation

> TimezoneResponse GetTimezoneByLocation (string timestamp, string longitude, string latitude)

Timezone By Location.

Identifies and retrieves the local time of any location in the world for a given latitude, longitude and time. The input and retrieved time format is in milliseconds.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetTimezoneByLocationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TimeZoneServiceApi(Configuration.Default);
            var timestamp = timestamp_example;  // string | Timestamp in miliseconds.
            var longitude = longitude_example;  // string | Longitude of the location.
            var latitude = latitude_example;  // string | Latitude of the location.

            try
            {
                // Timezone By Location.
                TimezoneResponse result = apiInstance.GetTimezoneByLocation(timestamp, longitude, latitude);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TimeZoneServiceApi.GetTimezoneByLocation: " + e.Message );
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
 **timestamp** | **string**| Timestamp in miliseconds. | 
 **longitude** | **string**| Longitude of the location. | 
 **latitude** | **string**| Latitude of the location. | 

### Return type

[**TimezoneResponse**](TimezoneResponse.md)

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

