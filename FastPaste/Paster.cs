using System;
using System.Collections.Specialized;
using System.Net;
using System.Text;

namespace PasteRight
{
    class Paster
    {
        private string ILoginURL = "http://pastebin.com/api/api_login.php";
        private string IPostURL = "http://pastebin.com/api/api_post.php";
        private string IDevKey = "";
        private string IUserKey = null;

        public void Send(string IBody, string ISubj, string IFormat)
        {
            if (string.IsNullOrEmpty(IBody.Trim())) { return; }
            if (string.IsNullOrEmpty(ISubj.Trim())) { return; }

            NameValueCollection IQuery = new NameValueCollection();

            IQuery.Add("api_dev_key", IDevKey);
            IQuery.Add("api_option", "paste");
            IQuery.Add("api_paste_code", IBody);
            IQuery.Add("api_paste_private", "0");
            IQuery.Add("api_paste_name", ISubj);
            IQuery.Add("api_paste_expire_date", "N");
            IQuery.Add("api_paste_format", IFormat);
            IQuery.Add("api_user_key", IUserKey);

            using (WebClient IClient = new WebClient())
            {
                string IResponse = Encoding.UTF8.GetString(IClient.UploadValues(IPostURL, IQuery));

                Uri isValid = null;
                if (!Uri.TryCreate(IResponse, UriKind.Absolute, out isValid))
                {
                    throw new WebException("Paste Error", WebExceptionStatus.SendFailure);
                }
            }
        }

        public void PastebinSharp(string Username, string Password)
        {
            NameValueCollection IQuery = new NameValueCollection();

            IQuery.Add("api_dev_key", IDevKey);
            IQuery.Add("api_user_name", Username);
            IQuery.Add("api_user_password", Password);

            using (WebClient wc = new WebClient())
            {
                byte[] respBytes = wc.UploadValues(ILoginURL, IQuery);
                string resp = Encoding.UTF8.GetString(respBytes);

                if (resp.Contains("Bad API request"))
                {
                    throw new WebException("Bad Request", WebExceptionStatus.SendFailure);
                }

                IUserKey = resp;
            }
        }
    }
}