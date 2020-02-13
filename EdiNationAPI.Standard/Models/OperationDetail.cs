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
    public class OperationDetail : BaseModel 
    {
        // These fields hold the values for the public properties.
        private int? index;
        private int? transactionIndex;
        private string transactionRef;
        private string segmentId;
        private string mvalue;
        private string message;
        private string status;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Index")]
        public int? Index 
        { 
            get 
            {
                return this.index; 
            } 
            set 
            {
                this.index = value;
                onPropertyChanged("Index");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("TransactionIndex")]
        public int? TransactionIndex 
        { 
            get 
            {
                return this.transactionIndex; 
            } 
            set 
            {
                this.transactionIndex = value;
                onPropertyChanged("TransactionIndex");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("TransactionRef")]
        public string TransactionRef 
        { 
            get 
            {
                return this.transactionRef; 
            } 
            set 
            {
                this.transactionRef = value;
                onPropertyChanged("TransactionRef");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("SegmentId")]
        public string SegmentId 
        { 
            get 
            {
                return this.segmentId; 
            } 
            set 
            {
                this.segmentId = value;
                onPropertyChanged("SegmentId");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Value")]
        public string Value 
        { 
            get 
            {
                return this.mvalue; 
            } 
            set 
            {
                this.mvalue = value;
                onPropertyChanged("Value");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Message")]
        public string Message 
        { 
            get 
            {
                return this.message; 
            } 
            set 
            {
                this.message = value;
                onPropertyChanged("Message");
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