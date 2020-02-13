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
    public class GE : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string numberOfIncludedSets1;
        private string groupControlNumber2;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("NumberOfIncludedSets_1")]
        public string NumberOfIncludedSets1 
        { 
            get 
            {
                return this.numberOfIncludedSets1; 
            } 
            set 
            {
                this.numberOfIncludedSets1 = value;
                onPropertyChanged("NumberOfIncludedSets1");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("GroupControlNumber_2")]
        public string GroupControlNumber2 
        { 
            get 
            {
                return this.groupControlNumber2; 
            } 
            set 
            {
                this.groupControlNumber2 = value;
                onPropertyChanged("GroupControlNumber2");
            }
        }
    }
} 