namespace Lab2_ex1
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
            this.btnClick = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCopiedTexr = new System.Windows.Forms.Label();
            this.txtText = new System.Windows.Forms.TextBox();
            this.txtCopiedText = new System.Windows.Forms.TextBox();
            this.btnGetText = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(670, 51);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(162, 80);
            this.btnClick.TabIndex = 0;
            this.btnClick.Text = "Click!";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Text";
            // 
            // lbCopiedTexr
            // 
            this.lbCopiedTexr.AutoSize = true;
            this.lbCopiedTexr.Location = new System.Drawing.Point(43, 114);
            this.lbCopiedTexr.Name = "lbCopiedTexr";
            this.lbCopiedTexr.Size = new System.Drawing.Size(80, 16);
            this.lbCopiedTexr.TabIndex = 2;
            this.lbCopiedTexr.Text = "Copied Text";
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(178, 45);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(100, 22);
            this.txtText.TabIndex = 3;
            // 
            // txtCopiedText
            // 
            this.txtCopiedText.Location = new System.Drawing.Point(178, 111);
            this.txtCopiedText.Name = "txtCopiedText";
            this.txtCopiedText.ReadOnly = true;
            this.txtCopiedText.Size = new System.Drawing.Size(100, 22);
            this.txtCopiedText.TabIndex = 4;
            // 
            // btnGetText
            // 
            this.btnGetText.Location = new System.Drawing.Point(90, 170);
            this.btnGetText.Name = "btnGetText";
            this.btnGetText.Size = new System.Drawing.Size(75, 23);
            this.btnGetText.TabIndex = 5;
            this.btnGetText.Text = "GetText";
            this.btnGetText.UseVisualStyleBackColor = true;
            this.btnGetText.Click += new System.EventHandler(this.btnGetText_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(449, 292);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(203, 49);
            this.btnOpen.TabIndex = 6;
            this.btnOpen.Text = "Open Second Form";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 459);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnGetText);
            this.Controls.Add(this.txtCopiedText);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.lbCopiedTexr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClick);
            this.Name = "Form1";
            this.Text = "First Exercise";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCopiedTexr;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.TextBox txtCopiedText;
        private System.Windows.Forms.Button btnGetText;
        private System.Windows.Forms.Button btnOpen;
    }
}

