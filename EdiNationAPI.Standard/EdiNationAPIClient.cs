/*
 * EdiNationAPI.Standard
 *
 * This file was automatically generated for EdiNation by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using EdiNationAPI.Standard.Controllers;
using EdiNationAPI.Standard.Http.Client;
using EdiNationAPI.Standard.Utilities;

namespace EdiNationAPI.Standard
{
    public partial class EdiNationAPIClient
    {

        /// <summary>
        /// Singleton access to Edifact controller
        /// </summary>
        public EdifactController Edifact
        {
            get
            {
                return EdifactController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to EdiModel controller
        /// </summary>
        public EdiModelController EdiModel
        {
            get
            {
                return EdiModelController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to X12 controller
        /// </summary>
        public X12Controller X12
        {
            get
            {
                return X12Controller.Instance;
            }
        }
        /// <summary>
        /// The shared http client to use for all API calls
        /// </summary>
        public IHttpClient SharedHttpClient
        {
            get
            {
                return BaseController.ClientInstance;
            }
            set
            {
                BaseController.ClientInstance = value;
            }        
        }
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        public EdiNationAPIClient() { }

        /// <summary>
        /// Client initialization constructor
        /// </summary>
        public EdiNationAPIClient(string ocpApimSubscriptionKey)
        {
            Configuration.OcpApimSubscriptionKey = ocpApimSubscriptionKey;
        }
        #endregion
    }
}