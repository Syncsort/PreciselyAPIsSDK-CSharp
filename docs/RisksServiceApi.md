# com.precisely.apis.Api.RisksServiceApi

All URIs are relative to *https://api.precisely.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCrimeRiskByAddress**](RisksServiceApi.md#getcrimeriskbyaddress) | **GET** /risks/v1/crime/byaddress | Get Crime Risk By Address
[**GetCrimeRiskByAddressBatch**](RisksServiceApi.md#getcrimeriskbyaddressbatch) | **POST** /risks/v1/crime/byaddress | Post Crime Risk By Address
[**GetCrimeRiskByLocation**](RisksServiceApi.md#getcrimeriskbylocation) | **GET** /risks/v1/crime/bylocation | Get Crime Risk By Location
[**GetCrimeRiskByLocationBatch**](RisksServiceApi.md#getcrimeriskbylocationbatch) | **POST** /risks/v1/crime/bylocation | Post Crime Risk By Location
[**GetDistanceToFloodHazardByAddress**](RisksServiceApi.md#getdistancetofloodhazardbyaddress) | **GET** /risks/v1/shoreline/distancetofloodhazard/byaddress | Get Distance To Flood Hazard By Address
[**GetDistanceToFloodHazardByAddressBatch**](RisksServiceApi.md#getdistancetofloodhazardbyaddressbatch) | **POST** /risks/v1/shoreline/distancetofloodhazard/byaddress | Post Distance To Flood Hazard By Address
[**GetDistanceToFloodHazardByLocation**](RisksServiceApi.md#getdistancetofloodhazardbylocation) | **GET** /risks/v1/shoreline/distancetofloodhazard/bylocation | Get Distance To Flood Hazard By Location
[**GetDistanceToFloodHazardByLocationBatch**](RisksServiceApi.md#getdistancetofloodhazardbylocationbatch) | **POST** /risks/v1/shoreline/distancetofloodhazard/bylocation | Post Distance To Flood Hazard By Location
[**GetEarthquakeHistory**](RisksServiceApi.md#getearthquakehistory) | **GET** /risks/v1/earthquakehistory | Earthquake History
[**GetEarthquakeRiskByAddress**](RisksServiceApi.md#getearthquakeriskbyaddress) | **GET** /risks/v1/earthquake/byaddress | Get Earthquake Risk By Address
[**GetEarthquakeRiskByAddressBatch**](RisksServiceApi.md#getearthquakeriskbyaddressbatch) | **POST** /risks/v1/earthquake/byaddress | Post Earthquake Risk By Address
[**GetEarthquakeRiskByLocation**](RisksServiceApi.md#getearthquakeriskbylocation) | **GET** /risks/v1/earthquake/bylocation | Get Earthquake Risk By Location
[**GetEarthquakeRiskByLocationBatch**](RisksServiceApi.md#getearthquakeriskbylocationbatch) | **POST** /risks/v1/earthquake/bylocation | Post Earthquake Risk By Location
[**GetFireHistory**](RisksServiceApi.md#getfirehistory) | **GET** /risks/v1/firehistory | Get Fire History
[**GetFireRiskByAddress**](RisksServiceApi.md#getfireriskbyaddress) | **GET** /risks/v1/fire/byaddress | Get Fire Risk By Address
[**GetFireRiskByAddressBatch**](RisksServiceApi.md#getfireriskbyaddressbatch) | **POST** /risks/v1/fire/byaddress | Post Fire Risk By Address
[**GetFireRiskByLocation**](RisksServiceApi.md#getfireriskbylocation) | **GET** /risks/v1/fire/bylocation | Get Fire Risk By Location
[**GetFireRiskByLocationBatch**](RisksServiceApi.md#getfireriskbylocationbatch) | **POST** /risks/v1/fire/bylocation | Post Fire Risk By Location
[**GetFireStationByAddress**](RisksServiceApi.md#getfirestationbyaddress) | **GET** /risks/v1/firestation/byaddress | Fire Station By Address
[**GetFireStationByLocation**](RisksServiceApi.md#getfirestationbylocation) | **GET** /risks/v1/firestation/bylocation | Fire Station By Location
[**GetFloodRiskByAddress**](RisksServiceApi.md#getfloodriskbyaddress) | **GET** /risks/v1/flood/byaddress | Get Flood Risk By Address
[**GetFloodRiskByAddressBatch**](RisksServiceApi.md#getfloodriskbyaddressbatch) | **POST** /risks/v1/flood/byaddress | Post Flood Risk By Address
[**GetFloodRiskByLocation**](RisksServiceApi.md#getfloodriskbylocation) | **GET** /risks/v1/flood/bylocation | Get Flood Risk By Location
[**GetFloodRiskByLocationBatch**](RisksServiceApi.md#getfloodriskbylocationbatch) | **POST** /risks/v1/flood/bylocation | Post Flood Risk By Location


<a name="getcrimeriskbyaddress"></a>
# **GetCrimeRiskByAddress**
> CrimeRiskResponse GetCrimeRiskByAddress (string address, string type = null, string includeGeometry = null)

Get Crime Risk By Address

Accepts addresses as input and Returns local crime indexes.

### Example
```csharp
using System;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetCrimeRiskByAddressExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new RisksServiceApi();
            var address = address_example;  // string | Free-form address text.
            var type = type_example;  // string | Type of crime like violent crime, property crime, etc., multiple crime type indexes could be requested as comma separated values with 'all' as default.) (optional) 
            var includeGeometry = includeGeometry_example;  // string | Y or N (default is N) - if it is Y, then geometry will be part of response (optional) 

            try
            {
                // Get Crime Risk By Address
                CrimeRiskResponse result = apiInstance.GetCrimeRiskByAddress(address, type, includeGeometry);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksServiceApi.GetCrimeRiskByAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **string**| Free-form address text. | 
 **type** | **string**| Type of crime like violent crime, property crime, etc., multiple crime type indexes could be requested as comma separated values with &#39;all&#39; as default.) | [optional] 
 **includeGeometry** | **string**| Y or N (default is N) - if it is Y, then geometry will be part of response | [optional] 

### Return type

[**CrimeRiskResponse**](CrimeRiskResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcrimeriskbyaddressbatch"></a>
# **GetCrimeRiskByAddressBatch**
> CrimeRiskResponseList GetCrimeRiskByAddressBatch (CrimeRiskByAddressRequest body = null)

Post Crime Risk By Address

This is a Batch offering for 'Crime Risk By Address' service. It accepts a single address or a list of addresses and retrieve local crime indexes.

### Example
```csharp
using System;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetCrimeRiskByAddressBatchExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new RisksServiceApi();
            var body = new CrimeRiskByAddressRequest(); // CrimeRiskByAddressRequest |  (optional) 

            try
            {
                // Post Crime Risk By Address
                CrimeRiskResponseList result = apiInstance.GetCrimeRiskByAddressBatch(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksServiceApi.GetCrimeRiskByAddressBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CrimeRiskByAddressRequest**](CrimeRiskByAddressRequest.md)|  | [optional] 

### Return type

[**CrimeRiskResponseList**](CrimeRiskResponseList.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcrimeriskbylocation"></a>
# **GetCrimeRiskByLocation**
> CrimeRiskLocationResponse GetCrimeRiskByLocation (string longitude, string latitude, string type = null, string includeGeometry = null)

Get Crime Risk By Location

Returns the crime data or crime indexes for a given location.

### Example
```csharp
using System;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetCrimeRiskByLocationExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new RisksServiceApi();
            var longitude = longitude_example;  // string | The longitude of the location
            var latitude = latitude_example;  // string | The latitude of the location
            var type = type_example;  // string | Refers to crime type. Valid values are following 11 crime types with 'all' as default (more than one can also be given as comma separated types) (optional) 
            var includeGeometry = includeGeometry_example;  // string | Y or N (default is N) - if it is Y, then geometry will be part of response (optional) 

            try
            {
                // Get Crime Risk By Location
                CrimeRiskLocationResponse result = apiInstance.GetCrimeRiskByLocation(longitude, latitude, type, includeGeometry);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksServiceApi.GetCrimeRiskByLocation: " + e.Message );
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
 **type** | **string**| Refers to crime type. Valid values are following 11 crime types with &#39;all&#39; as default (more than one can also be given as comma separated types) | [optional] 
 **includeGeometry** | **string**| Y or N (default is N) - if it is Y, then geometry will be part of response | [optional] 

### Return type

[**CrimeRiskLocationResponse**](CrimeRiskLocationResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcrimeriskbylocationbatch"></a>
# **GetCrimeRiskByLocationBatch**
> CrimeRiskLocationResponseList GetCrimeRiskByLocationBatch (CrimeRiskByLocationRequest body = null)

Post Crime Risk By Location

This is a Batch offering for 'Crime Risk By Location' service. It accepts a single location coordinate or a list of location coordinates and retrieve local crime indexes.

### Example
```csharp
using System;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetCrimeRiskByLocationBatchExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new RisksServiceApi();
            var body = new CrimeRiskByLocationRequest(); // CrimeRiskByLocationRequest |  (optional) 

            try
            {
                // Post Crime Risk By Location
                CrimeRiskLocationResponseList result = apiInstance.GetCrimeRiskByLocationBatch(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksServiceApi.GetCrimeRiskByLocationBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CrimeRiskByLocationRequest**](CrimeRiskByLocationRequest.md)|  | [optional] 

### Return type

[**CrimeRiskLocationResponseList**](CrimeRiskLocationResponseList.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdistancetofloodhazardbyaddress"></a>
# **GetDistanceToFloodHazardByAddress**
> WaterBodyResponse GetDistanceToFloodHazardByAddress (string address, string maxCandidates = null, string waterBodyType = null, string searchDistance = null, string searchDistanceUnit = null)

Get Distance To Flood Hazard By Address

Accepts addresses as input and Returns the distance from nearest water bodies along with body name and location.

### Example
```csharp
using System;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetDistanceToFloodHazardByAddressExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new RisksServiceApi();
            var address = address_example;  // string | The address of the location
            var maxCandidates = maxCandidates_example;  // string | This specifies the value of maxCandidates (optional) 
            var waterBodyType = waterBodyType_example;  // string | all (default value), oceanandsea,lake,others,unknown,intermittent (optional) 
            var searchDistance = searchDistance_example;  // string | This specifies the search distance (optional) 
            var searchDistanceUnit = searchDistanceUnit_example;  // string | miles (default value),feet, kilometers, meters (optional) 

            try
            {
                // Get Distance To Flood Hazard By Address
                WaterBodyResponse result = apiInstance.GetDistanceToFloodHazardByAddress(address, maxCandidates, waterBodyType, searchDistance, searchDistanceUnit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksServiceApi.GetDistanceToFloodHazardByAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **string**| The address of the location | 
 **maxCandidates** | **string**| This specifies the value of maxCandidates | [optional] 
 **waterBodyType** | **string**| all (default value), oceanandsea,lake,others,unknown,intermittent | [optional] 
 **searchDistance** | **string**| This specifies the search distance | [optional] 
 **searchDistanceUnit** | **string**| miles (default value),feet, kilometers, meters | [optional] 

### Return type

[**WaterBodyResponse**](WaterBodyResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdistancetofloodhazardbyaddressbatch"></a>
# **GetDistanceToFloodHazardByAddressBatch**
> DistanceToFloodHazardResponse GetDistanceToFloodHazardByAddressBatch (DistanceToFloodHazardAddressRequest body = null)

Post Distance To Flood Hazard By Address

This is a Batch offering for 'Distance To Flood Hazard By Address' service. It accepts a single address or a list of addresses and retrieve the distance from nearest water bodies along with body name and location.

### Example
```csharp
using System;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetDistanceToFloodHazardByAddressBatchExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new RisksServiceApi();
            var body = new DistanceToFloodHazardAddressRequest(); // DistanceToFloodHazardAddressRequest |  (optional) 

            try
            {
                // Post Distance To Flood Hazard By Address
                DistanceToFloodHazardResponse result = apiInstance.GetDistanceToFloodHazardByAddressBatch(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksServiceApi.GetDistanceToFloodHazardByAddressBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DistanceToFloodHazardAddressRequest**](DistanceToFloodHazardAddressRequest.md)|  | [optional] 

### Return type

[**DistanceToFloodHazardResponse**](DistanceToFloodHazardResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdistancetofloodhazardbylocation"></a>
# **GetDistanceToFloodHazardByLocation**
> WaterBodyLocationResponse GetDistanceToFloodHazardByLocation (string longitude, string latitude, string maxCandidates = null, string waterBodyType = null, string searchDistance = null, string searchDistanceUnit = null)

Get Distance To Flood Hazard By Location

Accepts latitude & longitude as input and Returns the distance from nearest water bodies along with body name and location.

### Example
```csharp
using System;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetDistanceToFloodHazardByLocationExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new RisksServiceApi();
            var longitude = longitude_example;  // string | The longitude of the location
            var latitude = latitude_example;  // string | The latitude of the location
            var maxCandidates = maxCandidates_example;  // string | This specifies the value of maxCandidates (optional) 
            var waterBodyType = waterBodyType_example;  // string | all (default value), oceanandsea,lake,others,unknown,intermittent (optional) 
            var searchDistance = searchDistance_example;  // string | This specifies the search distance (optional) 
            var searchDistanceUnit = searchDistanceUnit_example;  // string | miles (default value),feet, kilometers, meters (optional) 

            try
            {
                // Get Distance To Flood Hazard By Location
                WaterBodyLocationResponse result = apiInstance.GetDistanceToFloodHazardByLocation(longitude, latitude, maxCandidates, waterBodyType, searchDistance, searchDistanceUnit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksServiceApi.GetDistanceToFloodHazardByLocation: " + e.Message );
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
 **maxCandidates** | **string**| This specifies the value of maxCandidates | [optional] 
 **waterBodyType** | **string**| all (default value), oceanandsea,lake,others,unknown,intermittent | [optional] 
 **searchDistance** | **string**| This specifies the search distance | [optional] 
 **searchDistanceUnit** | **string**| miles (default value),feet, kilometers, meters | [optional] 

### Return type

[**WaterBodyLocationResponse**](WaterBodyLocationResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdistancetofloodhazardbylocationbatch"></a>
# **GetDistanceToFloodHazardByLocationBatch**
> DistanceToFloodHazardLocationResponse GetDistanceToFloodHazardByLocationBatch (DistanceToFloodHazardLocationRequest body = null)

Post Distance To Flood Hazard By Location

This is a Batch offering for 'Distance To Flood Hazard By Location' service. It accepts a single location coordinate or a list of location coordinates and retrieve the distance from nearest water bodies along with body name and location.

### Example
```csharp
using System;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetDistanceToFloodHazardByLocationBatchExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new RisksServiceApi();
            var body = new DistanceToFloodHazardLocationRequest(); // DistanceToFloodHazardLocationRequest |  (optional) 

            try
            {
                // Post Distance To Flood Hazard By Location
                DistanceToFloodHazardLocationResponse result = apiInstance.GetDistanceToFloodHazardByLocationBatch(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksServiceApi.GetDistanceToFloodHazardByLocationBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DistanceToFloodHazardLocationRequest**](DistanceToFloodHazardLocationRequest.md)|  | [optional] 

### Return type

[**DistanceToFloodHazardLocationResponse**](DistanceToFloodHazardLocationResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getearthquakehistory"></a>
# **GetEarthquakeHistory**
> EarthquakeHistory GetEarthquakeHistory (string postCode, string startDate = null, string endDate = null, string minMagnitude = null, string maxMagnitude = null, string maxCandidates = null)

Earthquake History

Accepts postcode as input and Returns historical earthquake details for a particular postcode.

### Example
```csharp
using System;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetEarthquakeHistoryExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new RisksServiceApi();
            var postCode = postCode_example;  // string | 5 digit Postal code to search
            var startDate = startDate_example;  // string | Start time in milliseconds(UTC) (optional) 
            var endDate = endDate_example;  // string | End time in milliseconds(UTC) (optional) 
            var minMagnitude = minMagnitude_example;  // string | Minimum richter scale magnitude (optional) 
            var maxMagnitude = maxMagnitude_example;  // string | Maximum Richter scale magnitude (optional) 
            var maxCandidates = maxCandidates_example;  // string | Maximum response events (optional)  (default to 1)

            try
            {
                // Earthquake History
                EarthquakeHistory result = apiInstance.GetEarthquakeHistory(postCode, startDate, endDate, minMagnitude, maxMagnitude, maxCandidates);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksServiceApi.GetEarthquakeHistory: " + e.Message );
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
 **maxCandidates** | **string**| Maximum response events | [optional] [default to 1]

### Return type

[**EarthquakeHistory**](EarthquakeHistory.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getearthquakeriskbyaddress"></a>
# **GetEarthquakeRiskByAddress**
> EarthquakeRiskResponse GetEarthquakeRiskByAddress (string address, string richterValue = null, string includeGeometry = null)

Get Earthquake Risk By Address

Accepts addresses as input and Returns counts of earthquakes for various richter measurements and values.

### Example
```csharp
using System;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetEarthquakeRiskByAddressExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new RisksServiceApi();
            var address = address_example;  // string | Free-form address text
            var richterValue = richterValue_example;  // string | Richter values like R5 (count of richter scale 5 events), R7 (count of richter scale 7 events), R6_GE (count of events >= richter scale 6), etc., multiple richter scales could be requested as comma separated values with 'all' as default. Valid values: All (default value), R0, R1, R2, R3, R4, R5, R6, R7, R0_GE, R1_GE, R2_GE, R3_GE, R4_GE, R5_GE, R6_GE, R7_GE (optional) 
            var includeGeometry = includeGeometry_example;  // string | Y or N (default is N) - if it is Y, then geometry will be part of response (optional) 

            try
            {
                // Get Earthquake Risk By Address
                EarthquakeRiskResponse result = apiInstance.GetEarthquakeRiskByAddress(address, richterValue, includeGeometry);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksServiceApi.GetEarthquakeRiskByAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **string**| Free-form address text | 
 **richterValue** | **string**| Richter values like R5 (count of richter scale 5 events), R7 (count of richter scale 7 events), R6_GE (count of events &gt;&#x3D; richter scale 6), etc., multiple richter scales could be requested as comma separated values with &#39;all&#39; as default. Valid values: All (default value), R0, R1, R2, R3, R4, R5, R6, R7, R0_GE, R1_GE, R2_GE, R3_GE, R4_GE, R5_GE, R6_GE, R7_GE | [optional] 
 **includeGeometry** | **string**| Y or N (default is N) - if it is Y, then geometry will be part of response | [optional] 

### Return type

[**EarthquakeRiskResponse**](EarthquakeRiskResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getearthquakeriskbyaddressbatch"></a>
# **GetEarthquakeRiskByAddressBatch**
> EarthquakeRiskResponseList GetEarthquakeRiskByAddressBatch (EarthquakeRiskByAddressRequest body = null)

Post Earthquake Risk By Address

This is a Batch offering for 'Earthquake Risk By Address' service. It accepts a single address or a list of addresses and retrieve counts of earthquakes for various richter measurements and values.

### Example
```csharp
using System;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetEarthquakeRiskByAddressBatchExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new RisksServiceApi();
            var body = new EarthquakeRiskByAddressRequest(); // EarthquakeRiskByAddressRequest |  (optional) 

            try
            {
                // Post Earthquake Risk By Address
                EarthquakeRiskResponseList result = apiInstance.GetEarthquakeRiskByAddressBatch(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksServiceApi.GetEarthquakeRiskByAddressBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EarthquakeRiskByAddressRequest**](EarthquakeRiskByAddressRequest.md)|  | [optional] 

### Return type

[**EarthquakeRiskResponseList**](EarthquakeRiskResponseList.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getearthquakeriskbylocation"></a>
# **GetEarthquakeRiskByLocation**
> EarthquakeRiskLocationResponse GetEarthquakeRiskByLocation (string longitude, string latitude, string richterValue = null, string includeGeometry = null)

Get Earthquake Risk By Location

Accepts latitude & longitude as input and Returns counts of earthquakes for various richter measurements and values.

### Example
```csharp
using System;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetEarthquakeRiskByLocationExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new RisksServiceApi();
            var longitude = longitude_example;  // string | The longitude of the location
            var latitude = latitude_example;  // string | The latitude of the location
            var richterValue = richterValue_example;  // string | Richter values like R5 (count of richter scale 5 events), R7 (count of richter scale 7 events), R6_GE (count of events >= richter scale 6), etc., multiple richter scales could be requested as comma separated values with 'all' as default. Valid values: All (default value), R0, R1, R2, R3, R4, R5, R6, R7, R0_GE, R1_GE, R2_GE, R3_GE, R4_GE, R5_GE, R6_GE, R7_GE (optional) 
            var includeGeometry = includeGeometry_example;  // string | Y or N (default is N) - if it is Y, then geometry will be part of response (optional) 

            try
            {
                // Get Earthquake Risk By Location
                EarthquakeRiskLocationResponse result = apiInstance.GetEarthquakeRiskByLocation(longitude, latitude, richterValue, includeGeometry);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksServiceApi.GetEarthquakeRiskByLocation: " + e.Message );
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
 **richterValue** | **string**| Richter values like R5 (count of richter scale 5 events), R7 (count of richter scale 7 events), R6_GE (count of events &gt;&#x3D; richter scale 6), etc., multiple richter scales could be requested as comma separated values with &#39;all&#39; as default. Valid values: All (default value), R0, R1, R2, R3, R4, R5, R6, R7, R0_GE, R1_GE, R2_GE, R3_GE, R4_GE, R5_GE, R6_GE, R7_GE | [optional] 
 **includeGeometry** | **string**| Y or N (default is N) - if it is Y, then geometry will be part of response | [optional] 

### Return type

[**EarthquakeRiskLocationResponse**](EarthquakeRiskLocationResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getearthquakeriskbylocationbatch"></a>
# **GetEarthquakeRiskByLocationBatch**
> EarthquakeRiskLocationResponseList GetEarthquakeRiskByLocationBatch (EarthquakeRiskByLocationRequest body = null)

Post Earthquake Risk By Location

This is a Batch offering for 'Earthquake Risk By Location' service. It accepts a single location coordinate or a list of location coordinates and retrieve counts of earthquakes for various richter measurements and values.

### Example
```csharp
using System;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetEarthquakeRiskByLocationBatchExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new RisksServiceApi();
            var body = new EarthquakeRiskByLocationRequest(); // EarthquakeRiskByLocationRequest |  (optional) 

            try
            {
                // Post Earthquake Risk By Location
                EarthquakeRiskLocationResponseList result = apiInstance.GetEarthquakeRiskByLocationBatch(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksServiceApi.GetEarthquakeRiskByLocationBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EarthquakeRiskByLocationRequest**](EarthquakeRiskByLocationRequest.md)|  | [optional] 

### Return type

[**EarthquakeRiskLocationResponseList**](EarthquakeRiskLocationResponseList.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfirehistory"></a>
# **GetFireHistory**
> FireHistory GetFireHistory (string postCode, string startDate = null, string endDate = null, string maxCandidates = null)

Get Fire History

Accepts postcode as input and Returns fire event details for a particular postcode.

### Example
```csharp
using System;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetFireHistoryExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new RisksServiceApi();
            var postCode = postCode_example;  // string | 5 digit Postal code to search
            var startDate = startDate_example;  // string | Start time in milliseconds(UTC) (optional) 
            var endDate = endDate_example;  // string | End time in milliseconds(UTC) (optional) 
            var maxCandidates = maxCandidates_example;  // string | Maximum response events (optional)  (default to 1)

            try
            {
                // Get Fire History
                FireHistory result = apiInstance.GetFireHistory(postCode, startDate, endDate, maxCandidates);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksServiceApi.GetFireHistory: " + e.Message );
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
 **maxCandidates** | **string**| Maximum response events | [optional] [default to 1]

### Return type

[**FireHistory**](FireHistory.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfireriskbyaddress"></a>
# **GetFireRiskByAddress**
> FireRiskResponse GetFireRiskByAddress (string address)

Get Fire Risk By Address

Accepts addresses as input and Returns fire risk data by risk types.

### Example
```csharp
using System;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetFireRiskByAddressExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new RisksServiceApi();
            var address = address_example;  // string | Free-form address text

            try
            {
                // Get Fire Risk By Address
                FireRiskResponse result = apiInstance.GetFireRiskByAddress(address);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksServiceApi.GetFireRiskByAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **string**| Free-form address text | 

### Return type

[**FireRiskResponse**](FireRiskResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfireriskbyaddressbatch"></a>
# **GetFireRiskByAddressBatch**
> FireRiskResponseList GetFireRiskByAddressBatch (FireRiskByAddressRequest body = null)

Post Fire Risk By Address

This is a Batch offering for 'Fire Risk By Address' service. It accepts a single address or a list of addresses and retrieve fire risk data by risk types.

### Example
```csharp
using System;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetFireRiskByAddressBatchExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new RisksServiceApi();
            var body = new FireRiskByAddressRequest(); // FireRiskByAddressRequest |  (optional) 

            try
            {
                // Post Fire Risk By Address
                FireRiskResponseList result = apiInstance.GetFireRiskByAddressBatch(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksServiceApi.GetFireRiskByAddressBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**FireRiskByAddressRequest**](FireRiskByAddressRequest.md)|  | [optional] 

### Return type

[**FireRiskResponseList**](FireRiskResponseList.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfireriskbylocation"></a>
# **GetFireRiskByLocation**
> FireRiskLocationResponse GetFireRiskByLocation (string longitude, string latitude)

Get Fire Risk By Location

Accepts latitude & longitude as input and Returns fire risk data by risk types.

### Example
```csharp
using System;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetFireRiskByLocationExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new RisksServiceApi();
            var longitude = longitude_example;  // string | Longitude of Location
            var latitude = latitude_example;  // string | Latitude of Location

            try
            {
                // Get Fire Risk By Location
                FireRiskLocationResponse result = apiInstance.GetFireRiskByLocation(longitude, latitude);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksServiceApi.GetFireRiskByLocation: " + e.Message );
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

### Return type

[**FireRiskLocationResponse**](FireRiskLocationResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfireriskbylocationbatch"></a>
# **GetFireRiskByLocationBatch**
> FireRiskLocationResponseList GetFireRiskByLocationBatch (FireRiskByLocationRequest body = null)

Post Fire Risk By Location

This is a Batch offering for 'Fire Risk By Location' service. It accepts a single location coordinate or a list of location coordinates and retrieve fire risk data by risk types.

### Example
```csharp
using System;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetFireRiskByLocationBatchExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new RisksServiceApi();
            var body = new FireRiskByLocationRequest(); // FireRiskByLocationRequest |  (optional) 

            try
            {
                // Post Fire Risk By Location
                FireRiskLocationResponseList result = apiInstance.GetFireRiskByLocationBatch(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksServiceApi.GetFireRiskByLocationBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**FireRiskByLocationRequest**](FireRiskByLocationRequest.md)|  | [optional] 

### Return type

[**FireRiskLocationResponseList**](FireRiskLocationResponseList.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfirestationbyaddress"></a>
# **GetFireStationByAddress**
> FireStations GetFireStationByAddress (string address, string maxCandidates = null, string travelTime = null, string travelTimeUnit = null, string travelDistance = null, string travelDistanceUnit = null, string sortBy = null, string historicTrafficTimeBucket = null)

Fire Station By Address

Accepts addresses as input and Returns nearest fire stations.

### Example
```csharp
using System;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetFireStationByAddressExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new RisksServiceApi();
            var address = address_example;  // string | The address to be searched.
            var maxCandidates = maxCandidates_example;  // string | Specifies the maximum number of fire stations that this service retrieves. The default value is 3 and maximum value is 5. The retrieved results are traveldistance sorted from the input location. (optional) 
            var travelTime = travelTime_example;  // string | Max travel time from input location to fire station. Maximum allowed is 2 hours (optional) 
            var travelTimeUnit = travelTimeUnit_example;  // string | Travel time unit such as minutes (default), hours, seconds or milliseconds. (optional) 
            var travelDistance = travelDistance_example;  // string | Maximum travel distance from input location to fire station. Maximum allowed is 50 miles (optional) 
            var travelDistanceUnit = travelDistanceUnit_example;  // string | Travel distance unit such as Feet (default), Kilometers, Miles or Meters. (optional) 
            var sortBy = sortBy_example;  // string | Sort the fire stations results by either travel time or travel distance (nearest first). Default sorting is by travel time. (optional) 
            var historicTrafficTimeBucket = historicTrafficTimeBucket_example;  // string | Historic traffic time slab (optional) 

            try
            {
                // Fire Station By Address
                FireStations result = apiInstance.GetFireStationByAddress(address, maxCandidates, travelTime, travelTimeUnit, travelDistance, travelDistanceUnit, sortBy, historicTrafficTimeBucket);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksServiceApi.GetFireStationByAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **string**| The address to be searched. | 
 **maxCandidates** | **string**| Specifies the maximum number of fire stations that this service retrieves. The default value is 3 and maximum value is 5. The retrieved results are traveldistance sorted from the input location. | [optional] 
 **travelTime** | **string**| Max travel time from input location to fire station. Maximum allowed is 2 hours | [optional] 
 **travelTimeUnit** | **string**| Travel time unit such as minutes (default), hours, seconds or milliseconds. | [optional] 
 **travelDistance** | **string**| Maximum travel distance from input location to fire station. Maximum allowed is 50 miles | [optional] 
 **travelDistanceUnit** | **string**| Travel distance unit such as Feet (default), Kilometers, Miles or Meters. | [optional] 
 **sortBy** | **string**| Sort the fire stations results by either travel time or travel distance (nearest first). Default sorting is by travel time. | [optional] 
 **historicTrafficTimeBucket** | **string**| Historic traffic time slab | [optional] 

### Return type

[**FireStations**](FireStations.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfirestationbylocation"></a>
# **GetFireStationByLocation**
> FireStationsLocation GetFireStationByLocation (string longitude, string latitude, string maxCandidates = null, string travelTime = null, string travelTimeUnit = null, string travelDistance = null, string travelDistanceUnit = null, string sortBy = null, string historicTrafficTimeBucket = null)

Fire Station By Location

Accepts latitude & longitude as input and Returns nearest fire stations.

### Example
```csharp
using System;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetFireStationByLocationExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new RisksServiceApi();
            var longitude = longitude_example;  // string | Longitude of Location
            var latitude = latitude_example;  // string | Latitude of Location
            var maxCandidates = maxCandidates_example;  // string | Specifies the maximum number of fire stations that this service retrieves. The default value is 3. The retrieved fire stations are distance ordered from the specified location. Maximum of 5 fire stations can be retrieved. (optional) 
            var travelTime = travelTime_example;  // string | Maximum travel time from input location to fire station. Maximum allowed is 2 hours (optional) 
            var travelTimeUnit = travelTimeUnit_example;  // string | Travel time unit such as minutes (default), hours, seconds or milliseconds. (optional) 
            var travelDistance = travelDistance_example;  // string | Maximum travel distance from input location to fire station. Maximum allowed is 50 miles (optional) 
            var travelDistanceUnit = travelDistanceUnit_example;  // string | Travel distance unit such as Feet (default), Kilometers, Miles or Meters. (optional) 
            var sortBy = sortBy_example;  // string | Sorting of fire stations in result by travel time/distance (nearest first from input location). (optional) 
            var historicTrafficTimeBucket = historicTrafficTimeBucket_example;  // string | Historic traffic time slab (optional) 

            try
            {
                // Fire Station By Location
                FireStationsLocation result = apiInstance.GetFireStationByLocation(longitude, latitude, maxCandidates, travelTime, travelTimeUnit, travelDistance, travelDistanceUnit, sortBy, historicTrafficTimeBucket);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksServiceApi.GetFireStationByLocation: " + e.Message );
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
 **maxCandidates** | **string**| Specifies the maximum number of fire stations that this service retrieves. The default value is 3. The retrieved fire stations are distance ordered from the specified location. Maximum of 5 fire stations can be retrieved. | [optional] 
 **travelTime** | **string**| Maximum travel time from input location to fire station. Maximum allowed is 2 hours | [optional] 
 **travelTimeUnit** | **string**| Travel time unit such as minutes (default), hours, seconds or milliseconds. | [optional] 
 **travelDistance** | **string**| Maximum travel distance from input location to fire station. Maximum allowed is 50 miles | [optional] 
 **travelDistanceUnit** | **string**| Travel distance unit such as Feet (default), Kilometers, Miles or Meters. | [optional] 
 **sortBy** | **string**| Sorting of fire stations in result by travel time/distance (nearest first from input location). | [optional] 
 **historicTrafficTimeBucket** | **string**| Historic traffic time slab | [optional] 

### Return type

[**FireStationsLocation**](FireStationsLocation.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfloodriskbyaddress"></a>
# **GetFloodRiskByAddress**
> FloodRiskResponse GetFloodRiskByAddress (string address, string includeZoneDesc = null, string includeGeometry = null)

Get Flood Risk By Address

Accepts addresses as input and Returns flood risk data for flood zones and base flood elevation values.

### Example
```csharp
using System;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetFloodRiskByAddressExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new RisksServiceApi();
            var address = address_example;  // string | Free-text Address
            var includeZoneDesc = includeZoneDesc_example;  // string | Specifies primary zone description. Valid Values: 'Y' or 'N'. (optional) 
            var includeGeometry = includeGeometry_example;  // string | Y or N (default is N) - if it is Y, then geometry will be part of response (optional) 

            try
            {
                // Get Flood Risk By Address
                FloodRiskResponse result = apiInstance.GetFloodRiskByAddress(address, includeZoneDesc, includeGeometry);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksServiceApi.GetFloodRiskByAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **string**| Free-text Address | 
 **includeZoneDesc** | **string**| Specifies primary zone description. Valid Values: &#39;Y&#39; or &#39;N&#39;. | [optional] 
 **includeGeometry** | **string**| Y or N (default is N) - if it is Y, then geometry will be part of response | [optional] 

### Return type

[**FloodRiskResponse**](FloodRiskResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfloodriskbyaddressbatch"></a>
# **GetFloodRiskByAddressBatch**
> FloodRiskResponseList GetFloodRiskByAddressBatch (FloodRiskByAddressRequest body = null)

Post Flood Risk By Address

This is a Batch offering for 'Flood Risk By Address' service. It accepts a single address or a list of addresses and retrieve flood risk data for flood zones and base flood elevation values.

### Example
```csharp
using System;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetFloodRiskByAddressBatchExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new RisksServiceApi();
            var body = new FloodRiskByAddressRequest(); // FloodRiskByAddressRequest |  (optional) 

            try
            {
                // Post Flood Risk By Address
                FloodRiskResponseList result = apiInstance.GetFloodRiskByAddressBatch(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksServiceApi.GetFloodRiskByAddressBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**FloodRiskByAddressRequest**](FloodRiskByAddressRequest.md)|  | [optional] 

### Return type

[**FloodRiskResponseList**](FloodRiskResponseList.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfloodriskbylocation"></a>
# **GetFloodRiskByLocation**
> FloodRiskLocationResponse GetFloodRiskByLocation (string longitude, string latitude, string includeZoneDesc = null, string includeGeometry = null)

Get Flood Risk By Location

Accepts latitude & longitude as input and Returns flood risk data for flood zones and base flood elevation values.

### Example
```csharp
using System;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetFloodRiskByLocationExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new RisksServiceApi();
            var longitude = longitude_example;  // string | Longitude of Location
            var latitude = latitude_example;  // string | Latitude of Location
            var includeZoneDesc = includeZoneDesc_example;  // string | Specifies primary zone description. Valid Values: 'Y' or 'N'. Default: 'Y' (optional) 
            var includeGeometry = includeGeometry_example;  // string | Y or N (default is N) - if it is Y, then geometry will be part of response (optional) 

            try
            {
                // Get Flood Risk By Location
                FloodRiskLocationResponse result = apiInstance.GetFloodRiskByLocation(longitude, latitude, includeZoneDesc, includeGeometry);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksServiceApi.GetFloodRiskByLocation: " + e.Message );
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
 **includeZoneDesc** | **string**| Specifies primary zone description. Valid Values: &#39;Y&#39; or &#39;N&#39;. Default: &#39;Y&#39; | [optional] 
 **includeGeometry** | **string**| Y or N (default is N) - if it is Y, then geometry will be part of response | [optional] 

### Return type

[**FloodRiskLocationResponse**](FloodRiskLocationResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfloodriskbylocationbatch"></a>
# **GetFloodRiskByLocationBatch**
> FloodRiskLocationResponseList GetFloodRiskByLocationBatch (FloodRiskByLocationRequest body = null)

Post Flood Risk By Location

This is a Batch offering for 'Flood Risk By Location' service. It accepts a single location coordinate or a list of location coordinates and retrieve flood risk data for flood zones and base flood elevation values.

### Example
```csharp
using System;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetFloodRiskByLocationBatchExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new RisksServiceApi();
            var body = new FloodRiskByLocationRequest(); // FloodRiskByLocationRequest |  (optional) 

            try
            {
                // Post Flood Risk By Location
                FloodRiskLocationResponseList result = apiInstance.GetFloodRiskByLocationBatch(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksServiceApi.GetFloodRiskByLocationBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**FloodRiskByLocationRequest**](FloodRiskByLocationRequest.md)|  | [optional] 

### Return type

[**FloodRiskLocationResponseList**](FloodRiskLocationResponseList.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

