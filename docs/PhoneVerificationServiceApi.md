# com.precisely.apis.Api.PhoneVerificationServiceApi

All URIs are relative to *https://api.precisely.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PhoneVerification**](PhoneVerificationServiceApi.md#phoneverification) | **GET** /phoneverification/v1/phoneverification | Phone verification.



## PhoneVerification

> PhoneVerification PhoneVerification (string phoneNumber, string includeNetworkInfo = null)

Phone verification.

This service accepts a phone number as input and returns details distinguishing landline and wireless numbers and also checks if a wireless number can be located.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class PhoneVerificationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PhoneVerificationServiceApi(Configuration.Default);
            var phoneNumber = phoneNumber_example;  // string | E.164 formatted phone number. Accepts digits only. Country Code (1) optional for USA & CAN.
            var includeNetworkInfo = includeNetworkInfo_example;  // string | Y or N (default is Y) – if it is N, then network/carrier details will not be added in the response. (optional) 

            try
            {
                // Phone verification.
                PhoneVerification result = apiInstance.PhoneVerification(phoneNumber, includeNetworkInfo);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PhoneVerificationServiceApi.PhoneVerification: " + e.Message );
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
 **phoneNumber** | **string**| E.164 formatted phone number. Accepts digits only. Country Code (1) optional for USA &amp; CAN. | 
 **includeNetworkInfo** | **string**| Y or N (default is Y) – if it is N, then network/carrier details will not be added in the response. | [optional] 

### Return type

[**PhoneVerification**](PhoneVerification.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **400** | Bad Request |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

