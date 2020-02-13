using EdiNationAPI.Standard.Models;
namespace EdiNationAPI.Standard
{
    public partial class Configuration
    {


        //The base Uri for API calls
        public static string BaseUri = "https://api.edination.com/v2";

        //API key to authenticate requests
        //TODO: Replace the OcpApimSubscriptionKey with an appropriate value
        public static string OcpApimSubscriptionKey = "";

    }
}