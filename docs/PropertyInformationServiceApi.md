# com.precisely.apis.Api.PropertyInformationServiceApi

All URIs are relative to *https://api.precisely.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetGeoPropertyByAddress**](PropertyInformationServiceApi.md#getgeopropertybyaddress) | **GET** /property/v1/all/attributes/byaddress | Get Property Attributes By Address
[**GetGeoPropertyByAddressBatch**](PropertyInformationServiceApi.md#getgeopropertybyaddressbatch) | **POST** /property/v1/all/attributes/byaddress | Post Property Attributes By Address
[**GetParcelBoundaryByAddress**](PropertyInformationServiceApi.md#getparcelboundarybyaddress) | **GET** /property/v1/parcelboundary/byaddress | Get Parcel Boundary By Address
[**GetParcelBoundaryByLocation**](PropertyInformationServiceApi.md#getparcelboundarybylocation) | **GET** /property/v1/parcelboundary/bylocation | Get Parcel Boundary By Location


<a name="getgeopropertybyaddress"></a>
# **GetGeoPropertyByAddress**
> GeoPropertyResponse GetGeoPropertyByAddress (string address)

Get Property Attributes By Address

Accepts address as input and returns property attributes for the matched address.

### Example
```csharp
using System;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetGeoPropertyByAddressExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new PropertyInformationServiceApi();
            var address = address_example;  // string | free form address text

            try
            {
                // Get Property Attributes By Address
                GeoPropertyResponse result = apiInstance.GetGeoPropertyByAddress(address);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PropertyInformationServiceApi.GetGeoPropertyByAddress: " + e.Message );
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

[**GeoPropertyResponse**](GeoPropertyResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgeopropertybyaddressbatch"></a>
# **GetGeoPropertyByAddressBatch**
> GeoPropertyResponses GetGeoPropertyByAddressBatch (GeoPropertyAddressRequest body = null)

Post Property Attributes By Address

This is a Batch offering for 'Property Attributes By Address' service. It accepts a single address or a list of addresses and returns property attributes for the matched address.

### Example
```csharp
using System;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetGeoPropertyByAddressBatchExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new PropertyInformationServiceApi();
            var body = new GeoPropertyAddressRequest(); // GeoPropertyAddressRequest |  (optional) 

            try
            {
                // Post Property Attributes By Address
                GeoPropertyResponses result = apiInstance.GetGeoPropertyByAddressBatch(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PropertyInformationServiceApi.GetGeoPropertyByAddressBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GeoPropertyAddressRequest**](GeoPropertyAddressRequest.md)|  | [optional] 

### Return type

[**GeoPropertyResponses**](GeoPropertyResponses.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getparcelboundarybyaddress"></a>
# **GetParcelBoundaryByAddress**
> ParcelBoundary GetParcelBoundaryByAddress (string address, string accept = null)

Get Parcel Boundary By Address

Accepts address as input and returns property parcel boundary around that address.

### Example
```csharp
using System;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetParcelBoundaryByAddressExample
    {
        public void main()
        {
            
            var apiInstance = new PropertyInformationServiceApi();
            var address = address_example;  // string | free form address text
            var accept = accept_example;  // string |  (optional) 

            try
            {
                // Get Parcel Boundary By Address
                ParcelBoundary result = apiInstance.GetParcelBoundaryByAddress(address, accept);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PropertyInformationServiceApi.GetParcelBoundaryByAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **string**| free form address text | 
 **accept** | **string**|  | [optional] 

### Return type

[**ParcelBoundary**](ParcelBoundary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getparcelboundarybylocation"></a>
# **GetParcelBoundaryByLocation**
> ParcelBoundary GetParcelBoundaryByLocation (string longitude, string latitude, string accept = null)

Get Parcel Boundary By Location

Accepts latitude/longitude as input and returns property parcel boundary around that location.

### Example
```csharp
using System;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetParcelBoundaryByLocationExample
    {
        public void main()
        {
            
            var apiInstance = new PropertyInformationServiceApi();
            var longitude = longitude_example;  // string | Longitude of Location
            var latitude = latitude_example;  // string | Latitude of Location
            var accept = accept_example;  // string |  (optional) 

            try
            {
                // Get Parcel Boundary By Location
                ParcelBoundary result = apiInstance.GetParcelBoundaryByLocation(longitude, latitude, accept);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PropertyInformationServiceApi.GetParcelBoundaryByLocation: " + e.Message );
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
 **accept** | **string**|  | [optional] 

### Return type

[**ParcelBoundary**](ParcelBoundary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

