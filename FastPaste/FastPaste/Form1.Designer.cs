namespace FastPaste
{
    partial class FastPaste
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.paste_cancel = new System.Windows.Forms.Button();
            this.paste_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.language = new System.Windows.Forms.ComboBox();
            this.exp = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.paste_text = new System.Windows.Forms.RichTextBox();
            this.paste_title = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.text_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // paste_cancel
            // 
            this.paste_cancel.BackColor = System.Drawing.Color.White;
            this.paste_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.paste_cancel.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paste_cancel.Location = new System.Drawing.Point(358, 367);
            this.paste_cancel.Name = "paste_cancel";
            this.paste_cancel.Size = new System.Drawing.Size(75, 41);
            this.paste_cancel.TabIndex = 21;
            this.paste_cancel.Text = "Cancel";
            this.paste_cancel.UseVisualStyleBackColor = false;
            this.paste_cancel.Click += new System.EventHandler(this.paste_cancel_Click);
            // 
            // paste_button
            // 
            this.paste_button.BackColor = System.Drawing.Color.White;
            this.paste_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.paste_button.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paste_button.Location = new System.Drawing.Point(439, 367);
            this.paste_button.Name = "paste_button";
            this.paste_button.Size = new System.Drawing.Size(269, 41);
            this.paste_button.TabIndex = 20;
            this.paste_button.Text = "Create Paste";
            this.paste_button.UseVisualStyleBackColor = false;
            this.paste_button.Click += new System.EventHandler(this.paste_button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(42, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Paste Language";
            // 
            // language
            // 
            this.language.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.language.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.language.FormattingEnabled = true;
            this.language.Location = new System.Drawing.Point(145, 379);
            this.language.Name = "language";
            this.language.Size = new System.Drawing.Size(121, 21);
            this.language.TabIndex = 18;
            // 
            // exp
            // 
            this.exp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.exp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exp.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exp.FormattingEnabled = true;
            this.exp.Location = new System.Drawing.Point(145, 346);
            this.exp.Name = "exp";
            this.exp.Size = new System.Drawing.Size(121, 21);
            this.exp.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(40, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Paste Expiration";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(36, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Paste Settings (Optional)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(33, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Your Text";
            // 
            // paste_text
            // 
            this.paste_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.paste_text.Location = new System.Drawing.Point(33, 109);
            this.paste_text.Name = "paste_text";
            this.paste_text.Size = new System.Drawing.Size(690, 187);
            this.paste_text.TabIndex = 13;
            this.paste_text.Text = "";
            // 
            // paste_title
            // 
            this.paste_title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paste_title.Location = new System.Drawing.Point(33, 48);
            this.paste_title.Name = "paste_title";
            this.paste_title.Size = new System.Drawing.Size(690, 20);
            this.paste_title.TabIndex = 12;
            this.paste_title.Text = "Untitled";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Paste Name / Title";
            // 
            // text_error
            // 
            this.text_error.AutoSize = true;
            this.text_error.BackColor = System.Drawing.Color.Transparent;
            this.text_error.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.text_error.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_error.ForeColor = System.Drawing.Color.Red;
            this.text_error.Location = new System.Drawing.Point(89, 90);
            this.text_error.Name = "text_error";
            this.text_error.Size = new System.Drawing.Size(115, 13);
            this.text_error.TabIndex = 22;
            this.text_error.Text = "Please fill in some Text";
            this.text_error.Visible = false;
            // 
            // FastPaste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(33)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(738, 435);
            this.Controls.Add(this.text_error);
            this.Controls.Add(this.paste_cancel);
            this.Controls.Add(this.paste_button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.language);
            this.Controls.Add(this.exp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.paste_text);
            this.Controls.Add(this.paste_title);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FastPaste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FastPaste - Create new Paste";
            this.Load += new System.EventHandler(this.FastPaste_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button paste_cancel;
        private System.Windows.Forms.Button paste_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox language;
        private System.Windows.Forms.ComboBox exp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox paste_text;
        private System.Windows.Forms.TextBox paste_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label text_error;
    }
}

