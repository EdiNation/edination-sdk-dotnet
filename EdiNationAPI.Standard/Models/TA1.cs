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
    public class TA1 : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string interchangeControlNumber1;
        private string interchangeDate2;
        private string interchangeTime3;
        private string interchangeAcknowledgmentCode4;
        private string interchangeNoteCode5;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("InterchangeControlNumber_1")]
        public string InterchangeControlNumber1 
        { 
            get 
            {
                return this.interchangeControlNumber1; 
            } 
            set 
            {
                this.interchangeControlNumber1 = value;
                onPropertyChanged("InterchangeControlNumber1");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("InterchangeDate_2")]
        public string InterchangeDate2 
        { 
            get 
            {
                return this.interchangeDate2; 
            } 
            set 
            {
                this.interchangeDate2 = value;
                onPropertyChanged("InterchangeDate2");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("InterchangeTime_3")]
        public string InterchangeTime3 
        { 
            get 
            {
                return this.interchangeTime3; 
            } 
            set 
            {
                this.interchangeTime3 = value;
                onPropertyChanged("InterchangeTime3");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("InterchangeAcknowledgmentCode_4")]
        public string InterchangeAcknowledgmentCode4 
        { 
            get 
            {
                return this.interchangeAcknowledgmentCode4; 
            } 
            set 
            {
                this.interchangeAcknowledgmentCode4 = value;
                onPropertyChanged("InterchangeAcknowledgmentCode4");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("InterchangeNoteCode_5")]
        public string InterchangeNoteCode5 
        { 
            get 
            {
                return this.interchangeNoteCode5; 
            } 
            set 
            {
                this.interchangeNoteCode5 = value;
                onPropertyChanged("InterchangeNoteCode5");
            }
        }
    }
} 