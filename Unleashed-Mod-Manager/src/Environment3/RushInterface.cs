﻿using System;
using System.IO;
using System.Net;
using System.Linq;
using System.Drawing;
using Unleash.Patcher;
using Unleash.Dialogs;
using Microsoft.Win32;
using Unleash.Messenger;
using System.Management;
using Unleash.Networking;
using System.Diagnostics;
using Unleash.Serialisers;
using System.Windows.Forms;
using System.Configuration;
using System.ComponentModel;
using Unleash.Globalisation;
using System.IO.Compression;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.VisualBasic.Devices;

// Unleashed Mod Manager is licensed under the MIT License:
/*
 * MIT License

 * Copyright (c) 2020 HyperBE32
 * Copyright (c) 2017 thesupersonic16

 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:

 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.

 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */

namespace Unleash.Environment3
{
    public partial class RushInterface : UserControl
    {
        public static bool _debug = false;
        private bool _isPathInvalid = false;
        private static string protocol = "unleashedmm";
        private bool _useBackupServer = false;

        public RushInterface() {
            InitializeComponent(); // Designer support

            // Prevents actions being performed in UnleashEnvironment's design time.
            if (!DesignMode) {
                // Begin first time setup
                if (Properties.Settings.Default.General_FirstLaunch &&
                    Properties.Settings.Default.Path_ModsDirectory == string.Empty)
                        new UnifySetup().ShowDialog();

                LoadSettings(); // Load user settings

                // Check registry for 1-Click Install registry key
                try { CheckRegistry(); } catch { LinkLabel_1ClickURLHandler.Text = "Reinstall 1-Click URL Handler"; }

                Label_Version.Text = Program.VersionNumber; // Sets the version string in the About section
                Properties.Settings.Default.SettingsSaving += Settings_SettingsSaving; // Subscribe to event for SettingsSaving
                TabControl_Rush.Height += 23; // Increase height on load to accommodate for lack of tabs in the section controller

                // Force splitter widths - because WinForms is dumb and ignores it at design time
                SplitContainer_ModsControls.SplitterWidth = SplitContainer_MainControls.SplitterWidth = 1;
                SplitContainer_ModUpdate.SplitterWidth = 2;
#if DEBUG
                // If the application is a debug build, force debug mode on
                Properties.Settings.Default.General_Debug = _debug = true;
                Properties.Settings.Default.Save();
#endif
            }
        }

        public string Status {
            get { return Label_Status.Text; }
            set { Label_Status.Text = value; }
        }

        /// <summary>
        /// Performs actions on launch.
        /// </summary>
        private void RushInterface_Load(object sender, EventArgs e) {
            RefreshLists(); // Refresh mods list
            if (Paths.CheckFileLegitimacy(Properties.Settings.Default.Path_GameDirectory) && 
                Properties.Settings.Default.General_AutoUninstall) UninstallThread(); // Uninstall everything
        }

        /// <summary>
        /// If 'Properties.Settings.Default.Save()' is called, the 'LoadSettings()' function will be executed.
        /// </summary>
        private void Settings_SettingsSaving(object sender, CancelEventArgs e) { LoadSettings(); }

        /// <summary>
        /// Loads all user settings.
        /// </summary>
        private void LoadSettings()
        {
            if (!DesignMode) {

                #region Restore label strings
                Label_LastModUpdate.Text      = Literal.Date("Last checked", Properties.Settings.Default.General_LastModUpdate);

                if (Properties.Settings.Default.General_Priority)
                    Button_Priority.Text = "Priority: Bottom to Top";
                else
                    Button_Priority.Text = "Priority: Top to Bottom";
                #endregion

                #region Restore text fields
                _isPathInvalid = false;
                TextBox_GameDirectory.Text      = Properties.Settings.Default.Path_GameDirectory;
                TextBox_ModsDirectory.Text      = Properties.Settings.Default.Path_ModsDirectory;
                TextBox_EmulatorExecutable.Text = Properties.Settings.Default.Path_EmulatorDirectory;
                TextBox_SaveData.Text           = Properties.Settings.Default.Path_SaveData;
                TextBox_Arguments.Text          = Properties.Settings.Default.Emulator_Arguments;

                if (Properties.Settings.Default.Path_ModsDirectory != string.Empty && Properties.Settings.Default.Path_GameDirectory != string.Empty) {
                    if (Literal.IsPathSubdirectory(Path.GetDirectoryName(Properties.Settings.Default.Path_GameDirectory), Properties.Settings.Default.Path_ModsDirectory) ||
                        Path.GetDirectoryName(Properties.Settings.Default.Path_GameDirectory) == Properties.Settings.Default.Path_ModsDirectory) {
                            // If the mods directory is inside the game directory, warn the user
                            Label_Warning_ModsDirectoryInvalid.ForeColor = Color.Tomato;
                            _isPathInvalid = true;
                    }
                    else
                        Label_Warning_ModsDirectoryInvalid.ForeColor = SystemColors.ControlDark;

                    if (Literal.IsPathSubdirectory(Properties.Settings.Default.Path_ModsDirectory, Path.GetDirectoryName(Properties.Settings.Default.Path_GameDirectory)) ||
                        Properties.Settings.Default.Path_ModsDirectory == Path.GetDirectoryName(Properties.Settings.Default.Path_GameDirectory)) {
                            // If the mods directory is inside the game directory, warn the user
                            Label_Warning_ModsDirectoryInvalid.ForeColor = Color.Tomato;
                            _isPathInvalid = true;
                    }
                    else
                        Label_Warning_ModsDirectoryInvalid.ForeColor = SystemColors.ControlDark;
                }
                #endregion

                #region Restore combo box states
                ComboBox_API.SelectedIndex = Properties.Settings.Default.Emulator_API;
                ComboBox_UserLanguage.SelectedIndex = Properties.Settings.Default.Emulator_UserLanguage;
                ComboBox_Width.SelectedIndex = Properties.Settings.Default.Emulator_Width;
                ComboBox_Height.SelectedIndex = Properties.Settings.Default.Emulator_Height;
                #endregion

                #region Restore check box states
                CheckBox_AutoColour.Checked         = Properties.Settings.Default.General_AutoColour;
                CheckBox_Xenia_VerticalSync.Checked = Properties.Settings.Default.Emulator_VerticalSync;
                CheckBox_Xenia_Gamma.Checked        = Properties.Settings.Default.Emulator_Gamma;
                CheckBox_Xenia_Fullscreen.Checked   = Properties.Settings.Default.Emulator_Fullscreen;
                CheckBox_Xenia_DiscordRPC.Checked   = Properties.Settings.Default.Emulator_DiscordRPC;
                CheckBox_UninstallOnLaunch.Checked  = Properties.Settings.Default.General_AutoUninstall;

                if (CheckBox_HighContrastText.Checked = Properties.Settings.Default.General_HighContrastText)
                    Label_Status.ForeColor = SystemColors.ControlText;
                else
                    Label_Status.ForeColor = SystemColors.Control;

                if (CheckBox_DebugMode.Checked = Rush_Section_Debug.Visible = _debug = Properties.Settings.Default.General_Debug)
                    Console.SetOut(new ListBoxWriter(ListBox_Debug));

                if (CheckBox_LaunchEmulator.Checked = Properties.Settings.Default.General_LaunchEmulator) {
                    SectionButton_InstallMods.SectionText = "Save, install content and launch Unleashed";
                    SectionButton_InstallMods.Refresh();
                } else {
                    SectionButton_InstallMods.SectionText = "Save and install content";
                    SectionButton_InstallMods.Refresh();
                }

                if (CheckBox_SaveFileRedirection.Checked = Properties.Settings.Default.General_SaveFileRedirection) {
                    // Set text colour to Control
                    Label_SaveData.ForeColor = SystemColors.Control;

                    // Set text colour to ControlDark
                    Label_Optional_SaveData.ForeColor =
                    Label_Description_SaveData.ForeColor =
                    SystemColors.ControlDark;

                    // Set controls enabled state
                    TextBox_SaveData.Enabled =
                    Button_SaveData.Enabled =
                    Button_Open_SaveData.Enabled =
                    true;
                } else {
                    // Set text colour to GrayText (spelt the wrong way)
                    Label_SaveData.ForeColor =
                    Label_Optional_SaveData.ForeColor =
                    Label_Description_SaveData.ForeColor =
                    SystemColors.GrayText;

                    // Set controls enabled state
                    TextBox_SaveData.Enabled =
                    Button_SaveData.Enabled =
                    Button_Open_SaveData.Enabled =
                    false;
                }
                #endregion

                #region Set controls to AccentColour setting
                Button_ColourPicker_Preview.FlatAppearance.MouseOverBackColor =
                Button_ColourPicker_Preview.FlatAppearance.MouseDownBackColor =
                Rush_Section_Mods.AccentColour =
                Rush_Section_Settings.AccentColour =
                Button_ColourPicker_Preview.BackColor =
                StatusStrip_Main.BackColor =
                Label_Status.BackColor =
                Properties.Settings.Default.General_AccentColour;
                #endregion

                #region Set controls depending on emulator
                if (Literal.Emulator(Properties.Settings.Default.Path_GameDirectory) == "Xenia")
                {
                    Panel_Xenia_Options.Visible = true;
                    Panel_Xenia_API_Options.Visible = Properties.Settings.Default.Emulator_API != 2 ? true : false;

                    // I am in a considerable amount of pain.
                    if (Properties.Settings.Default.Emulator_API != 0)
                    {
                        ComboBox_Width.Enabled = false;
                        ComboBox_Height.Enabled = false;
                        Label_Width.ForeColor = SystemColors.GrayText;
                        Label_Height.ForeColor = SystemColors.GrayText;
                        Label_Description_Width.ForeColor = SystemColors.GrayText;
                        Label_Description_Height.ForeColor = SystemColors.GrayText;
                    }
                    else
                    {
                        ComboBox_Width.Enabled = true;
                        ComboBox_Height.Enabled = true;
                        Label_Width.ForeColor = SystemColors.Control;
                        Label_Height.ForeColor = SystemColors.Control;
                        Label_Description_Width.ForeColor = SystemColors.ControlDark;
                        Label_Description_Height.ForeColor = SystemColors.ControlDark;
                    }
                }
                else if (Literal.Emulator(Properties.Settings.Default.Path_GameDirectory) == "RPCS3")
                {
                    Panel_Xenia_Options.Visible = false;
                }
                #endregion

            }
        }

