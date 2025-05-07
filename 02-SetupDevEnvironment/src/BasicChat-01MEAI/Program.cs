using Azure;
using System.ClientModel;
using Azure.AI.OpenAI;
using Microsoft.Extensions.AI;

var deploymentName = "gpt-4o-mini"; // e.g. "gpt-4o-mini"
var endpoint = new Uri("https://ai-mbullen9067ai169741240493.openai.azure.com"); // e.g. "https://< your hub name >.openai.azure.com/"
var apiKey = new ApiKeyCredential("9UtISN2g10LJcBvKQnzJD7p5EI69F5rP9BoP4YSt0S7eMbi6Dw6FJQQJ99BEACHYHv6XJ3w3AAAAACOGD3ND");


IChatClient client = new AzureOpenAIClient(
    endpoint,
    apiKey)
.AsChatClient(deploymentName);

var response = await client.GetResponseAsync("Who is most likely to be the next pope? Select one cardinal");

Console.WriteLine(response.Message);