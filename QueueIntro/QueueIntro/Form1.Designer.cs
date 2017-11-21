namespace QueueIntro
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
            this.txtQueue = new System.Windows.Forms.TextBox();
            this.btnEnQ = new System.Windows.Forms.Button();
            this.btnDeQ = new System.Windows.Forms.Button();
            this.txtEnQ = new System.Windows.Forms.TextBox();
            this.txtDeQ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.LineColor = System.Drawing.SystemColors.ControlDark;
            this.propertyGrid1.Location = new System.Drawing.Point(407, 12);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(255, 412);
            this.propertyGrid1.TabIndex = 0;
            // 
            // txtQueue
            // 
            this.txtQueue.Location = new System.Drawing.Point(193, 38);
            this.txtQueue.Multiline = true;
            this.txtQueue.Name = "txtQueue";
            this.txtQueue.Size = new System.Drawing.Size(199, 386);
            this.txtQueue.TabIndex = 1;
            // 
            // btnEnQ
            // 
            this.btnEnQ.Location = new System.Drawing.Point(50, 64);
            this.btnEnQ.Name = "btnEnQ";
            this.btnEnQ.Size = new System.Drawing.Size(75, 23);
            this.btnEnQ.TabIndex = 2;
            this.btnEnQ.Text = "Enqueue";
            this.btnEnQ.UseVisualStyleBackColor = true;
            // 
            // btnDeQ
            // 
            this.btnDeQ.Location = new System.Drawing.Point(50, 374);
            this.btnDeQ.Name = "btnDeQ";
            this.btnDeQ.Size = new System.Drawing.Size(75, 23);
            this.btnDeQ.TabIndex = 3;
            this.btnDeQ.Text = "Dequeue";
            this.btnDeQ.UseVisualStyleBackColor = true;
            // 
            // txtEnQ
            // 
            this.txtEnQ.Location = new System.Drawing.Point(50, 38);
            this.txtEnQ.Name = "txtEnQ";
            this.txtEnQ.Size = new System.Drawing.Size(100, 20);
            this.txtEnQ.TabIndex = 4;
            // 
            // txtDeQ
            // 
            this.txtDeQ.Location = new System.Drawing.Point(50, 403);
            this.txtDeQ.Name = "txtDeQ";
            this.txtDeQ.Size = new System.Drawing.Size(100, 20);
            this.txtDeQ.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Queue";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 436);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDeQ);
            this.Controls.Add(this.txtEnQ);
            this.Controls.Add(this.btnDeQ);
            this.Controls.Add(this.btnEnQ);
            this.Controls.Add(this.txtQueue);
            this.Controls.Add(this.propertyGrid1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.TextBox txtQueue;
        private System.Windows.Forms.Button btnEnQ;
        private System.Windows.Forms.Button btnDeQ;
        private System.Windows.Forms.TextBox txtEnQ;
        private System.Windows.Forms.TextBox txtDeQ;
        private System.Windows.Forms.Label label1;
    }
}

