using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreOCR.Services.Utilities
{
    public class SettingUrl
    {
        public static Dictionary<String, String> GetPort()
        {
            string fileName = "\\Ports/API.txt";

            string currentPath = Directory.GetCurrentDirectory() + fileName;
            Dictionary<String, String> MySettings = File
                                                .ReadLines(currentPath)
                                                .ToDictionary(line => line.Substring(0, line.IndexOf('=')).Trim(),
                                                line => line.Substring(line.IndexOf('=') + 1).Trim());

            return MySettings;
        }
        public static string GetAddress()
        {
            Dictionary<String, String> settings = GetPort();
            return settings["http"] + "://" + settings["domain"] + ":" + settings["port"] + "/";
        }
        public static Dictionary<String, String> GetHealthRecordsPort()
        {
            string fileName = "\\Ports/HealthRecords.txt";

            string currentPath = Directory.GetCurrentDirectory() + fileName;
            Dictionary<String, String> MySettings = File
                                                .ReadLines(currentPath)
                                                .ToDictionary(line => line.Substring(0, line.IndexOf('=')).Trim(),
                                                line => line.Substring(line.IndexOf('=') + 1).Trim());

            return MySettings;
        }

        public static Dictionary<String, String> GetIDCPort()
        {
            string fileName = "\\Ports/IDCards.txt";

            string currentPath = Directory.GetCurrentDirectory() + fileName;
            Dictionary<String, String> MySettings = File
                                                .ReadLines(currentPath)
                                                .ToDictionary(line => line.Substring(0, line.IndexOf('=')).Trim(),
                                                line => line.Substring(line.IndexOf('=') + 1).Trim());

            return MySettings;
        }

        public static Dictionary<String, String> GetVehicleRegisPort()
        {
            string fileName = "\\Ports/VehicleRegistration.txt";

            string currentPath = Directory.GetCurrentDirectory() + fileName;
            Dictionary<String, String> MySettings = File
                                                .ReadLines(currentPath)
                                                .ToDictionary(line => line.Substring(0, line.IndexOf('=')).Trim(),
                                                line => line.Substring(line.IndexOf('=') + 1).Trim());

            return MySettings;
        }
        public static Dictionary<String, String> GetAdministrativeDocumentsPort()
        {
            string fileName = "\\Ports/AdministrativeDocuments.txt";

            string currentPath = Directory.GetCurrentDirectory() + fileName;
            Dictionary<String, String> MySettings = File
                                                .ReadLines(currentPath)
                                                .ToDictionary(line => line.Substring(0, line.IndexOf('=')).Trim(),
                                                line => line.Substring(line.IndexOf('=') + 1).Trim());

            return MySettings;
        }
        public static Dictionary<String, String> GetTransferPaperPort()
        {
            string fileName = "\\Ports/TransferPaper.txt";

            string currentPath = Directory.GetCurrentDirectory() + fileName;
            //DirectoryInfo dir = new DirectoryInfo(currentPath);
            //List<DirectoryInfo> listDir = Split(dir);
            //string settingFilePath = listDir[listDir.Count - 5].ToString() + fileName;

            Dictionary<String, String> MySettings = File
                                                .ReadLines(currentPath)
                                                .ToDictionary(line => line.Substring(0, line.IndexOf('=')).Trim(),
                                                line => line.Substring(line.IndexOf('=') + 1).Trim());

            return MySettings;
        }
        public static string GetHealthRecordsAddress()
        {
            Dictionary<String, String> settings = GetHealthRecordsPort();
            return settings["http"] + "://" + settings["domain"] + ":" + settings["port"] + "/";
        }
        public static string GetIDCAddress()
        {
            Dictionary<String, String> settings = GetIDCPort();
            return settings["http"] + "://" + settings["domain"] + ":" + settings["port"] + "/";
        }
        public static string GetVehicleRegisAddress()
        {
            Dictionary<String, String> settings = GetVehicleRegisPort();
            return settings["http"] + "://" + settings["domain"] + ":" + settings["port"] + "/";
        }
        public static string GetAdministrativeDocumentsAddress()
        {
            Dictionary<String, String> settings = GetAdministrativeDocumentsPort();
            return settings["http"] + "://" + settings["domain"] + ":" + settings["port"] + "/";
        }
        public static string GetTransferPaperAddress()
        {
            Dictionary<String, String> settings = GetTransferPaperPort();
            return settings["http"] + "://" + settings["domain"] + ":" + settings["port"] + "/";
        }
    }
}
