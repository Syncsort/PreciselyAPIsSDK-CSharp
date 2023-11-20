/*
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * The version of the OpenAPI document: 17.1.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using com.precisely.apis.Client;
using com.precisely.apis.Api;
using com.precisely.apis.Model;

namespace com.precisely.apis.Test
{
    /// <summary>
    ///  Class for testing AddressAutocompleteEnterpriseServiceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class AddressAutocompleteEnterpriseServiceApiTests
    {
        private AddressAutocompleteEnterpriseServiceApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AddressAutocompleteEnterpriseServiceApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AddressAutocompleteEnterpriseServiceApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // test 'IsInstanceOfType' AddressAutocompleteEnterpriseServiceApi
            Assert.IsInstanceOf(typeof(AddressAutocompleteEnterpriseServiceApi), instance, "instance is a AddressAutocompleteEnterpriseServiceApi");
        }

        
        /// <summary>
        /// Test ListLocations
        /// </summary>
        [Test]
        public void ListLocationsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string searchText = null;
            //string transactionId = null;
            //string latitude = null;
            //string longitude = null;
            //string searchRadius = null;
            //string searchRadiusUnit = null;
            //string maxCandidates = null;
            //string country = null;
            //string matchOnAddressNumber = null;
            //string autoDetectLocation = null;
            //string ipAddress = null;
            //string areaName1 = null;
            //string areaName3 = null;
            //string postCode = null;
            //string returnAdminAreasOnly = null;
            //string includeRangesDetails = null;
            //string searchType = null;
            //string searchOnAddressNumber = null;
            //string searchOnUnitInfo = null;
            //var response = instance.ListLocations(searchTexttransactionIdlatitudelongitudesearchRadiussearchRadiusUnitmaxCandidatescountrymatchOnAddressNumberautoDetectLocationipAddressareaName1areaName3postCodereturnAdminAreasOnlyincludeRangesDetailssearchTypesearchOnAddressNumbersearchOnUnitInfo);
            //Assert.IsInstanceOf<TypeaheadLocations> (response, "response is TypeaheadLocations");
        }
        
        /// <summary>
        /// Test ListSelect
        /// </summary>
        [Test]
        public void ListSelectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string selectedAddress = null;
            //string transactionId = null;
            //string country = null;
            //var response = instance.ListSelect(selectedAddresstransactionIdcountry);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
    }

}
