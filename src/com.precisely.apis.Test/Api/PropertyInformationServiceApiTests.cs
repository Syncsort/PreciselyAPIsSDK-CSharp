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
    ///  Class for testing PropertyInformationServiceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class PropertyInformationServiceApiTests
    {
        private PropertyInformationServiceApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PropertyInformationServiceApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PropertyInformationServiceApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // test 'IsInstanceOfType' PropertyInformationServiceApi
            Assert.IsInstanceOf(typeof(PropertyInformationServiceApi), instance, "instance is a PropertyInformationServiceApi");
        }

        
        /// <summary>
        /// Test GetPropertyAttributesByAddress
        /// </summary>
        [Test]
        public void GetPropertyAttributesByAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string address = null;
            //string attributes = null;
            //var response = instance.GetPropertyAttributesByAddress(addressattributes);
            //Assert.IsInstanceOf<PropertyInfoResponse> (response, "response is PropertyInfoResponse");
        }
        
        /// <summary>
        /// Test GetPropertyAttributesByAddressBatch
        /// </summary>
        [Test]
        public void GetPropertyAttributesByAddressBatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PropertyInfoAddressRequest propertyInfoAddressRequest = null;
            //var response = instance.GetPropertyAttributesByAddressBatch(propertyInfoAddressRequest);
            //Assert.IsInstanceOf<PropertyInfoResponses> (response, "response is PropertyInfoResponses");
        }
        
    }

}
