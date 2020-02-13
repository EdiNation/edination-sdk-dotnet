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
    public class S008 : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string messageVersionNumber1;
        private string messageReleaseNumber2;
        private string associationAssignedCode3;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("MessageVersionNumber_1")]
        public string MessageVersionNumber1 
        { 
            get 
            {
                return this.messageVersionNumber1; 
            } 
            set 
            {
                this.messageVersionNumber1 = value;
                onPropertyChanged("MessageVersionNumber1");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("MessageReleaseNumber_2")]
        public string MessageReleaseNumber2 
        { 
            get 
            {
                return this.messageReleaseNumber2; 
            } 
            set 
            {
                this.messageReleaseNumber2 = value;
                onPropertyChanged("MessageReleaseNumber2");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("AssociationAssignedCode_3")]
        public string AssociationAssignedCode3 
        { 
            get 
            {
                return this.associationAssignedCode3; 
            } 
            set 
            {
                this.associationAssignedCode3 = value;
                onPropertyChanged("AssociationAssignedCode3");
            }
        }
    }
} 