/*
 * EdiNationAPI.Standard
 *
 * This file was automatically generated for EdiNation by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using EdiNationAPI.Standard.Http.Client;

using EdiNationAPI.Standard.Models;
using EdiNationAPI.Standard;
using EdiNationAPI.Standard.Utilities;


namespace EdiNationAPI.Standard.Exceptions
{
    public class ErrorDetailsException : APIException 
    {
        // These fields hold the values for the public properties.
        private int? code;
        private List<string> details;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Code")]
        public int? Code 
        { 
            get 
            {
                return this.code; 
            } 
            private set 
            {
                this.code = value;
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Details")]
        public List<string> Details 
        { 
            get 
            {
                return this.details; 
            } 
            private set 
            {
                this.details = value;
            }
        }

        /// <summary>
        /// Initialization constructor
        /// </summary>
        /// <param name="reason"> The reason for throwing exception </param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects </param>
        public ErrorDetailsException(string reason, HttpContext context)
            : base(reason, context)
        {
        }
    }
} 