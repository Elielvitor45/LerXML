namespace LeituraXml
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonReadXml = new System.Windows.Forms.Button();
            this.dataGrid1 = new System.Windows.Forms.DataGridView();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonPathMontagem = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonJson = new System.Windows.Forms.Button();
            this.buttonPathJson = new System.Windows.Forms.Button();
            this.textBoxJson = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonReadXml
            // 
            this.buttonReadXml.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonReadXml.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonReadXml.Location = new System.Drawing.Point(12, 154);
            this.buttonReadXml.Name = "buttonReadXml";
            this.buttonReadXml.Size = new System.Drawing.Size(98, 26);
            this.buttonReadXml.TabIndex = 2;
            this.buttonReadXml.Text = "Ler XML";
            this.buttonReadXml.UseVisualStyleBackColor = false;
            this.buttonReadXml.Click += new System.EventHandler(this.buttonReadXml_Click_1);
            // 
            // dataGrid1
            // 
            this.dataGrid1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.dataGrid1.AllowUserToDeleteRows = false;
            this.dataGrid1.AllowUserToOrderColumns = true;
            this.dataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid1.Location = new System.Drawing.Point(12, 12);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.RowTemplate.Height = 25;
            this.dataGrid1.Size = new System.Drawing.Size(785, 126);
            this.dataGrid1.TabIndex = 3;
            // 
            // date1
            // 
            this.date1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.date1.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.date1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date1.Location = new System.Drawing.Point(222, 334);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(98, 23);
            this.date1.TabIndex = 12;
            this.date1.Value = new System.DateTime(2023, 7, 18, 0, 0, 0, 0);
            // 
            // buttonPathMontagem
            // 
            this.buttonPathMontagem.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonPathMontagem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPathMontagem.Location = new System.Drawing.Point(12, 302);
            this.buttonPathMontagem.Name = "buttonPathMontagem";
            this.buttonPathMontagem.Size = new System.Drawing.Size(100, 26);
            this.buttonPathMontagem.TabIndex = 13;
            this.buttonPathMontagem.Text = "Pasta PGM";
            this.buttonPathMontagem.UseVisualStyleBackColor = false;
            this.buttonPathMontagem.Click += new System.EventHandler(this.buttonPathMontagem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 334);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "C:\\Desenvolvimento\\LeituraXml\\LeituraXml\\XmlImage.png";
            this.pictureBox1.Location = new System.Drawing.Point(12, 186);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 120);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // buttonJson
            // 
            this.buttonJson.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonJson.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonJson.Location = new System.Drawing.Point(116, 154);
            this.buttonJson.Name = "buttonJson";
            this.buttonJson.Size = new System.Drawing.Size(98, 26);
            this.buttonJson.TabIndex = 16;
            this.buttonJson.Text = "Salvar Json";
            this.buttonJson.UseVisualStyleBackColor = false;
            this.buttonJson.Click += new System.EventHandler(this.buttonJson_Click);
            // 
            // buttonPathJson
            // 
            this.buttonPathJson.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonPathJson.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPathJson.Location = new System.Drawing.Point(114, 302);
            this.buttonPathJson.Name = "buttonPathJson";
            this.buttonPathJson.Size = new System.Drawing.Size(100, 26);
            this.buttonPathJson.TabIndex = 17;
            this.buttonPathJson.Text = "Caminho";
            this.buttonPathJson.UseVisualStyleBackColor = false;
            this.buttonPathJson.Click += new System.EventHandler(this.buttonPathJson_Click);
            // 
            // textBoxJson
            // 
            this.textBoxJson.Location = new System.Drawing.Point(116, 334);
            this.textBoxJson.Name = "textBoxJson";
            this.textBoxJson.Size = new System.Drawing.Size(100, 23);
            this.textBoxJson.TabIndex = 18;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ImageLocation = "C:\\Desenvolvimento\\LeituraXml\\LeituraXml\\Json.png";
            this.pictureBox2.Location = new System.Drawing.Point(116, 186);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 120);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 369);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBoxJson);
            this.Controls.Add(this.buttonPathJson);
            this.Controls.Add(this.buttonJson);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonPathMontagem);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.buttonReadXml);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LeitorMontagemXML";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button buttonReadXml;
        private DataGridView dataGrid1;
        private DateTimePicker date1;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button buttonPathMontagem;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private Button buttonJson;
        private Button buttonPathJson;
        private TextBox textBoxJson;
        private PictureBox pictureBox2;

    }
}