# com.precisely.apis.Api.AddressesServiceApi

All URIs are relative to *https://api.precisely.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAddressesCountByBoundaryName**](AddressesServiceApi.md#getaddressescountbyboundaryname) | **GET** /addresses/v1/addresscount/byboundaryname | Addresses Count by Boundary Name.
[**GetAddressesCountbyBoundary**](AddressesServiceApi.md#getaddressescountbyboundary) | **POST** /addresses/v1/addresscount/byboundary | Addresses count by Boundary.
[**GetAddressesbyBoundary**](AddressesServiceApi.md#getaddressesbyboundary) | **POST** /addresses/v1/address/byboundary | Addresses by Boundary.
[**GetAddressesbyBoundaryName**](AddressesServiceApi.md#getaddressesbyboundaryname) | **GET** /addresses/v1/address/byboundaryname | Addresses by Boundary Name.



## GetAddressesCountByBoundaryName

> AddressesCount GetAddressesCountByBoundaryName (string country, string areaName1 = null, string areaName2 = null, string areaName3 = null, string areaName4 = null, string postCode = null)

Addresses Count by Boundary Name.

This service accepts zip code, neighborhood, county, or city names, and returns the total number of addresses associated with these names.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetAddressesCountByBoundaryNameExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AddressesServiceApi(Configuration.Default);
            var country = country_example;  // string | Name of country. Acceptable values are CAN, USA.
            var areaName1 = areaName1_example;  // string | Specifies the largest geographical area, typically a state or province. (optional) 
            var areaName2 = areaName2_example;  // string | Specifies the secondary geographic area, typically a county or district. (optional) 
            var areaName3 = areaName3_example;  // string | Specifies a city or town name. (optional) 
            var areaName4 = areaName4_example;  // string | Specifies a city subdivision or locality/neighborhood. (optional) 
            var postCode = postCode_example;  // string | Specifies the postcode (ZIP code) in the appropriate format for the country. (optional) 

            try
            {
                // Addresses Count by Boundary Name.
                AddressesCount result = apiInstance.GetAddressesCountByBoundaryName(country, areaName1, areaName2, areaName3, areaName4, postCode);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AddressesServiceApi.GetAddressesCountByBoundaryName: " + e.Message );
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
 **country** | **string**| Name of country. Acceptable values are CAN, USA. | 
 **areaName1** | **string**| Specifies the largest geographical area, typically a state or province. | [optional] 
 **areaName2** | **string**| Specifies the secondary geographic area, typically a county or district. | [optional] 
 **areaName3** | **string**| Specifies a city or town name. | [optional] 
 **areaName4** | **string**| Specifies a city subdivision or locality/neighborhood. | [optional] 
 **postCode** | **string**| Specifies the postcode (ZIP code) in the appropriate format for the country. | [optional] 

### Return type

[**AddressesCount**](AddressesCount.md)

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


## GetAddressesCountbyBoundary

> AddressesCount GetAddressesCountbyBoundary (AddressesByBoundaryRequest addressesByBoundaryRequest)

Addresses count by Boundary.

This service accepts custom geographic boundaries or drive time & drive distance, returns the total number of addresses within these boundaries.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetAddressesCountbyBoundaryExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AddressesServiceApi(Configuration.Default);
            var addressesByBoundaryRequest = new AddressesByBoundaryRequest(); // AddressesByBoundaryRequest | 

            try
            {
                // Addresses count by Boundary.
                AddressesCount result = apiInstance.GetAddressesCountbyBoundary(addressesByBoundaryRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AddressesServiceApi.GetAddressesCountbyBoundary: " + e.Message );
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
 **addressesByBoundaryRequest** | [**AddressesByBoundaryRequest**](AddressesByBoundaryRequest.md)|  | 

### Return type

[**AddressesCount**](AddressesCount.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

- **Content-Type**: application/json
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


## GetAddressesbyBoundary

> AddressesResponse GetAddressesbyBoundary (AddressesByBoundaryRequest addressesByBoundaryRequest)

Addresses by Boundary.

This service accepts custom geographic boundaries or drive time & drive distance, returns all known & valid addresses within these boundaries.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetAddressesbyBoundaryExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AddressesServiceApi(Configuration.Default);
            var addressesByBoundaryRequest = new AddressesByBoundaryRequest(); // AddressesByBoundaryRequest | 

            try
            {
                // Addresses by Boundary.
                AddressesResponse result = apiInstance.GetAddressesbyBoundary(addressesByBoundaryRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AddressesServiceApi.GetAddressesbyBoundary: " + e.Message );
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
 **addressesByBoundaryRequest** | [**AddressesByBoundaryRequest**](AddressesByBoundaryRequest.md)|  | 

### Return type

[**AddressesResponse**](AddressesResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

- **Content-Type**: application/json, application/xml
- **Accept**: application/json, application/xml, text/csv


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


## GetAddressesbyBoundaryName

> AddressesResponse GetAddressesbyBoundaryName (string country, string areaName1 = null, string areaName2 = null, string areaName3 = null, string areaName4 = null, string postCode = null, string maxCandidates = null, string page = null)

Addresses by Boundary Name.

This service accepts zip code, neighborhood, county, or city names, and returns all known & valid addresses associated with these names.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetAddressesbyBoundaryNameExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AddressesServiceApi(Configuration.Default);
            var country = country_example;  // string | Name of country. Acceptable values are CAN, USA.
            var areaName1 = areaName1_example;  // string | Specifies the largest geographical area, typically a state or province. (optional) 
            var areaName2 = areaName2_example;  // string | Specifies the secondary geographic area, typically a county or district. (optional) 
            var areaName3 = areaName3_example;  // string | Specifies a city or town name. (optional) 
            var areaName4 = areaName4_example;  // string | Specifies a city subdivision or locality/neighborhood. (optional) 
            var postCode = postCode_example;  // string | Specifies the postcode (ZIP code) in the appropriate format for the country. (optional) 
            var maxCandidates = maxCandidates_example;  // string | Maximum number of addresses to be returned in response. Max. value is 100 for XML/JSON, and 2000 for CSV. (optional) 
            var page = page_example;  // string | Response will indicate the page number. (optional) 

            try
            {
                // Addresses by Boundary Name.
                AddressesResponse result = apiInstance.GetAddressesbyBoundaryName(country, areaName1, areaName2, areaName3, areaName4, postCode, maxCandidates, page);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AddressesServiceApi.GetAddressesbyBoundaryName: " + e.Message );
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
 **country** | **string**| Name of country. Acceptable values are CAN, USA. | 
 **areaName1** | **string**| Specifies the largest geographical area, typically a state or province. | [optional] 
 **areaName2** | **string**| Specifies the secondary geographic area, typically a county or district. | [optional] 
 **areaName3** | **string**| Specifies a city or town name. | [optional] 
 **areaName4** | **string**| Specifies a city subdivision or locality/neighborhood. | [optional] 
 **postCode** | **string**| Specifies the postcode (ZIP code) in the appropriate format for the country. | [optional] 
 **maxCandidates** | **string**| Maximum number of addresses to be returned in response. Max. value is 100 for XML/JSON, and 2000 for CSV. | [optional] 
 **page** | **string**| Response will indicate the page number. | [optional] 

### Return type

[**AddressesResponse**](AddressesResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/xml, text/csv


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

