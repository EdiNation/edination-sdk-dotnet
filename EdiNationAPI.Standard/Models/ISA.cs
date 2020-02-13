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
    public class ISA : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string authorizationInformationQualifier1;
        private string authorizationInformation2;
        private string securityInformationQualifier3;
        private string securityInformation4;
        private string senderIDQualifier5;
        private string interchangeSenderID6;
        private string receiverIDQualifier7;
        private string interchangeReceiverID8;
        private string interchangeDate9;
        private string interchangeTime10;
        private string interchangeControlStandardsIdentifier11;
        private string interchangeControlVersionNumber12;
        private string interchangeControlNumber13;
        private string acknowledgementRequested14;
        private string usageIndicator15;
        private string componentElementSeparator16;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("AuthorizationInformationQualifier_1")]
        public string AuthorizationInformationQualifier1 
        { 
            get 
            {
                return this.authorizationInformationQualifier1; 
            } 
            set 
            {
                this.authorizationInformationQualifier1 = value;
                onPropertyChanged("AuthorizationInformationQualifier1");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("AuthorizationInformation_2")]
        public string AuthorizationInformation2 
        { 
            get 
            {
                return this.authorizationInformation2; 
            } 
            set 
            {
                this.authorizationInformation2 = value;
                onPropertyChanged("AuthorizationInformation2");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("SecurityInformationQualifier_3")]
        public string SecurityInformationQualifier3 
        { 
            get 
            {
                return this.securityInformationQualifier3; 
            } 
            set 
            {
                this.securityInformationQualifier3 = value;
                onPropertyChanged("SecurityInformationQualifier3");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("SecurityInformation_4")]
        public string SecurityInformation4 
        { 
            get 
            {
                return this.securityInformation4; 
            } 
            set 
            {
                this.securityInformation4 = value;
                onPropertyChanged("SecurityInformation4");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("SenderIDQualifier_5")]
        public string SenderIDQualifier5 
        { 
            get 
            {
                return this.senderIDQualifier5; 
            } 
            set 
            {
                this.senderIDQualifier5 = value;
                onPropertyChanged("SenderIDQualifier5");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("InterchangeSenderID_6")]
        public string InterchangeSenderID6 
        { 
            get 
            {
                return this.interchangeSenderID6; 
            } 
            set 
            {
                this.interchangeSenderID6 = value;
                onPropertyChanged("InterchangeSenderID6");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("ReceiverIDQualifier_7")]
        public string ReceiverIDQualifier7 
        { 
            get 
            {
                return this.receiverIDQualifier7; 
            } 
            set 
            {
                this.receiverIDQualifier7 = value;
                onPropertyChanged("ReceiverIDQualifier7");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("InterchangeReceiverID_8")]
        public string InterchangeReceiverID8 
        { 
            get 
            {
                return this.interchangeReceiverID8; 
            } 
            set 
            {
                this.interchangeReceiverID8 = value;
                onPropertyChanged("InterchangeReceiverID8");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("InterchangeDate_9")]
        public string InterchangeDate9 
        { 
            get 
            {
                return this.interchangeDate9; 
            } 
            set 
            {
                this.interchangeDate9 = value;
                onPropertyChanged("InterchangeDate9");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("InterchangeTime_10")]
        public string InterchangeTime10 
        { 
            get 
            {
                return this.interchangeTime10; 
            } 
            set 
            {
                this.interchangeTime10 = value;
                onPropertyChanged("InterchangeTime10");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("InterchangeControlStandardsIdentifier_11")]
        public string InterchangeControlStandardsIdentifier11 
        { 
            get 
            {
                return this.interchangeControlStandardsIdentifier11; 
            } 
            set 
            {
                this.interchangeControlStandardsIdentifier11 = value;
                onPropertyChanged("InterchangeControlStandardsIdentifier11");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("InterchangeControlVersionNumber_12")]
        public string InterchangeControlVersionNumber12 
        { 
            get 
            {
                return this.interchangeControlVersionNumber12; 
            } 
            set 
            {
                this.interchangeControlVersionNumber12 = value;
                onPropertyChanged("InterchangeControlVersionNumber12");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("InterchangeControlNumber_13")]
        public string InterchangeControlNumber13 
        { 
            get 
            {
                return this.interchangeControlNumber13; 
            } 
            set 
            {
                this.interchangeControlNumber13 = value;
                onPropertyChanged("InterchangeControlNumber13");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("AcknowledgementRequested_14")]
        public string AcknowledgementRequested14 
        { 
            get 
            {
                return this.acknowledgementRequested14; 
            } 
            set 
            {
                this.acknowledgementRequested14 = value;
                onPropertyChanged("AcknowledgementRequested14");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("UsageIndicator_15")]
        public string UsageIndicator15 
        { 
            get 
            {
                return this.usageIndicator15; 
            } 
            set 
            {
                this.usageIndicator15 = value;
                onPropertyChanged("UsageIndicator15");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("ComponentElementSeparator_16")]
        public string ComponentElementSeparator16 
        { 
            get 
            {
                return this.componentElementSeparator16; 
            } 
            set 
            {
                this.componentElementSeparator16 = value;
                onPropertyChanged("ComponentElementSeparator16");
            }
        }
    }
} 