﻿using Unleash;

namespace Unleash.Environment3
{
    partial class RushInterface
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RushInterface));
            this.StatusStrip_Main = new System.Windows.Forms.StatusStrip();
            this.Label_Status = new System.Windows.Forms.Label();
            this.Panel_MainControls = new System.Windows.Forms.Panel();
            this.SplitContainer_MainControls = new System.Windows.Forms.SplitContainer();
            this.SectionButton_InstallMods = new Unleash.Environment3.SectionButton();
            this.SectionButton_LaunchGame = new Unleash.Environment3.SectionButton();
            this.TabControl_Rush = new Unleash.Environment3.UnifyTabControl();
            this.Tab_Section_Mods = new System.Windows.Forms.TabPage();
            this.SplitContainer_ModsControls = new System.Windows.Forms.SplitContainer();
            this.SectionButton_SaveChecks = new Unleash.Environment3.SectionButton();
            this.SectionButton_RefreshMods = new Unleash.Environment3.SectionButton();
            this.Button_Priority = new System.Windows.Forms.Button();
            this.Button_DownerPriority = new System.Windows.Forms.Button();
            this.Button_UpperPriority = new System.Windows.Forms.Button();
            this.Button_Mods_DeselectAll = new System.Windows.Forms.Button();
            this.Button_Mods_SelectAll = new System.Windows.Forms.Button();
            this.Panel_ModBackdrop = new System.Windows.Forms.Panel();
            this.ListView_ModsList = new System.Windows.Forms.ListView();
            this.Column_ModsList_Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Column_ModsList_Version = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Column_ModsList_Author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Column_ModsList_System = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Column_ModsList_Merge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Column_ModsList_Blank = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tab_Section_Emulator = new System.Windows.Forms.TabPage();
            this.Panel_Xenia_Options = new System.Windows.Forms.Panel();
            this.Label_Subtitle_Emulator_Options = new System.Windows.Forms.Label();
            this.ComboBox_API = new System.Windows.Forms.ComboBox();
            this.Label_API = new System.Windows.Forms.Label();
            this.Label_Description_API = new System.Windows.Forms.Label();
            this.Panel_Xenia_API_Options = new System.Windows.Forms.Panel();
            this.Label_UserLanguage = new System.Windows.Forms.Label();
            this.ComboBox_UserLanguage = new System.Windows.Forms.ComboBox();
            this.Label_Description_DiscordRPC = new System.Windows.Forms.Label();
            this.Label_Description_Fullscreen = new System.Windows.Forms.Label();
            this.lol = new System.Windows.Forms.SplitContainer();
            this.Label_Width = new System.Windows.Forms.Label();
            this.ComboBox_Width = new System.Windows.Forms.ComboBox();
            this.Label_Description_Width = new System.Windows.Forms.Label();
            this.ComboBox_Height = new System.Windows.Forms.ComboBox();
            this.Label_Description_Height = new System.Windows.Forms.Label();
            this.Label_Height = new System.Windows.Forms.Label();
            this.Label_Description_UserLanguage = new System.Windows.Forms.Label();
            this.Label_Description_Gamma = new System.Windows.Forms.Label();
            this.CheckBox_Xenia_VerticalSync = new System.Windows.Forms.CheckBox();
            this.Label_Description_VerticalSync = new System.Windows.Forms.Label();
            this.CheckBox_Xenia_DiscordRPC = new System.Windows.Forms.CheckBox();
            this.CheckBox_Xenia_Gamma = new System.Windows.Forms.CheckBox();
            this.CheckBox_Xenia_Fullscreen = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBox_Arguments = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Button_Open_SaveData = new System.Windows.Forms.Button();
            this.Button_Open_EmulatorExecutable = new System.Windows.Forms.Button();
            this.TextBox_SaveData = new System.Windows.Forms.TextBox();
            this.Label_Description_EmulatorExecutable = new System.Windows.Forms.Label();
            this.Button_SaveData = new System.Windows.Forms.Button();
            this.Label_Description_SaveData = new System.Windows.Forms.Label();
            this.Label_Subtitle_Emulator_Paths = new System.Windows.Forms.Label();
            this.Button_EmulatorExecutable = new System.Windows.Forms.Button();
            this.TextBox_EmulatorExecutable = new System.Windows.Forms.TextBox();
            this.Label_EmulatorExecutable = new System.Windows.Forms.Label();
            this.Label_SaveData = new System.Windows.Forms.Label();
            this.Label_Optional_SaveData = new System.Windows.Forms.Label();
            this.Tab_Section_Debug = new System.Windows.Forms.TabPage();
            this.Panel_DebugControls = new System.Windows.Forms.Panel();
            this.SectionButton_ClearLog = new Unleash.Environment3.SectionButton();
            this.ListBox_Debug = new System.Windows.Forms.ListBox();
            this.Tab_Section_Updates = new System.Windows.Forms.TabPage();
            this.SplitContainer_ModUpdate = new System.Windows.Forms.SplitContainer();
            this.Panel_ModUpdateBackdrop = new System.Windows.Forms.Panel();
            this.ListView_ModUpdates = new System.Windows.Forms.ListView();
            this.Column_Updates_Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Column_Updates_Blank = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SectionButton_UpdateMods = new Unleash.Environment3.SectionButton();
            this.ProgressBar_ModUpdate = new System.Windows.Forms.ProgressBar();
            this.Panel_ModInfoBackdrop = new System.Windows.Forms.Panel();
            this.ListBox_UpdateLogs = new System.Windows.Forms.ListBox();
            this.Label_LastModUpdate = new System.Windows.Forms.Label();
            this.SectionButton_CheckForModUpdates = new Unleash.Environment3.SectionButton();
            this.Label_Title_ModsAndPatches = new System.Windows.Forms.Label();
            this.Tab_Section_Settings = new System.Windows.Forms.TabPage();
            this.LinkLabel_Snapshot = new System.Windows.Forms.LinkLabel();
            this.Label_Description_UninstallOnLaunch = new System.Windows.Forms.Label();
            this.CheckBox_UninstallOnLaunch = new System.Windows.Forms.CheckBox();
            this.Label_Description_Reset = new System.Windows.Forms.Label();
            this.LinkLabel_Reset = new System.Windows.Forms.LinkLabel();
            this.Label_Description_DebugMode = new System.Windows.Forms.Label();
            this.Label_Description_HighContrastText = new System.Windows.Forms.Label();
            this.Label_Description_SaveFileRedirect = new System.Windows.Forms.Label();
            this.CheckBox_SaveFileRedirection = new System.Windows.Forms.CheckBox();
            this.CheckBox_DebugMode = new System.Windows.Forms.CheckBox();
            this.Label_Description_LaunchEmulator = new System.Windows.Forms.Label();
            this.CheckBox_LaunchEmulator = new System.Windows.Forms.CheckBox();
            this.Label_Subtitle_General_Options = new System.Windows.Forms.Label();
            this.WindowsColourPicker_AccentColour = new Unleash.Environment3.WindowsColourPicker();
            this.TextBox_GameDirectory = new System.Windows.Forms.TextBox();
            this.Label_Title_Appearance = new System.Windows.Forms.Label();
            this.CheckBox_HighContrastText = new System.Windows.Forms.CheckBox();
            this.Label_Title_General = new System.Windows.Forms.Label();
            this.Label_Subtitle_AccentColour = new System.Windows.Forms.Label();
            this.Label_GameExecutable = new System.Windows.Forms.Label();
            this.Label_WindowsColours = new System.Windows.Forms.Label();
            this.Button_GameDirectory = new System.Windows.Forms.Button();
            this.Label_Subtitle_Appearance_Options = new System.Windows.Forms.Label();
            this.CheckBox_AutoColour = new System.Windows.Forms.CheckBox();
            this.Label_Description_GameExecutable = new System.Windows.Forms.Label();
            this.Button_ColourPicker_Preview = new System.Windows.Forms.Button();
            this.Label_Subtitle_Settings_Paths = new System.Windows.Forms.Label();
            this.Button_ModsDirectory = new System.Windows.Forms.Button();
            this.TextBox_ModsDirectory = new System.Windows.Forms.TextBox();
            this.Label_ModsDirectory = new System.Windows.Forms.Label();
            this.Panel_Settings_UICleanSpace = new System.Windows.Forms.Panel();
            this.Button_Open_GameDirectory = new System.Windows.Forms.Button();
            this.Button_Open_ModsDirectory = new System.Windows.Forms.Button();
            this.Button_ColourPicker_Default = new System.Windows.Forms.Button();
            this.Section_Appearance_ColourPicker = new Unleash.Environment3.SectionButton();
            this.Label_Description_1ClickURLHandler = new System.Windows.Forms.Label();
            this.LinkLabel_1ClickURLHandler = new System.Windows.Forms.LinkLabel();
            this.Label_Warning_ModsDirectoryInvalid = new System.Windows.Forms.Label();
            this.Label_Description_ModsDirectory = new System.Windows.Forms.Label();
            this.Label_Description_Snapshot = new System.Windows.Forms.Label();
            this.Tab_Section_About = new System.Windows.Forms.TabPage();
            this.LinkLabel_Knuxfan24 = new System.Windows.Forms.LinkLabel();
            this.LinkLabel_Velcomia = new System.Windows.Forms.LinkLabel();
            this.LinkLabel_CodenameGamma = new System.Windows.Forms.LinkLabel();
            this.LinkLabel_Beatz = new System.Windows.Forms.LinkLabel();
            this.LinkLabel_SuperSonic16 = new System.Windows.Forms.LinkLabel();
            this.LinkLabel_HyperBE32 = new System.Windows.Forms.LinkLabel();
            this.Title_Testers = new System.Windows.Forms.Label();
            this.Label_Contributors = new System.Windows.Forms.Label();
            this.Title_Contributors = new System.Windows.Forms.Label();
            this.LinkLabel_GPF = new System.Windows.Forms.LinkLabel();
            this.LinkLabel_slashiee = new System.Windows.Forms.LinkLabel();
            this.Label_Testers = new System.Windows.Forms.Label();
            this.Label_Version = new System.Windows.Forms.Label();
            this.Rush_Section_Debug = new Unleash.Environment3.SectionButton();
            this.Rush_Section_Updates = new Unleash.Environment3.SectionButton();
            this.Rush_Section_Settings = new Unleash.Environment3.SectionButton();
            this.Rush_Section_About = new Unleash.Environment3.SectionButton();
            this.Rush_Section_Emulator = new Unleash.Environment3.SectionButton();
            this.Rush_Section_Mods = new Unleash.Environment3.SectionButton();
            this.Container_Rush = new Unleash.Environment3.UserContainer();
            this.Panel_MainControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer_MainControls)).BeginInit();
            this.SplitContainer_MainControls.Panel1.SuspendLayout();
            this.SplitContainer_MainControls.Panel2.SuspendLayout();
            this.SplitContainer_MainControls.SuspendLayout();
            this.TabControl_Rush.SuspendLayout();
            this.Tab_Section_Mods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer_ModsControls)).BeginInit();
            this.SplitContainer_ModsControls.Panel1.SuspendLayout();
            this.SplitContainer_ModsControls.Panel2.SuspendLayout();
            this.SplitContainer_ModsControls.SuspendLayout();
            this.Panel_ModBackdrop.SuspendLayout();
            this.Tab_Section_Emulator.SuspendLayout();
            this.Panel_Xenia_Options.SuspendLayout();
            this.Panel_Xenia_API_Options.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lol)).BeginInit();
            this.lol.Panel1.SuspendLayout();
            this.lol.Panel2.SuspendLayout();
            this.lol.SuspendLayout();
            this.Tab_Section_Debug.SuspendLayout();
            this.Panel_DebugControls.SuspendLayout();
            this.Tab_Section_Updates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer_ModUpdate)).BeginInit();
            this.SplitContainer_ModUpdate.Panel1.SuspendLayout();
            this.SplitContainer_ModUpdate.Panel2.SuspendLayout();
            this.SplitContainer_ModUpdate.SuspendLayout();
            this.Panel_ModUpdateBackdrop.SuspendLayout();
            this.Panel_ModInfoBackdrop.SuspendLayout();
            this.Tab_Section_Settings.SuspendLayout();
            this.Tab_Section_About.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusStrip_Main
            // 
            this.StatusStrip_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.StatusStrip_Main.Location = new System.Drawing.Point(0, 1083);
            this.StatusStrip_Main.Name = "StatusStrip_Main";
            this.StatusStrip_Main.Size = new System.Drawing.Size(849, 22);
            this.StatusStrip_Main.TabIndex = 26;
            this.StatusStrip_Main.Text = "statusStrip1";
            // 
            // Label_Status
            // 
            this.Label_Status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Label_Status.AutoSize = true;
            this.Label_Status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label_Status.Location = new System.Drawing.Point(3, 1086);
            this.Label_Status.Name = "Label_Status";
            this.Label_Status.Size = new System.Drawing.Size(42, 15);
            this.Label_Status.TabIndex = 27;
            this.Label_Status.Text = "Ready.";
            // 
            // Panel_MainControls
            // 
            this.Panel_MainControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_MainControls.Controls.Add(this.SplitContainer_MainControls);
            this.Panel_MainControls.Location = new System.Drawing.Point(250, 1040);
            this.Panel_MainControls.Name = "Panel_MainControls";
            this.Panel_MainControls.Size = new System.Drawing.Size(599, 43);
            this.Panel_MainControls.TabIndex = 30;
            // 
            // SplitContainer_MainControls
            // 
            this.SplitContainer_MainControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SplitContainer_MainControls.IsSplitterFixed = true;
            this.SplitContainer_MainControls.Location = new System.Drawing.Point(5, -20);
            this.SplitContainer_MainControls.Name = "SplitContainer_MainControls";
            // 
            // SplitContainer_MainControls.Panel1
            // 
            this.SplitContainer_MainControls.Panel1.Controls.Add(this.SectionButton_InstallMods);
            // 
            // SplitContainer_MainControls.Panel2
            // 
            this.SplitContainer_MainControls.Panel2.Controls.Add(this.SectionButton_LaunchGame);
            this.SplitContainer_MainControls.Size = new System.Drawing.Size(586, 77);
            this.SplitContainer_MainControls.SplitterDistance = 292;
            this.SplitContainer_MainControls.SplitterWidth = 1;
            this.SplitContainer_MainControls.TabIndex = 3;
            // 
            // SectionButton_InstallMods
            // 
            this.SectionButton_InstallMods.AccentColour = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SectionButton_InstallMods.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SectionButton_InstallMods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(45)))));
            this.SectionButton_InstallMods.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SectionButton_InstallMods.Location = new System.Drawing.Point(2, 20);
            this.SectionButton_InstallMods.Name = "SectionButton_InstallMods";
            this.SectionButton_InstallMods.SectionImage = global::Unleash.Properties.Resources.InstallMods;
            this.SectionButton_InstallMods.SectionText = "Save and install content";
            this.SectionButton_InstallMods.SelectedSection = false;
            this.SectionButton_InstallMods.Size = new System.Drawing.Size(293, 35);
            this.SectionButton_InstallMods.TabIndex = 50;
            this.SectionButton_InstallMods.TextColour = System.Drawing.SystemColors.Control;
            this.SectionButton_InstallMods.Click += new System.EventHandler(this.SectionButton_InstallMods_Click);
            // 
            // SectionButton_LaunchGame
            // 
            this.SectionButton_LaunchGame.AccentColour = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SectionButton_LaunchGame.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SectionButton_LaunchGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(45)))));
            this.SectionButton_LaunchGame.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SectionButton_LaunchGame.Location = new System.Drawing.Point(0, 20);
            this.SectionButton_LaunchGame.Name = "SectionButton_LaunchGame";
            this.SectionButton_LaunchGame.SectionImage = global::Unleash.Properties.Resources.Run_16x;
            this.SectionButton_LaunchGame.SectionText = "Launch Sonic Unleashed";
            this.SectionButton_LaunchGame.SelectedSection = false;
            this.SectionButton_LaunchGame.Size = new System.Drawing.Size(1212, 35);
            this.SectionButton_LaunchGame.TabIndex = 51;
            this.SectionButton_LaunchGame.TextColour = System.Drawing.SystemColors.Control;
            this.SectionButton_LaunchGame.Click += new System.EventHandler(this.SectionButton_LaunchGame_Click);
            // 
            // TabControl_Rush
            // 
            this.TabControl_Rush.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.TabControl_Rush.AllowDragging = false;
            this.TabControl_Rush.AllowDrop = true;
            this.TabControl_Rush.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl_Rush.BackTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.TabControl_Rush.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TabControl_Rush.ClosingButtonColor = System.Drawing.Color.WhiteSmoke;
            this.TabControl_Rush.ClosingMessage = null;
            this.TabControl_Rush.Controls.Add(this.Tab_Section_Mods);
            this.TabControl_Rush.Controls.Add(this.Tab_Section_Emulator);
            this.TabControl_Rush.Controls.Add(this.Tab_Section_Debug);
            this.TabControl_Rush.Controls.Add(this.Tab_Section_Updates);
            this.TabControl_Rush.Controls.Add(this.Tab_Section_Settings);
            this.TabControl_Rush.Controls.Add(this.Tab_Section_About);
            this.TabControl_Rush.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.TabControl_Rush.HorizontalLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.TabControl_Rush.ItemSize = new System.Drawing.Size(240, 16);
            this.TabControl_Rush.Location = new System.Drawing.Point(250, 3);
            this.TabControl_Rush.Name = "TabControl_Rush";
            this.TabControl_Rush.NoTabDisplay = true;
            this.TabControl_Rush.SelectedIndex = 0;
            this.TabControl_Rush.SelectedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TabControl_Rush.ShowClosingButton = false;
            this.TabControl_Rush.ShowClosingMessage = false;
            this.TabControl_Rush.Size = new System.Drawing.Size(599, 1037);
            this.TabControl_Rush.TabIndex = 22;
            this.TabControl_Rush.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TabControl_Rush.SelectedIndexChanged += new System.EventHandler(this.TabControl_Rush_SelectedIndexChanged);
            // 
            // Tab_Section_Mods
            // 
            this.Tab_Section_Mods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Tab_Section_Mods.Controls.Add(this.SplitContainer_ModsControls);
            this.Tab_Section_Mods.Controls.Add(this.Button_Priority);
            this.Tab_Section_Mods.Controls.Add(this.Button_DownerPriority);
            this.Tab_Section_Mods.Controls.Add(this.Button_UpperPriority);
            this.Tab_Section_Mods.Controls.Add(this.Button_Mods_DeselectAll);
            this.Tab_Section_Mods.Controls.Add(this.Button_Mods_SelectAll);
            this.Tab_Section_Mods.Controls.Add(this.Panel_ModBackdrop);
            this.Tab_Section_Mods.Location = new System.Drawing.Point(4, 20);
            this.Tab_Section_Mods.Name = "Tab_Section_Mods";
            this.Tab_Section_Mods.Size = new System.Drawing.Size(591, 1013);
            this.Tab_Section_Mods.TabIndex = 0;
            this.Tab_Section_Mods.Text = "Mods";
            this.Tab_Section_Mods.Visible = false;
            // 
            // SplitContainer_ModsControls
            // 
            this.SplitContainer_ModsControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SplitContainer_ModsControls.IsSplitterFixed = true;
            this.SplitContainer_ModsControls.Location = new System.Drawing.Point(1, 978);
            this.SplitContainer_ModsControls.Name = "SplitContainer_ModsControls";
            // 
            // SplitContainer_ModsControls.Panel1
            // 
            this.SplitContainer_ModsControls.Panel1.Controls.Add(this.SectionButton_SaveChecks);
            // 
            // SplitContainer_ModsControls.Panel2
            // 
            this.SplitContainer_ModsControls.Panel2.Controls.Add(this.SectionButton_RefreshMods);
            this.SplitContainer_ModsControls.Size = new System.Drawing.Size(586, 35);
            this.SplitContainer_ModsControls.SplitterDistance = 292;
            this.SplitContainer_ModsControls.SplitterWidth = 1;
            this.SplitContainer_ModsControls.TabIndex = 2;
            // 
            // SectionButton_SaveChecks
            // 
            this.SectionButton_SaveChecks.AccentColour = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SectionButton_SaveChecks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SectionButton_SaveChecks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(45)))));
            this.SectionButton_SaveChecks.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SectionButton_SaveChecks.Location = new System.Drawing.Point(2, 0);
            this.SectionButton_SaveChecks.Name = "SectionButton_SaveChecks";
            this.SectionButton_SaveChecks.SectionImage = global::Unleash.Properties.Resources.CheckBox_16x_24;
            this.SectionButton_SaveChecks.SectionText = "Save checked mods";
            this.SectionButton_SaveChecks.SelectedSection = false;
            this.SectionButton_SaveChecks.Size = new System.Drawing.Size(398, 35);
            this.SectionButton_SaveChecks.TabIndex = 52;
            this.SectionButton_SaveChecks.TextColour = System.Drawing.SystemColors.Control;
            this.SectionButton_SaveChecks.Click += new System.EventHandler(this.SectionButton_SaveChecks_Click);
            // 
            // SectionButton_RefreshMods
            // 
            this.SectionButton_RefreshMods.AccentColour = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SectionButton_RefreshMods.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SectionButton_RefreshMods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(45)))));
            this.SectionButton_RefreshMods.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SectionButton_RefreshMods.Location = new System.Drawing.Point(0, 0);
            this.SectionButton_RefreshMods.Name = "SectionButton_RefreshMods";
            this.SectionButton_RefreshMods.SectionImage = ((System.Drawing.Bitmap)(resources.GetObject("SectionButton_RefreshMods.SectionImage")));
            this.SectionButton_RefreshMods.SectionText = "Refresh mods list";
            this.SectionButton_RefreshMods.SelectedSection = false;
            this.SectionButton_RefreshMods.Size = new System.Drawing.Size(1946, 35);
            this.SectionButton_RefreshMods.TabIndex = 52;
            this.SectionButton_RefreshMods.TextColour = System.Drawing.SystemColors.Control;
            this.SectionButton_RefreshMods.Click += new System.EventHandler(this.SectionButton_Refresh_Click);
            // 
            // Button_Priority
            // 
            this.Button_Priority.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Priority.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Button_Priority.FlatAppearance.BorderSize = 0;
            this.Button_Priority.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Priority.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Button_Priority.Location = new System.Drawing.Point(409, 949);
            this.Button_Priority.Name = "Button_Priority";
            this.Button_Priority.Size = new System.Drawing.Size(178, 23);
            this.Button_Priority.TabIndex = 49;
            this.Button_Priority.Text = "Priority: Top to Bottom";
            this.Button_Priority.UseVisualStyleBackColor = false;
            this.Button_Priority.Click += new System.EventHandler(this.Button_Priority_Click);
            // 
            // Button_DownerPriority
            // 
            this.Button_DownerPriority.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_DownerPriority.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Button_DownerPriority.Enabled = false;
            this.Button_DownerPriority.FlatAppearance.BorderSize = 0;
            this.Button_DownerPriority.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_DownerPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_DownerPriority.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Button_DownerPriority.Location = new System.Drawing.Point(377, 949);
            this.Button_DownerPriority.Name = "Button_DownerPriority";
            this.Button_DownerPriority.Size = new System.Drawing.Size(26, 23);
            this.Button_DownerPriority.TabIndex = 48;
            this.Button_DownerPriority.Text = "▼";
            this.Button_DownerPriority.UseVisualStyleBackColor = false;
            this.Button_DownerPriority.Click += new System.EventHandler(this.Button_Priority_Iteration_Click);
            // 
            // Button_UpperPriority
            // 
            this.Button_UpperPriority.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_UpperPriority.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Button_UpperPriority.Enabled = false;
            this.Button_UpperPriority.FlatAppearance.BorderSize = 0;
            this.Button_UpperPriority.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_UpperPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_UpperPriority.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Button_UpperPriority.Location = new System.Drawing.Point(346, 949);
            this.Button_UpperPriority.Name = "Button_UpperPriority";
            this.Button_UpperPriority.Size = new System.Drawing.Size(26, 23);
            this.Button_UpperPriority.TabIndex = 47;
            this.Button_UpperPriority.Text = "▲";
            this.Button_UpperPriority.UseVisualStyleBackColor = false;
            this.Button_UpperPriority.Click += new System.EventHandler(this.Button_Priority_Iteration_Click);
            // 
            // Button_Mods_DeselectAll
            // 
            this.Button_Mods_DeselectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_Mods_DeselectAll.BackColor = System.Drawing.Color.Tomato;
            this.Button_Mods_DeselectAll.FlatAppearance.BorderSize = 0;
            this.Button_Mods_DeselectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Mods_DeselectAll.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Button_Mods_DeselectAll.Location = new System.Drawing.Point(175, 949);
            this.Button_Mods_DeselectAll.Name = "Button_Mods_DeselectAll";
            this.Button_Mods_DeselectAll.Size = new System.Drawing.Size(165, 23);
            this.Button_Mods_DeselectAll.TabIndex = 46;
            this.Button_Mods_DeselectAll.Text = "Deselect All";
            this.Button_Mods_DeselectAll.UseVisualStyleBackColor = false;
            this.Button_Mods_DeselectAll.Click += new System.EventHandler(this.Button_Mods_Selection_Click);
            // 
            // Button_Mods_SelectAll
            // 
            this.Button_Mods_SelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_Mods_SelectAll.BackColor = System.Drawing.Color.SkyBlue;
            this.Button_Mods_SelectAll.FlatAppearance.BorderSize = 0;
            this.Button_Mods_SelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Mods_SelectAll.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Button_Mods_SelectAll.Location = new System.Drawing.Point(3, 949);
            this.Button_Mods_SelectAll.Name = "Button_Mods_SelectAll";
            this.Button_Mods_SelectAll.Size = new System.Drawing.Size(166, 23);
            this.Button_Mods_SelectAll.TabIndex = 45;
            this.Button_Mods_SelectAll.Text = "Select All";
            this.Button_Mods_SelectAll.UseVisualStyleBackColor = false;
            this.Button_Mods_SelectAll.Click += new System.EventHandler(this.Button_Mods_Selection_Click);
            // 
            // Panel_ModBackdrop
            // 
            this.Panel_ModBackdrop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_ModBackdrop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Panel_ModBackdrop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_ModBackdrop.Controls.Add(this.ListView_ModsList);
            this.Panel_ModBackdrop.Location = new System.Drawing.Point(3, 4);
            this.Panel_ModBackdrop.Name = "Panel_ModBackdrop";
            this.Panel_ModBackdrop.Size = new System.Drawing.Size(584, 939);
            this.Panel_ModBackdrop.TabIndex = 44;
            // 
            // ListView_ModsList
            // 
            this.ListView_ModsList.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.ListView_ModsList.AllowDrop = true;
            this.ListView_ModsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListView_ModsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ListView_ModsList.BackgroundImageTiled = true;
            this.ListView_ModsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListView_ModsList.CheckBoxes = true;
            this.ListView_ModsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Column_ModsList_Title,
            this.Column_ModsList_Version,
            this.Column_ModsList_Author,
            this.Column_ModsList_System,
            this.Column_ModsList_Merge,
            this.Column_ModsList_Blank});
            this.ListView_ModsList.ForeColor = System.Drawing.SystemColors.Control;
            this.ListView_ModsList.FullRowSelect = true;
            this.ListView_ModsList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ListView_ModsList.HideSelection = false;
            this.ListView_ModsList.Location = new System.Drawing.Point(0, 0);
            this.ListView_ModsList.MultiSelect = false;
            this.ListView_ModsList.Name = "ListView_ModsList";
            this.ListView_ModsList.OwnerDraw = true;
            this.ListView_ModsList.Size = new System.Drawing.Size(582, 954);
            this.ListView_ModsList.TabIndex = 1;
            this.ListView_ModsList.UseCompatibleStateImageBehavior = false;
            this.ListView_ModsList.View = System.Windows.Forms.View.Details;
            this.ListView_ModsList.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.ListView_DrawColumnHeader);
            this.ListView_ModsList.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.ListView_DrawItem);
            this.ListView_ModsList.SelectedIndexChanged += new System.EventHandler(this.ListView_ModsList_SelectedIndexChanged);
            this.ListView_ModsList.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListView_DragDrop);
            this.ListView_ModsList.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListView_DragEnter);
            this.ListView_ModsList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListView_MouseClick);
            this.ListView_ModsList.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ListView_MouseUp);
            // 
            // Column_ModsList_Title
            // 
            this.Column_ModsList_Title.Text = "Title";
            this.Column_ModsList_Title.Width = 242;
            // 
            // Column_ModsList_Version
            // 
            this.Column_ModsList_Version.Text = "Version";
            this.Column_ModsList_Version.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Column_ModsList_Version.Width = 71;
            // 
            // Column_ModsList_Author
            // 
            this.Column_ModsList_Author.Text = "Author";
            this.Column_ModsList_Author.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Column_ModsList_Author.Width = 126;
            // 
            // Column_ModsList_System
            // 
            this.Column_ModsList_System.Text = "System";
            this.Column_ModsList_System.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Column_ModsList_System.Width = 87;
            // 
            // Column_ModsList_Merge
            // 
            this.Column_ModsList_Merge.Text = "Merge";
            this.Column_ModsList_Merge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Column_ModsList_Blank
            // 
            this.Column_ModsList_Blank.Text = "";
            this.Column_ModsList_Blank.Width = 1000;
            // 
            // Tab_Section_Emulator
            // 
            this.Tab_Section_Emulator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Tab_Section_Emulator.Controls.Add(this.Panel_Xenia_Options);
            this.Tab_Section_Emulator.Controls.Add(this.label1);
            this.Tab_Section_Emulator.Controls.Add(this.TextBox_Arguments);
            this.Tab_Section_Emulator.Controls.Add(this.label2);
            this.Tab_Section_Emulator.Controls.Add(this.Button_Open_SaveData);
            this.Tab_Section_Emulator.Controls.Add(this.Button_Open_EmulatorExecutable);
            this.Tab_Section_Emulator.Controls.Add(this.TextBox_SaveData);
            this.Tab_Section_Emulator.Controls.Add(this.Label_Description_EmulatorExecutable);
            this.Tab_Section_Emulator.Controls.Add(this.Button_SaveData);
            this.Tab_Section_Emulator.Controls.Add(this.Label_Description_SaveData);
            this.Tab_Section_Emulator.Controls.Add(this.Label_Subtitle_Emulator_Paths);
            this.Tab_Section_Emulator.Controls.Add(this.Button_EmulatorExecutable);
            this.Tab_Section_Emulator.Controls.Add(this.TextBox_EmulatorExecutable);
            this.Tab_Section_Emulator.Controls.Add(this.Label_EmulatorExecutable);
            this.Tab_Section_Emulator.Controls.Add(this.Label_SaveData);
            this.Tab_Section_Emulator.Controls.Add(this.Label_Optional_SaveData);
            this.Tab_Section_Emulator.Location = new System.Drawing.Point(4, 20);
            this.Tab_Section_Emulator.Name = "Tab_Section_Emulator";
            this.Tab_Section_Emulator.Size = new System.Drawing.Size(591, 1013);
            this.Tab_Section_Emulator.TabIndex = 1;
            this.Tab_Section_Emulator.Text = "Emulator";
            this.Tab_Section_Emulator.Visible = false;
            // 
            // Panel_Xenia_Options
            // 
            this.Panel_Xenia_Options.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_Xenia_Options.Controls.Add(this.Label_Subtitle_Emulator_Options);
            this.Panel_Xenia_Options.Controls.Add(this.ComboBox_API);
            this.Panel_Xenia_Options.Controls.Add(this.Label_API);
            this.Panel_Xenia_Options.Controls.Add(this.Label_Description_API);
            this.Panel_Xenia_Options.Controls.Add(this.Panel_Xenia_API_Options);
            this.Panel_Xenia_Options.Location = new System.Drawing.Point(3, 204);
            this.Panel_Xenia_Options.Name = "Panel_Xenia_Options";
            this.Panel_Xenia_Options.Size = new System.Drawing.Size(585, 317);
            this.Panel_Xenia_Options.TabIndex = 165;
            // 
            // Label_Subtitle_Emulator_Options
            // 
            this.Label_Subtitle_Emulator_Options.AutoSize = true;
            this.Label_Subtitle_Emulator_Options.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.Label_Subtitle_Emulator_Options.Location = new System.Drawing.Point(6, 9);
            this.Label_Subtitle_Emulator_Options.Name = "Label_Subtitle_Emulator_Options";
            this.Label_Subtitle_Emulator_Options.Size = new System.Drawing.Size(76, 25);
            this.Label_Subtitle_Emulator_Options.TabIndex = 57;
            this.Label_Subtitle_Emulator_Options.Text = "Options";
            // 
            // ComboBox_API
            // 
            this.ComboBox_API.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBox_API.BackColor = System.Drawing.SystemColors.Window;
            this.ComboBox_API.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_API.FormattingEnabled = true;
            this.ComboBox_API.Items.AddRange(new object[] {
            "DirectX 12",
            "Vulkan",
            "Custom"});
            this.ComboBox_API.Location = new System.Drawing.Point(11, 68);
            this.ComboBox_API.Name = "ComboBox_API";
            this.ComboBox_API.Size = new System.Drawing.Size(560, 23);
            this.ComboBox_API.TabIndex = 59;
            this.ComboBox_API.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Emulator_SelectedIndexChanged);
            // 
            // Label_API
            // 
            this.Label_API.AutoSize = true;
            this.Label_API.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Label_API.Location = new System.Drawing.Point(8, 46);
            this.Label_API.Name = "Label_API";
            this.Label_API.Size = new System.Drawing.Size(26, 17);
            this.Label_API.TabIndex = 60;
            this.Label_API.Text = "API";
            // 
            // Label_Description_API
            // 
            this.Label_Description_API.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Description_API.AutoSize = true;
            this.Label_Description_API.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Description_API.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Label_Description_API.Location = new System.Drawing.Point(336, 48);
            this.Label_Description_API.Name = "Label_Description_API";
            this.Label_Description_API.Size = new System.Drawing.Size(235, 15);
            this.Label_Description_API.TabIndex = 144;
            this.Label_Description_API.Text = "The API the emulator will use as a backend.";
            // 
            // Panel_Xenia_API_Options
            // 
            this.Panel_Xenia_API_Options.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_Xenia_API_Options.Controls.Add(this.Label_UserLanguage);
            this.Panel_Xenia_API_Options.Controls.Add(this.ComboBox_UserLanguage);
            this.Panel_Xenia_API_Options.Controls.Add(this.Label_Description_DiscordRPC);
            this.Panel_Xenia_API_Options.Controls.Add(this.Label_Description_Fullscreen);
            this.Panel_Xenia_API_Options.Controls.Add(this.lol);
            this.Panel_Xenia_API_Options.Controls.Add(this.Label_Description_UserLanguage);
            this.Panel_Xenia_API_Options.Controls.Add(this.Label_Description_Gamma);
            this.Panel_Xenia_API_Options.Controls.Add(this.CheckBox_Xenia_VerticalSync);
            this.Panel_Xenia_API_Options.Controls.Add(this.Label_Description_VerticalSync);
            this.Panel_Xenia_API_Options.Controls.Add(this.CheckBox_Xenia_DiscordRPC);
            this.Panel_Xenia_API_Options.Controls.Add(this.CheckBox_Xenia_Gamma);
            this.Panel_Xenia_API_Options.Controls.Add(this.CheckBox_Xenia_Fullscreen);
            this.Panel_Xenia_API_Options.Location = new System.Drawing.Point(3, 95);
            this.Panel_Xenia_API_Options.Name = "Panel_Xenia_API_Options";
            this.Panel_Xenia_API_Options.Size = new System.Drawing.Size(579, 222);
            this.Panel_Xenia_API_Options.TabIndex = 165;
            // 
            // Label_UserLanguage
            // 
            this.Label_UserLanguage.AutoSize = true;
            this.Label_UserLanguage.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Label_UserLanguage.Location = new System.Drawing.Point(5, 2);
            this.Label_UserLanguage.Name = "Label_UserLanguage";
            this.Label_UserLanguage.Size = new System.Drawing.Size(65, 17);
            this.Label_UserLanguage.TabIndex = 152;
            this.Label_UserLanguage.Text = "Language";
            // 
            // ComboBox_UserLanguage
            // 
            this.ComboBox_UserLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBox_UserLanguage.BackColor = System.Drawing.SystemColors.Window;
            this.ComboBox_UserLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_UserLanguage.FormattingEnabled = true;
            this.ComboBox_UserLanguage.Items.AddRange(new object[] {
            "English",
            "Japanese",
            "German",
            "French",
            "Spanish",
            "Italian",
            "Korean",
            "Chinese (Simplified)",
            "Portuguese",
            "Polish",
            "Russian",
            "Swedish",
            "Turkish",
            "Norwegian",
            "Dutch",
            "Chinese (Traditional)"});
            this.ComboBox_UserLanguage.Location = new System.Drawing.Point(8, 24);
            this.ComboBox_UserLanguage.Name = "ComboBox_UserLanguage";
            this.ComboBox_UserLanguage.Size = new System.Drawing.Size(560, 23);
            this.ComboBox_UserLanguage.TabIndex = 151;
            this.ComboBox_UserLanguage.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Emulator_SelectedIndexChanged);
            // 
            // Label_Description_DiscordRPC
            // 
            this.Label_Description_DiscordRPC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Description_DiscordRPC.AutoSize = true;
            this.Label_Description_DiscordRPC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Description_DiscordRPC.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Label_Description_DiscordRPC.Location = new System.Drawing.Point(362, 189);
            this.Label_Description_DiscordRPC.Name = "Label_Description_DiscordRPC";
            this.Label_Description_DiscordRPC.Size = new System.Drawing.Size(206, 15);
            this.Label_Description_DiscordRPC.TabIndex = 150;
            this.Label_Description_DiscordRPC.Text = "Displays the current game on Discord.";
            // 
            // Label_Description_Fullscreen
            // 
            this.Label_Description_Fullscreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Description_Fullscreen.AutoSize = true;
            this.Label_Description_Fullscreen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Description_Fullscreen.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Label_Description_Fullscreen.Location = new System.Drawing.Point(372, 164);
            this.Label_Description_Fullscreen.Name = "Label_Description_Fullscreen";
            this.Label_Description_Fullscreen.Size = new System.Drawing.Size(196, 15);
            this.Label_Description_Fullscreen.TabIndex = 149;
            this.Label_Description_Fullscreen.Text = "Launches the emulator in fullscreen.";
            // 
            // lol
            // 
            this.lol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lol.Location = new System.Drawing.Point(0, 54);
            this.lol.Name = "lol";
            // 
            // lol.Panel1
            // 
            this.lol.Panel1.Controls.Add(this.Label_Width);
            this.lol.Panel1.Controls.Add(this.ComboBox_Width);
            this.lol.Panel1.Controls.Add(this.Label_Description_Width);
            // 
            // lol.Panel2
            // 
            this.lol.Panel2.Controls.Add(this.ComboBox_Height);
            this.lol.Panel2.Controls.Add(this.Label_Description_Height);
            this.lol.Panel2.Controls.Add(this.Label_Height);
            this.lol.Size = new System.Drawing.Size(579, 54);
            this.lol.SplitterDistance = 289;
            this.lol.TabIndex = 165;
            // 
            // Label_Width
            // 
            this.Label_Width.AutoSize = true;
            this.Label_Width.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Label_Width.Location = new System.Drawing.Point(5, 0);
            this.Label_Width.Name = "Label_Width";
            this.Label_Width.Size = new System.Drawing.Size(42, 17);
            this.Label_Width.TabIndex = 159;
            this.Label_Width.Text = "Width";
            // 
            // ComboBox_Width
            // 
            this.ComboBox_Width.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBox_Width.BackColor = System.Drawing.SystemColors.Window;
            this.ComboBox_Width.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Width.FormattingEnabled = true;
            this.ComboBox_Width.Items.AddRange(new object[] {
            "1280",
            "2560",
            "3840"});
            this.ComboBox_Width.Location = new System.Drawing.Point(8, 22);
            this.ComboBox_Width.Name = "ComboBox_Width";
            this.ComboBox_Width.Size = new System.Drawing.Size(275, 23);
            this.ComboBox_Width.TabIndex = 158;
            this.ComboBox_Width.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Emulator_SelectedIndexChanged);
            // 
            // Label_Description_Width
            // 
            this.Label_Description_Width.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Description_Width.AutoSize = true;
            this.Label_Description_Width.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Description_Width.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Label_Description_Width.Location = new System.Drawing.Point(157, 2);
            this.Label_Description_Width.Name = "Label_Description_Width";
            this.Label_Description_Width.Size = new System.Drawing.Size(126, 15);
            this.Label_Description_Width.TabIndex = 160;
            this.Label_Description_Width.Text = "The width to render at.";
            // 
            // ComboBox_Height
            // 
            this.ComboBox_Height.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBox_Height.BackColor = System.Drawing.SystemColors.Window;
            this.ComboBox_Height.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Height.FormattingEnabled = true;
            this.ComboBox_Height.Items.AddRange(new object[] {
            "720",
            "1440",
            "2160"});
            this.ComboBox_Height.Location = new System.Drawing.Point(0, 22);
            this.ComboBox_Height.Name = "ComboBox_Height";
            this.ComboBox_Height.Size = new System.Drawing.Size(275, 23);
            this.ComboBox_Height.TabIndex = 161;
            this.ComboBox_Height.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Emulator_SelectedIndexChanged);
            // 
            // Label_Description_Height
            // 
            this.Label_Description_Height.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Description_Height.AutoSize = true;
            this.Label_Description_Height.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Description_Height.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Label_Description_Height.Location = new System.Drawing.Point(146, 2);
            this.Label_Description_Height.Name = "Label_Description_Height";
            this.Label_Description_Height.Size = new System.Drawing.Size(130, 15);
            this.Label_Description_Height.TabIndex = 163;
            this.Label_Description_Height.Text = "The height to render at.";
            // 
            // Label_Height
            // 
            this.Label_Height.AutoSize = true;
            this.Label_Height.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Label_Height.Location = new System.Drawing.Point(-3, 0);
            this.Label_Height.Name = "Label_Height";
            this.Label_Height.Size = new System.Drawing.Size(46, 17);
            this.Label_Height.TabIndex = 162;
            this.Label_Height.Text = "Height";
            // 
            // Label_Description_UserLanguage
            // 
            this.Label_Description_UserLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Description_UserLanguage.AutoSize = true;
            this.Label_Description_UserLanguage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Description_UserLanguage.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Label_Description_UserLanguage.Location = new System.Drawing.Point(364, 4);
            this.Label_Description_UserLanguage.Name = "Label_Description_UserLanguage";
            this.Label_Description_UserLanguage.Size = new System.Drawing.Size(204, 15);
            this.Label_Description_UserLanguage.TabIndex = 153;
            this.Label_Description_UserLanguage.Text = "The system language to be emulated.";
            // 
            // Label_Description_Gamma
            // 
            this.Label_Description_Gamma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Description_Gamma.AutoSize = true;
            this.Label_Description_Gamma.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Description_Gamma.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Label_Description_Gamma.Location = new System.Drawing.Point(201, 139);
            this.Label_Description_Gamma.Name = "Label_Description_Gamma";
            this.Label_Description_Gamma.Size = new System.Drawing.Size(368, 15);
            this.Label_Description_Gamma.TabIndex = 148;
            this.Label_Description_Gamma.Text = "Forces gamma on, resulting in more accurate colours (recommended).";
            // 
            // CheckBox_Xenia_VerticalSync
            // 
            this.CheckBox_Xenia_VerticalSync.AutoSize = true;
            this.CheckBox_Xenia_VerticalSync.BackColor = System.Drawing.Color.Transparent;
            this.CheckBox_Xenia_VerticalSync.Location = new System.Drawing.Point(8, 113);
            this.CheckBox_Xenia_VerticalSync.Name = "CheckBox_Xenia_VerticalSync";
            this.CheckBox_Xenia_VerticalSync.Size = new System.Drawing.Size(63, 19);
            this.CheckBox_Xenia_VerticalSync.TabIndex = 63;
            this.CheckBox_Xenia_VerticalSync.Text = "V-Sync";
            this.CheckBox_Xenia_VerticalSync.UseVisualStyleBackColor = false;
            this.CheckBox_Xenia_VerticalSync.CheckedChanged += new System.EventHandler(this.CheckBox_Xenia_CheckedChanged);
            // 
            // Label_Description_VerticalSync
            // 
            this.Label_Description_VerticalSync.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Description_VerticalSync.AutoSize = true;
            this.Label_Description_VerticalSync.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Description_VerticalSync.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Label_Description_VerticalSync.Location = new System.Drawing.Point(219, 114);
            this.Label_Description_VerticalSync.Name = "Label_Description_VerticalSync";
            this.Label_Description_VerticalSync.Size = new System.Drawing.Size(349, 15);
            this.Label_Description_VerticalSync.TabIndex = 147;
            this.Label_Description_VerticalSync.Text = "Locks the framerate respective to the game\'s cap (recommended).";
            // 
            // CheckBox_Xenia_DiscordRPC
            // 
            this.CheckBox_Xenia_DiscordRPC.AutoSize = true;
            this.CheckBox_Xenia_DiscordRPC.BackColor = System.Drawing.Color.Transparent;
            this.CheckBox_Xenia_DiscordRPC.Location = new System.Drawing.Point(8, 188);
            this.CheckBox_Xenia_DiscordRPC.Name = "CheckBox_Xenia_DiscordRPC";
            this.CheckBox_Xenia_DiscordRPC.Size = new System.Drawing.Size(142, 19);
            this.CheckBox_Xenia_DiscordRPC.TabIndex = 66;
            this.CheckBox_Xenia_DiscordRPC.Text = "Discord Rich Presence";
            this.CheckBox_Xenia_DiscordRPC.UseVisualStyleBackColor = false;
            this.CheckBox_Xenia_DiscordRPC.CheckedChanged += new System.EventHandler(this.CheckBox_Xenia_CheckedChanged);
            // 
            // CheckBox_Xenia_Gamma
            // 
            this.CheckBox_Xenia_Gamma.AutoSize = true;
            this.CheckBox_Xenia_Gamma.BackColor = System.Drawing.Color.Transparent;
            this.CheckBox_Xenia_Gamma.Location = new System.Drawing.Point(8, 138);
            this.CheckBox_Xenia_Gamma.Name = "CheckBox_Xenia_Gamma";
            this.CheckBox_Xenia_Gamma.Size = new System.Drawing.Size(127, 19);
            this.CheckBox_Xenia_Gamma.TabIndex = 64;
            this.CheckBox_Xenia_Gamma.Text = "Gamma Correction";
            this.CheckBox_Xenia_Gamma.UseVisualStyleBackColor = false;
            this.CheckBox_Xenia_Gamma.CheckedChanged += new System.EventHandler(this.CheckBox_Xenia_CheckedChanged);
            // 
            // CheckBox_Xenia_Fullscreen
            // 
            this.CheckBox_Xenia_Fullscreen.AutoSize = true;
            this.CheckBox_Xenia_Fullscreen.BackColor = System.Drawing.Color.Transparent;
            this.CheckBox_Xenia_Fullscreen.Location = new System.Drawing.Point(8, 163);
            this.CheckBox_Xenia_Fullscreen.Name = "CheckBox_Xenia_Fullscreen";
            this.CheckBox_Xenia_Fullscreen.Size = new System.Drawing.Size(134, 19);
            this.CheckBox_Xenia_Fullscreen.TabIndex = 65;
            this.CheckBox_Xenia_Fullscreen.Text = "Launch in Fullscreen";
            this.CheckBox_Xenia_Fullscreen.UseVisualStyleBackColor = false;
            this.CheckBox_Xenia_Fullscreen.CheckedChanged += new System.EventHandler(this.CheckBox_Xenia_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(212, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 15);
            this.label1.TabIndex = 157;
            this.label1.Text = "User-specific arguments that are fed into the emulator upon launch.";
            // 
            // TextBox_Arguments
            // 
            this.TextBox_Arguments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_Arguments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.TextBox_Arguments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_Arguments.ForeColor = System.Drawing.SystemColors.Control;
            this.TextBox_Arguments.Location = new System.Drawing.Point(14, 174);
            this.TextBox_Arguments.Name = "TextBox_Arguments";
            this.TextBox_Arguments.Size = new System.Drawing.Size(560, 23);
            this.TextBox_Arguments.TabIndex = 155;
            this.TextBox_Arguments.TextChanged += new System.EventHandler(this.TextBox_Arguments_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label2.Location = new System.Drawing.Point(11, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 154;
            this.label2.Text = "Arguments";
            // 
            // Button_Open_SaveData
            // 
            this.Button_Open_SaveData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Open_SaveData.FlatAppearance.BorderSize = 0;
            this.Button_Open_SaveData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Button_Open_SaveData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Button_Open_SaveData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Open_SaveData.Image = ((System.Drawing.Image)(resources.GetObject("Button_Open_SaveData.Image")));
            this.Button_Open_SaveData.Location = new System.Drawing.Point(554, 122);
            this.Button_Open_SaveData.Name = "Button_Open_SaveData";
            this.Button_Open_SaveData.Size = new System.Drawing.Size(21, 20);
            this.Button_Open_SaveData.TabIndex = 143;
            this.Button_Open_SaveData.UseVisualStyleBackColor = true;
            this.Button_Open_SaveData.Click += new System.EventHandler(this.Button_Open_Click);
            // 
            // Button_Open_EmulatorExecutable
            // 
            this.Button_Open_EmulatorExecutable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Open_EmulatorExecutable.FlatAppearance.BorderSize = 0;
            this.Button_Open_EmulatorExecutable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Button_Open_EmulatorExecutable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Button_Open_EmulatorExecutable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Open_EmulatorExecutable.Image = ((System.Drawing.Image)(resources.GetObject("Button_Open_EmulatorExecutable.Image")));
            this.Button_Open_EmulatorExecutable.Location = new System.Drawing.Point(554, 70);
            this.Button_Open_EmulatorExecutable.Name = "Button_Open_EmulatorExecutable";
            this.Button_Open_EmulatorExecutable.Size = new System.Drawing.Size(21, 20);
            this.Button_Open_EmulatorExecutable.TabIndex = 142;
            this.Button_Open_EmulatorExecutable.UseVisualStyleBackColor = true;
            this.Button_Open_EmulatorExecutable.Click += new System.EventHandler(this.Button_Open_Click);
            // 
            // TextBox_SaveData
            // 
            this.TextBox_SaveData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_SaveData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.TextBox_SaveData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_SaveData.ForeColor = System.Drawing.SystemColors.Control;
            this.TextBox_SaveData.Location = new System.Drawing.Point(14, 122);
            this.TextBox_SaveData.Name = "TextBox_SaveData";
            this.TextBox_SaveData.Size = new System.Drawing.Size(504, 23);
            this.TextBox_SaveData.TabIndex = 54;
            // 
            // Label_Description_EmulatorExecutable
            // 
            this.Label_Description_EmulatorExecutable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Description_EmulatorExecutable.AutoSize = true;
            this.Label_Description_EmulatorExecutable.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Description_EmulatorExecutable.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Label_Description_EmulatorExecutable.Location = new System.Drawing.Point(217, 50);
            this.Label_Description_EmulatorExecutable.Name = "Label_Description_EmulatorExecutable";
            this.Label_Description_EmulatorExecutable.Size = new System.Drawing.Size(301, 15);
            this.Label_Description_EmulatorExecutable.TabIndex = 52;
            this.Label_Description_EmulatorExecutable.Text = "Emulator executable file (EXE) - used for Xenia or RPCS3.";
            // 
            // Button_SaveData
            // 
            this.Button_SaveData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_SaveData.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Button_SaveData.FlatAppearance.BorderSize = 0;
            this.Button_SaveData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_SaveData.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Button_SaveData.Location = new System.Drawing.Point(524, 122);
            this.Button_SaveData.Name = "Button_SaveData";
            this.Button_SaveData.Size = new System.Drawing.Size(25, 23);
            this.Button_SaveData.TabIndex = 55;
            this.Button_SaveData.Text = "...";
            this.Button_SaveData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_SaveData.UseVisualStyleBackColor = false;
            this.Button_SaveData.Click += new System.EventHandler(this.Button_Browse_Click);
            // 
            // Label_Description_SaveData
            // 
            this.Label_Description_SaveData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Description_SaveData.AutoSize = true;
            this.Label_Description_SaveData.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Description_SaveData.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Label_Description_SaveData.Location = new System.Drawing.Point(170, 102);
            this.Label_Description_SaveData.Name = "Label_Description_SaveData";
            this.Label_Description_SaveData.Size = new System.Drawing.Size(348, 15);
            this.Label_Description_SaveData.TabIndex = 56;
            this.Label_Description_SaveData.Text = "Sonic Unleashed save file currently being used with the emulator.";
            // 
            // Label_Subtitle_Emulator_Paths
            // 
            this.Label_Subtitle_Emulator_Paths.AutoSize = true;
            this.Label_Subtitle_Emulator_Paths.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.Label_Subtitle_Emulator_Paths.Location = new System.Drawing.Point(9, 13);
            this.Label_Subtitle_Emulator_Paths.Name = "Label_Subtitle_Emulator_Paths";
            this.Label_Subtitle_Emulator_Paths.Size = new System.Drawing.Size(54, 25);
            this.Label_Subtitle_Emulator_Paths.TabIndex = 48;
            this.Label_Subtitle_Emulator_Paths.Text = "Paths";
            // 
            // Button_EmulatorExecutable
            // 
            this.Button_EmulatorExecutable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_EmulatorExecutable.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Button_EmulatorExecutable.FlatAppearance.BorderSize = 0;
            this.Button_EmulatorExecutable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_EmulatorExecutable.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Button_EmulatorExecutable.Location = new System.Drawing.Point(524, 70);
            this.Button_EmulatorExecutable.Name = "Button_EmulatorExecutable";
            this.Button_EmulatorExecutable.Size = new System.Drawing.Size(25, 23);
            this.Button_EmulatorExecutable.TabIndex = 51;
            this.Button_EmulatorExecutable.Text = "...";
            this.Button_EmulatorExecutable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_EmulatorExecutable.UseVisualStyleBackColor = false;
            this.Button_EmulatorExecutable.Click += new System.EventHandler(this.Button_Browse_Click);
            // 
            // TextBox_EmulatorExecutable
            // 
            this.TextBox_EmulatorExecutable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_EmulatorExecutable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.TextBox_EmulatorExecutable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_EmulatorExecutable.ForeColor = System.Drawing.SystemColors.Control;
            this.TextBox_EmulatorExecutable.Location = new System.Drawing.Point(14, 70);
            this.TextBox_EmulatorExecutable.Name = "TextBox_EmulatorExecutable";
            this.TextBox_EmulatorExecutable.Size = new System.Drawing.Size(504, 23);
            this.TextBox_EmulatorExecutable.TabIndex = 50;
            // 
            // Label_EmulatorExecutable
            // 
            this.Label_EmulatorExecutable.AutoSize = true;
            this.Label_EmulatorExecutable.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Label_EmulatorExecutable.Location = new System.Drawing.Point(11, 48);
            this.Label_EmulatorExecutable.Name = "Label_EmulatorExecutable";
            this.Label_EmulatorExecutable.Size = new System.Drawing.Size(126, 17);
            this.Label_EmulatorExecutable.TabIndex = 49;
            this.Label_EmulatorExecutable.Text = "Emulator Executable";
            // 
            // Label_SaveData
            // 
            this.Label_SaveData.AutoSize = true;
            this.Label_SaveData.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Label_SaveData.Location = new System.Drawing.Point(11, 100);
            this.Label_SaveData.Name = "Label_SaveData";
            this.Label_SaveData.Size = new System.Drawing.Size(66, 17);
            this.Label_SaveData.TabIndex = 53;
            this.Label_SaveData.Text = "Save Data";
            // 
            // Label_Optional_SaveData
            // 
            this.Label_Optional_SaveData.AutoSize = true;
            this.Label_Optional_SaveData.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Optional_SaveData.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Label_Optional_SaveData.Location = new System.Drawing.Point(74, 100);
            this.Label_Optional_SaveData.Name = "Label_Optional_SaveData";
            this.Label_Optional_SaveData.Size = new System.Drawing.Size(61, 17);
            this.Label_Optional_SaveData.TabIndex = 68;
            this.Label_Optional_SaveData.Text = "(optional)";
            // 
            // Tab_Section_Debug
            // 
            this.Tab_Section_Debug.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Tab_Section_Debug.Controls.Add(this.Panel_DebugControls);
            this.Tab_Section_Debug.Controls.Add(this.ListBox_Debug);
            this.Tab_Section_Debug.Location = new System.Drawing.Point(4, 20);
            this.Tab_Section_Debug.Name = "Tab_Section_Debug";
            this.Tab_Section_Debug.Size = new System.Drawing.Size(591, 1013);
            this.Tab_Section_Debug.TabIndex = 5;
            this.Tab_Section_Debug.Text = "Debug";
            // 
            // Panel_DebugControls
            // 
            this.Panel_DebugControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_DebugControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_DebugControls.Controls.Add(this.SectionButton_ClearLog);
            this.Panel_DebugControls.Location = new System.Drawing.Point(-1, 970);
            this.Panel_DebugControls.Name = "Panel_DebugControls";
            this.Panel_DebugControls.Size = new System.Drawing.Size(596, 45);
            this.Panel_DebugControls.TabIndex = 1;
            // 
            // SectionButton_ClearLog
            // 
            this.SectionButton_ClearLog.AccentColour = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SectionButton_ClearLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SectionButton_ClearLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(45)))));
            this.SectionButton_ClearLog.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SectionButton_ClearLog.Location = new System.Drawing.Point(3, 7);
            this.SectionButton_ClearLog.Name = "SectionButton_ClearLog";
            this.SectionButton_ClearLog.SectionImage = ((System.Drawing.Bitmap)(resources.GetObject("SectionButton_ClearLog.SectionImage")));
            this.SectionButton_ClearLog.SectionText = "Clear debug log";
            this.SectionButton_ClearLog.SelectedSection = false;
            this.SectionButton_ClearLog.Size = new System.Drawing.Size(584, 35);
            this.SectionButton_ClearLog.TabIndex = 24;
            this.SectionButton_ClearLog.TextColour = System.Drawing.SystemColors.Control;
            this.SectionButton_ClearLog.Click += new System.EventHandler(this.SectionButton_ClearLog_Click);
            // 
            // ListBox_Debug
            // 
            this.ListBox_Debug.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListBox_Debug.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ListBox_Debug.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListBox_Debug.ForeColor = System.Drawing.SystemColors.Control;
            this.ListBox_Debug.FormattingEnabled = true;
            this.ListBox_Debug.ItemHeight = 15;
            this.ListBox_Debug.Location = new System.Drawing.Point(0, 4);
            this.ListBox_Debug.Name = "ListBox_Debug";
            this.ListBox_Debug.Size = new System.Drawing.Size(591, 975);
            this.ListBox_Debug.TabIndex = 0;
            // 
            // Tab_Section_Updates
            // 
            this.Tab_Section_Updates.AutoScroll = true;
            this.Tab_Section_Updates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Tab_Section_Updates.Controls.Add(this.SplitContainer_ModUpdate);
            this.Tab_Section_Updates.Controls.Add(this.Label_LastModUpdate);
            this.Tab_Section_Updates.Controls.Add(this.SectionButton_CheckForModUpdates);
            this.Tab_Section_Updates.Controls.Add(this.Label_Title_ModsAndPatches);
            this.Tab_Section_Updates.Location = new System.Drawing.Point(4, 20);
            this.Tab_Section_Updates.Name = "Tab_Section_Updates";
            this.Tab_Section_Updates.Size = new System.Drawing.Size(591, 1013);
            this.Tab_Section_Updates.TabIndex = 6;
            this.Tab_Section_Updates.Tag = "HideControls";
            this.Tab_Section_Updates.Text = "Updates";
            // 
            // SplitContainer_ModUpdate
            // 
            this.SplitContainer_ModUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SplitContainer_ModUpdate.Location = new System.Drawing.Point(14, 113);
            this.SplitContainer_ModUpdate.Name = "SplitContainer_ModUpdate";
            // 
            // SplitContainer_ModUpdate.Panel1
            // 
            this.SplitContainer_ModUpdate.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.SplitContainer_ModUpdate.Panel1.Controls.Add(this.Panel_ModUpdateBackdrop);
            this.SplitContainer_ModUpdate.Panel1.Controls.Add(this.SectionButton_UpdateMods);
            this.SplitContainer_ModUpdate.Panel1MinSize = 201;
            // 
            // SplitContainer_ModUpdate.Panel2
            // 
            this.SplitContainer_ModUpdate.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.SplitContainer_ModUpdate.Panel2.Controls.Add(this.ProgressBar_ModUpdate);
            this.SplitContainer_ModUpdate.Panel2.Controls.Add(this.Panel_ModInfoBackdrop);
            this.SplitContainer_ModUpdate.Panel2MinSize = 300;
            this.SplitContainer_ModUpdate.Size = new System.Drawing.Size(561, 421);
            this.SplitContainer_ModUpdate.SplitterDistance = 225;
            this.SplitContainer_ModUpdate.TabIndex = 44;
            this.SplitContainer_ModUpdate.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.SplitContainer_ModUpdate_SplitterMoved);
            // 
            // Panel_ModUpdateBackdrop
            // 
            this.Panel_ModUpdateBackdrop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_ModUpdateBackdrop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Panel_ModUpdateBackdrop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_ModUpdateBackdrop.Controls.Add(this.ListView_ModUpdates);
            this.Panel_ModUpdateBackdrop.Location = new System.Drawing.Point(0, 0);
            this.Panel_ModUpdateBackdrop.Name = "Panel_ModUpdateBackdrop";
            this.Panel_ModUpdateBackdrop.Size = new System.Drawing.Size(223, 379);
            this.Panel_ModUpdateBackdrop.TabIndex = 1;
            // 
            // ListView_ModUpdates
            // 
            this.ListView_ModUpdates.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.ListView_ModUpdates.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListView_ModUpdates.AutoArrange = false;
            this.ListView_ModUpdates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ListView_ModUpdates.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListView_ModUpdates.CheckBoxes = true;
            this.ListView_ModUpdates.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Column_Updates_Title,
            this.Column_Updates_Blank});
            this.ListView_ModUpdates.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ListView_ModUpdates.ForeColor = System.Drawing.SystemColors.Control;
            this.ListView_ModUpdates.FullRowSelect = true;
            this.ListView_ModUpdates.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ListView_ModUpdates.HideSelection = false;
            this.ListView_ModUpdates.Location = new System.Drawing.Point(0, 0);
            this.ListView_ModUpdates.MultiSelect = false;
            this.ListView_ModUpdates.Name = "ListView_ModUpdates";
            this.ListView_ModUpdates.OwnerDraw = true;
            this.ListView_ModUpdates.Size = new System.Drawing.Size(221, 394);
            this.ListView_ModUpdates.TabIndex = 2;
            this.ListView_ModUpdates.UseCompatibleStateImageBehavior = false;
            this.ListView_ModUpdates.View = System.Windows.Forms.View.Details;
            this.ListView_ModUpdates.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.ListView_DrawColumnHeader);
            this.ListView_ModUpdates.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.ListView_DrawItem);
            this.ListView_ModUpdates.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.ListView_ModUpdates_ItemChecked);
            // 
            // Column_Updates_Title
            // 
            this.Column_Updates_Title.Text = "Title";
            this.Column_Updates_Title.Width = 197;
            // 
            // Column_Updates_Blank
            // 
            this.Column_Updates_Blank.Text = "";
            this.Column_Updates_Blank.Width = 1000;
            // 
            // SectionButton_UpdateMods
            // 
            this.SectionButton_UpdateMods.AccentColour = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SectionButton_UpdateMods.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SectionButton_UpdateMods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(45)))));
            this.SectionButton_UpdateMods.Enabled = false;
            this.SectionButton_UpdateMods.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SectionButton_UpdateMods.Location = new System.Drawing.Point(1, 385);
            this.SectionButton_UpdateMods.Name = "SectionButton_UpdateMods";
            this.SectionButton_UpdateMods.SectionImage = global::Unleash.Properties.Resources.Update_4;
            this.SectionButton_UpdateMods.SectionText = "Update selected mods";
            this.SectionButton_UpdateMods.SelectedSection = false;
            this.SectionButton_UpdateMods.Size = new System.Drawing.Size(223, 35);
            this.SectionButton_UpdateMods.TabIndex = 45;
            this.SectionButton_UpdateMods.TextColour = System.Drawing.SystemColors.GrayText;
            this.SectionButton_UpdateMods.Click += new System.EventHandler(this.SectionButton_Updates_Click);
            // 
            // ProgressBar_ModUpdate
            // 
            this.ProgressBar_ModUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressBar_ModUpdate.Enabled = false;
            this.ProgressBar_ModUpdate.Location = new System.Drawing.Point(2, 385);
            this.ProgressBar_ModUpdate.Name = "ProgressBar_ModUpdate";
            this.ProgressBar_ModUpdate.Size = new System.Drawing.Size(329, 35);
            this.ProgressBar_ModUpdate.TabIndex = 94;
            // 
            // Panel_ModInfoBackdrop
            // 
            this.Panel_ModInfoBackdrop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_ModInfoBackdrop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Panel_ModInfoBackdrop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_ModInfoBackdrop.Controls.Add(this.ListBox_UpdateLogs);
            this.Panel_ModInfoBackdrop.Location = new System.Drawing.Point(2, 0);
            this.Panel_ModInfoBackdrop.Name = "Panel_ModInfoBackdrop";
            this.Panel_ModInfoBackdrop.Size = new System.Drawing.Size(329, 379);
            this.Panel_ModInfoBackdrop.TabIndex = 21;
            // 
            // ListBox_UpdateLogs
            // 
            this.ListBox_UpdateLogs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ListBox_UpdateLogs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListBox_UpdateLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBox_UpdateLogs.ForeColor = System.Drawing.SystemColors.Control;
            this.ListBox_UpdateLogs.FormattingEnabled = true;
            this.ListBox_UpdateLogs.ItemHeight = 15;
            this.ListBox_UpdateLogs.Location = new System.Drawing.Point(0, 0);
            this.ListBox_UpdateLogs.Name = "ListBox_UpdateLogs";
            this.ListBox_UpdateLogs.Size = new System.Drawing.Size(327, 377);
            this.ListBox_UpdateLogs.TabIndex = 1;
            // 
            // Label_LastModUpdate
            // 
            this.Label_LastModUpdate.AutoSize = true;
            this.Label_LastModUpdate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_LastModUpdate.Location = new System.Drawing.Point(256, 72);
            this.Label_LastModUpdate.Name = "Label_LastModUpdate";
            this.Label_LastModUpdate.Size = new System.Drawing.Size(216, 17);
            this.Label_LastModUpdate.TabIndex = 150;
            this.Label_LastModUpdate.Text = "Last checked: 21/01/2020, 08:59 PM";
            // 
            // SectionButton_CheckForModUpdates
            // 
            this.SectionButton_CheckForModUpdates.AccentColour = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SectionButton_CheckForModUpdates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(45)))));
            this.SectionButton_CheckForModUpdates.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SectionButton_CheckForModUpdates.Location = new System.Drawing.Point(14, 63);
            this.SectionButton_CheckForModUpdates.Name = "SectionButton_CheckForModUpdates";
            this.SectionButton_CheckForModUpdates.SectionImage = global::Unleash.Properties.Resources.Update_4;
            this.SectionButton_CheckForModUpdates.SectionText = "Check for mod updates";
            this.SectionButton_CheckForModUpdates.SelectedSection = false;
            this.SectionButton_CheckForModUpdates.Size = new System.Drawing.Size(233, 35);
            this.SectionButton_CheckForModUpdates.TabIndex = 94;
            this.SectionButton_CheckForModUpdates.TextColour = System.Drawing.SystemColors.Control;
            this.SectionButton_CheckForModUpdates.Click += new System.EventHandler(this.SectionButton_Updates_Click);
            // 
            // Label_Title_ModsAndPatches
            // 
            this.Label_Title_ModsAndPatches.AutoSize = true;
            this.Label_Title_ModsAndPatches.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.Label_Title_ModsAndPatches.Location = new System.Drawing.Point(6, 6);
            this.Label_Title_ModsAndPatches.Name = "Label_Title_ModsAndPatches";
            this.Label_Title_ModsAndPatches.Size = new System.Drawing.Size(280, 45);
            this.Label_Title_ModsAndPatches.TabIndex = 43;
            this.Label_Title_ModsAndPatches.Text = "Mods and Patches";
            // 
            // Tab_Section_Settings
            // 
            this.Tab_Section_Settings.AutoScroll = true;
            this.Tab_Section_Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Tab_Section_Settings.Controls.Add(this.LinkLabel_Snapshot);
            this.Tab_Section_Settings.Controls.Add(this.Label_Description_UninstallOnLaunch);
            this.Tab_Section_Settings.Controls.Add(this.CheckBox_UninstallOnLaunch);
            this.Tab_Section_Settings.Controls.Add(this.Label_Description_Reset);
            this.Tab_Section_Settings.Controls.Add(this.LinkLabel_Reset);
            this.Tab_Section_Settings.Controls.Add(this.Label_Description_DebugMode);
            this.Tab_Section_Settings.Controls.Add(this.Label_Description_HighContrastText);
            this.Tab_Section_Settings.Controls.Add(this.Label_Description_SaveFileRedirect);
            this.Tab_Section_Settings.Controls.Add(this.CheckBox_SaveFileRedirection);
            this.Tab_Section_Settings.Controls.Add(this.CheckBox_DebugMode);
            this.Tab_Section_Settings.Controls.Add(this.Label_Description_LaunchEmulator);
            this.Tab_Section_Settings.Controls.Add(this.CheckBox_LaunchEmulator);
            this.Tab_Section_Settings.Controls.Add(this.Label_Subtitle_General_Options);
            this.Tab_Section_Settings.Controls.Add(this.WindowsColourPicker_AccentColour);
            this.Tab_Section_Settings.Controls.Add(this.TextBox_GameDirectory);
            this.Tab_Section_Settings.Controls.Add(this.Label_Title_Appearance);
            this.Tab_Section_Settings.Controls.Add(this.CheckBox_HighContrastText);
            this.Tab_Section_Settings.Controls.Add(this.Label_Title_General);
            this.Tab_Section_Settings.Controls.Add(this.Label_Subtitle_AccentColour);
            this.Tab_Section_Settings.Controls.Add(this.Label_GameExecutable);
            this.Tab_Section_Settings.Controls.Add(this.Label_WindowsColours);
            this.Tab_Section_Settings.Controls.Add(this.Button_GameDirectory);
            this.Tab_Section_Settings.Controls.Add(this.Label_Subtitle_Appearance_Options);
            this.Tab_Section_Settings.Controls.Add(this.CheckBox_AutoColour);
            this.Tab_Section_Settings.Controls.Add(this.Label_Description_GameExecutable);
            this.Tab_Section_Settings.Controls.Add(this.Button_ColourPicker_Preview);
            this.Tab_Section_Settings.Controls.Add(this.Label_Subtitle_Settings_Paths);
            this.Tab_Section_Settings.Controls.Add(this.Button_ModsDirectory);
            this.Tab_Section_Settings.Controls.Add(this.TextBox_ModsDirectory);
            this.Tab_Section_Settings.Controls.Add(this.Label_ModsDirectory);
            this.Tab_Section_Settings.Controls.Add(this.Panel_Settings_UICleanSpace);
            this.Tab_Section_Settings.Controls.Add(this.Button_Open_GameDirectory);
            this.Tab_Section_Settings.Controls.Add(this.Button_Open_ModsDirectory);
            this.Tab_Section_Settings.Controls.Add(this.Button_ColourPicker_Default);
            this.Tab_Section_Settings.Controls.Add(this.Section_Appearance_ColourPicker);
            this.Tab_Section_Settings.Controls.Add(this.Label_Description_1ClickURLHandler);
            this.Tab_Section_Settings.Controls.Add(this.LinkLabel_1ClickURLHandler);
            this.Tab_Section_Settings.Controls.Add(this.Label_Warning_ModsDirectoryInvalid);
            this.Tab_Section_Settings.Controls.Add(this.Label_Description_ModsDirectory);
            this.Tab_Section_Settings.Controls.Add(this.Label_Description_Snapshot);
            this.Tab_Section_Settings.Location = new System.Drawing.Point(4, 20);
            this.Tab_Section_Settings.Name = "Tab_Section_Settings";
            this.Tab_Section_Settings.Size = new System.Drawing.Size(591, 1013);
            this.Tab_Section_Settings.TabIndex = 3;
            this.Tab_Section_Settings.Tag = "HideControls";
            this.Tab_Section_Settings.Text = "Settings";
            // 
            // LinkLabel_Snapshot
            // 
            this.LinkLabel_Snapshot.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LinkLabel_Snapshot.AutoSize = true;
            this.LinkLabel_Snapshot.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LinkLabel_Snapshot.LinkColor = System.Drawing.Color.SkyBlue;
            this.LinkLabel_Snapshot.Location = new System.Drawing.Point(11, 348);
            this.LinkLabel_Snapshot.Name = "LinkLabel_Snapshot";
            this.LinkLabel_Snapshot.Size = new System.Drawing.Size(110, 15);
            this.LinkLabel_Snapshot.TabIndex = 165;
            this.LinkLabel_Snapshot.TabStop = true;
            this.LinkLabel_Snapshot.Text = "Create a snapshot...";
            this.LinkLabel_Snapshot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_Snapshot_LinkClicked);
            // 
            // Label_Description_UninstallOnLaunch
            // 
            this.Label_Description_UninstallOnLaunch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Description_UninstallOnLaunch.AutoSize = true;
            this.Label_Description_UninstallOnLaunch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Description_UninstallOnLaunch.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Label_Description_UninstallOnLaunch.Location = new System.Drawing.Point(222, 273);
            this.Label_Description_UninstallOnLaunch.Name = "Label_Description_UninstallOnLaunch";
            this.Label_Description_UninstallOnLaunch.Size = new System.Drawing.Size(352, 15);
            this.Label_Description_UninstallOnLaunch.TabIndex = 164;
            this.Label_Description_UninstallOnLaunch.Text = "Disable if you plan to keep mods installed for long periods of time.";
            // 
            // CheckBox_UninstallOnLaunch
            // 
            this.CheckBox_UninstallOnLaunch.AutoSize = true;
            this.CheckBox_UninstallOnLaunch.BackColor = System.Drawing.Color.Transparent;
            this.CheckBox_UninstallOnLaunch.Location = new System.Drawing.Point(14, 272);
            this.CheckBox_UninstallOnLaunch.Name = "CheckBox_UninstallOnLaunch";
            this.CheckBox_UninstallOnLaunch.Size = new System.Drawing.Size(180, 19);
            this.CheckBox_UninstallOnLaunch.TabIndex = 163;
            this.CheckBox_UninstallOnLaunch.Text = "Uninstall mods automatically";
            this.CheckBox_UninstallOnLaunch.UseVisualStyleBackColor = false;
            this.CheckBox_UninstallOnLaunch.CheckedChanged += new System.EventHandler(this.CheckBox_Settings_CheckedChanged);
            // 
            // Label_Description_Reset
            // 
            this.Label_Description_Reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Description_Reset.AutoSize = true;
            this.Label_Description_Reset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Description_Reset.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Label_Description_Reset.Location = new System.Drawing.Point(224, 373);
            this.Label_Description_Reset.Name = "Label_Description_Reset";
            this.Label_Description_Reset.Size = new System.Drawing.Size(352, 15);
            this.Label_Description_Reset.TabIndex = 158;
            this.Label_Description_Reset.Text = "Resets all settings and removes files created by the Mod Manager.";
            // 
            // LinkLabel_Reset
            // 
            this.LinkLabel_Reset.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LinkLabel_Reset.AutoSize = true;
            this.LinkLabel_Reset.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LinkLabel_Reset.LinkColor = System.Drawing.Color.Tomato;
            this.LinkLabel_Reset.Location = new System.Drawing.Point(11, 373);
            this.LinkLabel_Reset.Name = "LinkLabel_Reset";
            this.LinkLabel_Reset.Size = new System.Drawing.Size(180, 15);
            this.LinkLabel_Reset.TabIndex = 157;
            this.LinkLabel_Reset.TabStop = true;
            this.LinkLabel_Reset.Text = "Reset Unleashed Mod Manager...";
            this.LinkLabel_Reset.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_Reset_LinkClicked);
            // 
            // Label_Description_DebugMode
            // 
            this.Label_Description_DebugMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Description_DebugMode.AutoSize = true;
            this.Label_Description_DebugMode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Description_DebugMode.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Label_Description_DebugMode.Location = new System.Drawing.Point(441, 967);
            this.Label_Description_DebugMode.Name = "Label_Description_DebugMode";
            this.Label_Description_DebugMode.Size = new System.Drawing.Size(133, 15);
            this.Label_Description_DebugMode.TabIndex = 156;
            this.Label_Description_DebugMode.Text = "Unlocks debug features.";
            // 
            // Label_Description_HighContrastText
            // 
            this.Label_Description_HighContrastText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Description_HighContrastText.AutoSize = true;
            this.Label_Description_HighContrastText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Description_HighContrastText.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Label_Description_HighContrastText.Location = new System.Drawing.Point(324, 942);
            this.Label_Description_HighContrastText.Name = "Label_Description_HighContrastText";
            this.Label_Description_HighContrastText.Size = new System.Drawing.Size(250, 15);
            this.Label_Description_HighContrastText.TabIndex = 155;
            this.Label_Description_HighContrastText.Text = "Sets text affected by the accent colour to black.";
            // 
            // Label_Description_SaveFileRedirect
            // 
            this.Label_Description_SaveFileRedirect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Description_SaveFileRedirect.AutoSize = true;
            this.Label_Description_SaveFileRedirect.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Description_SaveFileRedirect.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Label_Description_SaveFileRedirect.Location = new System.Drawing.Point(343, 298);
            this.Label_Description_SaveFileRedirect.Name = "Label_Description_SaveFileRedirect";
            this.Label_Description_SaveFileRedirect.Size = new System.Drawing.Size(233, 15);
            this.Label_Description_SaveFileRedirect.TabIndex = 154;
            this.Label_Description_SaveFileRedirect.Text = "Used for mods that have custom save data.";
            // 
            // CheckBox_SaveFileRedirection
            // 
            this.CheckBox_SaveFileRedirection.AutoSize = true;
            this.CheckBox_SaveFileRedirection.BackColor = System.Drawing.Color.Transparent;
            this.CheckBox_SaveFileRedirection.Location = new System.Drawing.Point(14, 297);
            this.CheckBox_SaveFileRedirection.Name = "CheckBox_SaveFileRedirection";
            this.CheckBox_SaveFileRedirection.Size = new System.Drawing.Size(129, 19);
            this.CheckBox_SaveFileRedirection.TabIndex = 153;
            this.CheckBox_SaveFileRedirection.Text = "Save file redirection";
            this.CheckBox_SaveFileRedirection.UseVisualStyleBackColor = false;
            this.CheckBox_SaveFileRedirection.CheckedChanged += new System.EventHandler(this.CheckBox_Settings_CheckedChanged);
            // 
            // CheckBox_DebugMode
            // 
            this.CheckBox_DebugMode.AutoSize = true;
            this.CheckBox_DebugMode.BackColor = System.Drawing.Color.Transparent;
            this.CheckBox_DebugMode.Location = new System.Drawing.Point(14, 966);
            this.CheckBox_DebugMode.Name = "CheckBox_DebugMode";
            this.CheckBox_DebugMode.Size = new System.Drawing.Size(95, 19);
            this.CheckBox_DebugMode.TabIndex = 150;
            this.CheckBox_DebugMode.Text = "Debug mode";
            this.CheckBox_DebugMode.UseVisualStyleBackColor = false;
            this.CheckBox_DebugMode.CheckedChanged += new System.EventHandler(this.CheckBox_Settings_CheckedChanged);
            // 
            // Label_Description_LaunchEmulator
            // 
            this.Label_Description_LaunchEmulator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Description_LaunchEmulator.AutoSize = true;
            this.Label_Description_LaunchEmulator.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Description_LaunchEmulator.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Label_Description_LaunchEmulator.Location = new System.Drawing.Point(289, 248);
            this.Label_Description_LaunchEmulator.Name = "Label_Description_LaunchEmulator";
            this.Label_Description_LaunchEmulator.Size = new System.Drawing.Size(285, 15);
            this.Label_Description_LaunchEmulator.TabIndex = 149;
            this.Label_Description_LaunchEmulator.Text = "Disable if installing mods on real modified hardware.";
            // 
            // CheckBox_LaunchEmulator
            // 
            this.CheckBox_LaunchEmulator.AutoSize = true;
            this.CheckBox_LaunchEmulator.BackColor = System.Drawing.Color.Transparent;
            this.CheckBox_LaunchEmulator.Location = new System.Drawing.Point(14, 247);
            this.CheckBox_LaunchEmulator.Name = "CheckBox_LaunchEmulator";
            this.CheckBox_LaunchEmulator.Size = new System.Drawing.Size(227, 19);
            this.CheckBox_LaunchEmulator.TabIndex = 148;
            this.CheckBox_LaunchEmulator.Text = "Launch emulator after installing mods";
            this.CheckBox_LaunchEmulator.UseVisualStyleBackColor = false;
            this.CheckBox_LaunchEmulator.CheckedChanged += new System.EventHandler(this.CheckBox_Settings_CheckedChanged);
            // 
            // Label_Subtitle_General_Options
            // 
            this.Label_Subtitle_General_Options.AutoSize = true;
            this.Label_Subtitle_General_Options.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.Label_Subtitle_General_Options.Location = new System.Drawing.Point(9, 210);
            this.Label_Subtitle_General_Options.Name = "Label_Subtitle_General_Options";
            this.Label_Subtitle_General_Options.Size = new System.Drawing.Size(76, 25);
            this.Label_Subtitle_General_Options.TabIndex = 147;
            this.Label_Subtitle_General_Options.Text = "Options";
            // 
            // WindowsColourPicker_AccentColour
            // 
            this.WindowsColourPicker_AccentColour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.WindowsColourPicker_AccentColour.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindowsColourPicker_AccentColour.Location = new System.Drawing.Point(11, 560);
            this.WindowsColourPicker_AccentColour.Name = "WindowsColourPicker_AccentColour";
            this.WindowsColourPicker_AccentColour.Size = new System.Drawing.Size(379, 285);
            this.WindowsColourPicker_AccentColour.TabIndex = 146;
            this.WindowsColourPicker_AccentColour.ButtonClick += new System.EventHandler(this.WindowsColourPicker_AccentColour_ButtonClick);
            // 
            // TextBox_GameDirectory
            // 
            this.TextBox_GameDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_GameDirectory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.TextBox_GameDirectory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_GameDirectory.ForeColor = System.Drawing.SystemColors.Control;
            this.TextBox_GameDirectory.Location = new System.Drawing.Point(14, 170);
            this.TextBox_GameDirectory.Name = "TextBox_GameDirectory";
            this.TextBox_GameDirectory.Size = new System.Drawing.Size(504, 23);
            this.TextBox_GameDirectory.TabIndex = 44;
            // 
            // Label_Title_Appearance
            // 
            this.Label_Title_Appearance.AutoSize = true;
            this.Label_Title_Appearance.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Title_Appearance.Location = new System.Drawing.Point(6, 406);
            this.Label_Title_Appearance.Name = "Label_Title_Appearance";
            this.Label_Title_Appearance.Size = new System.Drawing.Size(189, 45);
            this.Label_Title_Appearance.TabIndex = 10;
            this.Label_Title_Appearance.Text = "Appearance";
            // 
            // CheckBox_HighContrastText
            // 
            this.CheckBox_HighContrastText.AutoSize = true;
            this.CheckBox_HighContrastText.BackColor = System.Drawing.Color.Transparent;
            this.CheckBox_HighContrastText.Location = new System.Drawing.Point(14, 941);
            this.CheckBox_HighContrastText.Name = "CheckBox_HighContrastText";
            this.CheckBox_HighContrastText.Size = new System.Drawing.Size(121, 19);
            this.CheckBox_HighContrastText.TabIndex = 144;
            this.CheckBox_HighContrastText.Text = "High contrast text";
            this.CheckBox_HighContrastText.UseVisualStyleBackColor = false;
            this.CheckBox_HighContrastText.CheckedChanged += new System.EventHandler(this.CheckBox_Settings_CheckedChanged);
            // 
            // Label_Title_General
            // 
            this.Label_Title_General.AutoSize = true;
            this.Label_Title_General.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.Label_Title_General.Location = new System.Drawing.Point(6, 6);
            this.Label_Title_General.Name = "Label_Title_General";
            this.Label_Title_General.Size = new System.Drawing.Size(129, 45);
            this.Label_Title_General.TabIndex = 32;
            this.Label_Title_General.Text = "General";
            // 
            // Label_Subtitle_AccentColour
            // 
            this.Label_Subtitle_AccentColour.AutoSize = true;
            this.Label_Subtitle_AccentColour.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.Label_Subtitle_AccentColour.Location = new System.Drawing.Point(9, 461);
            this.Label_Subtitle_AccentColour.Name = "Label_Subtitle_AccentColour";
            this.Label_Subtitle_AccentColour.Size = new System.Drawing.Size(223, 25);
            this.Label_Subtitle_AccentColour.TabIndex = 45;
            this.Label_Subtitle_AccentColour.Text = "Choose your accent colour";
            // 
            // Label_GameExecutable
            // 
            this.Label_GameExecutable.AutoSize = true;
            this.Label_GameExecutable.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Label_GameExecutable.Location = new System.Drawing.Point(11, 148);
            this.Label_GameExecutable.Name = "Label_GameExecutable";
            this.Label_GameExecutable.Size = new System.Drawing.Size(108, 17);
            this.Label_GameExecutable.TabIndex = 43;
            this.Label_GameExecutable.Text = "Game Executable";
            // 
            // Label_WindowsColours
            // 
            this.Label_WindowsColours.AutoSize = true;
            this.Label_WindowsColours.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Label_WindowsColours.Location = new System.Drawing.Point(11, 535);
            this.Label_WindowsColours.Name = "Label_WindowsColours";
            this.Label_WindowsColours.Size = new System.Drawing.Size(108, 17);
            this.Label_WindowsColours.TabIndex = 89;
            this.Label_WindowsColours.Text = "Windows colours";
            // 
            // Button_GameDirectory
            // 
            this.Button_GameDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_GameDirectory.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Button_GameDirectory.FlatAppearance.BorderSize = 0;
            this.Button_GameDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_GameDirectory.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Button_GameDirectory.Location = new System.Drawing.Point(524, 170);
            this.Button_GameDirectory.Name = "Button_GameDirectory";
            this.Button_GameDirectory.Size = new System.Drawing.Size(25, 23);
            this.Button_GameDirectory.TabIndex = 45;
            this.Button_GameDirectory.Text = "...";
            this.Button_GameDirectory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_GameDirectory.UseVisualStyleBackColor = false;
            this.Button_GameDirectory.Click += new System.EventHandler(this.Button_Browse_Click);
            // 
            // Label_Subtitle_Appearance_Options
            // 
            this.Label_Subtitle_Appearance_Options.AutoSize = true;
            this.Label_Subtitle_Appearance_Options.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.Label_Subtitle_Appearance_Options.Location = new System.Drawing.Point(9, 904);
            this.Label_Subtitle_Appearance_Options.Name = "Label_Subtitle_Appearance_Options";
            this.Label_Subtitle_Appearance_Options.Size = new System.Drawing.Size(76, 25);
            this.Label_Subtitle_Appearance_Options.TabIndex = 143;
            this.Label_Subtitle_Appearance_Options.Text = "Options";
            // 
            // CheckBox_AutoColour
            // 
            this.CheckBox_AutoColour.AutoSize = true;
            this.CheckBox_AutoColour.BackColor = System.Drawing.Color.Transparent;
            this.CheckBox_AutoColour.Location = new System.Drawing.Point(14, 499);
            this.CheckBox_AutoColour.Name = "CheckBox_AutoColour";
            this.CheckBox_AutoColour.Size = new System.Drawing.Size(354, 19);
            this.CheckBox_AutoColour.TabIndex = 142;
            this.CheckBox_AutoColour.Text = "Automatically pick an accent colour from my Windows theme";
            this.CheckBox_AutoColour.UseVisualStyleBackColor = false;
            this.CheckBox_AutoColour.CheckedChanged += new System.EventHandler(this.CheckBox_Settings_CheckedChanged);
            // 
            // Label_Description_GameExecutable
            // 
            this.Label_Description_GameExecutable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Description_GameExecutable.AutoSize = true;
            this.Label_Description_GameExecutable.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Description_GameExecutable.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Label_Description_GameExecutable.Location = new System.Drawing.Point(153, 150);
            this.Label_Description_GameExecutable.Name = "Label_Description_GameExecutable";
            this.Label_Description_GameExecutable.Size = new System.Drawing.Size(365, 15);
            this.Label_Description_GameExecutable.TabIndex = 46;
            this.Label_Description_GameExecutable.Text = "Unleashed executable file (XEX/BIN) - auto-detects the console used.";
            // 
            // Button_ColourPicker_Preview
            // 
            this.Button_ColourPicker_Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_ColourPicker_Preview.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.Button_ColourPicker_Preview.FlatAppearance.BorderSize = 0;
            this.Button_ColourPicker_Preview.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_ColourPicker_Preview.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_ColourPicker_Preview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_ColourPicker_Preview.Location = new System.Drawing.Point(357, 852);
            this.Button_ColourPicker_Preview.Name = "Button_ColourPicker_Preview";
            this.Button_ColourPicker_Preview.Size = new System.Drawing.Size(25, 25);
            this.Button_ColourPicker_Preview.TabIndex = 140;
            this.Button_ColourPicker_Preview.UseVisualStyleBackColor = false;
            this.Button_ColourPicker_Preview.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_ColourPicker_Preview_MouseDown);
            this.Button_ColourPicker_Preview.MouseEnter += new System.EventHandler(this.Button_ColourPicker_Preview_MouseEnter);
            this.Button_ColourPicker_Preview.MouseLeave += new System.EventHandler(this.Button_ColourPicker_Preview_MouseLeave);
            this.Button_ColourPicker_Preview.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_ColourPicker_Preview_MouseUp);
            // 
            // Label_Subtitle_Settings_Paths
            // 
            this.Label_Subtitle_Settings_Paths.AutoSize = true;
            this.Label_Subtitle_Settings_Paths.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.Label_Subtitle_Settings_Paths.Location = new System.Drawing.Point(9, 61);
            this.Label_Subtitle_Settings_Paths.Name = "Label_Subtitle_Settings_Paths";
            this.Label_Subtitle_Settings_Paths.Size = new System.Drawing.Size(54, 25);
            this.Label_Subtitle_Settings_Paths.TabIndex = 33;
            this.Label_Subtitle_Settings_Paths.Text = "Paths";
            // 
            // Button_ModsDirectory
            // 
            this.Button_ModsDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_ModsDirectory.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Button_ModsDirectory.FlatAppearance.BorderSize = 0;
            this.Button_ModsDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_ModsDirectory.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Button_ModsDirectory.Location = new System.Drawing.Point(524, 118);
            this.Button_ModsDirectory.Name = "Button_ModsDirectory";
            this.Button_ModsDirectory.Size = new System.Drawing.Size(25, 23);
            this.Button_ModsDirectory.TabIndex = 36;
            this.Button_ModsDirectory.Text = "...";
            this.Button_ModsDirectory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_ModsDirectory.UseVisualStyleBackColor = false;
            this.Button_ModsDirectory.Click += new System.EventHandler(this.Button_Browse_Click);
            // 
            // TextBox_ModsDirectory
            // 
            this.TextBox_ModsDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_ModsDirectory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.TextBox_ModsDirectory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_ModsDirectory.ForeColor = System.Drawing.SystemColors.Control;
            this.TextBox_ModsDirectory.Location = new System.Drawing.Point(14, 118);
            this.TextBox_ModsDirectory.Name = "TextBox_ModsDirectory";
            this.TextBox_ModsDirectory.Size = new System.Drawing.Size(504, 23);
            this.TextBox_ModsDirectory.TabIndex = 35;
            // 
            // Label_ModsDirectory
            // 
            this.Label_ModsDirectory.AutoSize = true;
            this.Label_ModsDirectory.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Label_ModsDirectory.Location = new System.Drawing.Point(11, 96);
            this.Label_ModsDirectory.Name = "Label_ModsDirectory";
            this.Label_ModsDirectory.Size = new System.Drawing.Size(99, 17);
            this.Label_ModsDirectory.TabIndex = 34;
            this.Label_ModsDirectory.Text = "Mods Directory";
            // 
            // Panel_Settings_UICleanSpace
            // 
            this.Panel_Settings_UICleanSpace.Location = new System.Drawing.Point(12, 984);
            this.Panel_Settings_UICleanSpace.Name = "Panel_Settings_UICleanSpace";
            this.Panel_Settings_UICleanSpace.Size = new System.Drawing.Size(214, 8);
            this.Panel_Settings_UICleanSpace.TabIndex = 145;
            // 
            // Button_Open_GameDirectory
            // 
            this.Button_Open_GameDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Open_GameDirectory.FlatAppearance.BorderSize = 0;
            this.Button_Open_GameDirectory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Button_Open_GameDirectory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Button_Open_GameDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Open_GameDirectory.Image = ((System.Drawing.Image)(resources.GetObject("Button_Open_GameDirectory.Image")));
            this.Button_Open_GameDirectory.Location = new System.Drawing.Point(555, 170);
            this.Button_Open_GameDirectory.Name = "Button_Open_GameDirectory";
            this.Button_Open_GameDirectory.Size = new System.Drawing.Size(21, 20);
            this.Button_Open_GameDirectory.TabIndex = 152;
            this.Button_Open_GameDirectory.UseVisualStyleBackColor = true;
            this.Button_Open_GameDirectory.Click += new System.EventHandler(this.Button_Open_Click);
            // 
            // Button_Open_ModsDirectory
            // 
            this.Button_Open_ModsDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Open_ModsDirectory.FlatAppearance.BorderSize = 0;
            this.Button_Open_ModsDirectory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Button_Open_ModsDirectory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Button_Open_ModsDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Open_ModsDirectory.Image = ((System.Drawing.Image)(resources.GetObject("Button_Open_ModsDirectory.Image")));
            this.Button_Open_ModsDirectory.Location = new System.Drawing.Point(555, 118);
            this.Button_Open_ModsDirectory.Name = "Button_Open_ModsDirectory";
            this.Button_Open_ModsDirectory.Size = new System.Drawing.Size(21, 20);
            this.Button_Open_ModsDirectory.TabIndex = 151;
            this.Button_Open_ModsDirectory.UseVisualStyleBackColor = true;
            this.Button_Open_ModsDirectory.Click += new System.EventHandler(this.Button_Open_Click);
            // 
            // Button_ColourPicker_Default
            // 
            this.Button_ColourPicker_Default.FlatAppearance.BorderSize = 0;
            this.Button_ColourPicker_Default.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Button_ColourPicker_Default.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Button_ColourPicker_Default.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_ColourPicker_Default.Image = ((System.Drawing.Image)(resources.GetObject("Button_ColourPicker_Default.Image")));
            this.Button_ColourPicker_Default.Location = new System.Drawing.Point(393, 854);
            this.Button_ColourPicker_Default.Name = "Button_ColourPicker_Default";
            this.Button_ColourPicker_Default.Size = new System.Drawing.Size(21, 20);
            this.Button_ColourPicker_Default.TabIndex = 141;
            this.Button_ColourPicker_Default.UseVisualStyleBackColor = true;
            this.Button_ColourPicker_Default.Click += new System.EventHandler(this.Button_ColourPicker_Default_Click);
            // 
            // Section_Appearance_ColourPicker
            // 
            this.Section_Appearance_ColourPicker.AccentColour = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Section_Appearance_ColourPicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(45)))));
            this.Section_Appearance_ColourPicker.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Section_Appearance_ColourPicker.Location = new System.Drawing.Point(14, 847);
            this.Section_Appearance_ColourPicker.Name = "Section_Appearance_ColourPicker";
            this.Section_Appearance_ColourPicker.SectionImage = ((System.Drawing.Bitmap)(resources.GetObject("Section_Appearance_ColourPicker.SectionImage")));
            this.Section_Appearance_ColourPicker.SectionText = "Custom colour";
            this.Section_Appearance_ColourPicker.SelectedSection = false;
            this.Section_Appearance_ColourPicker.Size = new System.Drawing.Size(373, 35);
            this.Section_Appearance_ColourPicker.TabIndex = 138;
            this.Section_Appearance_ColourPicker.TextColour = System.Drawing.SystemColors.Control;
            this.Section_Appearance_ColourPicker.Click += new System.EventHandler(this.Section_Appearance_ColourPicker_Click);
            // 
            // Label_Description_1ClickURLHandler
            // 
            this.Label_Description_1ClickURLHandler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Description_1ClickURLHandler.AutoSize = true;
            this.Label_Description_1ClickURLHandler.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Description_1ClickURLHandler.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Label_Description_1ClickURLHandler.Location = new System.Drawing.Point(270, 323);
            this.Label_Description_1ClickURLHandler.Name = "Label_Description_1ClickURLHandler";
            this.Label_Description_1ClickURLHandler.Size = new System.Drawing.Size(304, 15);
            this.Label_Description_1ClickURLHandler.TabIndex = 160;
            this.Label_Description_1ClickURLHandler.Text = "Modifies the registry key for GameBanana 1-Click Install.";
            // 
            // LinkLabel_1ClickURLHandler
            // 
            this.LinkLabel_1ClickURLHandler.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LinkLabel_1ClickURLHandler.AutoSize = true;
            this.LinkLabel_1ClickURLHandler.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LinkLabel_1ClickURLHandler.LinkColor = System.Drawing.Color.Gold;
            this.LinkLabel_1ClickURLHandler.Location = new System.Drawing.Point(11, 323);
            this.LinkLabel_1ClickURLHandler.Name = "LinkLabel_1ClickURLHandler";
            this.LinkLabel_1ClickURLHandler.Size = new System.Drawing.Size(147, 15);
            this.LinkLabel_1ClickURLHandler.TabIndex = 159;
            this.LinkLabel_1ClickURLHandler.TabStop = true;
            this.LinkLabel_1ClickURLHandler.Text = "Install 1-Click URL Handler";
            this.LinkLabel_1ClickURLHandler.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_1ClickURLHandler_LinkClicked);
            // 
            // Label_Warning_ModsDirectoryInvalid
            // 
            this.Label_Warning_ModsDirectoryInvalid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Warning_ModsDirectoryInvalid.AutoSize = true;
            this.Label_Warning_ModsDirectoryInvalid.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Warning_ModsDirectoryInvalid.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Label_Warning_ModsDirectoryInvalid.Location = new System.Drawing.Point(305, 98);
            this.Label_Warning_ModsDirectoryInvalid.Name = "Label_Warning_ModsDirectoryInvalid";
            this.Label_Warning_ModsDirectoryInvalid.Size = new System.Drawing.Size(213, 15);
            this.Label_Warning_ModsDirectoryInvalid.TabIndex = 162;
            this.Label_Warning_ModsDirectoryInvalid.Text = "(ensure it\'s outside the game directory).";
            // 
            // Label_Description_ModsDirectory
            // 
            this.Label_Description_ModsDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Description_ModsDirectory.AutoSize = true;
            this.Label_Description_ModsDirectory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Description_ModsDirectory.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Label_Description_ModsDirectory.Location = new System.Drawing.Point(156, 98);
            this.Label_Description_ModsDirectory.Name = "Label_Description_ModsDirectory";
            this.Label_Description_ModsDirectory.Size = new System.Drawing.Size(153, 15);
            this.Label_Description_ModsDirectory.TabIndex = 161;
            this.Label_Description_ModsDirectory.Text = "Where the mods are located";
            // 
            // Label_Description_Snapshot
            // 
            this.Label_Description_Snapshot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Description_Snapshot.AutoSize = true;
            this.Label_Description_Snapshot.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Description_Snapshot.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Label_Description_Snapshot.Location = new System.Drawing.Point(328, 348);
            this.Label_Description_Snapshot.Name = "Label_Description_Snapshot";
            this.Label_Description_Snapshot.Size = new System.Drawing.Size(248, 15);
            this.Label_Description_Snapshot.TabIndex = 166;
            this.Label_Description_Snapshot.Text = "Dumps your user configuration for debuggers.";
            // 
            // Tab_Section_About
            // 
            this.Tab_Section_About.AutoScroll = true;
            this.Tab_Section_About.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Tab_Section_About.Controls.Add(this.LinkLabel_Knuxfan24);
            this.Tab_Section_About.Controls.Add(this.LinkLabel_Velcomia);
            this.Tab_Section_About.Controls.Add(this.LinkLabel_CodenameGamma);
            this.Tab_Section_About.Controls.Add(this.LinkLabel_Beatz);
            this.Tab_Section_About.Controls.Add(this.LinkLabel_SuperSonic16);
            this.Tab_Section_About.Controls.Add(this.LinkLabel_HyperBE32);
            this.Tab_Section_About.Controls.Add(this.Title_Testers);
            this.Tab_Section_About.Controls.Add(this.Label_Contributors);
            this.Tab_Section_About.Controls.Add(this.Title_Contributors);
            this.Tab_Section_About.Controls.Add(this.LinkLabel_GPF);
            this.Tab_Section_About.Controls.Add(this.LinkLabel_slashiee);
            this.Tab_Section_About.Controls.Add(this.Label_Testers);
            this.Tab_Section_About.Controls.Add(this.Label_Version);
            this.Tab_Section_About.Location = new System.Drawing.Point(4, 20);
            this.Tab_Section_About.Name = "Tab_Section_About";
            this.Tab_Section_About.Size = new System.Drawing.Size(591, 1013);
            this.Tab_Section_About.TabIndex = 4;
            this.Tab_Section_About.Tag = "HideControls";
            this.Tab_Section_About.Text = "About";
            this.Tab_Section_About.Visible = false;
            // 
            // LinkLabel_Knuxfan24
            // 
            this.LinkLabel_Knuxfan24.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(16)))), ((int)(((byte)(111)))));
            this.LinkLabel_Knuxfan24.AutoSize = true;
            this.LinkLabel_Knuxfan24.DisabledLinkColor = System.Drawing.SystemColors.GrayText;
            this.LinkLabel_Knuxfan24.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.LinkLabel_Knuxfan24.LinkColor = System.Drawing.SystemColors.Control;
            this.LinkLabel_Knuxfan24.Location = new System.Drawing.Point(30, 333);
            this.LinkLabel_Knuxfan24.Name = "LinkLabel_Knuxfan24";
            this.LinkLabel_Knuxfan24.Size = new System.Drawing.Size(95, 25);
            this.LinkLabel_Knuxfan24.TabIndex = 193;
            this.LinkLabel_Knuxfan24.TabStop = true;
            this.LinkLabel_Knuxfan24.Text = "Knuxfan24";
            this.LinkLabel_Knuxfan24.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_About_LinkClicked);
            // 
            // LinkLabel_Velcomia
            // 
            this.LinkLabel_Velcomia.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(16)))), ((int)(((byte)(111)))));
            this.LinkLabel_Velcomia.AutoSize = true;
            this.LinkLabel_Velcomia.DisabledLinkColor = System.Drawing.SystemColors.GrayText;
            this.LinkLabel_Velcomia.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.LinkLabel_Velcomia.LinkColor = System.Drawing.SystemColors.Control;
            this.LinkLabel_Velcomia.Location = new System.Drawing.Point(30, 283);
            this.LinkLabel_Velcomia.Name = "LinkLabel_Velcomia";
            this.LinkLabel_Velcomia.Size = new System.Drawing.Size(83, 25);
            this.LinkLabel_Velcomia.TabIndex = 191;
            this.LinkLabel_Velcomia.TabStop = true;
            this.LinkLabel_Velcomia.Text = "Velcomia";
            this.LinkLabel_Velcomia.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_About_LinkClicked);
            // 
            // LinkLabel_CodenameGamma
            // 
            this.LinkLabel_CodenameGamma.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(16)))), ((int)(((byte)(111)))));
            this.LinkLabel_CodenameGamma.AutoSize = true;
            this.LinkLabel_CodenameGamma.DisabledLinkColor = System.Drawing.SystemColors.GrayText;
            this.LinkLabel_CodenameGamma.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.LinkLabel_CodenameGamma.LinkColor = System.Drawing.SystemColors.Control;
            this.LinkLabel_CodenameGamma.Location = new System.Drawing.Point(30, 257);
            this.LinkLabel_CodenameGamma.Name = "LinkLabel_CodenameGamma";
            this.LinkLabel_CodenameGamma.Size = new System.Drawing.Size(160, 25);
            this.LinkLabel_CodenameGamma.TabIndex = 190;
            this.LinkLabel_CodenameGamma.TabStop = true;
            this.LinkLabel_CodenameGamma.Text = "CodenameGamma";
            this.LinkLabel_CodenameGamma.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_About_LinkClicked);
            // 
            // LinkLabel_Beatz
            // 
            this.LinkLabel_Beatz.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(16)))), ((int)(((byte)(111)))));
            this.LinkLabel_Beatz.AutoSize = true;
            this.LinkLabel_Beatz.DisabledLinkColor = System.Drawing.SystemColors.GrayText;
            this.LinkLabel_Beatz.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.LinkLabel_Beatz.LinkColor = System.Drawing.SystemColors.Control;
            this.LinkLabel_Beatz.Location = new System.Drawing.Point(30, 183);
            this.LinkLabel_Beatz.Name = "LinkLabel_Beatz";
            this.LinkLabel_Beatz.Size = new System.Drawing.Size(54, 25);
            this.LinkLabel_Beatz.TabIndex = 188;
            this.LinkLabel_Beatz.TabStop = true;
            this.LinkLabel_Beatz.Text = "Beatz";
            this.LinkLabel_Beatz.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_About_LinkClicked);
            // 
            // LinkLabel_SuperSonic16
            // 
            this.LinkLabel_SuperSonic16.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(16)))), ((int)(((byte)(111)))));
            this.LinkLabel_SuperSonic16.AutoSize = true;
            this.LinkLabel_SuperSonic16.DisabledLinkColor = System.Drawing.SystemColors.GrayText;
            this.LinkLabel_SuperSonic16.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.LinkLabel_SuperSonic16.LinkColor = System.Drawing.SystemColors.Control;
            this.LinkLabel_SuperSonic16.Location = new System.Drawing.Point(30, 85);
            this.LinkLabel_SuperSonic16.Name = "LinkLabel_SuperSonic16";
            this.LinkLabel_SuperSonic16.Size = new System.Drawing.Size(121, 25);
            this.LinkLabel_SuperSonic16.TabIndex = 179;
            this.LinkLabel_SuperSonic16.TabStop = true;
            this.LinkLabel_SuperSonic16.Text = "SuperSonic16";
            this.LinkLabel_SuperSonic16.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_About_LinkClicked);
            // 
            // LinkLabel_HyperBE32
            // 
            this.LinkLabel_HyperBE32.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(16)))), ((int)(((byte)(111)))));
            this.LinkLabel_HyperBE32.AutoSize = true;
            this.LinkLabel_HyperBE32.DisabledLinkColor = System.Drawing.SystemColors.GrayText;
            this.LinkLabel_HyperBE32.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.LinkLabel_HyperBE32.LinkColor = System.Drawing.SystemColors.Control;
            this.LinkLabel_HyperBE32.Location = new System.Drawing.Point(30, 60);
            this.LinkLabel_HyperBE32.Name = "LinkLabel_HyperBE32";
            this.LinkLabel_HyperBE32.Size = new System.Drawing.Size(99, 25);
            this.LinkLabel_HyperBE32.TabIndex = 176;
            this.LinkLabel_HyperBE32.TabStop = true;
            this.LinkLabel_HyperBE32.Text = "HyperBE32";
            this.LinkLabel_HyperBE32.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_About_LinkClicked);
            // 
            // Title_Testers
            // 
            this.Title_Testers.AutoSize = true;
            this.Title_Testers.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.Title_Testers.Location = new System.Drawing.Point(6, 129);
            this.Title_Testers.Name = "Title_Testers";
            this.Title_Testers.Size = new System.Drawing.Size(118, 45);
            this.Title_Testers.TabIndex = 38;
            this.Title_Testers.Text = "Testers";
            // 
            // Label_Contributors
            // 
            this.Label_Contributors.AutoSize = true;
            this.Label_Contributors.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.Label_Contributors.Location = new System.Drawing.Point(9, 60);
            this.Label_Contributors.Name = "Label_Contributors";
            this.Label_Contributors.Size = new System.Drawing.Size(388, 50);
            this.Label_Contributors.TabIndex = 35;
            this.Label_Contributors.Text = "► HyperBE32 - Lead programmer and designer\r\n► SuperSonic16 - GameBanana API Handl" +
    "er\r\n";
            // 
            // Title_Contributors
            // 
            this.Title_Contributors.AutoSize = true;
            this.Title_Contributors.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.Title_Contributors.Location = new System.Drawing.Point(6, 6);
            this.Title_Contributors.Name = "Title_Contributors";
            this.Title_Contributors.Size = new System.Drawing.Size(199, 45);
            this.Title_Contributors.TabIndex = 34;
            this.Title_Contributors.Text = "Contributors";
            // 
            // LinkLabel_GPF
            // 
            this.LinkLabel_GPF.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(16)))), ((int)(((byte)(111)))));
            this.LinkLabel_GPF.AutoSize = true;
            this.LinkLabel_GPF.DisabledLinkColor = System.Drawing.SystemColors.GrayText;
            this.LinkLabel_GPF.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.LinkLabel_GPF.LinkColor = System.Drawing.SystemColors.Control;
            this.LinkLabel_GPF.Location = new System.Drawing.Point(30, 208);
            this.LinkLabel_GPF.Name = "LinkLabel_GPF";
            this.LinkLabel_GPF.Size = new System.Drawing.Size(129, 25);
            this.LinkLabel_GPF.TabIndex = 189;
            this.LinkLabel_GPF.TabStop = true;
            this.LinkLabel_GPF.Text = "Gotta Play Fast";
            this.LinkLabel_GPF.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_About_LinkClicked);
            // 
            // LinkLabel_slashiee
            // 
            this.LinkLabel_slashiee.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(16)))), ((int)(((byte)(111)))));
            this.LinkLabel_slashiee.AutoSize = true;
            this.LinkLabel_slashiee.DisabledLinkColor = System.Drawing.SystemColors.GrayText;
            this.LinkLabel_slashiee.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.LinkLabel_slashiee.LinkColor = System.Drawing.SystemColors.Control;
            this.LinkLabel_slashiee.Location = new System.Drawing.Point(30, 308);
            this.LinkLabel_slashiee.Name = "LinkLabel_slashiee";
            this.LinkLabel_slashiee.Size = new System.Drawing.Size(73, 25);
            this.LinkLabel_slashiee.TabIndex = 192;
            this.LinkLabel_slashiee.TabStop = true;
            this.LinkLabel_slashiee.Text = "slashiee";
            this.LinkLabel_slashiee.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_About_LinkClicked);
            // 
            // Label_Testers
            // 
            this.Label_Testers.AutoSize = true;
            this.Label_Testers.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.Label_Testers.Location = new System.Drawing.Point(9, 183);
            this.Label_Testers.Name = "Label_Testers";
            this.Label_Testers.Size = new System.Drawing.Size(181, 175);
            this.Label_Testers.TabIndex = 39;
            this.Label_Testers.Text = "► Beatz\r\n► Gotta Play Fast\r\n► ChrisHighwind\r\n► CodenameGamma\r\n► Velcomia\r\n► slash" +
    "iee\r\n► Knuxfan24";
            // 
            // Label_Version
            // 
            this.Label_Version.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Version.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Version.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Label_Version.Location = new System.Drawing.Point(2, 982);
            this.Label_Version.Name = "Label_Version";
            this.Label_Version.Size = new System.Drawing.Size(582, 25);
            this.Label_Version.TabIndex = 0;
            this.Label_Version.Text = "Unleash 1.0";
            this.Label_Version.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Rush_Section_Debug
            // 
            this.Rush_Section_Debug.AccentColour = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Rush_Section_Debug.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Rush_Section_Debug.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(45)))));
            this.Rush_Section_Debug.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rush_Section_Debug.Location = new System.Drawing.Point(0, 939);
            this.Rush_Section_Debug.Name = "Rush_Section_Debug";
            this.Rush_Section_Debug.SectionImage = global::Unleash.Properties.Resources.debug_6;
            this.Rush_Section_Debug.SectionText = "Debug";
            this.Rush_Section_Debug.SelectedSection = false;
            this.Rush_Section_Debug.Size = new System.Drawing.Size(250, 35);
            this.Rush_Section_Debug.TabIndex = 25;
            this.Rush_Section_Debug.TextColour = System.Drawing.SystemColors.Control;
            this.Rush_Section_Debug.Visible = false;
            this.Rush_Section_Debug.Click += new System.EventHandler(this.Rush_Section_Click);
            // 
            // Rush_Section_Updates
            // 
            this.Rush_Section_Updates.AccentColour = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Rush_Section_Updates.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Rush_Section_Updates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(45)))));
            this.Rush_Section_Updates.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rush_Section_Updates.Location = new System.Drawing.Point(0, 975);
            this.Rush_Section_Updates.Name = "Rush_Section_Updates";
            this.Rush_Section_Updates.SectionImage = global::Unleash.Properties.Resources.Update_4;
            this.Rush_Section_Updates.SectionText = "Updates";
            this.Rush_Section_Updates.SelectedSection = false;
            this.Rush_Section_Updates.Size = new System.Drawing.Size(250, 35);
            this.Rush_Section_Updates.TabIndex = 28;
            this.Rush_Section_Updates.TextColour = System.Drawing.SystemColors.Control;
            this.Rush_Section_Updates.Click += new System.EventHandler(this.Rush_Section_Click);
            // 
            // Rush_Section_Settings
            // 
            this.Rush_Section_Settings.AccentColour = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Rush_Section_Settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Rush_Section_Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(45)))));
            this.Rush_Section_Settings.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rush_Section_Settings.Location = new System.Drawing.Point(0, 1011);
            this.Rush_Section_Settings.Name = "Rush_Section_Settings";
            this.Rush_Section_Settings.SectionImage = global::Unleash.Properties.Resources.Monaco_Settings_16x;
            this.Rush_Section_Settings.SectionText = "Settings";
            this.Rush_Section_Settings.SelectedSection = false;
            this.Rush_Section_Settings.Size = new System.Drawing.Size(250, 35);
            this.Rush_Section_Settings.TabIndex = 23;
            this.Rush_Section_Settings.TextColour = System.Drawing.SystemColors.Control;
            this.Rush_Section_Settings.Click += new System.EventHandler(this.Rush_Section_Click);
            // 
            // Rush_Section_About
            // 
            this.Rush_Section_About.AccentColour = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Rush_Section_About.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Rush_Section_About.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(45)))));
            this.Rush_Section_About.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rush_Section_About.Location = new System.Drawing.Point(0, 1047);
            this.Rush_Section_About.Name = "Rush_Section_About";
            this.Rush_Section_About.SectionImage = global::Unleash.Properties.Resources.InformationSymbol_16x;
            this.Rush_Section_About.SectionText = "About";
            this.Rush_Section_About.SelectedSection = false;
            this.Rush_Section_About.Size = new System.Drawing.Size(250, 35);
            this.Rush_Section_About.TabIndex = 20;
            this.Rush_Section_About.TextColour = System.Drawing.SystemColors.Control;
            this.Rush_Section_About.Click += new System.EventHandler(this.Rush_Section_Click);
            // 
            // Rush_Section_Emulator
            // 
            this.Rush_Section_Emulator.AccentColour = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Rush_Section_Emulator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(45)))));
            this.Rush_Section_Emulator.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rush_Section_Emulator.Location = new System.Drawing.Point(0, 99);
            this.Rush_Section_Emulator.Name = "Rush_Section_Emulator";
            this.Rush_Section_Emulator.SectionImage = global::Unleash.Properties.Resources.Disc;
            this.Rush_Section_Emulator.SectionText = "Emulator";
            this.Rush_Section_Emulator.SelectedSection = false;
            this.Rush_Section_Emulator.Size = new System.Drawing.Size(250, 35);
            this.Rush_Section_Emulator.TabIndex = 19;
            this.Rush_Section_Emulator.TextColour = System.Drawing.SystemColors.Control;
            this.Rush_Section_Emulator.Click += new System.EventHandler(this.Rush_Section_Click);
            // 
            // Rush_Section_Mods
            // 
            this.Rush_Section_Mods.AccentColour = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Rush_Section_Mods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(45)))));
            this.Rush_Section_Mods.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rush_Section_Mods.Location = new System.Drawing.Point(0, 63);
            this.Rush_Section_Mods.Name = "Rush_Section_Mods";
            this.Rush_Section_Mods.SectionImage = global::Unleash.Properties.Resources.ConfigurationFile_16x;
            this.Rush_Section_Mods.SectionText = "Mods";
            this.Rush_Section_Mods.SelectedSection = true;
            this.Rush_Section_Mods.Size = new System.Drawing.Size(250, 35);
            this.Rush_Section_Mods.TabIndex = 18;
            this.Rush_Section_Mods.TextColour = System.Drawing.SystemColors.Control;
            this.Rush_Section_Mods.Click += new System.EventHandler(this.Rush_Section_Click);
            // 
            // Container_Rush
            // 
            this.Container_Rush.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Container_Rush.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Container_Rush.IsSplitterFixed = true;
            this.Container_Rush.LeftPanelMinimumSize = 250;
            this.Container_Rush.Location = new System.Drawing.Point(0, 0);
            this.Container_Rush.Name = "Container_Rush";
            this.Container_Rush.SideColour = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Container_Rush.Size = new System.Drawing.Size(849, 1083);
            this.Container_Rush.SplitterDistance = 250;
            this.Container_Rush.TabIndex = 17;
            this.Container_Rush.Title = "Mods";
            // 
            // RushInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Controls.Add(this.Panel_MainControls);
            this.Controls.Add(this.TabControl_Rush);
            this.Controls.Add(this.Label_Status);
            this.Controls.Add(this.StatusStrip_Main);
            this.Controls.Add(this.Rush_Section_Debug);
            this.Controls.Add(this.Rush_Section_Updates);
            this.Controls.Add(this.Rush_Section_Settings);
            this.Controls.Add(this.Rush_Section_About);
            this.Controls.Add(this.Rush_Section_Emulator);
            this.Controls.Add(this.Rush_Section_Mods);
            this.Controls.Add(this.Container_Rush);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "RushInterface";
            this.Size = new System.Drawing.Size(849, 1105);
            this.Load += new System.EventHandler(this.RushInterface_Load);
            this.Resize += new System.EventHandler(this.RushInterface_Resize);
            this.Panel_MainControls.ResumeLayout(false);
            this.SplitContainer_MainControls.Panel1.ResumeLayout(false);
            this.SplitContainer_MainControls.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer_MainControls)).EndInit();
            this.SplitContainer_MainControls.ResumeLayout(false);
            this.TabControl_Rush.ResumeLayout(false);
            this.Tab_Section_Mods.ResumeLayout(false);
            this.SplitContainer_ModsControls.Panel1.ResumeLayout(false);
            this.SplitContainer_ModsControls.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer_ModsControls)).EndInit();
            this.SplitContainer_ModsControls.ResumeLayout(false);
            this.Panel_ModBackdrop.ResumeLayout(false);
            this.Tab_Section_Emulator.ResumeLayout(false);
            this.Tab_Section_Emulator.PerformLayout();
            this.Panel_Xenia_Options.ResumeLayout(false);
            this.Panel_Xenia_Options.PerformLayout();
            this.Panel_Xenia_API_Options.ResumeLayout(false);
            this.Panel_Xenia_API_Options.PerformLayout();
            this.lol.Panel1.ResumeLayout(false);
            this.lol.Panel1.PerformLayout();
            this.lol.Panel2.ResumeLayout(false);
            this.lol.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lol)).EndInit();
            this.lol.ResumeLayout(false);
            this.Tab_Section_Debug.ResumeLayout(false);
            this.Panel_DebugControls.ResumeLayout(false);
            this.Tab_Section_Updates.ResumeLayout(false);
            this.Tab_Section_Updates.PerformLayout();
            this.SplitContainer_ModUpdate.Panel1.ResumeLayout(false);
            this.SplitContainer_ModUpdate.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer_ModUpdate)).EndInit();
            this.SplitContainer_ModUpdate.ResumeLayout(false);
            this.Panel_ModUpdateBackdrop.ResumeLayout(false);
            this.Panel_ModInfoBackdrop.ResumeLayout(false);
            this.Tab_Section_Settings.ResumeLayout(false);
            this.Tab_Section_Settings.PerformLayout();
            this.Tab_Section_About.ResumeLayout(false);
            this.Tab_Section_About.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private UserContainer Container_Rush;
        private SectionButton Rush_Section_About;
        private SectionButton Rush_Section_Emulator;
        private SectionButton Rush_Section_Mods;
        private SectionButton Rush_Section_Settings;
        private System.Windows.Forms.TabPage Tab_Section_Mods;
        private System.Windows.Forms.TabPage Tab_Section_Emulator;
        private WindowsColourPicker WindowsColourPicker_AccentColour;
        private System.Windows.Forms.TextBox TextBox_GameDirectory;
        private System.Windows.Forms.Label Label_Title_Appearance;
        private System.Windows.Forms.CheckBox CheckBox_HighContrastText;
        private System.Windows.Forms.Label Label_Title_General;
        private System.Windows.Forms.Label Label_Subtitle_AccentColour;
        private System.Windows.Forms.Label Label_GameExecutable;
        private System.Windows.Forms.Panel Panel_Settings_UICleanSpace;
        private System.Windows.Forms.Label Label_WindowsColours;
        private System.Windows.Forms.Button Button_GameDirectory;
        private System.Windows.Forms.Label Label_Subtitle_Appearance_Options;
        private System.Windows.Forms.CheckBox CheckBox_AutoColour;
        private System.Windows.Forms.Label Label_Description_GameExecutable;
        private System.Windows.Forms.Button Button_ColourPicker_Preview;
        private System.Windows.Forms.Label Label_Subtitle_Settings_Paths;
        private System.Windows.Forms.Button Button_ColourPicker_Default;
        private System.Windows.Forms.Button Button_ModsDirectory;
        private SectionButton Section_Appearance_ColourPicker;
        private System.Windows.Forms.TextBox TextBox_ModsDirectory;
        private System.Windows.Forms.Label Label_ModsDirectory;
        private System.Windows.Forms.TabPage Tab_Section_Settings;
        private System.Windows.Forms.TabPage Tab_Section_About;
        private UnifyTabControl TabControl_Rush;
        private System.Windows.Forms.TabPage Tab_Section_Debug;
        private SectionButton Rush_Section_Debug;
        private System.Windows.Forms.ListBox ListBox_Debug;
        private System.Windows.Forms.Panel Panel_DebugControls;
        private SectionButton SectionButton_ClearLog;
        private System.Windows.Forms.Panel Panel_ModBackdrop;
        private System.Windows.Forms.ListView ListView_ModsList;
        private System.Windows.Forms.ColumnHeader Column_ModsList_Title;
        private System.Windows.Forms.ColumnHeader Column_ModsList_Version;
        private System.Windows.Forms.ColumnHeader Column_ModsList_Author;
        private System.Windows.Forms.ColumnHeader Column_ModsList_System;
        private System.Windows.Forms.ColumnHeader Column_ModsList_Blank;
        private System.Windows.Forms.Button Button_Priority;
        private System.Windows.Forms.Button Button_DownerPriority;
        private System.Windows.Forms.Button Button_UpperPriority;
        private System.Windows.Forms.Button Button_Mods_DeselectAll;
        private System.Windows.Forms.Button Button_Mods_SelectAll;
        private SectionButton SectionButton_InstallMods;
        private SectionButton SectionButton_LaunchGame;
        private System.Windows.Forms.StatusStrip StatusStrip_Main;
        private System.Windows.Forms.Label Label_Status;
        private System.Windows.Forms.TextBox TextBox_SaveData;
        private System.Windows.Forms.Label Label_SaveData;
        private System.Windows.Forms.Label Label_Description_EmulatorExecutable;
        private System.Windows.Forms.Button Button_SaveData;
        private System.Windows.Forms.Label Label_Description_SaveData;
        private System.Windows.Forms.Label Label_Subtitle_Emulator_Paths;
        private System.Windows.Forms.Button Button_EmulatorExecutable;
        private System.Windows.Forms.TextBox TextBox_EmulatorExecutable;
        private System.Windows.Forms.Label Label_EmulatorExecutable;
        private SectionButton Rush_Section_Updates;
        private System.Windows.Forms.TabPage Tab_Section_Updates;
        private System.Windows.Forms.Label Label_Version;
        private System.Windows.Forms.Label Label_Optional_SaveData;
        private SectionButton SectionButton_UpdateMods;
        private System.Windows.Forms.SplitContainer SplitContainer_ModUpdate;
        private System.Windows.Forms.Panel Panel_ModUpdateBackdrop;
        private System.Windows.Forms.ProgressBar ProgressBar_ModUpdate;
        private System.Windows.Forms.Panel Panel_ModInfoBackdrop;
        private System.Windows.Forms.Label Label_Title_ModsAndPatches;
        private System.Windows.Forms.Label Label_Description_LaunchEmulator;
        private System.Windows.Forms.CheckBox CheckBox_LaunchEmulator;
        private System.Windows.Forms.Label Label_Subtitle_General_Options;
        private System.Windows.Forms.CheckBox CheckBox_DebugMode;
        private System.Windows.Forms.Button Button_Open_EmulatorExecutable;
        private System.Windows.Forms.Button Button_Open_SaveData;
        private System.Windows.Forms.Button Button_Open_GameDirectory;
        private System.Windows.Forms.Button Button_Open_ModsDirectory;
        private System.Windows.Forms.Label Label_Description_DebugMode;
        private System.Windows.Forms.Label Label_Description_HighContrastText;
        private System.Windows.Forms.Label Label_Description_SaveFileRedirect;
        private System.Windows.Forms.CheckBox CheckBox_SaveFileRedirection;
        private SectionButton SectionButton_SaveChecks;
        private System.Windows.Forms.SplitContainer SplitContainer_ModsControls;
        private System.Windows.Forms.Label Label_Description_Reset;
        private System.Windows.Forms.LinkLabel LinkLabel_Reset;
        private SectionButton SectionButton_RefreshMods;
        private SectionButton SectionButton_CheckForModUpdates;
        private System.Windows.Forms.ListView ListView_ModUpdates;
        private System.Windows.Forms.ColumnHeader Column_Updates_Title;
        private System.Windows.Forms.ListBox ListBox_UpdateLogs;
        private System.Windows.Forms.ColumnHeader Column_Updates_Blank;
        private System.Windows.Forms.Label Label_LastModUpdate;
        private System.Windows.Forms.Label Label_Description_1ClickURLHandler;
        private System.Windows.Forms.LinkLabel LinkLabel_1ClickURLHandler;
        private System.Windows.Forms.Label Label_Warning_ModsDirectoryInvalid;
        private System.Windows.Forms.Label Label_Description_ModsDirectory;
        private System.Windows.Forms.Label Label_Testers;
        private System.Windows.Forms.Label Title_Testers;
        private System.Windows.Forms.Label Label_Contributors;
        private System.Windows.Forms.Label Title_Contributors;
        private System.Windows.Forms.LinkLabel LinkLabel_SuperSonic16;
        private System.Windows.Forms.LinkLabel LinkLabel_HyperBE32;
        private System.Windows.Forms.Label Label_Description_UninstallOnLaunch;
        private System.Windows.Forms.CheckBox CheckBox_UninstallOnLaunch;
        private System.Windows.Forms.LinkLabel LinkLabel_Snapshot;
        private System.Windows.Forms.Label Label_Description_Snapshot;
        private System.Windows.Forms.Panel Panel_MainControls;
        private System.Windows.Forms.SplitContainer SplitContainer_MainControls;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBox_Arguments;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel LinkLabel_Beatz;
        private System.Windows.Forms.LinkLabel LinkLabel_GPF;
        private System.Windows.Forms.LinkLabel LinkLabel_Velcomia;
        private System.Windows.Forms.LinkLabel LinkLabel_CodenameGamma;
        private System.Windows.Forms.LinkLabel LinkLabel_slashiee;
        private System.Windows.Forms.ColumnHeader Column_ModsList_Merge;
        private System.Windows.Forms.LinkLabel LinkLabel_Knuxfan24;
        private System.Windows.Forms.Panel Panel_Xenia_Options;
        private System.Windows.Forms.Label Label_Subtitle_Emulator_Options;
        private System.Windows.Forms.ComboBox ComboBox_API;
        private System.Windows.Forms.Label Label_API;
        private System.Windows.Forms.Label Label_Description_API;
        private System.Windows.Forms.Panel Panel_Xenia_API_Options;
        private System.Windows.Forms.Label Label_UserLanguage;
        private System.Windows.Forms.ComboBox ComboBox_UserLanguage;
        private System.Windows.Forms.Label Label_Description_DiscordRPC;
        private System.Windows.Forms.Label Label_Description_Fullscreen;
        private System.Windows.Forms.SplitContainer lol;
        private System.Windows.Forms.Label Label_Width;
        private System.Windows.Forms.ComboBox ComboBox_Width;
        private System.Windows.Forms.Label Label_Description_Width;
        private System.Windows.Forms.ComboBox ComboBox_Height;
        private System.Windows.Forms.Label Label_Description_Height;
        private System.Windows.Forms.Label Label_Height;
        private System.Windows.Forms.Label Label_Description_UserLanguage;
        private System.Windows.Forms.Label Label_Description_Gamma;
        private System.Windows.Forms.CheckBox CheckBox_Xenia_VerticalSync;
        private System.Windows.Forms.Label Label_Description_VerticalSync;
        private System.Windows.Forms.CheckBox CheckBox_Xenia_DiscordRPC;
        private System.Windows.Forms.CheckBox CheckBox_Xenia_Gamma;
        private System.Windows.Forms.CheckBox CheckBox_Xenia_Fullscreen;
    }
}