# com.precisely.apis.Api.PSAP911ServiceApi

All URIs are relative to *https://api.precisely.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAHJPlusPSAPByAddress**](PSAP911ServiceApi.md#getahjpluspsapbyaddress) | **GET** /911/v1/ahj-psap/byaddress | AHJ &amp; PSAP By Address.
[**GetAHJPlusPSAPByLocation**](PSAP911ServiceApi.md#getahjpluspsapbylocation) | **GET** /911/v1/ahj-psap/bylocation | AHJ &amp; PSAP By Location
[**GetPSAPByAddress**](PSAP911ServiceApi.md#getpsapbyaddress) | **GET** /911/v1/psap/byaddress | PSAP By Address.
[**GetPSAPByLocation**](PSAP911ServiceApi.md#getpsapbylocation) | **GET** /911/v1/psap/bylocation | PSAP By Location.



## GetAHJPlusPSAPByAddress

> AHJPlusPSAPResponse GetAHJPlusPSAPByAddress (string address)

AHJ & PSAP By Address.

Accepts addresses as input and Returns contact details for Authorities Having Jurisdiction (AHJ) on-behalf-of local Public Safety Answering Points (PSAP). 911/PSAP accepts an address and returns PSAP contact data plus contact data for an AHJ to communicate directly with a PSAP. Details include agency name, phone number, city name, coverage, contact person's details, site details and mailing addresses for EMS, Fire, and Police PSAP contacts.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetAHJPlusPSAPByAddressExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PSAP911ServiceApi(Configuration.Default);
            var address = address_example;  // string | The address to be searched.

            try
            {
                // AHJ & PSAP By Address.
                AHJPlusPSAPResponse result = apiInstance.GetAHJPlusPSAPByAddress(address);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PSAP911ServiceApi.GetAHJPlusPSAPByAddress: " + e.Message );
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
 **address** | **string**| The address to be searched. | 

### Return type

[**AHJPlusPSAPResponse**](AHJPlusPSAPResponse.md)

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


## GetAHJPlusPSAPByLocation

> AHJPlusPSAPResponse GetAHJPlusPSAPByLocation (string longitude, string latitude)

AHJ & PSAP By Location

Accepts latitude & longitude as input and Returns contact details for Authorities Having Jurisdiction (AHJ) on-behalf-of local Public Safety Answering Points (PSAP). 911/PSAP accepts a location coordinate and returns PSAP contact data plus contact data for an AHJ to communicate directly with a PSAP. Details include agency name, phone number, city name, coverage, contact person's details, site details and mailing addresses for EMS, Fire, and Police PSAP contacts.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetAHJPlusPSAPByLocationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PSAP911ServiceApi(Configuration.Default);
            var longitude = longitude_example;  // string | Longitude of the location.
            var latitude = latitude_example;  // string | Latitude of the location.

            try
            {
                // AHJ & PSAP By Location
                AHJPlusPSAPResponse result = apiInstance.GetAHJPlusPSAPByLocation(longitude, latitude);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PSAP911ServiceApi.GetAHJPlusPSAPByLocation: " + e.Message );
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
 **longitude** | **string**| Longitude of the location. | 
 **latitude** | **string**| Latitude of the location. | 

### Return type

[**AHJPlusPSAPResponse**](AHJPlusPSAPResponse.md)

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


## GetPSAPByAddress

> PSAPResponse GetPSAPByAddress (string address)

PSAP By Address.

Accepts addresses as input and Returns contact details for local Public Safety Answering Points (PSAP). 911/PSAP accepts an address as input and returns the relevant PSAP address and contact details including agency name, phone number, county name, coverage, contact person's details, site details and mailing address.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetPSAPByAddressExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PSAP911ServiceApi(Configuration.Default);
            var address = address_example;  // string | The address to be searched.

            try
            {
                // PSAP By Address.
                PSAPResponse result = apiInstance.GetPSAPByAddress(address);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PSAP911ServiceApi.GetPSAPByAddress: " + e.Message );
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
 **address** | **string**| The address to be searched. | 

### Return type

[**PSAPResponse**](PSAPResponse.md)

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


## GetPSAPByLocation

> PSAPResponse GetPSAPByLocation (string longitude, string latitude)

PSAP By Location.

Accepts latitude & longitude as input and Returns contact details for local Public Safety Answering Points (PSAP). 911/PSAP accepts a location coordinate and returns the relevant PSAP address and contact details including dispatch name, phone number, county name, coverage, contact person's details, site details and mailing address.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetPSAPByLocationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PSAP911ServiceApi(Configuration.Default);
            var longitude = longitude_example;  // string | Longitude of the location.
            var latitude = latitude_example;  // string | Latitude of the location.

            try
            {
                // PSAP By Location.
                PSAPResponse result = apiInstance.GetPSAPByLocation(longitude, latitude);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PSAP911ServiceApi.GetPSAPByLocation: " + e.Message );
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
 **longitude** | **string**| Longitude of the location. | 
 **latitude** | **string**| Latitude of the location. | 

### Return type

[**PSAPResponse**](PSAPResponse.md)

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

