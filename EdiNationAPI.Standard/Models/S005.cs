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
    public class S005 : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string recipientReferencePassword1;
        private string recipientReferencePasswordQualifier2;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("RecipientReferencePassword_1")]
        public string RecipientReferencePassword1 
        { 
            get 
            {
                return this.recipientReferencePassword1; 
            } 
            set 
            {
                this.recipientReferencePassword1 = value;
                onPropertyChanged("RecipientReferencePassword1");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("RecipientReferencePasswordQualifier_2")]
        public string RecipientReferencePasswordQualifier2 
        { 
            get 
            {
                return this.recipientReferencePasswordQualifier2; 
            } 
            set 
            {
                this.recipientReferencePasswordQualifier2 = value;
                onPropertyChanged("RecipientReferencePasswordQualifier2");
            }
        }
    }
} 