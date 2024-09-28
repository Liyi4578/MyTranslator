using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Text.Json.Serialization;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using System.Text.Json.Nodes;

namespace MyTanslator
{
    internal class Config
    {
        #region code for singleton
        static private readonly object _mutex = new object();

        private Config()
        { }

        static private Config _uniqueConfig;

        static public Config GetInstance()
        {
            if (_uniqueConfig == null)
            {
                lock(_mutex)
                {
                    if (_uniqueConfig == null)
                    {
                        _uniqueConfig = new Config();
                    }
                }
            }
            return _uniqueConfig;
        }
        #endregion

        #region internal class and data member
        public class ProxySetting
        {
            public enum EnumProxyType
            {
                CustomProxy,
                NoProxy,
                SystemProxy
            }
            // 如何序列化枚举？
            [JsonInclude]
            public EnumProxyType ProxyType { set; get; } = EnumProxyType.NoProxy;

            [JsonInclude]
            public string ProxyServerIP { set; get; } = "127.0.0.1";

            [JsonInclude]
            public string ProxyServerPort { set; get; } = "10809";

            public ProxySetting() {}

        }

        [JsonInclude]
        [JsonPropertyName("ProxySetting")]
        private ProxySetting m_proxySetting = new ProxySetting();

        [JsonIgnore]
        public ProxySetting ProxyConfig => m_proxySetting;
        #endregion


        #region deal with config file

        // 设置 json 序列化的选项
        private JsonSerializerOptions m_serializationOptions = new JsonSerializerOptions()
        {
            IncludeFields = false, // 包含所有字段
            PropertyNameCaseInsensitive = true,
            WriteIndented = true,
            Converters =
            {
                new JsonStringEnumConverter()
            }
        };

        public void WriteToFile(string fullPath)
        {
            try
            {
                using (Stream fileStream = File.Create(fullPath))
                {
                    JsonSerializer.Serialize(utf8Json: fileStream, value: this, m_serializationOptions);
                }
                MyMessageDialog.ShowMessage("Write Succeed!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.GetType()} says {ex.Message}");
            }
        }

        public bool ReadConfigFile(string fullPath)
        {
            try
            {
                using (FileStream jsonLoad = File.Open(fullPath, FileMode.Open))
                {
                    JsonNode jsonNode= JsonNode.Parse(jsonLoad);
                    // 反序列化对象图为 List<Person>
                    m_proxySetting = JsonSerializer.Deserialize<ProxySetting>(
                        utf8Json: Encoding.UTF8.GetBytes(jsonNode["ProxySetting"].ToString()),
                        options: m_serializationOptions
                    );

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.GetType()} says {ex.Message}");
                return false;
            }
            return true;
        }

        #endregion
    }
}
