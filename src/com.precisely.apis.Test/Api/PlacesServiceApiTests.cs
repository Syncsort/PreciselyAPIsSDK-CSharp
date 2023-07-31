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
    ///  Class for testing PlacesServiceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class PlacesServiceApiTests
    {
        private PlacesServiceApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PlacesServiceApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PlacesServiceApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // test 'IsInstanceOfType' PlacesServiceApi
            Assert.IsInstanceOf(typeof(PlacesServiceApi), instance, "instance is a PlacesServiceApi");
        }

        
        /// <summary>
        /// Test GetCategoryCodeMetadata
        /// </summary>
        [Test]
        public void GetCategoryCodeMetadataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string categoryCode = null;
            //string level = null;
            //var response = instance.GetCategoryCodeMetadata(categoryCodelevel);
            //Assert.IsInstanceOf<MetadataResponse> (response, "response is MetadataResponse");
        }
        
        /// <summary>
        /// Test GetPOIById
        /// </summary>
        [Test]
        public void GetPOIByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetPOIById(id);
            //Assert.IsInstanceOf<Poi> (response, "response is Poi");
        }
        
        /// <summary>
        /// Test GetPOIsByAddress
        /// </summary>
        [Test]
        public void GetPOIsByAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string address = null;
            //string country = null;
            //string name = null;
            //string type = null;
            //string categoryCode = null;
            //string sicCode = null;
            //string maxCandidates = null;
            //string searchRadius = null;
            //string searchRadiusUnit = null;
            //string travelTime = null;
            //string travelTimeUnit = null;
            //string travelDistance = null;
            //string travelDistanceUnit = null;
            //string travelMode = null;
            //string sortBy = null;
            //string fuzzyOnName = null;
            //string page = null;
            //string matchMode = null;
            //string specificMatchOn = null;
            //var response = instance.GetPOIsByAddress(addresscountrynametypecategoryCodesicCodemaxCandidatessearchRadiussearchRadiusUnittravelTimetravelTimeUnittravelDistancetravelDistanceUnittravelModesortByfuzzyOnNamepagematchModespecificMatchOn);
            //Assert.IsInstanceOf<PlacesResponse> (response, "response is PlacesResponse");
        }
        
        /// <summary>
        /// Test GetPOIsByArea
        /// </summary>
        [Test]
        public void GetPOIsByAreaTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string areaName1 = null;
            //string areaName3 = null;
            //string postcode1 = null;
            //string postcode2 = null;
            //string country = null;
            //string name = null;
            //string type = null;
            //string categoryCode = null;
            //string sicCode = null;
            //string maxCandidates = null;
            //string fuzzyOnName = null;
            //string page = null;
            //string matchMode = null;
            //string specificMatchOn = null;
            //var response = instance.GetPOIsByArea(areaName1areaName3postcode1postcode2countrynametypecategoryCodesicCodemaxCandidatesfuzzyOnNamepagematchModespecificMatchOn);
            //Assert.IsInstanceOf<PlacesResponse> (response, "response is PlacesResponse");
        }
        
        /// <summary>
        /// Test GetPOIsByGeometry
        /// </summary>
        [Test]
        public void GetPOIsByGeometryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //POIByGeometryRequest pOIByGeometryRequest = null;
            //var response = instance.GetPOIsByGeometry(pOIByGeometryRequest);
            //Assert.IsInstanceOf<PlacesResponse> (response, "response is PlacesResponse");
        }
        
        /// <summary>
        /// Test GetPOIsByLocation
        /// </summary>
        [Test]
        public void GetPOIsByLocationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string longitude = null;
            //string latitude = null;
            //string name = null;
            //string type = null;
            //string categoryCode = null;
            //string sicCode = null;
            //string maxCandidates = null;
            //string searchRadius = null;
            //string searchRadiusUnit = null;
            //string travelTime = null;
            //string travelTimeUnit = null;
            //string travelDistance = null;
            //string travelDistanceUnit = null;
            //string travelMode = null;
            //string sortBy = null;
            //string fuzzyOnName = null;
            //string page = null;
            //string matchMode = null;
            //string specificMatchOn = null;
            //var response = instance.GetPOIsByLocation(longitudelatitudenametypecategoryCodesicCodemaxCandidatessearchRadiussearchRadiusUnittravelTimetravelTimeUnittravelDistancetravelDistanceUnittravelModesortByfuzzyOnNamepagematchModespecificMatchOn);
            //Assert.IsInstanceOf<PlacesResponse> (response, "response is PlacesResponse");
        }
        
        /// <summary>
        /// Test GetPOIsCount
        /// </summary>
        [Test]
        public void GetPOIsCountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string contentType = null;
            //PoiCountRequest poiCountRequest = null;
            //var response = instance.GetPOIsCount(contentTypepoiCountRequest);
            //Assert.IsInstanceOf<PoiCount> (response, "response is PoiCount");
        }
        
        /// <summary>
        /// Test GetSICMetadata
        /// </summary>
        [Test]
        public void GetSICMetadataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string sicCode = null;
            //string level = null;
            //var response = instance.GetSICMetadata(sicCodelevel);
            //Assert.IsInstanceOf<MetadataResponse> (response, "response is MetadataResponse");
        }
        
        /// <summary>
        /// Test PoisAutocomplete
        /// </summary>
        [Test]
        public void PoisAutocompleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xForwardedFor = null;
            //string longitude = null;
            //string latitude = null;
            //string searchText = null;
            //string searchOnNameOnly = null;
            //string searchRadius = null;
            //string searchRadiusUnit = null;
            //string travelTime = null;
            //string travelTimeUnit = null;
            //string travelDistance = null;
            //string travelDistanceUnit = null;
            //string travelMode = null;
            //string country = null;
            //string areaName1 = null;
            //string areaName3 = null;
            //string postcode1 = null;
            //string postcode2 = null;
            //string ipAddress = null;
            //string autoDetectLocation = null;
            //string type = null;
            //string categoryCode = null;
            //string sicCode = null;
            //string maxCandidates = null;
            //string sortBy = null;
            //string matchMode = null;
            //string specificMatchOn = null;
            //var response = instance.PoisAutocomplete(xForwardedForlongitudelatitudesearchTextsearchOnNameOnlysearchRadiussearchRadiusUnittravelTimetravelTimeUnittravelDistancetravelDistanceUnittravelModecountryareaName1areaName3postcode1postcode2ipAddressautoDetectLocationtypecategoryCodesicCodemaxCandidatessortBymatchModespecificMatchOn);
            //Assert.IsInstanceOf<PlacesResponse> (response, "response is PlacesResponse");
        }
        
    }

}
