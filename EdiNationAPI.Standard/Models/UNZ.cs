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
    public class UNZ : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string interchangeControlCount1;
        private string interchangeControlReference2;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("InterchangeControlCount_1")]
        public string InterchangeControlCount1 
        { 
            get 
            {
                return this.interchangeControlCount1; 
            } 
            set 
            {
                this.interchangeControlCount1 = value;
                onPropertyChanged("InterchangeControlCount1");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("InterchangeControlReference_2")]
        public string InterchangeControlReference2 
        { 
            get 
            {
                return this.interchangeControlReference2; 
            } 
            set 
            {
                this.interchangeControlReference2 = value;
                onPropertyChanged("InterchangeControlReference2");
            }
        }
    }
} 