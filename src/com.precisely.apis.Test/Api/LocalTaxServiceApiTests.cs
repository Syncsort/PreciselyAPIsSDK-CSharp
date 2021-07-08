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
    ///  Class for testing LocalTaxServiceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class LocalTaxServiceApiTests
    {
        private LocalTaxServiceApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new LocalTaxServiceApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of LocalTaxServiceApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // test 'IsInstanceOfType' LocalTaxServiceApi
            Assert.IsInstanceOf(typeof(LocalTaxServiceApi), instance, "instance is a LocalTaxServiceApi");
        }

        
        /// <summary>
        /// Test GetBatchTaxByAddress
        /// </summary>
        [Test]
        public void GetBatchTaxByAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string taxRateTypeId = null;
            //TaxAddressRequest body = null;
            //var response = instance.GetBatchTaxByAddress(taxRateTypeId, body);
            //Assert.IsInstanceOf<TaxResponses> (response, "response is TaxResponses");
        }
        
        /// <summary>
        /// Test GetBatchTaxByLocation
        /// </summary>
        [Test]
        public void GetBatchTaxByLocationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string taxRateTypeId = null;
            //TaxLocationRequest body = null;
            //var response = instance.GetBatchTaxByLocation(taxRateTypeId, body);
            //Assert.IsInstanceOf<TaxLocationResponses> (response, "response is TaxLocationResponses");
        }
        
        /// <summary>
        /// Test GetBatchTaxRateByAddress
        /// </summary>
        [Test]
        public void GetBatchTaxRateByAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string taxRateTypeId = null;
            //TaxRateAddressRequest body = null;
            //var response = instance.GetBatchTaxRateByAddress(taxRateTypeId, body);
            //Assert.IsInstanceOf<TaxRateResponses> (response, "response is TaxRateResponses");
        }
        
        /// <summary>
        /// Test GetBatchTaxRateByLocation
        /// </summary>
        [Test]
        public void GetBatchTaxRateByLocationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string taxRateTypeId = null;
            //TaxRateLocationRequest body = null;
            //var response = instance.GetBatchTaxRateByLocation(taxRateTypeId, body);
            //Assert.IsInstanceOf<TaxRateLocationResponses> (response, "response is TaxRateLocationResponses");
        }
        
        /// <summary>
        /// Test GetIPDTaxByAddress
        /// </summary>
        [Test]
        public void GetIPDTaxByAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string address = null;
            //string returnLatLongFields = null;
            //string latLongFormat = null;
            //var response = instance.GetIPDTaxByAddress(address, returnLatLongFields, latLongFormat);
            //Assert.IsInstanceOf<TaxDistrictResponse> (response, "response is TaxDistrictResponse");
        }
        
        /// <summary>
        /// Test GetIPDTaxByAddressBatch
        /// </summary>
        [Test]
        public void GetIPDTaxByAddressBatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //IPDTaxByAddressBatchRequest body = null;
            //var response = instance.GetIPDTaxByAddressBatch(body);
            //Assert.IsInstanceOf<TaxDistrictResponseList> (response, "response is TaxDistrictResponseList");
        }
        
        /// <summary>
        /// Test GetSpecificTaxByAddress
        /// </summary>
        [Test]
        public void GetSpecificTaxByAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string taxRateTypeId = null;
            //string address = null;
            //string purchaseAmount = null;
            //var response = instance.GetSpecificTaxByAddress(taxRateTypeId, address, purchaseAmount);
            //Assert.IsInstanceOf<TaxResponse> (response, "response is TaxResponse");
        }
        
        /// <summary>
        /// Test GetSpecificTaxByLocation
        /// </summary>
        [Test]
        public void GetSpecificTaxByLocationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string taxRateTypeId = null;
            //string latitude = null;
            //string longitude = null;
            //string purchaseAmount = null;
            //var response = instance.GetSpecificTaxByLocation(taxRateTypeId, latitude, longitude, purchaseAmount);
            //Assert.IsInstanceOf<TaxResponse> (response, "response is TaxResponse");
        }
        
        /// <summary>
        /// Test GetSpecificTaxRateByAddress
        /// </summary>
        [Test]
        public void GetSpecificTaxRateByAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string taxRateTypeId = null;
            //string address = null;
            //var response = instance.GetSpecificTaxRateByAddress(taxRateTypeId, address);
            //Assert.IsInstanceOf<TaxRateResponse> (response, "response is TaxRateResponse");
        }
        
        /// <summary>
        /// Test GetSpecificTaxRateByLocation
        /// </summary>
        [Test]
        public void GetSpecificTaxRateByLocationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string taxRateTypeId = null;
            //string latitude = null;
            //string longitude = null;
            //var response = instance.GetSpecificTaxRateByLocation(taxRateTypeId, latitude, longitude);
            //Assert.IsInstanceOf<TaxRateResponse> (response, "response is TaxRateResponse");
        }
        
    }

}
