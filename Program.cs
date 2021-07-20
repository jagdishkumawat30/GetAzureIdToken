using System;
using RestSharp;

namespace GetAzureIdToken
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new RestClient("https://login.microsoftonline.com/tenantId/oauth2/v2.0/token");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            
            request.AddParameter("client_id", "");
            request.AddParameter("scope", "user.read openid profile offline_access");
            request.AddParameter("client_secret", "");
            request.AddParameter("username", "");
            request.AddParameter("password", "");
            request.AddParameter("grant_type", "password");

            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
        }

        
    }
}
