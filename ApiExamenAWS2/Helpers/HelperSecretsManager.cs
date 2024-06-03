﻿using Amazon.SecretsManager.Model;
using Amazon.SecretsManager;
using Amazon;
using Amazon.Runtime.Internal;

namespace ApiExamenAWS2.Helpers
{
    public static class HelperSecretsManager
    {
        public static async Task<string> GetSecretsAsync()
        {
            string secretName = "secretoseventos";
            string region = "us-east-1";

            IAmazonSecretsManager client = new AmazonSecretsManagerClient(RegionEndpoint.GetBySystemName(region));

            GetSecretValueRequest request = new GetSecretValueRequest
            {
                SecretId = secretName,
                VersionStage = "AWSCURRENT", // VersionStage defaults to AWSCURRENT if unspecified.
            };

            GetSecretValueResponse response;
            response = await client.GetSecretValueAsync(request);
            string secret = response.SecretString;
            return secret;
        }     
    }
}
