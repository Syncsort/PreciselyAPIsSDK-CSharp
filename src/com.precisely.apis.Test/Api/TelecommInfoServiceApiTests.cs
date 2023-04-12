/*
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * The version of the OpenAPI document: 15.0.0
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
    ///  Class for testing TelecommInfoServiceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class TelecommInfoServiceApiTests
    {
        private TelecommInfoServiceApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TelecommInfoServiceApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TelecommInfoServiceApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // test 'IsInstanceOfType' TelecommInfoServiceApi
            Assert.IsInstanceOf(typeof(TelecommInfoServiceApi), instance, "instance is a TelecommInfoServiceApi");
        }

        
        /// <summary>
        /// Test GetRateCenterByAddress
        /// </summary>
        [Test]
        public void GetRateCenterByAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string address = null;
            //string country = null;
            //string areaCodeInfo = null;
            //string level = null;
            //var response = instance.GetRateCenterByAddress(addresscountryareaCodeInfolevel);
            //Assert.IsInstanceOf<RateCenterResponse> (response, "response is RateCenterResponse");
        }
        
        /// <summary>
        /// Test GetRateCenterByLocation
        /// </summary>
        [Test]
        public void GetRateCenterByLocationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string longitude = null;
            //string latitude = null;
            //string areaCodeInfo = null;
            //string level = null;
            //var response = instance.GetRateCenterByLocation(longitudelatitudeareaCodeInfolevel);
            //Assert.IsInstanceOf<RateCenterResponse> (response, "response is RateCenterResponse");
        }
        
    }

}
