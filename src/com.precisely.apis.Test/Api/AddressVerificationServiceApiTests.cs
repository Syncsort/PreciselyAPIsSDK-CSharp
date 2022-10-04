/*
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * The version of the OpenAPI document: 12.0.1
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
    ///  Class for testing AddressVerificationServiceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class AddressVerificationServiceApiTests
    {
        private AddressVerificationServiceApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AddressVerificationServiceApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AddressVerificationServiceApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // test 'IsInstanceOfType' AddressVerificationServiceApi
            Assert.IsInstanceOf(typeof(AddressVerificationServiceApi), instance, "instance is a AddressVerificationServiceApi");
        }

        
        /// <summary>
        /// Test GetCityStateProvince
        /// </summary>
        [Test]
        public void GetCityStateProvinceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GetCityStateProvinceAPIRequest inputAddress = null;
            //var response = instance.GetCityStateProvince(inputAddress);
            //Assert.IsInstanceOf<GetCityStateProvinceAPIResponse> (response, "response is GetCityStateProvinceAPIResponse");
        }
        
        /// <summary>
        /// Test GetPostalCodes
        /// </summary>
        [Test]
        public void GetPostalCodesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GetPostalCodesAPIRequest inputAddress = null;
            //var response = instance.GetPostalCodes(inputAddress);
            //Assert.IsInstanceOf<GetPostalCodesAPIResponse> (response, "response is GetPostalCodesAPIResponse");
        }
        
        /// <summary>
        /// Test ValidateMailingAddress
        /// </summary>
        [Test]
        public void ValidateMailingAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ValidateMailingAddressRequest inputAddress = null;
            //var response = instance.ValidateMailingAddress(inputAddress);
            //Assert.IsInstanceOf<ValidateMailingAddressResponse> (response, "response is ValidateMailingAddressResponse");
        }
        
        /// <summary>
        /// Test ValidateMailingAddressPremium
        /// </summary>
        [Test]
        public void ValidateMailingAddressPremiumTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ValidateMailingAddressPremiumRequest inputAddress = null;
            //var response = instance.ValidateMailingAddressPremium(inputAddress);
            //Assert.IsInstanceOf<ValidateMailingAddressPremiumResponse> (response, "response is ValidateMailingAddressPremiumResponse");
        }
        
        /// <summary>
        /// Test ValidateMailingAddressPro
        /// </summary>
        [Test]
        public void ValidateMailingAddressProTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ValidateMailingAddressProRequest inputAddress = null;
            //var response = instance.ValidateMailingAddressPro(inputAddress);
            //Assert.IsInstanceOf<ValidateMailingAddressProResponse> (response, "response is ValidateMailingAddressProResponse");
        }
        
        /// <summary>
        /// Test ValidateMailingAddressUSCAN
        /// </summary>
        [Test]
        public void ValidateMailingAddressUSCANTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ValidateMailingAddressUSCANAPIRequest inputAddress = null;
            //var response = instance.ValidateMailingAddressUSCAN(inputAddress);
            //Assert.IsInstanceOf<ValidateMailingAddressUSCANAPIResponse> (response, "response is ValidateMailingAddressUSCANAPIResponse");
        }
        
    }

}
