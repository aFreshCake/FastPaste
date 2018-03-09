using System.Collections.Specialized;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System;

public class Paste
{

    private string _devkey;
    private string _username;
    private string _userpassword;
    private string _PasteCode;
    private string _PasteName;
    private string _Syntax;
    private string _ExpireDate;
    private int _PasteExposure;
    private string ukey;
    public Paste(string Key, string username, string password, string PasteCode, string PasteName, int PasteExposure, string SyntaxHighlighting, string ExpireDate)
    {
        _devkey = Key;
        _username = username;
        _userpassword = password;
        _PasteCode = PasteCode;
        _PasteName = PasteName;
        _PasteExposure = PasteExposure;
        _Syntax = SyntaxHighlighting;
        _ExpireDate = ExpireDate;
    }

    public string Start()
    {
        NameValueCollection query = new NameValueCollection();
        query.Add("api_dev_key", _devkey);
        query.Add("api_user_name", _username);
        query.Add("api_user_password", _userpassword);

        WebClient wClient = new WebClient();
        string risposta = Encoding.UTF8.GetString(wClient.UploadValues("https://pastebin.com/api/api_login.php", query));

        if (risposta.ToLower().Contains("bad api request"))
        {
            MessageBox.Show("Login failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return "ERROR";
        }
        else
        {
            ukey = risposta;
            try
            {
                string output = MakePaste();
                Process.Start(output);
                return "SUCCESS";
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Exception: " + Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "ERROR";
            }
        }
    }

    public string MakePaste()
    {
        if (ukey == "")
        {
            return "ERROR";
        }

        NameValueCollection query = new NameValueCollection();
        query.Add("api_dev_key", _devkey);
        query.Add("api_user_key", ukey);
        query.Add("api_option", "paste");
        query.Add("api_paste_code", _PasteCode);
        query.Add("api_paste_name", _PasteName);
        query.Add("api_paste_format", _Syntax);
        query.Add("api_paste_private", _PasteExposure.ToString());
        query.Add("api_paste_expire_date", _ExpireDate);

        WebClient wc = new WebClient();
        string result = "";
        string response = Encoding.UTF8.GetString(wc.UploadValues("https://pastebin.com/api/api_post.php", query));

        if (response.ToLower().Contains("bad api request"))
        {
            MessageBox.Show("Could not create Post!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else
        {
            result = response;
        }

        return result;
    }
}