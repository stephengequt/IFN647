﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.CognitiveServices.Language.SpellCheck;
using Microsoft.Azure.CognitiveServices.Language.SpellCheck.Models;

namespace EduSearchAdvancedIS
{
    class BingSpellCheck
    {
        static string host = "https://api.cognitive.microsoft.com";
        static string path = "/bing/v7.0/spellcheck?";

        // For a list of available markets, go to:
        // https://docs.microsoft.com/rest/api/cognitiveservices/bing-autosuggest-api-v7-reference#market-codes
        static string params_ = "mkt=en-US&mode=proof";

        // NOTE: Replace this example key with a valid subscription key.
        static string key = "c1a10976d73e469382f0860c0ab2dac4";

//        static string text = "Hollo, wrld!";

        // These properties are used for optional headers (see below).
        // static string ClientId = "<Client ID from Previous Response Goes Here>";
        //static string ClientId = "2325577A61966D252A475CD760C96C03";
        // static string ClientIp = "999.999.999.999";
        // static string ClientLocation = "+90.0000000000000;long: 00.0000000000000;re:100.000000000000";
        public BingSpellCheck()
        {
        }

        public async void SpellCheck(string query)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", key);

            // The following headers are optional, but it is recommended they be treated as required.
            // These headers help the service return more accurate results.
            //client.DefaultRequestHeaders.Add("X-Search-Location", ClientLocation);
            //client.DefaultRequestHeaders.Add("X-MSEdge-ClientID", ClientId);
            //client.DefaultRequestHeaders.Add("X-MSEdge-ClientIP", ClientIp);

            HttpResponseMessage response = new HttpResponseMessage();
            string uri = host + path + params_;

            List<KeyValuePair<string, string>> values = new List<KeyValuePair<string, string>>();
            values.Add(new KeyValuePair<string, string>("text", query));

            using (FormUrlEncodedContent content = new FormUrlEncodedContent(values))
            {
                content.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");
                response = await client.PostAsync(uri, content);
            }

            string client_id;
            if (response.Headers.TryGetValues("X-MSEdge-ClientID", out IEnumerable<string> header_values))
            {
                client_id = header_values.First();
                Console.WriteLine("Client ID: " + client_id);
            }

            string contentString = await response.Content.ReadAsStringAsync();
            Console.WriteLine(JsonPrettyPrint(contentString));
        }

//        static void Main(string[] args)
//        {
//            SpellCheck();
//            Console.ReadLine();
//        }

        static string JsonPrettyPrint(string json)
        {
            if (string.IsNullOrEmpty(json))
            {
                return string.Empty;
            }

            json = json.Replace(Environment.NewLine, "").Replace("\t", "");

            StringBuilder sb = new StringBuilder();
            bool quote = false;
            bool ignore = false;
            char last = ' ';
            int offset = 0;
            int indentLength = 3;

            foreach (char ch in json)
            {
                switch (ch)
                {
                    case '"':
                        if (!ignore) quote = !quote;
                        break;
                    case '\\':
                        if (quote && last != '\\') ignore = true;
                        break;
                }

                if (quote)
                {
                    sb.Append(ch);
                    if (last == '\\' && ignore) ignore = false;
                }
                else
                {
                    switch (ch)
                    {
                        case '{':
                        case '[':
                            sb.Append(ch);
                            sb.Append(Environment.NewLine);
                            sb.Append(new string(' ', ++offset * indentLength));
                            break;
                        case '}':
                        case ']':
                            sb.Append(Environment.NewLine);
                            sb.Append(new string(' ', --offset * indentLength));
                            sb.Append(ch);
                            break;
                        case ',':
                            sb.Append(ch);
                            sb.Append(Environment.NewLine);
                            sb.Append(new string(' ', offset * indentLength));
                            break;
                        case ':':
                            sb.Append(ch);
                            sb.Append(' ');
                            break;
                        default:
                            if (quote || ch != ' ') sb.Append(ch);
                            break;
                    }
                }

                last = ch;
            }

            return sb.ToString().Trim();
        }

        public string SpellCheckCorrection(string text)
        {
            string subscriptionKey = "c1a10976d73e469382f0860c0ab2dac4";
            var client = new SpellCheckClient(new ApiKeyServiceClientCredentials(subscriptionKey));

            try
            {
                var result = client.SpellCheckerWithHttpMessagesAsync(text: text, mode: "proof").Result;
                
                // SpellCheck Results
                if (result?.Body.FlaggedTokens?.Count > 0)
                {
//                    var firstspellCheckResult = result.Body.FlaggedTokens.FirstOrDefault();

                    var spellCheckResult = result.Body.FlaggedTokens;
                    StringBuilder sb = new StringBuilder(text);
                    foreach (var spellingFlaggedToken in spellCheckResult)
                    {
                        string token = spellingFlaggedToken.Token;
                        string suggestion = spellingFlaggedToken.Suggestions.FirstOrDefault().Suggestion;
                        int startIndex = spellingFlaggedToken.Offset;
                        int count = spellingFlaggedToken.Token.Length;
                        sb.Replace(token, suggestion, startIndex, count);
                    }
                    
                    return sb.ToString();

                    //                    if (firstspellCheckResult != null)
                    //                    {
                    //                        
                    //                        Console.WriteLine("SpellCheck Results#{0}", result.Body.FlaggedTokens.Count);
                    //                        Console.WriteLine("Offset:{0}",firstspellCheckResult.Offset);
                    //                        Console.WriteLine("First SpellCheck Result token: {0} ", firstspellCheckResult.Token);
                    //                        Console.WriteLine("First SpellCheck Result Type: {0} ", firstspellCheckResult.Type);
                    //                        Console.WriteLine("First SpellCheck Result Suggestion Count: {0} ",
                    //                            firstspellCheckResult.Suggestions.Count);
                    //
                    //                        var suggestions = firstspellCheckResult.Suggestions;
                    //
                    //                        if (suggestions?.Count > 0)
                    //                        {
                    //                            var firstSuggestion = suggestions.FirstOrDefault();
                    //                            Console.WriteLine("First SpellCheck Suggestion Score: {0} ", firstSuggestion.Score);
                    //                            Console.WriteLine("First SpellCheck Suggestion : {0} ", firstSuggestion.Suggestion);
                    //                        }
                    //                        return firstspellCheckResult.Token;
                    //                    }
                    //                    else
                    //                    {
                    //                        Console.WriteLine("Couldn't get any Spell check results!");
                    //                        return text;
                    //                    }
                }

                Console.WriteLine("Didn't see any SpellCheck results..");
                return text;
            }

            catch (Exception ex)
            {
                Console.WriteLine("Encountered exception. " + ex.Message);
                return text;
            }
        }

        //        // This will trigger an error response from the API.
        //        public static void SpellCheckError(string subscriptionKey)
        //        {
        //            var client = new SpellCheckClient(new ApiKeyServiceClientCredentials(subscriptionKey)); ;
        //            try
        //            {
        //                var result = client.SpellCheckerAsync(mode: "proof").Result;
        //                Console.WriteLine("Correction for Query# \"empty text field\"");
        //            }
        //            catch (Exception ex)
        //            {
        //                if (ex.GetBaseException().GetType() == typeof(Exception))
        //                {
        //                    Console.WriteLine("Encountered exception. " + ex.Message);
        //                }
        //            }
        //        }
    }
}