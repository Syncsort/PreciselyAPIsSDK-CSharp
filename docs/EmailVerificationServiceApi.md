# com.precisely.apis.Api.EmailVerificationServiceApi

All URIs are relative to *https://api.precisely.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ValidateEmailAddress**](EmailVerificationServiceApi.md#validateemailaddress) | **POST** /emailverification/v1/validateemailaddress/results.json | ValidateEmailAddress



## ValidateEmailAddress

> ValidateEmailAddressAPIResponse ValidateEmailAddress (ValidateEmailAddressAPIRequest inputEmailAddress)

ValidateEmailAddress

Confirm that your customer’s mailing address exists and that mail and packages can be delivered to it.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class ValidateEmailAddressExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmailVerificationServiceApi(Configuration.Default);
            var inputEmailAddress = new ValidateEmailAddressAPIRequest(); // ValidateEmailAddressAPIRequest | 

            try
            {
                // ValidateEmailAddress
                ValidateEmailAddressAPIResponse result = apiInstance.ValidateEmailAddress(inputEmailAddress);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling EmailVerificationServiceApi.ValidateEmailAddress: " + e.Message );
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
 **inputEmailAddress** | [**ValidateEmailAddressAPIRequest**](ValidateEmailAddressAPIRequest.md)|  | 

### Return type

[**ValidateEmailAddressAPIResponse**](ValidateEmailAddressAPIResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

- **Content-Type**: application/json
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

