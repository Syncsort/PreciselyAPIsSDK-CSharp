/*
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * The version of the OpenAPI document: 11.9.4
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
    ///  Class for testing EmailVerificationServiceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class EmailVerificationServiceApiTests
    {
        private EmailVerificationServiceApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new EmailVerificationServiceApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of EmailVerificationServiceApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // test 'IsInstanceOfType' EmailVerificationServiceApi
            Assert.IsInstanceOf(typeof(EmailVerificationServiceApi), instance, "instance is a EmailVerificationServiceApi");
        }

        
        /// <summary>
        /// Test ValidateEmailAddress
        /// </summary>
        [Test]
        public void ValidateEmailAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ValidateEmailAddressAPIRequest inputEmailAddress = null;
            //var response = instance.ValidateEmailAddress(inputEmailAddress);
            //Assert.IsInstanceOf<ValidateEmailAddressAPIResponse> (response, "response is ValidateEmailAddressAPIResponse");
        }
        
    }

}
