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
    public class EdifactGroup : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Models.UNG uNG;
        private List<object> transactions;
        private List<Models.UNE> uNETrailers;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("UNG")]
        public Models.UNG UNG 
        { 
            get 
            {
                return this.uNG; 
            } 
            set 
            {
                this.uNG = value;
                onPropertyChanged("UNG");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Transactions")]
        public List<object> Transactions 
        { 
            get 
            {
                return this.transactions; 
            } 
            set 
            {
                this.transactions = value;
                onPropertyChanged("Transactions");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("UNETrailers")]
        public List<Models.UNE> UNETrailers 
        { 
            get 
            {
                return this.uNETrailers; 
            } 
            set 
            {
                this.uNETrailers = value;
                onPropertyChanged("UNETrailers");
            }
        }
    }
} 