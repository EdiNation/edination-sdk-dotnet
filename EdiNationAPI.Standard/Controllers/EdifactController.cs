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
    public partial class EdifactController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static EdifactController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static EdifactController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new EdifactController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Reads an EDIFACT file and returns its contents translated to an array of EdifactInterchange objects.
        /// </summary>
        /// <param name="fileName">Required parameter: Upload File</param>
        /// <param name="ignoreNullValues">Optional parameter: Whether to ignore all null values in the response. The default is false.</param>
        /// <param name="continueOnError">Optional parameter: Whether to continue reading if a corrupt interchange is encountered. The default is false.</param>
        /// <param name="charSet">Optional parameter: The encoding of the file contents. The default is utf-8. The available values are: unicodeFFFE, utf-32, utf-32BE, us-ascii, iso-8859-1, utf-7, utf-8, utf-16.</param>
        /// <param name="model">Optional parameter: The model to use. By default, the API will infer the model based on the transaction and version identifiers.</param>
        /// <param name="eancomS3">Optional parameter: The default syntax for EANCOM transactions. By default all EANCOM transactions will be translated and validated according to the rules of Syntax 4. Set this flag to true if you need Syntax 3 to be used.</param>
        /// <return>Returns the List<Models.EdifactInterchange> response from the API call</return>
        public List<Models.EdifactInterchange> Read(
                FileStreamInfo fileName,
                bool? ignoreNullValues = false,
                bool? continueOnError = false,
                string charSet = "utf-8",
                string model = null,
                bool? eancomS3 = false)
        {
            Task<List<Models.EdifactInterchange>> t = ReadAsync(fileName, ignoreNullValues, continueOnError, charSet, model, eancomS3);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Reads an EDIFACT file and returns its contents translated to an array of EdifactInterchange objects.
        /// </summary>
        /// <param name="fileName">Required parameter: Upload File</param>
        /// <param name="ignoreNullValues">Optional parameter: Whether to ignore all null values in the response. The default is false.</param>
        /// <param name="continueOnError">Optional parameter: Whether to continue reading if a corrupt interchange is encountered. The default is false.</param>
        /// <param name="charSet">Optional parameter: The encoding of the file contents. The default is utf-8. The available values are: unicodeFFFE, utf-32, utf-32BE, us-ascii, iso-8859-1, utf-7, utf-8, utf-16.</param>
        /// <param name="model">Optional parameter: The model to use. By default, the API will infer the model based on the transaction and version identifiers.</param>
        /// <param name="eancomS3">Optional parameter: The default syntax for EANCOM transactions. By default all EANCOM transactions will be translated and validated according to the rules of Syntax 4. Set this flag to true if you need Syntax 3 to be used.</param>
        /// <return>Returns the List<Models.EdifactInterchange> response from the API call</return>
        public async Task<List<Models.EdifactInterchange>> ReadAsync(
                FileStreamInfo fileName,
                bool? ignoreNullValues = false,
                bool? continueOnError = false,
                string charSet = "utf-8",
                string model = null,
                bool? eancomS3 = false)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/edifact/read");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "ignoreNullValues", (null != ignoreNullValues) ? ignoreNullValues : false },
                { "continueOnError", (null != continueOnError) ? continueOnError : false },
                { "charSet", (null != charSet) ? charSet : "utf-8" },
                { "model", model },
                { "eancomS3", (null != eancomS3) ? eancomS3 : false }
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
                return APIHelper.JsonDeserialize<List<Models.EdifactInterchange>>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Translates an EdifactInterchange object to a raw EDIFACT interchange and returns it as a stream.
        /// </summary>
        /// <param name="preserveWhitespace">Optional parameter: Whether to preserve blank data elements so the output contains multiple delimiters instead of omitting any excess delimiters. The default is false.</param>
        /// <param name="charSet">Optional parameter: The encoding of the file contents. The default is utf-8. The available values are: unicodeFFFE, utf-32, utf-32BE, us-ascii, iso-8859-1, utf-7, utf-8, utf-16.</param>
        /// <param name="postfix">Optional parameter: The postfix to be applied at the end of each segment, just after the segment separator. This is usually a carriage return (CR), line feed (LF) or both. By default, there is no postfix.</param>
        /// <param name="sameRepetionAndDataElement">Optional parameter: Sometimes the same delimiter is used to denote data element separator and repetition separator as in IATA transactions. By default, this is false.</param>
        /// <param name="eancomS3">Optional parameter: The default syntax for EANCOM transactions. By default all EANCOM transactions will be translated and validated according to the rules of Syntax 4. Set this flag to true if you need Syntax 3 to be used.</param>
        /// <param name="contentType">Optional parameter: Example: application/json</param>
        /// <param name="body">Optional parameter: The EdifactInterchange object to translate to raw EDIFACT.</param>
        /// <return>Returns the Stream response from the API call</return>
        public Stream Write(
                bool? preserveWhitespace = false,
                string charSet = "utf-8",
                string postfix = null,
                bool? sameRepetionAndDataElement = false,
                bool? eancomS3 = false,
                string contentType = "application/json",
                Models.EdifactInterchange body = null)
        {
            Task<Stream> t = WriteAsync(preserveWhitespace, charSet, postfix, sameRepetionAndDataElement, eancomS3, contentType, body);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Translates an EdifactInterchange object to a raw EDIFACT interchange and returns it as a stream.
        /// </summary>
        /// <param name="preserveWhitespace">Optional parameter: Whether to preserve blank data elements so the output contains multiple delimiters instead of omitting any excess delimiters. The default is false.</param>
        /// <param name="charSet">Optional parameter: The encoding of the file contents. The default is utf-8. The available values are: unicodeFFFE, utf-32, utf-32BE, us-ascii, iso-8859-1, utf-7, utf-8, utf-16.</param>
        /// <param name="postfix">Optional parameter: The postfix to be applied at the end of each segment, just after the segment separator. This is usually a carriage return (CR), line feed (LF) or both. By default, there is no postfix.</param>
        /// <param name="sameRepetionAndDataElement">Optional parameter: Sometimes the same delimiter is used to denote data element separator and repetition separator as in IATA transactions. By default, this is false.</param>
        /// <param name="eancomS3">Optional parameter: The default syntax for EANCOM transactions. By default all EANCOM transactions will be translated and validated according to the rules of Syntax 4. Set this flag to true if you need Syntax 3 to be used.</param>
        /// <param name="contentType">Optional parameter: Example: application/json</param>
        /// <param name="body">Optional parameter: The EdifactInterchange object to translate to raw EDIFACT.</param>
        /// <return>Returns the Stream response from the API call</return>
        public async Task<Stream> WriteAsync(
                bool? preserveWhitespace = false,
                string charSet = "utf-8",
                string postfix = null,
                bool? sameRepetionAndDataElement = false,
                bool? eancomS3 = false,
                string contentType = "application/json",
                Models.EdifactInterchange body = null)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/edifact/write");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "preserveWhitespace", (null != preserveWhitespace) ? preserveWhitespace : false },
                { "charSet", (null != charSet) ? charSet : "utf-8" },
                { "postfix", postfix },
                { "sameRepetionAndDataElement", (null != sameRepetionAndDataElement) ? sameRepetionAndDataElement : false },
                { "eancomS3", (null != eancomS3) ? eancomS3 : false }
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
        /// Validates an EdifactInterchange object according to the EDIFACT standard rules for each version and transaction.
        /// </summary>
        /// <param name="syntaxSet">Optional parameter: In case you need to validate against a syntax set, different than UNOA and UNOB, populate this filed with all of the allowed symbols, url-escaped.              All data elements with alpha (A) or alphanumeric (AN) data types are validated against a syntax set of allowed characters. The supported syntax sets are UNOA and UNOB. The validator infers the correct syntax set from EdifactInterchange.UNB.SYNTAXIDENTIFIER_1.SyntaxIdentifier_1. The symbols added to this field will override the corresponding sets in both UNOA and UNOB.</param>
        /// <param name="skipTrailer">Optional parameter: You are allowed to validate an EdifactInterchange with missing interchange, functional group or transaction trailers (UNZ, UNE, UNT). This is because these will be automatically applied during the Write oprtaion so you don't have to worry about counting the items. By default it is expected that all trailers are present when you validate the EdifactInterchange and by default, this is set to false. To skip all trailer validation, set this to true.</param>
        /// <param name="structureOnly">Optional parameter: This is equivalent to HIPAA Snip level 1, where only the structure and control segments are validated. By default, this is set to false, however if you want to not validate things such as data types, number of repeteitions or dates, set this to true.</param>
        /// <param name="decimalPoint">Optional parameter: This could be either point . (default) or comma ,.</param>
        /// <param name="eancomS3">Optional parameter: The default syntax for EANCOM transactions. By default all EANCOM transactions will be validated according to the rules of Syntax 4. Set this flag to true if you need Syntax 3 to be used.</param>
        /// <param name="contentType">Optional parameter: Example: application/json</param>
        /// <param name="body">Optional parameter: The EdifactInterchange object to validate.</param>
        /// <return>Returns the Models.OperationResult response from the API call</return>
        public Models.OperationResult Validate(
                string syntaxSet = null,
                bool? skipTrailer = false,
                bool? structureOnly = false,
                string decimalPoint = ".",
                bool? eancomS3 = false,
                string contentType = "application/json",
                Models.EdifactInterchange body = null)
        {
            Task<Models.OperationResult> t = ValidateAsync(syntaxSet, skipTrailer, structureOnly, decimalPoint, eancomS3, contentType, body);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Validates an EdifactInterchange object according to the EDIFACT standard rules for each version and transaction.
        /// </summary>
        /// <param name="syntaxSet">Optional parameter: In case you need to validate against a syntax set, different than UNOA and UNOB, populate this filed with all of the allowed symbols, url-escaped.              All data elements with alpha (A) or alphanumeric (AN) data types are validated against a syntax set of allowed characters. The supported syntax sets are UNOA and UNOB. The validator infers the correct syntax set from EdifactInterchange.UNB.SYNTAXIDENTIFIER_1.SyntaxIdentifier_1. The symbols added to this field will override the corresponding sets in both UNOA and UNOB.</param>
        /// <param name="skipTrailer">Optional parameter: You are allowed to validate an EdifactInterchange with missing interchange, functional group or transaction trailers (UNZ, UNE, UNT). This is because these will be automatically applied during the Write oprtaion so you don't have to worry about counting the items. By default it is expected that all trailers are present when you validate the EdifactInterchange and by default, this is set to false. To skip all trailer validation, set this to true.</param>
        /// <param name="structureOnly">Optional parameter: This is equivalent to HIPAA Snip level 1, where only the structure and control segments are validated. By default, this is set to false, however if you want to not validate things such as data types, number of repeteitions or dates, set this to true.</param>
        /// <param name="decimalPoint">Optional parameter: This could be either point . (default) or comma ,.</param>
        /// <param name="eancomS3">Optional parameter: The default syntax for EANCOM transactions. By default all EANCOM transactions will be validated according to the rules of Syntax 4. Set this flag to true if you need Syntax 3 to be used.</param>
        /// <param name="contentType">Optional parameter: Example: application/json</param>
        /// <param name="body">Optional parameter: The EdifactInterchange object to validate.</param>
        /// <return>Returns the Models.OperationResult response from the API call</return>
        public async Task<Models.OperationResult> ValidateAsync(
                string syntaxSet = null,
                bool? skipTrailer = false,
                bool? structureOnly = false,
                string decimalPoint = ".",
                bool? eancomS3 = false,
                string contentType = "application/json",
                Models.EdifactInterchange body = null)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/edifact/validate");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "syntaxSet", syntaxSet },
                { "skipTrailer", (null != skipTrailer) ? skipTrailer : false },
                { "structureOnly", (null != structureOnly) ? structureOnly : false },
                { "decimalPoint", (null != decimalPoint) ? decimalPoint : "." },
                { "eancomS3", (null != eancomS3) ? eancomS3 : false }
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
        /// Generates functional and/or technical CONTRL acknowledment(s) for the requested EdifactInterchange.
        /// </summary>
        /// <param name="syntaxSet">Optional parameter: In case you need to validate against a syntax set, different than UNOA and UNOB, populate this filed with all of the allowed symbols, url-escaped. All data elements with alpha (A) or alphanumeric (AN) data types are validated against a syntax set of allowed characters. The supported syntax sets are UNOA and UNOB. The validator infers the correct syntax set from EdifactInterchange.UNB.SYNTAXIDENTIFIER_1.SyntaxIdentifier_1. The symbols added to this field will override the corresponding sets in both UNOA and UNOB.</param>
        /// <param name="detectDuplicates">Optional parameter: If you need to detect duplicates as in functional groups or transactions with the same reference number, set this flag to true. The default is false.</param>
        /// <param name="tranRefNumber">Optional parameter: The default is 1. Set this to whatever the CONTRL UNH.MessageReferenceNumber_01 needs to be.</param>
        /// <param name="interchangeRefNumber">Optional parameter: The default is 1. Set this to whatever the CONTRL EdifactInterchange.UNB.InterchangeControlReference_5 needs to be.</param>
        /// <param name="ackForValidTrans">Optional parameter: The default is false. Set this to true if you need UCM loops included for all valid transaction as well. By default UCM loops are generated only for invalid transactions.</param>
        /// <param name="batchAcks">Optional parameter: The default is true. Set this to false if you need to generate separate EdifactInterchange for each acknowledgment. By default all acknowledgments are batched in the same EdifactInterchange.</param>
        /// <param name="technicalAck">Optional parameter: The default technical acknowledgment CONTRL is generated according to EdifactInterchange.UNB.AcknowledgementRequest_9. You can either enforce it to always generate technical CONTRLs or supress it to never generate any technical CONTRLs. This will override the flag in EdifactInterchange.UNB.AcknowledgementRequest_9.              The available values are: default, enforce, suppress.</param>
        /// <param name="eancomS3">Optional parameter: The default syntax for EANCOM transactions. By default all EANCOM transactions will be validated according to the rules of Syntax 4. Set this flag to true if you need Syntax 3 to be used.</param>
        /// <param name="contentType">Optional parameter: Example: application/json</param>
        /// <param name="body">Optional parameter: The EdifactInterchange object to acknowledge.</param>
        /// <return>Returns the List<Models.EdifactInterchange> response from the API call</return>
        public List<Models.EdifactInterchange> Ack(
                string syntaxSet = null,
                bool? detectDuplicates = false,
                int? tranRefNumber = 1,
                int? interchangeRefNumber = 1,
                bool? ackForValidTrans = false,
                bool? batchAcks = true,
                string technicalAck = null,
                bool? eancomS3 = false,
                string contentType = "application/json",
                Models.EdifactInterchange body = null)
        {
            Task<List<Models.EdifactInterchange>> t = AckAsync(syntaxSet, detectDuplicates, tranRefNumber, interchangeRefNumber, ackForValidTrans, batchAcks, technicalAck, eancomS3, contentType, body);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Generates functional and/or technical CONTRL acknowledment(s) for the requested EdifactInterchange.
        /// </summary>
        /// <param name="syntaxSet">Optional parameter: In case you need to validate against a syntax set, different than UNOA and UNOB, populate this filed with all of the allowed symbols, url-escaped. All data elements with alpha (A) or alphanumeric (AN) data types are validated against a syntax set of allowed characters. The supported syntax sets are UNOA and UNOB. The validator infers the correct syntax set from EdifactInterchange.UNB.SYNTAXIDENTIFIER_1.SyntaxIdentifier_1. The symbols added to this field will override the corresponding sets in both UNOA and UNOB.</param>
        /// <param name="detectDuplicates">Optional parameter: If you need to detect duplicates as in functional groups or transactions with the same reference number, set this flag to true. The default is false.</param>
        /// <param name="tranRefNumber">Optional parameter: The default is 1. Set this to whatever the CONTRL UNH.MessageReferenceNumber_01 needs to be.</param>
        /// <param name="interchangeRefNumber">Optional parameter: The default is 1. Set this to whatever the CONTRL EdifactInterchange.UNB.InterchangeControlReference_5 needs to be.</param>
        /// <param name="ackForValidTrans">Optional parameter: The default is false. Set this to true if you need UCM loops included for all valid transaction as well. By default UCM loops are generated only for invalid transactions.</param>
        /// <param name="batchAcks">Optional parameter: The default is true. Set this to false if you need to generate separate EdifactInterchange for each acknowledgment. By default all acknowledgments are batched in the same EdifactInterchange.</param>
        /// <param name="technicalAck">Optional parameter: The default technical acknowledgment CONTRL is generated according to EdifactInterchange.UNB.AcknowledgementRequest_9. You can either enforce it to always generate technical CONTRLs or supress it to never generate any technical CONTRLs. This will override the flag in EdifactInterchange.UNB.AcknowledgementRequest_9.              The available values are: default, enforce, suppress.</param>
        /// <param name="eancomS3">Optional parameter: The default syntax for EANCOM transactions. By default all EANCOM transactions will be validated according to the rules of Syntax 4. Set this flag to true if you need Syntax 3 to be used.</param>
        /// <param name="contentType">Optional parameter: Example: application/json</param>
        /// <param name="body">Optional parameter: The EdifactInterchange object to acknowledge.</param>
        /// <return>Returns the List<Models.EdifactInterchange> response from the API call</return>
        public async Task<List<Models.EdifactInterchange>> AckAsync(
                string syntaxSet = null,
                bool? detectDuplicates = false,
                int? tranRefNumber = 1,
                int? interchangeRefNumber = 1,
                bool? ackForValidTrans = false,
                bool? batchAcks = true,
                string technicalAck = null,
                bool? eancomS3 = false,
                string contentType = "application/json",
                Models.EdifactInterchange body = null)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/edifact/ack");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "syntaxSet", syntaxSet },
                { "detectDuplicates", (null != detectDuplicates) ? detectDuplicates : false },
                { "tranRefNumber", (null != tranRefNumber) ? tranRefNumber : 1 },
                { "interchangeRefNumber", (null != interchangeRefNumber) ? interchangeRefNumber : 1 },
                { "ackForValidTrans", (null != ackForValidTrans) ? ackForValidTrans : false },
                { "batchAcks", (null != batchAcks) ? batchAcks : true },
                { "technicalAck", technicalAck },
                { "eancomS3", (null != eancomS3) ? eancomS3 : false }
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
                return APIHelper.JsonDeserialize<List<Models.EdifactInterchange>>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 