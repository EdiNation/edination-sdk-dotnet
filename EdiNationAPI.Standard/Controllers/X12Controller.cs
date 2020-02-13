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
    public partial class X12Controller: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static X12Controller instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static X12Controller Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new X12Controller();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Reads an X12 file and returns its contents translated to an array of X12Interchange objects.
        /// </summary>
        /// <param name="fileName">Required parameter: Upload File</param>
        /// <param name="ignoreNullValues">Optional parameter: Whether to ignore all null values in the response. The default is false.</param>
        /// <param name="continueOnError">Optional parameter: Whether to continue reading if a corrupt interchange is encountered. The default is false.</param>
        /// <param name="charSet">Optional parameter: The encoding of the file contents. The default is utf-8. The available values are: unicodeFFFE, utf-32, utf-32BE, us-ascii, iso-8859-1, utf-7, utf-8, utf-16.</param>
        /// <param name="model">Optional parameter: The model to use. By default, the API will infer the model based on the transaction and version identifiers.</param>
        /// <return>Returns the List<Models.X12Interchange> response from the API call</return>
        public List<Models.X12Interchange> Read(
                FileStreamInfo fileName,
                bool? ignoreNullValues = false,
                bool? continueOnError = false,
                string charSet = "utf-8",
                string model = null)
        {
            Task<List<Models.X12Interchange>> t = ReadAsync(fileName, ignoreNullValues, continueOnError, charSet, model);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Reads an X12 file and returns its contents translated to an array of X12Interchange objects.
        /// </summary>
        /// <param name="fileName">Required parameter: Upload File</param>
        /// <param name="ignoreNullValues">Optional parameter: Whether to ignore all null values in the response. The default is false.</param>
        /// <param name="continueOnError">Optional parameter: Whether to continue reading if a corrupt interchange is encountered. The default is false.</param>
        /// <param name="charSet">Optional parameter: The encoding of the file contents. The default is utf-8. The available values are: unicodeFFFE, utf-32, utf-32BE, us-ascii, iso-8859-1, utf-7, utf-8, utf-16.</param>
        /// <param name="model">Optional parameter: The model to use. By default, the API will infer the model based on the transaction and version identifiers.</param>
        /// <return>Returns the List<Models.X12Interchange> response from the API call</return>
        public async Task<List<Models.X12Interchange>> ReadAsync(
                FileStreamInfo fileName,
                bool? ignoreNullValues = false,
                bool? continueOnError = false,
                string charSet = "utf-8",
                string model = null)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/x12/read");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "ignoreNullValues", (null != ignoreNullValues) ? ignoreNullValues : false },
                { "continueOnError", (null != continueOnError) ? continueOnError : false },
                { "charSet", (null != charSet) ? charSet : "utf-8" },
                { "model", model }
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

            try
            {
                return APIHelper.JsonDeserialize<List<Models.X12Interchange>>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Translates an X12Interchange object to a raw X12 interchange and returns it as a stream.
        /// </summary>
        /// <param name="preserveWhitespace">Optional parameter: Whether to preserve blank data elements so the output contains multiple delimiters instead of omitting any excess delimiters. The default is false.</param>
        /// <param name="charSet">Optional parameter: The encoding of the file contents. The default is utf-8. The available values are: unicodeFFFE, utf-32, utf-32BE, us-ascii, iso-8859-1, utf-7, utf-8, utf-16.</param>
        /// <param name="postfix">Optional parameter: The postfix to be applied at the end of each segment, just after the segment separator. This is usually a carriage return (CR), line feed (LF) or both. By default, there is no postfix.</param>
        /// <param name="contentType">Optional parameter: Example: application/json</param>
        /// <param name="body">Optional parameter: The X12Interchange object to translate to raw X12.</param>
        /// <return>Returns the Stream response from the API call</return>
        public Stream Write(
                bool? preserveWhitespace = false,
                string charSet = "utf-8",
                string postfix = null,
                string contentType = "application/json",
                Models.X12Interchange body = null)
        {
            Task<Stream> t = WriteAsync(preserveWhitespace, charSet, postfix, contentType, body);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Translates an X12Interchange object to a raw X12 interchange and returns it as a stream.
        /// </summary>
        /// <param name="preserveWhitespace">Optional parameter: Whether to preserve blank data elements so the output contains multiple delimiters instead of omitting any excess delimiters. The default is false.</param>
        /// <param name="charSet">Optional parameter: The encoding of the file contents. The default is utf-8. The available values are: unicodeFFFE, utf-32, utf-32BE, us-ascii, iso-8859-1, utf-7, utf-8, utf-16.</param>
        /// <param name="postfix">Optional parameter: The postfix to be applied at the end of each segment, just after the segment separator. This is usually a carriage return (CR), line feed (LF) or both. By default, there is no postfix.</param>
        /// <param name="contentType">Optional parameter: Example: application/json</param>
        /// <param name="body">Optional parameter: The X12Interchange object to translate to raw X12.</param>
        /// <return>Returns the Stream response from the API call</return>
        public async Task<Stream> WriteAsync(
                bool? preserveWhitespace = false,
                string charSet = "utf-8",
                string postfix = null,
                string contentType = "application/json",
                Models.X12Interchange body = null)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/x12/write");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "preserveWhitespace", (null != preserveWhitespace) ? preserveWhitespace : false },
                { "charSet", (null != charSet) ? charSet : "utf-8" },
                { "postfix", postfix }
            },ArrayDeserializationFormat,ParameterSeparator);


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "Content-Type", (null != contentType) ? contentType : "application/json" }
            };
            _headers.Add("Ocp-Apim-Subscription-Key", Configuration.OcpApimSubscriptionKey);

            //append body params
            var _body = APIHelper.JsonSerialize(body);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.PostBody(_queryUrl, _headers, _body);

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
        /// Validates an X12Interchange object according to the X12 standard rules for each version and transaction.
        /// </summary>
        /// <param name="basicSyntax">Optional parameter: All data elements with alpha (A) or alphanumeric (AN) data types are validated against a syntax set of allowed characters. The default syntax set is the Extended, hence the default for this parameter is false. By setting this to true, validation will use the Basic syntax set.</param>
        /// <param name="syntaxSet">Optional parameter: In case you need to validate against a syntax set, different than Basic and Extended, populate this filed with all of the allowed symbols, url-escaped.</param>
        /// <param name="skipTrailer">Optional parameter: You are allowed to validate an X12Interchange with missing interchange, functional group or transaction trailers (IEA, GE, SE). This is because these will be automatically applied during the Write oprtaion so you don't have to worry about counting the items. By default it is expected that all trailers are present when you validate the X12Interchange and by default, this is set to false. To skip all trailer validation, set this to true.</param>
        /// <param name="structureOnly">Optional parameter: This is equivalent to HIPAA Snip level 1, where only the structure and control segments are validated. By default, this is set to false, however if you want to not validate things such as data types, number of repeteitions or dates, set this to true.</param>
        /// <param name="contentType">Optional parameter: Example: application/json</param>
        /// <param name="body">Optional parameter: The X12Interchange object to validate.</param>
        /// <return>Returns the Models.OperationResult response from the API call</return>
        public Models.OperationResult Validate(
                bool? basicSyntax = false,
                string syntaxSet = null,
                bool? skipTrailer = false,
                bool? structureOnly = false,
                string contentType = "application/json",
                Models.X12Interchange body = null)
        {
            Task<Models.OperationResult> t = ValidateAsync(basicSyntax, syntaxSet, skipTrailer, structureOnly, contentType, body);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Validates an X12Interchange object according to the X12 standard rules for each version and transaction.
        /// </summary>
        /// <param name="basicSyntax">Optional parameter: All data elements with alpha (A) or alphanumeric (AN) data types are validated against a syntax set of allowed characters. The default syntax set is the Extended, hence the default for this parameter is false. By setting this to true, validation will use the Basic syntax set.</param>
        /// <param name="syntaxSet">Optional parameter: In case you need to validate against a syntax set, different than Basic and Extended, populate this filed with all of the allowed symbols, url-escaped.</param>
        /// <param name="skipTrailer">Optional parameter: You are allowed to validate an X12Interchange with missing interchange, functional group or transaction trailers (IEA, GE, SE). This is because these will be automatically applied during the Write oprtaion so you don't have to worry about counting the items. By default it is expected that all trailers are present when you validate the X12Interchange and by default, this is set to false. To skip all trailer validation, set this to true.</param>
        /// <param name="structureOnly">Optional parameter: This is equivalent to HIPAA Snip level 1, where only the structure and control segments are validated. By default, this is set to false, however if you want to not validate things such as data types, number of repeteitions or dates, set this to true.</param>
        /// <param name="contentType">Optional parameter: Example: application/json</param>
        /// <param name="body">Optional parameter: The X12Interchange object to validate.</param>
        /// <return>Returns the Models.OperationResult response from the API call</return>
        public async Task<Models.OperationResult> ValidateAsync(
                bool? basicSyntax = false,
                string syntaxSet = null,
                bool? skipTrailer = false,
                bool? structureOnly = false,
                string contentType = "application/json",
                Models.X12Interchange body = null)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/x12/validate");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "basicSyntax", (null != basicSyntax) ? basicSyntax : false },
                { "syntaxSet", syntaxSet },
                { "skipTrailer", (null != skipTrailer) ? skipTrailer : false },
                { "structureOnly", (null != structureOnly) ? structureOnly : false }
            },ArrayDeserializationFormat,ParameterSeparator);


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" },
                { "Content-Type", (null != contentType) ? contentType : "application/json" }
            };
            _headers.Add("Ocp-Apim-Subscription-Key", Configuration.OcpApimSubscriptionKey);

            //append body params
            var _body = APIHelper.JsonSerialize(body);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.PostBody(_queryUrl, _headers, _body);

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
                return APIHelper.JsonDeserialize<Models.OperationResult>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Generates functional/implementation and/or technical acknowledment(s) for the requested X12Interchange.
        /// </summary>
        /// <param name="basicSyntax">Optional parameter: All data elements with alpha (A) or alphanumeric (AN) data types are validated against a syntax set of allowed characters. The default syntax set is the Extended, hence the default for this parameter is false. By setting this to true, validation will use the Basic syntax set.</param>
        /// <param name="syntaxSet">Optional parameter: In case you need to validate against a syntax set, different than Basic and Extended, populate this filed with all of the allowed symbols, url-escaped.</param>
        /// <param name="detectDuplicates">Optional parameter: If you need to detect duplicates as in functional groups or transactions with the same reference number, set this flag to true. The default is false.</param>
        /// <param name="tranRefNumber">Optional parameter: The default is 1. Set this to whatever the 997 or 999 X12Interchange.ST.TransactionSetControlNumber_02 needs to be. In case there are multiple acknowledgments (for multiple functional groups), this will be starting reference number and every subsequent acknowledgment will have the previous reference number incremented with 1.</param>
        /// <param name="interchangeRefNumber">Optional parameter: The default is 1. Set this to whatever the 997 or 999 X12Interchange.ISA.InterchangeControlNumber_13 needs to be.</param>
        /// <param name="ackForValidTrans">Optional parameter: The default is false. Set this to true if you need AK2 loops included for all valid transaction as well. By default AK2 loops are generated only for invalid transactions.</param>
        /// <param name="batchAcks">Optional parameter: The default is true. Set this to false if you need to generate separate X12Interchange for each acknowledgment. By default all acknowledgments are batched in the same X12Interchange.</param>
        /// <param name="technicalAck">Optional parameter: The default technical acknowledgment TA1 is generated according to X12Interchange.ISA.AcknowledgementRequested_14. You can either enforce it to always generate TA1s or supress it to never generate any TA1s. This will override the flag in X12Interchange.ISA.AcknowledgementRequested_14.              The available values are: default, enforce, suppress.</param>
        /// <param name="ack">Optional parameter: The default value is 997. The type of acknowledgment being generated. Set this to 999 if you need to generate an implementation instead of functional acknowledgment. The available values are: 997, 999.</param>
        /// <param name="ak901isP">Optional parameter: The value of the AK9's first element. By default it is "E". Set this to true if you want this value to be "P" instead.</param>
        /// <param name="contentType">Optional parameter: Example: application/json</param>
        /// <param name="body">Optional parameter: The X12Interchange object to acknowledge.</param>
        /// <return>Returns the List<Models.X12Interchange> response from the API call</return>
        public List<Models.X12Interchange> Ack(
                bool? basicSyntax = false,
                string syntaxSet = null,
                bool? detectDuplicates = false,
                int? tranRefNumber = 1,
                int? interchangeRefNumber = 1,
                bool? ackForValidTrans = false,
                bool? batchAcks = true,
                string technicalAck = null,
                string ack = "997",
                bool? ak901isP = false,
                string contentType = "application/json",
                Models.X12Interchange body = null)
        {
            Task<List<Models.X12Interchange>> t = AckAsync(basicSyntax, syntaxSet, detectDuplicates, tranRefNumber, interchangeRefNumber, ackForValidTrans, batchAcks, technicalAck, ack, ak901isP, contentType, body);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Generates functional/implementation and/or technical acknowledment(s) for the requested X12Interchange.
        /// </summary>
        /// <param name="basicSyntax">Optional parameter: All data elements with alpha (A) or alphanumeric (AN) data types are validated against a syntax set of allowed characters. The default syntax set is the Extended, hence the default for this parameter is false. By setting this to true, validation will use the Basic syntax set.</param>
        /// <param name="syntaxSet">Optional parameter: In case you need to validate against a syntax set, different than Basic and Extended, populate this filed with all of the allowed symbols, url-escaped.</param>
        /// <param name="detectDuplicates">Optional parameter: If you need to detect duplicates as in functional groups or transactions with the same reference number, set this flag to true. The default is false.</param>
        /// <param name="tranRefNumber">Optional parameter: The default is 1. Set this to whatever the 997 or 999 X12Interchange.ST.TransactionSetControlNumber_02 needs to be. In case there are multiple acknowledgments (for multiple functional groups), this will be starting reference number and every subsequent acknowledgment will have the previous reference number incremented with 1.</param>
        /// <param name="interchangeRefNumber">Optional parameter: The default is 1. Set this to whatever the 997 or 999 X12Interchange.ISA.InterchangeControlNumber_13 needs to be.</param>
        /// <param name="ackForValidTrans">Optional parameter: The default is false. Set this to true if you need AK2 loops included for all valid transaction as well. By default AK2 loops are generated only for invalid transactions.</param>
        /// <param name="batchAcks">Optional parameter: The default is true. Set this to false if you need to generate separate X12Interchange for each acknowledgment. By default all acknowledgments are batched in the same X12Interchange.</param>
        /// <param name="technicalAck">Optional parameter: The default technical acknowledgment TA1 is generated according to X12Interchange.ISA.AcknowledgementRequested_14. You can either enforce it to always generate TA1s or supress it to never generate any TA1s. This will override the flag in X12Interchange.ISA.AcknowledgementRequested_14.              The available values are: default, enforce, suppress.</param>
        /// <param name="ack">Optional parameter: The default value is 997. The type of acknowledgment being generated. Set this to 999 if you need to generate an implementation instead of functional acknowledgment. The available values are: 997, 999.</param>
        /// <param name="ak901isP">Optional parameter: The value of the AK9's first element. By default it is "E". Set this to true if you want this value to be "P" instead.</param>
        /// <param name="contentType">Optional parameter: Example: application/json</param>
        /// <param name="body">Optional parameter: The X12Interchange object to acknowledge.</param>
        /// <return>Returns the List<Models.X12Interchange> response from the API call</return>
        public async Task<List<Models.X12Interchange>> AckAsync(
                bool? basicSyntax = false,
                string syntaxSet = null,
                bool? detectDuplicates = false,
                int? tranRefNumber = 1,
                int? interchangeRefNumber = 1,
                bool? ackForValidTrans = false,
                bool? batchAcks = true,
                string technicalAck = null,
                string ack = "997",
                bool? ak901isP = false,
                string contentType = "application/json",
                Models.X12Interchange body = null)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/x12/ack");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "basicSyntax", (null != basicSyntax) ? basicSyntax : false },
                { "syntaxSet", syntaxSet },
                { "detectDuplicates", (null != detectDuplicates) ? detectDuplicates : false },
                { "tranRefNumber", (null != tranRefNumber) ? tranRefNumber : 1 },
                { "interchangeRefNumber", (null != interchangeRefNumber) ? interchangeRefNumber : 1 },
                { "ackForValidTrans", (null != ackForValidTrans) ? ackForValidTrans : false },
                { "batchAcks", (null != batchAcks) ? batchAcks : true },
                { "technicalAck", technicalAck },
                { "ack", (null != ack) ? ack : "997" },
                { "ak901isP", (null != ak901isP) ? ak901isP : false }
            },ArrayDeserializationFormat,ParameterSeparator);


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" },
                { "Content-Type", (null != contentType) ? contentType : "application/json" }
            };
            _headers.Add("Ocp-Apim-Subscription-Key", Configuration.OcpApimSubscriptionKey);

            //append body params
            var _body = APIHelper.JsonSerialize(body);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.PostBody(_queryUrl, _headers, _body);

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
                return APIHelper.JsonDeserialize<List<Models.X12Interchange>>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 