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
    public class EdifactInterchange : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Models.UNA uNA;
        private Models.UNB uNB;
        private List<Models.EdifactGroup> groups;
        private List<Models.UNZ> uNZTrailers;
        private Models.OperationResult result;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("UNA")]
        public Models.UNA UNA 
        { 
            get 
            {
                return this.uNA; 
            } 
            set 
            {
                this.uNA = value;
                onPropertyChanged("UNA");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("UNB")]
        public Models.UNB UNB 
        { 
            get 
            {
                return this.uNB; 
            } 
            set 
            {
                this.uNB = value;
                onPropertyChanged("UNB");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Groups")]
        public List<Models.EdifactGroup> Groups 
        { 
            get 
            {
                return this.groups; 
            } 
            set 
            {
                this.groups = value;
                onPropertyChanged("Groups");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("UNZTrailers")]
        public List<Models.UNZ> UNZTrailers 
        { 
            get 
            {
                return this.uNZTrailers; 
            } 
            set 
            {
                this.uNZTrailers = value;
                onPropertyChanged("UNZTrailers");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Result")]
        public Models.OperationResult Result 
        { 
            get 
            {
                return this.result; 
            } 
            set 
            {
                this.result = value;
                onPropertyChanged("Result");
            }
        }
    }
} 