/*
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * The version of the OpenAPI document: 11.9.4
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using com.precisely.apis.Api;
using com.precisely.apis.Model;
using com.precisely.apis.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace com.precisely.apis.Test
{
    /// <summary>
    ///  Class for testing ValidateMailingAddressUSCANAPIOptions
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ValidateMailingAddressUSCANAPIOptionsTests
    {
        // TODO uncomment below to declare an instance variable for ValidateMailingAddressUSCANAPIOptions
        //private ValidateMailingAddressUSCANAPIOptions instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of ValidateMailingAddressUSCANAPIOptions
            //instance = new ValidateMailingAddressUSCANAPIOptions();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ValidateMailingAddressUSCANAPIOptions
        /// </summary>
        [Test]
        public void ValidateMailingAddressUSCANAPIOptionsInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" ValidateMailingAddressUSCANAPIOptions
            //Assert.IsInstanceOf(typeof(ValidateMailingAddressUSCANAPIOptions), instance);
        }


        /// <summary>
        /// Test the property 'OutputAddressBlocks'
        /// </summary>
        [Test]
        public void OutputAddressBlocksTest()
        {
            // TODO unit test for the property 'OutputAddressBlocks'
        }
        /// <summary>
        /// Test the property 'PerformUSProcessing'
        /// </summary>
        [Test]
        public void PerformUSProcessingTest()
        {
            // TODO unit test for the property 'PerformUSProcessing'
        }
        /// <summary>
        /// Test the property 'PerformDPV'
        /// </summary>
        [Test]
        public void PerformDPVTest()
        {
            // TODO unit test for the property 'PerformDPV'
        }
        /// <summary>
        /// Test the property 'OutputFormattedOnFail'
        /// </summary>
        [Test]
        public void OutputFormattedOnFailTest()
        {
            // TODO unit test for the property 'OutputFormattedOnFail'
        }
        /// <summary>
        /// Test the property 'OutputPostalCodeSeparator'
        /// </summary>
        [Test]
        public void OutputPostalCodeSeparatorTest()
        {
            // TODO unit test for the property 'OutputPostalCodeSeparator'
        }
        /// <summary>
        /// Test the property 'OutputCountryFormat'
        /// </summary>
        [Test]
        public void OutputCountryFormatTest()
        {
            // TODO unit test for the property 'OutputCountryFormat'
        }
        /// <summary>
        /// Test the property 'KeepMultimatch'
        /// </summary>
        [Test]
        public void KeepMultimatchTest()
        {
            // TODO unit test for the property 'KeepMultimatch'
        }
        /// <summary>
        /// Test the property 'OutputCasing'
        /// </summary>
        [Test]
        public void OutputCasingTest()
        {
            // TODO unit test for the property 'OutputCasing'
        }
        /// <summary>
        /// Test the property 'MaximumResults'
        /// </summary>
        [Test]
        public void MaximumResultsTest()
        {
            // TODO unit test for the property 'MaximumResults'
        }
        /// <summary>
        /// Test the property 'OutputRecordType'
        /// </summary>
        [Test]
        public void OutputRecordTypeTest()
        {
            // TODO unit test for the property 'OutputRecordType'
        }
        /// <summary>
        /// Test the property 'OutputFieldLevelReturnCodes'
        /// </summary>
        [Test]
        public void OutputFieldLevelReturnCodesTest()
        {
            // TODO unit test for the property 'OutputFieldLevelReturnCodes'
        }
        /// <summary>
        /// Test the property 'DPVDetermineNoStat'
        /// </summary>
        [Test]
        public void DPVDetermineNoStatTest()
        {
            // TODO unit test for the property 'DPVDetermineNoStat'
        }
        /// <summary>
        /// Test the property 'StreetMatchingStrictness'
        /// </summary>
        [Test]
        public void StreetMatchingStrictnessTest()
        {
            // TODO unit test for the property 'StreetMatchingStrictness'
        }
        /// <summary>
        /// Test the property 'CanFrenchApartmentLabel'
        /// </summary>
        [Test]
        public void CanFrenchApartmentLabelTest()
        {
            // TODO unit test for the property 'CanFrenchApartmentLabel'
        }
        /// <summary>
        /// Test the property 'OutputAbbreviatedAlias'
        /// </summary>
        [Test]
        public void OutputAbbreviatedAliasTest()
        {
            // TODO unit test for the property 'OutputAbbreviatedAlias'
        }
        /// <summary>
        /// Test the property 'DPVSuccessfulStatusCondition'
        /// </summary>
        [Test]
        public void DPVSuccessfulStatusConditionTest()
        {
            // TODO unit test for the property 'DPVSuccessfulStatusCondition'
        }
        /// <summary>
        /// Test the property 'StandardAddressPMBLine'
        /// </summary>
        [Test]
        public void StandardAddressPMBLineTest()
        {
            // TODO unit test for the property 'StandardAddressPMBLine'
        }
        /// <summary>
        /// Test the property 'FirmMatchingStrictness'
        /// </summary>
        [Test]
        public void FirmMatchingStrictnessTest()
        {
            // TODO unit test for the property 'FirmMatchingStrictness'
        }
        /// <summary>
        /// Test the property 'CanRuralRouteFormat'
        /// </summary>
        [Test]
        public void CanRuralRouteFormatTest()
        {
            // TODO unit test for the property 'CanRuralRouteFormat'
        }
        /// <summary>
        /// Test the property 'CanPreferHouseNum'
        /// </summary>
        [Test]
        public void CanPreferHouseNumTest()
        {
            // TODO unit test for the property 'CanPreferHouseNum'
        }
        /// <summary>
        /// Test the property 'OutputPreferredAlias'
        /// </summary>
        [Test]
        public void OutputPreferredAliasTest()
        {
            // TODO unit test for the property 'OutputPreferredAlias'
        }
        /// <summary>
        /// Test the property 'DirectionalMatchingStrictness'
        /// </summary>
        [Test]
        public void DirectionalMatchingStrictnessTest()
        {
            // TODO unit test for the property 'DirectionalMatchingStrictness'
        }
        /// <summary>
        /// Test the property 'ExtractFirm'
        /// </summary>
        [Test]
        public void ExtractFirmTest()
        {
            // TODO unit test for the property 'ExtractFirm'
        }
        /// <summary>
        /// Test the property 'FailOnCMRAMatch'
        /// </summary>
        [Test]
        public void FailOnCMRAMatchTest()
        {
            // TODO unit test for the property 'FailOnCMRAMatch'
        }
        /// <summary>
        /// Test the property 'CanNonCivicFormat'
        /// </summary>
        [Test]
        public void CanNonCivicFormatTest()
        {
            // TODO unit test for the property 'CanNonCivicFormat'
        }
        /// <summary>
        /// Test the property 'CanSSLVRFlg'
        /// </summary>
        [Test]
        public void CanSSLVRFlgTest()
        {
            // TODO unit test for the property 'CanSSLVRFlg'
        }
        /// <summary>
        /// Test the property 'OutputStreetNameAlias'
        /// </summary>
        [Test]
        public void OutputStreetNameAliasTest()
        {
            // TODO unit test for the property 'OutputStreetNameAlias'
        }
        /// <summary>
        /// Test the property 'PerformEWS'
        /// </summary>
        [Test]
        public void PerformEWSTest()
        {
            // TODO unit test for the property 'PerformEWS'
        }
        /// <summary>
        /// Test the property 'CanOutputCityFormat'
        /// </summary>
        [Test]
        public void CanOutputCityFormatTest()
        {
            // TODO unit test for the property 'CanOutputCityFormat'
        }
        /// <summary>
        /// Test the property 'DualAddressLogic'
        /// </summary>
        [Test]
        public void DualAddressLogicTest()
        {
            // TODO unit test for the property 'DualAddressLogic'
        }
        /// <summary>
        /// Test the property 'PerformSuiteLink'
        /// </summary>
        [Test]
        public void PerformSuiteLinkTest()
        {
            // TODO unit test for the property 'PerformSuiteLink'
        }
        /// <summary>
        /// Test the property 'CanStandardAddressFormat'
        /// </summary>
        [Test]
        public void CanStandardAddressFormatTest()
        {
            // TODO unit test for the property 'CanStandardAddressFormat'
        }
        /// <summary>
        /// Test the property 'OutputPreferredCity'
        /// </summary>
        [Test]
        public void OutputPreferredCityTest()
        {
            // TODO unit test for the property 'OutputPreferredCity'
        }
        /// <summary>
        /// Test the property 'OutputMultinationalCharacters'
        /// </summary>
        [Test]
        public void OutputMultinationalCharactersTest()
        {
            // TODO unit test for the property 'OutputMultinationalCharacters'
        }
        /// <summary>
        /// Test the property 'CanDeliveryOfficeFormat'
        /// </summary>
        [Test]
        public void CanDeliveryOfficeFormatTest()
        {
            // TODO unit test for the property 'CanDeliveryOfficeFormat'
        }
        /// <summary>
        /// Test the property 'PerformLACSLink'
        /// </summary>
        [Test]
        public void PerformLACSLinkTest()
        {
            // TODO unit test for the property 'PerformLACSLink'
        }
        /// <summary>
        /// Test the property 'CanDualAddressLogic'
        /// </summary>
        [Test]
        public void CanDualAddressLogicTest()
        {
            // TODO unit test for the property 'CanDualAddressLogic'
        }
        /// <summary>
        /// Test the property 'ExtractUrb'
        /// </summary>
        [Test]
        public void ExtractUrbTest()
        {
            // TODO unit test for the property 'ExtractUrb'
        }
        /// <summary>
        /// Test the property 'StandardAddressFormat'
        /// </summary>
        [Test]
        public void StandardAddressFormatTest()
        {
            // TODO unit test for the property 'StandardAddressFormat'
        }
        /// <summary>
        /// Test the property 'CanFrenchFormat'
        /// </summary>
        [Test]
        public void CanFrenchFormatTest()
        {
            // TODO unit test for the property 'CanFrenchFormat'
        }
        /// <summary>
        /// Test the property 'DPVDetermineVacancy'
        /// </summary>
        [Test]
        public void DPVDetermineVacancyTest()
        {
            // TODO unit test for the property 'DPVDetermineVacancy'
        }
        /// <summary>
        /// Test the property 'CanEnglishApartmentLabel'
        /// </summary>
        [Test]
        public void CanEnglishApartmentLabelTest()
        {
            // TODO unit test for the property 'CanEnglishApartmentLabel'
        }
        /// <summary>
        /// Test the property 'SuppressZplusPhantomCarrierR777'
        /// </summary>
        [Test]
        public void SuppressZplusPhantomCarrierR777Test()
        {
            // TODO unit test for the property 'SuppressZplusPhantomCarrierR777'
        }
        /// <summary>
        /// Test the property 'CanOutputCityAlias'
        /// </summary>
        [Test]
        public void CanOutputCityAliasTest()
        {
            // TODO unit test for the property 'CanOutputCityAlias'
        }
        /// <summary>
        /// Test the property 'OutputShortCityName'
        /// </summary>
        [Test]
        public void OutputShortCityNameTest()
        {
            // TODO unit test for the property 'OutputShortCityName'
        }

    }

}
