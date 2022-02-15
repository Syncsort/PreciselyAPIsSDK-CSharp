# com.precisely.apis.Api.GeolocationServiceApi

All URIs are relative to *https://api.precisely.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetLocationByIPAddress**](GeolocationServiceApi.md#getlocationbyipaddress) | **GET** /geolocation/v1/location/byipaddress | Location By IP Address.
[**GetLocationByWiFiAccessPoint**](GeolocationServiceApi.md#getlocationbywifiaccesspoint) | **GET** /geolocation/v1/location/byaccesspoint | Location by WiFi Access Point.



## GetLocationByIPAddress

> GeoLocationIpAddr GetLocationByIPAddress (string ipAddress)

Location By IP Address.

This service accepts an IP address and returns the location coordinates corresponding to that IP address.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetLocationByIPAddressExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GeolocationServiceApi(Configuration.Default);
            var ipAddress = ipAddress_example;  // string | This is the ip address of network connected device. It must be a standard IPv4 octet and a valid external address.

            try
            {
                // Location By IP Address.
                GeoLocationIpAddr result = apiInstance.GetLocationByIPAddress(ipAddress);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GeolocationServiceApi.GetLocationByIPAddress: " + e.Message );
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
 **ipAddress** | **string**| This is the ip address of network connected device. It must be a standard IPv4 octet and a valid external address. | 

### Return type

[**GeoLocationIpAddr**](GeoLocationIpAddr.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/xml, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetLocationByWiFiAccessPoint

> GeoLocationAccessPoint GetLocationByWiFiAccessPoint (string mac = null, string ssid = null, string rsid = null, string speed = null, string accessPoint = null)

Location by WiFi Access Point.

This service accepts a WiFi access point MAC address and returns the location coordinates corresponding to that access point. Only mac or accessPoint are mandatory parameters (one of them has to be provided), rest are optional.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetLocationByWiFiAccessPointExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GeolocationServiceApi(Configuration.Default);
            var mac = mac_example;  // string | This should be the 48 bit mac address (or BSSID) of wireless access point. Accepted format is Six groups of two hexadecimal digits, separated by hyphens (-) or colons. (optional) 
            var ssid = ssid_example;  // string | The service set identifier for wi-fi access point. It should be alphanumeric with maximum 32 characters. (optional) 
            var rsid = rsid_example;  // string | This is the received signal strength indicator from particular wi-fi access point. It should be a number from -113 to 0 and the unit of this strength is dBm. (optional) 
            var speed = speed_example;  // string | This is the connection speed for wi-fi. It should be a number from 0 to 6930 and the unit should be Mbps. (optional) 
            var accessPoint = accessPoint_example;  // string | This is the JSON based list of wifi access points in the vicinity of device to be located. This parameter is helpful in case, multiple wifi points are visible and we want to make sure that the location of device is best calculated considering all the access points location. (optional) 

            try
            {
                // Location by WiFi Access Point.
                GeoLocationAccessPoint result = apiInstance.GetLocationByWiFiAccessPoint(mac, ssid, rsid, speed, accessPoint);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GeolocationServiceApi.GetLocationByWiFiAccessPoint: " + e.Message );
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
 **mac** | **string**| This should be the 48 bit mac address (or BSSID) of wireless access point. Accepted format is Six groups of two hexadecimal digits, separated by hyphens (-) or colons. | [optional] 
 **ssid** | **string**| The service set identifier for wi-fi access point. It should be alphanumeric with maximum 32 characters. | [optional] 
 **rsid** | **string**| This is the received signal strength indicator from particular wi-fi access point. It should be a number from -113 to 0 and the unit of this strength is dBm. | [optional] 
 **speed** | **string**| This is the connection speed for wi-fi. It should be a number from 0 to 6930 and the unit should be Mbps. | [optional] 
 **accessPoint** | **string**| This is the JSON based list of wifi access points in the vicinity of device to be located. This parameter is helpful in case, multiple wifi points are visible and we want to make sure that the location of device is best calculated considering all the access points location. | [optional] 

### Return type

[**GeoLocationAccessPoint**](GeoLocationAccessPoint.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/xml, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

