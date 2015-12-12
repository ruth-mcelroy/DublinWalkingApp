using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Windows.UI.Xaml.Media;
using System.Net;
using Dublin_WalkingTourApp.Models;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace Dublin_WalkingTourApp.Data
{
   public class DataSource
   {
       public async Task<List<Walk>> WebRequestWalksAsync(string url)
       {
           WebRequest req = WebRequest.Create(url);

           req.ContentType = "text/xml";
           req.Method = "GET";

           string received;

           using (var response = (HttpWebResponse)(await Task<WebResponse>.Factory.FromAsync(req.BeginGetResponse, req.EndGetResponse, null)))
           {
               using (var responseStream = response.GetResponseStream())
               {
                   using (var sr = new StreamReader(responseStream))
                   {

                       received = await sr.ReadToEndAsync();
                   }
               }
           }

           List<Walk> result;

           var serializer = new XmlSerializer(typeof(Walk));

           using (var stream = new StringReader(received))
           using (var reader = XmlReader.Create(stream))
           {
               result = (List<Walk>)serializer.Deserialize(reader);
           }

           return result;          
       }
   }
}
