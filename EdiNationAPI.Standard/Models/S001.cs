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
    public class S001 : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string syntaxIdentifier1;
        private string syntaxVersionNumber2;
        private string serviceCodeListDirectoryVersionNumber3;
        private string characterEncoding4;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("SyntaxIdentifier_1")]
        public string SyntaxIdentifier1 
        { 
            get 
            {
                return this.syntaxIdentifier1; 
            } 
            set 
            {
                this.syntaxIdentifier1 = value;
                onPropertyChanged("SyntaxIdentifier1");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("SyntaxVersionNumber_2")]
        public string SyntaxVersionNumber2 
        { 
            get 
            {
                return this.syntaxVersionNumber2; 
            } 
            set 
            {
                this.syntaxVersionNumber2 = value;
                onPropertyChanged("SyntaxVersionNumber2");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("ServiceCodeListDirectoryVersionNumber_3")]
        public string ServiceCodeListDirectoryVersionNumber3 
        { 
            get 
            {
                return this.serviceCodeListDirectoryVersionNumber3; 
            } 
            set 
            {
                this.serviceCodeListDirectoryVersionNumber3 = value;
                onPropertyChanged("ServiceCodeListDirectoryVersionNumber3");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("CharacterEncoding_4")]
        public string CharacterEncoding4 
        { 
            get 
            {
                return this.characterEncoding4; 
            } 
            set 
            {
                this.characterEncoding4 = value;
                onPropertyChanged("CharacterEncoding4");
            }
        }
    }
} 