
# com.precisely.apis.Model.ValidateMailingAddressUSCANAPIOptions

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OutputAddressBlocks** | **string** | Specifies whether to return a formatted version of the address. | [optional] [default to "Y"]
**PerformUSProcessing** | **string** | Specifies whether or not to process U.S. addresses. | [optional] [default to "Y"]
**PerformDPV** | **string** | Delivery Point Validation (DPV®) validates that a specific address exists | [optional] [default to "N"]
**OutputFormattedOnFail** | **string** | Specifies whether to return a formatted address when an address cannot be validated. | [optional] [default to "N"]
**OutputPostalCodeSeparator** | **string** | Specifies whether to use separators (spaces or hyphens) in ZIP™ Codes or Canadian postal codes. | [optional] [default to "Y"]
**OutputCountryFormat** | **string** | Specifies the format to use for the country name returned in the Country output field. | [optional] [default to "E"]
**KeepMultimatch** | **string** | Indicates whether to return multiple address for input addresses that have more than one possible matches. | [optional] [default to "N"]
**OutputCasing** | **string** | Specifies the casing of the output address. M for mixed case and U for upper case. | [optional] [default to "M"]
**MaximumResults** | **string** | Specifies a number between 1 and 10 that indicates the maximum number of addresses to be returned. | [optional] [default to "10"]
**OutputRecordType** | **string** | Specifies the type of the output record. | [optional] [default to "A"]
**OutputFieldLevelReturnCodes** | **string** | Identifies which output addresses are candidate addresses as value if Y for OutputFieldLevelReturnCodes. | [optional] [default to "N"]
**DPVDetermineNoStat** | **string** | Determines the no stat status of an address which means it exists but cannot receive mails. | [optional] [default to "N"]
**StreetMatchingStrictness** | **string** | Specifies the algorithm to determe if an input address matches in the postal database. | [optional] [default to "M"]
**CanFrenchApartmentLabel** | **string** | Specifies the default apartment label for the output if there is no apartment label in the input address. This is specific to French address.  | [optional] [default to "Appartement"]
**OutputAbbreviatedAlias** | **string** | Specifies whether to use a street&#39;s abbreviated alias in the output if the output address line is longer than 31 characters. | [optional] [default to "N"]
**DPVSuccessfulStatusCondition** | **string** | Selecting the match condition where a DPV result does NOT cause a record to fail. | [optional] [default to "A"]
**StandardAddressPMBLine** | **string** | Specifies where Private Mailbox (PMB) information is placed. | [optional] [default to "N"]
**FirmMatchingStrictness** | **string** | Specifies the algorithm to determining if an input address matches in the postal database. | [optional] [default to "M"]
**CanRuralRouteFormat** | **string** | Specifies where to place rural route delivery information. | [optional] [default to "A"]
**CanPreferHouseNum** | **string** | Specifies whether to select a house number of postal code in case of conflict. | [optional] [default to "N"]
**OutputPreferredAlias** | **string** | Specifies whether to use a street&#39;s preferred alias in the output. | [optional] [default to "N"]
**DirectionalMatchingStrictness** | **string** | Specifies the algorithm to determine if an input address matches in the postal database. | [optional] [default to "M"]
**ExtractFirm** | **string** | Specifies whether to extract the firm name from AddressLine1 through AddressLine4 and place it in the FirmName output field. | [optional] [default to "N"]
**FailOnCMRAMatch** | **string** | Specifies whether to consider Treat Commercial Mail Receiving Agency (CMRA) matches as failures? | [optional] [default to "N"]
**CanNonCivicFormat** | **string** | Specifies whether or not non-civic keywords are abbreviated in the output.  | [optional] [default to "A"]
**CanSSLVRFlg** | **string** | Changes the civic and/or suite information to match the LVR or single-single record. | [optional] [default to "N"]
**OutputStreetNameAlias** | **string** | Specifies how to handle street name aliases used in the input. This is specific to US. | [optional] [default to "Y"]
**PerformEWS** | **string** | Specifies the Early Warning System (EWS) that uses the USPS EWS File to validate addresses that are not in the ZIP + 4 database. | [optional] [default to "N"]
**CanOutputCityFormat** | **string** | Specifies whether to use the long, medium, or short version of the city if the city has a long name. | [optional] [default to "D"]
**DualAddressLogic** | **string** | Specifies how to return a match if multiple non-blank address lines are present or multiple address types are on the same address line. (U.S. addresses only.) | [optional] [default to "N"]
**PerformSuiteLink** | **string** | Specifies whether to perform SuiteLink processing. | [optional] [default to "N"]
**CanStandardAddressFormat** | **string** | Specifies where to place secondary address information in the output address. | [optional] [default to "D"]
**OutputPreferredCity** | **string** | Specifies whether the preferred last line city name should be stored. | [optional] [default to "Z"]
**OutputMultinationalCharacters** | **string** | Specifies whether to return multinational characters, including diacritical marks such as umlauts or accents. | [optional] [default to "N"]
**CanDeliveryOfficeFormat** | **string** | Specifies where to place station information. | [optional] [default to "I"]
**PerformLACSLink** | **string** | Facilitates the conversion of rural route address converting into street-style address using the LACS. | [optional] [default to "Y"]
**CanDualAddressLogic** | **string** | Specifies whether ValidateMailingAddressUSCAN should return a street match or a PO Box/non-civic match when the address contains both civic and non-civic information. | [optional] [default to "D"]
**ExtractUrb** | **string** | Specifies whether to extract the urbanization name from AddressLine1 through AddressLine4 and place it in the USUrbanName output field.  | [optional] [default to "N"]
**StandardAddressFormat** | **string** | Specifies where to place secondary address information for U.S. addresses. | [optional] [default to "C"]
**CanFrenchFormat** | **string** | Specifies how to determine the language (English or French) to use to format the address and directional. | [optional] [default to "C"]
**DPVDetermineVacancy** | **string** | Determines if the location has been unoccupied for at least 90 days. | [optional] [default to "N"]
**CanEnglishApartmentLabel** | **string** | Specifies the default apartment label to use in the output if there is no apartment label in the input address. rhis is specific to English addresses. | [optional] [default to "Apt"]
**SuppressZplusPhantomCarrierR777** | **string** | Specifies whether to supress addresses with Carrier Route R777. | [optional] [default to "N"]
**CanOutputCityAlias** | **string** | Specifies whether or not to return the city alias when the alias is in the input address. | [optional] [default to "N"]
**OutputShortCityName** | **string** | Specifies how to format city names that have short city name or non-mailing city name alternatives. | [optional] [default to "N"]

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

