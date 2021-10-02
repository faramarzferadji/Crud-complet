
namespace Complet_Crud.GUI
{
    partial class Customer_form
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
            this.buttonaADD = new System.Windows.Forms.Button();
            this.buttonSAVE = new System.Windows.Forms.Button();
            this.buttonUPDATE = new System.Windows.Forms.Button();
            this.buttonDELETE = new System.Windows.Forms.Button();
            this.buttonEXIT = new System.Windows.Forms.Button();
            this.buttonLISTCUSTOMER = new System.Windows.Forms.Button();
            this.buttonSEARCH = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.maskedTextBoxPhonNumber = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxLASTNAME = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxCustomerID = new System.Windows.Forms.TextBox();
            this.comboBoxSearchBY = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxInPut = new System.Windows.Forms.TextBox();
            this.labelinfo = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonaADD
            // 
            this.buttonaADD.Location = new System.Drawing.Point(698, 74);
            this.buttonaADD.Name = "buttonaADD";
            this.buttonaADD.Size = new System.Drawing.Size(94, 29);
            this.buttonaADD.TabIndex = 0;
            this.buttonaADD.Text = "ADD";
            this.buttonaADD.UseVisualStyleBackColor = true;
            this.buttonaADD.Click += new System.EventHandler(this.buttonaADD_Click);
            // 
            // buttonSAVE
            // 
            this.buttonSAVE.Location = new System.Drawing.Point(694, 39);
            this.buttonSAVE.Name = "buttonSAVE";
            this.buttonSAVE.Size = new System.Drawing.Size(94, 29);
            this.buttonSAVE.TabIndex = 1;
            this.buttonSAVE.Text = "SAVE";
            this.buttonSAVE.UseVisualStyleBackColor = true;
            this.buttonSAVE.Click += new System.EventHandler(this.buttonSAVE_Click);
            // 
            // buttonUPDATE
            // 
            this.buttonUPDATE.Location = new System.Drawing.Point(694, 161);
            this.buttonUPDATE.Name = "buttonUPDATE";
            this.buttonUPDATE.Size = new System.Drawing.Size(94, 29);
            this.buttonUPDATE.TabIndex = 2;
            this.buttonUPDATE.Text = "UPDATE";
            this.buttonUPDATE.UseVisualStyleBackColor = true;
            this.buttonUPDATE.Click += new System.EventHandler(this.buttonUPDATE_Click);
            // 
            // buttonDELETE
            // 
            this.buttonDELETE.Location = new System.Drawing.Point(698, 213);
            this.buttonDELETE.Name = "buttonDELETE";
            this.buttonDELETE.Size = new System.Drawing.Size(94, 29);
            this.buttonDELETE.TabIndex = 3;
            this.buttonDELETE.Text = "DELETE";
            this.buttonDELETE.UseVisualStyleBackColor = true;
            this.buttonDELETE.Click += new System.EventHandler(this.buttonDELETE_Click);
            // 
            // buttonEXIT
            // 
            this.buttonEXIT.Location = new System.Drawing.Point(694, 409);
            this.buttonEXIT.Name = "buttonEXIT";
            this.buttonEXIT.Size = new System.Drawing.Size(94, 29);
            this.buttonEXIT.TabIndex = 5;
            this.buttonEXIT.Text = "EXIT";
            this.buttonEXIT.UseVisualStyleBackColor = true;
            this.buttonEXIT.Click += new System.EventHandler(this.buttonEXIT_Click);
            // 
            // buttonLISTCUSTOMER
            // 
            this.buttonLISTCUSTOMER.Location = new System.Drawing.Point(698, 117);
            this.buttonLISTCUSTOMER.Name = "buttonLISTCUSTOMER";
            this.buttonLISTCUSTOMER.Size = new System.Drawing.Size(94, 29);
            this.buttonLISTCUSTOMER.TabIndex = 6;
            this.buttonLISTCUSTOMER.Text = "LIST CUSTOMER";
            this.buttonLISTCUSTOMER.UseVisualStyleBackColor = true;
            this.buttonLISTCUSTOMER.Click += new System.EventHandler(this.buttonLISTCUSTOMER_Click);
            // 
            // buttonSEARCH
            // 
            this.buttonSEARCH.Location = new System.Drawing.Point(698, 258);
            this.buttonSEARCH.Name = "buttonSEARCH";
            this.buttonSEARCH.Size = new System.Drawing.Size(90, 29);
            this.buttonSEARCH.TabIndex = 7;
            this.buttonSEARCH.Text = "Search";
            this.buttonSEARCH.UseVisualStyleBackColor = true;
            this.buttonSEARCH.Click += new System.EventHandler(this.buttonSEARCH_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(149, 196);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(251, 212);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Customer ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "First Name";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "LastName";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "PhonNumber";
            // 
            // maskedTextBoxPhonNumber
            // 
            this.maskedTextBoxPhonNumber.Location = new System.Drawing.Point(522, 41);
            this.maskedTextBoxPhonNumber.Mask = "(999) 000-0000";
            this.maskedTextBoxPhonNumber.Name = "maskedTextBoxPhonNumber";
            this.maskedTextBoxPhonNumber.Size = new System.Drawing.Size(125, 27);
            this.maskedTextBoxPhonNumber.TabIndex = 9;
            this.maskedTextBoxPhonNumber.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxPhonNumber_MaskInputRejected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(539, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Phone Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(369, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Customer ID";
            // 
            // textBoxLASTNAME
            // 
            this.textBoxLASTNAME.Location = new System.Drawing.Point(358, 41);
            this.textBoxLASTNAME.Name = "textBoxLASTNAME";
            this.textBoxLASTNAME.Size = new System.Drawing.Size(125, 27);
            this.textBoxLASTNAME.TabIndex = 14;
            this.textBoxLASTNAME.TextChanged += new System.EventHandler(this.textBoxLASTNAME_TextChanged);
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(203, 41);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(125, 27);
            this.textBoxFirstName.TabIndex = 15;
            // 
            // textBoxCustomerID
            // 
            this.textBoxCustomerID.Location = new System.Drawing.Point(34, 41);
            this.textBoxCustomerID.Name = "textBoxCustomerID";
            this.textBoxCustomerID.Size = new System.Drawing.Size(125, 27);
            this.textBoxCustomerID.TabIndex = 16;
            // 
            // comboBoxSearchBY
            // 
            this.comboBoxSearchBY.FormattingEnabled = true;
            this.comboBoxSearchBY.Items.AddRange(new object[] {
            "Customer ID",
            "First Name",
            "Last Name",
            "Phone Number"});
            this.comboBoxSearchBY.Location = new System.Drawing.Point(93, 109);
            this.comboBoxSearchBY.Name = "comboBoxSearchBY";
            this.comboBoxSearchBY.Size = new System.Drawing.Size(151, 28);
            this.comboBoxSearchBY.TabIndex = 17;
            this.comboBoxSearchBY.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearchBY_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Search BY";
            // 
            // textBoxInPut
            // 
            this.textBoxInPut.Location = new System.Drawing.Point(323, 119);
            this.textBoxInPut.Name = "textBoxInPut";
            this.textBoxInPut.Size = new System.Drawing.Size(125, 27);
            this.textBoxInPut.TabIndex = 19;
            this.textBoxInPut.TextChanged += new System.EventHandler(this.textBoxInPut_TextChanged);
            // 
            // labelinfo
            // 
            this.labelinfo.AutoSize = true;
            this.labelinfo.Location = new System.Drawing.Point(339, 91);
            this.labelinfo.Name = "labelinfo";
            this.labelinfo.Size = new System.Drawing.Size(73, 20);
            this.labelinfo.TabIndex = 20;
            this.labelinfo.Text = "Input Info";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(566, 150);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(94, 29);
            this.buttonClear.TabIndex = 21;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Customer_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 450);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.labelinfo);
            this.Controls.Add(this.textBoxInPut);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxSearchBY);
            this.Controls.Add(this.textBoxCustomerID);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxLASTNAME);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBoxPhonNumber);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.buttonSEARCH);
            this.Controls.Add(this.buttonLISTCUSTOMER);
            this.Controls.Add(this.buttonEXIT);
            this.Controls.Add(this.buttonDELETE);
            this.Controls.Add(this.buttonUPDATE);
            this.Controls.Add(this.buttonSAVE);
            this.Controls.Add(this.buttonaADD);
            this.Name = "Customer_form";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Customer_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonaADD;
        private System.Windows.Forms.Button buttonSAVE;
        private System.Windows.Forms.Button buttonUPDATE;
        private System.Windows.Forms.Button buttonDELETE;
        private System.Windows.Forms.Button buttonEXIT;
        private System.Windows.Forms.Button buttonLISTCUSTOMER;
        private System.Windows.Forms.Button buttonSEARCH;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhonNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxLASTNAME;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxCustomerID;
        private System.Windows.Forms.ComboBox comboBoxSearchBY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxInPut;
        private System.Windows.Forms.Label labelinfo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button buttonClear;
    }
}