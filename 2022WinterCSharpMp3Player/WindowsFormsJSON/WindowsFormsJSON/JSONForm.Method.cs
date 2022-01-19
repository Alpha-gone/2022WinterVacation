using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsJSON
{
    public partial class JSONForm:Form
    {
        public void ClickMethod()
        {
            btnCreate.Click += BtnCreate_Click;
            btnWrite.Click += BtnWrite_Click;
            btnRead.Click += BtnRead_Click;
        }
        string path = @"D:\WinterVacation\SampleData\Sample.json";
        private void BtnCreate_Click(object sender, EventArgs e)
        {
            if (!File.Exists(path))
            {
                using (File.Create(path))
                {
                    lbState.Text = "파일 생성 완료";
                }
            }
            else
            {
                lbState.Text = "이미 파일이 존재함";
            }
        }

        private void BtnWrite_Click(object sender, EventArgs e)
        {
            inputJSON(path);
        }

        private void inputJSON(string path)
        {
            if (File.Exists(path))
            {
                string[] devices = new string[] { "dev1", "dev2", "dev3", "dev4" };
                JObject hostData = new JObject(
                    new JProperty("HOST", "127.0.0.1"),
                    new JProperty("PORT", "1227"),
                    new JProperty("USER", "daelim"),
                    new JProperty("ID", "dluse01"),
                    new JProperty("PASSWORD", "012301234"),
                    new JProperty("ETC", "interface")
                    );

                hostData.Add("DEVICES", JArray.FromObject(devices));
                File.WriteAllText(path, hostData.ToString());
                txtData.Text = hostData.ToString();
                lbState.Text = "파일 쓰기 완료";
            }
        }

        private void BtnRead_Click(object sender, EventArgs e)
        {
            string str = "";
            string strDevices = "";

            using(StreamReader file = File.OpenText(path))
            using (JsonTextReader reder = new JsonTextReader(file))
            {
                JObject json = (JObject)JToken.ReadFrom(reder);
                Device device = new Device();
                device.HOST = json["HOST"].ToString();
                device.PORT = json["PORT"].ToString();
                device.USER = json["USER"].ToString();
                device.ID = json["ID"].ToString();
                device.PASSWORD = json["PASSWORD"].ToString();
                device.ETC = json["ETC"].ToString();

                var devices = json.SelectToken("DEVICES");
                var count = devices.Count();

                for (int i = 0; i < count; i++)
                {
                    var name = devices[i].ToString();
                    if(i == 0)
                    {
                        strDevices += $"{name}";
                    }
                    else
                    {
                        strDevices += $", {name}";
                    }
                }

                str = $"HOST : {device.HOST}\n" +
                    $"PORT : {device.PORT}\n" +
                    $"USER : {device.USER}\n" +
                    $"ID : {device.ID}\n" +
                    $"PASSWORD : {device.PASSWORD}\n" +
                    $"ETC : {device.ETC}\n" +
                    "DEVICES : " + strDevices;

                txtData.Text = str;
                lbState.Text = "파일 읽기 완료";
            }
        }

        
    }
}
