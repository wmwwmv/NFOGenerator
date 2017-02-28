﻿namespace NFOGenerator
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtInputFile = new System.Windows.Forms.TextBox();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.lblInputFile = new System.Windows.Forms.Label();
            this.grpGeneral = new System.Windows.Forms.GroupBox();
            this.cmbGeneralProper = new System.Windows.Forms.ComboBox();
            this.cmbGeneralHybrid = new System.Windows.Forms.ComboBox();
            this.cmbGeneralEdition = new System.Windows.Forms.ComboBox();
            this.cmbGeneralYear = new System.Windows.Forms.ComboBox();
            this.cmbGeneralAudio = new System.Windows.Forms.ComboBox();
            this.cmbGeneralResolution = new System.Windows.Forms.ComboBox();
            this.lblGeneralReleaseName = new System.Windows.Forms.Label();
            this.chkGeneralChaptersNamed = new System.Windows.Forms.CheckBox();
            this.txtGeneralReleaseName = new System.Windows.Forms.TextBox();
            this.chkGeneralChaptersIncluded = new System.Windows.Forms.CheckBox();
            this.lblGeneralChapters = new System.Windows.Forms.Label();
            this.btnGeneralGenerate = new System.Windows.Forms.Button();
            this.lblGeneralAudio = new System.Windows.Forms.Label();
            this.lblGeneralResolution = new System.Windows.Forms.Label();
            this.lblGeneralDuration = new System.Windows.Forms.Label();
            this.lblGeneralHybrid = new System.Windows.Forms.Label();
            this.lblGeneralSize = new System.Windows.Forms.Label();
            this.lblGeneralYear = new System.Windows.Forms.Label();
            this.lblGeneralProper = new System.Windows.Forms.Label();
            this.txtGeneralDuration = new System.Windows.Forms.TextBox();
            this.lblGeneralEdition = new System.Windows.Forms.Label();
            this.txtGeneralSize = new System.Windows.Forms.TextBox();
            this.txtGeneralTitle = new System.Windows.Forms.TextBox();
            this.lblGeneralTitle = new System.Windows.Forms.Label();
            this.grpAudio = new System.Windows.Forms.GroupBox();
            this.btnAudioAdd = new System.Windows.Forms.Button();
            this.lstAudio = new System.Windows.Forms.ListBox();
            this.txtAudioComment = new System.Windows.Forms.TextBox();
            this.txtAudioBitrate = new System.Windows.Forms.TextBox();
            this.lblAudioComment = new System.Windows.Forms.Label();
            this.txtAudioChannels = new System.Windows.Forms.TextBox();
            this.lblAudioBitrate = new System.Windows.Forms.Label();
            this.txtAudioCodec = new System.Windows.Forms.TextBox();
            this.lblAudioChannels = new System.Windows.Forms.Label();
            this.lblAudioCodec = new System.Windows.Forms.Label();
            this.txtAudioLanguage = new System.Windows.Forms.TextBox();
            this.lblAudioLanguage = new System.Windows.Forms.Label();
            this.grpSubtitle = new System.Windows.Forms.GroupBox();
            this.btnSubtitleAdd = new System.Windows.Forms.Button();
            this.lstSubtitle = new System.Windows.Forms.ListBox();
            this.txtSubtitleComment = new System.Windows.Forms.TextBox();
            this.txtSubtitleFormat = new System.Windows.Forms.TextBox();
            this.lblSubtitleComment = new System.Windows.Forms.Label();
            this.lblSubtitleFormat = new System.Windows.Forms.Label();
            this.txtSubtitleLanguage = new System.Windows.Forms.TextBox();
            this.lblSubtitleLanguage = new System.Windows.Forms.Label();
            this.txtTargetLocation = new System.Windows.Forms.TextBox();
            this.lblTargetLocation = new System.Windows.Forms.Label();
            this.txtVideoBitrate = new System.Windows.Forms.TextBox();
            this.lblVideoFramerate = new System.Windows.Forms.Label();
            this.lblVideoBitrate = new System.Windows.Forms.Label();
            this.lblVideoNote = new System.Windows.Forms.Label();
            this.txtVideoNote = new System.Windows.Forms.TextBox();
            this.lblVideoWidth = new System.Windows.Forms.Label();
            this.txtVideoWidth = new System.Windows.Forms.TextBox();
            this.grpVideo = new System.Windows.Forms.GroupBox();
            this.cmbVideoCodec = new System.Windows.Forms.ComboBox();
            this.txtVideoDAR = new System.Windows.Forms.TextBox();
            this.lblVideoDAR = new System.Windows.Forms.Label();
            this.txtVideoHeight = new System.Windows.Forms.TextBox();
            this.lblVideoHeight = new System.Windows.Forms.Label();
            this.lblVideoCodec = new System.Windows.Forms.Label();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnTargetBrowse = new System.Windows.Forms.Button();
            this.grpSource = new System.Windows.Forms.GroupBox();
            this.cmbSourceResolution = new System.Windows.Forms.ComboBox();
            this.cmbSourceType = new System.Windows.Forms.ComboBox();
            this.lblSourceType = new System.Windows.Forms.Label();
            this.lblSourceName = new System.Windows.Forms.Label();
            this.btnSourceGuess = new System.Windows.Forms.Button();
            this.txtSourceName = new System.Windows.Forms.TextBox();
            this.lblSourceResolution = new System.Windows.Forms.Label();
            this.mnsMain = new System.Windows.Forms.MenuStrip();
            this.mnsFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsFileClear = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsFileMediaInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsFileSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnsFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsTools = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsToolsZonesCommand = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsHelpAboutUs = new System.Windows.Forms.ToolStripMenuItem();
            this.txtVideoFramerate = new System.Windows.Forms.TextBox();
            this.grpInput.SuspendLayout();
            this.grpGeneral.SuspendLayout();
            this.grpAudio.SuspendLayout();
            this.grpSubtitle.SuspendLayout();
            this.grpVideo.SuspendLayout();
            this.grpSource.SuspendLayout();
            this.mnsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInputFile
            // 
            this.txtInputFile.Location = new System.Drawing.Point(83, 20);
            this.txtInputFile.Name = "txtInputFile";
            this.txtInputFile.Size = new System.Drawing.Size(573, 21);
            this.txtInputFile.TabIndex = 0;
            this.txtInputFile.TextChanged += new System.EventHandler(this.txtInputFile_TextChanged);
            // 
            // grpInput
            // 
            this.grpInput.Controls.Add(this.lblInputFile);
            this.grpInput.Controls.Add(this.txtInputFile);
            this.grpInput.Location = new System.Drawing.Point(12, 28);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(662, 53);
            this.grpInput.TabIndex = 1;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Input";
            // 
            // lblInputFile
            // 
            this.lblInputFile.AutoSize = true;
            this.lblInputFile.Location = new System.Drawing.Point(6, 23);
            this.lblInputFile.Name = "lblInputFile";
            this.lblInputFile.Size = new System.Drawing.Size(71, 12);
            this.lblInputFile.TabIndex = 1;
            this.lblInputFile.Text = "Media File:";
            // 
            // grpGeneral
            // 
            this.grpGeneral.Controls.Add(this.cmbGeneralProper);
            this.grpGeneral.Controls.Add(this.cmbGeneralHybrid);
            this.grpGeneral.Controls.Add(this.cmbGeneralEdition);
            this.grpGeneral.Controls.Add(this.cmbGeneralYear);
            this.grpGeneral.Controls.Add(this.cmbGeneralAudio);
            this.grpGeneral.Controls.Add(this.cmbGeneralResolution);
            this.grpGeneral.Controls.Add(this.lblGeneralReleaseName);
            this.grpGeneral.Controls.Add(this.chkGeneralChaptersNamed);
            this.grpGeneral.Controls.Add(this.txtGeneralReleaseName);
            this.grpGeneral.Controls.Add(this.chkGeneralChaptersIncluded);
            this.grpGeneral.Controls.Add(this.lblGeneralChapters);
            this.grpGeneral.Controls.Add(this.btnGeneralGenerate);
            this.grpGeneral.Controls.Add(this.lblGeneralAudio);
            this.grpGeneral.Controls.Add(this.lblGeneralResolution);
            this.grpGeneral.Controls.Add(this.lblGeneralDuration);
            this.grpGeneral.Controls.Add(this.lblGeneralHybrid);
            this.grpGeneral.Controls.Add(this.lblGeneralSize);
            this.grpGeneral.Controls.Add(this.lblGeneralYear);
            this.grpGeneral.Controls.Add(this.lblGeneralProper);
            this.grpGeneral.Controls.Add(this.txtGeneralDuration);
            this.grpGeneral.Controls.Add(this.lblGeneralEdition);
            this.grpGeneral.Controls.Add(this.txtGeneralSize);
            this.grpGeneral.Controls.Add(this.txtGeneralTitle);
            this.grpGeneral.Controls.Add(this.lblGeneralTitle);
            this.grpGeneral.Location = new System.Drawing.Point(12, 87);
            this.grpGeneral.Name = "grpGeneral";
            this.grpGeneral.Size = new System.Drawing.Size(662, 151);
            this.grpGeneral.TabIndex = 2;
            this.grpGeneral.TabStop = false;
            this.grpGeneral.Text = "General";
            // 
            // cmbGeneralProper
            // 
            this.cmbGeneralProper.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGeneralProper.FormattingEnabled = true;
            this.cmbGeneralProper.Location = new System.Drawing.Point(289, 67);
            this.cmbGeneralProper.Name = "cmbGeneralProper";
            this.cmbGeneralProper.Size = new System.Drawing.Size(126, 20);
            this.cmbGeneralProper.TabIndex = 8;
            // 
            // cmbGeneralHybrid
            // 
            this.cmbGeneralHybrid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGeneralHybrid.FormattingEnabled = true;
            this.cmbGeneralHybrid.Location = new System.Drawing.Point(83, 67);
            this.cmbGeneralHybrid.Name = "cmbGeneralHybrid";
            this.cmbGeneralHybrid.Size = new System.Drawing.Size(91, 20);
            this.cmbGeneralHybrid.TabIndex = 8;
            // 
            // cmbGeneralEdition
            // 
            this.cmbGeneralEdition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGeneralEdition.FormattingEnabled = true;
            this.cmbGeneralEdition.Location = new System.Drawing.Point(289, 41);
            this.cmbGeneralEdition.Name = "cmbGeneralEdition";
            this.cmbGeneralEdition.Size = new System.Drawing.Size(126, 20);
            this.cmbGeneralEdition.TabIndex = 8;
            // 
            // cmbGeneralYear
            // 
            this.cmbGeneralYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGeneralYear.FormattingEnabled = true;
            this.cmbGeneralYear.Location = new System.Drawing.Point(83, 41);
            this.cmbGeneralYear.Name = "cmbGeneralYear";
            this.cmbGeneralYear.Size = new System.Drawing.Size(91, 20);
            this.cmbGeneralYear.TabIndex = 8;
            // 
            // cmbGeneralAudio
            // 
            this.cmbGeneralAudio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGeneralAudio.FormattingEnabled = true;
            this.cmbGeneralAudio.Location = new System.Drawing.Point(528, 67);
            this.cmbGeneralAudio.Name = "cmbGeneralAudio";
            this.cmbGeneralAudio.Size = new System.Drawing.Size(128, 20);
            this.cmbGeneralAudio.TabIndex = 8;
            // 
            // cmbGeneralResolution
            // 
            this.cmbGeneralResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGeneralResolution.FormattingEnabled = true;
            this.cmbGeneralResolution.Location = new System.Drawing.Point(528, 41);
            this.cmbGeneralResolution.Name = "cmbGeneralResolution";
            this.cmbGeneralResolution.Size = new System.Drawing.Size(128, 20);
            this.cmbGeneralResolution.TabIndex = 8;
            // 
            // lblGeneralReleaseName
            // 
            this.lblGeneralReleaseName.AutoSize = true;
            this.lblGeneralReleaseName.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblGeneralReleaseName.Location = new System.Drawing.Point(6, 123);
            this.lblGeneralReleaseName.Name = "lblGeneralReleaseName";
            this.lblGeneralReleaseName.Size = new System.Drawing.Size(68, 12);
            this.lblGeneralReleaseName.TabIndex = 7;
            this.lblGeneralReleaseName.Text = "RLZ Name:";
            // 
            // chkGeneralChaptersNamed
            // 
            this.chkGeneralChaptersNamed.AutoSize = true;
            this.chkGeneralChaptersNamed.Location = new System.Drawing.Point(602, 95);
            this.chkGeneralChaptersNamed.Name = "chkGeneralChaptersNamed";
            this.chkGeneralChaptersNamed.Size = new System.Drawing.Size(54, 16);
            this.chkGeneralChaptersNamed.TabIndex = 10;
            this.chkGeneralChaptersNamed.Text = "Named";
            this.chkGeneralChaptersNamed.UseVisualStyleBackColor = true;
            // 
            // txtGeneralReleaseName
            // 
            this.txtGeneralReleaseName.Location = new System.Drawing.Point(83, 120);
            this.txtGeneralReleaseName.Name = "txtGeneralReleaseName";
            this.txtGeneralReleaseName.Size = new System.Drawing.Size(492, 21);
            this.txtGeneralReleaseName.TabIndex = 6;
            // 
            // chkGeneralChaptersIncluded
            // 
            this.chkGeneralChaptersIncluded.AutoSize = true;
            this.chkGeneralChaptersIncluded.Checked = true;
            this.chkGeneralChaptersIncluded.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGeneralChaptersIncluded.Location = new System.Drawing.Point(524, 95);
            this.chkGeneralChaptersIncluded.Name = "chkGeneralChaptersIncluded";
            this.chkGeneralChaptersIncluded.Size = new System.Drawing.Size(72, 16);
            this.chkGeneralChaptersIncluded.TabIndex = 10;
            this.chkGeneralChaptersIncluded.Text = "Included";
            this.chkGeneralChaptersIncluded.UseVisualStyleBackColor = true;
            // 
            // lblGeneralChapters
            // 
            this.lblGeneralChapters.AutoSize = true;
            this.lblGeneralChapters.Location = new System.Drawing.Point(450, 96);
            this.lblGeneralChapters.Name = "lblGeneralChapters";
            this.lblGeneralChapters.Size = new System.Drawing.Size(59, 12);
            this.lblGeneralChapters.TabIndex = 9;
            this.lblGeneralChapters.Text = "Chapters:";
            // 
            // btnGeneralGenerate
            // 
            this.btnGeneralGenerate.Location = new System.Drawing.Point(581, 119);
            this.btnGeneralGenerate.Name = "btnGeneralGenerate";
            this.btnGeneralGenerate.Size = new System.Drawing.Size(75, 21);
            this.btnGeneralGenerate.TabIndex = 3;
            this.btnGeneralGenerate.Text = "Generate";
            this.btnGeneralGenerate.UseVisualStyleBackColor = true;
            this.btnGeneralGenerate.Click += new System.EventHandler(this.btnGeneralGenerate_Click);
            // 
            // lblGeneralAudio
            // 
            this.lblGeneralAudio.AutoSize = true;
            this.lblGeneralAudio.Location = new System.Drawing.Point(450, 70);
            this.lblGeneralAudio.Name = "lblGeneralAudio";
            this.lblGeneralAudio.Size = new System.Drawing.Size(41, 12);
            this.lblGeneralAudio.TabIndex = 4;
            this.lblGeneralAudio.Text = "Audio:";
            // 
            // lblGeneralResolution
            // 
            this.lblGeneralResolution.AutoSize = true;
            this.lblGeneralResolution.Location = new System.Drawing.Point(450, 44);
            this.lblGeneralResolution.Name = "lblGeneralResolution";
            this.lblGeneralResolution.Size = new System.Drawing.Size(71, 12);
            this.lblGeneralResolution.TabIndex = 4;
            this.lblGeneralResolution.Text = "Resolution:";
            // 
            // lblGeneralDuration
            // 
            this.lblGeneralDuration.AutoSize = true;
            this.lblGeneralDuration.Location = new System.Drawing.Point(224, 96);
            this.lblGeneralDuration.Name = "lblGeneralDuration";
            this.lblGeneralDuration.Size = new System.Drawing.Size(59, 12);
            this.lblGeneralDuration.TabIndex = 4;
            this.lblGeneralDuration.Text = "Duration:";
            // 
            // lblGeneralHybrid
            // 
            this.lblGeneralHybrid.AutoSize = true;
            this.lblGeneralHybrid.Location = new System.Drawing.Point(6, 70);
            this.lblGeneralHybrid.Name = "lblGeneralHybrid";
            this.lblGeneralHybrid.Size = new System.Drawing.Size(47, 12);
            this.lblGeneralHybrid.TabIndex = 4;
            this.lblGeneralHybrid.Text = "Hybrid:";
            // 
            // lblGeneralSize
            // 
            this.lblGeneralSize.AutoSize = true;
            this.lblGeneralSize.Location = new System.Drawing.Point(6, 96);
            this.lblGeneralSize.Name = "lblGeneralSize";
            this.lblGeneralSize.Size = new System.Drawing.Size(35, 12);
            this.lblGeneralSize.TabIndex = 4;
            this.lblGeneralSize.Text = "Size:";
            // 
            // lblGeneralYear
            // 
            this.lblGeneralYear.AutoSize = true;
            this.lblGeneralYear.Location = new System.Drawing.Point(6, 44);
            this.lblGeneralYear.Name = "lblGeneralYear";
            this.lblGeneralYear.Size = new System.Drawing.Size(35, 12);
            this.lblGeneralYear.TabIndex = 4;
            this.lblGeneralYear.Text = "Year:";
            // 
            // lblGeneralProper
            // 
            this.lblGeneralProper.AutoSize = true;
            this.lblGeneralProper.Location = new System.Drawing.Point(224, 70);
            this.lblGeneralProper.Name = "lblGeneralProper";
            this.lblGeneralProper.Size = new System.Drawing.Size(47, 12);
            this.lblGeneralProper.TabIndex = 2;
            this.lblGeneralProper.Text = "Proper:";
            // 
            // txtGeneralDuration
            // 
            this.txtGeneralDuration.Location = new System.Drawing.Point(289, 93);
            this.txtGeneralDuration.Name = "txtGeneralDuration";
            this.txtGeneralDuration.Size = new System.Drawing.Size(126, 21);
            this.txtGeneralDuration.TabIndex = 5;
            // 
            // lblGeneralEdition
            // 
            this.lblGeneralEdition.AutoSize = true;
            this.lblGeneralEdition.Location = new System.Drawing.Point(224, 44);
            this.lblGeneralEdition.Name = "lblGeneralEdition";
            this.lblGeneralEdition.Size = new System.Drawing.Size(53, 12);
            this.lblGeneralEdition.TabIndex = 2;
            this.lblGeneralEdition.Text = "Edition:";
            // 
            // txtGeneralSize
            // 
            this.txtGeneralSize.Location = new System.Drawing.Point(83, 93);
            this.txtGeneralSize.Name = "txtGeneralSize";
            this.txtGeneralSize.ReadOnly = true;
            this.txtGeneralSize.Size = new System.Drawing.Size(91, 21);
            this.txtGeneralSize.TabIndex = 5;
            // 
            // txtGeneralTitle
            // 
            this.txtGeneralTitle.Location = new System.Drawing.Point(83, 14);
            this.txtGeneralTitle.Name = "txtGeneralTitle";
            this.txtGeneralTitle.Size = new System.Drawing.Size(573, 21);
            this.txtGeneralTitle.TabIndex = 1;
            // 
            // lblGeneralTitle
            // 
            this.lblGeneralTitle.AutoSize = true;
            this.lblGeneralTitle.Location = new System.Drawing.Point(6, 17);
            this.lblGeneralTitle.Name = "lblGeneralTitle";
            this.lblGeneralTitle.Size = new System.Drawing.Size(41, 12);
            this.lblGeneralTitle.TabIndex = 0;
            this.lblGeneralTitle.Text = "Title:";
            // 
            // grpAudio
            // 
            this.grpAudio.Controls.Add(this.btnAudioAdd);
            this.grpAudio.Controls.Add(this.lstAudio);
            this.grpAudio.Controls.Add(this.txtAudioComment);
            this.grpAudio.Controls.Add(this.txtAudioBitrate);
            this.grpAudio.Controls.Add(this.lblAudioComment);
            this.grpAudio.Controls.Add(this.txtAudioChannels);
            this.grpAudio.Controls.Add(this.lblAudioBitrate);
            this.grpAudio.Controls.Add(this.txtAudioCodec);
            this.grpAudio.Controls.Add(this.lblAudioChannels);
            this.grpAudio.Controls.Add(this.lblAudioCodec);
            this.grpAudio.Controls.Add(this.txtAudioLanguage);
            this.grpAudio.Controls.Add(this.lblAudioLanguage);
            this.grpAudio.Location = new System.Drawing.Point(12, 426);
            this.grpAudio.Name = "grpAudio";
            this.grpAudio.Size = new System.Drawing.Size(324, 198);
            this.grpAudio.TabIndex = 11;
            this.grpAudio.TabStop = false;
            this.grpAudio.Text = "Audio";
            // 
            // btnAudioAdd
            // 
            this.btnAudioAdd.Location = new System.Drawing.Point(215, 14);
            this.btnAudioAdd.Name = "btnAudioAdd";
            this.btnAudioAdd.Size = new System.Drawing.Size(102, 102);
            this.btnAudioAdd.TabIndex = 7;
            this.btnAudioAdd.Text = "Add Audio";
            this.btnAudioAdd.UseVisualStyleBackColor = true;
            // 
            // lstAudio
            // 
            this.lstAudio.FormattingEnabled = true;
            this.lstAudio.ItemHeight = 12;
            this.lstAudio.Location = new System.Drawing.Point(6, 149);
            this.lstAudio.Name = "lstAudio";
            this.lstAudio.Size = new System.Drawing.Size(309, 40);
            this.lstAudio.TabIndex = 6;
            // 
            // txtAudioComment
            // 
            this.txtAudioComment.Location = new System.Drawing.Point(83, 122);
            this.txtAudioComment.Name = "txtAudioComment";
            this.txtAudioComment.Size = new System.Drawing.Size(232, 21);
            this.txtAudioComment.TabIndex = 5;
            // 
            // txtAudioBitrate
            // 
            this.txtAudioBitrate.Location = new System.Drawing.Point(83, 95);
            this.txtAudioBitrate.Name = "txtAudioBitrate";
            this.txtAudioBitrate.Size = new System.Drawing.Size(126, 21);
            this.txtAudioBitrate.TabIndex = 5;
            // 
            // lblAudioComment
            // 
            this.lblAudioComment.AutoSize = true;
            this.lblAudioComment.Location = new System.Drawing.Point(6, 125);
            this.lblAudioComment.Name = "lblAudioComment";
            this.lblAudioComment.Size = new System.Drawing.Size(53, 12);
            this.lblAudioComment.TabIndex = 4;
            this.lblAudioComment.Text = "Comment:";
            // 
            // txtAudioChannels
            // 
            this.txtAudioChannels.Location = new System.Drawing.Point(83, 68);
            this.txtAudioChannels.Name = "txtAudioChannels";
            this.txtAudioChannels.Size = new System.Drawing.Size(126, 21);
            this.txtAudioChannels.TabIndex = 5;
            // 
            // lblAudioBitrate
            // 
            this.lblAudioBitrate.AutoSize = true;
            this.lblAudioBitrate.Location = new System.Drawing.Point(6, 98);
            this.lblAudioBitrate.Name = "lblAudioBitrate";
            this.lblAudioBitrate.Size = new System.Drawing.Size(53, 12);
            this.lblAudioBitrate.TabIndex = 4;
            this.lblAudioBitrate.Text = "Bitrate:";
            // 
            // txtAudioCodec
            // 
            this.txtAudioCodec.Location = new System.Drawing.Point(83, 41);
            this.txtAudioCodec.Name = "txtAudioCodec";
            this.txtAudioCodec.Size = new System.Drawing.Size(126, 21);
            this.txtAudioCodec.TabIndex = 5;
            // 
            // lblAudioChannels
            // 
            this.lblAudioChannels.AutoSize = true;
            this.lblAudioChannels.Location = new System.Drawing.Point(6, 71);
            this.lblAudioChannels.Name = "lblAudioChannels";
            this.lblAudioChannels.Size = new System.Drawing.Size(59, 12);
            this.lblAudioChannels.TabIndex = 4;
            this.lblAudioChannels.Text = "Channels:";
            // 
            // lblAudioCodec
            // 
            this.lblAudioCodec.AutoSize = true;
            this.lblAudioCodec.Location = new System.Drawing.Point(6, 44);
            this.lblAudioCodec.Name = "lblAudioCodec";
            this.lblAudioCodec.Size = new System.Drawing.Size(41, 12);
            this.lblAudioCodec.TabIndex = 4;
            this.lblAudioCodec.Text = "Codec:";
            // 
            // txtAudioLanguage
            // 
            this.txtAudioLanguage.Location = new System.Drawing.Point(83, 14);
            this.txtAudioLanguage.Name = "txtAudioLanguage";
            this.txtAudioLanguage.Size = new System.Drawing.Size(126, 21);
            this.txtAudioLanguage.TabIndex = 1;
            // 
            // lblAudioLanguage
            // 
            this.lblAudioLanguage.AutoSize = true;
            this.lblAudioLanguage.Location = new System.Drawing.Point(6, 17);
            this.lblAudioLanguage.Name = "lblAudioLanguage";
            this.lblAudioLanguage.Size = new System.Drawing.Size(59, 12);
            this.lblAudioLanguage.TabIndex = 0;
            this.lblAudioLanguage.Text = "Language:";
            // 
            // grpSubtitle
            // 
            this.grpSubtitle.Controls.Add(this.btnSubtitleAdd);
            this.grpSubtitle.Controls.Add(this.lstSubtitle);
            this.grpSubtitle.Controls.Add(this.txtSubtitleComment);
            this.grpSubtitle.Controls.Add(this.txtSubtitleFormat);
            this.grpSubtitle.Controls.Add(this.lblSubtitleComment);
            this.grpSubtitle.Controls.Add(this.lblSubtitleFormat);
            this.grpSubtitle.Controls.Add(this.txtSubtitleLanguage);
            this.grpSubtitle.Controls.Add(this.lblSubtitleLanguage);
            this.grpSubtitle.Location = new System.Drawing.Point(350, 426);
            this.grpSubtitle.Name = "grpSubtitle";
            this.grpSubtitle.Size = new System.Drawing.Size(324, 198);
            this.grpSubtitle.TabIndex = 12;
            this.grpSubtitle.TabStop = false;
            this.grpSubtitle.Text = "Subtitle";
            // 
            // btnSubtitleAdd
            // 
            this.btnSubtitleAdd.Location = new System.Drawing.Point(215, 14);
            this.btnSubtitleAdd.Name = "btnSubtitleAdd";
            this.btnSubtitleAdd.Size = new System.Drawing.Size(103, 102);
            this.btnSubtitleAdd.TabIndex = 7;
            this.btnSubtitleAdd.Text = "Add Audio";
            this.btnSubtitleAdd.UseVisualStyleBackColor = true;
            // 
            // lstSubtitle
            // 
            this.lstSubtitle.FormattingEnabled = true;
            this.lstSubtitle.ItemHeight = 12;
            this.lstSubtitle.Location = new System.Drawing.Point(6, 149);
            this.lstSubtitle.Name = "lstSubtitle";
            this.lstSubtitle.Size = new System.Drawing.Size(312, 40);
            this.lstSubtitle.TabIndex = 6;
            // 
            // txtSubtitleComment
            // 
            this.txtSubtitleComment.Location = new System.Drawing.Point(83, 122);
            this.txtSubtitleComment.Name = "txtSubtitleComment";
            this.txtSubtitleComment.Size = new System.Drawing.Size(235, 21);
            this.txtSubtitleComment.TabIndex = 5;
            // 
            // txtSubtitleFormat
            // 
            this.txtSubtitleFormat.Location = new System.Drawing.Point(83, 68);
            this.txtSubtitleFormat.Name = "txtSubtitleFormat";
            this.txtSubtitleFormat.Size = new System.Drawing.Size(126, 21);
            this.txtSubtitleFormat.TabIndex = 5;
            // 
            // lblSubtitleComment
            // 
            this.lblSubtitleComment.AutoSize = true;
            this.lblSubtitleComment.Location = new System.Drawing.Point(6, 125);
            this.lblSubtitleComment.Name = "lblSubtitleComment";
            this.lblSubtitleComment.Size = new System.Drawing.Size(53, 12);
            this.lblSubtitleComment.TabIndex = 4;
            this.lblSubtitleComment.Text = "Comment:";
            // 
            // lblSubtitleFormat
            // 
            this.lblSubtitleFormat.AutoSize = true;
            this.lblSubtitleFormat.Location = new System.Drawing.Point(6, 71);
            this.lblSubtitleFormat.Name = "lblSubtitleFormat";
            this.lblSubtitleFormat.Size = new System.Drawing.Size(47, 12);
            this.lblSubtitleFormat.TabIndex = 4;
            this.lblSubtitleFormat.Text = "Format:";
            // 
            // txtSubtitleLanguage
            // 
            this.txtSubtitleLanguage.Location = new System.Drawing.Point(83, 14);
            this.txtSubtitleLanguage.Name = "txtSubtitleLanguage";
            this.txtSubtitleLanguage.Size = new System.Drawing.Size(126, 21);
            this.txtSubtitleLanguage.TabIndex = 1;
            // 
            // lblSubtitleLanguage
            // 
            this.lblSubtitleLanguage.AutoSize = true;
            this.lblSubtitleLanguage.Location = new System.Drawing.Point(6, 17);
            this.lblSubtitleLanguage.Name = "lblSubtitleLanguage";
            this.lblSubtitleLanguage.Size = new System.Drawing.Size(59, 12);
            this.lblSubtitleLanguage.TabIndex = 0;
            this.lblSubtitleLanguage.Text = "Language:";
            // 
            // txtTargetLocation
            // 
            this.txtTargetLocation.Location = new System.Drawing.Point(130, 630);
            this.txtTargetLocation.Name = "txtTargetLocation";
            this.txtTargetLocation.Size = new System.Drawing.Size(376, 21);
            this.txtTargetLocation.TabIndex = 0;
            // 
            // lblTargetLocation
            // 
            this.lblTargetLocation.AutoSize = true;
            this.lblTargetLocation.Location = new System.Drawing.Point(23, 634);
            this.lblTargetLocation.Name = "lblTargetLocation";
            this.lblTargetLocation.Size = new System.Drawing.Size(101, 12);
            this.lblTargetLocation.TabIndex = 1;
            this.lblTargetLocation.Text = "Target Location:";
            // 
            // txtVideoBitrate
            // 
            this.txtVideoBitrate.Location = new System.Drawing.Point(227, 46);
            this.txtVideoBitrate.Name = "txtVideoBitrate";
            this.txtVideoBitrate.ReadOnly = true;
            this.txtVideoBitrate.Size = new System.Drawing.Size(88, 21);
            this.txtVideoBitrate.TabIndex = 5;
            // 
            // lblVideoFramerate
            // 
            this.lblVideoFramerate.AutoSize = true;
            this.lblVideoFramerate.Location = new System.Drawing.Point(162, 23);
            this.lblVideoFramerate.Name = "lblVideoFramerate";
            this.lblVideoFramerate.Size = new System.Drawing.Size(65, 12);
            this.lblVideoFramerate.TabIndex = 4;
            this.lblVideoFramerate.Text = "Framerate:";
            // 
            // lblVideoBitrate
            // 
            this.lblVideoBitrate.AutoSize = true;
            this.lblVideoBitrate.Location = new System.Drawing.Point(162, 52);
            this.lblVideoBitrate.Name = "lblVideoBitrate";
            this.lblVideoBitrate.Size = new System.Drawing.Size(53, 12);
            this.lblVideoBitrate.TabIndex = 4;
            this.lblVideoBitrate.Text = "Bitrate:";
            // 
            // lblVideoNote
            // 
            this.lblVideoNote.AutoSize = true;
            this.lblVideoNote.Location = new System.Drawing.Point(336, 23);
            this.lblVideoNote.Name = "lblVideoNote";
            this.lblVideoNote.Size = new System.Drawing.Size(35, 12);
            this.lblVideoNote.TabIndex = 7;
            this.lblVideoNote.Text = "Note:";
            // 
            // txtVideoNote
            // 
            this.txtVideoNote.Location = new System.Drawing.Point(377, 20);
            this.txtVideoNote.Multiline = true;
            this.txtVideoNote.Name = "txtVideoNote";
            this.txtVideoNote.Size = new System.Drawing.Size(279, 77);
            this.txtVideoNote.TabIndex = 6;
            // 
            // lblVideoWidth
            // 
            this.lblVideoWidth.AutoSize = true;
            this.lblVideoWidth.Location = new System.Drawing.Point(6, 22);
            this.lblVideoWidth.Name = "lblVideoWidth";
            this.lblVideoWidth.Size = new System.Drawing.Size(41, 12);
            this.lblVideoWidth.TabIndex = 4;
            this.lblVideoWidth.Text = "Width:";
            // 
            // txtVideoWidth
            // 
            this.txtVideoWidth.Location = new System.Drawing.Point(83, 19);
            this.txtVideoWidth.Name = "txtVideoWidth";
            this.txtVideoWidth.ReadOnly = true;
            this.txtVideoWidth.Size = new System.Drawing.Size(73, 21);
            this.txtVideoWidth.TabIndex = 5;
            // 
            // grpVideo
            // 
            this.grpVideo.Controls.Add(this.cmbVideoCodec);
            this.grpVideo.Controls.Add(this.txtVideoDAR);
            this.grpVideo.Controls.Add(this.lblVideoDAR);
            this.grpVideo.Controls.Add(this.txtVideoHeight);
            this.grpVideo.Controls.Add(this.lblVideoHeight);
            this.grpVideo.Controls.Add(this.txtVideoWidth);
            this.grpVideo.Controls.Add(this.lblVideoWidth);
            this.grpVideo.Controls.Add(this.txtVideoNote);
            this.grpVideo.Controls.Add(this.lblVideoNote);
            this.grpVideo.Controls.Add(this.lblVideoCodec);
            this.grpVideo.Controls.Add(this.lblVideoBitrate);
            this.grpVideo.Controls.Add(this.lblVideoFramerate);
            this.grpVideo.Controls.Add(this.txtVideoFramerate);
            this.grpVideo.Controls.Add(this.txtVideoBitrate);
            this.grpVideo.Location = new System.Drawing.Point(12, 317);
            this.grpVideo.Name = "grpVideo";
            this.grpVideo.Size = new System.Drawing.Size(662, 103);
            this.grpVideo.TabIndex = 15;
            this.grpVideo.TabStop = false;
            this.grpVideo.Text = "Video";
            // 
            // cmbVideoCodec
            // 
            this.cmbVideoCodec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVideoCodec.FormattingEnabled = true;
            this.cmbVideoCodec.Location = new System.Drawing.Point(227, 76);
            this.cmbVideoCodec.Name = "cmbVideoCodec";
            this.cmbVideoCodec.Size = new System.Drawing.Size(88, 20);
            this.cmbVideoCodec.TabIndex = 8;
            // 
            // txtVideoDAR
            // 
            this.txtVideoDAR.Location = new System.Drawing.Point(83, 76);
            this.txtVideoDAR.Name = "txtVideoDAR";
            this.txtVideoDAR.ReadOnly = true;
            this.txtVideoDAR.Size = new System.Drawing.Size(73, 21);
            this.txtVideoDAR.TabIndex = 5;
            // 
            // lblVideoDAR
            // 
            this.lblVideoDAR.AutoSize = true;
            this.lblVideoDAR.Location = new System.Drawing.Point(6, 79);
            this.lblVideoDAR.Name = "lblVideoDAR";
            this.lblVideoDAR.Size = new System.Drawing.Size(29, 12);
            this.lblVideoDAR.TabIndex = 4;
            this.lblVideoDAR.Text = "DAR:";
            // 
            // txtVideoHeight
            // 
            this.txtVideoHeight.Location = new System.Drawing.Point(83, 49);
            this.txtVideoHeight.Name = "txtVideoHeight";
            this.txtVideoHeight.ReadOnly = true;
            this.txtVideoHeight.Size = new System.Drawing.Size(73, 21);
            this.txtVideoHeight.TabIndex = 5;
            // 
            // lblVideoHeight
            // 
            this.lblVideoHeight.AutoSize = true;
            this.lblVideoHeight.Location = new System.Drawing.Point(6, 49);
            this.lblVideoHeight.Name = "lblVideoHeight";
            this.lblVideoHeight.Size = new System.Drawing.Size(47, 12);
            this.lblVideoHeight.TabIndex = 4;
            this.lblVideoHeight.Text = "Height:";
            // 
            // lblVideoCodec
            // 
            this.lblVideoCodec.AutoSize = true;
            this.lblVideoCodec.Location = new System.Drawing.Point(162, 79);
            this.lblVideoCodec.Name = "lblVideoCodec";
            this.lblVideoCodec.Size = new System.Drawing.Size(41, 12);
            this.lblVideoCodec.TabIndex = 4;
            this.lblVideoCodec.Text = "Codec:";
            // 
            // btnProcess
            // 
            this.btnProcess.Enabled = false;
            this.btnProcess.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnProcess.Location = new System.Drawing.Point(593, 630);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(75, 21);
            this.btnProcess.TabIndex = 3;
            this.btnProcess.Text = "GO!";
            this.btnProcess.UseVisualStyleBackColor = true;
            // 
            // btnTargetBrowse
            // 
            this.btnTargetBrowse.Location = new System.Drawing.Point(512, 630);
            this.btnTargetBrowse.Name = "btnTargetBrowse";
            this.btnTargetBrowse.Size = new System.Drawing.Size(75, 21);
            this.btnTargetBrowse.TabIndex = 3;
            this.btnTargetBrowse.Text = "Browse";
            this.btnTargetBrowse.UseVisualStyleBackColor = true;
            this.btnTargetBrowse.Click += new System.EventHandler(this.btnTargetBrowse_Click);
            // 
            // grpSource
            // 
            this.grpSource.Controls.Add(this.cmbSourceResolution);
            this.grpSource.Controls.Add(this.cmbSourceType);
            this.grpSource.Controls.Add(this.lblSourceType);
            this.grpSource.Controls.Add(this.lblSourceName);
            this.grpSource.Controls.Add(this.btnSourceGuess);
            this.grpSource.Controls.Add(this.txtSourceName);
            this.grpSource.Controls.Add(this.lblSourceResolution);
            this.grpSource.Location = new System.Drawing.Point(12, 244);
            this.grpSource.Name = "grpSource";
            this.grpSource.Size = new System.Drawing.Size(662, 67);
            this.grpSource.TabIndex = 16;
            this.grpSource.TabStop = false;
            this.grpSource.Text = "Source";
            // 
            // cmbSourceResolution
            // 
            this.cmbSourceResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSourceResolution.FormattingEnabled = true;
            this.cmbSourceResolution.Location = new System.Drawing.Point(421, 37);
            this.cmbSourceResolution.Name = "cmbSourceResolution";
            this.cmbSourceResolution.Size = new System.Drawing.Size(126, 20);
            this.cmbSourceResolution.TabIndex = 8;
            // 
            // cmbSourceType
            // 
            this.cmbSourceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSourceType.FormattingEnabled = true;
            this.cmbSourceType.Location = new System.Drawing.Point(83, 37);
            this.cmbSourceType.Name = "cmbSourceType";
            this.cmbSourceType.Size = new System.Drawing.Size(126, 20);
            this.cmbSourceType.TabIndex = 8;
            // 
            // lblSourceType
            // 
            this.lblSourceType.AutoSize = true;
            this.lblSourceType.Location = new System.Drawing.Point(6, 40);
            this.lblSourceType.Name = "lblSourceType";
            this.lblSourceType.Size = new System.Drawing.Size(35, 12);
            this.lblSourceType.TabIndex = 8;
            this.lblSourceType.Text = "Type:";
            // 
            // lblSourceName
            // 
            this.lblSourceName.AutoSize = true;
            this.lblSourceName.Location = new System.Drawing.Point(6, 17);
            this.lblSourceName.Name = "lblSourceName";
            this.lblSourceName.Size = new System.Drawing.Size(35, 12);
            this.lblSourceName.TabIndex = 7;
            this.lblSourceName.Text = "Name:";
            // 
            // btnSourceGuess
            // 
            this.btnSourceGuess.Location = new System.Drawing.Point(581, 12);
            this.btnSourceGuess.Name = "btnSourceGuess";
            this.btnSourceGuess.Size = new System.Drawing.Size(75, 21);
            this.btnSourceGuess.TabIndex = 3;
            this.btnSourceGuess.Text = "Guess";
            this.btnSourceGuess.UseVisualStyleBackColor = true;
            // 
            // txtSourceName
            // 
            this.txtSourceName.Location = new System.Drawing.Point(83, 12);
            this.txtSourceName.Name = "txtSourceName";
            this.txtSourceName.Size = new System.Drawing.Size(492, 21);
            this.txtSourceName.TabIndex = 6;
            // 
            // lblSourceResolution
            // 
            this.lblSourceResolution.AutoSize = true;
            this.lblSourceResolution.Location = new System.Drawing.Point(344, 40);
            this.lblSourceResolution.Name = "lblSourceResolution";
            this.lblSourceResolution.Size = new System.Drawing.Size(71, 12);
            this.lblSourceResolution.TabIndex = 4;
            this.lblSourceResolution.Text = "Resolution:";
            // 
            // mnsMain
            // 
            this.mnsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsFile,
            this.mnsTools,
            this.mnsHelp});
            this.mnsMain.Location = new System.Drawing.Point(0, 0);
            this.mnsMain.Name = "mnsMain";
            this.mnsMain.Size = new System.Drawing.Size(686, 25);
            this.mnsMain.TabIndex = 17;
            this.mnsMain.Text = "menuStrip1";
            // 
            // mnsFile
            // 
            this.mnsFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsFileOpen,
            this.mnsFileClear,
            this.mnsFileMediaInfo,
            this.mnsFileSeparator1,
            this.mnsFileExit});
            this.mnsFile.Name = "mnsFile";
            this.mnsFile.Size = new System.Drawing.Size(39, 21);
            this.mnsFile.Text = "File";
            // 
            // mnsFileOpen
            // 
            this.mnsFileOpen.Name = "mnsFileOpen";
            this.mnsFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnsFileOpen.Size = new System.Drawing.Size(155, 22);
            this.mnsFileOpen.Text = "Open";
            this.mnsFileOpen.Click += new System.EventHandler(this.mnsFileOpen_Click);
            // 
            // mnsFileClear
            // 
            this.mnsFileClear.Name = "mnsFileClear";
            this.mnsFileClear.Size = new System.Drawing.Size(155, 22);
            this.mnsFileClear.Text = "Clear";
            this.mnsFileClear.Click += new System.EventHandler(this.mnsFileClear_Click);
            // 
            // mnsFileMediaInfo
            // 
            this.mnsFileMediaInfo.Name = "mnsFileMediaInfo";
            this.mnsFileMediaInfo.Size = new System.Drawing.Size(155, 22);
            this.mnsFileMediaInfo.Text = "MediaInfo";
            // 
            // mnsFileSeparator1
            // 
            this.mnsFileSeparator1.Name = "mnsFileSeparator1";
            this.mnsFileSeparator1.Size = new System.Drawing.Size(152, 6);
            // 
            // mnsFileExit
            // 
            this.mnsFileExit.Name = "mnsFileExit";
            this.mnsFileExit.Size = new System.Drawing.Size(155, 22);
            this.mnsFileExit.Text = "Exit";
            this.mnsFileExit.Click += new System.EventHandler(this.mnsFileExit_Click);
            // 
            // mnsTools
            // 
            this.mnsTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsToolsZonesCommand});
            this.mnsTools.Name = "mnsTools";
            this.mnsTools.Size = new System.Drawing.Size(52, 21);
            this.mnsTools.Text = "Tools";
            // 
            // mnsToolsZonesCommand
            // 
            this.mnsToolsZonesCommand.Name = "mnsToolsZonesCommand";
            this.mnsToolsZonesCommand.Size = new System.Drawing.Size(175, 22);
            this.mnsToolsZonesCommand.Text = "Zones Command";
            // 
            // mnsHelp
            // 
            this.mnsHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsHelpAboutUs});
            this.mnsHelp.Name = "mnsHelp";
            this.mnsHelp.Size = new System.Drawing.Size(47, 21);
            this.mnsHelp.Text = "Help";
            // 
            // mnsHelpAboutUs
            // 
            this.mnsHelpAboutUs.Name = "mnsHelpAboutUs";
            this.mnsHelpAboutUs.Size = new System.Drawing.Size(130, 22);
            this.mnsHelpAboutUs.Text = "About Us";
            this.mnsHelpAboutUs.Click += new System.EventHandler(this.mnsHelpAboutUs_Click);
            // 
            // txtVideoFramerate
            // 
            this.txtVideoFramerate.Location = new System.Drawing.Point(227, 19);
            this.txtVideoFramerate.Name = "txtVideoFramerate";
            this.txtVideoFramerate.ReadOnly = true;
            this.txtVideoFramerate.Size = new System.Drawing.Size(88, 21);
            this.txtVideoFramerate.TabIndex = 5;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 660);
            this.Controls.Add(this.grpSource);
            this.Controls.Add(this.btnTargetBrowse);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.grpVideo);
            this.Controls.Add(this.lblTargetLocation);
            this.Controls.Add(this.grpSubtitle);
            this.Controls.Add(this.txtTargetLocation);
            this.Controls.Add(this.grpAudio);
            this.Controls.Add(this.grpGeneral);
            this.Controls.Add(this.grpInput);
            this.Controls.Add(this.mnsMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnsMain;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "TAiCHi NFO Generator";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.grpGeneral.ResumeLayout(false);
            this.grpGeneral.PerformLayout();
            this.grpAudio.ResumeLayout(false);
            this.grpAudio.PerformLayout();
            this.grpSubtitle.ResumeLayout(false);
            this.grpSubtitle.PerformLayout();
            this.grpVideo.ResumeLayout(false);
            this.grpVideo.PerformLayout();
            this.grpSource.ResumeLayout(false);
            this.grpSource.PerformLayout();
            this.mnsMain.ResumeLayout(false);
            this.mnsMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInputFile;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.Label lblInputFile;
        private System.Windows.Forms.GroupBox grpGeneral;
        private System.Windows.Forms.Label lblGeneralReleaseName;
        private System.Windows.Forms.TextBox txtGeneralReleaseName;
        private System.Windows.Forms.Label lblGeneralAudio;
        private System.Windows.Forms.Label lblGeneralResolution;
        private System.Windows.Forms.Label lblGeneralYear;
        private System.Windows.Forms.Label lblGeneralEdition;
        private System.Windows.Forms.TextBox txtGeneralTitle;
        private System.Windows.Forms.Label lblGeneralTitle;
        private System.Windows.Forms.GroupBox grpAudio;
        private System.Windows.Forms.Button btnAudioAdd;
        private System.Windows.Forms.ListBox lstAudio;
        private System.Windows.Forms.TextBox txtAudioComment;
        private System.Windows.Forms.TextBox txtAudioBitrate;
        private System.Windows.Forms.Label lblAudioComment;
        private System.Windows.Forms.TextBox txtAudioChannels;
        private System.Windows.Forms.Label lblAudioBitrate;
        private System.Windows.Forms.TextBox txtAudioCodec;
        private System.Windows.Forms.Label lblAudioChannels;
        private System.Windows.Forms.Label lblAudioCodec;
        private System.Windows.Forms.TextBox txtAudioLanguage;
        private System.Windows.Forms.Label lblAudioLanguage;
        private System.Windows.Forms.GroupBox grpSubtitle;
        private System.Windows.Forms.Button btnSubtitleAdd;
        private System.Windows.Forms.ListBox lstSubtitle;
        private System.Windows.Forms.TextBox txtSubtitleComment;
        private System.Windows.Forms.TextBox txtSubtitleFormat;
        private System.Windows.Forms.Label lblSubtitleComment;
        private System.Windows.Forms.Label lblSubtitleFormat;
        private System.Windows.Forms.TextBox txtSubtitleLanguage;
        private System.Windows.Forms.Label lblSubtitleLanguage;
        private System.Windows.Forms.TextBox txtTargetLocation;
        private System.Windows.Forms.Label lblTargetLocation;
        private System.Windows.Forms.TextBox txtGeneralDuration;
        private System.Windows.Forms.TextBox txtGeneralSize;
        private System.Windows.Forms.TextBox txtVideoBitrate;
        private System.Windows.Forms.Label lblVideoFramerate;
        private System.Windows.Forms.Label lblVideoBitrate;
        private System.Windows.Forms.Label lblGeneralDuration;
        private System.Windows.Forms.Label lblGeneralSize;
        private System.Windows.Forms.Label lblVideoNote;
        private System.Windows.Forms.TextBox txtVideoNote;
        private System.Windows.Forms.Label lblGeneralChapters;
        private System.Windows.Forms.CheckBox chkGeneralChaptersIncluded;
        private System.Windows.Forms.CheckBox chkGeneralChaptersNamed;
        private System.Windows.Forms.Label lblVideoWidth;
        private System.Windows.Forms.TextBox txtVideoWidth;
        private System.Windows.Forms.GroupBox grpVideo;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnTargetBrowse;
        private System.Windows.Forms.ComboBox cmbGeneralResolution;
        private System.Windows.Forms.GroupBox grpSource;
        private System.Windows.Forms.Label lblSourceName;
        private System.Windows.Forms.TextBox txtSourceName;
        private System.Windows.Forms.Button btnSourceGuess;
        private System.Windows.Forms.ComboBox cmbSourceType;
        private System.Windows.Forms.Label lblSourceType;
        private System.Windows.Forms.ComboBox cmbSourceResolution;
        private System.Windows.Forms.Label lblSourceResolution;
        private System.Windows.Forms.Button btnGeneralGenerate;
        private System.Windows.Forms.TextBox txtVideoDAR;
        private System.Windows.Forms.Label lblVideoDAR;
        private System.Windows.Forms.TextBox txtVideoHeight;
        private System.Windows.Forms.Label lblVideoHeight;
        private System.Windows.Forms.Label lblVideoCodec;
        private System.Windows.Forms.ComboBox cmbVideoCodec;
        private System.Windows.Forms.ComboBox cmbGeneralEdition;
        private System.Windows.Forms.ComboBox cmbGeneralYear;
        private System.Windows.Forms.ComboBox cmbGeneralProper;
        private System.Windows.Forms.ComboBox cmbGeneralHybrid;
        private System.Windows.Forms.Label lblGeneralHybrid;
        private System.Windows.Forms.Label lblGeneralProper;
        private System.Windows.Forms.MenuStrip mnsMain;
        private System.Windows.Forms.ToolStripMenuItem mnsFile;
        private System.Windows.Forms.ToolStripMenuItem mnsFileExit;
        private System.Windows.Forms.ToolStripMenuItem mnsTools;
        private System.Windows.Forms.ToolStripMenuItem mnsToolsZonesCommand;
        private System.Windows.Forms.ToolStripMenuItem mnsHelp;
        private System.Windows.Forms.ToolStripMenuItem mnsHelpAboutUs;
        private System.Windows.Forms.ComboBox cmbGeneralAudio;
        private System.Windows.Forms.ToolStripMenuItem mnsFileOpen;
        private System.Windows.Forms.ToolStripMenuItem mnsFileClear;
        private System.Windows.Forms.ToolStripMenuItem mnsFileMediaInfo;
        private System.Windows.Forms.ToolStripSeparator mnsFileSeparator1;
        private System.Windows.Forms.TextBox txtVideoFramerate;
    }
}

