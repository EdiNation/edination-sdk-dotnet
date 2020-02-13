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
    public class S002 : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string interchangeSenderIdentification1;
        private string identificationCodeQualifier2;
        private string interchangeSenderInternalIdentification3;
        private string interchangeSenderInternalSubIdentification4;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("InterchangeSenderIdentification_1")]
        public string InterchangeSenderIdentification1 
        { 
            get 
            {
                return this.interchangeSenderIdentification1; 
            } 
            set 
            {
                this.interchangeSenderIdentification1 = value;
                onPropertyChanged("InterchangeSenderIdentification1");
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
        [JsonProperty("InterchangeSenderInternalIdentification_3")]
        public string InterchangeSenderInternalIdentification3 
        { 
            get 
            {
                return this.interchangeSenderInternalIdentification3; 
            } 
            set 
            {
                this.interchangeSenderInternalIdentification3 = value;
                onPropertyChanged("InterchangeSenderInternalIdentification3");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("InterchangeSenderInternalSubIdentification_4")]
        public string InterchangeSenderInternalSubIdentification4 
        { 
            get 
            {
                return this.interchangeSenderInternalSubIdentification4; 
            } 
            set 
            {
                this.interchangeSenderInternalSubIdentification4 = value;
                onPropertyChanged("InterchangeSenderInternalSubIdentification4");
            }
        }
    }
} 