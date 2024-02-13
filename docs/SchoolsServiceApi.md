# com.precisely.apis.Api.SchoolsServiceApi

All URIs are relative to *https://api.precisely.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetSchoolsByAddress**](SchoolsServiceApi.md#getschoolsbyaddress) | **GET** /schools/v1/school/byaddress | Search Nearby Schools by Address



## GetSchoolsByAddress

> SchoolsNearByResponse GetSchoolsByAddress (string address, string edLevel = null, string schoolType = null, string schoolSubType = null, string gender = null, string assignedSchoolsOnly = null, string districtSchoolsOnly = null, string searchRadius = null, string searchRadiusUnit = null, string travelTime = null, string travelTimeUnit = null, string travelDistance = null, string travelDistanceUnit = null, string travelMode = null, string maxCandidates = null)

Search Nearby Schools by Address

Search Nearby Schools by Address

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetSchoolsByAddressExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SchoolsServiceApi(Configuration.Default);
            var address = address_example;  // string | free form address text
            var edLevel = edLevel_example;  // string | Single digit code for education level applicable values are P -> primary, M -> Middle, H -> High, O -> Mixed Grades for public school type andE -> Elementary , S -> Secondary , O -> Others mixed grades for private schools  (optional) 
            var schoolType = schoolType_example;  // string | Single digit code for schoolTypes applicable values are PRI and PUB (optional) 
            var schoolSubType = schoolSubType_example;  // string | Single digit code for schoolSubType Applicable values are C, M, A, R, I, L, P, V, U, S (i.e. Charter, Magnet, Alternative, Regular, Indian, Military, Reportable Program, Vocational, Unknown, Special Education) (optional) 
            var gender = gender_example;  // string | Single digit code for gender Applicable values are C, F, M (Coed, All Females, All Males) Applicable for Private Schools Only (optional) 
            var assignedSchoolsOnly = assignedSchoolsOnly_example;  // string | Single digit code for assignedSchoolOnly applicable values are  Y/N  (optional) 
            var districtSchoolsOnly = districtSchoolsOnly_example;  // string | Single digit code for districtSchoolOnly applicable values are Y/N  (optional) 
            var searchRadius = searchRadius_example;  // string | Search Radius within which schools are searched (optional) 
            var searchRadiusUnit = searchRadiusUnit_example;  // string | Search Radius unit applicable values are feet,kilometers,miles,meters (optional) 
            var travelTime = travelTime_example;  // string | Travel Time based on ‘travelMode’ within which schools are searched. (optional) 
            var travelTimeUnit = travelTimeUnit_example;  // string | Travel Time unit applicable values are minutes,hours,seconds,milliseconds  (optional) 
            var travelDistance = travelDistance_example;  // string | Travel Distance based on ‘travelMode’ within which schools are searched. (optional) 
            var travelDistanceUnit = travelDistanceUnit_example;  // string | Travel distanceUnit applicable values are feet,kilometers,miles,meters (optional) 
            var travelMode = travelMode_example;  // string | Travel mode Required when travelDistance or travelTime is specified. Accepted values are walking,driving (optional) 
            var maxCandidates = maxCandidates_example;  // string | Max result to search  (optional) 

            try
            {
                // Search Nearby Schools by Address
                SchoolsNearByResponse result = apiInstance.GetSchoolsByAddress(address, edLevel, schoolType, schoolSubType, gender, assignedSchoolsOnly, districtSchoolsOnly, searchRadius, searchRadiusUnit, travelTime, travelTimeUnit, travelDistance, travelDistanceUnit, travelMode, maxCandidates);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SchoolsServiceApi.GetSchoolsByAddress: " + e.Message );
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
 **edLevel** | **string**| Single digit code for education level applicable values are P -&gt; primary, M -&gt; Middle, H -&gt; High, O -&gt; Mixed Grades for public school type andE -&gt; Elementary , S -&gt; Secondary , O -&gt; Others mixed grades for private schools  | [optional] 
 **schoolType** | **string**| Single digit code for schoolTypes applicable values are PRI and PUB | [optional] 
 **schoolSubType** | **string**| Single digit code for schoolSubType Applicable values are C, M, A, R, I, L, P, V, U, S (i.e. Charter, Magnet, Alternative, Regular, Indian, Military, Reportable Program, Vocational, Unknown, Special Education) | [optional] 
 **gender** | **string**| Single digit code for gender Applicable values are C, F, M (Coed, All Females, All Males) Applicable for Private Schools Only | [optional] 
 **assignedSchoolsOnly** | **string**| Single digit code for assignedSchoolOnly applicable values are  Y/N  | [optional] 
 **districtSchoolsOnly** | **string**| Single digit code for districtSchoolOnly applicable values are Y/N  | [optional] 
 **searchRadius** | **string**| Search Radius within which schools are searched | [optional] 
 **searchRadiusUnit** | **string**| Search Radius unit applicable values are feet,kilometers,miles,meters | [optional] 
 **travelTime** | **string**| Travel Time based on ‘travelMode’ within which schools are searched. | [optional] 
 **travelTimeUnit** | **string**| Travel Time unit applicable values are minutes,hours,seconds,milliseconds  | [optional] 
 **travelDistance** | **string**| Travel Distance based on ‘travelMode’ within which schools are searched. | [optional] 
 **travelDistanceUnit** | **string**| Travel distanceUnit applicable values are feet,kilometers,miles,meters | [optional] 
 **travelMode** | **string**| Travel mode Required when travelDistance or travelTime is specified. Accepted values are walking,driving | [optional] 
 **maxCandidates** | **string**| Max result to search  | [optional] 

### Return type

[**SchoolsNearByResponse**](SchoolsNearByResponse.md)

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

