# com.precisely.apis.Api.RoutingServiceApi

All URIs are relative to *https://api.precisely.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetRouteByAddress**](RoutingServiceApi.md#getroutebyaddress) | **GET** /routing/v1/route/byaddress | Gets Route By Address.
[**GetRouteByLocation**](RoutingServiceApi.md#getroutebylocation) | **GET** /routing/v1/route/bylocation | Gets Route By Location.
[**GetTravelCostMatrixByAddress**](RoutingServiceApi.md#gettravelcostmatrixbyaddress) | **GET** /routing/v1/travelcostmatrix/byaddress | Get Cost Matrix By Address.
[**GetTravelCostMatrixByLocation**](RoutingServiceApi.md#gettravelcostmatrixbylocation) | **GET** /routing/v1/travelcostmatrix/bylocation | Get Cost Matrix By Location.



## GetRouteByAddress

> RouteResponse GetRouteByAddress (string startAddress = null, string endAddress = null, string db = null, string country = null, string intermediateAddresses = null, string returnIntermediatePoints = null, string oip = null, string destinationSrs = null, string optimizeBy = null, string returnDistance = null, string distanceUnit = null, string returnTime = null, string timeUnit = null, string language = null, string directionsStyle = null, string segmentGeometryStyle = null, string primaryNameOnly = null, string majorRoads = null, string historicTrafficTimeBucket = null, string returnDirectionGeometry = null, string useCvr = null, string looseningBarrierRestrictions = null, string vehicleType = null, string weight = null, string weightUnit = null, string height = null, string heightUnit = null, string length = null, string lengthUnit = null, string width = null, string widthUnit = null)

Gets Route By Address.

Accepts addresses as input and Returns Point-to-Point and Multi-Point travel directions by various travel modes.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetRouteByAddressExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RoutingServiceApi(Configuration.Default);
            var startAddress = startAddress_example;  // string | Starting address of the route. (optional) 
            var endAddress = endAddress_example;  // string | Ending address of the route. (optional) 
            var db = db_example;  // string | Mode of commute. (optional)  (default to "driving")
            var country = country_example;  // string | Three digit ISO country code. (optional)  (default to "USA")
            var intermediateAddresses = intermediateAddresses_example;  // string | List of intermediate points of the route. (optional) 
            var returnIntermediatePoints = returnIntermediatePoints_example;  // string | return intermediate points (optional)  (default to "false")
            var oip = oip_example;  // string | Specifies whether waypoints need to be optimized. (optional)  (default to "false")
            var destinationSrs = destinationSrs_example;  // string | Specifies the desired coordinate system of the returned route. (optional) 
            var optimizeBy = optimizeBy_example;  // string | Specifies whether the route should be optimized by time or distance. (optional)  (default to "time")
            var returnDistance = returnDistance_example;  // string | Specifies whether distance needs to be part of direction information in response. (optional)  (default to "true")
            var distanceUnit = distanceUnit_example;  // string | Return Distance Unit such as ft(Foot), km(Kilometer), mi(Mile), m(Meter) or yd(Yard). (optional)  (default to "m")
            var returnTime = returnTime_example;  // string | Specifies whether time needs to be part of direction information in response. (optional)  (default to "true")
            var timeUnit = timeUnit_example;  // string | Return time unit such as min(Minute), h(Hour), s(Second) or msec(Millisecond) (optional)  (default to "min")
            var language = language_example;  // string | Specifies the language of travel directions. (optional) 
            var directionsStyle = directionsStyle_example;  // string | Specifies whether route directions text is to be returned in the response and in what detail (Normal or Terse). (optional)  (default to "None")
            var segmentGeometryStyle = segmentGeometryStyle_example;  // string | Specifies whether the route geometry is to be returned in the response and in what detail (End or All). (optional)  (default to "none")
            var primaryNameOnly = primaryNameOnly_example;  // string | If true then only the primary street name is returned otherwise all the names for a street. (optional)  (default to "false")
            var majorRoads = majorRoads_example;  // string | Whether to include all roads in route calculation or just major roads. (optional)  (default to "false")
            var historicTrafficTimeBucket = historicTrafficTimeBucket_example;  // string | Specifies whether routing calculation uses the historic traffic speeds. (optional)  (default to "None")
            var returnDirectionGeometry = returnDirectionGeometry_example;  // string | Whether to include geometry associated with each route instruction in response. (optional)  (default to "false")
            var useCvr = useCvr_example;  // string | This parameter will enable/disable CVR (Commercial Vehicle Restrictions) capability in our APIs. (optional)  (default to "N")
            var looseningBarrierRestrictions = looseningBarrierRestrictions_example;  // string | Specifies that barriers will be removed when determining the route. (optional)  (default to "Y")
            var vehicleType = vehicleType_example;  // string | vehicle type. (optional)  (default to "ALL")
            var weight = weight_example;  // string | Specifies the maximum weight of a vehicle. Any vehicles over this value will be restricted when determining the route. (optional)  (default to "")
            var weightUnit = weightUnit_example;  // string | The unit of weight eg. kg(kilogram), lb(pound), mt(metric ton), t(ton). (optional)  (default to "kg")
            var height = height_example;  // string | Specifies the maximum height of a vehicle. Any vehicles over this value will be restricted when determining the route. (optional)  (default to "")
            var heightUnit = heightUnit_example;  // string | The unit of height e.g m(meter), km(kilometer), yd(yard), ft(foot), mi(mile). (optional)  (default to "ft")
            var length = length_example;  // string | Specifies the maximum length of a vehicle. Any vehicles over this value will be restricted when determining the route. (optional)  (default to "")
            var lengthUnit = lengthUnit_example;  // string | The unit of length eg. m(meter), km(kilometer), yd(yard), ft(foot), mi(mile). (optional)  (default to "ft")
            var width = width_example;  // string | Specifies the maximum width of a vehicle. Any vehicles over this value will be restricted when determining the route. (optional)  (default to "")
            var widthUnit = widthUnit_example;  // string | The unit of width eg. m(meter), km(kilometer), yd(yard), ft(foot), mi(mile). (optional)  (default to "ft")

            try
            {
                // Gets Route By Address.
                RouteResponse result = apiInstance.GetRouteByAddress(startAddress, endAddress, db, country, intermediateAddresses, returnIntermediatePoints, oip, destinationSrs, optimizeBy, returnDistance, distanceUnit, returnTime, timeUnit, language, directionsStyle, segmentGeometryStyle, primaryNameOnly, majorRoads, historicTrafficTimeBucket, returnDirectionGeometry, useCvr, looseningBarrierRestrictions, vehicleType, weight, weightUnit, height, heightUnit, length, lengthUnit, width, widthUnit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RoutingServiceApi.GetRouteByAddress: " + e.Message );
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
 **startAddress** | **string**| Starting address of the route. | [optional] 
 **endAddress** | **string**| Ending address of the route. | [optional] 
 **db** | **string**| Mode of commute. | [optional] [default to &quot;driving&quot;]
 **country** | **string**| Three digit ISO country code. | [optional] [default to &quot;USA&quot;]
 **intermediateAddresses** | **string**| List of intermediate points of the route. | [optional] 
 **returnIntermediatePoints** | **string**| return intermediate points | [optional] [default to &quot;false&quot;]
 **oip** | **string**| Specifies whether waypoints need to be optimized. | [optional] [default to &quot;false&quot;]
 **destinationSrs** | **string**| Specifies the desired coordinate system of the returned route. | [optional] 
 **optimizeBy** | **string**| Specifies whether the route should be optimized by time or distance. | [optional] [default to &quot;time&quot;]
 **returnDistance** | **string**| Specifies whether distance needs to be part of direction information in response. | [optional] [default to &quot;true&quot;]
 **distanceUnit** | **string**| Return Distance Unit such as ft(Foot), km(Kilometer), mi(Mile), m(Meter) or yd(Yard). | [optional] [default to &quot;m&quot;]
 **returnTime** | **string**| Specifies whether time needs to be part of direction information in response. | [optional] [default to &quot;true&quot;]
 **timeUnit** | **string**| Return time unit such as min(Minute), h(Hour), s(Second) or msec(Millisecond) | [optional] [default to &quot;min&quot;]
 **language** | **string**| Specifies the language of travel directions. | [optional] 
 **directionsStyle** | **string**| Specifies whether route directions text is to be returned in the response and in what detail (Normal or Terse). | [optional] [default to &quot;None&quot;]
 **segmentGeometryStyle** | **string**| Specifies whether the route geometry is to be returned in the response and in what detail (End or All). | [optional] [default to &quot;none&quot;]
 **primaryNameOnly** | **string**| If true then only the primary street name is returned otherwise all the names for a street. | [optional] [default to &quot;false&quot;]
 **majorRoads** | **string**| Whether to include all roads in route calculation or just major roads. | [optional] [default to &quot;false&quot;]
 **historicTrafficTimeBucket** | **string**| Specifies whether routing calculation uses the historic traffic speeds. | [optional] [default to &quot;None&quot;]
 **returnDirectionGeometry** | **string**| Whether to include geometry associated with each route instruction in response. | [optional] [default to &quot;false&quot;]
 **useCvr** | **string**| This parameter will enable/disable CVR (Commercial Vehicle Restrictions) capability in our APIs. | [optional] [default to &quot;N&quot;]
 **looseningBarrierRestrictions** | **string**| Specifies that barriers will be removed when determining the route. | [optional] [default to &quot;Y&quot;]
 **vehicleType** | **string**| vehicle type. | [optional] [default to &quot;ALL&quot;]
 **weight** | **string**| Specifies the maximum weight of a vehicle. Any vehicles over this value will be restricted when determining the route. | [optional] [default to &quot;&quot;]
 **weightUnit** | **string**| The unit of weight eg. kg(kilogram), lb(pound), mt(metric ton), t(ton). | [optional] [default to &quot;kg&quot;]
 **height** | **string**| Specifies the maximum height of a vehicle. Any vehicles over this value will be restricted when determining the route. | [optional] [default to &quot;&quot;]
 **heightUnit** | **string**| The unit of height e.g m(meter), km(kilometer), yd(yard), ft(foot), mi(mile). | [optional] [default to &quot;ft&quot;]
 **length** | **string**| Specifies the maximum length of a vehicle. Any vehicles over this value will be restricted when determining the route. | [optional] [default to &quot;&quot;]
 **lengthUnit** | **string**| The unit of length eg. m(meter), km(kilometer), yd(yard), ft(foot), mi(mile). | [optional] [default to &quot;ft&quot;]
 **width** | **string**| Specifies the maximum width of a vehicle. Any vehicles over this value will be restricted when determining the route. | [optional] [default to &quot;&quot;]
 **widthUnit** | **string**| The unit of width eg. m(meter), km(kilometer), yd(yard), ft(foot), mi(mile). | [optional] [default to &quot;ft&quot;]

### Return type

[**RouteResponse**](RouteResponse.md)

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


## GetRouteByLocation

> RouteResponse GetRouteByLocation (string startPoint = null, string endPoint = null, string db = null, string intermediatePoints = null, string returnIntermediatePoints = null, string oip = null, string destinationSrs = null, string optimizeBy = null, string returnDistance = null, string distanceUnit = null, string returnTime = null, string timeUnit = null, string language = null, string directionsStyle = null, string segmentGeometryStyle = null, string primaryNameOnly = null, string majorRoads = null, string historicTrafficTimeBucket = null, string returnDirectionGeometry = null, string useCvr = null, string looseningBarrierRestrictions = null, string vehicleType = null, string weight = null, string weightUnit = null, string height = null, string heightUnit = null, string length = null, string lengthUnit = null, string width = null, string widthUnit = null)

Gets Route By Location.

Accepts latitude & longitude as input and Returns Point-to-Point and Multi-Point travel directions by various travel modes.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetRouteByLocationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RoutingServiceApi(Configuration.Default);
            var startPoint = startPoint_example;  // string | Start Point in 'Lat,Long,coordsys' format. (optional) 
            var endPoint = endPoint_example;  // string | End Point in 'Lat,Long,coordsys' format. (optional) 
            var db = db_example;  // string | Mode of commute. (optional)  (default to "driving")
            var intermediatePoints = intermediatePoints_example;  // string | List of intermediate points of the route. (optional) 
            var returnIntermediatePoints = returnIntermediatePoints_example;  // string | returnIntermediatePoints route. (optional)  (default to "false")
            var oip = oip_example;  // string | Specifies whether waypoints need to be optimized. (optional)  (default to "false")
            var destinationSrs = destinationSrs_example;  // string | Specifies the desired coordinate system of the returned route. (optional) 
            var optimizeBy = optimizeBy_example;  // string | Specifies whether the route should be optimized by time or distance. (optional)  (default to "time")
            var returnDistance = returnDistance_example;  // string | Specifies whether distance needs to be part of direction information in response. (optional)  (default to "true")
            var distanceUnit = distanceUnit_example;  // string | Return Distance Unit such as ft(Foot), km(Kilometer), mi(Mile), m(Meter) or yd(Yard). (optional)  (default to "m")
            var returnTime = returnTime_example;  // string | Specifies whether time needs to be part of direction information in response. (optional)  (default to "true")
            var timeUnit = timeUnit_example;  // string | Return time unit such as min(Minute), h(Hour), s(Second) or msec(Millisecond) (optional)  (default to "min")
            var language = language_example;  // string | Specifies the language of travel directions. (optional) 
            var directionsStyle = directionsStyle_example;  // string | Specifies whether route directions text is to be returned in the response and in what detail (Normal or Terse). (optional)  (default to "None")
            var segmentGeometryStyle = segmentGeometryStyle_example;  // string | Specifies whether the route geometry is to be returned in the response and in what detail (End or All). (optional)  (default to "none")
            var primaryNameOnly = primaryNameOnly_example;  // string | If true then only the primary street name is returned otherwise all the names for a street. (optional)  (default to "false")
            var majorRoads = majorRoads_example;  // string | Whether to include all roads in route calculation or just major roads. (optional)  (default to "false")
            var historicTrafficTimeBucket = historicTrafficTimeBucket_example;  // string | Specifies whether routing calculation uses the historic traffic speeds. (optional)  (default to "None")
            var returnDirectionGeometry = returnDirectionGeometry_example;  // string | Whether to include geometry associated with each route instruction in response. (optional)  (default to "false")
            var useCvr = useCvr_example;  // string | This parameter will enable/disable CVR (Commercial Vehicle Restrictions) capability in our APIs. (optional)  (default to "N")
            var looseningBarrierRestrictions = looseningBarrierRestrictions_example;  // string | Specifies that barriers will be removed when determining the route. (optional)  (default to "Y")
            var vehicleType = vehicleType_example;  // string | vehicle type. (optional)  (default to "ALL")
            var weight = weight_example;  // string | Specifies the maximum weight of a vehicle. Any vehicles over this value will be restricted when determining the route. (optional)  (default to "")
            var weightUnit = weightUnit_example;  // string | The unit of weight eg. kg(kilogram), lb(pound), mt(metric ton), t(ton). (optional)  (default to "kg")
            var height = height_example;  // string | Specifies the maximum height of a vehicle. Any vehicles over this value will be restricted when determining the route. (optional)  (default to "")
            var heightUnit = heightUnit_example;  // string | The unit of height e.g m(meter), km(kilometer), yd(yard), ft(foot), mi(mile). (optional)  (default to "ft")
            var length = length_example;  // string | Specifies the maximum length of a vehicle. Any vehicles over this value will be restricted when determining the route. (optional)  (default to "")
            var lengthUnit = lengthUnit_example;  // string | The unit of length eg. m(meter), km(kilometer), yd(yard), ft(foot), mi(mile). (optional)  (default to "ft")
            var width = width_example;  // string | Specifies the maximum width of a vehicle. Any vehicles over this value will be restricted when determining the route. (optional)  (default to "")
            var widthUnit = widthUnit_example;  // string | The unit of width eg. m(meter), km(kilometer), yd(yard), ft(foot), mi(mile). (optional)  (default to "ft")

            try
            {
                // Gets Route By Location.
                RouteResponse result = apiInstance.GetRouteByLocation(startPoint, endPoint, db, intermediatePoints, returnIntermediatePoints, oip, destinationSrs, optimizeBy, returnDistance, distanceUnit, returnTime, timeUnit, language, directionsStyle, segmentGeometryStyle, primaryNameOnly, majorRoads, historicTrafficTimeBucket, returnDirectionGeometry, useCvr, looseningBarrierRestrictions, vehicleType, weight, weightUnit, height, heightUnit, length, lengthUnit, width, widthUnit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RoutingServiceApi.GetRouteByLocation: " + e.Message );
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
 **startPoint** | **string**| Start Point in &#39;Lat,Long,coordsys&#39; format. | [optional] 
 **endPoint** | **string**| End Point in &#39;Lat,Long,coordsys&#39; format. | [optional] 
 **db** | **string**| Mode of commute. | [optional] [default to &quot;driving&quot;]
 **intermediatePoints** | **string**| List of intermediate points of the route. | [optional] 
 **returnIntermediatePoints** | **string**| returnIntermediatePoints route. | [optional] [default to &quot;false&quot;]
 **oip** | **string**| Specifies whether waypoints need to be optimized. | [optional] [default to &quot;false&quot;]
 **destinationSrs** | **string**| Specifies the desired coordinate system of the returned route. | [optional] 
 **optimizeBy** | **string**| Specifies whether the route should be optimized by time or distance. | [optional] [default to &quot;time&quot;]
 **returnDistance** | **string**| Specifies whether distance needs to be part of direction information in response. | [optional] [default to &quot;true&quot;]
 **distanceUnit** | **string**| Return Distance Unit such as ft(Foot), km(Kilometer), mi(Mile), m(Meter) or yd(Yard). | [optional] [default to &quot;m&quot;]
 **returnTime** | **string**| Specifies whether time needs to be part of direction information in response. | [optional] [default to &quot;true&quot;]
 **timeUnit** | **string**| Return time unit such as min(Minute), h(Hour), s(Second) or msec(Millisecond) | [optional] [default to &quot;min&quot;]
 **language** | **string**| Specifies the language of travel directions. | [optional] 
 **directionsStyle** | **string**| Specifies whether route directions text is to be returned in the response and in what detail (Normal or Terse). | [optional] [default to &quot;None&quot;]
 **segmentGeometryStyle** | **string**| Specifies whether the route geometry is to be returned in the response and in what detail (End or All). | [optional] [default to &quot;none&quot;]
 **primaryNameOnly** | **string**| If true then only the primary street name is returned otherwise all the names for a street. | [optional] [default to &quot;false&quot;]
 **majorRoads** | **string**| Whether to include all roads in route calculation or just major roads. | [optional] [default to &quot;false&quot;]
 **historicTrafficTimeBucket** | **string**| Specifies whether routing calculation uses the historic traffic speeds. | [optional] [default to &quot;None&quot;]
 **returnDirectionGeometry** | **string**| Whether to include geometry associated with each route instruction in response. | [optional] [default to &quot;false&quot;]
 **useCvr** | **string**| This parameter will enable/disable CVR (Commercial Vehicle Restrictions) capability in our APIs. | [optional] [default to &quot;N&quot;]
 **looseningBarrierRestrictions** | **string**| Specifies that barriers will be removed when determining the route. | [optional] [default to &quot;Y&quot;]
 **vehicleType** | **string**| vehicle type. | [optional] [default to &quot;ALL&quot;]
 **weight** | **string**| Specifies the maximum weight of a vehicle. Any vehicles over this value will be restricted when determining the route. | [optional] [default to &quot;&quot;]
 **weightUnit** | **string**| The unit of weight eg. kg(kilogram), lb(pound), mt(metric ton), t(ton). | [optional] [default to &quot;kg&quot;]
 **height** | **string**| Specifies the maximum height of a vehicle. Any vehicles over this value will be restricted when determining the route. | [optional] [default to &quot;&quot;]
 **heightUnit** | **string**| The unit of height e.g m(meter), km(kilometer), yd(yard), ft(foot), mi(mile). | [optional] [default to &quot;ft&quot;]
 **length** | **string**| Specifies the maximum length of a vehicle. Any vehicles over this value will be restricted when determining the route. | [optional] [default to &quot;&quot;]
 **lengthUnit** | **string**| The unit of length eg. m(meter), km(kilometer), yd(yard), ft(foot), mi(mile). | [optional] [default to &quot;ft&quot;]
 **width** | **string**| Specifies the maximum width of a vehicle. Any vehicles over this value will be restricted when determining the route. | [optional] [default to &quot;&quot;]
 **widthUnit** | **string**| The unit of width eg. m(meter), km(kilometer), yd(yard), ft(foot), mi(mile). | [optional] [default to &quot;ft&quot;]

### Return type

[**RouteResponse**](RouteResponse.md)

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


## GetTravelCostMatrixByAddress

> TravelCostMatrixResponse GetTravelCostMatrixByAddress (string startAddresses = null, string endAddresses = null, string country = null, string db = null, string optimizeBy = null, string returnDistance = null, string destinationSrs = null, string distanceUnit = null, string returnTime = null, string timeUnit = null, string majorRoads = null, string returnOptimalRoutesOnly = null, string historicTrafficTimeBucket = null, string useCvr = null, string looseningBarrierRestrictions = null, string vehicleType = null, string weight = null, string weightUnit = null, string height = null, string heightUnit = null, string length = null, string lengthUnit = null, string width = null, string widthUnit = null)

Get Cost Matrix By Address.

Accepts addresses as input and Returns travel distances and times for multiple origins to multiple destinations by various travel modes.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetTravelCostMatrixByAddressExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RoutingServiceApi(Configuration.Default);
            var startAddresses = startAddresses_example;  // string | Start locations in text based addresses. (optional) 
            var endAddresses = endAddresses_example;  // string | End locations in text based addresses. (optional) 
            var country = country_example;  // string | 3 Digit ISO country code. (optional)  (default to "USA")
            var db = db_example;  // string | Mode of commute. (optional)  (default to "driving")
            var optimizeBy = optimizeBy_example;  // string | Specifies whether routes should be optimized by time or distance. (optional)  (default to "time")
            var returnDistance = returnDistance_example;  // string | Specifies whether distance needs to be returned in response. (optional)  (default to "true")
            var destinationSrs = destinationSrs_example;  // string | Specifies the desired coordinate system of returned routes. (optional) 
            var distanceUnit = distanceUnit_example;  // string | Return Distance Unit such as ft(Foot), km(Kilometer), mi(Mile), m(Meter) or yd(Yard). (optional)  (default to "m")
            var returnTime = returnTime_example;  // string | Specifies whether time needs to be returned in response. (optional)  (default to "true")
            var timeUnit = timeUnit_example;  // string | Return time unit such as min(Minute), h(Hour), s(Second) or msec(Millisecond). (optional)  (default to "min")
            var majorRoads = majorRoads_example;  // string | Whether to include all roads in routes calculation or just major roads. (optional)  (default to "false")
            var returnOptimalRoutesOnly = returnOptimalRoutesOnly_example;  // string | Specifies whether to return only the optimized route for each start and end point combination. (optional)  (default to "true")
            var historicTrafficTimeBucket = historicTrafficTimeBucket_example;  // string | Specifies whether routing calculation uses the historic traffic speeds. (optional)  (default to "None")
            var useCvr = useCvr_example;  // string | This parameter will enable/disable CVR (Commercial Vehicle Restrictions) capability in our APIs. (optional)  (default to "N")
            var looseningBarrierRestrictions = looseningBarrierRestrictions_example;  // string | Specifies that barriers will be removed when determining the route. (optional)  (default to "Y")
            var vehicleType = vehicleType_example;  // string | vehicle type. (optional)  (default to "ALL")
            var weight = weight_example;  // string | Specifies the maximum weight of a vehicle. Any vehicles over this value will be restricted when determining the route. (optional)  (default to "")
            var weightUnit = weightUnit_example;  // string | The unit of weight eg. kg(kilogram), lb(pound), mt(metric ton), t(ton). (optional)  (default to "kg")
            var height = height_example;  // string | Specifies the maximum height of a vehicle. Any vehicles over this value will be restricted when determining the route. (optional)  (default to "")
            var heightUnit = heightUnit_example;  // string | The unit of height e.g m(meter), km(kilometer), yd(yard), ft(foot), mi(mile). (optional)  (default to "ft")
            var length = length_example;  // string | Specifies the maximum length of a vehicle. Any vehicles over this value will be restricted when determining the route. (optional)  (default to "")
            var lengthUnit = lengthUnit_example;  // string | The unit of length eg. m(meter), km(kilometer), yd(yard), ft(foot), mi(mile). (optional)  (default to "ft")
            var width = width_example;  // string | Specifies the maximum width of a vehicle. Any vehicles over this value will be restricted when determining the route. (optional)  (default to "")
            var widthUnit = widthUnit_example;  // string | The unit of width eg. m(meter), km(kilometer), yd(yard), ft(foot), mi(mile). (optional)  (default to "ft")

            try
            {
                // Get Cost Matrix By Address.
                TravelCostMatrixResponse result = apiInstance.GetTravelCostMatrixByAddress(startAddresses, endAddresses, country, db, optimizeBy, returnDistance, destinationSrs, distanceUnit, returnTime, timeUnit, majorRoads, returnOptimalRoutesOnly, historicTrafficTimeBucket, useCvr, looseningBarrierRestrictions, vehicleType, weight, weightUnit, height, heightUnit, length, lengthUnit, width, widthUnit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RoutingServiceApi.GetTravelCostMatrixByAddress: " + e.Message );
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
 **startAddresses** | **string**| Start locations in text based addresses. | [optional] 
 **endAddresses** | **string**| End locations in text based addresses. | [optional] 
 **country** | **string**| 3 Digit ISO country code. | [optional] [default to &quot;USA&quot;]
 **db** | **string**| Mode of commute. | [optional] [default to &quot;driving&quot;]
 **optimizeBy** | **string**| Specifies whether routes should be optimized by time or distance. | [optional] [default to &quot;time&quot;]
 **returnDistance** | **string**| Specifies whether distance needs to be returned in response. | [optional] [default to &quot;true&quot;]
 **destinationSrs** | **string**| Specifies the desired coordinate system of returned routes. | [optional] 
 **distanceUnit** | **string**| Return Distance Unit such as ft(Foot), km(Kilometer), mi(Mile), m(Meter) or yd(Yard). | [optional] [default to &quot;m&quot;]
 **returnTime** | **string**| Specifies whether time needs to be returned in response. | [optional] [default to &quot;true&quot;]
 **timeUnit** | **string**| Return time unit such as min(Minute), h(Hour), s(Second) or msec(Millisecond). | [optional] [default to &quot;min&quot;]
 **majorRoads** | **string**| Whether to include all roads in routes calculation or just major roads. | [optional] [default to &quot;false&quot;]
 **returnOptimalRoutesOnly** | **string**| Specifies whether to return only the optimized route for each start and end point combination. | [optional] [default to &quot;true&quot;]
 **historicTrafficTimeBucket** | **string**| Specifies whether routing calculation uses the historic traffic speeds. | [optional] [default to &quot;None&quot;]
 **useCvr** | **string**| This parameter will enable/disable CVR (Commercial Vehicle Restrictions) capability in our APIs. | [optional] [default to &quot;N&quot;]
 **looseningBarrierRestrictions** | **string**| Specifies that barriers will be removed when determining the route. | [optional] [default to &quot;Y&quot;]
 **vehicleType** | **string**| vehicle type. | [optional] [default to &quot;ALL&quot;]
 **weight** | **string**| Specifies the maximum weight of a vehicle. Any vehicles over this value will be restricted when determining the route. | [optional] [default to &quot;&quot;]
 **weightUnit** | **string**| The unit of weight eg. kg(kilogram), lb(pound), mt(metric ton), t(ton). | [optional] [default to &quot;kg&quot;]
 **height** | **string**| Specifies the maximum height of a vehicle. Any vehicles over this value will be restricted when determining the route. | [optional] [default to &quot;&quot;]
 **heightUnit** | **string**| The unit of height e.g m(meter), km(kilometer), yd(yard), ft(foot), mi(mile). | [optional] [default to &quot;ft&quot;]
 **length** | **string**| Specifies the maximum length of a vehicle. Any vehicles over this value will be restricted when determining the route. | [optional] [default to &quot;&quot;]
 **lengthUnit** | **string**| The unit of length eg. m(meter), km(kilometer), yd(yard), ft(foot), mi(mile). | [optional] [default to &quot;ft&quot;]
 **width** | **string**| Specifies the maximum width of a vehicle. Any vehicles over this value will be restricted when determining the route. | [optional] [default to &quot;&quot;]
 **widthUnit** | **string**| The unit of width eg. m(meter), km(kilometer), yd(yard), ft(foot), mi(mile). | [optional] [default to &quot;ft&quot;]

### Return type

[**TravelCostMatrixResponse**](TravelCostMatrixResponse.md)

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


## GetTravelCostMatrixByLocation

> TravelCostMatrixResponse GetTravelCostMatrixByLocation (string startPoints = null, string endPoints = null, string db = null, string optimizeBy = null, string returnDistance = null, string destinationSrs = null, string distanceUnit = null, string returnTime = null, string timeUnit = null, string majorRoads = null, string returnOptimalRoutesOnly = null, string historicTrafficTimeBucket = null, string useCvr = null, string looseningBarrierRestrictions = null, string vehicleType = null, string weight = null, string weightUnit = null, string height = null, string heightUnit = null, string length = null, string lengthUnit = null, string width = null, string widthUnit = null)

Get Cost Matrix By Location.

Accepts latitude & longitude as input and Returns travel distances and times for multiple origins to multiple destinations by various travel modes.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetTravelCostMatrixByLocationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RoutingServiceApi(Configuration.Default);
            var startPoints = startPoints_example;  // string | The address to be searched. (optional) 
            var endPoints = endPoints_example;  // string | The address to be searched. (optional) 
            var db = db_example;  // string | Mode of commute. (optional)  (default to "driving")
            var optimizeBy = optimizeBy_example;  // string | Specifies whether routes should be optimized by time or distance. (optional)  (default to "time")
            var returnDistance = returnDistance_example;  // string | Specifies whether distance needs to be returned in response. (optional)  (default to "true")
            var destinationSrs = destinationSrs_example;  // string | Specifies the desired coordinate system of returned routes. (optional)  (default to "epsg:4326")
            var distanceUnit = distanceUnit_example;  // string | Return Distance Unit such as ft(Foot), km(Kilometer), mi(Mile), m(Meter) or yd(Yard). (optional)  (default to "m")
            var returnTime = returnTime_example;  // string | Specifies whether time needs to be returned in response. (optional)  (default to "true")
            var timeUnit = timeUnit_example;  // string | Return time unit such as min(Minute), h(Hour), s(Second) or msec(Millisecond). (optional)  (default to "min")
            var majorRoads = majorRoads_example;  // string | Whether to include all roads in routes calculation or just major roads. (optional)  (default to "false")
            var returnOptimalRoutesOnly = returnOptimalRoutesOnly_example;  // string | Specifies whether to return only the optimized route for each start and end point combination. (optional)  (default to "true")
            var historicTrafficTimeBucket = historicTrafficTimeBucket_example;  // string | Specifies whether routing calculation uses the historic traffic speeds. (optional)  (default to "None")
            var useCvr = useCvr_example;  // string | This parameter will enable/disable CVR (Commercial Vehicle Restrictions) capability in our APIs. (optional)  (default to "N")
            var looseningBarrierRestrictions = looseningBarrierRestrictions_example;  // string | Specifies that barriers will be removed when determining the route. (optional)  (default to "Y")
            var vehicleType = vehicleType_example;  // string | vehicle type. (optional)  (default to "ALL")
            var weight = weight_example;  // string | Specifies the maximum weight of a vehicle. Any vehicles over this value will be restricted when determining the route. (optional)  (default to "")
            var weightUnit = weightUnit_example;  // string | The unit of weight eg. kg(kilogram), lb(pound), mt(metric ton), t(ton). (optional)  (default to "kg")
            var height = height_example;  // string | Specifies the maximum height of a vehicle. Any vehicles over this value will be restricted when determining the route. (optional)  (default to "")
            var heightUnit = heightUnit_example;  // string | The unit of height e.g m(meter), km(kilometer), yd(yard), ft(foot), mi(mile). (optional)  (default to "ft")
            var length = length_example;  // string | Specifies the maximum length of a vehicle. Any vehicles over this value will be restricted when determining the route. (optional)  (default to "")
            var lengthUnit = lengthUnit_example;  // string | The unit of length eg. m(meter), km(kilometer), yd(yard), ft(foot), mi(mile). (optional)  (default to "ft")
            var width = width_example;  // string | Specifies the maximum width of a vehicle. Any vehicles over this value will be restricted when determining the route. (optional)  (default to "")
            var widthUnit = widthUnit_example;  // string | The unit of width eg. m(meter), km(kilometer), yd(yard), ft(foot), mi(mile). (optional)  (default to "ft")

            try
            {
                // Get Cost Matrix By Location.
                TravelCostMatrixResponse result = apiInstance.GetTravelCostMatrixByLocation(startPoints, endPoints, db, optimizeBy, returnDistance, destinationSrs, distanceUnit, returnTime, timeUnit, majorRoads, returnOptimalRoutesOnly, historicTrafficTimeBucket, useCvr, looseningBarrierRestrictions, vehicleType, weight, weightUnit, height, heightUnit, length, lengthUnit, width, widthUnit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RoutingServiceApi.GetTravelCostMatrixByLocation: " + e.Message );
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
 **startPoints** | **string**| The address to be searched. | [optional] 
 **endPoints** | **string**| The address to be searched. | [optional] 
 **db** | **string**| Mode of commute. | [optional] [default to &quot;driving&quot;]
 **optimizeBy** | **string**| Specifies whether routes should be optimized by time or distance. | [optional] [default to &quot;time&quot;]
 **returnDistance** | **string**| Specifies whether distance needs to be returned in response. | [optional] [default to &quot;true&quot;]
 **destinationSrs** | **string**| Specifies the desired coordinate system of returned routes. | [optional] [default to &quot;epsg:4326&quot;]
 **distanceUnit** | **string**| Return Distance Unit such as ft(Foot), km(Kilometer), mi(Mile), m(Meter) or yd(Yard). | [optional] [default to &quot;m&quot;]
 **returnTime** | **string**| Specifies whether time needs to be returned in response. | [optional] [default to &quot;true&quot;]
 **timeUnit** | **string**| Return time unit such as min(Minute), h(Hour), s(Second) or msec(Millisecond). | [optional] [default to &quot;min&quot;]
 **majorRoads** | **string**| Whether to include all roads in routes calculation or just major roads. | [optional] [default to &quot;false&quot;]
 **returnOptimalRoutesOnly** | **string**| Specifies whether to return only the optimized route for each start and end point combination. | [optional] [default to &quot;true&quot;]
 **historicTrafficTimeBucket** | **string**| Specifies whether routing calculation uses the historic traffic speeds. | [optional] [default to &quot;None&quot;]
 **useCvr** | **string**| This parameter will enable/disable CVR (Commercial Vehicle Restrictions) capability in our APIs. | [optional] [default to &quot;N&quot;]
 **looseningBarrierRestrictions** | **string**| Specifies that barriers will be removed when determining the route. | [optional] [default to &quot;Y&quot;]
 **vehicleType** | **string**| vehicle type. | [optional] [default to &quot;ALL&quot;]
 **weight** | **string**| Specifies the maximum weight of a vehicle. Any vehicles over this value will be restricted when determining the route. | [optional] [default to &quot;&quot;]
 **weightUnit** | **string**| The unit of weight eg. kg(kilogram), lb(pound), mt(metric ton), t(ton). | [optional] [default to &quot;kg&quot;]
 **height** | **string**| Specifies the maximum height of a vehicle. Any vehicles over this value will be restricted when determining the route. | [optional] [default to &quot;&quot;]
 **heightUnit** | **string**| The unit of height e.g m(meter), km(kilometer), yd(yard), ft(foot), mi(mile). | [optional] [default to &quot;ft&quot;]
 **length** | **string**| Specifies the maximum length of a vehicle. Any vehicles over this value will be restricted when determining the route. | [optional] [default to &quot;&quot;]
 **lengthUnit** | **string**| The unit of length eg. m(meter), km(kilometer), yd(yard), ft(foot), mi(mile). | [optional] [default to &quot;ft&quot;]
 **width** | **string**| Specifies the maximum width of a vehicle. Any vehicles over this value will be restricted when determining the route. | [optional] [default to &quot;&quot;]
 **widthUnit** | **string**| The unit of width eg. m(meter), km(kilometer), yd(yard), ft(foot), mi(mile). | [optional] [default to &quot;ft&quot;]

### Return type

[**TravelCostMatrixResponse**](TravelCostMatrixResponse.md)

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