        /// <summary>
        /// Re-deserialises the mods, then checks them - in turn, refreshing the list.
        /// </summary>
        private void RefreshLists() {
            DeserialiseMods(); // Refresh mods list
            CheckDeserialisedMods(); // Check saved mods
        }

        /// <summary>
        /// Removes the selected highlight for all SectionButton controls.
        /// </summary>
        private void SectionButton_DeselectAll() {
            foreach (Control control in Controls)
                if (control is SectionButton) ((SectionButton)control).SelectedSection = false;
        }

        /// <summary>
        /// Takes click control from all section buttons and switches the navigator control.
        /// </summary>
        private void Rush_Section_Click(object sender, EventArgs e) {
            SectionButton_DeselectAll();
            if          (sender == Rush_Section_Mods) TabControl_Rush.SelectedTab = Tab_Section_Mods;     // Set tab to Mods
            else if (sender == Rush_Section_Emulator) TabControl_Rush.SelectedTab = Tab_Section_Emulator; // Set tab to Emulator
            else if (sender == Rush_Section_Settings) TabControl_Rush.SelectedTab = Tab_Section_Settings; // Set tab to Settings
            else if    (sender == Rush_Section_Debug) TabControl_Rush.SelectedTab = Tab_Section_Debug;    // Set tab to Debug
            else if  (sender == Rush_Section_Updates) TabControl_Rush.SelectedTab = Tab_Section_Updates;  // Set tab to Updates
            else if    (sender == Rush_Section_About) TabControl_Rush.SelectedTab = Tab_Section_About;    // Set tab to About
            ((SectionButton)sender).SelectedSection = true;
            Container_Rush.Title = ((SectionButton)sender).SectionText;
        }

        /// <summary>
        /// Defines what browser should be used by sender.
        /// </summary>
        private void Button_Browse_Click(object sender, EventArgs e) {
            if (sender == Button_ModsDirectory) {
                // Browse for mods directory
                string browseMods = RequestPath.ModsDirectory();

                if (browseMods != string.Empty) {
                    Properties.Settings.Default.Path_ModsDirectory = TextBox_ModsDirectory.Text = browseMods;
                    Properties.Settings.Default.Save();
                }
            } else if (sender == Button_GameDirectory) {
                // Browse for game executables
                string gameExecutable = RequestPath.GameExecutable();

                if (gameExecutable != string.Empty) {
                    Properties.Settings.Default.Path_GameDirectory = TextBox_GameDirectory.Text = gameExecutable;
                    Properties.Settings.Default.Save();
                }
            } else if (sender == Button_EmulatorExecutable) {
                // Browse for emulator executables
                string emulatorExecutable = RequestPath.EmulatorExecutable();

                if (emulatorExecutable != string.Empty) {
                    Properties.Settings.Default.Path_EmulatorDirectory = TextBox_EmulatorExecutable.Text = emulatorExecutable;
                    Properties.Settings.Default.Save();
                }
            } else if (sender == Button_SaveData) {
                // Browse for save data
                string saveData = RequestPath.SaveData();

                if (saveData != string.Empty) {
                    Properties.Settings.Default.Path_SaveData = TextBox_SaveData.Text = saveData;
                    Properties.Settings.Default.Save();
                }
            }
            RefreshLists();
        }

