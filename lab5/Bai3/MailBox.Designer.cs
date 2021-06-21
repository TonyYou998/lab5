
namespace lab5.Bai5
{
    partial class MailBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.From = new System.Windows.Forms.ColumnHeader();
            this.Time = new System.Windows.Forms.ColumnHeader();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SendBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.contenttxt = new System.Windows.Forms.RichTextBox();
            this.Subjecttxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mailtotxt = new System.Windows.Forms.TextBox();
            this.mailfromtxt = new System.Windows.Forms.TextBox();
            this.msgcontent = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Passtxt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.msgcontent);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.RefreshBtn);
            this.groupBox1.Location = new System.Drawing.Point(14, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(725, 648);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MailBox";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.From,
            this.Time});
            this.listView1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(7, 75);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(702, 253);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Name = "columnHeader1";
            this.columnHeader1.Text = "Subject";
            this.columnHeader1.Width = 300;
            // 
            // From
            // 
            this.From.Name = "From";
            this.From.Text = "Mail From";
            this.From.Width = 200;
            // 
            // Time
            // 
            this.Time.Name = "Time";
            this.Time.Text = "Time";
            this.Time.Width = 200;
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Location = new System.Drawing.Point(11, 24);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(94, 29);
            this.RefreshBtn.TabIndex = 1;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Passtxt);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.SendBtn);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.contenttxt);
            this.groupBox2.Controls.Add(this.Subjecttxt);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.mailtotxt);
            this.groupBox2.Controls.Add(this.mailfromtxt);
            this.groupBox2.Location = new System.Drawing.Point(806, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(595, 683);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mail Sender";
            // 
            // SendBtn
            // 
            this.SendBtn.Location = new System.Drawing.Point(190, 628);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(224, 49);
            this.SendBtn.TabIndex = 8;
            this.SendBtn.Text = "Send";
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Content";
            // 
            // contenttxt
            // 
            this.contenttxt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contenttxt.Location = new System.Drawing.Point(46, 298);
            this.contenttxt.Name = "contenttxt";
            this.contenttxt.Size = new System.Drawing.Size(529, 324);
            this.contenttxt.TabIndex = 6;
            this.contenttxt.Text = "";
            // 
            // Subjecttxt
            // 
            this.Subjecttxt.Location = new System.Drawing.Point(92, 149);
            this.Subjecttxt.Name = "Subjecttxt";
            this.Subjecttxt.Size = new System.Drawing.Size(460, 27);
            this.Subjecttxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Subject";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "From";
            // 
            // mailtotxt
            // 
            this.mailtotxt.Location = new System.Drawing.Point(92, 98);
            this.mailtotxt.Name = "mailtotxt";
            this.mailtotxt.Size = new System.Drawing.Size(280, 27);
            this.mailtotxt.TabIndex = 1;
            // 
            // mailfromtxt
            // 
            this.mailfromtxt.Location = new System.Drawing.Point(92, 41);
            this.mailfromtxt.Name = "mailfromtxt";
            this.mailfromtxt.Size = new System.Drawing.Size(280, 27);
            this.mailfromtxt.TabIndex = 0;
            // 
            // msgcontent
            // 
            this.msgcontent.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.msgcontent.Location = new System.Drawing.Point(7, 348);
            this.msgcontent.Name = "msgcontent";
            this.msgcontent.Size = new System.Drawing.Size(702, 281);
            this.msgcontent.TabIndex = 7;
            this.msgcontent.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Password";
            // 
            // Passtxt
            // 
            this.Passtxt.Location = new System.Drawing.Point(92, 214);
            this.Passtxt.Name = "Passtxt";
            this.Passtxt.Size = new System.Drawing.Size(128, 27);
            this.Passtxt.TabIndex = 10;
            // 
            // MailBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 719);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MailBox";
            this.Text = "MailBox";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Button SendBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox contenttxt;
        private System.Windows.Forms.TextBox Subjecttxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mailtotxt;
        private System.Windows.Forms.TextBox mailfromtxt;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Content;
        private System.Windows.Forms.ColumnHeader Mail_From;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader From;
        private System.Windows.Forms.RichTextBox msgcontent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Passtxt;
    }
}