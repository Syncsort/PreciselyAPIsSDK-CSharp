/* 
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * OpenAPI spec version: 9.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
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
            //var response = instance.GetRateCenterByAddress(address, country, areaCodeInfo, level);
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
            //var response = instance.GetRateCenterByLocation(longitude, latitude, areaCodeInfo, level);
            //Assert.IsInstanceOf<RateCenterResponse> (response, "response is RateCenterResponse");
        }
        
    }

}