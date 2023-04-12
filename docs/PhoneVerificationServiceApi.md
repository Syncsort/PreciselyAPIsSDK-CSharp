# com.precisely.apis.Api.PhoneVerificationServiceApi

All URIs are relative to *https://api.precisely.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Validatephonenumber**](PhoneVerificationServiceApi.md#validatephonenumber) | **POST** /phoneverification/v2/validatephonenumber/results.json | Phone verification.



## Validatephonenumber

> PhoneVerification Validatephonenumber (ValidatePhoneNumberAPIRequest validatePhoneNumberAPIRequest)

Phone verification.

This service accepts a phone number as input and returns details distinguishing landline and wireless numbers.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class ValidatephonenumberExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PhoneVerificationServiceApi(Configuration.Default);
            var validatePhoneNumberAPIRequest = new ValidatePhoneNumberAPIRequest(); // ValidatePhoneNumberAPIRequest | 

            try
            {
                // Phone verification.
                PhoneVerification result = apiInstance.Validatephonenumber(validatePhoneNumberAPIRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PhoneVerificationServiceApi.Validatephonenumber: " + e.Message );
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
 **validatePhoneNumberAPIRequest** | [**ValidatePhoneNumberAPIRequest**](ValidatePhoneNumberAPIRequest.md)|  | 

### Return type

[**PhoneVerification**](PhoneVerification.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

- **Content-Type**: application/json
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

