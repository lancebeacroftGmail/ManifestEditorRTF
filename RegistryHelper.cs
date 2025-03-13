using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManifestVieweRTF
{
    public class RegistryHelper
    {
        private const string RegistryPath = @"SOFTWARE\ManifestViewerRTF";

        public static void WriteRegistry(string key, string value)
        {
            using (RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(RegistryPath))
            {
                if (registryKey != null)
                {
                    registryKey.SetValue(key, value);
                }
            }
        }
        public static string ReadRegistry(string key)
        {
            using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(RegistryPath))
            {
                if (registryKey != null)
                {
                    return registryKey.GetValue(key)?.ToString();
                }
                return null;
            }
        }
    }
}

