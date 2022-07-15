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
    ///  Class for testing ZonesServiceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ZonesServiceApiTests
    {
        private ZonesServiceApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ZonesServiceApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ZonesServiceApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // test 'IsInstanceOfType' ZonesServiceApi
            Assert.IsInstanceOf(typeof(ZonesServiceApi), instance, "instance is a ZonesServiceApi");
        }

        
        /// <summary>
        /// Test GetBasicBoundaryByAddress
        /// </summary>
        [Test]
        public void GetBasicBoundaryByAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string address = null;
            //string country = null;
            //string distance = null;
            //string distanceUnit = null;
            //string resolution = null;
            //string responseSrs = null;
            //var response = instance.GetBasicBoundaryByAddress(addresscountrydistancedistanceUnitresolutionresponseSrs);
            //Assert.IsInstanceOf<BasicBoundary> (response, "response is BasicBoundary");
        }
        
        /// <summary>
        /// Test GetBasicBoundaryByLocation
        /// </summary>
        [Test]
        public void GetBasicBoundaryByLocationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string latitude = null;
            //string longitude = null;
            //string distance = null;
            //string distanceUnit = null;
            //string resolution = null;
            //string responseSrs = null;
            //string srsName = null;
            //var response = instance.GetBasicBoundaryByLocation(latitudelongitudedistancedistanceUnitresolutionresponseSrssrsName);
            //Assert.IsInstanceOf<BasicBoundary> (response, "response is BasicBoundary");
        }
        
        /// <summary>
        /// Test GetPOIBoundaryByAddress
        /// </summary>
        [Test]
        public void GetPOIBoundaryByAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string address = null;
            //string categoryCode = null;
            //string sicCode = null;
            //string naicsCode = null;
            //var response = instance.GetPOIBoundaryByAddress(addresscategoryCodesicCodenaicsCode);
            //Assert.IsInstanceOf<PoiBoundary> (response, "response is PoiBoundary");
        }
        
        /// <summary>
        /// Test GetPOIBoundaryByAddressBatch
        /// </summary>
        [Test]
        public void GetPOIBoundaryByAddressBatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //POIBoundaryAddressRequest pOIBoundaryAddressRequest = null;
            //var response = instance.GetPOIBoundaryByAddressBatch(pOIBoundaryAddressRequest);
            //Assert.IsInstanceOf<POIBoundaryResponse> (response, "response is POIBoundaryResponse");
        }
        
        /// <summary>
        /// Test GetPOIBoundaryByLocation
        /// </summary>
        [Test]
        public void GetPOIBoundaryByLocationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string latitude = null;
            //string longitude = null;
            //string categoryCode = null;
            //string sicCode = null;
            //string naicsCode = null;
            //var response = instance.GetPOIBoundaryByLocation(latitudelongitudecategoryCodesicCodenaicsCode);
            //Assert.IsInstanceOf<PoiBoundary> (response, "response is PoiBoundary");
        }
        
        /// <summary>
        /// Test GetPOIBoundaryByLocationBatch
        /// </summary>
        [Test]
        public void GetPOIBoundaryByLocationBatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //POIBoundaryLocationRequest pOIBoundaryLocationRequest = null;
            //var response = instance.GetPOIBoundaryByLocationBatch(pOIBoundaryLocationRequest);
            //Assert.IsInstanceOf<POIBoundaryResponse> (response, "response is POIBoundaryResponse");
        }
        
        /// <summary>
        /// Test GetTravelBoundaryByDistance
        /// </summary>
        [Test]
        public void GetTravelBoundaryByDistanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string point = null;
            //string address = null;
            //string costs = null;
            //string costUnit = null;
            //string db = null;
            //string country = null;
            //string maxOffroadDistance = null;
            //string maxOffroadDistanceUnit = null;
            //string destinationSrs = null;
            //string majorRoads = null;
            //string returnHoles = null;
            //string returnIslands = null;
            //string simplificationFactor = null;
            //string bandingStyle = null;
            //string historicTrafficTimeBucket = null;
            //string defaultAmbientSpeed = null;
            //string ambientSpeedUnit = null;
            //var response = instance.GetTravelBoundaryByDistance(pointaddresscostscostUnitdbcountrymaxOffroadDistancemaxOffroadDistanceUnitdestinationSrsmajorRoadsreturnHolesreturnIslandssimplificationFactorbandingStylehistoricTrafficTimeBucketdefaultAmbientSpeedambientSpeedUnit);
            //Assert.IsInstanceOf<TravelBoundaries> (response, "response is TravelBoundaries");
        }
        
        /// <summary>
        /// Test GetTravelBoundaryByTime
        /// </summary>
        [Test]
        public void GetTravelBoundaryByTimeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string point = null;
            //string address = null;
            //string costs = null;
            //string costUnit = null;
            //string db = null;
            //string country = null;
            //string maxOffroadDistance = null;
            //string maxOffroadDistanceUnit = null;
            //string destinationSrs = null;
            //string majorRoads = null;
            //string returnHoles = null;
            //string returnIslands = null;
            //string simplificationFactor = null;
            //string bandingStyle = null;
            //string historicTrafficTimeBucket = null;
            //string defaultAmbientSpeed = null;
            //string ambientSpeedUnit = null;
            //var response = instance.GetTravelBoundaryByTime(pointaddresscostscostUnitdbcountrymaxOffroadDistancemaxOffroadDistanceUnitdestinationSrsmajorRoadsreturnHolesreturnIslandssimplificationFactorbandingStylehistoricTrafficTimeBucketdefaultAmbientSpeedambientSpeedUnit);
            //Assert.IsInstanceOf<TravelBoundaries> (response, "response is TravelBoundaries");
        }
        
    }

}
