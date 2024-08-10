using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHIELD
{
    sealed class RefuseConnection
    {
        public RefuseConnection()
        {
            try
            {
                for (int i = 1; i <= 50; i++)
                {
                    ProcessStartInfo psi = new ProcessStartInfo()
                    {
                        FileName = "powershell.exe",
                        Arguments = $"Set-dnsclientserveraddress -InterfaceIndex {i} -ResetServerAddresses",
                        CreateNoWindow = true,
                        UseShellExecute = true,
                        WindowStyle = ProcessWindowStyle.Hidden

                    };
                    Process process = new Process()
                    {
                        StartInfo = psi,
                    };

                    process.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            Application.Exit();
        }
    }
}
