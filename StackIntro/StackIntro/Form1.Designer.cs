namespace StackIntro
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
            this.btnRandom = new System.Windows.Forms.Button();
            this.txtrandom = new System.Windows.Forms.TextBox();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.txtStack = new System.Windows.Forms.TextBox();
            this.txtPop = new System.Windows.Forms.TextBox();
            this.btnPop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(38, 38);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(178, 23);
            this.btnRandom.TabIndex = 0;
            this.btnRandom.Text = "Push a randon number";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // txtrandom
            // 
            this.txtrandom.Location = new System.Drawing.Point(38, 12);
            this.txtrandom.Name = "txtrandom";
            this.txtrandom.Size = new System.Drawing.Size(178, 20);
            this.txtrandom.TabIndex = 1;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.LineColor = System.Drawing.SystemColors.ControlDark;
            this.propertyGrid1.Location = new System.Drawing.Point(565, 12);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(315, 396);
            this.propertyGrid1.TabIndex = 2;
            // 
            // txtStack
            // 
            this.txtStack.Location = new System.Drawing.Point(297, 12);
            this.txtStack.Multiline = true;
            this.txtStack.Name = "txtStack";
            this.txtStack.Size = new System.Drawing.Size(262, 396);
            this.txtStack.TabIndex = 3;
            // 
            // txtPop
            // 
            this.txtPop.Location = new System.Drawing.Point(38, 140);
            this.txtPop.Name = "txtPop";
            this.txtPop.Size = new System.Drawing.Size(178, 20);
            this.txtPop.TabIndex = 4;
            // 
            // btnPop
            // 
            this.btnPop.Location = new System.Drawing.Point(38, 111);
            this.btnPop.Name = "btnPop";
            this.btnPop.Size = new System.Drawing.Size(178, 23);
            this.btnPop.TabIndex = 5;
            this.btnPop.Text = "Pop from stack";
            this.btnPop.UseVisualStyleBackColor = true;
            this.btnPop.Click += new System.EventHandler(this.btnPop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 431);
            this.Controls.Add(this.btnPop);
            this.Controls.Add(this.txtPop);
            this.Controls.Add(this.txtStack);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.txtrandom);
            this.Controls.Add(this.btnRandom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.TextBox txtrandom;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.TextBox txtStack;
        private System.Windows.Forms.TextBox txtPop;
        private System.Windows.Forms.Button btnPop;
    }
}

