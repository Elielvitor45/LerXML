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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGrid1 = new System.Windows.Forms.DataGridView();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NameB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A_Ins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Atributo_Locked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Atributo_Changed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Atributo_Filetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Atributo_Filetime2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A_TypeB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A_IdB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A_Id_Edited = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A_Fixo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A_Descarte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A_Net = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A_DurB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A_Slots = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A_Orig = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inserções = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A_CTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A_Source = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A_MovedTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A_Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A_File = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A_Folder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A_Text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A_Composer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A_Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A_Checked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A_Err = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A_sErr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A_HoraAudio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A_HoraPK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A_IsAudioFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A_DurOrig = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A_Dur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A_Refr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A_DurRefr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A_PtVh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A_PtMx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A_MxIni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A_Intro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A_PtLoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A_Vol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A_Bitrate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A_Reg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A_MD5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(805, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ler XML";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dataGrid1
            // 
            this.dataGrid1.AllowUserToDeleteRows = false;
            this.dataGrid1.AllowUserToOrderColumns = true;
            this.dataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameB,
            this.A_Ins,
            this.Atributo_Locked,
            this.Atributo_Changed,
            this.Atributo_Filetime,
            this.Atributo_Filetime2,
            this.A_Time,
            this.A_TypeB,
            this.A_IdB,
            this.A_Id_Edited,
            this.A_Fixo,
            this.A_Descarte,
            this.A_Net,
            this.A_DurB,
            this.A_Slots,
            this.A_Orig,
            this.Inserções,
            this.A_Id,
            this.A_CTA,
            this.A_Source,
            this.A_MovedTo,
            this.A_Type,
            this.A_Title,
            this.A_File,
            this.A_Folder,
            this.A_Text,
            this.A_Composer,
            this.A_Comment,
            this.A_Checked,
            this.A_Err,
            this.A_sErr,
            this.A_HoraAudio,
            this.A_HoraPK,
            this.A_IsAudioFile,
            this.A_DurOrig,
            this.A_Dur,
            this.A_Refr,
            this.A_DurRefr,
            this.A_PtVh,
            this.A_PtMx,
            this.A_MxIni,
            this.A_Intro,
            this.A_PtLoc,
            this.A_Vol,
            this.A_Bitrate,
            this.A_Reg,
            this.A_MD5});
            this.dataGrid1.Location = new System.Drawing.Point(12, 12);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.RowTemplate.Height = 25;
            this.dataGrid1.Size = new System.Drawing.Size(787, 348);
            this.dataGrid1.TabIndex = 3;
            this.dataGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // date1
            // 
            this.date1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.date1.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.date1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date1.Location = new System.Drawing.Point(805, 44);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(98, 23);
            this.date1.TabIndex = 12;
            this.date1.Value = new System.DateTime(2023, 7, 18, 0, 0, 0, 0);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(803, 302);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 26);
            this.button2.TabIndex = 13;
            this.button2.Text = "Pasta PGM";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(803, 334);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextChanged += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "C:\\Desenvolvimento\\LeituraXml\\LeituraXml\\XmlImage.png";
            this.pictureBox1.Location = new System.Drawing.Point(805, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 214);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // NameB
            // 
            this.NameB.HeaderText = "Breaks";
            this.NameB.Name = "NameB";
            this.NameB.Visible = false;
            // 
            // A_Ins
            // 
            this.A_Ins.HeaderText = "A_Ins";
            this.A_Ins.Name = "A_Ins";
            this.A_Ins.Visible = false;
            // 
            // Atributo_Locked
            // 
            this.Atributo_Locked.HeaderText = "A_Locked";
            this.Atributo_Locked.Name = "Atributo_Locked";
            this.Atributo_Locked.Visible = false;
            // 
            // Atributo_Changed
            // 
            this.Atributo_Changed.HeaderText = "A_Changed";
            this.Atributo_Changed.Name = "Atributo_Changed";
            this.Atributo_Changed.Visible = false;
            // 
            // Atributo_Filetime
            // 
            this.Atributo_Filetime.HeaderText = "A_Filetime";
            this.Atributo_Filetime.Name = "Atributo_Filetime";
            this.Atributo_Filetime.Visible = false;
            // 
            // Atributo_Filetime2
            // 
            this.Atributo_Filetime2.HeaderText = "A_Filetime2";
            this.Atributo_Filetime2.Name = "Atributo_Filetime2";
            this.Atributo_Filetime2.Visible = false;
            // 
            // A_Time
            // 
            this.A_Time.HeaderText = "A_Time";
            this.A_Time.Name = "A_Time";
            this.A_Time.Visible = false;
            // 
            // A_TypeB
            // 
            this.A_TypeB.HeaderText = "A_Type";
            this.A_TypeB.Name = "A_TypeB";
            this.A_TypeB.Visible = false;
            // 
            // A_IdB
            // 
            this.A_IdB.HeaderText = "A_Id";
            this.A_IdB.Name = "A_IdB";
            this.A_IdB.Visible = false;
            // 
            // A_Id_Edited
            // 
            this.A_Id_Edited.HeaderText = "A_Id_Edited";
            this.A_Id_Edited.Name = "A_Id_Edited";
            this.A_Id_Edited.Visible = false;
            // 
            // A_Fixo
            // 
            this.A_Fixo.HeaderText = "A_Fixo";
            this.A_Fixo.Name = "A_Fixo";
            this.A_Fixo.Visible = false;
            // 
            // A_Descarte
            // 
            this.A_Descarte.HeaderText = "A_Descarte";
            this.A_Descarte.Name = "A_Descarte";
            this.A_Descarte.Visible = false;
            // 
            // A_Net
            // 
            this.A_Net.HeaderText = "A_Net";
            this.A_Net.Name = "A_Net";
            this.A_Net.Visible = false;
            // 
            // A_DurB
            // 
            this.A_DurB.HeaderText = "A_Dur";
            this.A_DurB.Name = "A_DurB";
            this.A_DurB.Visible = false;
            // 
            // A_Slots
            // 
            this.A_Slots.HeaderText = "A_Slots";
            this.A_Slots.Name = "A_Slots";
            this.A_Slots.Visible = false;
            // 
            // A_Orig
            // 
            this.A_Orig.HeaderText = "A_Orig";
            this.A_Orig.Name = "A_Orig";
            this.A_Orig.Visible = false;
            // 
            // Inserções
            // 
            this.Inserções.HeaderText = "Inserções";
            this.Inserções.Name = "Inserções";
            this.Inserções.Visible = false;
            // 
            // A_Id
            // 
            this.A_Id.HeaderText = "A_Id";
            this.A_Id.Name = "A_Id";
            this.A_Id.Visible = false;
            // 
            // A_CTA
            // 
            this.A_CTA.HeaderText = "A_CTA";
            this.A_CTA.Name = "A_CTA";
            this.A_CTA.Visible = false;
            // 
            // A_Source
            // 
            this.A_Source.HeaderText = "A_Source";
            this.A_Source.Name = "A_Source";
            this.A_Source.Visible = false;
            // 
            // A_MovedTo
            // 
            this.A_MovedTo.HeaderText = "A_MovedTo";
            this.A_MovedTo.Name = "A_MovedTo";
            this.A_MovedTo.Visible = false;
            // 
            // A_Type
            // 
            this.A_Type.HeaderText = "A_Type";
            this.A_Type.Name = "A_Type";
            this.A_Type.Visible = false;
            // 
            // A_Title
            // 
            this.A_Title.HeaderText = "A_Title";
            this.A_Title.Name = "A_Title";
            this.A_Title.Visible = false;
            // 
            // A_File
            // 
            this.A_File.HeaderText = "A_File";
            this.A_File.Name = "A_File";
            this.A_File.Visible = false;
            // 
            // A_Folder
            // 
            this.A_Folder.HeaderText = "A_Folder";
            this.A_Folder.Name = "A_Folder";
            this.A_Folder.Visible = false;
            // 
            // A_Text
            // 
            this.A_Text.HeaderText = "A_Text";
            this.A_Text.Name = "A_Text";
            this.A_Text.Visible = false;
            // 
            // A_Composer
            // 
            this.A_Composer.HeaderText = "A_Composer";
            this.A_Composer.Name = "A_Composer";
            this.A_Composer.Visible = false;
            // 
            // A_Comment
            // 
            this.A_Comment.HeaderText = "A_Comment";
            this.A_Comment.Name = "A_Comment";
            this.A_Comment.Visible = false;
            // 
            // A_Checked
            // 
            this.A_Checked.HeaderText = "A_Checked";
            this.A_Checked.Name = "A_Checked";
            this.A_Checked.Visible = false;
            // 
            // A_Err
            // 
            this.A_Err.HeaderText = "A_Err";
            this.A_Err.Name = "A_Err";
            this.A_Err.Visible = false;
            // 
            // A_sErr
            // 
            this.A_sErr.HeaderText = "A_sErr";
            this.A_sErr.Name = "A_sErr";
            this.A_sErr.Visible = false;
            // 
            // A_HoraAudio
            // 
            this.A_HoraAudio.HeaderText = "A_HoraAudio";
            this.A_HoraAudio.Name = "A_HoraAudio";
            this.A_HoraAudio.Visible = false;
            // 
            // A_HoraPK
            // 
            this.A_HoraPK.HeaderText = "A_HoraPK";
            this.A_HoraPK.Name = "A_HoraPK";
            this.A_HoraPK.Visible = false;
            // 
            // A_IsAudioFile
            // 
            this.A_IsAudioFile.HeaderText = "A_IsAudioFile";
            this.A_IsAudioFile.Name = "A_IsAudioFile";
            this.A_IsAudioFile.Visible = false;
            // 
            // A_DurOrig
            // 
            this.A_DurOrig.HeaderText = "A_DurOrig";
            this.A_DurOrig.Name = "A_DurOrig";
            this.A_DurOrig.Visible = false;
            // 
            // A_Dur
            // 
            this.A_Dur.HeaderText = "A_Dur";
            this.A_Dur.Name = "A_Dur";
            this.A_Dur.Visible = false;
            // 
            // A_Refr
            // 
            this.A_Refr.HeaderText = "A_Refr";
            this.A_Refr.Name = "A_Refr";
            this.A_Refr.Visible = false;
            // 
            // A_DurRefr
            // 
            this.A_DurRefr.HeaderText = "A_DurRefr";
            this.A_DurRefr.Name = "A_DurRefr";
            this.A_DurRefr.Visible = false;
            // 
            // A_PtVh
            // 
            this.A_PtVh.HeaderText = "A_PtVh";
            this.A_PtVh.Name = "A_PtVh";
            this.A_PtVh.Visible = false;
            // 
            // A_PtMx
            // 
            this.A_PtMx.HeaderText = "A_PtMx";
            this.A_PtMx.Name = "A_PtMx";
            this.A_PtMx.Visible = false;
            // 
            // A_MxIni
            // 
            this.A_MxIni.HeaderText = "A_MxIni";
            this.A_MxIni.Name = "A_MxIni";
            this.A_MxIni.Visible = false;
            // 
            // A_Intro
            // 
            this.A_Intro.HeaderText = "A_Intro";
            this.A_Intro.Name = "A_Intro";
            this.A_Intro.Visible = false;
            // 
            // A_PtLoc
            // 
            this.A_PtLoc.HeaderText = "A_PtLoc";
            this.A_PtLoc.Name = "A_PtLoc";
            this.A_PtLoc.Visible = false;
            // 
            // A_Vol
            // 
            this.A_Vol.HeaderText = "A_Vol";
            this.A_Vol.Name = "A_Vol";
            this.A_Vol.Visible = false;
            // 
            // A_Bitrate
            // 
            this.A_Bitrate.HeaderText = "A_Bitrate";
            this.A_Bitrate.Name = "A_Bitrate";
            this.A_Bitrate.Visible = false;
            // 
            // A_Reg
            // 
            this.A_Reg.HeaderText = "A_Reg";
            this.A_Reg.Name = "A_Reg";
            this.A_Reg.Visible = false;
            // 
            // A_MD5
            // 
            this.A_MD5.HeaderText = "A_MD5";
            this.A_MD5.Name = "A_MD5";
            this.A_MD5.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 369);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LeitorMontagemXML";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.VisibleChanged += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button1;
        private DataGridView dataGrid1;
        private DateTimePicker date1;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button button2;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn NameB;
        private DataGridViewTextBoxColumn A_Ins;
        private DataGridViewTextBoxColumn Atributo_Locked;
        private DataGridViewTextBoxColumn Atributo_Changed;
        private DataGridViewTextBoxColumn Atributo_Filetime;
        private DataGridViewTextBoxColumn Atributo_Filetime2;
        private DataGridViewTextBoxColumn A_Time;
        private DataGridViewTextBoxColumn A_TypeB;
        private DataGridViewTextBoxColumn A_IdB;
        private DataGridViewTextBoxColumn A_Id_Edited;
        private DataGridViewTextBoxColumn A_Fixo;
        private DataGridViewTextBoxColumn A_Descarte;
        private DataGridViewTextBoxColumn A_Net;
        private DataGridViewTextBoxColumn A_DurB;
        private DataGridViewTextBoxColumn A_Slots;
        private DataGridViewTextBoxColumn A_Orig;
        private DataGridViewTextBoxColumn Inserções;
        private DataGridViewTextBoxColumn A_Id;
        private DataGridViewTextBoxColumn A_CTA;
        private DataGridViewTextBoxColumn A_Source;
        private DataGridViewTextBoxColumn A_MovedTo;
        private DataGridViewTextBoxColumn A_Type;
        private DataGridViewTextBoxColumn A_Title;
        private DataGridViewTextBoxColumn A_File;
        private DataGridViewTextBoxColumn A_Folder;
        private DataGridViewTextBoxColumn A_Text;
        private DataGridViewTextBoxColumn A_Composer;
        private DataGridViewTextBoxColumn A_Comment;
        private DataGridViewTextBoxColumn A_Checked;
        private DataGridViewTextBoxColumn A_Err;
        private DataGridViewTextBoxColumn A_sErr;
        private DataGridViewTextBoxColumn A_HoraAudio;
        private DataGridViewTextBoxColumn A_HoraPK;
        private DataGridViewTextBoxColumn A_IsAudioFile;
        private DataGridViewTextBoxColumn A_DurOrig;
        private DataGridViewTextBoxColumn A_Dur;
        private DataGridViewTextBoxColumn A_Refr;
        private DataGridViewTextBoxColumn A_DurRefr;
        private DataGridViewTextBoxColumn A_PtVh;
        private DataGridViewTextBoxColumn A_PtMx;
        private DataGridViewTextBoxColumn A_MxIni;
        private DataGridViewTextBoxColumn A_Intro;
        private DataGridViewTextBoxColumn A_PtLoc;
        private DataGridViewTextBoxColumn A_Vol;
        private DataGridViewTextBoxColumn A_Bitrate;
        private DataGridViewTextBoxColumn A_Reg;
        private DataGridViewTextBoxColumn A_MD5;
    }
}