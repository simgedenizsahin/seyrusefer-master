namespace seyrusefer
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.adminname = new System.Windows.Forms.TextBox();
            this.adminpass = new System.Windows.Forms.TextBox();
            this.adminbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // adminname
            // 
            resources.ApplyResources(this.adminname, "adminname");
            this.adminname.Name = "adminname";
            this.adminname.TextChanged += new System.EventHandler(this.adminname_TextChanged);
            // 
            // adminpass
            // 
            resources.ApplyResources(this.adminpass, "adminpass");
            this.adminpass.Name = "adminpass";
            this.adminpass.TextChanged += new System.EventHandler(this.adminpass_TextChanged);
            // 
            // adminbutton
            // 
            resources.ApplyResources(this.adminbutton, "adminbutton");
            this.adminbutton.Name = "adminbutton";
            this.adminbutton.UseVisualStyleBackColor = true;
            this.adminbutton.Click += new System.EventHandler(this.adminbutton_Click);
            // 
            // Form2
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.adminbutton);
            this.Controls.Add(this.adminpass);
            this.Controls.Add(this.adminname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox adminname;
        private System.Windows.Forms.TextBox adminpass;
        private System.Windows.Forms.Button adminbutton;
    }
}