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
    public class X12Group : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Models.GS gS;
        private object transactions;
        private List<Models.GE> gETrailers;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("GS")]
        public Models.GS GS 
        { 
            get 
            {
                return this.gS; 
            } 
            set 
            {
                this.gS = value;
                onPropertyChanged("GS");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Transactions")]
        public object Transactions 
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
        [JsonProperty("GETrailers")]
        public List<Models.GE> GETrailers 
        { 
            get 
            {
                return this.gETrailers; 
            } 
            set 
            {
                this.gETrailers = value;
                onPropertyChanged("GETrailers");
            }
        }
    }
} 