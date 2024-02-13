# com.precisely.apis.Api.RisksServiceApi

All URIs are relative to *https://api.precisely.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCrimeRiskByAddress**](RisksServiceApi.md#getcrimeriskbyaddress) | **GET** /risks/v1/crime/byaddress | Get Crime Risk By Address
[**GetCrimeRiskByAddressBatch**](RisksServiceApi.md#getcrimeriskbyaddressbatch) | **POST** /risks/v1/crime/byaddress | Post Crime Risk By Address
[**GetCrimeRiskByLocation**](RisksServiceApi.md#getcrimeriskbylocation) | **GET** /risks/v1/crime/bylocation | Get Crime Risk By  Location
[**GetCrimeRiskByLocationBatch**](RisksServiceApi.md#getcrimeriskbylocationbatch) | **POST** /risks/v1/crime/bylocation | Post Crime Risk By Location
[**GetDistanceToCoastByAddress**](RisksServiceApi.md#getdistancetocoastbyaddress) | **GET** /risks/v1/shoreline/distancetofloodhazard/byaddress | Get Distance To Flood Hazard By Address
[**GetDistanceToCoastByAddressBatch**](RisksServiceApi.md#getdistancetocoastbyaddressbatch) | **POST** /risks/v1/shoreline/distancetofloodhazard/byaddress | Post Distance To Flood Hazard By Address
[**GetDistanceToCoastByLocation**](RisksServiceApi.md#getdistancetocoastbylocation) | **GET** /risks/v1/shoreline/distancetofloodhazard/bylocation | Get Distance To Flood Hazard By Location
[**GetDistanceToCoastByLocationBatch**](RisksServiceApi.md#getdistancetocoastbylocationbatch) | **POST** /risks/v1/shoreline/distancetofloodhazard/bylocation | Post Distance To Flood Hazard By Location
[**GetEarthquakeHistory**](RisksServiceApi.md#getearthquakehistory) | **GET** /risks/v1/earthquakehistory | Earthquake History
[**GetEarthquakeRiskByAddress**](RisksServiceApi.md#getearthquakeriskbyaddress) | **GET** /risks/v1/earthquake/byaddress | Get Earthquake Risk By Address
[**GetEarthquakeRiskByAddressBatch**](RisksServiceApi.md#getearthquakeriskbyaddressbatch) | **POST** /risks/v1/earthquake/byaddress | Post Earthquake Risk By Address
[**GetEarthquakeRiskByLocation**](RisksServiceApi.md#getearthquakeriskbylocation) | **GET** /risks/v1/earthquake/bylocation | Get Earthquake Risk By Location
[**GetEarthquakeRiskByLocationBatch**](RisksServiceApi.md#getearthquakeriskbylocationbatch) | **POST** /risks/v1/earthquake/bylocation | Post Earthquake Risk By Location
[**GetFireHistory**](RisksServiceApi.md#getfirehistory) | **GET** /risks/v1/firehistory | Get Fire History
[**GetFireHistoryV2**](RisksServiceApi.md#getfirehistoryv2) | **GET** /risks/v2/firehistory | Get Fire History
[**GetFireRiskByAddress**](RisksServiceApi.md#getfireriskbyaddress) | **GET** /risks/v1/fire/byaddress | Get Fire Risk By Address
[**GetFireRiskByAddressBatch**](RisksServiceApi.md#getfireriskbyaddressbatch) | **POST** /risks/v1/fire/byaddress | Post Fire Risk By Address
[**GetFireRiskByLocation**](RisksServiceApi.md#getfireriskbylocation) | **GET** /risks/v1/fire/bylocation | Get Fire Risk By Location
[**GetFireRiskByLocationBatch**](RisksServiceApi.md#getfireriskbylocationbatch) | **POST** /risks/v1/fire/bylocation | Post Fire Risk By Location
[**GetFireRiskV2ByAddress**](RisksServiceApi.md#getfireriskv2byaddress) | **GET** /risks/v2/fire/byaddress | Get Fire Risk By Address
[**GetFireRiskV2ByAddressBatch**](RisksServiceApi.md#getfireriskv2byaddressbatch) | **POST** /risks/v2/fire/byaddress | Post Fire Risk By Address
[**GetFireRiskV2ByLocation**](RisksServiceApi.md#getfireriskv2bylocation) | **GET** /risks/v2/fire/bylocation | Get Fire Risk By Location
[**GetFireRiskV2ByLocationBatch**](RisksServiceApi.md#getfireriskv2bylocationbatch) | **POST** /risks/v2/fire/bylocation | Post Fire Risk By Location
[**GetFireStationByAddress**](RisksServiceApi.md#getfirestationbyaddress) | **GET** /risks/v1/firestation/byaddress | Get Fire Station By Address
[**GetFireStationByLocation**](RisksServiceApi.md#getfirestationbylocation) | **GET** /risks/v1/firestation/bylocation | Get Fire Station By Location
[**GetFloodRiskByAddress**](RisksServiceApi.md#getfloodriskbyaddress) | **GET** /risks/v1/flood/byaddress | Get Flood Risk By Address
[**GetFloodRiskByAddressBatch**](RisksServiceApi.md#getfloodriskbyaddressbatch) | **POST** /risks/v1/flood/byaddress | Post Flood Risk By Address
[**GetFloodRiskByLocation**](RisksServiceApi.md#getfloodriskbylocation) | **GET** /risks/v1/flood/bylocation | Get Flood Risk By Location
[**GetFloodRiskByLocationBatch**](RisksServiceApi.md#getfloodriskbylocationbatch) | **POST** /risks/v1/flood/bylocation | Post Flood Risk By Location



## GetCrimeRiskByAddress

> CrimeRiskResponse GetCrimeRiskByAddress (string address, string type = null, string includeGeometry = null)

Get Crime Risk By Address

Accepts addresses as input and Returns local crime indexes.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetCrimeRiskByAddressExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RisksServiceApi(Configuration.Default);
            var address = address_example;  // string | free form address text
            var type = type_example;  // string | this is crime type; valid values are following 11 crime types with 'all' as default (more than one can also be given as comma separated types) (optional) 
            var includeGeometry = includeGeometry_example;  // string | Y or N (default is N) - if it is Y, then geometry will be part of response (optional) 

            try
            {
                // Get Crime Risk By Address
                CrimeRiskResponse result = apiInstance.GetCrimeRiskByAddress(address, type, includeGeometry);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RisksServiceApi.GetCrimeRiskByAddress: " + e.Message );
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
 **type** | **string**| this is crime type; valid values are following 11 crime types with &#39;all&#39; as default (more than one can also be given as comma separated types) | [optional] 
 **includeGeometry** | **string**| Y or N (default is N) - if it is Y, then geometry will be part of response | [optional] 

### Return type

[**CrimeRiskResponse**](CrimeRiskResponse.md)

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


## GetCrimeRiskByAddressBatch

> CrimeRiskResponseList GetCrimeRiskByAddressBatch (CrimeRiskByAddressBatchRequest crimeRiskByAddressBatchRequest)

Post Crime Risk By Address

This is a Batch offering for 'Crime Risk By Address' service. It accepts a single address or a list of addresses and retrieve local crime indexes.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetCrimeRiskByAddressBatchExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RisksServiceApi(Configuration.Default);
            var crimeRiskByAddressBatchRequest = new CrimeRiskByAddressBatchRequest(); // CrimeRiskByAddressBatchRequest | 

            try
            {
                // Post Crime Risk By Address
                CrimeRiskResponseList result = apiInstance.GetCrimeRiskByAddressBatch(crimeRiskByAddressBatchRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RisksServiceApi.GetCrimeRiskByAddressBatch: " + e.Message );
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
 **crimeRiskByAddressBatchRequest** | [**CrimeRiskByAddressBatchRequest**](CrimeRiskByAddressBatchRequest.md)|  | 

### Return type

[**CrimeRiskResponseList**](CrimeRiskResponseList.md)

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


## GetCrimeRiskByLocation

> CrimeRiskResponse GetCrimeRiskByLocation (string longitude, string latitude, string type = null, string includeGeometry = null)

Get Crime Risk By  Location

Accepts latitude/longitude as input and returns and Returns local crime indexes.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetCrimeRiskByLocationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RisksServiceApi(Configuration.Default);
            var longitude = longitude_example;  // string | The longitude of the location
            var latitude = latitude_example;  // string | The latitude of the location
            var type = type_example;  // string | this is crime type; valid values are following 11 crime types with 'all' as default (more than one can also be given as comma separated types) (optional) 
            var includeGeometry = includeGeometry_example;  // string | Y or N (default is N) - if it is Y, then geometry will be part of response (optional) 

            try
            {
                // Get Crime Risk By  Location
                CrimeRiskResponse result = apiInstance.GetCrimeRiskByLocation(longitude, latitude, type, includeGeometry);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RisksServiceApi.GetCrimeRiskByLocation: " + e.Message );
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
 **longitude** | **string**| The longitude of the location | 
 **latitude** | **string**| The latitude of the location | 
 **type** | **string**| this is crime type; valid values are following 11 crime types with &#39;all&#39; as default (more than one can also be given as comma separated types) | [optional] 
 **includeGeometry** | **string**| Y or N (default is N) - if it is Y, then geometry will be part of response | [optional] 

### Return type

[**CrimeRiskResponse**](CrimeRiskResponse.md)

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


## GetCrimeRiskByLocationBatch

> CrimeRiskResponseList GetCrimeRiskByLocationBatch (CrimeRiskByLocationBatchRequest crimeRiskByLocationBatchRequest)

Post Crime Risk By Location

This is a Batch offering for 'Crime Risk By Location' service. It accepts a single location coordinate or a list of location coordinates and retrieve local crime indexes.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetCrimeRiskByLocationBatchExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RisksServiceApi(Configuration.Default);
            var crimeRiskByLocationBatchRequest = new CrimeRiskByLocationBatchRequest(); // CrimeRiskByLocationBatchRequest | 

            try
            {
                // Post Crime Risk By Location
                CrimeRiskResponseList result = apiInstance.GetCrimeRiskByLocationBatch(crimeRiskByLocationBatchRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RisksServiceApi.GetCrimeRiskByLocationBatch: " + e.Message );
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
 **crimeRiskByLocationBatchRequest** | [**CrimeRiskByLocationBatchRequest**](CrimeRiskByLocationBatchRequest.md)|  | 

### Return type

[**CrimeRiskResponseList**](CrimeRiskResponseList.md)

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


## GetDistanceToCoastByAddress

> WaterBodyResponse GetDistanceToCoastByAddress (string address = null, string maxCandidates = null, string waterBodyType = null, string searchDistance = null, string searchDistanceUnit = null)

Get Distance To Flood Hazard By Address

Accepts addresses as input and Returns the distance from nearest water bodies along with body name and location.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetDistanceToCoastByAddressExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RisksServiceApi(Configuration.Default);
            var address = address_example;  // string | The address of the location (optional) 
            var maxCandidates = maxCandidates_example;  // string | This specifies the value of maxCandidates (optional) 
            var waterBodyType = waterBodyType_example;  // string | This specifies the value of waterBodyType (optional) 
            var searchDistance = searchDistance_example;  // string | This specifies the search distance (optional) 
            var searchDistanceUnit = searchDistanceUnit_example;  // string | miles (default value),feet, kilometers, meters (optional) 

            try
            {
                // Get Distance To Flood Hazard By Address
                WaterBodyResponse result = apiInstance.GetDistanceToCoastByAddress(address, maxCandidates, waterBodyType, searchDistance, searchDistanceUnit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RisksServiceApi.GetDistanceToCoastByAddress: " + e.Message );
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
 **address** | **string**| The address of the location | [optional] 
 **maxCandidates** | **string**| This specifies the value of maxCandidates | [optional] 
 **waterBodyType** | **string**| This specifies the value of waterBodyType | [optional] 
 **searchDistance** | **string**| This specifies the search distance | [optional] 
 **searchDistanceUnit** | **string**| miles (default value),feet, kilometers, meters | [optional] 

### Return type

[**WaterBodyResponse**](WaterBodyResponse.md)

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


## GetDistanceToCoastByAddressBatch

> DistanceToFloodHazardResponse GetDistanceToCoastByAddressBatch (DistanceToFloodHazardAddressRequest distanceToFloodHazardAddressRequest)

Post Distance To Flood Hazard By Address

This is a Batch offering for 'Distance To Flood Hazard By Address' service. It accepts a single address or a list of addresses and retrieve the distance from nearest water bodies along with body name and location.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetDistanceToCoastByAddressBatchExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RisksServiceApi(Configuration.Default);
            var distanceToFloodHazardAddressRequest = new DistanceToFloodHazardAddressRequest(); // DistanceToFloodHazardAddressRequest | 

            try
            {
                // Post Distance To Flood Hazard By Address
                DistanceToFloodHazardResponse result = apiInstance.GetDistanceToCoastByAddressBatch(distanceToFloodHazardAddressRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RisksServiceApi.GetDistanceToCoastByAddressBatch: " + e.Message );
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
 **distanceToFloodHazardAddressRequest** | [**DistanceToFloodHazardAddressRequest**](DistanceToFloodHazardAddressRequest.md)|  | 

### Return type

[**DistanceToFloodHazardResponse**](DistanceToFloodHazardResponse.md)

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


## GetDistanceToCoastByLocation

> WaterBodyResponse GetDistanceToCoastByLocation (string longitude = null, string latitude = null, string maxCandidates = null, string waterBodyType = null, string searchDistance = null, string searchDistanceUnit = null)

Get Distance To Flood Hazard By Location

Accepts latitude & longitude as input and Returns the distance from nearest water bodies along with body name and location.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetDistanceToCoastByLocationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RisksServiceApi(Configuration.Default);
            var longitude = longitude_example;  // string | The longitude of the location (optional) 
            var latitude = latitude_example;  // string | The latitude of the location (optional) 
            var maxCandidates = maxCandidates_example;  // string | This specifies the value of maxCandidates (optional) 
            var waterBodyType = waterBodyType_example;  // string | This specifies the value of waterBodyType (optional) 
            var searchDistance = searchDistance_example;  // string | This specifies the search distance (optional) 
            var searchDistanceUnit = searchDistanceUnit_example;  // string | miles (default value),feet, kilometers, meters (optional) 

            try
            {
                // Get Distance To Flood Hazard By Location
                WaterBodyResponse result = apiInstance.GetDistanceToCoastByLocation(longitude, latitude, maxCandidates, waterBodyType, searchDistance, searchDistanceUnit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RisksServiceApi.GetDistanceToCoastByLocation: " + e.Message );
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
 **longitude** | **string**| The longitude of the location | [optional] 
 **latitude** | **string**| The latitude of the location | [optional] 
 **maxCandidates** | **string**| This specifies the value of maxCandidates | [optional] 
 **waterBodyType** | **string**| This specifies the value of waterBodyType | [optional] 
 **searchDistance** | **string**| This specifies the search distance | [optional] 
 **searchDistanceUnit** | **string**| miles (default value),feet, kilometers, meters | [optional] 

### Return type

[**WaterBodyResponse**](WaterBodyResponse.md)

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


## GetDistanceToCoastByLocationBatch

> DistanceToFloodHazardResponse GetDistanceToCoastByLocationBatch (DistanceToFloodHazardLocationRequest distanceToFloodHazardLocationRequest)

Post Distance To Flood Hazard By Location

This is a Batch offering for 'Distance To Flood Hazard By Location' service. It accepts a single location coordinate or a list of location coordinates and retrieve the distance from nearest water bodies along with body name and location.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetDistanceToCoastByLocationBatchExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RisksServiceApi(Configuration.Default);
            var distanceToFloodHazardLocationRequest = new DistanceToFloodHazardLocationRequest(); // DistanceToFloodHazardLocationRequest | 

            try
            {
                // Post Distance To Flood Hazard By Location
                DistanceToFloodHazardResponse result = apiInstance.GetDistanceToCoastByLocationBatch(distanceToFloodHazardLocationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RisksServiceApi.GetDistanceToCoastByLocationBatch: " + e.Message );
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
 **distanceToFloodHazardLocationRequest** | [**DistanceToFloodHazardLocationRequest**](DistanceToFloodHazardLocationRequest.md)|  | 

### Return type

[**DistanceToFloodHazardResponse**](DistanceToFloodHazardResponse.md)

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


## GetEarthquakeHistory

> EarthquakeHistory GetEarthquakeHistory (string postCode, string startDate = null, string endDate = null, string minMagnitude = null, string maxMagnitude = null, string maxCandidates = null)

Earthquake History

Accepts postcode as input and Returns historical earthquake details for a particular postcode.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetEarthquakeHistoryExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RisksServiceApi(Configuration.Default);
            var postCode = postCode_example;  // string | 5 digit Postal code to search
            var startDate = startDate_example;  // string | Start time in milliseconds(UTC) (optional) 
            var endDate = endDate_example;  // string | End time in milliseconds(UTC) (optional) 
            var minMagnitude = minMagnitude_example;  // string | Minimum richter scale magnitude (optional) 
            var maxMagnitude = maxMagnitude_example;  // string | Maximum Richter scale magnitude (optional) 
            var maxCandidates = maxCandidates_example;  // string | Maximum response events (optional) 

            try
            {
                // Earthquake History
                EarthquakeHistory result = apiInstance.GetEarthquakeHistory(postCode, startDate, endDate, minMagnitude, maxMagnitude, maxCandidates);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RisksServiceApi.GetEarthquakeHistory: " + e.Message );
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
 **postCode** | **string**| 5 digit Postal code to search | 
 **startDate** | **string**| Start time in milliseconds(UTC) | [optional] 
 **endDate** | **string**| End time in milliseconds(UTC) | [optional] 
 **minMagnitude** | **string**| Minimum richter scale magnitude | [optional] 
 **maxMagnitude** | **string**| Maximum Richter scale magnitude | [optional] 
 **maxCandidates** | **string**| Maximum response events | [optional] 

### Return type

[**EarthquakeHistory**](EarthquakeHistory.md)

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


## GetEarthquakeRiskByAddress

> EarthquakeRiskResponse GetEarthquakeRiskByAddress (string address, string richterValue = null, string includeGeometry = null)

Get Earthquake Risk By Address

Accepts addresses as input and Returns counts of earthquakes for various richter measurements and values.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetEarthquakeRiskByAddressExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RisksServiceApi(Configuration.Default);
            var address = address_example;  // string | free form address text
            var richterValue = richterValue_example;  // string | all (default value), R0, R1, R2, R3, R4, R5, R6, R7, R0_GE, R1_GE, R2_GE, R3_GE, R4_GE, R5_GE, R6_GE, R7_GE (optional) 
            var includeGeometry = includeGeometry_example;  // string | Y or N (default is N) - if it is Y, then geometry will be part of response (optional) 

            try
            {
                // Get Earthquake Risk By Address
                EarthquakeRiskResponse result = apiInstance.GetEarthquakeRiskByAddress(address, richterValue, includeGeometry);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RisksServiceApi.GetEarthquakeRiskByAddress: " + e.Message );
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
 **richterValue** | **string**| all (default value), R0, R1, R2, R3, R4, R5, R6, R7, R0_GE, R1_GE, R2_GE, R3_GE, R4_GE, R5_GE, R6_GE, R7_GE | [optional] 
 **includeGeometry** | **string**| Y or N (default is N) - if it is Y, then geometry will be part of response | [optional] 

### Return type

[**EarthquakeRiskResponse**](EarthquakeRiskResponse.md)

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


## GetEarthquakeRiskByAddressBatch

> EarthquakeRiskResponseList GetEarthquakeRiskByAddressBatch (EarthquakeRiskByAddressRequest earthquakeRiskByAddressRequest)

Post Earthquake Risk By Address

This is a Batch offering for 'Earthquake Risk By Address' service. It accepts a single address or a list of addresses and retrieve counts of earthquakes for various richter measurements and values.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetEarthquakeRiskByAddressBatchExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RisksServiceApi(Configuration.Default);
            var earthquakeRiskByAddressRequest = new EarthquakeRiskByAddressRequest(); // EarthquakeRiskByAddressRequest | 

            try
            {
                // Post Earthquake Risk By Address
                EarthquakeRiskResponseList result = apiInstance.GetEarthquakeRiskByAddressBatch(earthquakeRiskByAddressRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RisksServiceApi.GetEarthquakeRiskByAddressBatch: " + e.Message );
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
 **earthquakeRiskByAddressRequest** | [**EarthquakeRiskByAddressRequest**](EarthquakeRiskByAddressRequest.md)|  | 

### Return type

[**EarthquakeRiskResponseList**](EarthquakeRiskResponseList.md)

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


## GetEarthquakeRiskByLocation

> EarthquakeRiskResponse GetEarthquakeRiskByLocation (string longitude, string latitude, string richterValue = null, string includeGeometry = null)

Get Earthquake Risk By Location

Accepts latitude & longitude as input and Returns counts of earthquakes for various richter measurements and values.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetEarthquakeRiskByLocationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RisksServiceApi(Configuration.Default);
            var longitude = longitude_example;  // string | The longitude of the location
            var latitude = latitude_example;  // string | The latitude of the location
            var richterValue = richterValue_example;  // string | all (default value), R0, R1, R2, R3, R4, R5, R6, R7, R0_GE, R1_GE, R2_GE, R3_GE, R4_GE, R5_GE, R6_GE, R7_GE (optional) 
            var includeGeometry = includeGeometry_example;  // string | Y or N (default is N) - if it is Y, then geometry will be part of response (optional) 

            try
            {
                // Get Earthquake Risk By Location
                EarthquakeRiskResponse result = apiInstance.GetEarthquakeRiskByLocation(longitude, latitude, richterValue, includeGeometry);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RisksServiceApi.GetEarthquakeRiskByLocation: " + e.Message );
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
 **longitude** | **string**| The longitude of the location | 
 **latitude** | **string**| The latitude of the location | 
 **richterValue** | **string**| all (default value), R0, R1, R2, R3, R4, R5, R6, R7, R0_GE, R1_GE, R2_GE, R3_GE, R4_GE, R5_GE, R6_GE, R7_GE | [optional] 
 **includeGeometry** | **string**| Y or N (default is N) - if it is Y, then geometry will be part of response | [optional] 

### Return type

[**EarthquakeRiskResponse**](EarthquakeRiskResponse.md)

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


## GetEarthquakeRiskByLocationBatch

> EarthquakeRiskResponseList GetEarthquakeRiskByLocationBatch (EarthquakeRiskByLocationRequest earthquakeRiskByLocationRequest)

Post Earthquake Risk By Location

This is a Batch offering for 'Earthquake Risk By Location' service. It accepts a single location coordinate or a list of location coordinates and retrieve counts of earthquakes for various richter measurements and values.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetEarthquakeRiskByLocationBatchExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RisksServiceApi(Configuration.Default);
            var earthquakeRiskByLocationRequest = new EarthquakeRiskByLocationRequest(); // EarthquakeRiskByLocationRequest | 

            try
            {
                // Post Earthquake Risk By Location
                EarthquakeRiskResponseList result = apiInstance.GetEarthquakeRiskByLocationBatch(earthquakeRiskByLocationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RisksServiceApi.GetEarthquakeRiskByLocationBatch: " + e.Message );
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
 **earthquakeRiskByLocationRequest** | [**EarthquakeRiskByLocationRequest**](EarthquakeRiskByLocationRequest.md)|  | 

### Return type

[**EarthquakeRiskResponseList**](EarthquakeRiskResponseList.md)

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


## GetFireHistory

> FireHistory GetFireHistory (string postCode, string startDate = null, string endDate = null, string maxCandidates = null)

Get Fire History

Accepts postcode as input and Returns fire event details for a particular postcode.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetFireHistoryExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RisksServiceApi(Configuration.Default);
            var postCode = postCode_example;  // string | 5 digit Postal code to search
            var startDate = startDate_example;  // string | Start time in milliseconds(UTC) (optional) 
            var endDate = endDate_example;  // string | End time in milliseconds(UTC) (optional) 
            var maxCandidates = maxCandidates_example;  // string | Maximum response events (optional) 

            try
            {
                // Get Fire History
                FireHistory result = apiInstance.GetFireHistory(postCode, startDate, endDate, maxCandidates);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RisksServiceApi.GetFireHistory: " + e.Message );
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
 **postCode** | **string**| 5 digit Postal code to search | 
 **startDate** | **string**| Start time in milliseconds(UTC) | [optional] 
 **endDate** | **string**| End time in milliseconds(UTC) | [optional] 
 **maxCandidates** | **string**| Maximum response events | [optional] 

### Return type

[**FireHistory**](FireHistory.md)

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


## GetFireHistoryV2

> FireHistoryV2 GetFireHistoryV2 (string postCode, string startDate = null, string endDate = null, string maxCandidates = null)

Get Fire History

Accepts postcode as input and Returns fire event details for a particular postcode.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetFireHistoryV2Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RisksServiceApi(Configuration.Default);
            var postCode = postCode_example;  // string | 5 digit Postal code to search
            var startDate = startDate_example;  // string | Start time in milliseconds(UTC) (optional) 
            var endDate = endDate_example;  // string | End time in milliseconds(UTC) (optional) 
            var maxCandidates = maxCandidates_example;  // string | Maximum response events (optional) 

            try
            {
                // Get Fire History
                FireHistoryV2 result = apiInstance.GetFireHistoryV2(postCode, startDate, endDate, maxCandidates);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RisksServiceApi.GetFireHistoryV2: " + e.Message );
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
 **postCode** | **string**| 5 digit Postal code to search | 
 **startDate** | **string**| Start time in milliseconds(UTC) | [optional] 
 **endDate** | **string**| End time in milliseconds(UTC) | [optional] 
 **maxCandidates** | **string**| Maximum response events | [optional] 

### Return type

[**FireHistoryV2**](FireHistoryV2.md)

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


## GetFireRiskByAddress

> FireRiskResponse GetFireRiskByAddress (string address, string includeGeometry = null)

Get Fire Risk By Address

Accepts addresses as input and Returns fire risk data by risk types.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetFireRiskByAddressExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RisksServiceApi(Configuration.Default);
            var address = address_example;  // string | Free form address text
            var includeGeometry = includeGeometry_example;  // string | Flag to return Geometry default is N (optional) 

            try
            {
                // Get Fire Risk By Address
                FireRiskResponse result = apiInstance.GetFireRiskByAddress(address, includeGeometry);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RisksServiceApi.GetFireRiskByAddress: " + e.Message );
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
 **address** | **string**| Free form address text | 
 **includeGeometry** | **string**| Flag to return Geometry default is N | [optional] 

### Return type

[**FireRiskResponse**](FireRiskResponse.md)

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


## GetFireRiskByAddressBatch

> FireRiskResponseList GetFireRiskByAddressBatch (FireRiskByAddressRequest fireRiskByAddressRequest)

Post Fire Risk By Address

This is a Batch offering for 'Fire Risk By Address' service. It accepts a single address or a list of addresses and retrieve fire risk data by risk types.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetFireRiskByAddressBatchExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RisksServiceApi(Configuration.Default);
            var fireRiskByAddressRequest = new FireRiskByAddressRequest(); // FireRiskByAddressRequest | 

            try
            {
                // Post Fire Risk By Address
                FireRiskResponseList result = apiInstance.GetFireRiskByAddressBatch(fireRiskByAddressRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RisksServiceApi.GetFireRiskByAddressBatch: " + e.Message );
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
 **fireRiskByAddressRequest** | [**FireRiskByAddressRequest**](FireRiskByAddressRequest.md)|  | 

### Return type

[**FireRiskResponseList**](FireRiskResponseList.md)

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


## GetFireRiskByLocation

> FireRiskResponse GetFireRiskByLocation (string longitude, string latitude, string includeGeometry = null)

Get Fire Risk By Location

Accepts latitude & longitude as input and Returns fire risk data by risk types.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetFireRiskByLocationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RisksServiceApi(Configuration.Default);
            var longitude = longitude_example;  // string | Longitude of Location
            var latitude = latitude_example;  // string | Latitude of Location
            var includeGeometry = includeGeometry_example;  // string | Flag to return Geometry default is N (optional) 

            try
            {
                // Get Fire Risk By Location
                FireRiskResponse result = apiInstance.GetFireRiskByLocation(longitude, latitude, includeGeometry);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RisksServiceApi.GetFireRiskByLocation: " + e.Message );
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
 **includeGeometry** | **string**| Flag to return Geometry default is N | [optional] 

### Return type

[**FireRiskResponse**](FireRiskResponse.md)

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


## GetFireRiskByLocationBatch

> FireRiskResponseList GetFireRiskByLocationBatch (FireRiskByLocationRequest fireRiskByLocationRequest)

Post Fire Risk By Location

This is a Batch offering for 'Fire Risk By Location' service. It accepts a single location coordinate or a list of location coordinates and retrieve fire risk data by risk types.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetFireRiskByLocationBatchExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RisksServiceApi(Configuration.Default);
            var fireRiskByLocationRequest = new FireRiskByLocationRequest(); // FireRiskByLocationRequest | 

            try
            {
                // Post Fire Risk By Location
                FireRiskResponseList result = apiInstance.GetFireRiskByLocationBatch(fireRiskByLocationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RisksServiceApi.GetFireRiskByLocationBatch: " + e.Message );
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
 **fireRiskByLocationRequest** | [**FireRiskByLocationRequest**](FireRiskByLocationRequest.md)|  | 

### Return type

[**FireRiskResponseList**](FireRiskResponseList.md)

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


## GetFireRiskV2ByAddress

> FireRiskV2Response GetFireRiskV2ByAddress (string address, string includeGeometry = null)

Get Fire Risk By Address

Accepts addresses as input and Returns fire risk data by risk types.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetFireRiskV2ByAddressExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RisksServiceApi(Configuration.Default);
            var address = address_example;  // string | Free form address text
            var includeGeometry = includeGeometry_example;  // string | Flag to return Geometry default is N (optional) 

            try
            {
                // Get Fire Risk By Address
                FireRiskV2Response result = apiInstance.GetFireRiskV2ByAddress(address, includeGeometry);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RisksServiceApi.GetFireRiskV2ByAddress: " + e.Message );
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
 **address** | **string**| Free form address text | 
 **includeGeometry** | **string**| Flag to return Geometry default is N | [optional] 

### Return type

[**FireRiskV2Response**](FireRiskV2Response.md)

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


## GetFireRiskV2ByAddressBatch

> FireRiskV2ResponseList GetFireRiskV2ByAddressBatch (FireRiskByAddressRequest fireRiskByAddressRequest)

Post Fire Risk By Address

This is a Batch offering for 'Fire Risk By Address' service. It accepts a single address or a list of addresses and retrieve fire risk data by risk types.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetFireRiskV2ByAddressBatchExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RisksServiceApi(Configuration.Default);
            var fireRiskByAddressRequest = new FireRiskByAddressRequest(); // FireRiskByAddressRequest | 

            try
            {
                // Post Fire Risk By Address
                FireRiskV2ResponseList result = apiInstance.GetFireRiskV2ByAddressBatch(fireRiskByAddressRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RisksServiceApi.GetFireRiskV2ByAddressBatch: " + e.Message );
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
 **fireRiskByAddressRequest** | [**FireRiskByAddressRequest**](FireRiskByAddressRequest.md)|  | 

### Return type

[**FireRiskV2ResponseList**](FireRiskV2ResponseList.md)

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


## GetFireRiskV2ByLocation

> FireRiskV2Response GetFireRiskV2ByLocation (string longitude, string latitude, string includeGeometry = null)

Get Fire Risk By Location

Accepts latitude & longitude as input and Returns fire risk data by risk types.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetFireRiskV2ByLocationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RisksServiceApi(Configuration.Default);
            var longitude = longitude_example;  // string | Longitude of Location
            var latitude = latitude_example;  // string | Latitude of Location
            var includeGeometry = includeGeometry_example;  // string | Flag to return Geometry default is N (optional) 

            try
            {
                // Get Fire Risk By Location
                FireRiskV2Response result = apiInstance.GetFireRiskV2ByLocation(longitude, latitude, includeGeometry);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RisksServiceApi.GetFireRiskV2ByLocation: " + e.Message );
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
 **includeGeometry** | **string**| Flag to return Geometry default is N | [optional] 

### Return type

[**FireRiskV2Response**](FireRiskV2Response.md)

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


## GetFireRiskV2ByLocationBatch

> FireRiskV2ResponseList GetFireRiskV2ByLocationBatch (FireRiskByLocationRequest fireRiskByLocationRequest)

Post Fire Risk By Location

This is a Batch offering for 'Fire Risk By Location' service. It accepts a single location coordinate or a list of location coordinates and retrieve fire risk data by risk types.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetFireRiskV2ByLocationBatchExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RisksServiceApi(Configuration.Default);
            var fireRiskByLocationRequest = new FireRiskByLocationRequest(); // FireRiskByLocationRequest | 

            try
            {
                // Post Fire Risk By Location
                FireRiskV2ResponseList result = apiInstance.GetFireRiskV2ByLocationBatch(fireRiskByLocationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RisksServiceApi.GetFireRiskV2ByLocationBatch: " + e.Message );
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
 **fireRiskByLocationRequest** | [**FireRiskByLocationRequest**](FireRiskByLocationRequest.md)|  | 

### Return type

[**FireRiskV2ResponseList**](FireRiskV2ResponseList.md)

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


## GetFireStationByAddress

> FireStations GetFireStationByAddress (string address, string maxCandidates = null, string travelTime = null, string travelTimeUnit = null, string travelDistance = null, string travelDistanceUnit = null, string sortBy = null, string historicTrafficTimeBucket = null)

Get Fire Station By Address

Accepts addresses as input and Returns nearest fire stations.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetFireStationByAddressExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RisksServiceApi(Configuration.Default);
            var address = address_example;  // string | Free Address
            var maxCandidates = maxCandidates_example;  // string | Specifies the maximum number of fire stations that this service retrieves. The default value is 3 and maximum value is 5. The retrieved results are traveldistance sorted from the input location. (optional) 
            var travelTime = travelTime_example;  // string | Max travel time from input location to fire station. Maximum allowed is 2 hours (optional) 
            var travelTimeUnit = travelTimeUnit_example;  // string | minutes (default), hours, seconds, milliseconds (optional) 
            var travelDistance = travelDistance_example;  // string | Max travel distance from input location to fire station. Maximum allowed is 50 miles (optional) 
            var travelDistanceUnit = travelDistanceUnit_example;  // string | Feet (default), Kilometers, Miles, Meters (optional) 
            var sortBy = sortBy_example;  // string | time (default), distance (optional) 
            var historicTrafficTimeBucket = historicTrafficTimeBucket_example;  // string | Historic traffic time slab (optional) 

            try
            {
                // Get Fire Station By Address
                FireStations result = apiInstance.GetFireStationByAddress(address, maxCandidates, travelTime, travelTimeUnit, travelDistance, travelDistanceUnit, sortBy, historicTrafficTimeBucket);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RisksServiceApi.GetFireStationByAddress: " + e.Message );
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
 **address** | **string**| Free Address | 
 **maxCandidates** | **string**| Specifies the maximum number of fire stations that this service retrieves. The default value is 3 and maximum value is 5. The retrieved results are traveldistance sorted from the input location. | [optional] 
 **travelTime** | **string**| Max travel time from input location to fire station. Maximum allowed is 2 hours | [optional] 
 **travelTimeUnit** | **string**| minutes (default), hours, seconds, milliseconds | [optional] 
 **travelDistance** | **string**| Max travel distance from input location to fire station. Maximum allowed is 50 miles | [optional] 
 **travelDistanceUnit** | **string**| Feet (default), Kilometers, Miles, Meters | [optional] 
 **sortBy** | **string**| time (default), distance | [optional] 
 **historicTrafficTimeBucket** | **string**| Historic traffic time slab | [optional] 

### Return type

[**FireStations**](FireStations.md)

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


## GetFireStationByLocation

> FireStations GetFireStationByLocation (string longitude, string latitude, string maxCandidates = null, string travelTime = null, string travelTimeUnit = null, string travelDistance = null, string travelDistanceUnit = null, string sortBy = null, string historicTrafficTimeBucket = null)

Get Fire Station By Location

Accepts latitude & longitude as input and Returns nearest fire stations.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetFireStationByLocationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RisksServiceApi(Configuration.Default);
            var longitude = longitude_example;  // string | Longitude of Location
            var latitude = latitude_example;  // string | Latitude of Location
            var maxCandidates = maxCandidates_example;  // string | Specifies the maximum number of fire stations that this service retrieves. The default value is 3 and maximum value is 5. The retrieved results are traveldistance sorted from the input location. (optional) 
            var travelTime = travelTime_example;  // string | Max travel time from input location to fire station. Maximum allowed is 2 hours (optional) 
            var travelTimeUnit = travelTimeUnit_example;  // string | minutes (default), hours, seconds, milliseconds (optional) 
            var travelDistance = travelDistance_example;  // string | Max travel distance from input location to fire station. Maximum allowed is 50 miles (optional) 
            var travelDistanceUnit = travelDistanceUnit_example;  // string | Feet (default), Kilometers, Miles, Meters (optional) 
            var sortBy = sortBy_example;  // string | time (default), distance (optional) 
            var historicTrafficTimeBucket = historicTrafficTimeBucket_example;  // string | Historic traffic time slab (optional) 

            try
            {
                // Get Fire Station By Location
                FireStations result = apiInstance.GetFireStationByLocation(longitude, latitude, maxCandidates, travelTime, travelTimeUnit, travelDistance, travelDistanceUnit, sortBy, historicTrafficTimeBucket);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RisksServiceApi.GetFireStationByLocation: " + e.Message );
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
 **maxCandidates** | **string**| Specifies the maximum number of fire stations that this service retrieves. The default value is 3 and maximum value is 5. The retrieved results are traveldistance sorted from the input location. | [optional] 
 **travelTime** | **string**| Max travel time from input location to fire station. Maximum allowed is 2 hours | [optional] 
 **travelTimeUnit** | **string**| minutes (default), hours, seconds, milliseconds | [optional] 
 **travelDistance** | **string**| Max travel distance from input location to fire station. Maximum allowed is 50 miles | [optional] 
 **travelDistanceUnit** | **string**| Feet (default), Kilometers, Miles, Meters | [optional] 
 **sortBy** | **string**| time (default), distance | [optional] 
 **historicTrafficTimeBucket** | **string**| Historic traffic time slab | [optional] 

### Return type

[**FireStations**](FireStations.md)

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


## GetFloodRiskByAddress

> FloodRiskResponse GetFloodRiskByAddress (string address, string includeZoneDesc = null, string includeGeometry = null)

Get Flood Risk By Address

Accepts addresses as input and Returns flood risk data for flood zones and base flood elevation values.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetFloodRiskByAddressExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RisksServiceApi(Configuration.Default);
            var address = address_example;  // string | Free text Address
            var includeZoneDesc = includeZoneDesc_example;  // string | Flag to return zone description (optional) 
            var includeGeometry = includeGeometry_example;  // string | Flag to return Geometry (optional) 

            try
            {
                // Get Flood Risk By Address
                FloodRiskResponse result = apiInstance.GetFloodRiskByAddress(address, includeZoneDesc, includeGeometry);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RisksServiceApi.GetFloodRiskByAddress: " + e.Message );
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
 **address** | **string**| Free text Address | 
 **includeZoneDesc** | **string**| Flag to return zone description | [optional] 
 **includeGeometry** | **string**| Flag to return Geometry | [optional] 

### Return type

[**FloodRiskResponse**](FloodRiskResponse.md)

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


## GetFloodRiskByAddressBatch

> FloodRiskResponseList GetFloodRiskByAddressBatch (FloodRiskByAddressRequest floodRiskByAddressRequest)

Post Flood Risk By Address

This is a Batch offering for 'Flood Risk By Address' service. It accepts a single address or a list of addresses and retrieve flood risk data for flood zones and base flood elevation values.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetFloodRiskByAddressBatchExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RisksServiceApi(Configuration.Default);
            var floodRiskByAddressRequest = new FloodRiskByAddressRequest(); // FloodRiskByAddressRequest | 

            try
            {
                // Post Flood Risk By Address
                FloodRiskResponseList result = apiInstance.GetFloodRiskByAddressBatch(floodRiskByAddressRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RisksServiceApi.GetFloodRiskByAddressBatch: " + e.Message );
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
 **floodRiskByAddressRequest** | [**FloodRiskByAddressRequest**](FloodRiskByAddressRequest.md)|  | 

### Return type

[**FloodRiskResponseList**](FloodRiskResponseList.md)

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


## GetFloodRiskByLocation

> FloodRiskResponse GetFloodRiskByLocation (string longitude, string latitude, string includeZoneDesc = null, string includeGeometry = null)

Get Flood Risk By Location

Accepts latitude & longitude as input and Returns flood risk data for flood zones and base flood elevation values.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetFloodRiskByLocationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RisksServiceApi(Configuration.Default);
            var longitude = longitude_example;  // string | Longitude of Location
            var latitude = latitude_example;  // string | Latitude of Location
            var includeZoneDesc = includeZoneDesc_example;  // string | Flag to return zone description (optional) 
            var includeGeometry = includeGeometry_example;  // string | Flag to return Geometry (optional) 

            try
            {
                // Get Flood Risk By Location
                FloodRiskResponse result = apiInstance.GetFloodRiskByLocation(longitude, latitude, includeZoneDesc, includeGeometry);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RisksServiceApi.GetFloodRiskByLocation: " + e.Message );
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
 **includeZoneDesc** | **string**| Flag to return zone description | [optional] 
 **includeGeometry** | **string**| Flag to return Geometry | [optional] 

### Return type

[**FloodRiskResponse**](FloodRiskResponse.md)

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


## GetFloodRiskByLocationBatch

> FloodRiskResponseList GetFloodRiskByLocationBatch (FloodRiskByLocationRequest floodRiskByLocationRequest)

Post Flood Risk By Location

This is a Batch offering for 'Flood Risk By Location' service. It accepts a single location coordinate or a list of location coordinates and retrieve flood risk data for flood zones and base flood elevation values.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetFloodRiskByLocationBatchExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RisksServiceApi(Configuration.Default);
            var floodRiskByLocationRequest = new FloodRiskByLocationRequest(); // FloodRiskByLocationRequest | 

            try
            {
                // Post Flood Risk By Location
                FloodRiskResponseList result = apiInstance.GetFloodRiskByLocationBatch(floodRiskByLocationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RisksServiceApi.GetFloodRiskByLocationBatch: " + e.Message );
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
 **floodRiskByLocationRequest** | [**FloodRiskByLocationRequest**](FloodRiskByLocationRequest.md)|  | 

### Return type

[**FloodRiskResponseList**](FloodRiskResponseList.md)

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

