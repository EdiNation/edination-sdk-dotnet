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
    public class S004 : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string date1;
        private string time2;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Date_1")]
        public string Date1 
        { 
            get 
            {
                return this.date1; 
            } 
            set 
            {
                this.date1 = value;
                onPropertyChanged("Date1");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Time_2")]
        public string Time2 
        { 
            get 
            {
                return this.time2; 
            } 
            set 
            {
                this.time2 = value;
                onPropertyChanged("Time2");
            }
        }
    }
} 