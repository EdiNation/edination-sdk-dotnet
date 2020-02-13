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
    public class UNA : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string componentDataElement;
        private string dataElement;
        private string decimalNotation;
        private string releaseIndicator;
        private string reserved;
        private string segment;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("ComponentDataElement")]
        public string ComponentDataElement 
        { 
            get 
            {
                return this.componentDataElement; 
            } 
            set 
            {
                this.componentDataElement = value;
                onPropertyChanged("ComponentDataElement");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("DataElement")]
        public string DataElement 
        { 
            get 
            {
                return this.dataElement; 
            } 
            set 
            {
                this.dataElement = value;
                onPropertyChanged("DataElement");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("DecimalNotation")]
        public string DecimalNotation 
        { 
            get 
            {
                return this.decimalNotation; 
            } 
            set 
            {
                this.decimalNotation = value;
                onPropertyChanged("DecimalNotation");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("ReleaseIndicator")]
        public string ReleaseIndicator 
        { 
            get 
            {
                return this.releaseIndicator; 
            } 
            set 
            {
                this.releaseIndicator = value;
                onPropertyChanged("ReleaseIndicator");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Reserved")]
        public string Reserved 
        { 
            get 
            {
                return this.reserved; 
            } 
            set 
            {
                this.reserved = value;
                onPropertyChanged("Reserved");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Segment")]
        public string Segment 
        { 
            get 
            {
                return this.segment; 
            } 
            set 
            {
                this.segment = value;
                onPropertyChanged("Segment");
            }
        }
    }
} 