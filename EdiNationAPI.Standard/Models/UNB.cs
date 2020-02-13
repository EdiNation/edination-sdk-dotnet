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
    public class UNB : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Models.S001 sYNTAXIDENTIFIER1;
        private Models.S002 iNTERCHANGESENDER2;
        private Models.S003 iNTERCHANGERECIPIENT3;
        private Models.S004 dATEANDTIMEOFPREPARATION4;
        private string interchangeControlReference5;
        private Models.S005 rECIPIENTSREFERENCEPASSWORDDETAILS6;
        private string applicationReference7;
        private string processingPriorityCode8;
        private string acknowledgementRequest9;
        private string interchangeAgreementIdentifier10;
        private string testIndicator11;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("SYNTAXIDENTIFIER_1")]
        public Models.S001 SYNTAXIDENTIFIER1 
        { 
            get 
            {
                return this.sYNTAXIDENTIFIER1; 
            } 
            set 
            {
                this.sYNTAXIDENTIFIER1 = value;
                onPropertyChanged("SYNTAXIDENTIFIER1");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("INTERCHANGESENDER_2")]
        public Models.S002 INTERCHANGESENDER2 
        { 
            get 
            {
                return this.iNTERCHANGESENDER2; 
            } 
            set 
            {
                this.iNTERCHANGESENDER2 = value;
                onPropertyChanged("INTERCHANGESENDER2");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("INTERCHANGERECIPIENT_3")]
        public Models.S003 INTERCHANGERECIPIENT3 
        { 
            get 
            {
                return this.iNTERCHANGERECIPIENT3; 
            } 
            set 
            {
                this.iNTERCHANGERECIPIENT3 = value;
                onPropertyChanged("INTERCHANGERECIPIENT3");
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
        [JsonProperty("InterchangeControlReference_5")]
        public string InterchangeControlReference5 
        { 
            get 
            {
                return this.interchangeControlReference5; 
            } 
            set 
            {
                this.interchangeControlReference5 = value;
                onPropertyChanged("InterchangeControlReference5");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("RECIPIENTSREFERENCEPASSWORDDETAILS_6")]
        public Models.S005 RECIPIENTSREFERENCEPASSWORDDETAILS6 
        { 
            get 
            {
                return this.rECIPIENTSREFERENCEPASSWORDDETAILS6; 
            } 
            set 
            {
                this.rECIPIENTSREFERENCEPASSWORDDETAILS6 = value;
                onPropertyChanged("RECIPIENTSREFERENCEPASSWORDDETAILS6");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("ApplicationReference_7")]
        public string ApplicationReference7 
        { 
            get 
            {
                return this.applicationReference7; 
            } 
            set 
            {
                this.applicationReference7 = value;
                onPropertyChanged("ApplicationReference7");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("ProcessingPriorityCode_8")]
        public string ProcessingPriorityCode8 
        { 
            get 
            {
                return this.processingPriorityCode8; 
            } 
            set 
            {
                this.processingPriorityCode8 = value;
                onPropertyChanged("ProcessingPriorityCode8");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("AcknowledgementRequest_9")]
        public string AcknowledgementRequest9 
        { 
            get 
            {
                return this.acknowledgementRequest9; 
            } 
            set 
            {
                this.acknowledgementRequest9 = value;
                onPropertyChanged("AcknowledgementRequest9");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("InterchangeAgreementIdentifier_10")]
        public string InterchangeAgreementIdentifier10 
        { 
            get 
            {
                return this.interchangeAgreementIdentifier10; 
            } 
            set 
            {
                this.interchangeAgreementIdentifier10 = value;
                onPropertyChanged("InterchangeAgreementIdentifier10");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("TestIndicator_11")]
        public string TestIndicator11 
        { 
            get 
            {
                return this.testIndicator11; 
            } 
            set 
            {
                this.testIndicator11 = value;
                onPropertyChanged("TestIndicator11");
            }
        }
    }
} 