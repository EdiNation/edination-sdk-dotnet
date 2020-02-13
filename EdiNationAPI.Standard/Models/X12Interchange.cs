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
    public class X12Interchange : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string segmentDelimiter;
        private string dataElementDelimiter;
        private Models.ISA iSA;
        private Models.TA1 tA1;
        private List<Models.X12Group> groups;
        private List<Models.IEA> iEATrailers;
        private Models.OperationResult result;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("SegmentDelimiter")]
        public string SegmentDelimiter 
        { 
            get 
            {
                return this.segmentDelimiter; 
            } 
            set 
            {
                this.segmentDelimiter = value;
                onPropertyChanged("SegmentDelimiter");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("DataElementDelimiter")]
        public string DataElementDelimiter 
        { 
            get 
            {
                return this.dataElementDelimiter; 
            } 
            set 
            {
                this.dataElementDelimiter = value;
                onPropertyChanged("DataElementDelimiter");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("ISA")]
        public Models.ISA ISA 
        { 
            get 
            {
                return this.iSA; 
            } 
            set 
            {
                this.iSA = value;
                onPropertyChanged("ISA");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("TA1")]
        public Models.TA1 TA1 
        { 
            get 
            {
                return this.tA1; 
            } 
            set 
            {
                this.tA1 = value;
                onPropertyChanged("TA1");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Groups")]
        public List<Models.X12Group> Groups 
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
        [JsonProperty("IEATrailers")]
        public List<Models.IEA> IEATrailers 
        { 
            get 
            {
                return this.iEATrailers; 
            } 
            set 
            {
                this.iEATrailers = value;
                onPropertyChanged("IEATrailers");
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