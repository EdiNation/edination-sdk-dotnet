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
    public class UNG : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string messageGroupIdentification1;
        private Models.S006 aPPLICATIONSENDERIDENTIFICATION2;
        private Models.S007 aPPLICATIONRECIPIENTIDENTIFICATION3;
        private Models.S004 dATEANDTIMEOFPREPARATION4;
        private string groupReferenceNumber5;
        private string controllingAgency6;
        private Models.S008 mESSAGEVERSION7;
        private string applicationPassword8;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("MessageGroupIdentification_1")]
        public string MessageGroupIdentification1 
        { 
            get 
            {
                return this.messageGroupIdentification1; 
            } 
            set 
            {
                this.messageGroupIdentification1 = value;
                onPropertyChanged("MessageGroupIdentification1");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("APPLICATIONSENDERIDENTIFICATION_2")]
        public Models.S006 APPLICATIONSENDERIDENTIFICATION2 
        { 
            get 
            {
                return this.aPPLICATIONSENDERIDENTIFICATION2; 
            } 
            set 
            {
                this.aPPLICATIONSENDERIDENTIFICATION2 = value;
                onPropertyChanged("APPLICATIONSENDERIDENTIFICATION2");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("APPLICATIONRECIPIENTIDENTIFICATION_3")]
        public Models.S007 APPLICATIONRECIPIENTIDENTIFICATION3 
        { 
            get 
            {
                return this.aPPLICATIONRECIPIENTIDENTIFICATION3; 
            } 
            set 
            {
                this.aPPLICATIONRECIPIENTIDENTIFICATION3 = value;
                onPropertyChanged("APPLICATIONRECIPIENTIDENTIFICATION3");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("DATEANDTIMEOFPREPARATION_4")]
        public Models.S004 DATEANDTIMEOFPREPARATION4 
        { 
            get 
            {
                return this.dATEANDTIMEOFPREPARATION4; 
            } 
            set 
            {
                this.dATEANDTIMEOFPREPARATION4 = value;
                onPropertyChanged("DATEANDTIMEOFPREPARATION4");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("GroupReferenceNumber_5")]
        public string GroupReferenceNumber5 
        { 
            get 
            {
                return this.groupReferenceNumber5; 
            } 
            set 
            {
                this.groupReferenceNumber5 = value;
                onPropertyChanged("GroupReferenceNumber5");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("ControllingAgency_6")]
        public string ControllingAgency6 
        { 
            get 
            {
                return this.controllingAgency6; 
            } 
            set 
            {
                this.controllingAgency6 = value;
                onPropertyChanged("ControllingAgency6");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("MESSAGEVERSION_7")]
        public Models.S008 MESSAGEVERSION7 
        { 
            get 
            {
                return this.mESSAGEVERSION7; 
            } 
            set 
            {
                this.mESSAGEVERSION7 = value;
                onPropertyChanged("MESSAGEVERSION7");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("ApplicationPassword_8")]
        public string ApplicationPassword8 
        { 
            get 
            {
                return this.applicationPassword8; 
            } 
            set 
            {
                this.applicationPassword8 = value;
                onPropertyChanged("ApplicationPassword8");
            }
        }
    }
} 