        /// <summary>
        /// Checks if a button has been clicked on the WindowsColourPicker user control.
        /// </summary>
        private void WindowsColourPicker_AccentColour_ButtonClick(object sender, EventArgs e) {
            Properties.Settings.Default.General_AutoColour = false;
            Properties.Settings.Default.General_AccentColour = ((Button)sender).BackColor;
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Perform actions when the selected tab is changed.
        /// </summary>
        private void TabControl_Rush_SelectedIndexChanged(object sender, EventArgs e) {
            TabControl_Rush.SelectedTab.VerticalScroll.Value = 0;
            RefreshColumnSize();

            if ((string)TabControl_Rush.SelectedTab.Tag == "HideControls") {
                if (Panel_MainControls.Visible) {
                    Panel_MainControls.Visible = false;
                    TabControl_Rush.Height += 40;
                }
            } else {
                if (!Panel_MainControls.Visible) {
                    Panel_MainControls.Visible = true;
                    TabControl_Rush.Height -= 40;
                }
            }

            // Clear mod updating UI to delist any mods that may be changed later
            if (TabControl_Rush.SelectedTab != Tab_Section_Updates) {
                ListBox_UpdateLogs.Items.Clear();
                ListView_ModUpdates.Items.Clear();
            }
        }

        /// <summary>
        /// Deserialises 'mod.ini' for each iterated mod and checks for updates.
        /// </summary>
        /// <param name="searchByMod">File path to another mod's INI to ensure it's searching for the correct mod.</param>
        private async Task CheckForModUpdates(string searchByMod) {
            if (Properties.Settings.Default.Path_ModsDirectory != string.Empty &&
                Directory.Exists(Properties.Settings.Default.Path_ModsDirectory)) {
                    ListView_ModUpdates.Items.Clear();
                    ListBox_UpdateLogs.Items.Clear();
                    foreach (string mod in Directory.GetFiles(Properties.Settings.Default.Path_ModsDirectory, "mod.ini", SearchOption.AllDirectories)) {
                        // Block controls to ensure the list isn't added to
                        SectionButton_CheckForModUpdates.Enabled = false;

                        // Deserialise INI
                        string title     = INI.DeserialiseKey("Title", mod),
                               version   = INI.DeserialiseKey("Version", mod),
                               metadata  = INI.DeserialiseKey("Metadata", mod),
                               data      = INI.DeserialiseKey("Data", mod),
                               versionDL = string.Empty;

                        if (metadata.Length != 0) {
                            string config = await Client.RequestString(metadata);
                            if (config.Length != 0) {
                                string[] configLines = config.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

                                // Manually deserialise downloaded string
                                foreach (string metadataLine in configLines) {
                                    string metadataEntry = string.Empty;
                                    if (metadataLine.StartsWith("Version")) {
                                        metadataEntry = metadataLine.Substring(metadataLine.IndexOf("=") + 2);
                                        metadataEntry = metadataEntry.Remove(metadataEntry.Length - 1);
                                        versionDL = metadataEntry;
                                    }
                                    if (metadataLine.StartsWith("Data")) {
                                        metadataEntry = metadataLine.Substring(metadataLine.IndexOf("=") + 2);
                                        metadataEntry = metadataEntry.Remove(metadataEntry.Length - 1);
                                        if (data != metadataEntry) data = metadataEntry;
                                    }
                                }

                                if (versionDL != version) {
                                    // Mod needs updating - add to list
                                    ListViewItem update = new ListViewItem(new[] { title, string.Empty, mod });
                                    ListView_ModUpdates.Items.Add(update);

                                    // If the paths are identical, then the mod shall be checked
                                    update.Checked = mod == searchByMod;
                                }
                            }
                        }

                        //Feedback
                        SectionButton_CheckForModUpdates.Enabled = true;
                    }

                    // If no mods are added to the updates list - presumably, all of them are up to date
                    if (ListView_ModUpdates.Items.Count == 0)
                        UnifyMessenger.UnifyMessage.ShowDialog("All mods are up to date! Check back later...",
                                                                "Unleashed Mod Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                // Browse for mods directory
                string browseMods = RequestPath.ModsDirectory();

                if (browseMods != string.Empty) {
                    Properties.Settings.Default.Path_ModsDirectory = TextBox_ModsDirectory.Text = browseMods;
                    Properties.Settings.Default.Save();
                    await CheckForModUpdates(string.Empty); // Check all mods in the mods list for updates with new path
                } else return;
            }
        }

        /// <summary>
        /// Updates settings if sender's check state is changed.
        /// </summary>
        private void CheckBox_Settings_CheckedChanged(object sender, EventArgs e) {
            if (sender == CheckBox_AutoColour) {
                if (CheckBox_AutoColour.Checked) {
                    int RegistryColour = (int)Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\DWM", "ColorizationColor", null);
                    Properties.Settings.Default.General_AccentColour = Color.FromArgb(RegistryColour);
                }
                Properties.Settings.Default.General_AutoColour = ((CheckBox)sender).Checked;
            } else if (sender == CheckBox_HighContrastText)   Properties.Settings.Default.General_HighContrastText     = ((CheckBox)sender).Checked;
            else if (sender == CheckBox_UninstallOnLaunch)    Properties.Settings.Default.General_AutoUninstall    = ((CheckBox)sender).Checked;
            else if (sender == CheckBox_DebugMode)            Properties.Settings.Default.General_Debug                = ((CheckBox)sender).Checked;
            else if (sender == CheckBox_SaveFileRedirection)  Properties.Settings.Default.General_SaveFileRedirection  = ((CheckBox)sender).Checked;
            else if (sender == CheckBox_LaunchEmulator)       Properties.Settings.Default.General_LaunchEmulator       = ((CheckBox)sender).Checked;
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Changes colour of the colour picker button if the preview button is being hovered over.
        /// </summary>
        private void Button_ColourPicker_Preview_MouseEnter(object sender, EventArgs e) { Section_Appearance_ColourPicker.BackColor = Color.FromArgb(48, 48, 51); }

        /// <summary>
        /// Changes colour of the colour picker button if the preview button is no longer being hovered over.
        /// </summary>
        private void Button_ColourPicker_Preview_MouseLeave(object sender, EventArgs e) { Section_Appearance_ColourPicker.BackColor = Color.FromArgb(42, 42, 45); }

        /// <summary>
        /// Changes colour of the colour picker button if the preview button is clicked.
        /// </summary>
        private void Button_ColourPicker_Preview_MouseDown(object sender, MouseEventArgs e) { Section_Appearance_ColourPicker.BackColor = Color.FromArgb(58, 58, 61); }

        /// <summary>
        /// Changes colour of the colour picker button if the preview button is released.
        /// </summary>
        private void Button_ColourPicker_Preview_MouseUp(object sender, MouseEventArgs e) {
            Section_Appearance_ColourPicker.BackColor = Color.FromArgb(48, 48, 51);
            Section_Appearance_ColourPicker_Click(sender, e);
        }

        /// <summary>
        /// Opens the colour picker to define a new accent colour.
        /// </summary>
        private void Section_Appearance_ColourPicker_Click(object sender, EventArgs e) {
            ColorDialog accentPicker = new ColorDialog {
                FullOpen = true,
                Color = Properties.Settings.Default.General_AccentColour
            };

            if (accentPicker.ShowDialog() == DialogResult.OK) {
                Properties.Settings.Default.General_AutoColour = false;
                Properties.Settings.Default.General_AccentColour = accentPicker.Color;
                Properties.Settings.Default.Save();
            }
        }

        /// <summary>
        /// Resets the accent colour to default.
        /// </summary>
        private void Button_ColourPicker_Default_Click(object sender, EventArgs e) {
            Properties.Settings.Default.General_AutoColour = false;
            Properties.Settings.Default.General_AccentColour = Color.FromArgb(100, 16, 111);
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Clears the debug log.
        /// </summary>
        private void SectionButton_ClearLog_Click(object sender, EventArgs e) { ListBox_Debug.Items.Clear(); }

        /// <summary>
        /// Create right-click context menu for the lists at runtime.
        /// Only called when an item is selected.
        /// </summary>
        private void ListView_MouseClick(object sender, MouseEventArgs e) {
            // Perform if the function was called with the right mouse button
            if (e.Button == MouseButtons.Right) {
                // Create the dark context menu
                ContextMenuDark menuDark = new ContextMenuDark();

                // Get item by mouse focus
                if (sender == ListView_ModsList) {
                    if (ListView_ModsList.FocusedItem.Bounds.Contains(e.Location)) {
                        menuDark.Items.Clear();
                        menuDark.Items.AddRange(new ToolStripMenuItem[] {
                            new ToolStripMenuItem("Mod Information",   Properties.Resources.InformationSymbol_16x, ContextMenu_ModMenu_Items_Click),
                            new ToolStripMenuItem("Open Folder",       Properties.Resources.Open_grey_16x,         ContextMenu_ModMenu_Items_Click),
                            new ToolStripMenuItem("Check for Updates", Properties.Resources.Update_4,              ContextMenu_ModMenu_Items_Click)
                        });
                        menuDark.Items.Add(new ToolStripSeparator());
                        menuDark.Items.AddRange(new ToolStripMenuItem[] {
                            new ToolStripMenuItem("Create Mod",        Properties.Resources.NewFileCollection_16x, ContextMenu_ModMenu_Items_Click),
                            new ToolStripMenuItem("Edit Mod",          Properties.Resources.EditPage_16x,          ContextMenu_ModMenu_Items_Click),
                            new ToolStripMenuItem("Delete Mod",        Properties.Resources.Cancel_16x,            ContextMenu_ModMenu_Items_Click)
                        });
                        menuDark.Show(Cursor.Position);
                    }
                }
            }
        }

        /// <summary>
        /// Event handler for the right-click menu items by index.
        /// </summary>
        private async void ContextMenu_ModMenu_Items_Click(object sender, EventArgs e) {
            switch (((ToolStripMenuItem)sender).ToString()) {
                case "Mod Information":
                    new ModInfo(ListView_ModsList.FocusedItem.SubItems[6].Text).ShowDialog();
                    break;
                case "Open Folder":
                    try { Process.Start(Path.GetDirectoryName(ListView_ModsList.FocusedItem.SubItems[6].Text)); }
                    catch {
                        UnifyMessenger.UnifyMessage.ShowDialog("Unable to locate the selected mod. It may have been removed from the mods directory. Removing from list...",
                                                               "Unable to find mod...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        RefreshLists(); // Refresh mods list
                    }
                    break;
                case "Check for Updates":
                    // Navigate to Updates section
                    SectionButton_DeselectAll();
                    Rush_Section_Updates.SelectedSection = true;
                    TabControl_Rush.SelectedTab = Tab_Section_Updates;

                    // Check for updates...
                    await CheckForModUpdates(ListView_ModsList.FocusedItem.SubItems[6].Text);
                    break;
                case "Create Mod":
                    // Launch Mod Creator
                    new ModCreator(string.Empty, false).ShowDialog();
                    RefreshLists(); // Refresh on Mod Creator exit
                    break;
                case "Edit Mod":
                    // Launch Mod Editor
                    new ModCreator(ListView_ModsList.FocusedItem.SubItems[6].Text, true).ShowDialog();
                    RefreshLists(); // Refresh on Mod Editor exit
                    break;
                case "Delete Mod":
                    try {
                        DialogResult confirmation = UnifyMessenger.UnifyMessage.ShowDialog($"Are you sure you want to delete {ListView_ModsList.FocusedItem.Text}?",
                                                                                           $"Deleting {ListView_ModsList.FocusedItem.Text}...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (confirmation == DialogResult.Yes) {
                            string modPath = Path.GetDirectoryName(ListView_ModsList.FocusedItem.SubItems[6].Text);
                            DirectoryInfo modData = new DirectoryInfo(modPath);

                            if (Directory.Exists(modPath)) {
                                foreach (FileInfo file in modData.GetFiles()) file.Delete();
                                foreach (DirectoryInfo directory in modData.GetDirectories()) directory.Delete(true);
                                Directory.Delete(modPath);
                                RefreshLists();
                            }
                        }
                    } catch {
                        UnifyMessenger.UnifyMessage.ShowDialog("Failed to delete the data for the requested mod.",
                                                               "I/O Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }
        }

        /// <summary>
        /// Renders the items with the default software renderer.
        /// </summary>
        private void ListView_DrawItem(object sender, DrawListViewItemEventArgs e) { e.DrawDefault = true; }

        /// <summary>
        /// Draws the column header in the presented design language by sender.
        /// </summary>
        private void ListView_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e) {
            // Draws the column background colour
            Color theme = Color.FromArgb(35, 35, 38);
            e.Graphics.FillRectangle(new SolidBrush(theme), e.Bounds);
            Point point = new Point(0, 4);
            point.X = e.Bounds.X;

            // Draws the column header by sender
            ColumnHeader column = ((ListView)sender).Columns[e.ColumnIndex];
            e.Graphics.FillRectangle(new SolidBrush(theme), point.X, 0, 2, e.Bounds.Height);
            point.X += column.Width / 2 - TextRenderer.MeasureText(column.Text, ((ListView)sender).Font).Width / 2;
            TextRenderer.DrawText(e.Graphics, column.Text, ((ListView)sender).Font, point, ((ListView)sender).ForeColor);
        }

        /// <summary>
        /// Deserialises 'mod.ini' for each mod in the mods directory.
        /// </summary>
        private void DeserialiseMods() {
            if (Directory.Exists(Properties.Settings.Default.Path_ModsDirectory)) {
                ListView_ModsList.Items.Clear(); // Clears the mods list
                Button_UpperPriority.Enabled = Button_DownerPriority.Enabled = false; // Disable priority buttons to prevent index errors
                foreach (string mod in Directory.GetFiles(Properties.Settings.Default.Path_ModsDirectory, "mod.ini", SearchOption.AllDirectories)) {
                    try {
                        string title = INI.DeserialiseKey("Title", mod); // Deserialise 'Title' key

                        if (title != string.Empty) {
                            //Add mod to list, getting information from its mod.ini file
                            ListViewItem config = new ListViewItem(new[] {
                                                      title,
                                                      INI.DeserialiseKey("Version", mod), // Deserialise 'Version' key
                                                      INI.DeserialiseKey("Author", mod), // Deserialise 'Author' key
                                                      INI.DeserialiseKey("Platform", mod), // Deserialise 'Platform' key
                                                      Literal.Bool(INI.DeserialiseKey("Merge", mod)), // Translates 'True' to 'Yes' and 'False' to 'No'
                                                      string.Empty,
                                                      mod
                                                  });
                            ListView_ModsList.Items.Add(config);
                        }
                    } catch { }
                }
            }
        }

        /// <summary>
        /// Restore checked items from 'mods.ini'
        /// </summary>
        private void CheckDeserialisedMods() {
            string line = string.Empty; // Declare empty string for StreamReader
            string modConfig = Path.Combine(Properties.Settings.Default.Path_ModsDirectory, "mods.ini");

            if (File.Exists(modConfig)) {
                // Read 'mods.ini'
                using (StreamReader mods = new StreamReader(modConfig)) {
                    mods.ReadLine(); // Skip [Main] line
                    while ((line = mods.ReadLine()) != null) { // Read all lines until null
                        try {
                            if (Directory.Exists(Path.Combine(Properties.Settings.Default.Path_ModsDirectory, line))) {
                                // If the item exists, shift it to the top of the list and check it
                                for (int i = 0; i <= ListView_ModsList.Items.Count - 1; i++)
                                    if (Paths.GetContainingFolder(ListView_ModsList.Items[i].SubItems[6].Text) == line) {
                                        // Store original list item before shifting it in the list
                                        ListViewItem shiftItem = ListView_ModsList.Items[i];

                                        // Remove the mod already in the mods list
                                        ListView_ModsList.Items.RemoveAt(i);

                                        // Insert the mod stored previously
                                        ListView_ModsList.Items.Insert(0, shiftItem).Checked = true;
                                        break;
                                    }
                            }
                        } catch { }
                    }
                }
            }
        }

        /// <summary>
        /// Save checked items from the mods and patches lists respectively.
        /// </summary>
        private void SaveChecks() {
            //Save the names of the selected mods and the indexes of the selected patches to their appropriate INI files
            string modCheckList = Path.Combine(Properties.Settings.Default.Path_ModsDirectory, "mods.ini");
            string patchCheckList = Path.Combine(Properties.Settings.Default.Path_ModsDirectory, "patches.ini");

            // Create 'mods.ini'
            using (StreamWriter sw = File.CreateText(modCheckList))
                sw.WriteLine("[Main]"); // [Main] specification

            // Writes the list in reverse so the mods list writes it in it's preferred order
            for (int i = ListView_ModsList.Items.Count - 1; i >= 0; i--) {
                if (ListView_ModsList.Items[i].Checked) // Get checked state
                    using (StreamWriter sw = File.AppendText(modCheckList))
                        // Write mod name by folder name to prevent duplicate mod names conflicting
                        sw.WriteLine(Path.GetFileName(Path.GetDirectoryName(ListView_ModsList.Items[i].SubItems[6].Text)));
            }
        }

        /// <summary>
        /// Begins the mod installation process by calling the required methods.
        /// </summary>
        private void SectionButton_InstallMods_Click(object sender, EventArgs e) {
            if (Properties.Settings.Default.Path_GameDirectory != string.Empty ||
                File.Exists(Properties.Settings.Default.Path_GameDirectory)) {
                    ModEngine.skipped.Clear(); // Clear the skipped list
                    SaveChecks(); // Save checked items
                    RefreshLists();
                    UninstallThread(); // Uninstall everything before installing more mods

                    if (_isPathInvalid) {
                        DialogResult confirmation = UnifyMessenger.UnifyMessage.ShowDialog("Ensure that your mods directory is outside your game directory! " +
                                                                                           "This may cause issues with mod and patch installation.",
                                                                                           "Invalid directory", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                        if (confirmation == DialogResult.Cancel) {
                            SectionButton_DeselectAll();
                            Rush_Section_Settings.SelectedSection = true;
                            TabControl_Rush.SelectedTab = Tab_Section_Settings;
                            return;
                        }
                    }

                    //Top to Bottom Priority
                    if (Properties.Settings.Default.General_Priority) {
                        for (int i = ListView_ModsList.Items.Count - 1; i >= 0; i--)
                            if (ListView_ModsList.Items[i].Checked) {
                                Label_Status.Text = $"Installing {ListView_ModsList.Items[i].Text}...";

                                // Install the specified mod
                                try { 
                                    ModEngine.InstallMods(ListView_ModsList.Items[i].SubItems[6].Text, ListView_ModsList.Items[i].Text); 
                                }
                                catch (Exception ex) {
                                    UnifyMessenger.UnifyMessage.ShowDialog($"An error occurred whilst installing your mods...\n\n{ex}",
                                                                           "Installation failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                if (Properties.Settings.Default.General_SaveFileRedirection)
                                    // Redirect save data from the specified mod
                                    RedirectSaves(ListView_ModsList.Items[i].SubItems[6].Text, ListView_ModsList.Items[i].Text);
                            }

                    //Bottom to Top Priority
                    } else {
                        foreach (ListViewItem mod in ListView_ModsList.CheckedItems)
                            if (ListView_ModsList.Items[ListView_ModsList.Items.IndexOf(mod)].Checked) {
                                Label_Status.Text = $"Installing {mod.Text}...";

                                // Install the specified mod
                                ModEngine.InstallMods(mod.SubItems[6].Text, mod.Text);

                                if (Properties.Settings.Default.General_SaveFileRedirection)
                                    // Redirect save data from the specified mod
                                    RedirectSaves(mod.SubItems[6].Text, mod.Text);
                            }
                    }

                    if (Literal.System(Properties.Settings.Default.Path_GameDirectory) == "PlayStation 3") {
                        string rsdxCache = Paths.ReplaceFilename(Properties.Settings.Default.Path_GameDirectory, "RsdxPackedCacheFile.bin");

                        if (File.Exists(rsdxCache))
                            File.Move(rsdxCache, Path.ChangeExtension(rsdxCache, ".bin_back"));
                    }

                    // Check skipped list to ensure any errors occurred
                    if (ModEngine.skipped.Count != 0)
                        UnifyMessenger.UnifyMessage.ShowDialog($"Installation completed, but the following mods need revising:\n\n{string.Join("\n", ModEngine.skipped)}",
                                                               "Installation completed with warnings...", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    // Launch the emulator of choice
                    if (Properties.Settings.Default.General_LaunchEmulator) LaunchEmulator(Literal.Emulator(Properties.Settings.Default.Path_GameDirectory));

                    // Reset status label once emulator process has ended
                    Label_Status.Text = $"Ready.";

            // No game directory set - choose a new one...
            } else {
                string browseGame = RequestPath.GameExecutable();

                if (browseGame != string.Empty) {
                    Properties.Settings.Default.Path_GameDirectory = TextBox_GameDirectory.Text = browseGame;
                    Properties.Settings.Default.Save();
                } else return;
            }
        }

        /// <summary>
        /// Redirect save data from a mod to the user-specified save location.
        /// </summary>
        private void RedirectSaves(string mod, string name) {
            string saveLocation = Properties.Settings.Default.Path_SaveData; // Stores Save Data location in string for ease of use

            // Deserialise 'Save' key
            if (INI.DeserialiseKey("Save", mod).Contains("savedata")) {
                if (File.Exists(saveLocation)) {
                        // Feedback
                        Label_Status.Text = $"Redirecting save file for {name}...";

                        if (Literal.System(Properties.Settings.Default.Path_GameDirectory) == "Xbox 360") {
                            try {
                                // If the backup directory doesn't exist, create it
                                if (!Directory.Exists($"{Path.GetDirectoryName(saveLocation)}_back")) 
                                    Directory.CreateDirectory($"{Path.GetDirectoryName(saveLocation)}_back");

                                    // Copy original save to backup directory
                                    DirectoryInfo backupSave = new DirectoryInfo(Path.GetDirectoryName(saveLocation));
                                    foreach (FileInfo fi in backupSave.GetFiles())
                                        fi.CopyTo(Path.Combine($"{Path.GetDirectoryName(saveLocation)}_back", fi.Name), true);

                                    // Copy mod's save to the save data location
                                    File.Copy(Path.Combine(Path.GetDirectoryName(mod), "savedata.360"), saveLocation, true);
                            } catch { ModEngine.skipped.Add($"► {name} (save redirect failed because the save was not targeted for the Xbox 360)"); }
                        } else if (Literal.System(Properties.Settings.Default.Path_GameDirectory) == "PlayStation 3") {
                            try {
                                if (File.Exists(Path.Combine(Path.GetDirectoryName(mod), "savedata.ps3")) && Directory.Exists(Path.GetDirectoryName(saveLocation))) {
                                    // If the backup save data doesn't exist, create it
                                    if (!File.Exists($"{saveLocation}_back"))
                                        File.Move(saveLocation, $"{saveLocation}_back");

                                    // Copy mod's save to the save data location
                                    File.Copy(Path.Combine(Path.GetDirectoryName(mod), "savedata.ps3"), saveLocation, true);
                                }
                            } catch { ModEngine.skipped.Add($"► {name} (save redirect failed because the save was not targeted for the PlayStation 3)"); }
                        }
                } else ModEngine.skipped.Add($"► {name} (save redirect failed because no save data was specified)");
            } else return;
        }

        /// <summary>
        /// Simutaneously uninstall everything...
        /// </summary>
        private void UninstallThread() {
            Label_Status.Text = "Removing modified game data...";
            try {
                ModEngine.UninstallMods(); // Uninstalls all mods.
                ModEngine.UninstallCustomFilesystem(ListView_ModsList.Items); // Uninstalls user-made filesystems.
                ModEngine.UninstallSaves(ListView_ModsList.Items); // Removes redirected save data. 
            } catch (Exception ex) {
                UnifyMessenger.UnifyMessage.ShowDialog($"Failed to uninstall modified game data...\n\n{ex}",
                                                       "Uninstall failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Label_Status.Text = "Ready.";
        }

        /// <summary>
        /// Launches Xenia or RPCS3 depending on the selected game executable.
        /// </summary>
        private void LaunchEmulator(string emulator) {
            List<string> parameters = new List<string>();

            if (File.Exists(Properties.Settings.Default.Path_GameDirectory)) parameters.Add($"\"{Properties.Settings.Default.Path_GameDirectory}\"");
            else { // If the game directory is invalid, prompt the user to select a new one
                string gameExecutable = RequestPath.GameExecutable();

                if (gameExecutable != string.Empty) {
                    Properties.Settings.Default.Path_GameDirectory = TextBox_GameDirectory.Text = gameExecutable;
                    Properties.Settings.Default.Save();
                    LaunchEmulator(Literal.Emulator(Properties.Settings.Default.Path_GameDirectory)); // Perform task again with specified emulator
                } else return;
            }

            parameters.AddRange(Properties.Settings.Default.Emulator_Arguments.Split(' '));

            if (Properties.Settings.Default.Path_EmulatorDirectory == string.Empty ||
                !File.Exists(Properties.Settings.Default.Path_EmulatorDirectory)) { // If the emulator is empty/doesn't exist, prompt the user to select one
                    string emulatorExecutable = RequestPath.EmulatorExecutable();

                    if (emulatorExecutable != string.Empty) {
                        Properties.Settings.Default.Path_EmulatorDirectory = TextBox_EmulatorExecutable.Text = emulatorExecutable;
                        Properties.Settings.Default.Save();
                        LaunchEmulator(Literal.Emulator(Properties.Settings.Default.Path_GameDirectory)); // Perform task again with specified emulator
                    } else return;
            } else {
                if (emulator == "Xenia") {
                    // Xenia parameter setup
                    if (ComboBox_API.SelectedIndex != 2) {
                        if (ComboBox_API.SelectedIndex == 0) {
                            parameters.Add("--gpu=d3d12"); // Use DirectX 12
                            parameters.Add($"--draw_resolution_scale_x={ComboBox_Width.SelectedIndex + 1}"); // Width
                            parameters.Add($"--draw_resolution_scale_y={ComboBox_Height.SelectedIndex + 1}"); // Height
                        } else
                            parameters.Add("--gpu=vulkan"); // Use Vulkan

                        if (!CheckBox_Xenia_VerticalSync.Checked) parameters.Add("--vsync=false"); // V-Sync
                        if (CheckBox_Xenia_Gamma.Checked)         parameters.Add("--kernel_display_gamma_type=2"); // Enable Gamma
                        if (CheckBox_Xenia_Fullscreen.Checked)    parameters.Add("--fullscreen"); // Launch in Fullscreen
                        if (!CheckBox_Xenia_DiscordRPC.Checked)   parameters.Add("--discord=false"); // Discord Rich Presence
                        parameters.Add($"--user_language={Properties.Settings.Default.Emulator_UserLanguage + 1}");
                    }
                }

                ProcessStartInfo xeniaProc = new ProcessStartInfo() {
                    FileName = Properties.Settings.Default.Path_EmulatorDirectory,

                    // Ensure emulator directory is the working dir - prevents 'xenia.log' and save data being in the wrong locations
                    WorkingDirectory = Path.GetDirectoryName(Properties.Settings.Default.Path_EmulatorDirectory),

                    // Join all parameters for arguments
                    Arguments = string.Join(" ", parameters.ToArray())
                };

                Process emulatorProc = Process.Start(xeniaProc); // Launch the emulator
                Label_Status.Text = "Waiting for emulator exit call...";
                emulatorProc.WaitForExit(); // Halt usage of Unleashed Mod Manager to prevent the user from breaking stuff in the background

                // Uninstall mods after emulator quits
                if (Properties.Settings.Default.General_AutoUninstall) UninstallThread();
            }
        }

        /// <summary>
        /// Opens the requested location by sender.
        /// </summary>
        private void Button_Open_Click(object sender, EventArgs e) {
            try {
                string location = string.Empty;
                if (sender == Button_Open_ModsDirectory)           location = Properties.Settings.Default.Path_ModsDirectory; // Mods Directory
                else if (sender == Button_Open_GameDirectory)      location = Path.GetDirectoryName(Properties.Settings.Default.Path_GameDirectory); // Game Directory
                else if (sender == Button_Open_EmulatorExecutable) location = Properties.Settings.Default.Path_EmulatorDirectory; // Xenia
                else if (sender == Button_Open_SaveData)           location = Path.GetDirectoryName(Properties.Settings.Default.Path_SaveData); // Save Data Directory
                Process.Start(location); // Launch requested location
            } catch {
                UnifyMessenger.UnifyMessage.ShowDialog("The requested location was invalid or unspecified. Ensure the box is populated.",
                                                       "Unable to load...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Save checked items at their specified locations in the list.
        /// </summary>
        private void SectionButton_SaveChecks_Click(object sender, EventArgs e) {
            SaveChecks(); // Save checked items
            RefreshLists(); // Refresh mods list
        }

        /// <summary>
        /// Sets the item check state depending on the sender.
        /// </summary>
        private void Button_Mods_Selection_Click(object sender, EventArgs e) {
            // Mods List
            if      (sender == Button_Mods_SelectAll) ListView_ModsList.Items.Cast<ListViewItem>().All(i => i.Checked = true); // Select All
            else if (sender == Button_Mods_DeselectAll) { // Deselect All
                foreach (ListViewItem item in ListView_ModsList.Items) item.Checked = false;
                ListView_ModsList.SelectedItems.Clear();
            }
        }

        /// <summary>
        /// Switches between Top to Bottom or Bottom to Top priority.
        /// </summary>
        private void Button_Priority_Click(object sender, EventArgs e) {
            if (Properties.Settings.Default.General_Priority)
                Properties.Settings.Default.General_Priority = false;
            else
                Properties.Settings.Default.General_Priority = true;
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Increases or decreases item priority in the list.
        /// </summary>
        private void Button_Priority_Iteration_Click(object sender, EventArgs e) {
            if (sender == Button_UpperPriority) {
                int selectedIndex = ListView_ModsList.SelectedItems[0].Index; // Store the selected index
                bool check = ListView_ModsList.SelectedItems[0].Checked; // Check state bool
                ListViewItem shiftItem = ListView_ModsList.SelectedItems[0]; // Store the item
                ListView_ModsList.Items.RemoveAt(selectedIndex); // Removes the selected item
                ListView_ModsList.Items.Insert(selectedIndex - 1, shiftItem).Checked = check; // Insert checkbox at selectedIndex
                ListView_ModsList.Items[selectedIndex - 1].Selected = true; // Selects the recently moved checkbox
            } else if (sender == Button_DownerPriority) {
                int selectedIndex = ListView_ModsList.SelectedItems[0].Index; // Store the selected index
                bool check = ListView_ModsList.SelectedItems[0].Checked; // Check state bool
                ListViewItem shiftItem = ListView_ModsList.SelectedItems[0]; // Store the item
                ListView_ModsList.Items.RemoveAt(selectedIndex); // Removes the selected item
                ListView_ModsList.Items.Insert(selectedIndex + 1, shiftItem).Checked = check; // Insert checkbox at selectedIndex
                ListView_ModsList.Items[selectedIndex + 1].Selected = true; // Selects the recently moved checkbox
            }
        }

        /// <summary>
        /// Perform actions if user selects an item in the mods list.
        /// </summary>
        private void ListView_ModsList_SelectedIndexChanged(object sender, EventArgs e) {
            // Enables/disables the Upper Priority button depending on if a checkbox is selected
            Button_UpperPriority.Enabled = ListView_ModsList.SelectedItems.Count > 0 && ListView_ModsList.SelectedItems[0].Index > 0;

            // Enables/disables the Downer Priority button depending on if a checkbox is selected
            Button_DownerPriority.Enabled = ListView_ModsList.SelectedItems.Count > 0 && ListView_ModsList.SelectedItems[0].Index < ListView_ModsList.Items.Count - 1;
        }

        /// <summary>
        /// Resets Unleashed Mod Manager.
        /// </summary>
        private void LinkLabel_Reset_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            DialogResult confirmation = UnifyMessenger.UnifyMessage.ShowDialog("This will clear all of the settings for Unleashed Mod Manager. Are you sure you want to continue?",
                                                                               "Unleashed Mod Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmation == DialogResult.Yes) Program.Reset();
        }

        /// <summary>
        /// Refreshes the lists.
        /// </summary>
        private void SectionButton_Refresh_Click(object sender, EventArgs e) { RefreshLists(); }

        /// <summary>
        /// Enables/disables the Update Mods button depending on how many items are checked in the Mod Updates list.
        /// </summary>
        private void ListView_ModUpdates_ItemChecked(object sender, ItemCheckedEventArgs e) {
            SectionButton_UpdateMods.Enabled = ListView_ModUpdates.CheckedItems.Count > 0;
        }

        /// <summary>
        /// Code for all SectionButton controls in the Updates section.
        /// </summary>
        private async void SectionButton_Updates_Click(object sender, EventArgs e) {
            // Check if mod updates is clicked
            if (sender == SectionButton_CheckForModUpdates) {
                Properties.Settings.Default.General_LastModUpdate = DateTime.Now.Ticks;
                await CheckForModUpdates(string.Empty);
                Properties.Settings.Default.Save();
            }

            // Update mods is clicked
            else if (sender == SectionButton_UpdateMods) {
                ListBox_UpdateLogs.Items.Clear(); // Clear update logs
                ListView_ModUpdates.SelectedItems.Clear(); // Clear selected

                // Item is checked in the mod updates list
                foreach (ListViewItem mod in ListView_ModUpdates.CheckedItems) {
                    // Block controls
                    SectionButton_UpdateMods.Enabled =
                    SectionButton_CheckForModUpdates.Enabled = false;

                    // Feedback
                    ListBox_UpdateLogs.Items.Add($"Updating {mod.Text}...");

                    try {
                        // Update the mod using deserialised keys from the 'mod.ini'
                        await UpdateMod(mod.SubItems[2].Text,
                                        mod.Text,
                                        INI.DeserialiseKey("Version",  mod.SubItems[2].Text),
                                        INI.DeserialiseKey("Metadata", mod.SubItems[2].Text),
                                        INI.DeserialiseKey("Data",     mod.SubItems[2].Text),
                                        mod
                                        );
                    } catch (Exception ex) {
                        // Update failed - prints error to debug console and is subsequently ignored
                        ListBox_UpdateLogs.Items.Add($"Failed to update {mod.Text}...");
                        Console.WriteLine(ex);
                    }

                    // Feedback
                    SectionButton_CheckForModUpdates.Enabled = true;
                    if (ListView_ModUpdates.CheckedItems.Count == ListView_ModUpdates.Items.Count) SectionButton_UpdateMods.Enabled = false;
                    else SectionButton_UpdateMods.Enabled = true;
                }
            }
        }

        /// <summary>
        /// Updates the selected mod using parameters from it's 'mod.ini'
        /// </summary>
        /// <param name="mod">Location of 'mod.ini'</param>
        /// <param name="title">Name of the mod</param>
        /// <param name="version">Current version of the mod</param>
        /// <param name="metadata">Network location of 'mod.ini'</param>
        /// <param name="data">Network location of new data</param>
        private async Task UpdateMod(string mod, string title, string version, string metadata, string data, ListViewItem listViewItem) {
            string archive = Path.GetTempFileName(), // Creates a temporary name for the mod update package
                   versionDL = string.Empty; // Defined string to contain the latest version number

            // Download latest 'mod.ini' from update server (in case any changes have been made)
            try { metadata = await Client.RequestString(metadata); }
            catch { return; }

            if (metadata.Length != 0) {
                string[] splitMetadata = metadata.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

                // Manually deserialise split lines
                foreach (string line in splitMetadata) {
                    string entryValue = string.Empty;
                    if (line.StartsWith("Version")) {
                        entryValue = line.Substring(line.IndexOf("=") + 2);
                        entryValue = entryValue.Remove(entryValue.Length - 1);
                        versionDL = entryValue;
                    }
                    if (line.StartsWith("Data")) {
                        entryValue = line.Substring(line.IndexOf("=") + 2);
                        entryValue = entryValue.Remove(entryValue.Length - 1);
                        if (data != entryValue) data = entryValue; // Overwrite data location if changed
                    }
                }
            }

            // If the version number differs...
            if (versionDL != version) {
                using (WebClient client = new WebClient()) {
                    client.DownloadProgressChanged += (s, dlevent) => { ProgressBar_ModUpdate.Value = dlevent.ProgressPercentage; };
                    client.DownloadFileAsync(new Uri(data), archive); // Download archive data
                    client.DownloadFileCompleted += (s, dlevent) => {
                        // Get header info for verification
                        byte[] bytes = File.ReadAllBytes(archive).Take(2).ToArray();
                        string hexString = BitConverter.ToString(bytes); hexString = hexString.Replace("-", " ");

                        // Erase temporary update data
                        DirectoryInfo extractData = new DirectoryInfo(mod);
                        try {
                            if (Directory.Exists(mod)) {
                                foreach (FileInfo file in extractData.GetFiles())
                                    file.Delete();
                                foreach (DirectoryInfo directory in extractData.GetDirectories())
                                    directory.Delete(true);
                            }
                            Directory.Delete(mod);
                        } catch { }

                        // Determine what should be used to extract the downloaded archive
                        if (hexString == "50 4B") // ZIP header
                            using (ZipArchive zip = new ZipArchive(new MemoryStream(File.ReadAllBytes(archive))))
                                ZIP.ExtractToDirectory(zip, Properties.Settings.Default.Path_ModsDirectory, true);
                        else
                            // Try 7-Zip - if it doesn't work, try WinRAR before throwing exception
                            ZIP.InstallFromCustomArchive(archive, Properties.Settings.Default.Path_ModsDirectory);

                        // Delete archive regardless of extracted state
                        File.Delete(archive);

                        // Feedback
                        ListBox_UpdateLogs.Items.Add($"{title} was updated successfully...");
                        ListView_ModUpdates.Items.Remove(listViewItem);
                        ProgressBar_ModUpdate.Value = 0;
                    };
                }
            }
        }

        /// <summary>
        /// Column resizing algorithm.
        /// </summary>
        private void SizeLastColumn(ListView lv) {
            if (lv == ListView_ModsList) {
                int x = lv.Width / 15 == 0 ? 1 : lv.Width / 15;
                lv.Columns[0].Width = (x * 7) - 7;
                lv.Columns[1].Width = (x * 2) - 20;
                lv.Columns[2].Width = (x * 2) + 20;
                lv.Columns[3].Width = (x * 2) + 10;
                lv.Columns[4].Width = (x * 2) - 9;
                lv.Columns[5].Width = x * 100;
            } else if (lv == ListView_ModUpdates) {
                int x = lv.Width / 15 == 0 ? 1 : lv.Width / 15;
                lv.Columns[0].Width = Panel_ModUpdateBackdrop.Width;
                lv.Columns[1].Width = x * 100;
            }
            lv.Refresh();
        }

        /// <summary>
        /// Resizes all columns.
        /// </summary>
        private void RefreshColumnSize() {
            SizeLastColumn(ListView_ModsList);
            SizeLastColumn(ListView_ModUpdates);
        }

        /// <summary>
        /// Refreshes the column size on the Resize event.
        /// </summary>
        private void RushInterface_Resize(object sender, EventArgs e) {
            TabControl_Rush.SelectedTab.VerticalScroll.Value = 0;
            RefreshColumnSize();
        }

        /// <summary>
        /// Launches Protocol Manager for GameBanana registry key installation.
        /// </summary>
        private void LinkLabel_1ClickURLHandler_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            try {
                RegistryKey unleashedmmKey = Registry.CurrentUser.OpenSubKey($"Software\\Classes\\{protocol}\\shell\\open\\command", true);

                // Install handler
                if (((LinkLabel)sender).Text == "Install 1-Click URL Handler" || ((LinkLabel)sender).Text == "Reinstall 1-Click URL Handler") {
                    unleashedmmKey = Registry.CurrentUser.OpenSubKey($"Software\\Classes\\{protocol}", true);
                    if (unleashedmmKey == null)
                        unleashedmmKey = Registry.CurrentUser.CreateSubKey($"Software\\Classes\\{protocol}");
                    unleashedmmKey.SetValue(string.Empty, "Unleashed Mod Manager");
                    unleashedmmKey.SetValue("URL Protocol", string.Empty);
                    RegistryKey prevkey = unleashedmmKey;
                    unleashedmmKey = unleashedmmKey.OpenSubKey("shell", true);
                    if (unleashedmmKey == null)
                        unleashedmmKey = prevkey.CreateSubKey("shell");
                    prevkey = unleashedmmKey;
                    unleashedmmKey = unleashedmmKey.OpenSubKey("open", true);
                    if (unleashedmmKey == null)
                        unleashedmmKey = prevkey.CreateSubKey("open");
                    prevkey = unleashedmmKey;
                    unleashedmmKey = unleashedmmKey.OpenSubKey("command", true);
                    if (unleashedmmKey == null)
                        unleashedmmKey = prevkey.CreateSubKey("command");

                    unleashedmmKey.SetValue(string.Empty, $"\"{Application.ExecutablePath}\" \"-banana\" \"%1\"");
                    unleashedmmKey.Close();

                // Uninstall handler
                } else if (((LinkLabel)sender).Text == "Uninstall 1-Click URL Handler") {
                    unleashedmmKey = Registry.CurrentUser.OpenSubKey($"Software\\Classes\\{protocol}", true);
                    unleashedmmKey.SetValue(string.Empty, string.Empty);
                    unleashedmmKey = Registry.CurrentUser.OpenSubKey($"Software\\Classes\\{protocol}\\shell\\open\\command", true);
                    unleashedmmKey.SetValue(string.Empty, string.Empty);
                    unleashedmmKey.Close();
                }

                CheckRegistry();
            } catch {
                UnifyMessenger.UnifyMessage.ShowDialog("Failed to modify the Windows Registry...",
                                                       "Registry error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Checks to see if the GameBanana 1-Click registry key is installed.
        /// </summary>
        private void CheckRegistry() {
            RegistryKey key         = Registry.CurrentUser.OpenSubKey($"Software\\Classes\\{protocol}", false), // Open the Unleashed Mod Manager protocol key
                        getLocation = Registry.CurrentUser.OpenSubKey($"Software\\Classes\\{protocol}\\shell\\open\\command", false);

            string command = $"\"{Application.ExecutablePath}\" \"-banana\" \"%1\"";

            // If the key does not exist, keep the checkbox unchecked.
            if (key == null || getLocation.GetValue(null).ToString() == string.Empty)
                LinkLabel_1ClickURLHandler.Text = "Install 1-Click URL Handler";
            else {
                if (getLocation.GetValue(null).ToString() != command)
                    LinkLabel_1ClickURLHandler.Text = "Reinstall 1-Click URL Handler";
                else if (getLocation.GetValue(null).ToString() == command)
                    LinkLabel_1ClickURLHandler.Text = "Uninstall 1-Click URL Handler";
            }
        }

        /// <summary>
        /// Resizes Mod Updates container when splitter is moved.
        /// </summary>
        private void SplitContainer_ModUpdate_SplitterMoved(object sender, SplitterEventArgs e) { SizeLastColumn(ListView_ModUpdates); }

        /// <summary>
        /// Tells the list view how it should handle the DragDrop event.
        /// </summary>
        private void ListView_DragEnter(object sender, DragEventArgs e) { e.Effect = DragDropEffects.Copy; }

        /// <summary>
        /// Tells the list view what to do with the dropped item.
        /// </summary>
        private void ListView_DragDrop(object sender, DragEventArgs e) {
            string[] droppedFiles = (string[])e.Data.GetData(DataFormats.FileDrop);

            // Mods DragDrop event
            if (sender == ListView_ModsList) {
                if (droppedFiles.Length == 1) {
                    // File is an archive
                    if (Path.GetExtension(droppedFiles[0]) == ".zip" || Path.GetExtension(droppedFiles[0]) == ".7z" || Path.GetExtension(droppedFiles[0]) == ".rar") { 
                        DialogResult confirmation = UnifyMessenger.UnifyMessage.ShowDialog($"Do you want to add '{Path.GetFileName(droppedFiles[0])}' as a mod?",
                                                                                           "Add mod?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (confirmation == DialogResult.Yes) {
                            byte[] bytes = File.ReadAllBytes(droppedFiles[0]).Take(2).ToArray();
                            string hexString = BitConverter.ToString(bytes);

                            if (hexString == "50-4B") ZIP.InstallFromZip(droppedFiles[0], Properties.Settings.Default.Path_ModsDirectory);
                            else ZIP.InstallFromCustomArchive(droppedFiles[0], Properties.Settings.Default.Path_ModsDirectory);

                            RefreshLists();
                        }
                    }
                } else {
                    DialogResult confirmation = UnifyMessenger.UnifyMessage.ShowDialog($"Do you want to add all {droppedFiles.Length} items as mods?",
                                                                                       "Add mods?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (confirmation == DialogResult.Yes) {
                        Label_Status.Text = $"Extracting {droppedFiles.Length} mods...";

                        // Install
                        foreach (string item in droppedFiles) {
                            byte[] bytes = File.ReadAllBytes(item).Take(2).ToArray();
                            string hexString = BitConverter.ToString(bytes);

                            // File is an archive
                            if (Path.GetExtension(item) == ".zip" || Path.GetExtension(item) == ".7z" || Path.GetExtension(item) == ".rar")
                                if (hexString == "50-4B") ZIP.InstallFromZip(item, Properties.Settings.Default.Path_ModsDirectory);
                                else ZIP.InstallFromCustomArchive(item, Properties.Settings.Default.Path_ModsDirectory);

                            RefreshLists(); // Refresh on completion
                        }

                        Label_Status.Text = "Ready.";
                    }
                }
            }
        }

        /// <summary>
        /// Redirects the user to a webpage about the selected contributor.
        /// </summary>
        private void Link_About_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            if           (sender == LinkLabel_HyperBE32) Process.Start("https://github.com/HyperBE32");
            else if   (sender == LinkLabel_SuperSonic16) Process.Start("https://github.com/thesupersonic16");
            else if          (sender == LinkLabel_Beatz) Process.Start("https://www.youtube.com/channel/UCEjwges-3BTaWsMwOGJDoGQ");
            else if            (sender == LinkLabel_GPF) Process.Start("https://www.youtube.com/channel/UCZfOGBkXRKICFozWU5bE0Xg");
            else if  (sender == LinkLabel_CodenameGamma) Process.Start("https://www.youtube.com/user/codenamegamma");
            else if       (sender == LinkLabel_Velcomia) Process.Start("https://twitter.com/Velcomia");
            else if       (sender == LinkLabel_slashiee) Process.Start("https://github.com/slashiee");
            else if      (sender == LinkLabel_Knuxfan24) Process.Start("https://github.com/Knuxfan24");
        }

        /// <summary>
        /// Launches Sonic Unleashed without installing any mods, patches or tweaks.
        /// Keeps the game intact, whether it have mods installed or not.
        /// </summary>
        private void SectionButton_LaunchGame_Click(object sender, EventArgs e) {
            // Launch the emulator of choice
            LaunchEmulator(Literal.Emulator(Properties.Settings.Default.Path_GameDirectory));

            // Reset status label once emulator process has ended
            Label_Status.Text = $"Ready.";
        }

        /// <summary>
        /// Create right-click context menu for the lists at runtime.
        /// Called when mouse clicked in the ListView whitespace.
        /// </summary>
        private void ListView_MouseUp(object sender, MouseEventArgs e) {
            // Perform if the function was called with the right mouse button
            if (e.Button == MouseButtons.Right) {
                // Create the dark context menu
                ContextMenuDark menuDark = new ContextMenuDark();

                // Get item by mouse focus
                if (sender == ListView_ModsList) {
                    if (ListView_ModsList.SelectedItems.Count == 0) {
                        menuDark.Items.Clear();
                        menuDark.Items.Add(new ToolStripMenuItem("Create Mod", Properties.Resources.NewFileCollection_16x, ContextMenu_ModMenu_Items_Click));
                        menuDark.Show(Cursor.Position);
                    }
                }
            }
        }

        /// <summary>
        /// Dumps current user settings and selected items.
        /// </summary>
        private void LinkLabel_Snapshot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            // Save location for snapshot
            SaveFileDialog snapshot = new SaveFileDialog() {
                Title = "Save snapshot...",
                Filter = "Snapshot (*.dmp)|*.dmp",
                FileName = $"sonic06mm-snapshot-{DateTime.Now.ToString("ddMMyy")}.dmp"
            };

            if (snapshot.ShowDialog() == DialogResult.OK) {
                string architecture = "x86";
                int gpuCount = 0;

                // Get application architecture
                if (IntPtr.Size == 4) architecture = "x86";
                else if (IntPtr.Size == 8) architecture = "x64";
                else architecture = "Unknown";

                // Create snapshot
                using (StreamWriter sw = File.CreateText(snapshot.FileName)) {
                    try {
                        sw.WriteLine($"Unleashed Mod Manager");
                        sw.WriteLine(DateTime.Now);

                        sw.WriteLine("\nBuild:");
#if !DEBUG
                        sw.WriteLine($"Type: Release");
#elif DEBUG
                        sw.WriteLine($"Type: Debug");
#endif
                        sw.WriteLine($"Version: {Program.VersionNumber}");
                        sw.WriteLine($"Architecture: {architecture}");

                        sw.WriteLine("\nSpecifications:");

                        // Get OS version
                        sw.WriteLine($"OS: {new ComputerInfo().OSFullName}");

                        // Get CPU name
                        ManagementObjectSearcher getCPU = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");
                        foreach (ManagementObject mo in getCPU.Get())
                            sw.WriteLine($"CPU: {mo["Name"].ToString()}");

                        // Format RAM as long to readable bytes
                        sw.WriteLine($"RAM: {Literal.FormatBytes(new ManagementObjectSearcher("SELECT Capacity FROM Win32_PhysicalMemory").Get().Cast<ManagementObject>().Sum(x => Convert.ToInt64(x.Properties["Capacity"].Value)))}");

                        // Get GPU names
                        ManagementObjectSearcher getGPU = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController");
                        foreach (ManagementObject mo in getGPU.Get())
                            foreach (PropertyData property in mo.Properties)
                                if (property.Name == "Description") {
                                    sw.WriteLine($"GPU #{gpuCount}: {property.Value.ToString()}");
                                    gpuCount++;
                                }

                        // Print list of checked mods
                        if (ListView_ModsList.CheckedItems.Count != 0) {
                            sw.WriteLine("\nMods:");
                            foreach (object mod in ListView_ModsList.CheckedItems)
                                sw.WriteLine(mod);
                        }

                        // Print list of current settings
                        sw.WriteLine("\nSettings:");
                        foreach (SettingsPropertyValue property in Properties.Settings.Default.PropertyValues)
                            sw.WriteLine($"{property.Name}: {property.PropertyValue}");
                    } catch (Exception ex) {
                        // Print exception if something failed
                        sw.WriteLine("\nExceptions:");
                        sw.WriteLine(ex);
                    }
                }
            }
        }

        /// <summary>
        /// Changed index selection events for the Emulator section.
        /// </summary>
        private void ComboBox_Emulator_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender == ComboBox_API)
            {
                Properties.Settings.Default.Emulator_API = ((ComboBox)sender).SelectedIndex;
            }
            else if (sender == ComboBox_UserLanguage)
            {
                Properties.Settings.Default.Emulator_UserLanguage = ((ComboBox)sender).SelectedIndex;
            }
            else if (sender == ComboBox_Width)
            {
                Properties.Settings.Default.Emulator_Width = ((ComboBox)sender).SelectedIndex;
            }
            else if (sender == ComboBox_Height)
            {
                Properties.Settings.Default.Emulator_Height = ((ComboBox)sender).SelectedIndex;
            }

            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Save arguments on text changed.
        /// </summary>
        private void TextBox_Arguments_TextChanged(object sender, EventArgs e) {
            Properties.Settings.Default.Emulator_Arguments = ((TextBox)sender).Text;
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Save Xenia parameter settings.
        /// </summary>
        private void CheckBox_Xenia_CheckedChanged(object sender, EventArgs e) {
            if (sender == CheckBox_Xenia_VerticalSync) Properties.Settings.Default.Emulator_VerticalSync = ((CheckBox)sender).Checked;
            else if        (sender == CheckBox_Xenia_Gamma) Properties.Settings.Default.Emulator_Gamma        = ((CheckBox)sender).Checked;
            else if   (sender == CheckBox_Xenia_Fullscreen) Properties.Settings.Default.Emulator_Fullscreen   = ((CheckBox)sender).Checked;
            else if   (sender == CheckBox_Xenia_DiscordRPC) Properties.Settings.Default.Emulator_DiscordRPC   = ((CheckBox)sender).Checked;
            Properties.Settings.Default.Save();
        }
    }
}
