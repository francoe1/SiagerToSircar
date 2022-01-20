using System;
using System.Collections.Generic;
using System.IO;

namespace CoreApp
{
    public static class Config
    {
        private static Dictionary<string, string> _options { get; set; } = new Dictionary<string, string>();

        static Config()
        {
            _options = ReadConfigFile(AppDomain.CurrentDomain.BaseDirectory + "conf.ini");
        }

        private static Dictionary<string, string> ReadConfigFile(string path)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            if (!File.Exists(path)) return dictionary;
            foreach (string line in File.ReadAllLines(path))
            {
                if (line.Length == 0 || line.StartsWith("#")) continue;
                string[] pair = line.Split('=');
                if (pair.Length != 2) continue;
                if (!dictionary.ContainsKey(pair[0])) dictionary.Add(pair[0], pair[1]);
            }

            return dictionary;
        }

        public static int ReadInt(string key, int defaultValue = default)
        {
            if (!_options.ContainsKey(key)) return defaultValue;
            return int.Parse(_options[key]);
        }

        public static string ReadString(string key, string defaultValue = default)
        {
            if (!_options.ContainsKey(key)) return defaultValue;
            return _options[key];
        }

    }
}
