using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using Microsoft.Web.WebView2.WinForms;
using Portal_Speedrunning_Guide_App.Models;

namespace Portal_Speedrunning_Guide_App
{
    public partial class Form2 : Form
    {
        private Dictionary<string, List<StratInfo>> linkData;
        private Dictionary<string, List<string>> descData;
        private Dictionary<string, List<string>> rankData;

        private List<StratInfo> currentStrats;
        private string currentDesc;
        private string currentRank;
        public Form2()
        {
            InitializeComponent();

            CBCategory.Items.AddRange(new string[] { "Out of Bounds", "Inbounds", "Inbounds No SLA", "Glitchless" });
            CBMap.Items.AddRange(new string[] { "00/01", "02/03", "04/05", "06/07", "08", "09", "10", "11/12", "13", "14", "15", "16", "17", "18", "19", "e00", "e01", "e02" });

            CBCategory.SelectedIndexChanged += UpdateStratsList;
            CBMap.SelectedIndexChanged += UpdateStratsList;


            this.Text = "Portal Speedrunning Guide";


            webView21.EnsureCoreWebView2Async();

            LoadLinks();
            LoadDesc();
            LoadRank();
        }

        private void LoadLinks()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "links.json");
            string json = System.IO.File.ReadAllText(path);
            linkData = JsonSerializer.Deserialize<Dictionary<string, List<StratInfo>>>(json);
        }

        private void LoadDesc()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "desc.json");
            string json = System.IO.File.ReadAllText(path);
            descData = JsonSerializer.Deserialize<Dictionary<string, List<string>>>(json);
        }
        private void LoadRank()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "rank.json");
            string json = System.IO.File.ReadAllText(path);
            rankData = JsonSerializer.Deserialize<Dictionary<string, List<string>>>(json);
        }

        private void SelectedMap(string key)
        {
            LBStrats.Items.Clear();
            currentStrats = null;

            if (linkData.TryGetValue(key, out var strats))
            {
                currentStrats = strats;
                foreach (var strat in strats)
                {
                    LBStrats.Items.Add(strat.Name);
                }


            }
        }

        private void UpdateStratsList(object sender, EventArgs e)
        {
            LBStrats.Items.Clear();

            if (CBMap.SelectedItem == null || CBCategory.SelectedItem == null)
            {
                MessageBox.Show("Ok, then select a category or a map.", "Map & Category Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            string category = CBCategory.SelectedItem.ToString();
            string map = CBMap.SelectedItem.ToString();

            labelMap.Text = map;

            string key = GetMapKey(category, map);

            SelectedMap(key);

        }

        private string GetMapKey(string category, string map)
        {
            if (category == "Out of Bounds" && map == "00/01")
                return "OoB00";
            if (category == "Out of Bounds" && map == "02/03")
                return "OoB02";
            if (category == "Out of Bounds" && map == "04/05")
                return "OoB04";
            if (category == "Out of Bounds" && map == "06/07")
                return "OoB06";
            if (category == "Out of Bounds" && map == "08")
                return "OoB08";
            if (category == "Out of Bounds" && map == "09")
                return "OoB09";
            if (category == "Out of Bounds" && map == "10")
                return "OoB10";
            if (category == "Out of Bounds" && map == "11/12")
                return "OoB11";
            if (category == "Out of Bounds" && map == "13")
                return "OoB13";
            if (category == "Out of Bounds" && map == "14")
                return "OoB13";
            if (category == "Out of Bounds" && map == "15")
                return "OoB13";
            if (category == "Out of Bounds" && map == "16")
                return "OoB13";
            if (category == "Out of Bounds" && map == "17")
                return "OoB13";
            if (category == "Out of Bounds" && map == "18")
                return "OoB13";
            if (category == "Out of Bounds" && map == "19")
                return "OoB19";
            if (category == "Out of Bounds" && map == "e00")
                return "OoBe00";
            if (category == "Out of Bounds" && map == "e01")
                return "OoBe01";
            if (category == "Out of Bounds" && map == "e02")
                return "OoBe02";
            if (category == "Inbounds" && map == "00/01")
                return "IB00";
            if (category == "Inbounds" && map == "02/03")
                return "IB02";
            if (category == "Inbounds" && map == "04/05")
                return "IB04";
            if (category == "Inbounds" && map == "06/07")
                return "IB06";
            if (category == "Inbounds" && map == "08")
                return "IB08";
            if (category == "Inbounds" && map == "09")
                return "IB09";
            if (category == "Inbounds" && map == "10")
                return "IB10";
            if (category == "Inbounds" && map == "11/12")
                return "IB11";
            if (category == "Inbounds" && map == "13")
                return "IB13";
            if (category == "Inbounds" && map == "14")
                return "IB14";
            if (category == "Inbounds" && map == "15")
                return "IB15";
            if (category == "Inbounds" && map == "16")
                return "IB16";
            if (category == "Inbounds" && map == "17")
                return "IB17";
            if (category == "Inbounds" && map == "18")
                return "IB18";
            if (category == "Inbounds" && map == "19")
                return "IB19";
            if (category == "Inbounds" && map == "e00")
                return "IBe00";
            if (category == "Inbounds" && map == "e01")
                return "IBe01";
            if (category == "Inbounds" && map == "e02")
                return "IBe02";
            if (category == "Inbounds No SLA" && map == "00/01")
                return "IBNSLA00";
            if (category == "Inbounds No SLA" && map == "02/03")
                return "IBNSLA02";
            if (category == "Inbounds No SLA" && map == "04/05")
                return "IBNSLA04";
            if (category == "Inbounds No SLA" && map == "06/07")
                return "IBNSLA06";
            if (category == "Inbounds No SLA" && map == "08")
                return "IBNSLA08";
            if (category == "Inbounds No SLA" && map == "09")
                return "IBNSLA09";
            if (category == "Inbounds No SLA" && map == "10")
                return "IBNSLA10";
            if (category == "Inbounds No SLA" && map == "11/12")
                return "IBNSLA11";
            if (category == "Inbounds No SLA" && map == "13")
                return "IBNSLA13";
            if (category == "Inbounds No SLA" && map == "14")
                return "IBNSLA14";
            if (category == "Inbounds No SLA" && map == "15")
                return "IBNSLA15";
            if (category == "Inbounds No SLA" && map == "16")
                return "IBNSLA16";
            if (category == "Inbounds No SLA" && map == "17")
                return "IBNSLA17";
            if (category == "Inbounds No SLA" && map == "18")
                return "IBNSLA18";
            if (category == "Inbounds No SLA" && map == "19")
                return "IBNSLA19";
            if (category == "Inbounds No SLA" && map == "e00")
                return "IBNSLAe00";
            if (category == "Inbounds No SLA" && map == "e01")
                return "IBNSLAe01";
            if (category == "Inbounds No SLA" && map == "e02")
                return "IBNSLAe02";
            if (category == "Glitchless" && map == "00/01")
                return "Gless00";
            if (category == "Glitchless" && map == "02/03")
                return "Gless02";
            if (category == "Glitchless" && map == "04/05")
                return "Gless04";
            if (category == "Glitchless" && map == "06/07")
                return "Gless06";
            if (category == "Glitchless" && map == "08")
                return "Gless08";
            if (category == "Glitchless" && map == "09")
                return "Gless09";
            if (category == "Glitchless" && map == "10")
                return "Gless10";
            if (category == "Glitchless" && map == "11/12")
                return "Gless11";
            if (category == "Glitchless" && map == "13")
                return "Gless13";
            if (category == "Glitchless" && map == "14")
                return "Gless14";
            if (category == "Glitchless" && map == "15")
                return "Gless15";
            if (category == "Glitchless" && map == "16")
                return "Gless16";
            if (category == "Glitchless" && map == "17")
                return "Gless17";
            if (category == "Glitchless" && map == "18")
                return "Gless18";
            if (category == "Glitchless" && map == "19")
                return "Gless19";
            if (category == "Glitchless" && map == "e00")
                return "Glesse00";
            if (category == "Glitchless" && map == "e01")
                return "Glesse01";
            if (category == "Glitchless" && map == "e02")
                return "Glesse02";
            return null;
        }

        private async void LBStrats_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = LBStrats.SelectedIndex;

            currentDesc = null;
            currentRank = null;

            if (index >= 0 && index < currentStrats.Count)
            {
                string url = currentStrats[index].Url;
                string embedUrl = ConvertToEmbedUrl(url);
                webView21.Source = new Uri($"{embedUrl}?autoplay=1");

                string key = GetMapKey(CBCategory.SelectedItem.ToString(), CBMap.SelectedItem.ToString());

                if (descData.TryGetValue(key, out var descs) && index < descs.Count)
                {
                    currentDesc = descs[index];
                    textBox1.Text = currentDesc;
                }

                if (rankData.TryGetValue(key, out var ranks) && index < ranks.Count)
                {
                    currentRank = ranks[index];
                    labelRank.Text = currentRank;
                }
            }
        }

        private string ConvertToEmbedUrl(string url)
        {
            try
            {
                var uri = new Uri(url);
                string videoId = "";

                if (uri.Host.Contains("youtu.be"))
                {
                    videoId = uri.AbsolutePath.Trim('/');
                }
                else if (uri.Host.Contains("youtube.com"))
                {
                    var query = System.Web.HttpUtility.ParseQueryString(uri.Query);
                    videoId = query.Get("v");
                }

                return $"https://www.youtube.com/embed/{videoId}";
            }
            catch (Exception)
            {

                return "";
            }
        }
    }
}
