# com.precisely.apis.Api.TimeZoneServiceApi

All URIs are relative to *https://api.precisely.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetBatchTimezoneByAddress**](TimeZoneServiceApi.md#getbatchtimezonebyaddress) | **POST** /timezone/v1/timezone/byaddress | Timezone Batch by Address
[**GetBatchTimezoneByLocation**](TimeZoneServiceApi.md#getbatchtimezonebylocation) | **POST** /timezone/v1/timezone/bylocation | Timezone Batch by Location
[**GetTimezoneByAddress**](TimeZoneServiceApi.md#gettimezonebyaddress) | **GET** /timezone/v1/timezone/byaddress | Timezone By Address.
[**GetTimezoneByLocation**](TimeZoneServiceApi.md#gettimezonebylocation) | **GET** /timezone/v1/timezone/bylocation | Timezone By Location.


<a name="getbatchtimezonebyaddress"></a>
# **GetBatchTimezoneByAddress**
> TimezoneResponse GetBatchTimezoneByAddress (TimezoneAddressRequest body = null)

Timezone Batch by Address

Identifies and retrieves the local time of any location in the world for a given address and time. The input and retrieved time format is in milliseconds. 

### Example
```csharp
using System;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetBatchTimezoneByAddressExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new TimeZoneServiceApi();
            var body = new TimezoneAddressRequest(); // TimezoneAddressRequest |  (optional) 

            try
            {
                // Timezone Batch by Address
                TimezoneResponse result = apiInstance.GetBatchTimezoneByAddress(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimeZoneServiceApi.GetBatchTimezoneByAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TimezoneAddressRequest**](TimezoneAddressRequest.md)|  | [optional] 

### Return type

[**TimezoneResponse**](TimezoneResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbatchtimezonebylocation"></a>
# **GetBatchTimezoneByLocation**
> TimezoneLocationResponse GetBatchTimezoneByLocation (TimezoneLocationRequest body = null)

Timezone Batch by Location

Identifies and retrieves the local time of any location in the world for a given latitude, longitude and time. The input and retrieved time format is in milliseconds. 

### Example
```csharp
using System;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetBatchTimezoneByLocationExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new TimeZoneServiceApi();
            var body = new TimezoneLocationRequest(); // TimezoneLocationRequest |  (optional) 

            try
            {
                // Timezone Batch by Location
                TimezoneLocationResponse result = apiInstance.GetBatchTimezoneByLocation(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimeZoneServiceApi.GetBatchTimezoneByLocation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TimezoneLocationRequest**](TimezoneLocationRequest.md)|  | [optional] 

### Return type

[**TimezoneLocationResponse**](TimezoneLocationResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettimezonebyaddress"></a>
# **GetTimezoneByAddress**
> Timezone GetTimezoneByAddress (string timestamp, string address, string matchMode = null, string country = null)

Timezone By Address.

Identifies and retrieves the local time of any location in the world for a given address and time. The input and retrieved time format is in milliseconds.

### Example
```csharp
using System;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetTimezoneByAddressExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new TimeZoneServiceApi();
            var timestamp = timestamp_example;  // string | Timestamp in miliseconds.
            var address = address_example;  // string | The address to be searched.
            var matchMode = matchMode_example;  // string | Match modes determine the leniency used to make a match between the input address and the reference data. (optional)  (default to Relaxed)
            var country = country_example;  // string | Country ISO code. (optional)  (default to USA)

            try
            {
                // Timezone By Address.
                Timezone result = apiInstance.GetTimezoneByAddress(timestamp, address, matchMode, country);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimeZoneServiceApi.GetTimezoneByAddress: " + e.Message );
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
 **matchMode** | **string**| Match modes determine the leniency used to make a match between the input address and the reference data. | [optional] [default to Relaxed]
 **country** | **string**| Country ISO code. | [optional] [default to USA]

### Return type

[**Timezone**](Timezone.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettimezonebylocation"></a>
# **GetTimezoneByLocation**
> TimezoneLocation GetTimezoneByLocation (string timestamp, string longitude, string latitude)

Timezone By Location.

Identifies and retrieves the local time of any location in the world for a given latitude, longitude and time. The input and retrieved time format is in milliseconds.

### Example
```csharp
using System;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetTimezoneByLocationExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new TimeZoneServiceApi();
            var timestamp = timestamp_example;  // string | Timestamp in miliseconds.
            var longitude = longitude_example;  // string | Longitude of the location.
            var latitude = latitude_example;  // string | Latitude of the location.

            try
            {
                // Timezone By Location.
                TimezoneLocation result = apiInstance.GetTimezoneByLocation(timestamp, longitude, latitude);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimeZoneServiceApi.GetTimezoneByLocation: " + e.Message );
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

[**TimezoneLocation**](TimezoneLocation.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

