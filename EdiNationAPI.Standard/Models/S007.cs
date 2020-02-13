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
    public class S007 : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string applicationRecipientIdentification1;
        private string identificationCodeQualifier2;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("ApplicationRecipientIdentification_1")]
        public string ApplicationRecipientIdentification1 
        { 
            get 
            {
                return this.applicationRecipientIdentification1; 
            } 
            set 
            {
                this.applicationRecipientIdentification1 = value;
                onPropertyChanged("ApplicationRecipientIdentification1");
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