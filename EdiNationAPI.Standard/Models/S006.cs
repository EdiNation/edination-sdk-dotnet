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
using EdiNationAPI.Standard;
using EdiNationAPI.Standard.Utilities;


namespace EdiNationAPI.Standard.Models
{
    public class S006 : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string applicationSenderIdentification1;
        private string identificationCodeQualifier2;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("ApplicationSenderIdentification_1")]
        public string ApplicationSenderIdentification1 
        { 
            get 
            {
                return this.applicationSenderIdentification1; 
            } 
            set 
            {
                this.applicationSenderIdentification1 = value;
                onPropertyChanged("ApplicationSenderIdentification1");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("IdentificationCodeQualifier_2")]
        public string IdentificationCodeQualifier2 
        { 
            get 
            {
                return this.identificationCodeQualifier2; 
            } 
            set 
            {
                this.identificationCodeQualifier2 = value;
                onPropertyChanged("IdentificationCodeQualifier2");
            }
        }
    }
} 