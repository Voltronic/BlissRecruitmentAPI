using BlissRecruitmentAPICaller.Classes;
using Newtonsoft.Json.Linq;
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
        Question question = new Question();

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
            try
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
            catch (Exception ex) { txtResult.Text = ex.Message; }
        }

        private async void btnQuestionGet_Click(object sender, EventArgs e)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("api/questions/" + txtQuestionIdGet.Text);
                txtResult.Text = await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex) { txtResult.Text = ex.Message; }
        }

        private async void btnQuestionsPost_Click(object sender, EventArgs e)
        {
            try
            {
                PostQuestionDTO postQuestionDTO = new PostQuestionDTO();
                postQuestionDTO.question = txtQuestionPost.Text;
                postQuestionDTO.image_url = "image_url/example";
                postQuestionDTO.thumb_url = "thumb_url/example";
                postQuestionDTO.published_at = DateTime.Now;
                postQuestionDTO.choices = new List<ChoiceDTO>();
                postQuestionDTO.choices.Add(new ChoiceDTO() { choice = txtChoicePost.Text });

                HttpResponseMessage response = await client.PostAsync("api/questions/", postQuestionDTO.AsJson());
                txtResult.Text = await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex) { txtResult.Text = ex.Message; }
        }

        private async void btnQuestionsPut_Click(object sender, EventArgs e)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("api/questions/" + txtQuestionIdPost.Text);
                txtResult.Text = await response.Content.ReadAsStringAsync();

                string str = @"{'question' : " + txtResult.Text.Replace("\"", "'").Substring(1, txtResult.Text.Length - 2) + "}";

                JObject jObject = JObject.Parse(str);
                JToken jQuestion = jObject["question"];

                question = new Question()
                {
                    id = (int)jQuestion["id"],
                    question = (string)jQuestion["question"],
                    image_url = (string)jQuestion["image_url"],
                    thumb_url = (string)jQuestion["thumb_url"],
                    published_at = (DateTime)jQuestion["published_at"],
                    choices = jQuestion["choices"].ToObject<List<Choice>>()
                };

                question.question = txtQuestionPut.Text;
                var toDelete = question.choices.First<Choice>();

                question.choices.Remove(toDelete);
                question.choices.Add(new Choice() { choice = toDelete.choice, votes = int.Parse(txtVotes.Text) });

                response = await client.PutAsync("api/questions/" + txtQuestionIdPost.Text, question.AsJson());
                txtResult.Text = await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex) { txtResult.Text = ex.Message; }
        }

        private async void btnShare_Click(object sender, EventArgs e)
        {
            try
            {
                var builder = new UriBuilder(txtBaseAddress.Text + "/api/share");
                builder.Port = int.Parse(txtBaseAddress.Text.Substring(txtBaseAddress.Text.LastIndexOf(':') + 1));
                var query = HttpUtility.ParseQueryString(builder.Query);
                if (txtDestinationEmail.Text != "")
                    query["destination_email"] = txtDestinationEmail.Text;
                if (txtContentUrl.Text != "")
                    query["content_url"] = txtContentUrl.Text;
                builder.Query = query.ToString();
                string url = builder.ToString();

                HttpContent content;
                HttpResponseMessage response = await client.PostAsync(url, content);
                txtResult.Text = await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex) { txtResult.Text = ex.Message; }
        }
    }
}
