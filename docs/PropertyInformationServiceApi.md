# com.precisely.apis.Api.PropertyInformationServiceApi

All URIs are relative to *https://api.precisely.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetParcelBoundaryByAddress**](PropertyInformationServiceApi.md#getparcelboundarybyaddress) | **GET** /property/v1/parcelboundary/byaddress | Get Parcel Boundary By Address
[**GetParcelBoundaryByLocation**](PropertyInformationServiceApi.md#getparcelboundarybylocation) | **GET** /property/v1/parcelboundary/bylocation | Get Parcel Boundary By Location
[**GetPropertyAttributesByAddress**](PropertyInformationServiceApi.md#getpropertyattributesbyaddress) | **GET** /property/v2/attributes/byaddress | PropertyV2 Attributes By Address.
[**GetPropertyAttributesByAddressBatch**](PropertyInformationServiceApi.md#getpropertyattributesbyaddressbatch) | **POST** /property/v2/attributes/byaddress | PropertyV2 Attributes By Address Batch.


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

<a name="getpropertyattributesbyaddress"></a>
# **GetPropertyAttributesByAddress**
> PropertyInfoResponse GetPropertyAttributesByAddress (string address = null, string attributeFilter = null)

PropertyV2 Attributes By Address.

GetPropertyAttributesbyAddress Endpoint will take address as an input and will return key property attributes in response. Optionally user will have the option to filter the attributes and will pay for only returned attributes.

### Example
```csharp
using System;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetPropertyAttributesByAddressExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new PropertyInformationServiceApi();
            var address = address_example;  // string | free form address text (optional) 
            var attributeFilter = attributeFilter_example;  // string | Case-insensitive comma separated values of property attributes. Response will contain only the input attributes. (optional) 

            try
            {
                // PropertyV2 Attributes By Address.
                PropertyInfoResponse result = apiInstance.GetPropertyAttributesByAddress(address, attributeFilter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PropertyInformationServiceApi.GetPropertyAttributesByAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **string**| free form address text | [optional] 
 **attributeFilter** | **string**| Case-insensitive comma separated values of property attributes. Response will contain only the input attributes. | [optional] 

### Return type

[**PropertyInfoResponse**](PropertyInfoResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpropertyattributesbyaddressbatch"></a>
# **GetPropertyAttributesByAddressBatch**
> PropertyInfoResponses GetPropertyAttributesByAddressBatch (PropertyInfoAddressRequest body = null)

PropertyV2 Attributes By Address Batch.

GetPropertyAttributesbyAddressBatch Endpoint will take the list of addresses as an input and will return key property attributes for the given addresses in response. Optionally user will have the option to filter the attributes and will pay for only returned attributes.

### Example
```csharp
using System;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetPropertyAttributesByAddressBatchExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new PropertyInformationServiceApi();
            var body = new PropertyInfoAddressRequest(); // PropertyInfoAddressRequest |  (optional) 

            try
            {
                // PropertyV2 Attributes By Address Batch.
                PropertyInfoResponses result = apiInstance.GetPropertyAttributesByAddressBatch(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PropertyInformationServiceApi.GetPropertyAttributesByAddressBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PropertyInfoAddressRequest**](PropertyInfoAddressRequest.md)|  | [optional] 

### Return type

[**PropertyInfoResponses**](PropertyInfoResponses.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

