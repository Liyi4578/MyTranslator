using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace MyTanslator.src
{
    internal static class Translator
    {
        #region language enum
        public enum EnumLanguage : int
        {
           AUTO,
           CN,
           EN
        }

        public static List<string> MapLanguage { get; } = new List<string>()
        {
            "Auto","zh-CN","en"
        };
        #endregion

        #region translate
        public static string Translate(string text, EnumLanguage sourceLanguage, EnumLanguage dstLanguage)
        {
            string data = string.Concat("client=gtx&sl=",
                MapLanguage[((int)sourceLanguage)], 
                "&tl=", MapLanguage[((int)dstLanguage)], "&dt=t&q=",
            HttpUtility.UrlEncode(text)?.Replace("+", "%20"));


            var url = "https://translate.googleapis.com/translate_a/single?";
            var request_url = string.Concat(url, data);
            HttpWebRequest request =  (HttpWebRequest)WebRequest.Create(request_url);     //谷歌翻译API  
            // 设置HttpWebRequest请求的一些参数   
            request.MaximumAutomaticRedirections = 4;
            request.MaximumResponseHeadersLength = 4;
            request.Credentials = CredentialCache.DefaultCredentials;
            request.Method = "GET";
            try
            {
                if (Config.GetInstance().ProxyConfig.ProxyType == Config.ProxySetting.EnumProxyType.CustomProxy)
                {
                    string pro = "http://" + Config.GetInstance().ProxyConfig.ProxyServerIP +
                        ":" + Config.GetInstance().ProxyConfig.ProxyServerPort;
                    WebProxy proxy = new WebProxy(pro);
                    request.Proxy = proxy;
                }

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream receiveStream = response.GetResponseStream())
                using (StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8))
                {
                    string text_string = readStream.ReadToEnd();
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        return $"Call Google Translate API failed with " +
                            $"Status:[{response.StatusCode}]:[{response.StatusDescription}]";
                    }

                    string ret = System.String.Empty;
                    if (JsonArray.Parse(text_string) is JsonArray root)
                    {
                        if (root[0] is JsonArray resArray)
                        {
                            foreach (JsonArray resNode in resArray)
                            {
                                ret += resNode[0].ToString();
                            }
                        }
                    }
                    else
                    {
                        ret = "The result from google translator is not array!";
                    }
                    return ret;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.GetType()} says {ex.Message}");
                return "Call Google translate API failed!";
            }
        }

        #endregion
    }
}
