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
    public class OperationResult : BaseModel 
    {
        // These fields hold the values for the public properties.
        private int? lastIndex;
        private List<Models.OperationDetail> details;
        private string status;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("LastIndex")]
        public int? LastIndex 
        { 
            get 
            {
                return this.lastIndex; 
            } 
            set 
            {
                this.lastIndex = value;
                onPropertyChanged("LastIndex");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Details")]
        public List<Models.OperationDetail> Details 
        { 
            get 
            {
                return this.details; 
            } 
            set 
            {
                this.details = value;
                onPropertyChanged("Details");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Status")]
        public string Status 
        { 
            get 
            {
                return this.status; 
            } 
            set 
            {
                this.status = value;
                onPropertyChanged("Status");
            }
        }
    }
} 