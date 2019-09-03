using CommonServices.Earthquake;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CommonServices.HttpComm
{
    public sealed class Comm
    {
        public const int METHOD_POST = 0x01;
        public const int METHOD_GET = 0x02;
        public const int METHOD_PUT = 0x03;
        public const int METHOD_DELETE = 0x04;

        public const int POST_CONTENTTYPE_URL = 0x10;
        public const int POST_CONTENTTYPE_JSON = 0x11;

        public const string ApplicationWWW = "application/x-www-form-urlencoded";
        public const string ApplicationJson = "application/json";
        public const string ApplicationXml = "application/xml";

        public const string TextCss = "text/css";
        public const string TextJavascript = "text/javascript";
        public const string TextHtml = "text/html";
        public const string TextPlain = "text/plain";

        public static readonly string MultipartFormeddata = "mulitpart/formed-data";

        private static Lazy<Comm> _lazy = new Lazy<Comm>(() => new Comm());

        public static Comm Instance
        {
            get
            {
                return _lazy.Value;
            }
        }

        private Comm()
        {
        }

        public async Task<string> request(string url, int method, string postOrParamsData, string ContentsType = ApplicationJson)
        {
            try
            {
                HttpWebRequest request;

                if (method == METHOD_GET)
                {
                    StringBuilder body = new StringBuilder();
                    JObject obj;

                    if (string.IsNullOrEmpty(postOrParamsData))
                    {
                        obj = new JObject();
                    }
                    else
                    {
                        obj = JObject.Parse(postOrParamsData);
                    }

                    foreach (var keyValuePair in obj)
                    {
                        body.Append(keyValuePair.Key + "=" + keyValuePair.Value + "&");
                    }

                    if (url.ToString().Contains(SiteURI.EarthquakeServiceDefaultPath))
                    {
                        request = (HttpWebRequest)WebRequest.Create(url + "?" + body.ToString() + "&type=json");
                    }
                    else
                    {
                        request = (HttpWebRequest)WebRequest.Create(url + "?" + body.ToString() + "");
                    }
                    request.Credentials = CredentialCache.DefaultCredentials;
                    ServicePointManager.ServerCertificateValidationCallback += new RemoteCertificateValidationCallback(VaildateServerCertificate);
                    request.KeepAlive = false;
                    request.ProtocolVersion = HttpVersion.Version10;
                    request.Method = "GET";
                }
                else
                {
                    request = (HttpWebRequest)WebRequest.Create(url);
                    request.Credentials = CredentialCache.DefaultCredentials;
                    ServicePointManager.ServerCertificateValidationCallback += new System.Net.Security.RemoteCertificateValidationCallback(VaildateServerCertificate);
                    request.KeepAlive = false;
                    request.ProtocolVersion = HttpVersion.Version10;

                    if (method == METHOD_POST)
                    {
                        request.Method = "POST";
                    }
                    else if (method == METHOD_PUT)
                    {
                        request.Method = "PUT";
                    }
                    else if (method == METHOD_DELETE)
                    {
                        request.Method = "DELETE";
                    }
                }

                Stream dataStream;

                if (method == METHOD_GET)
                {
                    request.ContentType = ContentsType;
                }
                else
                {
                    byte[] byteArray = Encoding.UTF8.GetBytes(postOrParamsData);

                    request.ContentType = ContentsType;

                    request.ContentLength = byteArray.Length;
                    dataStream = request.GetRequestStream();
                    dataStream.Write(byteArray, 0, byteArray.Length);
                    // Close the Stream object.  
                    dataStream.Close();
                }

                // Set the ContentLength property of the WebRequest.  

                // Get the request stream.  

                // Write the data to the request stream.  

                // Get the response.  
                HttpWebResponse response = (HttpWebResponse) await request.GetResponseAsync();
                // Display the status. 
                Console.WriteLine(((HttpWebResponse)response).StatusDescription);
                // Get the stream containing content returned by the server.  
                dataStream = response.GetResponseStream();
                // Open the stream using a StreamReader for easy access.  
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.  
                string responseFromServer = reader.ReadToEnd();
                // Display the content.  
                Console.WriteLine(responseFromServer);
                // Clean up the streams.  
                reader.Close();
                dataStream.Close();
                response.Close();

                return responseFromServer;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static bool VaildateServerCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }
    }
}
