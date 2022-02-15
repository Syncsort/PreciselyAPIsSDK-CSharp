
# com.precisely.apis.Model.ValidateMailingAddressProOutput

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UserFields** | [**List&lt;GetPostalCodesAPIOutputUserFields&gt;**](GetPostalCodesAPIOutputUserFields.md) | These fields are returned, unmodified, in the user_fields section of the response. | [optional] 
**AddressLine1** | **string** | The first line of the validated address. | [optional] 
**AddressLine2** | **string** | The second line of the validated address. | [optional] 
**FirmName** | **string** | The validated firm or company name. | [optional] 
**ChangeScore** | **string** | A value of 0 and 100 that reflects how much the address has changed to make it valid. | [optional] 
**Locality** | **string** | Generally a locality is a village in rural areas or it may be a suburb in urban areas. | [optional] 
**Suburb** | **string** | The suburb name. | [optional] 
**AddressType** | **string** | A single letter code that indicates the type of address. | [optional] 
**Deliverability** | **string** | An estimate of confidence that an item mailed or shipped to this address would be successfully delivered. | [optional] 
**AddressQuality** | **string** | A two character code indicating overall quality of the resulting address. | [optional] 
**CouldNotValidate** | **string** | Mentions the address component that could not be validated, in case no match is found. | [optional] 
**City** | **string** | The validated city name. | [optional] 
**PostalCode** | **string** | The validated ZIP Code or postal code. | [optional] 
**Country** | **string** | The country in the format determined by what you selected. | [optional] 
**StateProvince** | **string** | The validated state or province abbreviation. | [optional] 
**BlockAddress** | **string** | The formatted address, as it would appear on a physical mail piece. | [optional] 
**AdditionalInputData** | **string** | Input data that could not be matched to a particular address component. | [optional] 
**PostalCodeBase** | **string** | The 5-digit ZIP Code. | [optional] 
**PostalCodeAddOn** | **string** | The 4-digit add-on part of the ZIP Code. | [optional] 
**Status** | **string** | Reports the success or failure of the match attempt. | [optional] 
**StatusCode** | **string** | Reason for failure, if there is one. | [optional] 
**StatusDescription** | **string** | Description of the problem, if there is one. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

