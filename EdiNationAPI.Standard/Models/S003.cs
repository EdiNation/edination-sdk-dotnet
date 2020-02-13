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
    public class S003 : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string interchangeRecipientIdentification1;
        private string identificationCodeQualifier2;
        private string interchangeRecipientInternalIdentification3;
        private string interchangeRecipientInternalSubIdentification4;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("InterchangeRecipientIdentification_1")]
        public string InterchangeRecipientIdentification1 
        { 
            get 
            {
                return this.interchangeRecipientIdentification1; 
            } 
            set 
            {
                this.interchangeRecipientIdentification1 = value;
                onPropertyChanged("InterchangeRecipientIdentification1");
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

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("InterchangeRecipientInternalIdentification_3")]
        public string InterchangeRecipientInternalIdentification3 
        { 
            get 
            {
                return this.interchangeRecipientInternalIdentification3; 
            } 
            set 
            {
                this.interchangeRecipientInternalIdentification3 = value;
                onPropertyChanged("InterchangeRecipientInternalIdentification3");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("InterchangeRecipientInternalSubIdentification_4")]
        public string InterchangeRecipientInternalSubIdentification4 
        { 
            get 
            {
                return this.interchangeRecipientInternalSubIdentification4; 
            } 
            set 
            {
                this.interchangeRecipientInternalSubIdentification4 = value;
                onPropertyChanged("InterchangeRecipientInternalSubIdentification4");
            }
        }
    }
} 