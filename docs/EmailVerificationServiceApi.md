# com.precisely.apis.Api.EmailVerificationServiceApi

All URIs are relative to *https://api.precisely.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ValidateEmailAddress**](EmailVerificationServiceApi.md#validateemailaddress) | **POST** /emailverification/v1/validateemailaddress/results.json | ValidateEmailAddress


<a name="validateemailaddress"></a>
# **ValidateEmailAddress**
> ValidateEmailAddressAPIResponse ValidateEmailAddress (ValidateEmailAddressAPIRequest inputEmailAddress)

ValidateEmailAddress

Confirm that your customer’s mailing address exists and that mail and packages can be delivered to it.

### Example
```csharp
using System;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class ValidateEmailAddressExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new EmailVerificationServiceApi();
            var inputEmailAddress = new ValidateEmailAddressAPIRequest(); // ValidateEmailAddressAPIRequest | 

            try
            {
                // ValidateEmailAddress
                ValidateEmailAddressAPIResponse result = apiInstance.ValidateEmailAddress(inputEmailAddress);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailVerificationServiceApi.ValidateEmailAddress: " + e.Message );
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
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

