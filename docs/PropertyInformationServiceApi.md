# com.precisely.apis.Api.PropertyInformationServiceApi

All URIs are relative to *https://api.precisely.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetParcelBoundaryByAddress**](PropertyInformationServiceApi.md#getparcelboundarybyaddress) | **GET** /property/v2/parcelboundary/byaddress | Get Parcel Boundary By Address
[**GetParcelBoundaryByLocation**](PropertyInformationServiceApi.md#getparcelboundarybylocation) | **GET** /property/v2/parcelboundary/bylocation | Get Parcel Boundary By Location
[**GetParcelBoundaryByPreciselyID**](PropertyInformationServiceApi.md#getparcelboundarybypreciselyid) | **GET** /property/v2/parcelboundary/bypreciselyID | Get Parcel Boundary By PreciselyID
[**GetPropertyAttributesByAddress**](PropertyInformationServiceApi.md#getpropertyattributesbyaddress) | **GET** /property/v2/attributes/byaddress | PropertyV2 Attributes By Address.
[**GetPropertyAttributesByAddressBatch**](PropertyInformationServiceApi.md#getpropertyattributesbyaddressbatch) | **POST** /property/v2/attributes/byaddress | PropertyV2 Attributes By Address Batch.



## GetParcelBoundaryByAddress

> ParcelBoundaryV2 GetParcelBoundaryByAddress (string address)

Get Parcel Boundary By Address

Accepts address as input and returns property parcel boundary around that address.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetParcelBoundaryByAddressExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PropertyInformationServiceApi(Configuration.Default);
            var address = address_example;  // string | free form address text

            try
            {
                // Get Parcel Boundary By Address
                ParcelBoundaryV2 result = apiInstance.GetParcelBoundaryByAddress(address);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PropertyInformationServiceApi.GetParcelBoundaryByAddress: " + e.Message );
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
 **address** | **string**| free form address text | 

### Return type

[**ParcelBoundaryV2**](ParcelBoundaryV2.md)

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


## GetParcelBoundaryByLocation

> ParcelBoundaryV2 GetParcelBoundaryByLocation (string longitude, string latitude)

Get Parcel Boundary By Location

Accepts latitude/longitude as input and returns property parcel boundary around that location.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetParcelBoundaryByLocationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PropertyInformationServiceApi(Configuration.Default);
            var longitude = longitude_example;  // string | Longitude of Location
            var latitude = latitude_example;  // string | Latitude of Location

            try
            {
                // Get Parcel Boundary By Location
                ParcelBoundaryV2 result = apiInstance.GetParcelBoundaryByLocation(longitude, latitude);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PropertyInformationServiceApi.GetParcelBoundaryByLocation: " + e.Message );
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
 **longitude** | **string**| Longitude of Location | 
 **latitude** | **string**| Latitude of Location | 

### Return type

[**ParcelBoundaryV2**](ParcelBoundaryV2.md)

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


## GetParcelBoundaryByPreciselyID

> ParcelBoundaryV2 GetParcelBoundaryByPreciselyID (string preciselyID)

Get Parcel Boundary By PreciselyID

Accepts PB key as input and returns property attributes for the matched address.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetParcelBoundaryByPreciselyIDExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PropertyInformationServiceApi(Configuration.Default);
            var preciselyID = preciselyID_example;  // string | precisely ID

            try
            {
                // Get Parcel Boundary By PreciselyID
                ParcelBoundaryV2 result = apiInstance.GetParcelBoundaryByPreciselyID(preciselyID);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PropertyInformationServiceApi.GetParcelBoundaryByPreciselyID: " + e.Message );
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
 **preciselyID** | **string**| precisely ID | 

### Return type

[**ParcelBoundaryV2**](ParcelBoundaryV2.md)

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


## GetPropertyAttributesByAddress

> PropertyInfoResponse GetPropertyAttributesByAddress (string address = null, string attributes = null)

PropertyV2 Attributes By Address.

GetPropertyAttributesbyAddress Endpoint will take address as an input and will return key property attributes in response. Optionally user will have the option to filter the attributes and will pay for only returned attributes.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetPropertyAttributesByAddressExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PropertyInformationServiceApi(Configuration.Default);
            var address = address_example;  // string | free form address text (optional) 
            var attributes = attributes_example;  // string | Case-insensitive comma separated values of property attributes. Response will contain only the input attributes. (optional) 

            try
            {
                // PropertyV2 Attributes By Address.
                PropertyInfoResponse result = apiInstance.GetPropertyAttributesByAddress(address, attributes);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PropertyInformationServiceApi.GetPropertyAttributesByAddress: " + e.Message );
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
 **address** | **string**| free form address text | [optional] 
 **attributes** | **string**| Case-insensitive comma separated values of property attributes. Response will contain only the input attributes. | [optional] 

### Return type

[**PropertyInfoResponse**](PropertyInfoResponse.md)

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


## GetPropertyAttributesByAddressBatch

> PropertyInfoResponses GetPropertyAttributesByAddressBatch (PropertyInfoAddressRequest propertyInfoAddressRequest)

PropertyV2 Attributes By Address Batch.

GetPropertyAttributesbyAddressBatch Endpoint will take the list of addresses as an input and will return key property attributes for the given addresses in response. Optionally user will have the option to filter the attributes and will pay for only returned attributes.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetPropertyAttributesByAddressBatchExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PropertyInformationServiceApi(Configuration.Default);
            var propertyInfoAddressRequest = new PropertyInfoAddressRequest(); // PropertyInfoAddressRequest | 

            try
            {
                // PropertyV2 Attributes By Address Batch.
                PropertyInfoResponses result = apiInstance.GetPropertyAttributesByAddressBatch(propertyInfoAddressRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PropertyInformationServiceApi.GetPropertyAttributesByAddressBatch: " + e.Message );
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
 **propertyInfoAddressRequest** | [**PropertyInfoAddressRequest**](PropertyInfoAddressRequest.md)|  | 

### Return type

[**PropertyInfoResponses**](PropertyInfoResponses.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

- **Content-Type**: application/json
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

