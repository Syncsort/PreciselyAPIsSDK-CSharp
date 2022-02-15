# com.precisely.apis.Api.LocalTaxServiceApi

All URIs are relative to *https://api.precisely.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetBatchTaxByAddress**](LocalTaxServiceApi.md#getbatchtaxbyaddress) | **POST** /localtax/v1/tax/{taxRateTypeId}/byaddress | Post Tax By Address
[**GetBatchTaxByLocation**](LocalTaxServiceApi.md#getbatchtaxbylocation) | **POST** /localtax/v1/tax/{taxRateTypeId}/bylocation | Post Tax By Location
[**GetBatchTaxRateByAddress**](LocalTaxServiceApi.md#getbatchtaxratebyaddress) | **POST** /localtax/v1/taxrate/{taxRateTypeId}/byaddress | Post Taxrate By Address
[**GetBatchTaxRateByLocation**](LocalTaxServiceApi.md#getbatchtaxratebylocation) | **POST** /localtax/v1/taxrate/{taxRateTypeId}/bylocation | Post Taxrate By Location
[**GetIPDTaxByAddress**](LocalTaxServiceApi.md#getipdtaxbyaddress) | **GET** /localtax/v1/taxdistrict/ipd/byaddress | Get IPD Tax by Address
[**GetIPDTaxByAddressBatch**](LocalTaxServiceApi.md#getipdtaxbyaddressbatch) | **POST** /localtax/v1/taxdistrict/ipd/byaddress | Get IPD Tax for batch requests.
[**GetSpecificTaxByAddress**](LocalTaxServiceApi.md#getspecifictaxbyaddress) | **GET** /localtax/v1/tax/{taxRateTypeId}/byaddress | Get Tax By Address
[**GetSpecificTaxByLocation**](LocalTaxServiceApi.md#getspecifictaxbylocation) | **GET** /localtax/v1/tax/{taxRateTypeId}/bylocation | Get Tax By Location
[**GetSpecificTaxRateByAddress**](LocalTaxServiceApi.md#getspecifictaxratebyaddress) | **GET** /localtax/v1/taxrate/{taxRateTypeId}/byaddress | Get Taxrate By Address
[**GetSpecificTaxRateByLocation**](LocalTaxServiceApi.md#getspecifictaxratebylocation) | **GET** /localtax/v1/taxrate/{taxRateTypeId}/bylocation | Get Taxrate By Location



## GetBatchTaxByAddress

> TaxResponses GetBatchTaxByAddress (string taxRateTypeId, TaxAddressRequest taxAddressRequest)

Post Tax By Address

This is a Batch offering for 'Tax By Address' service. It accepts a single address, purchase amount or a list of addresses, purchase amounts and retrieve applicable taxes.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetBatchTaxByAddressExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocalTaxServiceApi(Configuration.Default);
            var taxRateTypeId = taxRateTypeId_example;  // string | 
            var taxAddressRequest = new TaxAddressRequest(); // TaxAddressRequest | 

            try
            {
                // Post Tax By Address
                TaxResponses result = apiInstance.GetBatchTaxByAddress(taxRateTypeId, taxAddressRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LocalTaxServiceApi.GetBatchTaxByAddress: " + e.Message );
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
 **taxRateTypeId** | **string**|  | 
 **taxAddressRequest** | [**TaxAddressRequest**](TaxAddressRequest.md)|  | 

### Return type

[**TaxResponses**](TaxResponses.md)

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


## GetBatchTaxByLocation

> TaxResponses GetBatchTaxByLocation (string taxRateTypeId, TaxLocationRequest taxLocationRequest)

Post Tax By Location

This is a Batch offering for 'Tax By Location' service. It accepts a single location coordinate, purchase amount or a list of location coordinates, purchase amounts and retrieve applicable tax.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetBatchTaxByLocationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocalTaxServiceApi(Configuration.Default);
            var taxRateTypeId = taxRateTypeId_example;  // string | 
            var taxLocationRequest = new TaxLocationRequest(); // TaxLocationRequest | 

            try
            {
                // Post Tax By Location
                TaxResponses result = apiInstance.GetBatchTaxByLocation(taxRateTypeId, taxLocationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LocalTaxServiceApi.GetBatchTaxByLocation: " + e.Message );
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
 **taxRateTypeId** | **string**|  | 
 **taxLocationRequest** | [**TaxLocationRequest**](TaxLocationRequest.md)|  | 

### Return type

[**TaxResponses**](TaxResponses.md)

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


## GetBatchTaxRateByAddress

> TaxResponses GetBatchTaxRateByAddress (string taxRateTypeId, TaxRateAddressRequest taxRateAddressRequest)

Post Taxrate By Address

This is a Batch offering for 'Taxrate By Address' service. It accepts a single address or a list of addresses and retrieve applicable tax rates.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetBatchTaxRateByAddressExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocalTaxServiceApi(Configuration.Default);
            var taxRateTypeId = taxRateTypeId_example;  // string | 
            var taxRateAddressRequest = new TaxRateAddressRequest(); // TaxRateAddressRequest | 

            try
            {
                // Post Taxrate By Address
                TaxResponses result = apiInstance.GetBatchTaxRateByAddress(taxRateTypeId, taxRateAddressRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LocalTaxServiceApi.GetBatchTaxRateByAddress: " + e.Message );
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
 **taxRateTypeId** | **string**|  | 
 **taxRateAddressRequest** | [**TaxRateAddressRequest**](TaxRateAddressRequest.md)|  | 

### Return type

[**TaxResponses**](TaxResponses.md)

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


## GetBatchTaxRateByLocation

> TaxResponses GetBatchTaxRateByLocation (string taxRateTypeId, TaxRateLocationRequest taxRateLocationRequest)

Post Taxrate By Location

This is a Batch offering for 'Taxrate By Location' service. It accepts a single location coordinate or a list of location coordinates and retrieve applicable tax rates.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetBatchTaxRateByLocationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocalTaxServiceApi(Configuration.Default);
            var taxRateTypeId = taxRateTypeId_example;  // string | 
            var taxRateLocationRequest = new TaxRateLocationRequest(); // TaxRateLocationRequest | 

            try
            {
                // Post Taxrate By Location
                TaxResponses result = apiInstance.GetBatchTaxRateByLocation(taxRateTypeId, taxRateLocationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LocalTaxServiceApi.GetBatchTaxRateByLocation: " + e.Message );
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
 **taxRateTypeId** | **string**|  | 
 **taxRateLocationRequest** | [**TaxRateLocationRequest**](TaxRateLocationRequest.md)|  | 

### Return type

[**TaxResponses**](TaxResponses.md)

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


## GetIPDTaxByAddress

> TaxDistrictResponse GetIPDTaxByAddress (string address, string returnLatLongFields = null, string latLongFormat = null)

Get IPD Tax by Address

Retrieves IPD (Insurance Premium District) tax rates applicable to a specific address. This service accepts address as input and returns one or many IPD tax rate details for that region in which address falls.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetIPDTaxByAddressExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocalTaxServiceApi(Configuration.Default);
            var address = address_example;  // string | The address to be searched.
            var returnLatLongFields = returnLatLongFields_example;  // string | Y or N (default is N) - Returns Latitude Longitude Fields. (optional) 
            var latLongFormat = latLongFormat_example;  // string | (default is Decimal) - Returns Desired Latitude Longitude Format. (optional) 

            try
            {
                // Get IPD Tax by Address
                TaxDistrictResponse result = apiInstance.GetIPDTaxByAddress(address, returnLatLongFields, latLongFormat);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LocalTaxServiceApi.GetIPDTaxByAddress: " + e.Message );
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
 **returnLatLongFields** | **string**| Y or N (default is N) - Returns Latitude Longitude Fields. | [optional] 
 **latLongFormat** | **string**| (default is Decimal) - Returns Desired Latitude Longitude Format. | [optional] 

### Return type

[**TaxDistrictResponse**](TaxDistrictResponse.md)

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


## GetIPDTaxByAddressBatch

> TaxDistrictResponseList GetIPDTaxByAddressBatch (IPDTaxByAddressBatchRequest iPDTaxByAddressBatchRequest)

Get IPD Tax for batch requests.

This is a Batch offering for 'IPD Tax rates By Address'. It accepts multiple addresses as parameters along with geocoding and matching preferences and returns one or many IPD tax rate details for each address.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetIPDTaxByAddressBatchExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocalTaxServiceApi(Configuration.Default);
            var iPDTaxByAddressBatchRequest = new IPDTaxByAddressBatchRequest(); // IPDTaxByAddressBatchRequest | 

            try
            {
                // Get IPD Tax for batch requests.
                TaxDistrictResponseList result = apiInstance.GetIPDTaxByAddressBatch(iPDTaxByAddressBatchRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LocalTaxServiceApi.GetIPDTaxByAddressBatch: " + e.Message );
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
 **iPDTaxByAddressBatchRequest** | [**IPDTaxByAddressBatchRequest**](IPDTaxByAddressBatchRequest.md)|  | 

### Return type

[**TaxDistrictResponseList**](TaxDistrictResponseList.md)

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


## GetSpecificTaxByAddress

> TaxRateResponse GetSpecificTaxByAddress (string taxRateTypeId, string address, string purchaseAmount)

Get Tax By Address

This service calculates and returns taxes applicable at a specific address. Address, purchase amount and supported tax rate type are inputs to the service.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetSpecificTaxByAddressExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocalTaxServiceApi(Configuration.Default);
            var taxRateTypeId = taxRateTypeId_example;  // string | The tax rate id
            var address = address_example;  // string | The address to be searched.
            var purchaseAmount = purchaseAmount_example;  // string | The amount on which tax to be calculated

            try
            {
                // Get Tax By Address
                TaxRateResponse result = apiInstance.GetSpecificTaxByAddress(taxRateTypeId, address, purchaseAmount);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LocalTaxServiceApi.GetSpecificTaxByAddress: " + e.Message );
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
 **taxRateTypeId** | **string**| The tax rate id | 
 **address** | **string**| The address to be searched. | 
 **purchaseAmount** | **string**| The amount on which tax to be calculated | 

### Return type

[**TaxRateResponse**](TaxRateResponse.md)

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


## GetSpecificTaxByLocation

> TaxRateResponse GetSpecificTaxByLocation (string taxRateTypeId, string latitude, string longitude, string purchaseAmount)

Get Tax By Location

This service calculates and returns tax applicable at a specific location. Longitude, latitude, purchase amount and supported tax rate type are inputs to the service.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetSpecificTaxByLocationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocalTaxServiceApi(Configuration.Default);
            var taxRateTypeId = taxRateTypeId_example;  // string | The tax rate id
            var latitude = latitude_example;  // string | Latitude of the location
            var longitude = longitude_example;  // string | Longitude of the location
            var purchaseAmount = purchaseAmount_example;  // string | The amount on which tax to be calculated

            try
            {
                // Get Tax By Location
                TaxRateResponse result = apiInstance.GetSpecificTaxByLocation(taxRateTypeId, latitude, longitude, purchaseAmount);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LocalTaxServiceApi.GetSpecificTaxByLocation: " + e.Message );
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
 **taxRateTypeId** | **string**| The tax rate id | 
 **latitude** | **string**| Latitude of the location | 
 **longitude** | **string**| Longitude of the location | 
 **purchaseAmount** | **string**| The amount on which tax to be calculated | 

### Return type

[**TaxRateResponse**](TaxRateResponse.md)

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


## GetSpecificTaxRateByAddress

> TaxRateResponse GetSpecificTaxRateByAddress (string taxRateTypeId, string address)

Get Taxrate By Address

Retrieves tax rates applicable to a specific address. This service accepts address and supported tax rate type as inputs to retrieve applicable tax rates.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetSpecificTaxRateByAddressExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocalTaxServiceApi(Configuration.Default);
            var taxRateTypeId = taxRateTypeId_example;  // string | The tax rate id
            var address = address_example;  // string | The address to be searched.

            try
            {
                // Get Taxrate By Address
                TaxRateResponse result = apiInstance.GetSpecificTaxRateByAddress(taxRateTypeId, address);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LocalTaxServiceApi.GetSpecificTaxRateByAddress: " + e.Message );
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
 **taxRateTypeId** | **string**| The tax rate id | 
 **address** | **string**| The address to be searched. | 

### Return type

[**TaxRateResponse**](TaxRateResponse.md)

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


## GetSpecificTaxRateByLocation

> TaxRateResponse GetSpecificTaxRateByLocation (string taxRateTypeId, string latitude, string longitude)

Get Taxrate By Location

Retrieves tax rates applicable to a specific location. This service accepts longitude, latitude and supported tax rate type as inputs to retrieve applicable tax rates.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetSpecificTaxRateByLocationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocalTaxServiceApi(Configuration.Default);
            var taxRateTypeId = taxRateTypeId_example;  // string | The tax rate id
            var latitude = latitude_example;  // string | Latitude of the location
            var longitude = longitude_example;  // string | Longitude of the location

            try
            {
                // Get Taxrate By Location
                TaxRateResponse result = apiInstance.GetSpecificTaxRateByLocation(taxRateTypeId, latitude, longitude);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LocalTaxServiceApi.GetSpecificTaxRateByLocation: " + e.Message );
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
 **taxRateTypeId** | **string**| The tax rate id | 
 **latitude** | **string**| Latitude of the location | 
 **longitude** | **string**| Longitude of the location | 

### Return type

[**TaxRateResponse**](TaxRateResponse.md)

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

