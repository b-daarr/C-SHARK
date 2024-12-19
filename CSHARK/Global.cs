using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace CSHARK
{
    internal class Global
    {
        #region Encapsulated Variables
        readonly string appLogDirectory = @"C:\\ProgramData\C_SHARK\app.log";
        readonly string appSettingDirectory = @"C:\\ProgramData\C_SHARK\setting.json";
        readonly string appConfigDirectory = @"C:\\ProgramData\C_SHARK\config.json";
        JObject jsonObject;

        readonly JObject settings = JObject.Parse(@"{
            'app_launched': false,
            'app_theme': 'light'
        }");

        readonly JObject configuration = JObject.Parse(@"{ 
            'config_list': [
                { 
                    'config_name': 'Troubleshooter', 
                    'preferred_dns_server_ip': '1.1.1.1', 
                    'alternate_dns_server_ip': '8.8.8.8'
                }
            ]
        }");
        #endregion

        #region Allowed Variables
        public string appLog()
        {
            return appLogDirectory;
        }
        public string appSetting()
        {
            return appSettingDirectory;
        }
        public string appConfig()
        {
            return appConfigDirectory;
        }
        public void jsObject(dynamic value)
        {
            jsonObject = value;
        }
        public dynamic settingData()
        {
            return settings;
        }
        public dynamic configData()
        {
            return configuration;
        }
        #endregion

        #region Log Messages
        public string logMessageAC = DateTime.Now.ToString() + " [ > ] Application Called\n";
        public string logMessageAS = DateTime.Now.ToString() + " [ > ] Application Started\n";
        public string logMessageSR = DateTime.Now.ToString() + " [ > ] Application Service Running\n";
        public string logMessageAE = DateTime.Now.ToString() + " [ > ] Application Closed\n";
        public string logMessageRFET(string State)
        {
            return DateTime.Now.ToString() + " [ "+ State +" ] Root Files Existing Test\n";
        }
        public string logMessageRFRT(string State)
        {
            return DateTime.Now.ToString() + " [ "+ State +" ] Root Files Remaking Test\n";
        }
        #endregion

        #region Error Messages
        public string errorName;
        public string errorDescription;
        string errorCode;

        // PDNR ---> Program Does Not Run
        public void x50444E52()
        {
            errorName = "Program Does Not Run";
            errorCode = "x50444E52";
            errorDescription = "The app cannot run, the problem is expected to be with the program's prerequistes;\n\nPlease update the app prerequistes or reinstall app...\n\nError " + errorCode;
        }

        // RFNE ---> Root File Not Exist
        public void x52464E45()
        {
            errorName = "Root File Not Exist";
            errorCode = "x52464E45";
            errorDescription = "The app's resources have been destroyed and attemps to restore or reset the app were unsuccessful;\n\nPlease repaire the app...\n\nError " + errorCode;
        }

        public void errorSender()
        {
            var msg = MessageBox.Show(errorDescription, errorName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (msg == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        #endregion
    }
}
