/* 
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * OpenAPI spec version: 11.0.1
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
    ///  Class for testing AddressesAPIServiceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class AddressesAPIServiceApiTests
    {
        private AddressesAPIServiceApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AddressesAPIServiceApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AddressesAPIServiceApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // test 'IsInstanceOfType' AddressesAPIServiceApi
            Assert.IsInstanceOf(typeof(AddressesAPIServiceApi), instance, "instance is a AddressesAPIServiceApi");
        }

        
        /// <summary>
        /// Test GetAddressesByBoundaryName
        /// </summary>
        [Test]
        public void GetAddressesByBoundaryNameTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string country = null;
            //string areaName1 = null;
            //string areaName2 = null;
            //string areaName3 = null;
            //string areaName4 = null;
            //string postCode = null;
            //string maxCandidates = null;
            //string page = null;
            //var response = instance.GetAddressesByBoundaryName(country, areaName1, areaName2, areaName3, areaName4, postCode, maxCandidates, page);
            //Assert.IsInstanceOf<AddressesResponse> (response, "response is AddressesResponse");
        }
        
        /// <summary>
        /// Test GetAddressesCountByBoundary
        /// </summary>
        [Test]
        public void GetAddressesCountByBoundaryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AddressesByBoundaryRequest body = null;
            //var response = instance.GetAddressesCountByBoundary(body);
            //Assert.IsInstanceOf<AddressesCount> (response, "response is AddressesCount");
        }
        
        /// <summary>
        /// Test GetAddressesCountByBoundaryName
        /// </summary>
        [Test]
        public void GetAddressesCountByBoundaryNameTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string country = null;
            //string areaName1 = null;
            //string areaName2 = null;
            //string areaName3 = null;
            //string areaName4 = null;
            //string postCode = null;
            //var response = instance.GetAddressesCountByBoundaryName(country, areaName1, areaName2, areaName3, areaName4, postCode);
            //Assert.IsInstanceOf<AddressesCount> (response, "response is AddressesCount");
        }
        
        /// <summary>
        /// Test GetAddressesbyBoundary
        /// </summary>
        [Test]
        public void GetAddressesbyBoundaryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AddressesByBoundaryRequest body = null;
            //var response = instance.GetAddressesbyBoundary(body);
            //Assert.IsInstanceOf<AddressesResponse> (response, "response is AddressesResponse");
        }
        
    }

}
