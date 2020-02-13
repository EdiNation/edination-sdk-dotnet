/*
 * EdiNationAPI.Standard
 *
 * This file was automatically generated for EdiNation by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Converters;
using EdiNationAPI.Standard;
using EdiNationAPI.Standard.Utilities;
using EdiNationAPI.Standard.Http.Request;
using EdiNationAPI.Standard.Http.Response;
using EdiNationAPI.Standard.Http.Client;
using EdiNationAPI.Standard.Exceptions;

namespace EdiNationAPI.Standard.Controllers
{
    public partial class EdiModelController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static EdiModelController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static EdiModelController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new EdiModelController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Uploads a model file to a subscription. It must be a valid DOT NET assembly.
        /// </summary>
        /// <param name="fileName">Required parameter: Upload File</param>
        /// <return>Returns the void response from the API call</return>
        public void Upload(FileStreamInfo fileName)
        {
            Task t = UploadAsync(fileName);
            APIHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// Uploads a model file to a subscription. It must be a valid DOT NET assembly.
        /// </summary>
        /// <param name="fileName">Required parameter: Upload File</param>
        /// <return>Returns the void response from the API call</return>
        public async Task UploadAsync(FileStreamInfo fileName)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/models");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" }
            };
            _headers.Add("Ocp-Apim-Subscription-Key", Configuration.OcpApimSubscriptionKey);

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "fileName", fileName)
            };
            //remove null parameters
            _fields = _fields.Where(kvp => kvp.Value != null).ToList();

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);

            //Error handling using HTTP status codes
            if (_response.StatusCode == 400)
                throw new ErrorDetailsException(@"Bad Request", _context);

            if (_response.StatusCode == 500)
                throw new ErrorDetailsException(@"Server Error", _context);

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

        }

        /// <summary>
        /// Retrieves all models for a subscription.
        /// </summary>
        /// <param name="system">Optional parameter: Whether to retrieve EdiNation's or custom uploaded models.</param>
        /// <return>Returns the List<Models.EdiModel> response from the API call</return>
        public List<Models.EdiModel> GetModels(bool? system = true)
        {
            Task<List<Models.EdiModel>> t = GetModelsAsync(system);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieves all models for a subscription.
        /// </summary>
        /// <param name="system">Optional parameter: Whether to retrieve EdiNation's or custom uploaded models.</param>
        /// <return>Returns the List<Models.EdiModel> response from the API call</return>
        public async Task<List<Models.EdiModel>> GetModelsAsync(bool? system = true)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/models");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "system", (null != system) ? system : true }
            },ArrayDeserializationFormat,ParameterSeparator);


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" }
            };
            _headers.Add("Ocp-Apim-Subscription-Key", Configuration.OcpApimSubscriptionKey);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);

            //Error handling using HTTP status codes
            if (_response.StatusCode == 400)
                throw new ErrorDetailsException(@"Bad Request", _context);

            if (_response.StatusCode == 500)
                throw new ErrorDetailsException(@"Server Error", _context);

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<List<Models.EdiModel>>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Retrieve a particular model file as a stream.
        /// </summary>
        /// <param name="id">Required parameter: The model name.</param>
        /// <param name="system">Optional parameter: Whether to search in EdiNation's or custom uploaded models.</param>
        /// <return>Returns the Stream response from the API call</return>
        public Stream GetModel(string id, bool? system = true)
        {
            Task<Stream> t = GetModelAsync(id, system);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve a particular model file as a stream.
        /// </summary>
        /// <param name="id">Required parameter: The model name.</param>
        /// <param name="system">Optional parameter: Whether to search in EdiNation's or custom uploaded models.</param>
        /// <return>Returns the Stream response from the API call</return>
        public async Task<Stream> GetModelAsync(string id, bool? system = true)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/models/{id}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "id", id }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "system", (null != system) ? system : true }
            },ArrayDeserializationFormat,ParameterSeparator);


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" }
            };
            _headers.Add("Ocp-Apim-Subscription-Key", Configuration.OcpApimSubscriptionKey);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers);

            //invoke request and get response
            HttpResponse _response = await ClientInstance.ExecuteAsBinaryAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);

            //Error handling using HTTP status codes
            if (_response.StatusCode == 400)
                throw new ErrorDetailsException(@"Bad Request", _context);

            if (_response.StatusCode == 500)
                throw new ErrorDetailsException(@"Server Error", _context);

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return _response.RawBody;
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Deletes a particular model from the custom models.
        /// </summary>
        /// <param name="id">Required parameter: The model name.</param>
        /// <return>Returns the void response from the API call</return>
        public void Delete(string id)
        {
            Task t = DeleteAsync(id);
            APIHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// Deletes a particular model from the custom models.
        /// </summary>
        /// <param name="id">Required parameter: The model name.</param>
        /// <return>Returns the void response from the API call</return>
        public async Task DeleteAsync(string id)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/models/{id}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "id", id }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" }
            };
            _headers.Add("Ocp-Apim-Subscription-Key", Configuration.OcpApimSubscriptionKey);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Delete(_queryUrl, _headers, null);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);

            //Error handling using HTTP status codes
            if (_response.StatusCode == 400)
                throw new ErrorDetailsException(@"Bad Request", _context);

            if (_response.StatusCode == 500)
                throw new ErrorDetailsException(@"Server Error", _context);

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

        }

    }
} 