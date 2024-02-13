# com.precisely.apis.Api.PlacesServiceApi

All URIs are relative to *https://api.precisely.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCategoryCodeMetadata**](PlacesServiceApi.md#getcategorycodemetadata) | **GET** /places/v1/metadata/category | Category Code Metadata.
[**GetPOIById**](PlacesServiceApi.md#getpoibyid) | **GET** /places/v1/poi/{id} | Points Of Interest Details By Id
[**GetPOIsByAddress**](PlacesServiceApi.md#getpoisbyaddress) | **GET** /places/v1/poi/byaddress | Get POIs By Address.
[**GetPOIsByArea**](PlacesServiceApi.md#getpoisbyarea) | **GET** /places/v1/poi/byarea | GET Points Of Interest By Area.
[**GetPOIsByGeometry**](PlacesServiceApi.md#getpoisbygeometry) | **POST** /places/v1/poi/byboundary | Points Of Interest By Boundary
[**GetPOIsByLocation**](PlacesServiceApi.md#getpoisbylocation) | **GET** /places/v1/poi/bylocation | Get POIs By Location.
[**GetPOIsCount**](PlacesServiceApi.md#getpoiscount) | **POST** /places/v1/poicount | Points Of Interest Count
[**GetSICMetadata**](PlacesServiceApi.md#getsicmetadata) | **GET** /places/v1/metadata/sic | Get SIC Metadata
[**PoisAutocomplete**](PlacesServiceApi.md#poisautocomplete) | **GET** /places/v1/poi/autocomplete | Points Of Interest Autocomplete



## GetCategoryCodeMetadata

> MetadataResponse GetCategoryCodeMetadata (string categoryCode = null, string level = null)

Category Code Metadata.

This service returns a list of Category codes & associated metadata which can then be used as inputs for querying the Points of Interest By Address or Location methods listed above.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetCategoryCodeMetadataExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PlacesServiceApi(Configuration.Default);
            var categoryCode = categoryCode_example;  // string | 4, 6, or 11 digits category code to filter the response. (optional) 
            var level = level_example;  // string | 1, 2, or 3. (optional) 

            try
            {
                // Category Code Metadata.
                MetadataResponse result = apiInstance.GetCategoryCodeMetadata(categoryCode, level);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PlacesServiceApi.GetCategoryCodeMetadata: " + e.Message );
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
 **categoryCode** | **string**| 4, 6, or 11 digits category code to filter the response. | [optional] 
 **level** | **string**| 1, 2, or 3. | [optional] 

### Return type

[**MetadataResponse**](MetadataResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, text/csv


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


## GetPOIById

> Poi GetPOIById (string id)

Points Of Interest Details By Id

This service returns complete details of a chosen point of interest by an identifier. The identifier could be selected from Autocomplete API response.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetPOIByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PlacesServiceApi(Configuration.Default);
            var id = id_example;  // string | POI unique Identifier.

            try
            {
                // Points Of Interest Details By Id
                Poi result = apiInstance.GetPOIById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PlacesServiceApi.GetPOIById: " + e.Message );
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
 **id** | **string**| POI unique Identifier. | 

### Return type

[**Poi**](Poi.md)

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


## GetPOIsByAddress

> PlacesResponse GetPOIsByAddress (string address = null, string country = null, string name = null, string type = null, string categoryCode = null, string sicCode = null, string maxCandidates = null, string searchRadius = null, string searchRadiusUnit = null, string travelTime = null, string travelTimeUnit = null, string travelDistance = null, string travelDistanceUnit = null, string travelMode = null, string sortBy = null, string fuzzyOnName = null, string page = null, string matchMode = null, string specificMatchOn = null)

Get POIs By Address.

This service accepts an address as input and returns nearby points-of-interest places around that address. Additional input features include retrieving data by name, type, standard industrial classifications and category codes, as well as geographic filtering by radius, travel times and travel distances. Response features include JSON as well as CSV download.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetPOIsByAddressExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PlacesServiceApi(Configuration.Default);
            var address = address_example;  // string | The address to be searched. (optional) 
            var country = country_example;  // string | Country ISO code. (optional) 
            var name = name_example;  // string | Specifies the name of the place (POI) to be searched. Also performs search on partially specified names. It requires minimum 3 characters to search. (optional) 
            var type = type_example;  // string | Filters the points of interest (POIs) by place types. (optional) 
            var categoryCode = categoryCode_example;  // string | Acts as a filter to narrow down and refine POI search results. The category codes are unique 4, 6, or 11 digit numeric values. (optional) 
            var sicCode = sicCode_example;  // string | Acts as a filter to narrow down and refine POI search results. The SIC codes are unique 4 or 8 digit numerical values (optional) 
            var maxCandidates = maxCandidates_example;  // string | Maximum number of POIs that can be retrieved (optional) 
            var searchRadius = searchRadius_example;  // string | Radius range within which search is performed. (optional) 
            var searchRadiusUnit = searchRadiusUnit_example;  // string | Radius unit such as Feet, Kilometers, Miles or Meters (default). (optional) 
            var travelTime = travelTime_example;  // string | Travel time within which search is performed (POIs which can be reached within travel time). (optional) 
            var travelTimeUnit = travelTimeUnit_example;  // string | Travel time unit such as minutes (default), hours, seconds or milliseconds. (optional) 
            var travelDistance = travelDistance_example;  // string | Travel distance within which search is performed (POIs which can be reached within travel distance). (optional) 
            var travelDistanceUnit = travelDistanceUnit_example;  // string | Travel distance unit such as Feet (default), Kilometers, Miles or Meters. (optional) 
            var travelMode = travelMode_example;  // string | Mode of commute. (optional)  (default to "driving")
            var sortBy = sortBy_example;  // string | Whether to sort the results based on relevance (best match) or by nearest distance from input location. (optional) 
            var fuzzyOnName = fuzzyOnName_example;  // string | Whether to allow fuzzy seacrh on name input. (optional) 
            var page = page_example;  // string | Specifies the page number of results where page size is the value of maxCandidates input in request. (optional) 
            var matchMode = matchMode_example;  // string | Determine the leniency used to make a match between the input name and the reference data. (optional) 
            var specificMatchOn = specificMatchOn_example;  // string | Specifies the field for the Specific Match Mode. (optional) 

            try
            {
                // Get POIs By Address.
                PlacesResponse result = apiInstance.GetPOIsByAddress(address, country, name, type, categoryCode, sicCode, maxCandidates, searchRadius, searchRadiusUnit, travelTime, travelTimeUnit, travelDistance, travelDistanceUnit, travelMode, sortBy, fuzzyOnName, page, matchMode, specificMatchOn);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PlacesServiceApi.GetPOIsByAddress: " + e.Message );
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
 **address** | **string**| The address to be searched. | [optional] 
 **country** | **string**| Country ISO code. | [optional] 
 **name** | **string**| Specifies the name of the place (POI) to be searched. Also performs search on partially specified names. It requires minimum 3 characters to search. | [optional] 
 **type** | **string**| Filters the points of interest (POIs) by place types. | [optional] 
 **categoryCode** | **string**| Acts as a filter to narrow down and refine POI search results. The category codes are unique 4, 6, or 11 digit numeric values. | [optional] 
 **sicCode** | **string**| Acts as a filter to narrow down and refine POI search results. The SIC codes are unique 4 or 8 digit numerical values | [optional] 
 **maxCandidates** | **string**| Maximum number of POIs that can be retrieved | [optional] 
 **searchRadius** | **string**| Radius range within which search is performed. | [optional] 
 **searchRadiusUnit** | **string**| Radius unit such as Feet, Kilometers, Miles or Meters (default). | [optional] 
 **travelTime** | **string**| Travel time within which search is performed (POIs which can be reached within travel time). | [optional] 
 **travelTimeUnit** | **string**| Travel time unit such as minutes (default), hours, seconds or milliseconds. | [optional] 
 **travelDistance** | **string**| Travel distance within which search is performed (POIs which can be reached within travel distance). | [optional] 
 **travelDistanceUnit** | **string**| Travel distance unit such as Feet (default), Kilometers, Miles or Meters. | [optional] 
 **travelMode** | **string**| Mode of commute. | [optional] [default to &quot;driving&quot;]
 **sortBy** | **string**| Whether to sort the results based on relevance (best match) or by nearest distance from input location. | [optional] 
 **fuzzyOnName** | **string**| Whether to allow fuzzy seacrh on name input. | [optional] 
 **page** | **string**| Specifies the page number of results where page size is the value of maxCandidates input in request. | [optional] 
 **matchMode** | **string**| Determine the leniency used to make a match between the input name and the reference data. | [optional] 
 **specificMatchOn** | **string**| Specifies the field for the Specific Match Mode. | [optional] 

### Return type

[**PlacesResponse**](PlacesResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, text/csv


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


## GetPOIsByArea

> PlacesResponse GetPOIsByArea (string areaName1 = null, string areaName3 = null, string postcode1 = null, string postcode2 = null, string country = null, string name = null, string type = null, string categoryCode = null, string sicCode = null, string maxCandidates = null, string fuzzyOnName = null, string page = null, string matchMode = null, string specificMatchOn = null)

GET Points Of Interest By Area.

This service accepts city or postcode (alongwith country) and returns points-of-interest places within a city or postcode. Additional input features include retrieving data by name, type, standard industrial classifications and category codes, as well as geographic filtering by radius, travel times and travel distances. Response features include JSON as well as CSV download.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetPOIsByAreaExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PlacesServiceApi(Configuration.Default);
            var areaName1 = areaName1_example;  // string | Specifies the largest geographical area, typically a state or province (optional) 
            var areaName3 = areaName3_example;  // string | Specifies a city or town name (optional) 
            var postcode1 = postcode1_example;  // string | Specifies the postcode(ZIP code) in the appropriate format for the country (optional) 
            var postcode2 = postcode2_example;  // string | Specifies the postcode(ZIP code) extension (optional) 
            var country = country_example;  // string | Country ISO code (optional) 
            var name = name_example;  // string | Specifies the name of the place (POI) to be searched. Also performs search on partially specified names. It requires minimum 3 characters to search (optional) 
            var type = type_example;  // string | Filters the points of interest (POIs) by place types (optional) 
            var categoryCode = categoryCode_example;  // string | Acts as a filter to narrow down and refine POI search results. The category codes are unique 4, 6, or 11 digit numeric values (optional) 
            var sicCode = sicCode_example;  // string | Acts as a filter to narrow down and refine POI search results. The SIC codes are unique 4 or 8 digit numerical values (optional) 
            var maxCandidates = maxCandidates_example;  // string | Maximum number of POIs that can be retrieved (optional) 
            var fuzzyOnName = fuzzyOnName_example;  // string | Whether to allow fuzzy seacrh on name input (optional) 
            var page = page_example;  // string | Specifies the page number of results where page size is the value of maxCandidates input in request (optional) 
            var matchMode = matchMode_example;  // string | Determine the leniency used to make a match between the input name and the reference data (optional) 
            var specificMatchOn = specificMatchOn_example;  // string | Specifies the field for the Specific Match Mode (optional) 

            try
            {
                // GET Points Of Interest By Area.
                PlacesResponse result = apiInstance.GetPOIsByArea(areaName1, areaName3, postcode1, postcode2, country, name, type, categoryCode, sicCode, maxCandidates, fuzzyOnName, page, matchMode, specificMatchOn);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PlacesServiceApi.GetPOIsByArea: " + e.Message );
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
 **areaName1** | **string**| Specifies the largest geographical area, typically a state or province | [optional] 
 **areaName3** | **string**| Specifies a city or town name | [optional] 
 **postcode1** | **string**| Specifies the postcode(ZIP code) in the appropriate format for the country | [optional] 
 **postcode2** | **string**| Specifies the postcode(ZIP code) extension | [optional] 
 **country** | **string**| Country ISO code | [optional] 
 **name** | **string**| Specifies the name of the place (POI) to be searched. Also performs search on partially specified names. It requires minimum 3 characters to search | [optional] 
 **type** | **string**| Filters the points of interest (POIs) by place types | [optional] 
 **categoryCode** | **string**| Acts as a filter to narrow down and refine POI search results. The category codes are unique 4, 6, or 11 digit numeric values | [optional] 
 **sicCode** | **string**| Acts as a filter to narrow down and refine POI search results. The SIC codes are unique 4 or 8 digit numerical values | [optional] 
 **maxCandidates** | **string**| Maximum number of POIs that can be retrieved | [optional] 
 **fuzzyOnName** | **string**| Whether to allow fuzzy seacrh on name input | [optional] 
 **page** | **string**| Specifies the page number of results where page size is the value of maxCandidates input in request | [optional] 
 **matchMode** | **string**| Determine the leniency used to make a match between the input name and the reference data | [optional] 
 **specificMatchOn** | **string**| Specifies the field for the Specific Match Mode | [optional] 

### Return type

[**PlacesResponse**](PlacesResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, text/csv


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


## GetPOIsByGeometry

> PlacesResponse GetPOIsByGeometry (POIByGeometryRequest pOIByGeometryRequest)

Points Of Interest By Boundary

Accepts a user-defined boundary as input and returns all Points of Interest within the boundary. Additionally, user can filter the response by name, type, standard industrial classifications and category codes.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetPOIsByGeometryExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PlacesServiceApi(Configuration.Default);
            var pOIByGeometryRequest = new POIByGeometryRequest(); // POIByGeometryRequest | 

            try
            {
                // Points Of Interest By Boundary
                PlacesResponse result = apiInstance.GetPOIsByGeometry(pOIByGeometryRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PlacesServiceApi.GetPOIsByGeometry: " + e.Message );
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
 **pOIByGeometryRequest** | [**POIByGeometryRequest**](POIByGeometryRequest.md)|  | 

### Return type

[**PlacesResponse**](PlacesResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json, text/csv


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


## GetPOIsByLocation

> PlacesResponse GetPOIsByLocation (string longitude, string latitude, string name = null, string type = null, string categoryCode = null, string sicCode = null, string maxCandidates = null, string searchRadius = null, string searchRadiusUnit = null, string travelTime = null, string travelTimeUnit = null, string travelDistance = null, string travelDistanceUnit = null, string travelMode = null, string sortBy = null, string fuzzyOnName = null, string page = null, string matchMode = null, string specificMatchOn = null)

Get POIs By Location.

This service accepts latitude/longitude as input and returns nearby points-of-interest places around that location. Additional input features include retrieving data by name, type, standard industrial classifications and category codes, as well as geographic filtering by radius, travel times and travel distances. Response features include JSON as well as CSV download

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetPOIsByLocationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PlacesServiceApi(Configuration.Default);
            var longitude = longitude_example;  // string | Longitude of the location.
            var latitude = latitude_example;  // string | Latitude of the location.
            var name = name_example;  // string | Specifies the name of the place (POI) to be searched. Also performs search on partially specified names. It requires minimum 3 characters to search. (optional) 
            var type = type_example;  // string | Filters the points of interest (POIs) by place types. (optional) 
            var categoryCode = categoryCode_example;  // string | Acts as a filter to narrow down and refine POI search results. The category codes are unique 4, 6, or 11 digit numeric values. (optional) 
            var sicCode = sicCode_example;  // string | Acts as a filter to narrow down and refine POI search results. The SIC codes are unique 4 or 8 digit numerical values (optional) 
            var maxCandidates = maxCandidates_example;  // string | Maximum number of POIs that can be retrieved (optional) 
            var searchRadius = searchRadius_example;  // string | Radius range within which search is performed. (optional) 
            var searchRadiusUnit = searchRadiusUnit_example;  // string | Radius unit such as Feet, Kilometers, Miles or Meters (default). (optional) 
            var travelTime = travelTime_example;  // string | Travel time within which search is performed (POIs which can be reached within travel time). (optional) 
            var travelTimeUnit = travelTimeUnit_example;  // string | Travel time unit such as minutes (default), hours, seconds or milliseconds. (optional) 
            var travelDistance = travelDistance_example;  // string | Travel distance within which search is performed (POIs which can be reached within travel distance). (optional) 
            var travelDistanceUnit = travelDistanceUnit_example;  // string | Travel distance unit such as Feet (default), Kilometers, Miles or Meters. (optional) 
            var travelMode = travelMode_example;  // string | Mode of commute. (optional) 
            var sortBy = sortBy_example;  // string | Whether to sort the results based on relevance (best match) or by nearest distance from input location. (optional) 
            var fuzzyOnName = fuzzyOnName_example;  // string | Whether to allow fuzzy seacrh on name input. (optional) 
            var page = page_example;  // string | Specifies the page number of results where page size is the value of maxCandidates input in request. (optional) 
            var matchMode = matchMode_example;  // string | Determine the leniency used to make a match between the input name and the reference data. (optional) 
            var specificMatchOn = specificMatchOn_example;  // string | Specifies the field for the Specific Match Mode. (optional) 

            try
            {
                // Get POIs By Location.
                PlacesResponse result = apiInstance.GetPOIsByLocation(longitude, latitude, name, type, categoryCode, sicCode, maxCandidates, searchRadius, searchRadiusUnit, travelTime, travelTimeUnit, travelDistance, travelDistanceUnit, travelMode, sortBy, fuzzyOnName, page, matchMode, specificMatchOn);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PlacesServiceApi.GetPOIsByLocation: " + e.Message );
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
 **name** | **string**| Specifies the name of the place (POI) to be searched. Also performs search on partially specified names. It requires minimum 3 characters to search. | [optional] 
 **type** | **string**| Filters the points of interest (POIs) by place types. | [optional] 
 **categoryCode** | **string**| Acts as a filter to narrow down and refine POI search results. The category codes are unique 4, 6, or 11 digit numeric values. | [optional] 
 **sicCode** | **string**| Acts as a filter to narrow down and refine POI search results. The SIC codes are unique 4 or 8 digit numerical values | [optional] 
 **maxCandidates** | **string**| Maximum number of POIs that can be retrieved | [optional] 
 **searchRadius** | **string**| Radius range within which search is performed. | [optional] 
 **searchRadiusUnit** | **string**| Radius unit such as Feet, Kilometers, Miles or Meters (default). | [optional] 
 **travelTime** | **string**| Travel time within which search is performed (POIs which can be reached within travel time). | [optional] 
 **travelTimeUnit** | **string**| Travel time unit such as minutes (default), hours, seconds or milliseconds. | [optional] 
 **travelDistance** | **string**| Travel distance within which search is performed (POIs which can be reached within travel distance). | [optional] 
 **travelDistanceUnit** | **string**| Travel distance unit such as Feet (default), Kilometers, Miles or Meters. | [optional] 
 **travelMode** | **string**| Mode of commute. | [optional] 
 **sortBy** | **string**| Whether to sort the results based on relevance (best match) or by nearest distance from input location. | [optional] 
 **fuzzyOnName** | **string**| Whether to allow fuzzy seacrh on name input. | [optional] 
 **page** | **string**| Specifies the page number of results where page size is the value of maxCandidates input in request. | [optional] 
 **matchMode** | **string**| Determine the leniency used to make a match between the input name and the reference data. | [optional] 
 **specificMatchOn** | **string**| Specifies the field for the Specific Match Mode. | [optional] 

### Return type

[**PlacesResponse**](PlacesResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, text/csv


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


## GetPOIsCount

> PoiCount GetPOIsCount (string contentType, PoiCountRequest poiCountRequest)

Points Of Interest Count

Accepts a user-defined boundary as input and returns the Count number of POIs within the boundary. Additionally, user can request the count of filtered POIs by name, type, standard industrial classifications and category codes within the given polygon.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetPOIsCountExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PlacesServiceApi(Configuration.Default);
            var contentType = contentType_example;  // string | 
            var poiCountRequest = new PoiCountRequest(); // PoiCountRequest | 

            try
            {
                // Points Of Interest Count
                PoiCount result = apiInstance.GetPOIsCount(contentType, poiCountRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PlacesServiceApi.GetPOIsCount: " + e.Message );
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
 **contentType** | **string**|  | 
 **poiCountRequest** | [**PoiCountRequest**](PoiCountRequest.md)|  | 

### Return type

[**PoiCount**](PoiCount.md)

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


## GetSICMetadata

> MetadataResponse GetSICMetadata (string sicCode = null, string level = null)

Get SIC Metadata

This service returns a list of standard industrial classification codes & associated metadata which can then be used as inputs for querying the Points of Interest By Address or Location methods listed above.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetSICMetadataExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PlacesServiceApi(Configuration.Default);
            var sicCode = sicCode_example;  // string | 4 or 8 digits SIC code to filter the response. (optional) 
            var level = level_example;  // string | 1 or 2. (optional) 

            try
            {
                // Get SIC Metadata
                MetadataResponse result = apiInstance.GetSICMetadata(sicCode, level);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PlacesServiceApi.GetSICMetadata: " + e.Message );
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
 **sicCode** | **string**| 4 or 8 digits SIC code to filter the response. | [optional] 
 **level** | **string**| 1 or 2. | [optional] 

### Return type

[**MetadataResponse**](MetadataResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, text/csv


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


## PoisAutocomplete

> PlacesResponse PoisAutocomplete (string xForwardedFor = null, string longitude = null, string latitude = null, string searchText = null, string searchOnNameOnly = null, string searchRadius = null, string searchRadiusUnit = null, string travelTime = null, string travelTimeUnit = null, string travelDistance = null, string travelDistanceUnit = null, string travelMode = null, string country = null, string areaName1 = null, string areaName3 = null, string postcode1 = null, string postcode2 = null, string ipAddress = null, string autoDetectLocation = null, string type = null, string categoryCode = null, string sicCode = null, string maxCandidates = null, string sortBy = null, string matchMode = null, string specificMatchOn = null)

Points Of Interest Autocomplete

This service accepts partial text input and returns matching points of interest, sorted by relevance or distance.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class PoisAutocompleteExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PlacesServiceApi(Configuration.Default);
            var xForwardedFor = xForwardedFor_example;  // string |  (optional) 
            var longitude = longitude_example;  // string | Longitude of the location. (optional) 
            var latitude = latitude_example;  // string | Latitude of the location. (optional) 
            var searchText = searchText_example;  // string | Free text which will accept a multi-word string. Combination of POI name and address is possible. (optional) 
            var searchOnNameOnly = searchOnNameOnly_example;  // string |  (optional)  (default to "N")
            var searchRadius = searchRadius_example;  // string | Radius range within which search is performed. (optional) 
            var searchRadiusUnit = searchRadiusUnit_example;  // string | Radius unit such as Feet, Kilometers, Miles or Meters (default). (optional) 
            var travelTime = travelTime_example;  // string | Travel time within which search is performed (POIs which can be reached within travel time). (optional) 
            var travelTimeUnit = travelTimeUnit_example;  // string | Travel time unit such as minutes (default), hours, seconds or milliseconds. (optional) 
            var travelDistance = travelDistance_example;  // string | Travel distance within which search is performed (POIs which can be reached within travel distance). (optional) 
            var travelDistanceUnit = travelDistanceUnit_example;  // string | Travel distance unit such as Feet (default), Kilometers, Miles or Meters. (optional) 
            var travelMode = travelMode_example;  // string | Mode of commute. (optional)  (default to "driving")
            var country = country_example;  // string | Country ISO code. (optional) 
            var areaName1 = areaName1_example;  // string | Specifies the largest geographical area, typically a state or province. (optional) 
            var areaName3 = areaName3_example;  // string | Specifies a city or town name. (optional) 
            var postcode1 = postcode1_example;  // string | Specifies the postcode(ZIP code) in the appropriate format for the country. (optional) 
            var postcode2 = postcode2_example;  // string | Specifies the postcode(ZIP code) extension. (optional) 
            var ipAddress = ipAddress_example;  // string | IP address which will be used to auto detect the location in order to serve contextually relevant results. (optional) 
            var autoDetectLocation = autoDetectLocation_example;  // string | Specifies whether to detect client's location using IP address. If IP address(below) is not provided and autoDetectLocation is set 'True' then IP address will be picked from HTTP request automatically. (optional) 
            var type = type_example;  // string | Filters the points of interest (POIs) by place types. (optional) 
            var categoryCode = categoryCode_example;  // string | Acts as a filter to narrow down and refine POI search results. The category codes are unique 4, 6, or 11 digit numeric values. (optional) 
            var sicCode = sicCode_example;  // string | Acts as a filter to narrow down and refine POI search results. The SIC codes are unique 4 or 8 digit numerical values. (optional) 
            var maxCandidates = maxCandidates_example;  // string | Maximum number of POIs that can be retrieved. (optional) 
            var sortBy = sortBy_example;  // string | sortBy (optional) 
            var matchMode = matchMode_example;  // string | Determine the leniency used to make a match between the input name and the reference data. (optional) 
            var specificMatchOn = specificMatchOn_example;  // string | Specifies the field for the Specific Match Mode. (optional) 

            try
            {
                // Points Of Interest Autocomplete
                PlacesResponse result = apiInstance.PoisAutocomplete(xForwardedFor, longitude, latitude, searchText, searchOnNameOnly, searchRadius, searchRadiusUnit, travelTime, travelTimeUnit, travelDistance, travelDistanceUnit, travelMode, country, areaName1, areaName3, postcode1, postcode2, ipAddress, autoDetectLocation, type, categoryCode, sicCode, maxCandidates, sortBy, matchMode, specificMatchOn);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PlacesServiceApi.PoisAutocomplete: " + e.Message );
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
 **xForwardedFor** | **string**|  | [optional] 
 **longitude** | **string**| Longitude of the location. | [optional] 
 **latitude** | **string**| Latitude of the location. | [optional] 
 **searchText** | **string**| Free text which will accept a multi-word string. Combination of POI name and address is possible. | [optional] 
 **searchOnNameOnly** | **string**|  | [optional] [default to &quot;N&quot;]
 **searchRadius** | **string**| Radius range within which search is performed. | [optional] 
 **searchRadiusUnit** | **string**| Radius unit such as Feet, Kilometers, Miles or Meters (default). | [optional] 
 **travelTime** | **string**| Travel time within which search is performed (POIs which can be reached within travel time). | [optional] 
 **travelTimeUnit** | **string**| Travel time unit such as minutes (default), hours, seconds or milliseconds. | [optional] 
 **travelDistance** | **string**| Travel distance within which search is performed (POIs which can be reached within travel distance). | [optional] 
 **travelDistanceUnit** | **string**| Travel distance unit such as Feet (default), Kilometers, Miles or Meters. | [optional] 
 **travelMode** | **string**| Mode of commute. | [optional] [default to &quot;driving&quot;]
 **country** | **string**| Country ISO code. | [optional] 
 **areaName1** | **string**| Specifies the largest geographical area, typically a state or province. | [optional] 
 **areaName3** | **string**| Specifies a city or town name. | [optional] 
 **postcode1** | **string**| Specifies the postcode(ZIP code) in the appropriate format for the country. | [optional] 
 **postcode2** | **string**| Specifies the postcode(ZIP code) extension. | [optional] 
 **ipAddress** | **string**| IP address which will be used to auto detect the location in order to serve contextually relevant results. | [optional] 
 **autoDetectLocation** | **string**| Specifies whether to detect client&#39;s location using IP address. If IP address(below) is not provided and autoDetectLocation is set &#39;True&#39; then IP address will be picked from HTTP request automatically. | [optional] 
 **type** | **string**| Filters the points of interest (POIs) by place types. | [optional] 
 **categoryCode** | **string**| Acts as a filter to narrow down and refine POI search results. The category codes are unique 4, 6, or 11 digit numeric values. | [optional] 
 **sicCode** | **string**| Acts as a filter to narrow down and refine POI search results. The SIC codes are unique 4 or 8 digit numerical values. | [optional] 
 **maxCandidates** | **string**| Maximum number of POIs that can be retrieved. | [optional] 
 **sortBy** | **string**| sortBy | [optional] 
 **matchMode** | **string**| Determine the leniency used to make a match between the input name and the reference data. | [optional] 
 **specificMatchOn** | **string**| Specifies the field for the Specific Match Mode. | [optional] 

### Return type

[**PlacesResponse**](PlacesResponse.md)

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

