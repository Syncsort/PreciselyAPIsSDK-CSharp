
# com.precisely.apis.Model.ValidateMailingAddressOutput

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UserFields** | [**List&lt;GetPostalCodesAPIOutputUserFields&gt;**](GetPostalCodesAPIOutputUserFields.md) | These fields are returned, unmodified, in the user_fields section of the response. | [optional] 
**AddressLine1** | **string** | The first line of the validated address. | [optional] 
**AddressLine2** | **string** | The second line of the validated address. | [optional] 
**FirmName** | **string** | The validated firm or company name. | [optional] 
**City** | **string** | The validated city name. | [optional] 
**PostalCode** | **string** | The validated ZIP Code or postal code. | [optional] 
**Country** | **string** | The country name in English. | [optional] 
**StateProvince** | **string** | The validated state or province abbreviation. | [optional] 
**BlockAddress** | **string** | The formatted address, as it would appear on a physical mail piece. | [optional] 
**AdditionalInputData** | **string** | Input data not used by the address validation process. | [optional] 
**PostalCodeBase** | **string** | The 5-digit ZIP Code. | [optional] 
**PostalCodeAddOn** | **string** | The 4-digit add-on part of the ZIP Code. | [optional] 
**Status** | **string** | Reports the success or failure of the match attempt. | [optional] 
**StatusCode** | **string** | Reason for failure, if there is one. | [optional] 
**StatusDescription** | **string** | Description of the problem, if there is one. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

