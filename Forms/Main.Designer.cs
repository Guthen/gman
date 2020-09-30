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
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tc_main = new System.Windows.Forms.TabControl();
            this.tp_create = new System.Windows.Forms.TabPage();
            this.gb_create_gma = new System.Windows.Forms.GroupBox();
            this.b_create_gma_compress = new System.Windows.Forms.Button();
            this.b_create_gma_update = new System.Windows.Forms.Button();
            this.b_create_gma_publish = new System.Windows.Forms.Button();
            this.gb_create_json = new System.Windows.Forms.GroupBox();
            this.b_create_json_find = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_create_json_ignore = new System.Windows.Forms.TextBox();
            this.cob_create_json_tag_2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cob_create_json_tag_1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.b_create_json_generate = new System.Windows.Forms.Button();
            this.cob_create_json_type = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_create_json_title = new System.Windows.Forms.TextBox();
            this.l_create_folder = new System.Windows.Forms.Label();
            this.b_create_folder = new System.Windows.Forms.Button();
            this.tb_create_folder = new System.Windows.Forms.TextBox();
            this.tp_extract = new System.Windows.Forms.TabPage();
            this.tp_settings = new System.Windows.Forms.TabPage();
            this.gb_settings_paths = new System.Windows.Forms.GroupBox();
            this.b_settings_paths_gmad = new System.Windows.Forms.Button();
            this.l_settings_paths_gmpublish = new System.Windows.Forms.Label();
            this.tb_settings_paths_gmpublish = new System.Windows.Forms.TextBox();
            this.l_settings_paths_gmad = new System.Windows.Forms.Label();
            this.cb_settings_paths = new System.Windows.Forms.CheckBox();
            this.tb_settings_paths_gmad = new System.Windows.Forms.TextBox();
            this.l_settings_gmh = new System.Windows.Forms.Label();
            this.b_settings_gmh = new System.Windows.Forms.Button();
            this.tb_settings_gmh = new System.Windows.Forms.TextBox();
            this.tool_tip = new System.Windows.Forms.ToolTip(this.components);
            this.l_version = new System.Windows.Forms.Label();
            this.l_author = new System.Windows.Forms.Label();
            this.b_settings_paths_gmpublish = new System.Windows.Forms.Button();
            this.tc_main.SuspendLayout();
            this.tp_create.SuspendLayout();
            this.gb_create_gma.SuspendLayout();
            this.gb_create_json.SuspendLayout();
            this.tp_settings.SuspendLayout();
            this.gb_settings_paths.SuspendLayout();
            this.SuspendLayout();
            // 
            // tc_main
            // 
            this.tc_main.Controls.Add(this.tp_create);
            this.tc_main.Controls.Add(this.tp_extract);
            this.tc_main.Controls.Add(this.tp_settings);
            this.tc_main.Location = new System.Drawing.Point(12, 12);
            this.tc_main.Name = "tc_main";
            this.tc_main.SelectedIndex = 0;
            this.tc_main.Size = new System.Drawing.Size(374, 411);
            this.tc_main.TabIndex = 3;
            // 
            // tp_create
            // 
            this.tp_create.Controls.Add(this.gb_create_gma);
            this.tp_create.Controls.Add(this.gb_create_json);
            this.tp_create.Controls.Add(this.l_create_folder);
            this.tp_create.Controls.Add(this.b_create_folder);
            this.tp_create.Controls.Add(this.tb_create_folder);
            this.tp_create.Location = new System.Drawing.Point(4, 22);
            this.tp_create.Name = "tp_create";
            this.tp_create.Padding = new System.Windows.Forms.Padding(3);
            this.tp_create.Size = new System.Drawing.Size(366, 385);
            this.tp_create.TabIndex = 0;
            this.tp_create.Text = "Create";
            this.tp_create.UseVisualStyleBackColor = true;
            // 
            // gb_create_gma
            // 
            this.gb_create_gma.Controls.Add(this.b_create_gma_compress);
            this.gb_create_gma.Controls.Add(this.b_create_gma_update);
            this.gb_create_gma.Controls.Add(this.b_create_gma_publish);
            this.gb_create_gma.Location = new System.Drawing.Point(9, 265);
            this.gb_create_gma.Name = "gb_create_gma";
            this.gb_create_gma.Size = new System.Drawing.Size(341, 111);
            this.gb_create_gma.TabIndex = 4;
            this.gb_create_gma.TabStop = false;
            this.gb_create_gma.Text = "GMA";
            // 
            // b_create_gma_compress
            // 
            this.b_create_gma_compress.Location = new System.Drawing.Point(60, 19);
            this.b_create_gma_compress.Name = "b_create_gma_compress";
            this.b_create_gma_compress.Size = new System.Drawing.Size(220, 23);
            this.b_create_gma_compress.TabIndex = 2;
            this.b_create_gma_compress.Text = "Compress";
            this.b_create_gma_compress.UseVisualStyleBackColor = true;
            this.b_create_gma_compress.Click += new System.EventHandler(this.b_create_gma_compress_Click);
            // 
            // b_create_gma_update
            // 
            this.b_create_gma_update.Enabled = false;
            this.b_create_gma_update.Location = new System.Drawing.Point(60, 77);
            this.b_create_gma_update.Name = "b_create_gma_update";
            this.b_create_gma_update.Size = new System.Drawing.Size(220, 23);
            this.b_create_gma_update.TabIndex = 1;
            this.b_create_gma_update.Text = "Update";
            this.b_create_gma_update.UseVisualStyleBackColor = true;
            this.b_create_gma_update.Click += new System.EventHandler(this.b_create_gma_update_Click);
            // 
            // b_create_gma_publish
            // 
            this.b_create_gma_publish.Location = new System.Drawing.Point(60, 48);
            this.b_create_gma_publish.Name = "b_create_gma_publish";
            this.b_create_gma_publish.Size = new System.Drawing.Size(220, 23);
            this.b_create_gma_publish.TabIndex = 0;
            this.b_create_gma_publish.Text = "Publish";
            this.b_create_gma_publish.UseVisualStyleBackColor = true;
            this.b_create_gma_publish.Click += new System.EventHandler(this.b_create_gma_publish_Click);
            // 
            // gb_create_json
            // 
            this.gb_create_json.Controls.Add(this.b_create_json_find);
            this.gb_create_json.Controls.Add(this.label5);
            this.gb_create_json.Controls.Add(this.tb_create_json_ignore);
            this.gb_create_json.Controls.Add(this.cob_create_json_tag_2);
            this.gb_create_json.Controls.Add(this.label4);
            this.gb_create_json.Controls.Add(this.cob_create_json_tag_1);
            this.gb_create_json.Controls.Add(this.label3);
            this.gb_create_json.Controls.Add(this.b_create_json_generate);
            this.gb_create_json.Controls.Add(this.cob_create_json_type);
            this.gb_create_json.Controls.Add(this.label2);
            this.gb_create_json.Controls.Add(this.label1);
            this.gb_create_json.Controls.Add(this.tb_create_json_title);
            this.gb_create_json.Location = new System.Drawing.Point(9, 56);
            this.gb_create_json.Name = "gb_create_json";
            this.gb_create_json.Size = new System.Drawing.Size(341, 202);
            this.gb_create_json.TabIndex = 3;
            this.gb_create_json.TabStop = false;
            this.gb_create_json.Text = "JSON";
            // 
            // b_create_json_find
            // 
            this.b_create_json_find.Location = new System.Drawing.Point(174, 172);
            this.b_create_json_find.Name = "b_create_json_find";
            this.b_create_json_find.Size = new System.Drawing.Size(56, 23);
            this.b_create_json_find.TabIndex = 16;
            this.b_create_json_find.Text = "Find";
            this.b_create_json_find.UseVisualStyleBackColor = true;
            this.b_create_json_find.Click += new System.EventHandler(this.b_create_json_find_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Ignore";
            // 
            // tb_create_json_ignore
            // 
            this.tb_create_json_ignore.Location = new System.Drawing.Point(7, 87);
            this.tb_create_json_ignore.Multiline = true;
            this.tb_create_json_ignore.Name = "tb_create_json_ignore";
            this.tb_create_json_ignore.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_create_json_ignore.Size = new System.Drawing.Size(159, 79);
            this.tb_create_json_ignore.TabIndex = 14;
            // 
            // cob_create_json_tag_2
            // 
            this.cob_create_json_tag_2.FormattingEnabled = true;
            this.cob_create_json_tag_2.Location = new System.Drawing.Point(174, 145);
            this.cob_create_json_tag_2.Name = "cob_create_json_tag_2";
            this.cob_create_json_tag_2.Size = new System.Drawing.Size(161, 21);
            this.cob_create_json_tag_2.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tag 2";
            // 
            // cob_create_json_tag_1
            // 
            this.cob_create_json_tag_1.FormattingEnabled = true;
            this.cob_create_json_tag_1.Location = new System.Drawing.Point(174, 87);
            this.cob_create_json_tag_1.Name = "cob_create_json_tag_1";
            this.cob_create_json_tag_1.Size = new System.Drawing.Size(161, 21);
            this.cob_create_json_tag_1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tag 1";
            // 
            // b_create_json_generate
            // 
            this.b_create_json_generate.Location = new System.Drawing.Point(236, 172);
            this.b_create_json_generate.Name = "b_create_json_generate";
            this.b_create_json_generate.Size = new System.Drawing.Size(99, 23);
            this.b_create_json_generate.TabIndex = 9;
            this.b_create_json_generate.Text = "Generate";
            this.b_create_json_generate.UseVisualStyleBackColor = true;
            this.b_create_json_generate.Click += new System.EventHandler(this.b_create_json_generate_Click);
            // 
            // cob_create_json_type
            // 
            this.cob_create_json_type.FormattingEnabled = true;
            this.cob_create_json_type.Location = new System.Drawing.Point(174, 38);
            this.cob_create_json_type.Name = "cob_create_json_type";
            this.cob_create_json_type.Size = new System.Drawing.Size(161, 21);
            this.cob_create_json_type.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Title";
            // 
            // tb_create_json_title
            // 
            this.tb_create_json_title.Location = new System.Drawing.Point(6, 38);
            this.tb_create_json_title.Name = "tb_create_json_title";
            this.tb_create_json_title.Size = new System.Drawing.Size(160, 20);
            this.tb_create_json_title.TabIndex = 4;
            this.tb_create_json_title.Text = "My Addon\'s Title";
            // 
            // l_create_folder
            // 
            this.l_create_folder.AutoSize = true;
            this.l_create_folder.Location = new System.Drawing.Point(6, 9);
            this.l_create_folder.Name = "l_create_folder";
            this.l_create_folder.Size = new System.Drawing.Size(36, 13);
            this.l_create_folder.TabIndex = 2;
            this.l_create_folder.Text = "Folder";
            // 
            // b_create_folder
            // 
            this.b_create_folder.Location = new System.Drawing.Point(326, 26);
            this.b_create_folder.Name = "b_create_folder";
            this.b_create_folder.Size = new System.Drawing.Size(24, 24);
            this.b_create_folder.TabIndex = 1;
            this.b_create_folder.Text = "...";
            this.b_create_folder.UseVisualStyleBackColor = true;
            this.b_create_folder.Click += new System.EventHandler(this.b_create_folder_Click);
            // 
            // tb_create_folder
            // 
            this.tb_create_folder.Location = new System.Drawing.Point(9, 29);
            this.tb_create_folder.Name = "tb_create_folder";
            this.tb_create_folder.Size = new System.Drawing.Size(311, 20);
            this.tb_create_folder.TabIndex = 0;
            this.tb_create_folder.Text = "K:\\Programmes\\Steam\\steamapps\\common\\GarrysMod\\garrysmod\\addons";
            // 
            // tp_extract
            // 
            this.tp_extract.Location = new System.Drawing.Point(4, 22);
            this.tp_extract.Name = "tp_extract";
            this.tp_extract.Padding = new System.Windows.Forms.Padding(3);
            this.tp_extract.Size = new System.Drawing.Size(366, 385);
            this.tp_extract.TabIndex = 1;
            this.tp_extract.Text = "Extract";
            this.tp_extract.UseVisualStyleBackColor = true;
            // 
            // tp_settings
            // 
            this.tp_settings.Controls.Add(this.gb_settings_paths);
            this.tp_settings.Controls.Add(this.l_settings_gmh);
            this.tp_settings.Controls.Add(this.b_settings_gmh);
            this.tp_settings.Controls.Add(this.tb_settings_gmh);
            this.tp_settings.Location = new System.Drawing.Point(4, 22);
            this.tp_settings.Name = "tp_settings";
            this.tp_settings.Size = new System.Drawing.Size(366, 385);
            this.tp_settings.TabIndex = 2;
            this.tp_settings.Text = "Settings";
            this.tp_settings.UseVisualStyleBackColor = true;
            // 
            // gb_settings_paths
            // 
            this.gb_settings_paths.Controls.Add(this.b_settings_paths_gmpublish);
            this.gb_settings_paths.Controls.Add(this.b_settings_paths_gmad);
            this.gb_settings_paths.Controls.Add(this.l_settings_paths_gmpublish);
            this.gb_settings_paths.Controls.Add(this.tb_settings_paths_gmpublish);
            this.gb_settings_paths.Controls.Add(this.l_settings_paths_gmad);
            this.gb_settings_paths.Controls.Add(this.cb_settings_paths);
            this.gb_settings_paths.Controls.Add(this.tb_settings_paths_gmad);
            this.gb_settings_paths.Location = new System.Drawing.Point(9, 56);
            this.gb_settings_paths.Name = "gb_settings_paths";
            this.gb_settings_paths.Size = new System.Drawing.Size(341, 142);
            this.gb_settings_paths.TabIndex = 7;
            this.gb_settings_paths.TabStop = false;
            this.gb_settings_paths.Text = "Custom Paths";
            // 
            // b_settings_paths_gmad
            // 
            this.b_settings_paths_gmad.Enabled = false;
            this.b_settings_paths_gmad.Location = new System.Drawing.Point(305, 55);
            this.b_settings_paths_gmad.Name = "b_settings_paths_gmad";
            this.b_settings_paths_gmad.Size = new System.Drawing.Size(24, 24);
            this.b_settings_paths_gmad.TabIndex = 13;
            this.b_settings_paths_gmad.Text = "...";
            this.b_settings_paths_gmad.UseVisualStyleBackColor = true;
            this.b_settings_paths_gmad.Click += new System.EventHandler(this.b_settings_paths_gmad_Click);
            // 
            // l_settings_paths_gmpublish
            // 
            this.l_settings_paths_gmpublish.AutoSize = true;
            this.l_settings_paths_gmpublish.Enabled = false;
            this.l_settings_paths_gmpublish.Location = new System.Drawing.Point(7, 89);
            this.l_settings_paths_gmpublish.Name = "l_settings_paths_gmpublish";
            this.l_settings_paths_gmpublish.Size = new System.Drawing.Size(54, 13);
            this.l_settings_paths_gmpublish.TabIndex = 10;
            this.l_settings_paths_gmpublish.Text = "gmpublish";
            // 
            // tb_settings_paths_gmpublish
            // 
            this.tb_settings_paths_gmpublish.Enabled = false;
            this.tb_settings_paths_gmpublish.Location = new System.Drawing.Point(10, 109);
            this.tb_settings_paths_gmpublish.Name = "tb_settings_paths_gmpublish";
            this.tb_settings_paths_gmpublish.Size = new System.Drawing.Size(289, 20);
            this.tb_settings_paths_gmpublish.TabIndex = 11;
            this.tb_settings_paths_gmpublish.Text = "K:\\Programmes\\Steam\\steamapps\\common\\GarrysMod\\bin\\gmpublish.exe";
            // 
            // l_settings_paths_gmad
            // 
            this.l_settings_paths_gmad.AutoSize = true;
            this.l_settings_paths_gmad.Enabled = false;
            this.l_settings_paths_gmad.Location = new System.Drawing.Point(7, 39);
            this.l_settings_paths_gmad.Name = "l_settings_paths_gmad";
            this.l_settings_paths_gmad.Size = new System.Drawing.Size(33, 13);
            this.l_settings_paths_gmad.TabIndex = 8;
            this.l_settings_paths_gmad.Text = "gmad";
            // 
            // cb_settings_paths
            // 
            this.cb_settings_paths.AutoSize = true;
            this.cb_settings_paths.Location = new System.Drawing.Point(10, 19);
            this.cb_settings_paths.Name = "cb_settings_paths";
            this.cb_settings_paths.Size = new System.Drawing.Size(65, 17);
            this.cb_settings_paths.TabIndex = 6;
            this.cb_settings_paths.Text = "Enabled";
            this.cb_settings_paths.UseVisualStyleBackColor = true;
            this.cb_settings_paths.CheckedChanged += new System.EventHandler(this.cb_settings_paths_CheckedChanged);
            // 
            // tb_settings_paths_gmad
            // 
            this.tb_settings_paths_gmad.Enabled = false;
            this.tb_settings_paths_gmad.Location = new System.Drawing.Point(10, 59);
            this.tb_settings_paths_gmad.Name = "tb_settings_paths_gmad";
            this.tb_settings_paths_gmad.Size = new System.Drawing.Size(289, 20);
            this.tb_settings_paths_gmad.TabIndex = 8;
            this.tb_settings_paths_gmad.Text = "K:\\Programmes\\Steam\\steamapps\\common\\GarrysMod\\bin\\gmad.exe";
            // 
            // l_settings_gmh
            // 
            this.l_settings_gmh.AutoSize = true;
            this.l_settings_gmh.Location = new System.Drawing.Point(6, 9);
            this.l_settings_gmh.Name = "l_settings_gmh";
            this.l_settings_gmh.Size = new System.Drawing.Size(94, 13);
            this.l_settings_gmh.TabIndex = 5;
            this.l_settings_gmh.Text = "Garry\'s Mod Home";
            // 
            // b_settings_gmh
            // 
            this.b_settings_gmh.Location = new System.Drawing.Point(326, 26);
            this.b_settings_gmh.Name = "b_settings_gmh";
            this.b_settings_gmh.Size = new System.Drawing.Size(24, 24);
            this.b_settings_gmh.TabIndex = 4;
            this.b_settings_gmh.Text = "...";
            this.b_settings_gmh.UseVisualStyleBackColor = true;
            this.b_settings_gmh.Click += new System.EventHandler(this.b_settings_gmh_Click);
            // 
            // tb_settings_gmh
            // 
            this.tb_settings_gmh.Location = new System.Drawing.Point(9, 29);
            this.tb_settings_gmh.Name = "tb_settings_gmh";
            this.tb_settings_gmh.Size = new System.Drawing.Size(311, 20);
            this.tb_settings_gmh.TabIndex = 3;
            this.tb_settings_gmh.Text = "K:\\Programmes\\Steam\\steamapps\\common\\GarrysMod";
            // 
            // l_version
            // 
            this.l_version.AutoSize = true;
            this.l_version.Location = new System.Drawing.Point(9, 428);
            this.l_version.Name = "l_version";
            this.l_version.Size = new System.Drawing.Size(48, 13);
            this.l_version.TabIndex = 4;
            this.l_version.Text = "[Version]";
            // 
            // l_author
            // 
            this.l_author.AutoSize = true;
            this.l_author.Location = new System.Drawing.Point(332, 428);
            this.l_author.Name = "l_author";
            this.l_author.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.l_author.Size = new System.Drawing.Size(44, 13);
            this.l_author.TabIndex = 5;
            this.l_author.Text = "[Author]";
            this.l_author.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // b_settings_paths_gmpublish
            // 
            this.b_settings_paths_gmpublish.Enabled = false;
            this.b_settings_paths_gmpublish.Location = new System.Drawing.Point(305, 105);
            this.b_settings_paths_gmpublish.Name = "b_settings_paths_gmpublish";
            this.b_settings_paths_gmpublish.Size = new System.Drawing.Size(24, 24);
            this.b_settings_paths_gmpublish.TabIndex = 14;
            this.b_settings_paths_gmpublish.Text = "...";
            this.b_settings_paths_gmpublish.UseVisualStyleBackColor = true;
            this.b_settings_paths_gmpublish.Click += new System.EventHandler(this.b_settings_paths_gmpublish_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 447);
            this.Controls.Add(this.l_author);
            this.Controls.Add(this.l_version);
            this.Controls.Add(this.tc_main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Garry\'s Mod Addon Nanomatic";
            this.tc_main.ResumeLayout(false);
            this.tp_create.ResumeLayout(false);
            this.tp_create.PerformLayout();
            this.gb_create_gma.ResumeLayout(false);
            this.gb_create_json.ResumeLayout(false);
            this.gb_create_json.PerformLayout();
            this.tp_settings.ResumeLayout(false);
            this.tp_settings.PerformLayout();
            this.gb_settings_paths.ResumeLayout(false);
            this.gb_settings_paths.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tc_main;
        private System.Windows.Forms.TabPage tp_create;
        private System.Windows.Forms.TabPage tp_extract;
        private System.Windows.Forms.Label l_create_folder;
        private System.Windows.Forms.Button b_create_folder;
        private System.Windows.Forms.TextBox tb_create_folder;
        private System.Windows.Forms.TabPage tp_settings;
        private System.Windows.Forms.GroupBox gb_settings_paths;
        private System.Windows.Forms.CheckBox cb_settings_paths;
        private System.Windows.Forms.Label l_settings_gmh;
        private System.Windows.Forms.Button b_settings_gmh;
        private System.Windows.Forms.TextBox tb_settings_gmh;
        private System.Windows.Forms.Label l_settings_paths_gmad;
        private System.Windows.Forms.TextBox tb_settings_paths_gmad;
        private System.Windows.Forms.TextBox tb_settings_paths_gmpublish;
        private System.Windows.Forms.Label l_settings_paths_gmpublish;
        private System.Windows.Forms.GroupBox gb_create_json;
        private System.Windows.Forms.ComboBox cob_create_json_type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_create_json_title;
        private System.Windows.Forms.Button b_create_json_generate;
        private System.Windows.Forms.ComboBox cob_create_json_tag_2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cob_create_json_tag_1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_create_json_ignore;
        private System.Windows.Forms.GroupBox gb_create_gma;
        private System.Windows.Forms.Button b_create_gma_update;
        private System.Windows.Forms.Button b_create_gma_publish;
        private System.Windows.Forms.Button b_create_gma_compress;
        private System.Windows.Forms.ToolTip tool_tip;
        private System.Windows.Forms.Label l_version;
        private System.Windows.Forms.Label l_author;
        private System.Windows.Forms.Button b_create_json_find;
        private System.Windows.Forms.Button b_settings_paths_gmad;
        private System.Windows.Forms.Button b_settings_paths_gmpublish;
    }
}

