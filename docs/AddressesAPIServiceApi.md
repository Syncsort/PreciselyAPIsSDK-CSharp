# com.precisely.apis.Api.AddressesAPIServiceApi

All URIs are relative to *https://api.precisely.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAddressesByBoundaryName**](AddressesAPIServiceApi.md#getaddressesbyboundaryname) | **GET** /addresses/v1/address/byboundaryname | Addresses By Boundary Area.
[**GetAddressesCountByBoundary**](AddressesAPIServiceApi.md#getaddressescountbyboundary) | **POST** /addresses/v1/addresscount/byboundary | Address Counts by Boundary.
[**GetAddressesCountByBoundaryName**](AddressesAPIServiceApi.md#getaddressescountbyboundaryname) | **GET** /addresses/v1/addresscount/byboundaryname | Address Counts by Boundary Name.
[**GetAddressesbyBoundary**](AddressesAPIServiceApi.md#getaddressesbyboundary) | **POST** /addresses/v1/address/byboundary | Addresses by Boundary.


<a name="getaddressesbyboundaryname"></a>
# **GetAddressesByBoundaryName**
> AddressesResponse GetAddressesByBoundaryName (string country, string areaName1 = null, string areaName2 = null, string areaName3 = null, string areaName4 = null, string postCode = null, string maxCandidates = null, string page = null)

Addresses By Boundary Area.

This service accepts zip code, neighborhood, county, or city names, and returns all known & valid addresses associated with these names.

### Example
```csharp
using System;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetAddressesByBoundaryNameExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new AddressesAPIServiceApi();
            var country = country_example;  // string | Name of country. Acceptable values are CAN, USA.
            var areaName1 = areaName1_example;  // string | Specifies the largest geographical area, typically a state or province. (optional) 
            var areaName2 = areaName2_example;  // string | Specifies the secondary geographic area, typically a county or district. (optional) 
            var areaName3 = areaName3_example;  // string | Specifies a city or town name. (optional) 
            var areaName4 = areaName4_example;  // string | Specifies a city subdivision or locality/neighborhood. (optional) 
            var postCode = postCode_example;  // string | Specifies the postcode (ZIP code) in the appropriate format for the country. (optional) 
            var maxCandidates = maxCandidates_example;  // string | Maximum number of addresses to be returned in response. Max. value is 100 for XML/JSON, and 2000 for CSV. (optional) 
            var page = page_example;  // string | Response will indicate the page number. (optional) 

            try
            {
                // Addresses By Boundary Area.
                AddressesResponse result = apiInstance.GetAddressesByBoundaryName(country, areaName1, areaName2, areaName3, areaName4, postCode, maxCandidates, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddressesAPIServiceApi.GetAddressesByBoundaryName: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **country** | **string**| Name of country. Acceptable values are CAN, USA. | 
 **areaName1** | **string**| Specifies the largest geographical area, typically a state or province. | [optional] 
 **areaName2** | **string**| Specifies the secondary geographic area, typically a county or district. | [optional] 
 **areaName3** | **string**| Specifies a city or town name. | [optional] 
 **areaName4** | **string**| Specifies a city subdivision or locality/neighborhood. | [optional] 
 **postCode** | **string**| Specifies the postcode (ZIP code) in the appropriate format for the country. | [optional] 
 **maxCandidates** | **string**| Maximum number of addresses to be returned in response. Max. value is 100 for XML/JSON, and 2000 for CSV. | [optional] 
 **page** | **string**| Response will indicate the page number. | [optional] 

### Return type

[**AddressesResponse**](AddressesResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaddressescountbyboundary"></a>
# **GetAddressesCountByBoundary**
> AddressesCount GetAddressesCountByBoundary (AddressesByBoundaryRequest body = null)

Address Counts by Boundary.

This service accepts custom geographic boundaries or drivetimes & drive distances, returns the total number of addresses within these boundaries.

### Example
```csharp
using System;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetAddressesCountByBoundaryExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new AddressesAPIServiceApi();
            var body = new AddressesByBoundaryRequest(); // AddressesByBoundaryRequest |  (optional) 

            try
            {
                // Address Counts by Boundary.
                AddressesCount result = apiInstance.GetAddressesCountByBoundary(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddressesAPIServiceApi.GetAddressesCountByBoundary: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AddressesByBoundaryRequest**](AddressesByBoundaryRequest.md)|  | [optional] 

### Return type

[**AddressesCount**](AddressesCount.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaddressescountbyboundaryname"></a>
# **GetAddressesCountByBoundaryName**
> AddressesCount GetAddressesCountByBoundaryName (string country, string areaName1 = null, string areaName2 = null, string areaName3 = null, string areaName4 = null, string postCode = null)

Address Counts by Boundary Name.

This service accepts zip code, neighborhood, county, or city names, and returns the total number of addresses associated with these names. 

### Example
```csharp
using System;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetAddressesCountByBoundaryNameExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new AddressesAPIServiceApi();
            var country = country_example;  // string | Name of country. Acceptable values are CAN, USA.
            var areaName1 = areaName1_example;  // string | Specifies the largest geographical area, typically a state or province. (optional) 
            var areaName2 = areaName2_example;  // string | Specifies the secondary geographic area, typically a county or district. (optional) 
            var areaName3 = areaName3_example;  // string | Specifies a city or town name. (optional) 
            var areaName4 = areaName4_example;  // string | Specifies a city subdivision or locality/neighborhood. (optional) 
            var postCode = postCode_example;  // string | Specifies the postcode (ZIP code) in the appropriate format for the country. (optional) 

            try
            {
                // Address Counts by Boundary Name.
                AddressesCount result = apiInstance.GetAddressesCountByBoundaryName(country, areaName1, areaName2, areaName3, areaName4, postCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddressesAPIServiceApi.GetAddressesCountByBoundaryName: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **country** | **string**| Name of country. Acceptable values are CAN, USA. | 
 **areaName1** | **string**| Specifies the largest geographical area, typically a state or province. | [optional] 
 **areaName2** | **string**| Specifies the secondary geographic area, typically a county or district. | [optional] 
 **areaName3** | **string**| Specifies a city or town name. | [optional] 
 **areaName4** | **string**| Specifies a city subdivision or locality/neighborhood. | [optional] 
 **postCode** | **string**| Specifies the postcode (ZIP code) in the appropriate format for the country. | [optional] 

### Return type

[**AddressesCount**](AddressesCount.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaddressesbyboundary"></a>
# **GetAddressesbyBoundary**
> AddressesResponse GetAddressesbyBoundary (AddressesByBoundaryRequest body = null)

Addresses by Boundary.

This service accepts custom geographic boundaries or drivetimes & drive distances, returns all known & valid addresses within these boundaries.

### Example
```csharp
using System;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetAddressesbyBoundaryExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new AddressesAPIServiceApi();
            var body = new AddressesByBoundaryRequest(); // AddressesByBoundaryRequest |  (optional) 

            try
            {
                // Addresses by Boundary.
                AddressesResponse result = apiInstance.GetAddressesbyBoundary(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddressesAPIServiceApi.GetAddressesbyBoundary: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AddressesByBoundaryRequest**](AddressesByBoundaryRequest.md)|  | [optional] 

### Return type

[**AddressesResponse**](AddressesResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

