namespace OptiveDemoManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel5 = new System.Windows.Forms.Panel();
            this.NewDemosFolderPathPaste = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NewDemosFolderPath = new System.Windows.Forms.TextBox();
            this.SpecifyNewDemosFolder = new System.Windows.Forms.Button();
            this.ClearNewDemosFolderPath = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DemosFolderPath = new System.Windows.Forms.TextBox();
            this.ClearDemosFolderPath = new System.Windows.Forms.Button();
            this.SpecifyDemosFolder = new System.Windows.Forms.Button();
            this.SaveSettings = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CfgFolderPath = new System.Windows.Forms.TextBox();
            this.ClearCfgFolderPath = new System.Windows.Forms.Button();
            this.SpecifyCfgFolder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ToggleRecordAliasAviRecorder = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ToggleRecordAlias = new System.Windows.Forms.TextBox();
            this.ToggleRecordAliasClear = new System.Windows.Forms.Button();
            this.QuitGameCheckBox = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.TF2LaunchOptions = new System.Windows.Forms.TextBox();
            this.TF2LaunchOptionsClear = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Controls.Add(this.NewDemosFolderPathPaste);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.NewDemosFolderPath);
            this.panel5.Controls.Add(this.SpecifyNewDemosFolder);
            this.panel5.Controls.Add(this.ClearNewDemosFolderPath);
            this.panel5.Location = new System.Drawing.Point(12, 58);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(801, 74);
            this.panel5.TabIndex = 43;
            // 
            // NewDemosFolderPathPaste
            // 
            this.NewDemosFolderPathPaste.Location = new System.Drawing.Point(116, 46);
            this.NewDemosFolderPathPaste.Name = "NewDemosFolderPathPaste";
            this.NewDemosFolderPathPaste.Size = new System.Drawing.Size(43, 22);
            this.NewDemosFolderPathPaste.TabIndex = 43;
            this.NewDemosFolderPathPaste.Text = "Paste";
            this.NewDemosFolderPathPaste.UseVisualStyleBackColor = true;
            this.NewDemosFolderPathPaste.Click += new System.EventHandler(this.NewDemosFolderPathPaste_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(166, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(462, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Example: \'C:\\Program Files (x86)\\Steam\\steamapps\\common\\Team Fortress 2\\tf\\demos\\" +
    "video1\'";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(204, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Folder processed demos will be moved to:";
            // 
            // NewDemosFolderPath
            // 
            this.NewDemosFolderPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewDemosFolderPath.Location = new System.Drawing.Point(3, 18);
            this.NewDemosFolderPath.Name = "NewDemosFolderPath";
            this.NewDemosFolderPath.Size = new System.Drawing.Size(795, 20);
            this.NewDemosFolderPath.TabIndex = 33;
            this.NewDemosFolderPath.Text = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Team Fortress 2\\tf\\demos";
            // 
            // SpecifyNewDemosFolder
            // 
            this.SpecifyNewDemosFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpecifyNewDemosFolder.Location = new System.Drawing.Point(4, 46);
            this.SpecifyNewDemosFolder.Name = "SpecifyNewDemosFolder";
            this.SpecifyNewDemosFolder.Size = new System.Drawing.Size(55, 22);
            this.SpecifyNewDemosFolder.TabIndex = 28;
            this.SpecifyNewDemosFolder.Text = "Choose";
            this.SpecifyNewDemosFolder.UseVisualStyleBackColor = true;
            this.SpecifyNewDemosFolder.Click += new System.EventHandler(this.SpecifyNewDemosFolder_Click);
            // 
            // ClearNewDemosFolderPath
            // 
            this.ClearNewDemosFolderPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearNewDemosFolderPath.Location = new System.Drawing.Point(65, 46);
            this.ClearNewDemosFolderPath.Name = "ClearNewDemosFolderPath";
            this.ClearNewDemosFolderPath.Size = new System.Drawing.Size(45, 22);
            this.ClearNewDemosFolderPath.TabIndex = 37;
            this.ClearNewDemosFolderPath.Text = "Clear";
            this.ClearNewDemosFolderPath.UseVisualStyleBackColor = true;
            this.ClearNewDemosFolderPath.Click += new System.EventHandler(this.ClearNewDemosFolderPath_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.DemosFolderPath);
            this.panel2.Controls.Add(this.ClearDemosFolderPath);
            this.panel2.Controls.Add(this.SpecifyDemosFolder);
            this.panel2.Location = new System.Drawing.Point(12, 138);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(801, 74);
            this.panel2.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(115, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(447, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "Can be the same as the processed demos location to just rename the demos and crea" +
    "te VDM";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(286, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Folder where source demos are located and or recorded to:";
            // 
            // DemosFolderPath
            // 
            this.DemosFolderPath.AllowDrop = true;
            this.DemosFolderPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DemosFolderPath.Location = new System.Drawing.Point(3, 18);
            this.DemosFolderPath.Name = "DemosFolderPath";
            this.DemosFolderPath.Size = new System.Drawing.Size(795, 20);
            this.DemosFolderPath.TabIndex = 31;
            this.DemosFolderPath.Text = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Team Fortress 2\\tf\\demos\\ds";
            // 
            // ClearDemosFolderPath
            // 
            this.ClearDemosFolderPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearDemosFolderPath.Location = new System.Drawing.Point(64, 46);
            this.ClearDemosFolderPath.Name = "ClearDemosFolderPath";
            this.ClearDemosFolderPath.Size = new System.Drawing.Size(45, 22);
            this.ClearDemosFolderPath.TabIndex = 36;
            this.ClearDemosFolderPath.Text = "Clear";
            this.ClearDemosFolderPath.UseVisualStyleBackColor = true;
            this.ClearDemosFolderPath.Click += new System.EventHandler(this.ClearDemosFolderPath_Click);
            // 
            // SpecifyDemosFolder
            // 
            this.SpecifyDemosFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpecifyDemosFolder.Location = new System.Drawing.Point(3, 46);
            this.SpecifyDemosFolder.Name = "SpecifyDemosFolder";
            this.SpecifyDemosFolder.Size = new System.Drawing.Size(55, 22);
            this.SpecifyDemosFolder.TabIndex = 25;
            this.SpecifyDemosFolder.Text = "Choose";
            this.SpecifyDemosFolder.UseVisualStyleBackColor = true;
            this.SpecifyDemosFolder.Click += new System.EventHandler(this.SpecifyDemosFolder_Click);
            // 
            // SaveSettings
            // 
            this.SaveSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveSettings.Location = new System.Drawing.Point(819, 12);
            this.SaveSettings.Name = "SaveSettings";
            this.SaveSettings.Size = new System.Drawing.Size(91, 350);
            this.SaveSettings.TabIndex = 45;
            this.SaveSettings.Text = "Save and close";
            this.SaveSettings.UseVisualStyleBackColor = true;
            this.SaveSettings.Click += new System.EventHandler(this.SaveSettings_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Silver;
            this.panel7.Controls.Add(this.MessageLabel);
            this.panel7.Location = new System.Drawing.Point(12, 22);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(801, 30);
            this.panel7.TabIndex = 46;
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.BackColor = System.Drawing.Color.Transparent;
            this.MessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageLabel.Location = new System.Drawing.Point(1, 8);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(76, 13);
            this.MessageLabel.TabIndex = 17;
            this.MessageLabel.Text = "MessageLabel";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CfgFolderPath);
            this.panel1.Controls.Add(this.ClearCfgFolderPath);
            this.panel1.Controls.Add(this.SpecifyCfgFolder);
            this.panel1.Location = new System.Drawing.Point(12, 218);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 74);
            this.panel1.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "This will allow you to press a key to launch the demo name that you enter on the " +
    "first form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Path config folder:";
            // 
            // CfgFolderPath
            // 
            this.CfgFolderPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CfgFolderPath.Location = new System.Drawing.Point(3, 18);
            this.CfgFolderPath.Name = "CfgFolderPath";
            this.CfgFolderPath.Size = new System.Drawing.Size(795, 20);
            this.CfgFolderPath.TabIndex = 31;
            this.CfgFolderPath.Text = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Team Fortress 2\\tf\\cfg";
            // 
            // ClearCfgFolderPath
            // 
            this.ClearCfgFolderPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearCfgFolderPath.Location = new System.Drawing.Point(64, 46);
            this.ClearCfgFolderPath.Name = "ClearCfgFolderPath";
            this.ClearCfgFolderPath.Size = new System.Drawing.Size(45, 22);
            this.ClearCfgFolderPath.TabIndex = 36;
            this.ClearCfgFolderPath.Text = "Clear";
            this.ClearCfgFolderPath.UseVisualStyleBackColor = true;
            this.ClearCfgFolderPath.Click += new System.EventHandler(this.ClearCfgFolderPath_Click);
            // 
            // SpecifyCfgFolder
            // 
            this.SpecifyCfgFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpecifyCfgFolder.Location = new System.Drawing.Point(3, 46);
            this.SpecifyCfgFolder.Name = "SpecifyCfgFolder";
            this.SpecifyCfgFolder.Size = new System.Drawing.Size(55, 22);
            this.SpecifyCfgFolder.TabIndex = 25;
            this.SpecifyCfgFolder.Text = "Choose";
            this.SpecifyCfgFolder.UseVisualStyleBackColor = true;
            this.SpecifyCfgFolder.Click += new System.EventHandler(this.SpecifyCfgFolder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "bind f12 \"exec OptivePlayDemo\"";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.ToggleRecordAliasAviRecorder);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.ToggleRecordAlias);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.ToggleRecordAliasClear);
            this.panel3.Location = new System.Drawing.Point(12, 298);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(801, 103);
            this.panel3.TabIndex = 49;
            // 
            // ToggleRecordAliasAviRecorder
            // 
            this.ToggleRecordAliasAviRecorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToggleRecordAliasAviRecorder.Location = new System.Drawing.Point(55, 46);
            this.ToggleRecordAliasAviRecorder.Name = "ToggleRecordAliasAviRecorder";
            this.ToggleRecordAliasAviRecorder.Size = new System.Drawing.Size(138, 22);
            this.ToggleRecordAliasAviRecorder.TabIndex = 41;
            this.ToggleRecordAliasAviRecorder.Text = "Using AviRecorder";
            this.ToggleRecordAliasAviRecorder.UseVisualStyleBackColor = true;
            this.ToggleRecordAliasAviRecorder.Click += new System.EventHandler(this.ToggleRecordAliasAviRecorder_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(199, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "alias used to start and stop recording";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "toggle recording command";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(176, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(438, 13);
            this.label10.TabIndex = 51;
            this.label10.Text = "<- This will allow you to press a key to launch the demo name that you enter on t" +
    "he first form";
            // 
            // ToggleRecordAlias
            // 
            this.ToggleRecordAlias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToggleRecordAlias.Location = new System.Drawing.Point(3, 18);
            this.ToggleRecordAlias.Name = "ToggleRecordAlias";
            this.ToggleRecordAlias.Size = new System.Drawing.Size(795, 20);
            this.ToggleRecordAlias.TabIndex = 31;
            this.ToggleRecordAlias.Text = "avi_recorder_startstop";
            // 
            // ToggleRecordAliasClear
            // 
            this.ToggleRecordAliasClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToggleRecordAliasClear.Location = new System.Drawing.Point(4, 46);
            this.ToggleRecordAliasClear.Name = "ToggleRecordAliasClear";
            this.ToggleRecordAliasClear.Size = new System.Drawing.Size(45, 22);
            this.ToggleRecordAliasClear.TabIndex = 36;
            this.ToggleRecordAliasClear.Text = "Clear";
            this.ToggleRecordAliasClear.UseVisualStyleBackColor = true;
            this.ToggleRecordAliasClear.Click += new System.EventHandler(this.ToggleRecordAliasClear_Click);
            // 
            // QuitGameCheckBox
            // 
            this.QuitGameCheckBox.AutoSize = true;
            this.QuitGameCheckBox.Location = new System.Drawing.Point(527, 44);
            this.QuitGameCheckBox.Name = "QuitGameCheckBox";
            this.QuitGameCheckBox.Size = new System.Drawing.Size(242, 17);
            this.QuitGameCheckBox.TabIndex = 50;
            this.QuitGameCheckBox.Text = "Quit game in VDM after recording each demo.";
            this.QuitGameCheckBox.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.QuitGameCheckBox);
            this.panel4.Controls.Add(this.TF2LaunchOptions);
            this.panel4.Controls.Add(this.TF2LaunchOptionsClear);
            this.panel4.Location = new System.Drawing.Point(12, 420);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(801, 74);
            this.panel4.TabIndex = 52;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(166, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "TF2 Launch Options for recording";
            // 
            // TF2LaunchOptions
            // 
            this.TF2LaunchOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TF2LaunchOptions.Location = new System.Drawing.Point(3, 18);
            this.TF2LaunchOptions.Name = "TF2LaunchOptions";
            this.TF2LaunchOptions.Size = new System.Drawing.Size(795, 20);
            this.TF2LaunchOptions.TabIndex = 31;
            // 
            // TF2LaunchOptionsClear
            // 
            this.TF2LaunchOptionsClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TF2LaunchOptionsClear.Location = new System.Drawing.Point(4, 46);
            this.TF2LaunchOptionsClear.Name = "TF2LaunchOptionsClear";
            this.TF2LaunchOptionsClear.Size = new System.Drawing.Size(45, 22);
            this.TF2LaunchOptionsClear.TabIndex = 36;
            this.TF2LaunchOptionsClear.Text = "Clear";
            this.TF2LaunchOptionsClear.UseVisualStyleBackColor = true;
            this.TF2LaunchOptionsClear.Click += new System.EventHandler(this.TF2LaunchOptionsClear_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 13);
            this.label13.TabIndex = 53;
            this.label13.Text = "Demo sorting settings:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 404);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(164, 13);
            this.label14.TabIndex = 54;
            this.label14.Text = "Demo recording process settings:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(55, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(345, 13);
            this.label11.TabIndex = 51;
            this.label11.Text = "these launch options will be used when this program launches the game";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 624);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.SaveSettings);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Settings";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button NewDemosFolderPathPaste;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NewDemosFolderPath;
        private System.Windows.Forms.Button SpecifyNewDemosFolder;
        private System.Windows.Forms.Button ClearNewDemosFolderPath;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DemosFolderPath;
        private System.Windows.Forms.Button ClearDemosFolderPath;
        private System.Windows.Forms.Button SpecifyDemosFolder;
        private System.Windows.Forms.Button SaveSettings;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CfgFolderPath;
        private System.Windows.Forms.Button ClearCfgFolderPath;
        private System.Windows.Forms.Button SpecifyCfgFolder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ToggleRecordAlias;
        private System.Windows.Forms.Button ToggleRecordAliasClear;
        private System.Windows.Forms.Button ToggleRecordAliasAviRecorder;
        private System.Windows.Forms.CheckBox QuitGameCheckBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TF2LaunchOptions;
        private System.Windows.Forms.Button TF2LaunchOptionsClear;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
    }
}