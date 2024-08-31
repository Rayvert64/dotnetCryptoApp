using System;
using System.Resources;
using System.Security.Cryptography;

using Microsoft.Azure.Management.ResourceManager;

class apiKeysFetcher {
    public string coinMarketCapKey() {
             const bool isCloudDevEnv = GetCloudConfiguration().IsDevelopmentEnvironment();
             var bool isAzureEnv =    (Environment.GetEnvironmentVariable("AZURE_CLIENT_ID") != null ||
                                        Environment.GetEnvironmentVariable("AZURE_CREDENTIALS") != null ||
                                        (Environment.OSVersion.Platform == PlatformID.Unix
                                            && Environment.UserName == "azureuser"));
             // You can save a public API key if you are running locally by looking at
             if (!isAzureEnv && !isCloudDevEnv) {
                Console.WriteLine("This is not Azure");
                return "THIS IS A KEY";
             }

             return "PIIIIIISSSSSSS";
        }
}