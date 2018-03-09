using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastPaste
{
    public partial class FastPaste : Form
    {

        public FastPaste()
        {
            InitializeComponent();

        }

        private void paste_cancel_Click(object sender, EventArgs e)
        {
            FastPaste.ActiveForm.Close();
        }


        private void FastPaste_Load(object sender, EventArgs e)
        {
            var CodeIni = new IniFile.IniFile("Settings.ini");

            //programming language
            if (CodeIni.KeyExists("size", "DateNum"))
            {
                for (int i = 0; i < Int32.Parse(CodeIni.Read("size", "languageNum")); i++)
                {
                    String n = CodeIni.Read("l" + i, "languageNum");
                    language.Items.Add(CodeIni.Read(n, "language"));
                }
            }
            else
            {
                MessageBox.Show("Settings.ini File Corruped.\n Check if a size Entry exists! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            //expiration of post
            if (CodeIni.KeyExists("size", "DateNum"))
            {
                for (int i = 0; i < Int32.Parse(CodeIni.Read("size", "DateNum")); i++)
                {
                    String n = CodeIni.Read("l" + i, "DateNum");
                    exp.Items.Add(CodeIni.Read(n, "Date"));
                }
            }
            else
            {
                MessageBox.Show("Settings.ini File Corruped.\n Check if a size Entry exists! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

        }

        private void paste_button_Click(object sender, EventArgs e)
        {
            var CodeIni = new IniFile.IniFile("Settings.ini");
            String text = "";
            String title = "Untitled";
            String syntax = "text";
            String expire = "10M";
            bool canPost = false;
            title = paste_title.Text;
            if (paste_text.Text == "")
            {
                text_error.Visible = true;
            }
            else
            {
                text = paste_text.Text;
                canPost = true;
            }

            if(language.SelectedItem == null)
            {
                syntax = "text";
            }
            else
            {
                syntax = CodeIni.Read("l" + language.SelectedIndex.ToString(), "languageNum");
            }

            if (exp.SelectedItem == null)
            {
                expire = "10M";
            }
            else
            {
                expire = CodeIni.Read("l" + exp.SelectedIndex.ToString(), "DateNum");
                Console.WriteLine(expire);
            }
            
            if (canPost)
            {
                var paster = new Paste("18a327411f310ee27470c6aa1cef6d39", "", "", text, title, 1, syntax, expire);
                System.Windows.Forms.Clipboard.SetText(paster.MakePaste());
                Console.WriteLine("Post Created!");
                FastPaste.ActiveForm.Close();
            }
        }

    }
}
