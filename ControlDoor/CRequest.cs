using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Net.Sockets;
using System.Windows.Forms;

namespace ControlDoor
{
    public class CRequest
    {
        public async Task<string> PostRequest(string url, string json)
        {
            Uri uri = new Uri(url);
            var request = (HttpWebRequest)WebRequest.Create(uri);
            var credentialCache = new CredentialCache();

            credentialCache.Add(
              new Uri(uri.GetLeftPart(UriPartial.Authority)),
              "Digest",  // authentication type 
              new NetworkCredential("admin", "ivandavid121")
            );

            request.Method = "POST";
            request.ContentType = "application/json";
            request.Credentials = credentialCache;

            try
            {
                // Write the request Asynchronously 
                using (var stream = await Task.Factory.FromAsync<Stream>(request.BeginGetRequestStream, request.EndGetRequestStream, null))
                {
                    byte[] byteArray = Encoding.UTF8.GetBytes(json);

                    // Write the bytes to the stream
                    await stream.WriteAsync(byteArray, 0, byteArray.Length);
                }

                using (var response = (HttpWebResponse)await request.GetResponseAsync())
                {
                    string data;

                    // Read the response into a Stream object. 
                    Stream responseStream = response.GetResponseStream();
                    using (var reader = new StreamReader(responseStream))
                    {
                        data = reader.ReadToEnd();
                    }
                    responseStream.Close();
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        return data;
                    }
                    else
                    {
                        if (response.StatusCode == HttpStatusCode.Unauthorized)
                        {
                            return "No autorizado";
                        }
                        else if (response.StatusCode == HttpStatusCode.BadRequest)
                        {
                            return "Solicitud incorrecta";
                        }
                        else
                        {
                            return "Error de conexión";
                        }
                    }
                }
            }
            catch (Exception e)
            {
                return "Error: " + e.Message;
            }
        }

        public async Task<string> PutRequest(string url, string json)
        {
            Uri uri = new Uri(url);
            var request = (HttpWebRequest)WebRequest.Create(uri);
            var credentialCache = new CredentialCache();

            credentialCache.Add(
              new Uri(uri.GetLeftPart(UriPartial.Authority)),
              "Digest",  // authentication type 
              new NetworkCredential("admin", "ivandavid121")
            );

            request.Method = "PUT";
            request.ContentType = "application/json";
            request.Credentials = credentialCache;

            try
            {
                // Write the request Asynchronously 
                using (var stream = await Task.Factory.FromAsync<Stream>(request.BeginGetRequestStream, request.EndGetRequestStream, null))
                {
                    byte[] byteArray = Encoding.UTF8.GetBytes(json);

                    // Write the bytes to the stream
                    await stream.WriteAsync(byteArray, 0, byteArray.Length);
                }

                using (var response = (HttpWebResponse)await request.GetResponseAsync())
                {
                    string data;

                    // Read the response into a Stream object. 
                    Stream responseStream = response.GetResponseStream();
                    using (var reader = new StreamReader(responseStream))
                    {
                        data = reader.ReadToEnd();
                    }
                    responseStream.Close();
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        return data;
                    }
                    else
                    {
                        if (response.StatusCode == HttpStatusCode.Unauthorized)
                        {
                            return "No autorizado";
                        }
                        else if (response.StatusCode == HttpStatusCode.BadRequest)
                        {
                            return "Solicitud incorrecta";
                        }
                        else
                        {
                            return "Error de conexión";
                        }
                    }
                }
            }
            catch (Exception e)
            {
                return "Error: " + e.Message;
            }
        }

        public string GetRequest(string url)
        {
            Uri uri = new Uri(url);
            var request = (HttpWebRequest)WebRequest.Create(uri);
            var credentialCache = new CredentialCache();

            credentialCache.Add(
              new Uri(uri.GetLeftPart(UriPartial.Authority)),
              "Digest",  // authentication type 
              new NetworkCredential("admin", "ivandavid121")
            );

            //request.Method = "POST";
            request.ContentType = "application/json";
            request.Credentials = credentialCache;

            try
            {
                var httpResponse = (HttpWebResponse)request.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    return result;
                }
                //HttpStatusCode statusCode = httpResponse.StatusCode;
            }
            catch (Exception e)
            {
                return "Error: " + e;
            }
        }

        public bool PingHost(string hostUri, int portNumber)
        {
            try
            {
                using (var client = new TcpClient(hostUri, portNumber))
                    return true;
            }
            catch 
            {
                return false;
            }
        }
    }
}
