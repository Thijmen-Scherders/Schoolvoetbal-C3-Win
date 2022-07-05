using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ultimehoofdpijn_2_electric_boogaloo_FEAT_melancholie
{
    public partial class testing : Form
    {
        public testing()
        {
            InitializeComponent();
            GetMatch("1");
            //GetAllMatches();
            
        }

        private void test_Load(object sender, EventArgs e)
        {

        }

        private string TestURL = "http://c3-schoolvoetbal.test";

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        public async Task<string> GetAllMatches()
        {
            try
            {
                using (var Client = new HttpClient())
                {
                    Client.BaseAddress = new Uri(TestURL);
                    Client.DefaultRequestHeaders.Accept.Clear();
                    Client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));


                    HttpResponseMessage responce = await Client.GetAsync("/api/matches");
                    if (responce.IsSuccessStatusCode)
                    {
                        var Json = await responce.Content.ReadAsStringAsync();
                        var myJArray = JArray.Parse(Json);
                        foreach (var jsonObject in myJArray)
                        {
                            Match deserializedProduct = JsonConvert.DeserializeObject<Match>(jsonObject.ToString());

                            if (deserializedProduct.finished == true)
                            {
                                //HttpResponseMessage response = await Client.GetAsync($"/api/matches?match_id={deserializedProduct.id}");
                                listBox1.Items.Add(deserializedProduct.team1_name + " VS " + deserializedProduct.team2_name);
                            }
                            else
                            {
                                listBox2.Items.Add(deserializedProduct.team1_name + " VS " + deserializedProduct.team2_name);
                            }
                        }
                        return Json;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }


        public async Task<string> GetAllResults()
        {
            try
            {
                using (var Client = new HttpClient())
                {
                    Client.BaseAddress = new Uri(TestURL);
                    Client.DefaultRequestHeaders.Accept.Clear();
                    Client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));


                    HttpResponseMessage responce = await Client.GetAsync("/api/matches");
                    if (responce.IsSuccessStatusCode)
                    {
                        var Json = await responce.Content.ReadAsStringAsync();
                        var myJArray = JArray.Parse(Json);
                        foreach (var jsonObject in myJArray)
                        {
                            Match deserializedProduct = JsonConvert.DeserializeObject<Match>(jsonObject.ToString());

                            if (deserializedProduct.finished == true)
                            {
                                HttpResponseMessage response = await Client.GetAsync($"/api/matches?match_id={deserializedProduct.id}");
                                listBox1.Items.Add(deserializedProduct.team1_name + " VS " + deserializedProduct.team2_name);
                            }
                            else
                            {
                                listBox2.Items.Add(deserializedProduct.team1_name + " VS " + deserializedProduct.team2_name);
                            }
                        }
                        return Json;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }


        public async Task<string> GetMatch(string id)
        {
            try
            {
                using (var Client = new HttpClient())
                {
                    Client.BaseAddress = new Uri(TestURL);
                    Client.DefaultRequestHeaders.Accept.Clear();
                    Client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = await Client.GetAsync($"/api/match?match_id={id}");
F
                    if (response.IsSuccessStatusCode)
                    {
                        var Json = await response.Content.ReadAsStringAsync();
                        
                        Match match = JsonConvert.DeserializeObject<Match>(JObject.Parse(Json).ToString());
                        bool run = true;
                        while (run == true)
                        {
                            listBox1.Items.Add(match.team1_name);
                            listBox2.Items.Add(match.team2_name);
                            run = false;
                        }
                            
                        return Json;

                    }
                    else
                    {
                        listBox2.Items.Add("failed");
                        return null;
                    }
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
