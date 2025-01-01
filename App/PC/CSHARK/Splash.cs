using System.Diagnostics;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CSHARK
{
    public partial class Splash : Form
    {
        #region Variables and Calling methods
        Global global = new Global();
        Lobby lobby = new Lobby();
        #endregion

        #region Constructor
        public Splash()
        {
            InitializeComponent();
            ExistTest();
            File.AppendAllText(global.appLog(), global.logMessageAC);
        }
        #endregion

        #region App Starting
        private void Splash_Load(object sender, EventArgs e)
        {
            File.AppendAllText(global.appLog(), global.logMessageAS);
        }
        #endregion

        #region Test for Existing Root Files
        void ExistTest()
        {
            try
            {
                if (File.Exists(global.appLog()) && File.Exists(global.appSetting()) && File.Exists(global.appConfig()))
                {
                    global.jsObject(JObject.Parse(File.ReadAllText(global.appConfig())));
                    File.AppendAllText(global.appLog(), global.logMessageRFET("+") + global.logMessageRFRT("-"));

                    splashing.Tick += new EventHandler(splashing_Tick);
                    splashing.Start();
                }
                else
                {
                    File.WriteAllText(global.appSetting(), JsonConvert.SerializeObject(global.settingData(), Formatting.Indented));
                    File.WriteAllText(global.appConfig(), JsonConvert.SerializeObject(global.configData(), Formatting.Indented));
                    global.jsObject(JObject.Parse(File.ReadAllText(global.appConfig())));

                    File.AppendAllText(global.appLog(), global.logMessageRFET("-") + global.logMessageRFRT("+"));

                    splashing.Tick += new EventHandler(splashing_Tick);
                    splashing.Start();
                }
            }
            catch (Exception ex)
            {
                global.x52464E45();
                global.errorSender();
            }
        }
        #endregion

        #region features
        private void splashing_Tick(object sender, EventArgs e)
        {
            splashing.Stop();
            try
            {
                lobby.Show();
                File.AppendAllText(global.appLog(), global.logMessageSR);
                this.Hide();
            }
            catch (Exception ex)
            {
                global.x50444E52();
                global.errorSender();
            }
        }
        #endregion
    }
}
