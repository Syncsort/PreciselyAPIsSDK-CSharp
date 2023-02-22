# com.precisely.apis.Api.GeocodeServiceApi

All URIs are relative to *https://api.precisely.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Geocode**](GeocodeServiceApi.md#geocode) | **GET** /geocode/v1/{datapackBundle}/geocode | Get Forward Geocode(Basic/Premium/Advanced)
[**GeocodeBatch**](GeocodeServiceApi.md#geocodebatch) | **POST** /geocode/v1/{datapackBundle}/geocode | Post Forward Geocode
[**GetPBKey**](GeocodeServiceApi.md#getpbkey) | **GET** /geocode/v1/key/byaddress | Get PreciselyID By Address
[**GetPBKeys**](GeocodeServiceApi.md#getpbkeys) | **POST** /geocode/v1/key/byaddress | Post PreciselyID By Address
[**KeyLookup**](GeocodeServiceApi.md#keylookup) | **GET** /geocode/v1/keylookup | Get Key Lookup
[**KeyLookupBatch**](GeocodeServiceApi.md#keylookupbatch) | **POST** /geocode/v1/keylookup | Post Key Lookup
[**ReverseGeocodBatch**](GeocodeServiceApi.md#reversegeocodbatch) | **POST** /geocode/v1/{datapackBundle}/reverseGeocode | Post Reverse Geocode
[**ReverseGeocode**](GeocodeServiceApi.md#reversegeocode) | **GET** /geocode/v1/{datapackBundle}/reverseGeocode | Get Reverse Geocode(Basic/Premium/Advanced)



## Geocode

> GeocodeServiceResponse Geocode (string datapackBundle, string country = null, string mainAddress = null, string matchMode = null, string fallbackGeo = null, string fallbackPostal = null, string maxCands = null, string streetOffset = null, string streetOffsetUnits = null, string cornerOffset = null, string cornerOffsetUnits = null, string removeAccentMarks = null, string findDPV = null)

Get Forward Geocode(Basic/Premium/Advanced)

This service accepts an address and returns the location coordinates corresponding to that address. Premium offers the best accuracy and is a high precision geocoder leveraging Master Location Data - geocodes to Street or building level. Advanced offers advanced accuracy and geocodes to Street level.Basic offering will geocode to a Place or Postal level. Good accuracy.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GeocodeExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GeocodeServiceApi(Configuration.Default);
            var datapackBundle = datapackBundle_example;  // string | datapackBundle
            var country = country_example;  // string | Country name or ISO code. (optional)  (default to "USA")
            var mainAddress = mainAddress_example;  // string | Single line input, treated as collection of field elements. (optional)  (default to "4750 Walnut St., Boulder CO, 80301")
            var matchMode = matchMode_example;  // string | Match modes determine the leniency used to make a match between the input address and the reference data. (optional)  (default to Standard)
            var fallbackGeo = fallbackGeo_example;  // string | Specifies whether to attempt to determine a geographic region centroid when an address-level geocode cannot be determined. (optional)  (default to "true")
            var fallbackPostal = fallbackPostal_example;  // string | Specifies whether to attempt to determine a post code centroid when an address-level geocode cannot be determined. (optional)  (default to "true")
            var maxCands = maxCands_example;  // string | The maximum number of candidates to return. (optional)  (default to "1")
            var streetOffset = streetOffset_example;  // string | Indicates the offset distance from the street segments to use in street-level geocoding. (optional)  (default to "7")
            var streetOffsetUnits = streetOffsetUnits_example;  // string | Specifies the unit of measurement for the street offset. (optional)  (default to METERS)
            var cornerOffset = cornerOffset_example;  // string | Specifies the distance to offset the street end points in street-level matching. (optional)  (default to "7")
            var cornerOffsetUnits = cornerOffsetUnits_example;  // string | Specifies the unit of measurement for the corner offset. (optional)  (default to METERS)
            var removeAccentMarks = removeAccentMarks_example;  // string | Specifies whether to Suppress accents and other diacritical marks. (optional)  (default to "false")
            var findDPV = findDPV_example;  // string | Specifies if Delivery Point Validation is required. Note: This parameter is only applicable for USA addresses. (optional)  (default to "false")

            try
            {
                // Get Forward Geocode(Basic/Premium/Advanced)
                GeocodeServiceResponse result = apiInstance.Geocode(datapackBundle, country, mainAddress, matchMode, fallbackGeo, fallbackPostal, maxCands, streetOffset, streetOffsetUnits, cornerOffset, cornerOffsetUnits, removeAccentMarks, findDPV);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GeocodeServiceApi.Geocode: " + e.Message );
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
 **datapackBundle** | **string**| datapackBundle | 
 **country** | **string**| Country name or ISO code. | [optional] [default to &quot;USA&quot;]
 **mainAddress** | **string**| Single line input, treated as collection of field elements. | [optional] [default to &quot;4750 Walnut St., Boulder CO, 80301&quot;]
 **matchMode** | **string**| Match modes determine the leniency used to make a match between the input address and the reference data. | [optional] [default to Standard]
 **fallbackGeo** | **string**| Specifies whether to attempt to determine a geographic region centroid when an address-level geocode cannot be determined. | [optional] [default to &quot;true&quot;]
 **fallbackPostal** | **string**| Specifies whether to attempt to determine a post code centroid when an address-level geocode cannot be determined. | [optional] [default to &quot;true&quot;]
 **maxCands** | **string**| The maximum number of candidates to return. | [optional] [default to &quot;1&quot;]
 **streetOffset** | **string**| Indicates the offset distance from the street segments to use in street-level geocoding. | [optional] [default to &quot;7&quot;]
 **streetOffsetUnits** | **string**| Specifies the unit of measurement for the street offset. | [optional] [default to METERS]
 **cornerOffset** | **string**| Specifies the distance to offset the street end points in street-level matching. | [optional] [default to &quot;7&quot;]
 **cornerOffsetUnits** | **string**| Specifies the unit of measurement for the corner offset. | [optional] [default to METERS]
 **removeAccentMarks** | **string**| Specifies whether to Suppress accents and other diacritical marks. | [optional] [default to &quot;false&quot;]
 **findDPV** | **string**| Specifies if Delivery Point Validation is required. Note: This parameter is only applicable for USA addresses. | [optional] [default to &quot;false&quot;]

### Return type

[**GeocodeServiceResponse**](GeocodeServiceResponse.md)

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


## GeocodeBatch

> GeocodeServiceResponseList GeocodeBatch (string datapackBundle, GeocodeRequest geocodeRequest)

Post Forward Geocode

This is a Batch offering for geocode service. It accepts a single address or a list of addresses and returns location coordinates

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GeocodeBatchExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GeocodeServiceApi(Configuration.Default);
            var datapackBundle = datapackBundle_example;  // string | 
            var geocodeRequest = new GeocodeRequest(); // GeocodeRequest | 

            try
            {
                // Post Forward Geocode
                GeocodeServiceResponseList result = apiInstance.GeocodeBatch(datapackBundle, geocodeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GeocodeServiceApi.GeocodeBatch: " + e.Message );
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
 **datapackBundle** | **string**|  | 
 **geocodeRequest** | [**GeocodeRequest**](GeocodeRequest.md)|  | 

### Return type

[**GeocodeServiceResponseList**](GeocodeServiceResponseList.md)

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


## GetPBKey

> PBKeyResponse GetPBKey (string address, string country = null)

Get PreciselyID By Address

This service accepts an address and returns the corresponding PreciselyID

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetPBKeyExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GeocodeServiceApi(Configuration.Default);
            var address = address_example;  // string | The address to be searched.
            var country = country_example;  // string | 3 letter ISO code of the country to be searched. (optional) 

            try
            {
                // Get PreciselyID By Address
                PBKeyResponse result = apiInstance.GetPBKey(address, country);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GeocodeServiceApi.GetPBKey: " + e.Message );
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
 **country** | **string**| 3 letter ISO code of the country to be searched. | [optional] 

### Return type

[**PBKeyResponse**](PBKeyResponse.md)

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


## GetPBKeys

> PBKeyResponseList GetPBKeys (PBKeyAddressRequest pBKeyAddressRequest)

Post PreciselyID By Address

This is a Batch offering for 'PreciselyID By Address' service. It accepts a single address or a list of addresses and returns the corresponding PreciselyID.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetPBKeysExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GeocodeServiceApi(Configuration.Default);
            var pBKeyAddressRequest = new PBKeyAddressRequest(); // PBKeyAddressRequest | 

            try
            {
                // Post PreciselyID By Address
                PBKeyResponseList result = apiInstance.GetPBKeys(pBKeyAddressRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GeocodeServiceApi.GetPBKeys: " + e.Message );
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
 **pBKeyAddressRequest** | [**PBKeyAddressRequest**](PBKeyAddressRequest.md)|  | 

### Return type

[**PBKeyResponseList**](PBKeyResponseList.md)

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


## KeyLookup

> GeocodeServiceResponse KeyLookup (string key, string type, string country = null)

Get Key Lookup

This service accepts a PreciselyID and returns the corresponding address associated with that PreciselyID.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class KeyLookupExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GeocodeServiceApi(Configuration.Default);
            var key = key_example;  // string | PreciselyID which maps to a unique address.
            var type = type_example;  // string | Specifies the key type - PreciselyID and GNAF_PID for Aus.
            var country = country_example;  // string | 3 letter ISO code of the country to be searched. (optional) 

            try
            {
                // Get Key Lookup
                GeocodeServiceResponse result = apiInstance.KeyLookup(key, type, country);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GeocodeServiceApi.KeyLookup: " + e.Message );
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
 **key** | **string**| PreciselyID which maps to a unique address. | 
 **type** | **string**| Specifies the key type - PreciselyID and GNAF_PID for Aus. | 
 **country** | **string**| 3 letter ISO code of the country to be searched. | [optional] 

### Return type

[**GeocodeServiceResponse**](GeocodeServiceResponse.md)

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


## KeyLookupBatch

> GeocodeServiceResponseList KeyLookupBatch (KeyLookupRequest keyLookupRequest)

Post Key Lookup

This service accepts batches of PreciselyID's and returns the corresponding address associated with those PreciselyID's.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class KeyLookupBatchExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GeocodeServiceApi(Configuration.Default);
            var keyLookupRequest = new KeyLookupRequest(); // KeyLookupRequest | 

            try
            {
                // Post Key Lookup
                GeocodeServiceResponseList result = apiInstance.KeyLookupBatch(keyLookupRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GeocodeServiceApi.KeyLookupBatch: " + e.Message );
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
 **keyLookupRequest** | [**KeyLookupRequest**](KeyLookupRequest.md)|  | 

### Return type

[**GeocodeServiceResponseList**](GeocodeServiceResponseList.md)

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


## ReverseGeocodBatch

> GeocodeServiceResponseList ReverseGeocodBatch (string datapackBundle, ReverseGeocodeRequest reverseGeocodeRequest)

Post Reverse Geocode

This is a Batch offering for geocode service. It accepts a single address or a list of addresses and returns location coordinates

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class ReverseGeocodBatchExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GeocodeServiceApi(Configuration.Default);
            var datapackBundle = datapackBundle_example;  // string | 
            var reverseGeocodeRequest = new ReverseGeocodeRequest(); // ReverseGeocodeRequest | 

            try
            {
                // Post Reverse Geocode
                GeocodeServiceResponseList result = apiInstance.ReverseGeocodBatch(datapackBundle, reverseGeocodeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GeocodeServiceApi.ReverseGeocodBatch: " + e.Message );
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
 **datapackBundle** | **string**|  | 
 **reverseGeocodeRequest** | [**ReverseGeocodeRequest**](ReverseGeocodeRequest.md)|  | 

### Return type

[**GeocodeServiceResponseList**](GeocodeServiceResponseList.md)

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


## ReverseGeocode

> GeocodeServiceResponse ReverseGeocode (string datapackBundle, string x, string y, string country = null, string coordSysName = null, string distance = null, string distanceUnits = null)

Get Reverse Geocode(Basic/Premium/Advanced)

This service accepts location coordinate and returns an address.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class ReverseGeocodeExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GeocodeServiceApi(Configuration.Default);
            var datapackBundle = datapackBundle_example;  // string | datapackBundle
            var x = x_example;  // string | Longitude of the location. (default to "-105.240976")
            var y = y_example;  // string | Latitude of the location. (default to "40.018301")
            var country = country_example;  // string | Country name or ISO code. (optional) 
            var coordSysName = coordSysName_example;  // string | Coordinate system to convert geometry to in format codespace:code. (optional)  (default to "EPSG:4326")
            var distance = distance_example;  // string | Radius in which search is performed. (optional)  (default to "Radius in which search is performed.")
            var distanceUnits = distanceUnits_example;  // string | Unit of measurement. (optional)  (default to METERS)

            try
            {
                // Get Reverse Geocode(Basic/Premium/Advanced)
                GeocodeServiceResponse result = apiInstance.ReverseGeocode(datapackBundle, x, y, country, coordSysName, distance, distanceUnits);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GeocodeServiceApi.ReverseGeocode: " + e.Message );
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
 **datapackBundle** | **string**| datapackBundle | 
 **x** | **string**| Longitude of the location. | [default to &quot;-105.240976&quot;]
 **y** | **string**| Latitude of the location. | [default to &quot;40.018301&quot;]
 **country** | **string**| Country name or ISO code. | [optional] 
 **coordSysName** | **string**| Coordinate system to convert geometry to in format codespace:code. | [optional] [default to &quot;EPSG:4326&quot;]
 **distance** | **string**| Radius in which search is performed. | [optional] [default to &quot;Radius in which search is performed.&quot;]
 **distanceUnits** | **string**| Unit of measurement. | [optional] [default to METERS]

### Return type

[**GeocodeServiceResponse**](GeocodeServiceResponse.md)

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

