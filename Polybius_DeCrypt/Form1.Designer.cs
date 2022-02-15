namespace Polybius_DeCrypt
{
    partial class Form1
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
            this.tB_Input = new System.Windows.Forms.TextBox();
            this.tB_Output = new System.Windows.Forms.TextBox();
            this.btn_Decrypt = new System.Windows.Forms.Button();
            this.btn_Encrypt = new System.Windows.Forms.Button();
            this.gB_Input = new System.Windows.Forms.GroupBox();
            this.gB_Output = new System.Windows.Forms.GroupBox();
            this.gB_Options = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Keyword = new System.Windows.Forms.Label();
            this.tB_Keyword = new System.Windows.Forms.TextBox();
            this.gB_Input.SuspendLayout();
            this.gB_Output.SuspendLayout();
            this.gB_Options.SuspendLayout();
            this.SuspendLayout();
            // 
            // tB_Input
            // 
            this.tB_Input.Location = new System.Drawing.Point(6, 19);
            this.tB_Input.Multiline = true;
            this.tB_Input.Name = "tB_Input";
            this.tB_Input.Size = new System.Drawing.Size(288, 225);
            this.tB_Input.TabIndex = 0;
            // 
            // tB_Output
            // 
            this.tB_Output.Location = new System.Drawing.Point(6, 19);
            this.tB_Output.Multiline = true;
            this.tB_Output.Name = "tB_Output";
            this.tB_Output.ReadOnly = true;
            this.tB_Output.Size = new System.Drawing.Size(288, 225);
            this.tB_Output.TabIndex = 2;
            // 
            // btn_Decrypt
            // 
            this.btn_Decrypt.Location = new System.Drawing.Point(324, 268);
            this.btn_Decrypt.Name = "btn_Decrypt";
            this.btn_Decrypt.Size = new System.Drawing.Size(93, 23);
            this.btn_Decrypt.TabIndex = 3;
            this.btn_Decrypt.Text = "Verschlüsseln";
            this.btn_Decrypt.UseVisualStyleBackColor = true;
            this.btn_Decrypt.Click += new System.EventHandler(this.Encrypt);
            // 
            // btn_Encrypt
            // 
            this.btn_Encrypt.Location = new System.Drawing.Point(324, 297);
            this.btn_Encrypt.Name = "btn_Encrypt";
            this.btn_Encrypt.Size = new System.Drawing.Size(93, 23);
            this.btn_Encrypt.TabIndex = 4;
            this.btn_Encrypt.Text = "Entschlüsseln";
            this.btn_Encrypt.UseVisualStyleBackColor = true;
            this.btn_Encrypt.Click += new System.EventHandler(this.Decrypt);
            // 
            // gB_Input
            // 
            this.gB_Input.Controls.Add(this.tB_Input);
            this.gB_Input.Location = new System.Drawing.Point(12, 12);
            this.gB_Input.Name = "gB_Input";
            this.gB_Input.Size = new System.Drawing.Size(300, 250);
            this.gB_Input.TabIndex = 6;
            this.gB_Input.TabStop = false;
            this.gB_Input.Text = "Eingabe";
            // 
            // gB_Output
            // 
            this.gB_Output.Controls.Add(this.tB_Output);
            this.gB_Output.Location = new System.Drawing.Point(318, 12);
            this.gB_Output.Name = "gB_Output";
            this.gB_Output.Size = new System.Drawing.Size(300, 250);
            this.gB_Output.TabIndex = 7;
            this.gB_Output.TabStop = false;
            this.gB_Output.Text = "Ausgabe";
            // 
            // gB_Options
            // 
            this.gB_Options.Controls.Add(this.label1);
            this.gB_Options.Controls.Add(this.lbl_Keyword);
            this.gB_Options.Controls.Add(this.tB_Keyword);
            this.gB_Options.Location = new System.Drawing.Point(18, 268);
            this.gB_Options.Name = "gB_Options";
            this.gB_Options.Size = new System.Drawing.Size(288, 98);
            this.gB_Options.TabIndex = 3;
            this.gB_Options.TabStop = false;
            this.gB_Options.Text = "Options";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(6, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nur Buchstaben KEINE Zahlen!";
            // 
            // lbl_Keyword
            // 
            this.lbl_Keyword.AutoSize = true;
            this.lbl_Keyword.Location = new System.Drawing.Point(6, 27);
            this.lbl_Keyword.Name = "lbl_Keyword";
            this.lbl_Keyword.Size = new System.Drawing.Size(54, 13);
            this.lbl_Keyword.TabIndex = 9;
            this.lbl_Keyword.Text = "Keyword: ";
            // 
            // tB_Keyword
            // 
            this.tB_Keyword.Location = new System.Drawing.Point(65, 24);
            this.tB_Keyword.Name = "tB_Keyword";
            this.tB_Keyword.Size = new System.Drawing.Size(100, 20);
            this.tB_Keyword.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 379);
            this.Controls.Add(this.gB_Options);
            this.Controls.Add(this.gB_Output);
            this.Controls.Add(this.btn_Decrypt);
            this.Controls.Add(this.gB_Input);
            this.Controls.Add(this.btn_Encrypt);
            this.Name = "Form1";
            this.Text = "Polybius | Sebastian Schindler, Paul Rakutt";
            this.gB_Input.ResumeLayout(false);
            this.gB_Input.PerformLayout();
            this.gB_Output.ResumeLayout(false);
            this.gB_Output.PerformLayout();
            this.gB_Options.ResumeLayout(false);
            this.gB_Options.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tB_Input;
        private System.Windows.Forms.TextBox tB_Output;
        private System.Windows.Forms.Button btn_Decrypt;
        private System.Windows.Forms.Button btn_Encrypt;
        private System.Windows.Forms.GroupBox gB_Input;
        private System.Windows.Forms.GroupBox gB_Output;
        private System.Windows.Forms.GroupBox gB_Options;
        private System.Windows.Forms.TextBox tB_Keyword;
        private System.Windows.Forms.Label lbl_Keyword;
        private System.Windows.Forms.Label label1;
    }
}

