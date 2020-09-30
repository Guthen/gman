namespace gman
{
    partial class StringRequest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_string_request = new System.Windows.Forms.TextBox();
            this.b_ok = new System.Windows.Forms.Button();
            this.b_cancel = new System.Windows.Forms.Button();
            this.l_title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_string_request
            // 
            this.tb_string_request.Location = new System.Drawing.Point(13, 28);
            this.tb_string_request.Name = "tb_string_request";
            this.tb_string_request.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_string_request.Size = new System.Drawing.Size(387, 20);
            this.tb_string_request.TabIndex = 0;
            // 
            // b_ok
            // 
            this.b_ok.Location = new System.Drawing.Point(342, 54);
            this.b_ok.Name = "b_ok";
            this.b_ok.Size = new System.Drawing.Size(58, 23);
            this.b_ok.TabIndex = 1;
            this.b_ok.Text = "OK";
            this.b_ok.UseVisualStyleBackColor = true;
            this.b_ok.Click += new System.EventHandler(this.b_ok_Click);
            // 
            // b_cancel
            // 
            this.b_cancel.Location = new System.Drawing.Point(261, 54);
            this.b_cancel.Name = "b_cancel";
            this.b_cancel.Size = new System.Drawing.Size(75, 23);
            this.b_cancel.TabIndex = 2;
            this.b_cancel.Text = "Cancel";
            this.b_cancel.UseVisualStyleBackColor = true;
            this.b_cancel.Click += new System.EventHandler(this.b_cancel_Click);
            // 
            // l_title
            // 
            this.l_title.AutoSize = true;
            this.l_title.Location = new System.Drawing.Point(10, 9);
            this.l_title.Name = "l_title";
            this.l_title.Size = new System.Drawing.Size(27, 13);
            this.l_title.TabIndex = 3;
            this.l_title.Text = "Title";
            // 
            // StringRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 85);
            this.Controls.Add(this.l_title);
            this.Controls.Add(this.b_cancel);
            this.Controls.Add(this.b_ok);
            this.Controls.Add(this.tb_string_request);
            this.Name = "StringRequest";
            this.Text = "StringRequest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_string_request;
        private System.Windows.Forms.Button b_ok;
        private System.Windows.Forms.Button b_cancel;
        private System.Windows.Forms.Label l_title;
    }
}