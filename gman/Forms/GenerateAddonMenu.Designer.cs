namespace gman.Forms
{
    partial class GenerateAddonMenu
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
			System.Windows.Forms.Label label1;
			System.Windows.Forms.GroupBox groupbox_settings;
			System.Windows.Forms.Label label5;
			System.Windows.Forms.Label label4;
			System.Windows.Forms.Label label3;
			System.Windows.Forms.Label label2;
			System.Windows.Forms.GroupBox groupbox_actions;
			this.textbox_settings_path = new System.Windows.Forms.TextBox();
			this.combobox_settings_tag2 = new System.Windows.Forms.ComboBox();
			this.combobox_settings_tag1 = new System.Windows.Forms.ComboBox();
			this.combobox_settings_type = new System.Windows.Forms.ComboBox();
			this.textbox_settings_title = new System.Windows.Forms.TextBox();
			this.button_actions_generate = new System.Windows.Forms.Button();
			label1 = new System.Windows.Forms.Label();
			groupbox_settings = new System.Windows.Forms.GroupBox();
			label5 = new System.Windows.Forms.Label();
			label4 = new System.Windows.Forms.Label();
			label3 = new System.Windows.Forms.Label();
			label2 = new System.Windows.Forms.Label();
			groupbox_actions = new System.Windows.Forms.GroupBox();
			groupbox_settings.SuspendLayout();
			groupbox_actions.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(13, 22);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(33, 13);
			label1.TabIndex = 0;
			label1.Text = "Title :";
			label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// groupbox_settings
			// 
			groupbox_settings.Controls.Add(this.textbox_settings_path);
			groupbox_settings.Controls.Add(label5);
			groupbox_settings.Controls.Add(label4);
			groupbox_settings.Controls.Add(this.combobox_settings_tag2);
			groupbox_settings.Controls.Add(label3);
			groupbox_settings.Controls.Add(this.combobox_settings_tag1);
			groupbox_settings.Controls.Add(label2);
			groupbox_settings.Controls.Add(this.combobox_settings_type);
			groupbox_settings.Controls.Add(this.textbox_settings_title);
			groupbox_settings.Controls.Add(label1);
			groupbox_settings.Location = new System.Drawing.Point(12, 12);
			groupbox_settings.Name = "groupbox_settings";
			groupbox_settings.Size = new System.Drawing.Size(411, 104);
			groupbox_settings.TabIndex = 2;
			groupbox_settings.TabStop = false;
			groupbox_settings.Text = "Settings";
			// 
			// textbox_settings_path
			// 
			this.textbox_settings_path.Location = new System.Drawing.Point(52, 73);
			this.textbox_settings_path.Name = "textbox_settings_path";
			this.textbox_settings_path.Size = new System.Drawing.Size(347, 20);
			this.textbox_settings_path.TabIndex = 9;
			this.textbox_settings_path.TextChanged += new System.EventHandler(this.textbox_settings_path_TextChanged);
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new System.Drawing.Point(11, 76);
			label5.Name = "label5";
			label5.Size = new System.Drawing.Size(35, 13);
			label5.TabIndex = 8;
			label5.Text = "Path :";
			label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new System.Drawing.Point(205, 49);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(41, 13);
			label4.TabIndex = 7;
			label4.Text = "Tag 2 :";
			label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// combobox_settings_tag2
			// 
			this.combobox_settings_tag2.FormattingEnabled = true;
			this.combobox_settings_tag2.Location = new System.Drawing.Point(252, 46);
			this.combobox_settings_tag2.Name = "combobox_settings_tag2";
			this.combobox_settings_tag2.Size = new System.Drawing.Size(147, 21);
			this.combobox_settings_tag2.TabIndex = 6;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new System.Drawing.Point(205, 22);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(41, 13);
			label3.TabIndex = 5;
			label3.Text = "Tag 1 :";
			label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// combobox_settings_tag1
			// 
			this.combobox_settings_tag1.FormattingEnabled = true;
			this.combobox_settings_tag1.Location = new System.Drawing.Point(252, 19);
			this.combobox_settings_tag1.Name = "combobox_settings_tag1";
			this.combobox_settings_tag1.Size = new System.Drawing.Size(147, 21);
			this.combobox_settings_tag1.TabIndex = 4;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(9, 49);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(37, 13);
			label2.TabIndex = 3;
			label2.Text = "Type :";
			label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// combobox_settings_type
			// 
			this.combobox_settings_type.FormattingEnabled = true;
			this.combobox_settings_type.Location = new System.Drawing.Point(52, 46);
			this.combobox_settings_type.Name = "combobox_settings_type";
			this.combobox_settings_type.Size = new System.Drawing.Size(147, 21);
			this.combobox_settings_type.TabIndex = 2;
			// 
			// textbox_settings_title
			// 
			this.textbox_settings_title.Location = new System.Drawing.Point(52, 19);
			this.textbox_settings_title.Name = "textbox_settings_title";
			this.textbox_settings_title.Size = new System.Drawing.Size(147, 20);
			this.textbox_settings_title.TabIndex = 1;
			// 
			// groupbox_actions
			// 
			groupbox_actions.Controls.Add(this.button_actions_generate);
			groupbox_actions.Location = new System.Drawing.Point(12, 122);
			groupbox_actions.Name = "groupbox_actions";
			groupbox_actions.Size = new System.Drawing.Size(411, 56);
			groupbox_actions.TabIndex = 4;
			groupbox_actions.TabStop = false;
			groupbox_actions.Text = "Actions";
			// 
			// button_actions_generate
			// 
			this.button_actions_generate.Location = new System.Drawing.Point(52, 19);
			this.button_actions_generate.Name = "button_actions_generate";
			this.button_actions_generate.Size = new System.Drawing.Size(301, 23);
			this.button_actions_generate.TabIndex = 0;
			this.button_actions_generate.Text = "Generate JSON";
			this.button_actions_generate.UseVisualStyleBackColor = true;
			this.button_actions_generate.Click += new System.EventHandler(this.button_actions_generate_Click);
			// 
			// GenerateAddonMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(436, 189);
			this.Controls.Add(groupbox_actions);
			this.Controls.Add(groupbox_settings);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "GenerateAddonMenu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Generate Addon";
			groupbox_settings.ResumeLayout(false);
			groupbox_settings.PerformLayout();
			groupbox_actions.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textbox_settings_title;
        private System.Windows.Forms.ComboBox combobox_settings_type;
        private System.Windows.Forms.ComboBox combobox_settings_tag2;
        private System.Windows.Forms.ComboBox combobox_settings_tag1;
        private System.Windows.Forms.Button button_actions_generate;
        private System.Windows.Forms.TextBox textbox_settings_path;
    }
}