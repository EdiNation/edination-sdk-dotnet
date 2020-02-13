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
    public class Link : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string rel;
        private string href;
        private string action;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Rel")]
        public string Rel 
        { 
            get 
            {
                return this.rel; 
            } 
            set 
            {
                this.rel = value;
                onPropertyChanged("Rel");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Href")]
        public string Href 
        { 
            get 
            {
                return this.href; 
            } 
            set 
            {
                this.href = value;
                onPropertyChanged("Href");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Action")]
        public string Action 
        { 
            get 
            {
                return this.action; 
            } 
            set 
            {
                this.action = value;
                onPropertyChanged("Action");
            }
        }
    }
} 