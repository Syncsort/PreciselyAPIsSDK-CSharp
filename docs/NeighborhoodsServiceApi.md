# com.precisely.apis.Api.NeighborhoodsServiceApi

All URIs are relative to *https://api.precisely.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetPlaceByLocation**](NeighborhoodsServiceApi.md#getplacebylocation) | **GET** /neighborhoods/v1/place/bylocation | Place By Location.


<a name="getplacebylocation"></a>
# **GetPlaceByLocation**
> PlaceByLocations GetPlaceByLocation (string longitude, string latitude, string levelHint = null)

Place By Location.

Identifies and retrieves the nearest neighborhood around a specific location. This Places service accepts latitude & longitude as input and returns a place name.

### Example
```csharp
using System;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetPlaceByLocationExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new NeighborhoodsServiceApi();
            var longitude = longitude_example;  // string | Longitude of the location.
            var latitude = latitude_example;  // string | Latitude of the location.
            var levelHint = levelHint_example;  // string | Numeric code of geographic hierarchy level which is classified at six levels.Allowed values 1,2,3,4,5,6 (optional) 

            try
            {
                // Place By Location.
                PlaceByLocations result = apiInstance.GetPlaceByLocation(longitude, latitude, levelHint);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NeighborhoodsServiceApi.GetPlaceByLocation: " + e.Message );
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
 **levelHint** | **string**| Numeric code of geographic hierarchy level which is classified at six levels.Allowed values 1,2,3,4,5,6 | [optional] 

### Return type

[**PlaceByLocations**](PlaceByLocations.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

