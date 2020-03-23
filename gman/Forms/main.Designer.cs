namespace gman
{
    partial class Main
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
			System.Windows.Forms.GroupBox groupbox_settings_paths;
			System.Windows.Forms.Label label1;
			System.Windows.Forms.Label label_gmpublish_path;
			System.Windows.Forms.Label label_addon_path;
			System.Windows.Forms.Label label_gmad_path;
			System.Windows.Forms.GroupBox groupbox_actions;
			System.Windows.Forms.GroupBox groupbox_actions_gman;
			System.Windows.Forms.GroupBox groupbox_actions_gmpublish;
			System.Windows.Forms.GroupBox groupbox_actions_gmad;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.button_settings_paths_output_browse = new System.Windows.Forms.Button();
			this.textbox_settings_paths_output = new System.Windows.Forms.TextBox();
			this.textbox_settings_paths_gmpublish = new System.Windows.Forms.TextBox();
			this.textbox_settings_paths_addon = new System.Windows.Forms.TextBox();
			this.textbox_settings_paths_gmad = new System.Windows.Forms.TextBox();
			this.button_actions_gman_generation = new System.Windows.Forms.Button();
			this.button_actions_gman_update = new System.Windows.Forms.Button();
			this.button_actions_gmpublish_list = new System.Windows.Forms.Button();
			this.button_actions_gmpublish_update = new System.Windows.Forms.Button();
			this.button_actions_gmpublish_publish = new System.Windows.Forms.Button();
			this.button_actions_gmad_create = new System.Windows.Forms.Button();
			this.button_actions_gmad_extract = new System.Windows.Forms.Button();
			this.groupbox_settings = new System.Windows.Forms.GroupBox();
			this.folderbrowser_settings_paths_output = new System.Windows.Forms.FolderBrowserDialog();
			groupbox_settings_paths = new System.Windows.Forms.GroupBox();
			label1 = new System.Windows.Forms.Label();
			label_gmpublish_path = new System.Windows.Forms.Label();
			label_addon_path = new System.Windows.Forms.Label();
			label_gmad_path = new System.Windows.Forms.Label();
			groupbox_actions = new System.Windows.Forms.GroupBox();
			groupbox_actions_gman = new System.Windows.Forms.GroupBox();
			groupbox_actions_gmpublish = new System.Windows.Forms.GroupBox();
			groupbox_actions_gmad = new System.Windows.Forms.GroupBox();
			groupbox_settings_paths.SuspendLayout();
			groupbox_actions.SuspendLayout();
			groupbox_actions_gman.SuspendLayout();
			groupbox_actions_gmpublish.SuspendLayout();
			groupbox_actions_gmad.SuspendLayout();
			this.groupbox_settings.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupbox_settings_paths
			// 
			groupbox_settings_paths.Controls.Add(this.button_settings_paths_output_browse);
			groupbox_settings_paths.Controls.Add(this.textbox_settings_paths_output);
			groupbox_settings_paths.Controls.Add(label1);
			groupbox_settings_paths.Controls.Add(this.textbox_settings_paths_gmpublish);
			groupbox_settings_paths.Controls.Add(label_gmpublish_path);
			groupbox_settings_paths.Controls.Add(this.textbox_settings_paths_addon);
			groupbox_settings_paths.Controls.Add(this.textbox_settings_paths_gmad);
			groupbox_settings_paths.Controls.Add(label_addon_path);
			groupbox_settings_paths.Controls.Add(label_gmad_path);
			groupbox_settings_paths.Location = new System.Drawing.Point(7, 19);
			groupbox_settings_paths.Name = "groupbox_settings_paths";
			groupbox_settings_paths.Size = new System.Drawing.Size(358, 131);
			groupbox_settings_paths.TabIndex = 2;
			groupbox_settings_paths.TabStop = false;
			groupbox_settings_paths.Text = "Paths";
			// 
			// button_settings_paths_output_browse
			// 
			this.button_settings_paths_output_browse.Location = new System.Drawing.Point(293, 96);
			this.button_settings_paths_output_browse.Name = "button_settings_paths_output_browse";
			this.button_settings_paths_output_browse.Size = new System.Drawing.Size(59, 22);
			this.button_settings_paths_output_browse.TabIndex = 6;
			this.button_settings_paths_output_browse.Text = "Browse";
			this.button_settings_paths_output_browse.UseVisualStyleBackColor = true;
			this.button_settings_paths_output_browse.Click += new System.EventHandler(this.button_settings_paths_output_browse_Click);
			// 
			// textbox_settings_paths_output
			// 
			this.textbox_settings_paths_output.Location = new System.Drawing.Point(79, 97);
			this.textbox_settings_paths_output.Name = "textbox_settings_paths_output";
			this.textbox_settings_paths_output.Size = new System.Drawing.Size(208, 20);
			this.textbox_settings_paths_output.TabIndex = 5;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(28, 100);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(45, 13);
			label1.TabIndex = 4;
			label1.Text = "Output :";
			label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textbox_settings_paths_gmpublish
			// 
			this.textbox_settings_paths_gmpublish.Location = new System.Drawing.Point(79, 45);
			this.textbox_settings_paths_gmpublish.Name = "textbox_settings_paths_gmpublish";
			this.textbox_settings_paths_gmpublish.Size = new System.Drawing.Size(274, 20);
			this.textbox_settings_paths_gmpublish.TabIndex = 2;
			// 
			// label_gmpublish_path
			// 
			label_gmpublish_path.AutoSize = true;
			label_gmpublish_path.Location = new System.Drawing.Point(13, 48);
			label_gmpublish_path.Name = "label_gmpublish_path";
			label_gmpublish_path.Size = new System.Drawing.Size(60, 13);
			label_gmpublish_path.TabIndex = 3;
			label_gmpublish_path.Text = "gmpublish :";
			label_gmpublish_path.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textbox_settings_paths_addon
			// 
			this.textbox_settings_paths_addon.Location = new System.Drawing.Point(79, 71);
			this.textbox_settings_paths_addon.Name = "textbox_settings_paths_addon";
			this.textbox_settings_paths_addon.Size = new System.Drawing.Size(273, 20);
			this.textbox_settings_paths_addon.TabIndex = 3;
			// 
			// textbox_settings_paths_gmad
			// 
			this.textbox_settings_paths_gmad.Location = new System.Drawing.Point(79, 19);
			this.textbox_settings_paths_gmad.Name = "textbox_settings_paths_gmad";
			this.textbox_settings_paths_gmad.Size = new System.Drawing.Size(274, 20);
			this.textbox_settings_paths_gmad.TabIndex = 0;
			// 
			// label_addon_path
			// 
			label_addon_path.AutoSize = true;
			label_addon_path.Location = new System.Drawing.Point(29, 74);
			label_addon_path.Name = "label_addon_path";
			label_addon_path.Size = new System.Drawing.Size(44, 13);
			label_addon_path.TabIndex = 1;
			label_addon_path.Text = "Addon :";
			label_addon_path.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label_gmad_path
			// 
			label_gmad_path.AutoSize = true;
			label_gmad_path.Location = new System.Drawing.Point(34, 22);
			label_gmad_path.Name = "label_gmad_path";
			label_gmad_path.Size = new System.Drawing.Size(39, 13);
			label_gmad_path.TabIndex = 1;
			label_gmad_path.Text = "gmad :";
			label_gmad_path.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// groupbox_actions
			// 
			groupbox_actions.Controls.Add(groupbox_actions_gman);
			groupbox_actions.Controls.Add(groupbox_actions_gmpublish);
			groupbox_actions.Controls.Add(groupbox_actions_gmad);
			groupbox_actions.Location = new System.Drawing.Point(13, 175);
			groupbox_actions.Name = "groupbox_actions";
			groupbox_actions.Size = new System.Drawing.Size(371, 310);
			groupbox_actions.TabIndex = 1;
			groupbox_actions.TabStop = false;
			groupbox_actions.Text = "Actions";
			// 
			// groupbox_actions_gman
			// 
			groupbox_actions_gman.Controls.Add(this.button_actions_gman_generation);
			groupbox_actions_gman.Controls.Add(this.button_actions_gman_update);
			groupbox_actions_gman.Location = new System.Drawing.Point(7, 224);
			groupbox_actions_gman.Name = "groupbox_actions_gman";
			groupbox_actions_gman.Size = new System.Drawing.Size(358, 80);
			groupbox_actions_gman.TabIndex = 8;
			groupbox_actions_gman.TabStop = false;
			groupbox_actions_gman.Text = "gman";
			// 
			// button_actions_gman_generation
			// 
			this.button_actions_gman_generation.Location = new System.Drawing.Point(39, 19);
			this.button_actions_gman_generation.Name = "button_actions_gman_generation";
			this.button_actions_gman_generation.Size = new System.Drawing.Size(278, 23);
			this.button_actions_gman_generation.TabIndex = 7;
			this.button_actions_gman_generation.Text = "Generation Menu";
			this.button_actions_gman_generation.UseVisualStyleBackColor = true;
			this.button_actions_gman_generation.Click += new System.EventHandler(this.button_actions_gman_generate_Click);
			// 
			// button_actions_gman_update
			// 
			this.button_actions_gman_update.Enabled = false;
			this.button_actions_gman_update.Location = new System.Drawing.Point(39, 48);
			this.button_actions_gman_update.Name = "button_actions_gman_update";
			this.button_actions_gman_update.Size = new System.Drawing.Size(278, 23);
			this.button_actions_gman_update.TabIndex = 6;
			this.button_actions_gman_update.Text = "Publish";
			this.button_actions_gman_update.UseVisualStyleBackColor = true;
			// 
			// groupbox_actions_gmpublish
			// 
			groupbox_actions_gmpublish.Controls.Add(this.button_actions_gmpublish_list);
			groupbox_actions_gmpublish.Controls.Add(this.button_actions_gmpublish_update);
			groupbox_actions_gmpublish.Controls.Add(this.button_actions_gmpublish_publish);
			groupbox_actions_gmpublish.Location = new System.Drawing.Point(7, 112);
			groupbox_actions_gmpublish.Name = "groupbox_actions_gmpublish";
			groupbox_actions_gmpublish.Size = new System.Drawing.Size(358, 106);
			groupbox_actions_gmpublish.TabIndex = 7;
			groupbox_actions_gmpublish.TabStop = false;
			groupbox_actions_gmpublish.Text = "gmpublish";
			// 
			// button_actions_gmpublish_list
			// 
			this.button_actions_gmpublish_list.Location = new System.Drawing.Point(39, 77);
			this.button_actions_gmpublish_list.Name = "button_actions_gmpublish_list";
			this.button_actions_gmpublish_list.Size = new System.Drawing.Size(278, 23);
			this.button_actions_gmpublish_list.TabIndex = 5;
			this.button_actions_gmpublish_list.Text = "Addons list";
			this.button_actions_gmpublish_list.UseVisualStyleBackColor = true;
			this.button_actions_gmpublish_list.Click += new System.EventHandler(this.button_actions_gmpublish_list_Click);
			// 
			// button_actions_gmpublish_update
			// 
			this.button_actions_gmpublish_update.Location = new System.Drawing.Point(39, 48);
			this.button_actions_gmpublish_update.Name = "button_actions_gmpublish_update";
			this.button_actions_gmpublish_update.Size = new System.Drawing.Size(278, 23);
			this.button_actions_gmpublish_update.TabIndex = 2;
			this.button_actions_gmpublish_update.Text = "Update .gma";
			this.button_actions_gmpublish_update.UseVisualStyleBackColor = true;
			this.button_actions_gmpublish_update.Click += new System.EventHandler(this.button_actions_gmpublish_update_Click);
			// 
			// button_actions_gmpublish_publish
			// 
			this.button_actions_gmpublish_publish.Location = new System.Drawing.Point(39, 19);
			this.button_actions_gmpublish_publish.Name = "button_actions_gmpublish_publish";
			this.button_actions_gmpublish_publish.Size = new System.Drawing.Size(278, 23);
			this.button_actions_gmpublish_publish.TabIndex = 4;
			this.button_actions_gmpublish_publish.Text = "Publish .gma";
			this.button_actions_gmpublish_publish.UseVisualStyleBackColor = true;
			this.button_actions_gmpublish_publish.Click += new System.EventHandler(this.button_actions_gmpublish_publish_Click);
			// 
			// groupbox_actions_gmad
			// 
			groupbox_actions_gmad.Controls.Add(this.button_actions_gmad_create);
			groupbox_actions_gmad.Controls.Add(this.button_actions_gmad_extract);
			groupbox_actions_gmad.Location = new System.Drawing.Point(7, 20);
			groupbox_actions_gmad.Name = "groupbox_actions_gmad";
			groupbox_actions_gmad.Size = new System.Drawing.Size(358, 86);
			groupbox_actions_gmad.TabIndex = 6;
			groupbox_actions_gmad.TabStop = false;
			groupbox_actions_gmad.Text = "gmad";
			// 
			// button_actions_gmad_create
			// 
			this.button_actions_gmad_create.Location = new System.Drawing.Point(39, 19);
			this.button_actions_gmad_create.Name = "button_actions_gmad_create";
			this.button_actions_gmad_create.Size = new System.Drawing.Size(278, 23);
			this.button_actions_gmad_create.TabIndex = 5;
			this.button_actions_gmad_create.Text = "Create .gma";
			this.button_actions_gmad_create.UseVisualStyleBackColor = true;
			this.button_actions_gmad_create.Click += new System.EventHandler(this.button_actions_gmad_create_Click);
			// 
			// button_actions_gmad_extract
			// 
			this.button_actions_gmad_extract.Location = new System.Drawing.Point(39, 48);
			this.button_actions_gmad_extract.Name = "button_actions_gmad_extract";
			this.button_actions_gmad_extract.Size = new System.Drawing.Size(278, 23);
			this.button_actions_gmad_extract.TabIndex = 2;
			this.button_actions_gmad_extract.Text = "Extract .gma";
			this.button_actions_gmad_extract.UseVisualStyleBackColor = true;
			this.button_actions_gmad_extract.Click += new System.EventHandler(this.button_actions_gmad_extract_Click);
			// 
			// groupbox_settings
			// 
			this.groupbox_settings.Controls.Add(groupbox_settings_paths);
			this.groupbox_settings.Location = new System.Drawing.Point(13, 13);
			this.groupbox_settings.Name = "groupbox_settings";
			this.groupbox_settings.Size = new System.Drawing.Size(371, 156);
			this.groupbox_settings.TabIndex = 0;
			this.groupbox_settings.TabStop = false;
			this.groupbox_settings.Text = "Settings";
			// 
			// folderbrowser_settings_paths_output
			// 
			this.folderbrowser_settings_paths_output.Description = "Output path";
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(396, 497);
			this.Controls.Add(groupbox_actions);
			this.Controls.Add(this.groupbox_settings);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Garry\'s Mod Addon Manager";
			groupbox_settings_paths.ResumeLayout(false);
			groupbox_settings_paths.PerformLayout();
			groupbox_actions.ResumeLayout(false);
			groupbox_actions_gman.ResumeLayout(false);
			groupbox_actions_gmpublish.ResumeLayout(false);
			groupbox_actions_gmad.ResumeLayout(false);
			this.groupbox_settings.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupbox_settings;
        private System.Windows.Forms.TextBox textbox_settings_paths_gmpublish;
        private System.Windows.Forms.TextBox textbox_settings_paths_gmad;
        private System.Windows.Forms.TextBox textbox_settings_paths_addon;
        private System.Windows.Forms.Button button_actions_gmad_extract;
        private System.Windows.Forms.Button button_actions_gmpublish_publish;
        private System.Windows.Forms.Button button_actions_gmad_create;
        private System.Windows.Forms.Button button_actions_gmpublish_update;
        private System.Windows.Forms.Button button_actions_gman_update;
        private System.Windows.Forms.Button button_actions_gman_generation;
        private System.Windows.Forms.TextBox textbox_settings_paths_output;
        private System.Windows.Forms.Button button_actions_gmpublish_list;
		private System.Windows.Forms.FolderBrowserDialog folderbrowser_settings_paths_output;
		private System.Windows.Forms.Button button_settings_paths_output_browse;
	}
}

