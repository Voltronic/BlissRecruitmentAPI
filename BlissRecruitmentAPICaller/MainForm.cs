using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace BlissRecruitmentAPICaller
{
    public partial class MainForm : Form
    {
        static HttpClient client;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(txtBaseAddress.Text);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        private async void btnStatus_Click(object sender, EventArgs e)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("api/health");
                txtResult.Text = await response.Content.ReadAsStringAsync();
            }
            catch(Exception ex) { txtResult.Text = ex.Message; }
        }

        private async void btnQuestionsGetQuery_Click(object sender, EventArgs e)
        {
            var builder = new UriBuilder(txtBaseAddress.Text + "/api/questions");
            builder.Port = int.Parse(txtBaseAddress.Text.Substring(txtBaseAddress.Text.LastIndexOf(':') + 1));
            var query = HttpUtility.ParseQueryString(builder.Query);
            if (txtLimit.Text != "")
                query["limit"] = txtLimit.Text;
            if (txtOffset.Text != "")
                query["offset"] = txtOffset.Text;
            if (txtFilter.Text != "")
                query["filter"] = txtFilter.Text;
            builder.Query = query.ToString();
            string url = builder.ToString();

            HttpResponseMessage response = await client.GetAsync(url);
            txtResult.Text = await response.Content.ReadAsStringAsync();
        }
    }
}
