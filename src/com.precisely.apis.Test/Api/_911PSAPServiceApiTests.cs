/* 
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * OpenAPI spec version: 9.5.0
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
    ///  Class for testing _911PSAPServiceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class _911PSAPServiceApiTests
    {
        private _911PSAPServiceApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new _911PSAPServiceApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of _911PSAPServiceApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // test 'IsInstanceOfType' _911PSAPServiceApi
            Assert.IsInstanceOf(typeof(_911PSAPServiceApi), instance, "instance is a _911PSAPServiceApi");
        }

        
        /// <summary>
        /// Test GetAHJPlusPSAPByAddress
        /// </summary>
        [Test]
        public void GetAHJPlusPSAPByAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string address = null;
            //var response = instance.GetAHJPlusPSAPByAddress(address);
            //Assert.IsInstanceOf<AHJPlusPSAPResponse> (response, "response is AHJPlusPSAPResponse");
        }
        
        /// <summary>
        /// Test GetAHJPlusPSAPByLocation
        /// </summary>
        [Test]
        public void GetAHJPlusPSAPByLocationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string longitude = null;
            //string latitude = null;
            //var response = instance.GetAHJPlusPSAPByLocation(longitude, latitude);
            //Assert.IsInstanceOf<AHJPlusPSAPResponse> (response, "response is AHJPlusPSAPResponse");
        }
        
        /// <summary>
        /// Test GetPSAPByAddress
        /// </summary>
        [Test]
        public void GetPSAPByAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string address = null;
            //var response = instance.GetPSAPByAddress(address);
            //Assert.IsInstanceOf<PSAPResponse> (response, "response is PSAPResponse");
        }
        
        /// <summary>
        /// Test GetPSAPByLocation
        /// </summary>
        [Test]
        public void GetPSAPByLocationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string longitude = null;
            //string latitude = null;
            //var response = instance.GetPSAPByLocation(longitude, latitude);
            //Assert.IsInstanceOf<PSAPResponse> (response, "response is PSAPResponse");
        }
        
    }

}
