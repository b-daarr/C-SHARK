using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHIELD
{
    internal class ConfigTool
    {
        private Dictionary<int, string> configList = new Dictionary<int, string>();

        private void import()
        {
        }

        public void List(dynamic x)
        {
            for (int i = 0; i < configList.Count; i++)
            {
                RadioButton radioButton = new RadioButton();

                radioButton.ForeColor = Color.Yellow;
                radioButton.Location = new System.Drawing.Point(10, 30 * i + 1);
                radioButton.Size = new System.Drawing.Size(360, 30);
                radioButton.Text = configList[i];
                radioButton.Name = "C" + i;

                Config config = new Config();

                x.Controls.Add(radioButton);
            }
        }
    }
}
