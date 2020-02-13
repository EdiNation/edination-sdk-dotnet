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
    public class GS : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string codeIdentifyingInformationType1;
        private string senderIDCode2;
        private string receiverIDCode3;
        private string date4;
        private string time5;
        private string groupControlNumber6;
        private string transactionTypeCode7;
        private string versionAndRelease8;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("CodeIdentifyingInformationType_1")]
        public string CodeIdentifyingInformationType1 
        { 
            get 
            {
                return this.codeIdentifyingInformationType1; 
            } 
            set 
            {
                this.codeIdentifyingInformationType1 = value;
                onPropertyChanged("CodeIdentifyingInformationType1");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("SenderIDCode_2")]
        public string SenderIDCode2 
        { 
            get 
            {
                return this.senderIDCode2; 
            } 
            set 
            {
                this.senderIDCode2 = value;
                onPropertyChanged("SenderIDCode2");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("ReceiverIDCode_3")]
        public string ReceiverIDCode3 
        { 
            get 
            {
                return this.receiverIDCode3; 
            } 
            set 
            {
                this.receiverIDCode3 = value;
                onPropertyChanged("ReceiverIDCode3");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Date_4")]
        public string Date4 
        { 
            get 
            {
                return this.date4; 
            } 
            set 
            {
                this.date4 = value;
                onPropertyChanged("Date4");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Time_5")]
        public string Time5 
        { 
            get 
            {
                return this.time5; 
            } 
            set 
            {
                this.time5 = value;
                onPropertyChanged("Time5");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("GroupControlNumber_6")]
        public string GroupControlNumber6 
        { 
            get 
            {
                return this.groupControlNumber6; 
            } 
            set 
            {
                this.groupControlNumber6 = value;
                onPropertyChanged("GroupControlNumber6");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("TransactionTypeCode_7")]
        public string TransactionTypeCode7 
        { 
            get 
            {
                return this.transactionTypeCode7; 
            } 
            set 
            {
                this.transactionTypeCode7 = value;
                onPropertyChanged("TransactionTypeCode7");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("VersionAndRelease_8")]
        public string VersionAndRelease8 
        { 
            get 
            {
                return this.versionAndRelease8; 
            } 
            set 
            {
                this.versionAndRelease8 = value;
                onPropertyChanged("VersionAndRelease8");
            }
        }
    }
} 