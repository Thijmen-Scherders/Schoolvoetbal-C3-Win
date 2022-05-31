using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ultimehoofdpijn_2_electric_boogaloo_FEAT_melancholie
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnLogoff_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void fetchArray()
        {// Set the URL
            string url = "http://127.0.0.1:8000/api/arrayfetcher";
            Debug.WriteLine("Calling: " + url);
            // Create a 'WebRequest' object with the specified url.
            WebRequest request = WebRequest.Create(url);

            // Send the 'WebRequest' and wait for response.
            WebResponse response = request.GetResponse();
            using (Stream stream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                String responseString = reader.ReadToEnd();
                Debug.WriteLine(responseString);
                Debug.WriteLine("Deserializing");
                // Describe the expected response
                var formatter = new { status = 0, payload = "" };
                var data = JsonConvert.DeserializeAnonymousType(responseString, formatter);
                // Check response
                if (data.status == 1)
                {
                    Debug.WriteLine($"Status: {data.status}");
                    Debug.WriteLine($"Payload: {data.payload}");
                }
                else
                {
                    Debug.WriteLine($"Unexpected status code received: {data.status}");
                }
            }
            // Close the streams and the responeresponse.Close();}}
        }
    }
}
