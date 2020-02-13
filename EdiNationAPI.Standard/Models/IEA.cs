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
    public class IEA : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string numberOfIncludedGroups1;
        private string interchangeControlNumber2;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("NumberOfIncludedGroups_1")]
        public string NumberOfIncludedGroups1 
        { 
            get 
            {
                return this.numberOfIncludedGroups1; 
            } 
            set 
            {
                this.numberOfIncludedGroups1 = value;
                onPropertyChanged("NumberOfIncludedGroups1");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("InterchangeControlNumber_2")]
        public string InterchangeControlNumber2 
        { 
            get 
            {
                return this.interchangeControlNumber2; 
            } 
            set 
            {
                this.interchangeControlNumber2 = value;
                onPropertyChanged("InterchangeControlNumber2");
            }
        }
    }
} 