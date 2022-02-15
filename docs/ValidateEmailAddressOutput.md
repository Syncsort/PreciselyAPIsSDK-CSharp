
# com.precisely.apis.Model.ValidateEmailAddressOutput

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UserFields** | [**List&lt;GetPostalCodesAPIOutputUserFields&gt;**](GetPostalCodesAPIOutputUserFields.md) | These fields are returned, unmodified, in the user_fields section of the response. | [optional] 
**EMAIL** | **string** | The email address submitted for verification. | [optional] 
**FINDING** | **string** | One character code indicating the validity of the submitted email address. | [optional] 
**COMMENT** | **string** | The comment string pertaining to the result of the submitted email address. | [optional] 
**COMMENT_CODE** | **string** | A short code which maps to each returned COMMENT field value. | [optional] 
**SUGG_EMAIL** | **string** | Suggested correction for submitted email address, if found. A suggestion will only be provided if it is valid and SafeToDeliver. | [optional] 
**SUGG_COMMENT** | **string** | This field contains suggestion not SafeToDeliver when ValidateEmailAddress corrected the address and the corrected version of the email address failed one or more SafeToDeliver process checks. | [optional] 
**ERROR_RESPONSE** | **string** | Pre-formatted response intended to be provided to user. | [optional] 
**ERROR** | **string** | Field reserved for special features only. | [optional] 
**Status** | **string** |  | [optional] 
**StatusCode** | **string** |  | [optional] 
**StatusDescription** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

