namespace DictionaryIntro
{
    partial class Form1
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
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.button1 = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDictionary = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFindByID = new System.Windows.Forms.Button();
            this.txtFindByID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnameToFind = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFindByName = new System.Windows.Forms.Button();
            this.txtNameFound = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIDFound = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.LineColor = System.Drawing.SystemColors.ControlDark;
            this.propertyGrid1.Location = new System.Drawing.Point(577, 12);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(296, 522);
            this.propertyGrid1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(273, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add to Dictionary";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(20, 25);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(138, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(116, 20);
            this.txtName.TabIndex = 3;
            // 
            // txtDictionary
            // 
            this.txtDictionary.Location = new System.Drawing.Point(20, 75);
            this.txtDictionary.Multiline = true;
            this.txtDictionary.Name = "txtDictionary";
            this.txtDictionary.Size = new System.Drawing.Size(234, 189);
            this.txtDictionary.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dictionary";
            // 
            // btnFindByID
            // 
            this.btnFindByID.Location = new System.Drawing.Point(17, 308);
            this.btnFindByID.Name = "btnFindByID";
            this.btnFindByID.Size = new System.Drawing.Size(166, 26);
            this.btnFindByID.TabIndex = 6;
            this.btnFindByID.Text = "Find by ID";
            this.btnFindByID.UseVisualStyleBackColor = true;
            this.btnFindByID.Click += new System.EventHandler(this.btnFindByID_Click);
            // 
            // txtFindByID
            // 
            this.txtFindByID.Location = new System.Drawing.Point(83, 282);
            this.txtFindByID.Name = "txtFindByID";
            this.txtFindByID.Size = new System.Drawing.Size(100, 20);
            this.txtFindByID.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "ID to find";
            // 
            // txtnameToFind
            // 
            this.txtnameToFind.Location = new System.Drawing.Point(93, 386);
            this.txtnameToFind.Name = "txtnameToFind";
            this.txtnameToFind.Size = new System.Drawing.Size(116, 20);
            this.txtnameToFind.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Name to Find";
            // 
            // btnFindByName
            // 
            this.btnFindByName.Location = new System.Drawing.Point(20, 412);
            this.btnFindByName.Name = "btnFindByName";
            this.btnFindByName.Size = new System.Drawing.Size(163, 26);
            this.btnFindByName.TabIndex = 6;
            this.btnFindByName.Text = "Find by name";
            this.btnFindByName.UseVisualStyleBackColor = true;
            this.btnFindByName.Click += new System.EventHandler(this.btnFindByName_Click);
            // 
            // txtNameFound
            // 
            this.txtNameFound.Location = new System.Drawing.Point(83, 340);
            this.txtNameFound.Name = "txtNameFound";
            this.txtNameFound.Size = new System.Drawing.Size(100, 20);
            this.txtNameFound.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "name found";
            // 
            // txtIDFound
            // 
            this.txtIDFound.Location = new System.Drawing.Point(83, 444);
            this.txtIDFound.Multiline = true;
            this.txtIDFound.Name = "txtIDFound";
            this.txtIDFound.Size = new System.Drawing.Size(100, 56);
            this.txtIDFound.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 447);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "ID found";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 546);
            this.Controls.Add(this.btnFindByName);
            this.Controls.Add(this.btnFindByID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDictionary);
            this.Controls.Add(this.txtnameToFind);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtIDFound);
            this.Controls.Add(this.txtNameFound);
            this.Controls.Add(this.txtFindByID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.propertyGrid1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDictionary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFindByID;
        private System.Windows.Forms.TextBox txtFindByID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnameToFind;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnFindByName;
        private System.Windows.Forms.TextBox txtNameFound;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIDFound;
        private System.Windows.Forms.Label label7;
    }
}

