namespace AnimalShelter
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.CreateCustomer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CusFullNameLabel = new System.Windows.Forms.Label();
            this.CusAgeLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CusIsQualifiedLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CusAddressLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CusDescriptionLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.NewCusLastNameTextBox = new System.Windows.Forms.TextBox();
            this.NewCusFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.NewCusBirthdayTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.NewCusAddressTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.NewCusDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CustomerListBox = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateCustomer
            // 
            this.CreateCustomer.Location = new System.Drawing.Point(222, 379);
            this.CreateCustomer.Name = "CreateCustomer";
            this.CreateCustomer.Size = new System.Drawing.Size(97, 23);
            this.CreateCustomer.TabIndex = 0;
            this.CreateCustomer.Text = "입양자 생성";
            this.CreateCustomer.UseVisualStyleBackColor = true;
            this.CreateCustomer.Click += new System.EventHandler(this.CreateCustomer_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CusDescriptionLabel);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.CusAddressLabel);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.CusIsQualifiedLabel);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.CusAgeLabel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.CusFullNameLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(504, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 426);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "이름 :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CusFullNameLabel
            // 
            this.CusFullNameLabel.AutoSize = true;
            this.CusFullNameLabel.Location = new System.Drawing.Point(78, 36);
            this.CusFullNameLabel.Name = "CusFullNameLabel";
            this.CusFullNameLabel.Size = new System.Drawing.Size(38, 12);
            this.CusFullNameLabel.TabIndex = 1;
            this.CusFullNameLabel.Text = "label2";
            this.CusFullNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CusAgeLabel
            // 
            this.CusAgeLabel.AutoSize = true;
            this.CusAgeLabel.Location = new System.Drawing.Point(78, 60);
            this.CusAgeLabel.Name = "CusAgeLabel";
            this.CusAgeLabel.Size = new System.Drawing.Size(38, 12);
            this.CusAgeLabel.TabIndex = 3;
            this.CusAgeLabel.Text = "label2";
            this.CusAgeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "나이 :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CusIsQualifiedLabel
            // 
            this.CusIsQualifiedLabel.AutoSize = true;
            this.CusIsQualifiedLabel.Location = new System.Drawing.Point(78, 83);
            this.CusIsQualifiedLabel.Name = "CusIsQualifiedLabel";
            this.CusIsQualifiedLabel.Size = new System.Drawing.Size(38, 12);
            this.CusIsQualifiedLabel.TabIndex = 5;
            this.CusIsQualifiedLabel.Text = "label2";
            this.CusIsQualifiedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "입양가능? :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CusAddressLabel
            // 
            this.CusAddressLabel.AutoSize = true;
            this.CusAddressLabel.Location = new System.Drawing.Point(78, 105);
            this.CusAddressLabel.Name = "CusAddressLabel";
            this.CusAddressLabel.Size = new System.Drawing.Size(38, 12);
            this.CusAddressLabel.TabIndex = 7;
            this.CusAddressLabel.Text = "label2";
            this.CusAddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "주소 :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CusDescriptionLabel
            // 
            this.CusDescriptionLabel.AutoSize = true;
            this.CusDescriptionLabel.Location = new System.Drawing.Point(78, 128);
            this.CusDescriptionLabel.Name = "CusDescriptionLabel";
            this.CusDescriptionLabel.Size = new System.Drawing.Size(38, 12);
            this.CusDescriptionLabel.TabIndex = 9;
            this.CusDescriptionLabel.Text = "label2";
            this.CusDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "상세 :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.NewCusDescriptionTextBox);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.CreateCustomer);
            this.panel2.Controls.Add(this.NewCusAddressTextBox);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.NewCusBirthdayTextBox);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.NewCusFirstNameTextBox);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.NewCusLastNameTextBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(159, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(339, 426);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "성 :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NewCusLastNameTextBox
            // 
            this.NewCusLastNameTextBox.Location = new System.Drawing.Point(51, 27);
            this.NewCusLastNameTextBox.Name = "NewCusLastNameTextBox";
            this.NewCusLastNameTextBox.Size = new System.Drawing.Size(100, 21);
            this.NewCusLastNameTextBox.TabIndex = 1;
            // 
            // NewCusFirstNameTextBox
            // 
            this.NewCusFirstNameTextBox.Location = new System.Drawing.Point(51, 54);
            this.NewCusFirstNameTextBox.Name = "NewCusFirstNameTextBox";
            this.NewCusFirstNameTextBox.Size = new System.Drawing.Size(100, 21);
            this.NewCusFirstNameTextBox.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "이름 :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NewCusBirthdayTextBox
            // 
            this.NewCusBirthdayTextBox.Location = new System.Drawing.Point(51, 81);
            this.NewCusBirthdayTextBox.Name = "NewCusBirthdayTextBox";
            this.NewCusBirthdayTextBox.Size = new System.Drawing.Size(100, 21);
            this.NewCusBirthdayTextBox.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 12);
            this.label8.TabIndex = 4;
            this.label8.Text = "생일 :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NewCusAddressTextBox
            // 
            this.NewCusAddressTextBox.Location = new System.Drawing.Point(51, 108);
            this.NewCusAddressTextBox.Name = "NewCusAddressTextBox";
            this.NewCusAddressTextBox.Size = new System.Drawing.Size(268, 21);
            this.NewCusAddressTextBox.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 6;
            this.label9.Text = "주소 : ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NewCusDescriptionTextBox
            // 
            this.NewCusDescriptionTextBox.Location = new System.Drawing.Point(51, 135);
            this.NewCusDescriptionTextBox.Multiline = true;
            this.NewCusDescriptionTextBox.Name = "NewCusDescriptionTextBox";
            this.NewCusDescriptionTextBox.Size = new System.Drawing.Size(268, 229);
            this.NewCusDescriptionTextBox.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 12);
            this.label10.TabIndex = 8;
            this.label10.Text = "상세 :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CustomerListBox
            // 
            this.CustomerListBox.FormattingEnabled = true;
            this.CustomerListBox.ItemHeight = 12;
            this.CustomerListBox.Location = new System.Drawing.Point(12, 12);
            this.CustomerListBox.Name = "CustomerListBox";
            this.CustomerListBox.Size = new System.Drawing.Size(130, 424);
            this.CustomerListBox.TabIndex = 10;
            this.CustomerListBox.SelectedValueChanged += new System.EventHandler(this.CustomerListBox_SelectedValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 450);
            this.Controls.Add(this.CustomerListBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateCustomer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CusDescriptionLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label CusAddressLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label CusIsQualifiedLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label CusAgeLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label CusFullNameLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NewCusDescriptionTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox NewCusAddressTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox NewCusBirthdayTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox NewCusFirstNameTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NewCusLastNameTextBox;
        private System.Windows.Forms.ListBox CustomerListBox;
    }
}

