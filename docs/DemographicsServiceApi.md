# com.precisely.apis.Api.DemographicsServiceApi

All URIs are relative to *https://api.precisely.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetDemographicsAdvanced**](DemographicsServiceApi.md#getdemographicsadvanced) | **POST** /demographics-segmentation/v1/advanced/demographics | Demographics Advanced Endpoint
[**GetDemographicsBasic**](DemographicsServiceApi.md#getdemographicsbasic) | **GET** /demographics-segmentation/v1/basic/demographics | Demographics Basic
[**GetDemographicsByAddress**](DemographicsServiceApi.md#getdemographicsbyaddress) | **GET** /demographics-segmentation/v1/demographics/byaddress | Demographics By Address.
[**GetDemographicsByBoundaryIds**](DemographicsServiceApi.md#getdemographicsbyboundaryids) | **GET** /demographics-segmentation/v1/demographics/byboundaryids | Demographics By Boundaryids.
[**GetDemographicsByLocation**](DemographicsServiceApi.md#getdemographicsbylocation) | **GET** /demographics-segmentation/v1/demographics/bylocation | Demographics By Location.
[**GetSegmentationByAddress**](DemographicsServiceApi.md#getsegmentationbyaddress) | **GET** /demographics-segmentation/v1/segmentation/byaddress | Segmentation By Address.
[**GetSegmentationByLocation**](DemographicsServiceApi.md#getsegmentationbylocation) | **GET** /demographics-segmentation/v1/segmentation/bylocation | Segmentation By Location.



## GetDemographicsAdvanced

> Demographics GetDemographicsAdvanced (DemographicsAdvancedRequest demographicsAdvancedRequest)

Demographics Advanced Endpoint

Demographics Advanced Endpoint will return the aggregated values of the selected demographics variables of the regions falling inside a user provided geometry or travel time/distance boundaries. All the intersecting demographic boundaries will be snapped completely, and user will have option to request these boundaries in response.  

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetDemographicsAdvancedExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DemographicsServiceApi(Configuration.Default);
            var demographicsAdvancedRequest = new DemographicsAdvancedRequest(); // DemographicsAdvancedRequest | 

            try
            {
                // Demographics Advanced Endpoint
                Demographics result = apiInstance.GetDemographicsAdvanced(demographicsAdvancedRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DemographicsServiceApi.GetDemographicsAdvanced: " + e.Message );
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
 **demographicsAdvancedRequest** | [**DemographicsAdvancedRequest**](DemographicsAdvancedRequest.md)|  | 

### Return type

[**Demographics**](Demographics.md)

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


## GetDemographicsBasic

> Demographics GetDemographicsBasic (string address = null, string longitude = null, string latitude = null, string searchRadius = null, string searchRadiusUnit = null, string travelTime = null, string travelTimeUnit = null, string travelDistance = null, string travelDistanceUnit = null, string travelMode = null, string country = null, string profile = null, string filter = null, string includeGeometry = null)

Demographics Basic

Demographics Basic Endpoint will return the aggregated values of the selected demographics variables of the regions falling inside the search radius. All the intersecting demographic boundaries will be snapped completely and user will have option to request these boundaries in response.  

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetDemographicsBasicExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DemographicsServiceApi(Configuration.Default);
            var address = address_example;  // string | Address to be searched (optional) 
            var longitude = longitude_example;  // string | Longitude of the location (optional) 
            var latitude = latitude_example;  // string | Latitude of the location (optional) 
            var searchRadius = searchRadius_example;  // string | Radius within which demographics details are required. Max. value is 52800 Feet or 10 miles (optional) 
            var searchRadiusUnit = searchRadiusUnit_example;  // string | Radius unit such as Feet, Kilometers, Miles or Meters  (optional) 
            var travelTime = travelTime_example;  // string | Travel Time based on ‘travelMode’ within which demographics details are required. Max. value is 1 hour. (optional) 
            var travelTimeUnit = travelTimeUnit_example;  // string | minutes,hours,seconds,milliseconds. Default is meters.Default is minutes. (optional) 
            var travelDistance = travelDistance_example;  // string | Travel Distance based on ‘travelMode’ within which demographics details are required. Max. value is 10 miles. (optional) 
            var travelDistanceUnit = travelDistanceUnit_example;  // string | feet,kilometers,miles,meters.  Default is feet. (optional) 
            var travelMode = travelMode_example;  // string | Default is driving. (optional) 
            var country = country_example;  // string | 3 digit ISO country code (Used in case address is mentioned). (optional) 
            var profile = profile_example;  // string | Applicable on ranged variables. Returns top sorted result based on the input value. (optional) 
            var filter = filter_example;  // string | If Y, demographic boundaries are returned in response. (optional) 
            var includeGeometry = includeGeometry_example;  // string |  (optional) 

            try
            {
                // Demographics Basic
                Demographics result = apiInstance.GetDemographicsBasic(address, longitude, latitude, searchRadius, searchRadiusUnit, travelTime, travelTimeUnit, travelDistance, travelDistanceUnit, travelMode, country, profile, filter, includeGeometry);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DemographicsServiceApi.GetDemographicsBasic: " + e.Message );
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
 **address** | **string**| Address to be searched | [optional] 
 **longitude** | **string**| Longitude of the location | [optional] 
 **latitude** | **string**| Latitude of the location | [optional] 
 **searchRadius** | **string**| Radius within which demographics details are required. Max. value is 52800 Feet or 10 miles | [optional] 
 **searchRadiusUnit** | **string**| Radius unit such as Feet, Kilometers, Miles or Meters  | [optional] 
 **travelTime** | **string**| Travel Time based on ‘travelMode’ within which demographics details are required. Max. value is 1 hour. | [optional] 
 **travelTimeUnit** | **string**| minutes,hours,seconds,milliseconds. Default is meters.Default is minutes. | [optional] 
 **travelDistance** | **string**| Travel Distance based on ‘travelMode’ within which demographics details are required. Max. value is 10 miles. | [optional] 
 **travelDistanceUnit** | **string**| feet,kilometers,miles,meters.  Default is feet. | [optional] 
 **travelMode** | **string**| Default is driving. | [optional] 
 **country** | **string**| 3 digit ISO country code (Used in case address is mentioned). | [optional] 
 **profile** | **string**| Applicable on ranged variables. Returns top sorted result based on the input value. | [optional] 
 **filter** | **string**| If Y, demographic boundaries are returned in response. | [optional] 
 **includeGeometry** | **string**|  | [optional] 

### Return type

[**Demographics**](Demographics.md)

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


## GetDemographicsByAddress

> Demographics GetDemographicsByAddress (string address, string country = null, string profile = null, string filter = null, string valueFormat = null, string variableLevel = null)

Demographics By Address.

Provides the demographic details around a specified address. GeoLife 'byaddress' service accepts address as an input to return a specific population segment's age group, ethnicity, income, purchasing behaviour, commuter patterns and more.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetDemographicsByAddressExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DemographicsServiceApi(Configuration.Default);
            var address = address_example;  // string | The address to be searched.
            var country = country_example;  // string | 3 letter ISO code of the country to be searched.Allowed values USA,CAN,GBR,AUS. (optional) 
            var profile = profile_example;  // string | Retrieves the sorted demographic data on the basis of pre-defined profiles that can display the top 3 or top 5 results (by location) either in ascending or descending order.Allowed values Top5Ascending,Top5Descending,Top3Ascending,Top3Descending (optional) 
            var filter = filter_example;  // string | The 'filter' parameter retrieves the demographic data based upon specified input themes. (optional) 
            var valueFormat = valueFormat_example;  // string | The 'valueFormat' parameter is applicable for few ranged variables where percent & count both are available and filter response based on the input value. (optional) 
            var variableLevel = variableLevel_example;  // string | The 'variableLevel' retrieves demographic facts in response based on the input value (optional) 

            try
            {
                // Demographics By Address.
                Demographics result = apiInstance.GetDemographicsByAddress(address, country, profile, filter, valueFormat, variableLevel);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DemographicsServiceApi.GetDemographicsByAddress: " + e.Message );
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
 **country** | **string**| 3 letter ISO code of the country to be searched.Allowed values USA,CAN,GBR,AUS. | [optional] 
 **profile** | **string**| Retrieves the sorted demographic data on the basis of pre-defined profiles that can display the top 3 or top 5 results (by location) either in ascending or descending order.Allowed values Top5Ascending,Top5Descending,Top3Ascending,Top3Descending | [optional] 
 **filter** | **string**| The &#39;filter&#39; parameter retrieves the demographic data based upon specified input themes. | [optional] 
 **valueFormat** | **string**| The &#39;valueFormat&#39; parameter is applicable for few ranged variables where percent &amp; count both are available and filter response based on the input value. | [optional] 
 **variableLevel** | **string**| The &#39;variableLevel&#39; retrieves demographic facts in response based on the input value | [optional] 

### Return type

[**Demographics**](Demographics.md)

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


## GetDemographicsByBoundaryIds

> Demographics GetDemographicsByBoundaryIds (string boundaryIds = null, string profile = null, string filter = null, string valueFormat = null, string variableLevel = null)

Demographics By Boundaryids.

This endpoint will allow the user to request demographics details by census boundary id. Multiple comma separated boundary ids will be accepted. 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetDemographicsByBoundaryIdsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DemographicsServiceApi(Configuration.Default);
            var boundaryIds = boundaryIds_example;  // string | Accepts comma separated multiple boundary ids. (optional) 
            var profile = profile_example;  // string | Applicable on ranged variables. Returns top sorted result based on the input value. (optional) 
            var filter = filter_example;  // string | Accept the comma separated theme names and filter response based on value. Maximum 10 can be provided. (optional) 
            var valueFormat = valueFormat_example;  // string | Applicable for few ranged variables where percent & count both are available and filter response based on the input value. (optional) 
            var variableLevel = variableLevel_example;  // string | Retrieves demographic facts in response based on the input value. (optional) 

            try
            {
                // Demographics By Boundaryids.
                Demographics result = apiInstance.GetDemographicsByBoundaryIds(boundaryIds, profile, filter, valueFormat, variableLevel);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DemographicsServiceApi.GetDemographicsByBoundaryIds: " + e.Message );
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
 **boundaryIds** | **string**| Accepts comma separated multiple boundary ids. | [optional] 
 **profile** | **string**| Applicable on ranged variables. Returns top sorted result based on the input value. | [optional] 
 **filter** | **string**| Accept the comma separated theme names and filter response based on value. Maximum 10 can be provided. | [optional] 
 **valueFormat** | **string**| Applicable for few ranged variables where percent &amp; count both are available and filter response based on the input value. | [optional] 
 **variableLevel** | **string**| Retrieves demographic facts in response based on the input value. | [optional] 

### Return type

[**Demographics**](Demographics.md)

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


## GetDemographicsByLocation

> Demographics GetDemographicsByLocation (string longitude = null, string latitude = null, string profile = null, string filter = null, string valueFormat = null, string variableLevel = null)

Demographics By Location.

Provides the demographic details around a specified location. GeoLife 'bylocation' service accepts longitude and latitude as an input to return a specific population segment's age group, ethnicity, income, purchasing behaviour, commuter patterns and more.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetDemographicsByLocationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DemographicsServiceApi(Configuration.Default);
            var longitude = longitude_example;  // string | Longitude of the location. (optional) 
            var latitude = latitude_example;  // string | Latitude of the location. (optional) 
            var profile = profile_example;  // string | Retrieves the sorted demographic data on the basis of pre-defined profiles that can display the top 3 or top 5 results (by location) either in ascending or descending order.Allowed values Top5Ascending,Top5Descending,Top3Ascending,Top3Descending (optional) 
            var filter = filter_example;  // string | The 'filter' parameter retrieves the demographic data based upon specified input themes. (optional) 
            var valueFormat = valueFormat_example;  // string | The 'valueFormat' parameter is applicable for few ranged variables where percent & count both are available and filter response based on the input value. (optional) 
            var variableLevel = variableLevel_example;  // string | The 'variableLevel' retrieves demographic facts in response based on the input value (optional) 

            try
            {
                // Demographics By Location.
                Demographics result = apiInstance.GetDemographicsByLocation(longitude, latitude, profile, filter, valueFormat, variableLevel);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DemographicsServiceApi.GetDemographicsByLocation: " + e.Message );
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
 **profile** | **string**| Retrieves the sorted demographic data on the basis of pre-defined profiles that can display the top 3 or top 5 results (by location) either in ascending or descending order.Allowed values Top5Ascending,Top5Descending,Top3Ascending,Top3Descending | [optional] 
 **filter** | **string**| The &#39;filter&#39; parameter retrieves the demographic data based upon specified input themes. | [optional] 
 **valueFormat** | **string**| The &#39;valueFormat&#39; parameter is applicable for few ranged variables where percent &amp; count both are available and filter response based on the input value. | [optional] 
 **variableLevel** | **string**| The &#39;variableLevel&#39; retrieves demographic facts in response based on the input value | [optional] 

### Return type

[**Demographics**](Demographics.md)

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


## GetSegmentationByAddress

> Segmentation GetSegmentationByAddress (string address, string country = null)

Segmentation By Address.

Provides the segmentation details around a specified address. GeoLife 'Segmentation by Address' service accepts address as an input to return the lifestyle characteristics of households in terms of their family status, children characteristics, income behaviors, financial preferences and interests.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetSegmentationByAddressExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DemographicsServiceApi(Configuration.Default);
            var address = address_example;  // string | The address to be searched.
            var country = country_example;  // string | 3 letter ISO code of the country to be searched.Allowed values USA,CAN,GBR,FRA,ITA,AUS,DEU. (optional) 

            try
            {
                // Segmentation By Address.
                Segmentation result = apiInstance.GetSegmentationByAddress(address, country);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DemographicsServiceApi.GetSegmentationByAddress: " + e.Message );
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
 **country** | **string**| 3 letter ISO code of the country to be searched.Allowed values USA,CAN,GBR,FRA,ITA,AUS,DEU. | [optional] 

### Return type

[**Segmentation**](Segmentation.md)

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


## GetSegmentationByLocation

> Segmentation GetSegmentationByLocation (string longitude, string latitude)

Segmentation By Location.

Provides the segmentation details around a specified location. GeoLife 'segmentation bylocation' service accepts longitude and latitude as an input to return the lifestyle characteristics of households in terms of their family status, children characteristics, income behaviors, financial preferences and interests.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetSegmentationByLocationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DemographicsServiceApi(Configuration.Default);
            var longitude = longitude_example;  // string | Longitude of the location.
            var latitude = latitude_example;  // string | Latitude of the location.

            try
            {
                // Segmentation By Location.
                Segmentation result = apiInstance.GetSegmentationByLocation(longitude, latitude);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DemographicsServiceApi.GetSegmentationByLocation: " + e.Message );
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

[**Segmentation**](Segmentation.md)

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

