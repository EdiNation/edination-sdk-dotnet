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
    public class UNE : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string groupControlCount1;
        private string groupReferenceNumber2;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("GroupControlCount_1")]
        public string GroupControlCount1 
        { 
            get 
            {
                return this.groupControlCount1; 
            } 
            set 
            {
                this.groupControlCount1 = value;
                onPropertyChanged("GroupControlCount1");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("GroupReferenceNumber_2")]
        public string GroupReferenceNumber2 
        { 
            get 
            {
                return this.groupReferenceNumber2; 
            } 
            set 
            {
                this.groupReferenceNumber2 = value;
                onPropertyChanged("GroupReferenceNumber2");
            }
        }
    }
} 