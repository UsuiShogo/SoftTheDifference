namespace SlackPost
{
    public partial class FormSlackPost : Form
    {
        public FormSlackPost()
        {
            InitializeComponent();
        }

        private void butPost_Click(object sender, EventArgs e)
        {
            string strWebHookUrl = "https://hooks.slack.com/services/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";
            string strData = string.Format("{{'text' : '{0}'}}", txtPost.Text);
            //string strData = "{" + $"'text':'{txtPost.Text}'" + "}";
            // {{'text' : '‚ ‚¢‚¤‚¦‚¨'}}
            System.Net.WebClient client = new System.Net.WebClient();
            //var cl = new System.Net.Http.HttpClient();
            client.Headers.Add(System.Net.HttpRequestHeader.ContentType, "application/json;charset=UTF-8");
            client.Encoding = System.Text.Encoding.UTF8;
            string reply = client.UploadString(strWebHookUrl, strData);
            MessageBox.Show( reply );
        }
    }
}
