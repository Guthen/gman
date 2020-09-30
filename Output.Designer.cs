namespace gman
{
    partial class Output
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
            this.tb_output = new System.Windows.Forms.TextBox();
            this.b_ok = new System.Windows.Forms.Button();
            this.b_copy_all = new System.Windows.Forms.Button();
            this.l_output_commentary = new System.Windows.Forms.Label();
            this.l_output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_output
            // 
            this.tb_output.Location = new System.Drawing.Point(13, 33);
            this.tb_output.Multiline = true;
            this.tb_output.Name = "tb_output";
            this.tb_output.ReadOnly = true;
            this.tb_output.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_output.Size = new System.Drawing.Size(368, 253);
            this.tb_output.TabIndex = 0;
            // 
            // b_ok
            // 
            this.b_ok.Location = new System.Drawing.Point(323, 292);
            this.b_ok.Name = "b_ok";
            this.b_ok.Size = new System.Drawing.Size(58, 23);
            this.b_ok.TabIndex = 1;
            this.b_ok.Text = "OK";
            this.b_ok.UseVisualStyleBackColor = true;
            this.b_ok.Click += new System.EventHandler(this.b_ok_Click);
            // 
            // b_copy_all
            // 
            this.b_copy_all.Location = new System.Drawing.Point(242, 292);
            this.b_copy_all.Name = "b_copy_all";
            this.b_copy_all.Size = new System.Drawing.Size(75, 23);
            this.b_copy_all.TabIndex = 2;
            this.b_copy_all.Text = "Copy All";
            this.b_copy_all.UseVisualStyleBackColor = true;
            this.b_copy_all.Click += new System.EventHandler(this.b_copy_all_Click);
            // 
            // l_output_commentary
            // 
            this.l_output_commentary.AutoSize = true;
            this.l_output_commentary.Location = new System.Drawing.Point(10, 297);
            this.l_output_commentary.Name = "l_output_commentary";
            this.l_output_commentary.Size = new System.Drawing.Size(30, 13);
            this.l_output_commentary.TabIndex = 3;
            this.l_output_commentary.Text = "Fine!";
            // 
            // l_output
            // 
            this.l_output.AutoSize = true;
            this.l_output.Location = new System.Drawing.Point(10, 13);
            this.l_output.Name = "l_output";
            this.l_output.Size = new System.Drawing.Size(39, 13);
            this.l_output.TabIndex = 4;
            this.l_output.Text = "Output";
            // 
            // Output
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 321);
            this.Controls.Add(this.l_output);
            this.Controls.Add(this.l_output_commentary);
            this.Controls.Add(this.b_copy_all);
            this.Controls.Add(this.b_ok);
            this.Controls.Add(this.tb_output);
            this.Name = "Output";
            this.Text = "Output";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_output;
        private System.Windows.Forms.Button b_ok;
        private System.Windows.Forms.Button b_copy_all;
        private System.Windows.Forms.Label l_output_commentary;
        private System.Windows.Forms.Label l_output;
    }
}