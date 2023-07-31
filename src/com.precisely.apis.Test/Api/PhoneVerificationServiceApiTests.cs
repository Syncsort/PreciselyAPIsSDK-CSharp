/*
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * The version of the OpenAPI document: 16.0.1
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
    ///  Class for testing PhoneVerificationServiceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class PhoneVerificationServiceApiTests
    {
        private PhoneVerificationServiceApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PhoneVerificationServiceApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PhoneVerificationServiceApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // test 'IsInstanceOfType' PhoneVerificationServiceApi
            Assert.IsInstanceOf(typeof(PhoneVerificationServiceApi), instance, "instance is a PhoneVerificationServiceApi");
        }

        
        /// <summary>
        /// Test Validatephonenumber
        /// </summary>
        [Test]
        public void ValidatephonenumberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ValidatePhoneNumberAPIRequest validatePhoneNumberAPIRequest = null;
            //var response = instance.Validatephonenumber(validatePhoneNumberAPIRequest);
            //Assert.IsInstanceOf<PhoneVerification> (response, "response is PhoneVerification");
        }
        
    }

}
