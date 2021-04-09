# com.precisely.apis.Api.PlacesServiceApi

All URIs are relative to *https://api.precisely.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCategoryCodeMetadata**](PlacesServiceApi.md#getcategorycodemetadata) | **GET** /places/v1/metadata/category | Returns Category Codes with their sub-categories (if exist), descriptions and SIC Codes mapping
[**GetPOIById**](PlacesServiceApi.md#getpoibyid) | **GET** /places/v1/poi/{id} | Points Of Interest Details By Id
[**GetPOIsByAddress**](PlacesServiceApi.md#getpoisbyaddress) | **GET** /places/v1/poi/byaddress | Points of Interest By Address.
[**GetPOIsByArea**](PlacesServiceApi.md#getpoisbyarea) | **GET** /places/v1/poi/byarea | Points of Interest By Area.
[**GetPOIsByBoundary**](PlacesServiceApi.md#getpoisbyboundary) | **POST** /places/v1/poi/byboundary | Points Of Interest By Boundary
[**GetPOIsByLocation**](PlacesServiceApi.md#getpoisbylocation) | **GET** /places/v1/poi/bylocation | Points of Interest By Location.
[**GetPOIsCount**](PlacesServiceApi.md#getpoiscount) | **POST** /places/v1/poicount | Point of Interests count By Geometry.
[**GetSICMetadata**](PlacesServiceApi.md#getsicmetadata) | **GET** /places/v1/metadata/sic | Returns SIC Codes with their Industry Titles and Category Codes mapping
[**PoisAutocomplete**](PlacesServiceApi.md#poisautocomplete) | **GET** /places/v1/poi/autocomplete | Points of Interest Autocomplete.


<a name="getcategorycodemetadata"></a>
# **GetCategoryCodeMetadata**
> GeoEnrichMetadataResponse GetCategoryCodeMetadata (string categoryCode = null, string level = null)

Returns Category Codes with their sub-categories (if exist), descriptions and SIC Codes mapping

Accepts first partial digits or full category codes to filter the response

### Example
```csharp
using System;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetCategoryCodeMetadataExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new PlacesServiceApi();
            var categoryCode = categoryCode_example;  // string | Specify starting digits or full category code to filter the response (optional) 
            var level = level_example;  // string | Allowed values are 1,2,3. If level=1, then only 4 digits category codes will be returned, level=2 means only 6 digits category codes   will be returned, level=3 means only 11 digits category codes will be returned. Multiple comma-separated values will also be accepted. So level='1,2' means return 4 digits and 6 digits category codes. (optional) 

            try
            {
                // Returns Category Codes with their sub-categories (if exist), descriptions and SIC Codes mapping
                GeoEnrichMetadataResponse result = apiInstance.GetCategoryCodeMetadata(categoryCode, level);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlacesServiceApi.GetCategoryCodeMetadata: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **categoryCode** | **string**| Specify starting digits or full category code to filter the response | [optional] 
 **level** | **string**| Allowed values are 1,2,3. If level&#x3D;1, then only 4 digits category codes will be returned, level&#x3D;2 means only 6 digits category codes   will be returned, level&#x3D;3 means only 11 digits category codes will be returned. Multiple comma-separated values will also be accepted. So level&#x3D;&#39;1,2&#39; means return 4 digits and 6 digits category codes. | [optional] 

### Return type

[**GeoEnrichMetadataResponse**](GeoEnrichMetadataResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml, text/csv

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpoibyid"></a>
# **GetPOIById**
> POIPlaces GetPOIById (string id)

Points Of Interest Details By Id

This service returns complete details of a chosen point of interest by an identifier. The identifier could be selected from Autocomplete API response.

### Example
```csharp
using System;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetPOIByIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new PlacesServiceApi();
            var id = id_example;  // string | POI unique Identifier. Accepts only numbers.

            try
            {
                // Points Of Interest Details By Id
                POIPlaces result = apiInstance.GetPOIById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlacesServiceApi.GetPOIById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| POI unique Identifier. Accepts only numbers. | 

### Return type

[**POIPlaces**](POIPlaces.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpoisbyaddress"></a>
# **GetPOIsByAddress**
> GeoEnrichResponse GetPOIsByAddress (string address, string country = null, string name = null, string type = null, string categoryCode = null, string sicCode = null, string maxCandidates = null, string searchRadius = null, string searchRadiusUnit = null, string travelTime = null, string travelTimeUnit = null, string travelDistance = null, string travelDistanceUnit = null, string travelMode = null, string sortBy = null, string fuzzyOnName = null, string page = null, string matchMode = null, string specificMatchOn = null)

Points of Interest By Address.

Accepts address as an input to retrieve nearby points of interest.

### Example
```csharp
using System;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetPOIsByAddressExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new PlacesServiceApi();
            var address = address_example;  // string | Address
            var country = country_example;  // string | Country (optional) 
            var name = name_example;  // string | Matched against Name, BrandName and Trade Name. Partial terms are also matched with fuzziness (max edit distance is 1) (optional) 
            var type = type_example;  // string | Matched against the content which defines the type of the poi.  (optional) 
            var categoryCode = categoryCode_example;  // string | Specific Category/Categories Codes for the desired POIs. Accepts a mix of 4 digit (Top Category), 6 digit (Second-Level Category) and 11 digit (Low-Level Category) Category Codes. https://developer.precisely.com/download?CategoryCodes.xlsx  (optional) 
            var sicCode = sicCode_example;  // string | Specific SIC Codes/Codes for the desired POIs. Accepts a mix of 4 digit (Top Category) and 8 digit (Low-Level Category) SIC Codes. (optional) 
            var maxCandidates = maxCandidates_example;  // string | Maximum number of POIs that can be retrieved. (optional) 
            var searchRadius = searchRadius_example;  // string | Radius range within which search is performed. (optional) 
            var searchRadiusUnit = searchRadiusUnit_example;  // string | Radius unit such as Feet, Kilometers, Miles or Meters. (optional) 
            var travelTime = travelTime_example;  // string | Specifies the travel time within which method searches for results (POIs which can be reached within travel time)the search boundary in terms of time mentioned in 'travelTimeUnit'. The results are retrieved from the polygon formed based on the travel time specified. This means search can be done in the mentioned time results be from the mentioned time. (optional) 
            var travelTimeUnit = travelTimeUnit_example;  // string | Specifies acceptable time units.Allowed values Minutes,Hours,Seconds and Milliseconds (optional) 
            var travelDistance = travelDistance_example;  // string | Specifies the search boundary in terms of distance mentioned in 'travelDistanceUnit'. The results are retrieved from the polygon formed based on the travel distance specified. (optional) 
            var travelDistanceUnit = travelDistanceUnit_example;  // string | Specifies acceptable time units.Allowed values Feet,Kilometers,Miles and Meters (optional) 
            var travelMode = travelMode_example;  // string | Specifies the available mode of commute. This is required when u r trying to do search by travel distance or travel time. Allowed values driving and walking (optional) 
            var sortBy = sortBy_example;  // string | Specifies the order in which POIs are retrieved. (optional)  (default to distance)
            var fuzzyOnName = fuzzyOnName_example;  // string | Allowed values are Y/N. If N, the search on name will not allow fuzziness. (optional) 
            var page = page_example;  // string | Will support pagination, by default 1st page with maxCandidates results are returned. (optional) 
            var matchMode = matchMode_example;  // string |  (optional) 
            var specificMatchOn = specificMatchOn_example;  // string |  (optional) 

            try
            {
                // Points of Interest By Address.
                GeoEnrichResponse result = apiInstance.GetPOIsByAddress(address, country, name, type, categoryCode, sicCode, maxCandidates, searchRadius, searchRadiusUnit, travelTime, travelTimeUnit, travelDistance, travelDistanceUnit, travelMode, sortBy, fuzzyOnName, page, matchMode, specificMatchOn);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlacesServiceApi.GetPOIsByAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **string**| Address | 
 **country** | **string**| Country | [optional] 
 **name** | **string**| Matched against Name, BrandName and Trade Name. Partial terms are also matched with fuzziness (max edit distance is 1) | [optional] 
 **type** | **string**| Matched against the content which defines the type of the poi.  | [optional] 
 **categoryCode** | **string**| Specific Category/Categories Codes for the desired POIs. Accepts a mix of 4 digit (Top Category), 6 digit (Second-Level Category) and 11 digit (Low-Level Category) Category Codes. https://developer.precisely.com/download?CategoryCodes.xlsx  | [optional] 
 **sicCode** | **string**| Specific SIC Codes/Codes for the desired POIs. Accepts a mix of 4 digit (Top Category) and 8 digit (Low-Level Category) SIC Codes. | [optional] 
 **maxCandidates** | **string**| Maximum number of POIs that can be retrieved. | [optional] 
 **searchRadius** | **string**| Radius range within which search is performed. | [optional] 
 **searchRadiusUnit** | **string**| Radius unit such as Feet, Kilometers, Miles or Meters. | [optional] 
 **travelTime** | **string**| Specifies the travel time within which method searches for results (POIs which can be reached within travel time)the search boundary in terms of time mentioned in &#39;travelTimeUnit&#39;. The results are retrieved from the polygon formed based on the travel time specified. This means search can be done in the mentioned time results be from the mentioned time. | [optional] 
 **travelTimeUnit** | **string**| Specifies acceptable time units.Allowed values Minutes,Hours,Seconds and Milliseconds | [optional] 
 **travelDistance** | **string**| Specifies the search boundary in terms of distance mentioned in &#39;travelDistanceUnit&#39;. The results are retrieved from the polygon formed based on the travel distance specified. | [optional] 
 **travelDistanceUnit** | **string**| Specifies acceptable time units.Allowed values Feet,Kilometers,Miles and Meters | [optional] 
 **travelMode** | **string**| Specifies the available mode of commute. This is required when u r trying to do search by travel distance or travel time. Allowed values driving and walking | [optional] 
 **sortBy** | **string**| Specifies the order in which POIs are retrieved. | [optional] [default to distance]
 **fuzzyOnName** | **string**| Allowed values are Y/N. If N, the search on name will not allow fuzziness. | [optional] 
 **page** | **string**| Will support pagination, by default 1st page with maxCandidates results are returned. | [optional] 
 **matchMode** | **string**|  | [optional] 
 **specificMatchOn** | **string**|  | [optional] 

### Return type

[**GeoEnrichResponse**](GeoEnrichResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml, text/csv

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpoisbyarea"></a>
# **GetPOIsByArea**
> GeoEnrichResponse GetPOIsByArea (string country, string areaName3 = null, string postcode1 = null, string postcode2 = null, string name = null, string type = null, string categoryCode = null, string sicCode = null, string maxCandidates = null, string fuzzyOnName = null, string page = null, string matchMode = null, string specificMatchOn = null)

Points of Interest By Area.

Accepts postcode or city as an input to retrieve nearby points of interest.

### Example
```csharp
using System;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetPOIsByAreaExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new PlacesServiceApi();
            var country = country_example;  // string | Country
            var areaName3 = areaName3_example;  // string | Either areaName3 or postcode is required (optional) 
            var postcode1 = postcode1_example;  // string | Either areaName3 or postcode is required (optional) 
            var postcode2 = postcode2_example;  // string | postcode extension (optional) 
            var name = name_example;  // string | Matched against Name, BrandName and Trade Name. Partial terms are also matched with fuzziness (max edit distance is 1) (optional) 
            var type = type_example;  // string | Matched against the content which defines the type of the poi.  (optional) 
            var categoryCode = categoryCode_example;  // string | Specific Category/Categories Codes for the desired POIs. Accepts a mix of 4 digit (Top Category), 6 digit (Second-Level Category) and 11 digit (Low-Level Category) Category Codes. https://developer.precisely.com/download?CategoryCodes.xlsx  (optional) 
            var sicCode = sicCode_example;  // string | Specific SIC Codes/Codes for the desired POIs. Accepts a mix of 4 digit (Top Category) and 8 digit (Low-Level Category) SIC Codes. (optional) 
            var maxCandidates = maxCandidates_example;  // string | Maximum number of POIs that can be retrieved. (optional) 
            var fuzzyOnName = fuzzyOnName_example;  // string | Allowed values are Y/N. If N, the search on name will not allow fuzziness. (optional) 
            var page = page_example;  // string | Will support pagination, by default 1st page with maxCandidates results are returned. (optional) 
            var matchMode = matchMode_example;  // string |  (optional) 
            var specificMatchOn = specificMatchOn_example;  // string |  (optional) 

            try
            {
                // Points of Interest By Area.
                GeoEnrichResponse result = apiInstance.GetPOIsByArea(country, areaName3, postcode1, postcode2, name, type, categoryCode, sicCode, maxCandidates, fuzzyOnName, page, matchMode, specificMatchOn);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlacesServiceApi.GetPOIsByArea: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **country** | **string**| Country | 
 **areaName3** | **string**| Either areaName3 or postcode is required | [optional] 
 **postcode1** | **string**| Either areaName3 or postcode is required | [optional] 
 **postcode2** | **string**| postcode extension | [optional] 
 **name** | **string**| Matched against Name, BrandName and Trade Name. Partial terms are also matched with fuzziness (max edit distance is 1) | [optional] 
 **type** | **string**| Matched against the content which defines the type of the poi.  | [optional] 
 **categoryCode** | **string**| Specific Category/Categories Codes for the desired POIs. Accepts a mix of 4 digit (Top Category), 6 digit (Second-Level Category) and 11 digit (Low-Level Category) Category Codes. https://developer.precisely.com/download?CategoryCodes.xlsx  | [optional] 
 **sicCode** | **string**| Specific SIC Codes/Codes for the desired POIs. Accepts a mix of 4 digit (Top Category) and 8 digit (Low-Level Category) SIC Codes. | [optional] 
 **maxCandidates** | **string**| Maximum number of POIs that can be retrieved. | [optional] 
 **fuzzyOnName** | **string**| Allowed values are Y/N. If N, the search on name will not allow fuzziness. | [optional] 
 **page** | **string**| Will support pagination, by default 1st page with maxCandidates results are returned. | [optional] 
 **matchMode** | **string**|  | [optional] 
 **specificMatchOn** | **string**|  | [optional] 

### Return type

[**GeoEnrichResponse**](GeoEnrichResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml, text/csv

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpoisbyboundary"></a>
# **GetPOIsByBoundary**
> Pois GetPOIsByBoundary (string accept = null, string contentType = null, POIByGeometryRequest body = null)

Points Of Interest By Boundary

Accepts a user-defined boundary as input and returns all Points of Interest within the boundary. Additionally, user can filter the response by name, type, standard industrial classifications and category codes.

### Example
```csharp
using System;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetPOIsByBoundaryExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new PlacesServiceApi();
            var accept = accept_example;  // string |  (optional) 
            var contentType = contentType_example;  // string |  (optional) 
            var body = new POIByGeometryRequest(); // POIByGeometryRequest |  (optional) 

            try
            {
                // Points Of Interest By Boundary
                Pois result = apiInstance.GetPOIsByBoundary(accept, contentType, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlacesServiceApi.GetPOIsByBoundary: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**|  | [optional] 
 **contentType** | **string**|  | [optional] 
 **body** | [**POIByGeometryRequest**](POIByGeometryRequest.md)|  | [optional] 

### Return type

[**Pois**](Pois.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml, text/csv

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpoisbylocation"></a>
# **GetPOIsByLocation**
> GeoEnrichResponse GetPOIsByLocation (string longitude, string latitude, string searchText = null, string type = null, string categoryCode = null, string sicCode = null, string maxCandidates = null, string searchRadius = null, string searchRadiusUnit = null, string travelTime = null, string travelTimeUnit = null, string travelDistance = null, string travelDistanceUnit = null, string travelMode = null, string sortBy = null, string fuzzyOnName = null, string page = null, string searchOnNameOnly = null, string matchMode = null, string specificMatchOn = null)

Points of Interest By Location.

Accepts longitude and latitude as an input to retrieve nearby points of interest.

### Example
```csharp
using System;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetPOIsByLocationExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new PlacesServiceApi();
            var longitude = longitude_example;  // string | Longitude of the location.
            var latitude = latitude_example;  // string | Latitude of the location.
            var searchText = searchText_example;  // string | Matched against Name, BrandName and Trade Name. Partial terms are also matched with fuzziness (max edit distance is 1) (optional) 
            var type = type_example;  // string | Matched against the content which defines the type of the poi.  (optional) 
            var categoryCode = categoryCode_example;  // string | Specific Category/Categories Codes for the desired POIs. Accepts a mix of 4 digit (Top Category), 6 digit (Second-Level Category) and 11 digit (Low-Level Category) Category Codes. https://developer.precisely.com/download?CategoryCodes.xlsx  (optional) 
            var sicCode = sicCode_example;  // string | Specific SIC Codes/Codes for the desired POIs. Accepts a mix of 4 digit (Top Category) and 8 digit (Low-Level Category) SIC Codes. (optional) 
            var maxCandidates = maxCandidates_example;  // string | Maximum number of POIs that can be retrieved. (optional) 
            var searchRadius = searchRadius_example;  // string | Radius range within which search is performed. (optional) 
            var searchRadiusUnit = searchRadiusUnit_example;  // string | Radius unit such as Feet, Kilometers, Miles or Meters. (optional) 
            var travelTime = travelTime_example;  // string | Specifies the travel time within which method searches for results (POIs which can be reached within travel time)the search boundary in terms of time mentioned in 'travelTimeUnit'. The results are retrieved from the polygon formed based on the travel time specified. This means search can be done in the mentioned time results be from the mentioned time. (optional) 
            var travelTimeUnit = travelTimeUnit_example;  // string | Specifies acceptable time units.Allowed values Minutes,Hours,Seconds and Milliseconds (optional) 
            var travelDistance = travelDistance_example;  // string | Specifies the search boundary in terms of distance mentioned in 'travelDistanceUnit'. The results are retrieved from the polygon formed based on the travel distance specified. (optional) 
            var travelDistanceUnit = travelDistanceUnit_example;  // string | Specifies acceptable time units.Allowed values Feet,Kilometers,Miles and Meters (optional) 
            var travelMode = travelMode_example;  // string | Specifies the available mode of commute. This is required when u r trying to do search by travel distance or travel time. Allowed values driving and walking (optional) 
            var sortBy = sortBy_example;  // string | Specifies the order in which POIs are retrieved. (optional)  (default to distance)
            var fuzzyOnName = fuzzyOnName_example;  // string | Allowed values are Y/N. If N, the search on name will not allow fuzziness. (optional) 
            var page = page_example;  // string | Will support pagination, by default 1st page with maxCandidates results are returned. (optional) 
            var searchOnNameOnly = searchOnNameOnly_example;  // string | search name description (optional) 
            var matchMode = matchMode_example;  // string |  (optional) 
            var specificMatchOn = specificMatchOn_example;  // string |  (optional) 

            try
            {
                // Points of Interest By Location.
                GeoEnrichResponse result = apiInstance.GetPOIsByLocation(longitude, latitude, searchText, type, categoryCode, sicCode, maxCandidates, searchRadius, searchRadiusUnit, travelTime, travelTimeUnit, travelDistance, travelDistanceUnit, travelMode, sortBy, fuzzyOnName, page, searchOnNameOnly, matchMode, specificMatchOn);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlacesServiceApi.GetPOIsByLocation: " + e.Message );
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
 **searchText** | **string**| Matched against Name, BrandName and Trade Name. Partial terms are also matched with fuzziness (max edit distance is 1) | [optional] 
 **type** | **string**| Matched against the content which defines the type of the poi.  | [optional] 
 **categoryCode** | **string**| Specific Category/Categories Codes for the desired POIs. Accepts a mix of 4 digit (Top Category), 6 digit (Second-Level Category) and 11 digit (Low-Level Category) Category Codes. https://developer.precisely.com/download?CategoryCodes.xlsx  | [optional] 
 **sicCode** | **string**| Specific SIC Codes/Codes for the desired POIs. Accepts a mix of 4 digit (Top Category) and 8 digit (Low-Level Category) SIC Codes. | [optional] 
 **maxCandidates** | **string**| Maximum number of POIs that can be retrieved. | [optional] 
 **searchRadius** | **string**| Radius range within which search is performed. | [optional] 
 **searchRadiusUnit** | **string**| Radius unit such as Feet, Kilometers, Miles or Meters. | [optional] 
 **travelTime** | **string**| Specifies the travel time within which method searches for results (POIs which can be reached within travel time)the search boundary in terms of time mentioned in &#39;travelTimeUnit&#39;. The results are retrieved from the polygon formed based on the travel time specified. This means search can be done in the mentioned time results be from the mentioned time. | [optional] 
 **travelTimeUnit** | **string**| Specifies acceptable time units.Allowed values Minutes,Hours,Seconds and Milliseconds | [optional] 
 **travelDistance** | **string**| Specifies the search boundary in terms of distance mentioned in &#39;travelDistanceUnit&#39;. The results are retrieved from the polygon formed based on the travel distance specified. | [optional] 
 **travelDistanceUnit** | **string**| Specifies acceptable time units.Allowed values Feet,Kilometers,Miles and Meters | [optional] 
 **travelMode** | **string**| Specifies the available mode of commute. This is required when u r trying to do search by travel distance or travel time. Allowed values driving and walking | [optional] 
 **sortBy** | **string**| Specifies the order in which POIs are retrieved. | [optional] [default to distance]
 **fuzzyOnName** | **string**| Allowed values are Y/N. If N, the search on name will not allow fuzziness. | [optional] 
 **page** | **string**| Will support pagination, by default 1st page with maxCandidates results are returned. | [optional] 
 **searchOnNameOnly** | **string**| search name description | [optional] 
 **matchMode** | **string**|  | [optional] 
 **specificMatchOn** | **string**|  | [optional] 

### Return type

[**GeoEnrichResponse**](GeoEnrichResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml, text/csv

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpoiscount"></a>
# **GetPOIsCount**
> PoiCount GetPOIsCount (string contentType = null, PoiCountRequest body = null)

Point of Interests count By Geometry.

Accepts geometry/loc/address as an input to count nearby point of interests.

### Example
```csharp
using System;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetPOIsCountExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new PlacesServiceApi();
            var contentType = contentType_example;  // string |  (optional) 
            var body = new PoiCountRequest(); // PoiCountRequest |  (optional) 

            try
            {
                // Point of Interests count By Geometry.
                PoiCount result = apiInstance.GetPOIsCount(contentType, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlacesServiceApi.GetPOIsCount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**|  | [optional] 
 **body** | [**PoiCountRequest**](PoiCountRequest.md)|  | [optional] 

### Return type

[**PoiCount**](PoiCount.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsicmetadata"></a>
# **GetSICMetadata**
> GeoEnrichMetadataResponse GetSICMetadata (string sicCode = null, string level = null)

Returns SIC Codes with their Industry Titles and Category Codes mapping

Accepts first few partial digits or full SIC codes to filter the response

### Example
```csharp
using System;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetSICMetadataExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new PlacesServiceApi();
            var sicCode = sicCode_example;  // string | Specify starting digits or full sic code to filter the response (optional) 
            var level = level_example;  // string | Allowed values are 1,2. If level=1, then only 4 digits sic codes will be returned, level=2 means only 8 digits sic codes will be returned. Multiple comma-separated values will also be accepted. So level='1,2' means return both 4 digits and 8 digits sic codes. (optional) 

            try
            {
                // Returns SIC Codes with their Industry Titles and Category Codes mapping
                GeoEnrichMetadataResponse result = apiInstance.GetSICMetadata(sicCode, level);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlacesServiceApi.GetSICMetadata: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sicCode** | **string**| Specify starting digits or full sic code to filter the response | [optional] 
 **level** | **string**| Allowed values are 1,2. If level&#x3D;1, then only 4 digits sic codes will be returned, level&#x3D;2 means only 8 digits sic codes will be returned. Multiple comma-separated values will also be accepted. So level&#x3D;&#39;1,2&#39; means return both 4 digits and 8 digits sic codes. | [optional] 

### Return type

[**GeoEnrichMetadataResponse**](GeoEnrichMetadataResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml, text/csv

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="poisautocomplete"></a>
# **PoisAutocomplete**
> GeoEnrichResponse PoisAutocomplete (string longitude = null, string latitude = null, string searchText = null, string searchRadius = null, string searchRadiusUnit = null, string travelTime = null, string travelTimeUnit = null, string travelDistance = null, string travelDistanceUnit = null, string travelMode = null, string country = null, string areaName1 = null, string areaName3 = null, string postcode1 = null, string postcode2 = null, string ipAddress = null, string autoDetectLocation = null, string type = null, string categoryCode = null, string sicCode = null, string maxCandidates = null, string sortBy = null, string searchOnNameOnly = null, string matchMode = null, string specificMatchOn = null)

Points of Interest Autocomplete.

POIs-Autocomplete will return POIs predictions based on the full or partial words specified in the search.The search can then be narrowed based on Location, IP Address or Country along with other supporting filters.

### Example
```csharp
using System;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class PoisAutocompleteExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new PlacesServiceApi();
            var longitude = longitude_example;  // string | Longitude of the location. (optional) 
            var latitude = latitude_example;  // string | Latitude of the location. (optional) 
            var searchText = searchText_example;  // string | Matched against Name, BrandName and Trade Name. Partial terms are also matched with fuzziness (max edit distance is 1) (optional) 
            var searchRadius = searchRadius_example;  // string | Radius range within which search is performed. (optional) 
            var searchRadiusUnit = searchRadiusUnit_example;  // string | Radius unit such as Feet, Kilometers, Miles or Meters. (optional) 
            var travelTime = travelTime_example;  // string | Specifies the travel time within which method searches for results (POIs which can be reached within travel time)the search boundary in terms of time mentioned in 'travelTimeUnit'. The results are retrieved from the polygon formed based on the travel time specified. This means search can be done in the mentioned time results be from the mentioned time. (optional) 
            var travelTimeUnit = travelTimeUnit_example;  // string | Specifies acceptable time units.Allowed values Minutes,Hours,Seconds and Milliseconds (optional) 
            var travelDistance = travelDistance_example;  // string | Specifies the search boundary in terms of distance mentioned in 'travelDistanceUnit'. The results are retrieved from the polygon formed based on the travel distance specified. (optional) 
            var travelDistanceUnit = travelDistanceUnit_example;  // string | Specifies acceptable time units.Allowed values Feet,Kilometers,Miles and Meters (optional) 
            var travelMode = travelMode_example;  // string | Specifies the available mode of commute. This is required when u r trying to do search by travel distance or travel time. Allowed values driving and walking (optional) 
            var country = country_example;  // string | Country (optional) 
            var areaName1 = areaName1_example;  // string | Specifies the largest geographical area, typically a state or province. (optional) 
            var areaName3 = areaName3_example;  // string | Specifies the name of the city or town.  (optional) 
            var postcode1 = postcode1_example;  // string | Postal Code of the input to be searched (optional) 
            var postcode2 = postcode2_example;  // string | Postcode2 (optional) 
            var ipAddress = ipAddress_example;  // string | IP address of network connected device in standard IPv4 octet and a valid external address. (optional) 
            var autoDetectLocation = autoDetectLocation_example;  // string | Specifies whether to auto-detect location from IP address. If 'True' is set, the location is detected from the specified ip address. If 'False' is set. the search will happen according to country or location. (optional) 
            var type = type_example;  // string | Matched against the content which defines the type of the poi.  (optional) 
            var categoryCode = categoryCode_example;  // string | Specific Category/Categories Codes for the desired POIs. Accepts a mix of 4 digit (Top Category), 6 digit (Second-Level Category) and 11 digit (Low-Level Category) Category Codes. https://developer.precisely.com/download?CategoryCodes.xlsx  (optional) 
            var sicCode = sicCode_example;  // string | Specific SIC Codes/Codes for the desired POIs. Accepts a mix of 4 digit (Top Category) and 8 digit (Low-Level Category) SIC Codes. (optional) 
            var maxCandidates = maxCandidates_example;  // string | Maximum number of POIs that can be retrieved. (optional) 
            var sortBy = sortBy_example;  // string | Specifies the order in which POIs are retrieved. (optional)  (default to distance)
            var searchOnNameOnly = searchOnNameOnly_example;  // string | specifies search on name (optional) 
            var matchMode = matchMode_example;  // string |  (optional) 
            var specificMatchOn = specificMatchOn_example;  // string |  (optional) 

            try
            {
                // Points of Interest Autocomplete.
                GeoEnrichResponse result = apiInstance.PoisAutocomplete(longitude, latitude, searchText, searchRadius, searchRadiusUnit, travelTime, travelTimeUnit, travelDistance, travelDistanceUnit, travelMode, country, areaName1, areaName3, postcode1, postcode2, ipAddress, autoDetectLocation, type, categoryCode, sicCode, maxCandidates, sortBy, searchOnNameOnly, matchMode, specificMatchOn);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlacesServiceApi.PoisAutocomplete: " + e.Message );
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
 **searchText** | **string**| Matched against Name, BrandName and Trade Name. Partial terms are also matched with fuzziness (max edit distance is 1) | [optional] 
 **searchRadius** | **string**| Radius range within which search is performed. | [optional] 
 **searchRadiusUnit** | **string**| Radius unit such as Feet, Kilometers, Miles or Meters. | [optional] 
 **travelTime** | **string**| Specifies the travel time within which method searches for results (POIs which can be reached within travel time)the search boundary in terms of time mentioned in &#39;travelTimeUnit&#39;. The results are retrieved from the polygon formed based on the travel time specified. This means search can be done in the mentioned time results be from the mentioned time. | [optional] 
 **travelTimeUnit** | **string**| Specifies acceptable time units.Allowed values Minutes,Hours,Seconds and Milliseconds | [optional] 
 **travelDistance** | **string**| Specifies the search boundary in terms of distance mentioned in &#39;travelDistanceUnit&#39;. The results are retrieved from the polygon formed based on the travel distance specified. | [optional] 
 **travelDistanceUnit** | **string**| Specifies acceptable time units.Allowed values Feet,Kilometers,Miles and Meters | [optional] 
 **travelMode** | **string**| Specifies the available mode of commute. This is required when u r trying to do search by travel distance or travel time. Allowed values driving and walking | [optional] 
 **country** | **string**| Country | [optional] 
 **areaName1** | **string**| Specifies the largest geographical area, typically a state or province. | [optional] 
 **areaName3** | **string**| Specifies the name of the city or town.  | [optional] 
 **postcode1** | **string**| Postal Code of the input to be searched | [optional] 
 **postcode2** | **string**| Postcode2 | [optional] 
 **ipAddress** | **string**| IP address of network connected device in standard IPv4 octet and a valid external address. | [optional] 
 **autoDetectLocation** | **string**| Specifies whether to auto-detect location from IP address. If &#39;True&#39; is set, the location is detected from the specified ip address. If &#39;False&#39; is set. the search will happen according to country or location. | [optional] 
 **type** | **string**| Matched against the content which defines the type of the poi.  | [optional] 
 **categoryCode** | **string**| Specific Category/Categories Codes for the desired POIs. Accepts a mix of 4 digit (Top Category), 6 digit (Second-Level Category) and 11 digit (Low-Level Category) Category Codes. https://developer.precisely.com/download?CategoryCodes.xlsx  | [optional] 
 **sicCode** | **string**| Specific SIC Codes/Codes for the desired POIs. Accepts a mix of 4 digit (Top Category) and 8 digit (Low-Level Category) SIC Codes. | [optional] 
 **maxCandidates** | **string**| Maximum number of POIs that can be retrieved. | [optional] 
 **sortBy** | **string**| Specifies the order in which POIs are retrieved. | [optional] [default to distance]
 **searchOnNameOnly** | **string**| specifies search on name | [optional] 
 **matchMode** | **string**|  | [optional] 
 **specificMatchOn** | **string**|  | [optional] 

### Return type

[**GeoEnrichResponse**](GeoEnrichResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

