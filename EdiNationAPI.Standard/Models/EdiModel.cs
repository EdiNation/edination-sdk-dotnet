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
    public class EdiModel : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string name;
        private string dateCreated;
        private List<Models.Link> links;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Name")]
        public string Name 
        { 
            get 
            {
                return this.name; 
            } 
            set 
            {
                this.name = value;
                onPropertyChanged("Name");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("DateCreated")]
        public string DateCreated 
        { 
            get 
            {
                return this.dateCreated; 
            } 
            set 
            {
                this.dateCreated = value;
                onPropertyChanged("DateCreated");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Links")]
        public List<Models.Link> Links 
        { 
            get 
            {
                return this.links; 
            } 
            set 
            {
                this.links = value;
                onPropertyChanged("Links");
            }
        }
    }
} 