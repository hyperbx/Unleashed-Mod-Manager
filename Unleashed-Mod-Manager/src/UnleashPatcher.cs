using System;
using System.IO;
using System.Linq;
using Unleash.Messenger;
using System.Diagnostics;
using Unleash.Serialisers;
using Unleash.Compression;
using Unleash.Environment3;
using System.Windows.Forms;
using System.IO.Compression;
using Unleash.Globalisation;
using System.Collections.Generic;

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

namespace Unleash.Patcher
{
    class ModEngine
    {
        public static List<string> skipped = new List<string>();  // Define the skipped list for error tracking

        /// <summary>
        /// Installs the specified mods (requires for statement iteration for more than one mod).
        /// </summary>
        /// <param name="mod">File path to the mod's INI file.</param>
        /// <param name="name">Name of the mod by Title key.</param>
        public static void InstallMods(string mod, string name) {
            string platform = INI.DeserialiseKey("Platform", mod); // Deserialise 'Platform' key
            bool merge = false; // Deserialise 'Merge' key
            string[] read_only = INI.DeserialiseKey("Read-only", mod).Split(','); // Deserialise 'Read-only' key

            try {
                // Attempt to parse as a Boolean value
                merge = bool.Parse(INI.DeserialiseKey("Merge", mod)); 
            } catch { merge = false; }

            //Skip the mod if the platform is invalid
            string system = Literal.System(Properties.Settings.Default.Path_GameDirectory);
            if (system != platform && platform != "All Systems") {
                skipped.Add($"► {name} (failed because the mod was not targeted for the {system})");
                return;
            }

            // Search for all files with specified LINQ filters
            List<string> files = Directory.GetFiles(Path.GetDirectoryName(mod), "*.*", SearchOption.AllDirectories)
                                .Where(s => s.Contains(".ar")        ||
                                            s.EndsWith(".arl")        ||
                                            s.EndsWith(".dds")        ||
                                            s.EndsWith("default.xex") ||
                                            s.EndsWith("EBOOT.BIN")   ||
                                            s.EndsWith(".sfd")        ||
                                            s.EndsWith(".pfd")        ||
                                            s.EndsWith(".csb")        ||
                                            s.EndsWith(".cpk")).ToList();

            foreach (string file in files) {
                // Absolute file path
                string filePath = file.Remove(0, Path.GetDirectoryName(mod).Length);

                // Absolute file path (from the mod) combined with the game directory
                string vanillaFilePath = Path.Combine(Path.GetDirectoryName(Properties.Settings.Default.Path_GameDirectory), filePath.Substring(1));

                // Define string to store backed up file
                string targetFilePath = string.Empty;

                // Proceed with backup
                if ((targetFilePath = Content.CreateBackup(vanillaFilePath)) != string.Empty) {
                    // Decompress backed up ARL to compare AR count with later
                    if (Path.GetExtension(vanillaFilePath) == ".arl" && File.Exists(targetFilePath))
                        Decompress.DecompressBySystem(targetFilePath);

                    // Merge modified data
                    if (Path.GetFileName(file).Contains(".ar") && merge && !read_only.Contains(Path.GetFileName(file))) {
                        if (RushInterface._debug) Console.WriteLine($"Merging: {file}");
                        Content.Merge(vanillaFilePath, file);

                    // Copy the modified data
                    } else {
                        if (RushInterface._debug) Console.WriteLine($"Copying: {file}");
                        File.Copy(file, vanillaFilePath, true);
                    }
                } else {
                    if (RushInterface._debug) Console.WriteLine($"Copying: {file}");
                    File.Copy(file, vanillaFilePath, true);
                }
            }
        }

        /// <summary>
        /// Uninstalls all mods.
        /// </summary>
        public static void UninstallMods() {
            // If the game directory is empty/doesn't exist, ignore request
            if (Paths.CheckFileLegitimacy(Properties.Settings.Default.Path_GameDirectory)) {
                // Search for all backup files
                List<string> files = Directory.GetFiles(
                                               Path.GetDirectoryName(Properties.Settings.Default.Path_GameDirectory),
                                               "*.*_back",
                                               SearchOption.AllDirectories).ToList();

                foreach (string file in files) {
                    // Restore archive splits
                    if (Path.GetExtension(file) == ".arl_back") {
                        uint arCount     = Content.GetArchiveCount(file), // Number of archives (from 1)
                             arFileCount = arCount - 1; // Number of archives (from 0)

                        if (arCount != 0) {
                            for (int i = 99; i > arFileCount; i--) {
                                string arRange = Path.ChangeExtension(file, $"ar.{i.ToString("00")}");
                                if (File.Exists(arRange)) File.Delete(arRange);
                            }
                        } else {
                            for (int i = 99; i >= arCount; i--) {
                                string arRange = Path.ChangeExtension(file, $"ar.{i.ToString("00")}");
                                if (File.Exists(arRange)) File.Delete(arRange);
                            }
                        }

                        Content.RestoreFromBackup(file);

                    // Restore other files
                    } else
                        Content.RestoreFromBackup(file);
                }
            }
        }

        /// <summary>
        /// Uninstalls user-made filesystems.
        /// </summary>
        public static void UninstallCustomFilesystem(ListView.ListViewItemCollection listViewItems) {
            if (Paths.CheckFileLegitimacy(Properties.Settings.Default.Path_GameDirectory)) { // If the game directory is empty/doesn't exist, ignore request
                foreach (ListViewItem mod in listViewItems) {
                    string[] custom = INI.DeserialiseKey("Custom", mod.SubItems[6].Text).Split(','); // Deserialise 'Custom' key

                    if (custom[0] != string.Empty) { // Speeds things up a bit - ensures it's not checking a default null parameter
                        foreach (string file in custom) {
                            // Search for all files with filters from custom
                            List<string> files = Directory.GetFiles(Path.GetDirectoryName(Properties.Settings.Default.Path_GameDirectory), file, SearchOption.AllDirectories).ToList();
                                
                            foreach (string customfile in files)
                                try {
                                    if (RushInterface._debug) Console.WriteLine($"Removing: {file}");
                                    File.Delete(customfile); // If custom archive is found, erase...
                                } catch { }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Removes redirected save data.
        /// </summary>
        public static void UninstallSaves(ListView.ListViewItemCollection listViewItems) {
            if (Properties.Settings.Default.Path_SaveData != string.Empty || File.Exists(Properties.Settings.Default.Path_SaveData)) {
                foreach (ListViewItem mod in listViewItems) {
                    // Basically just to check 'SYS-DATA' as a directory
                    string saveLocation = Path.GetDirectoryName(Path.GetDirectoryName(Properties.Settings.Default.Path_SaveData));

                    // Deserialise 'Save' key
                    string savedata = INI.DeserialiseKey("Save", mod.SubItems[6].Text);

                    if (savedata != string.Empty) { // Speeds things up a bit - ensures it's not checking a default null parameter
                        if (Literal.Emulator(Properties.Settings.Default.Path_GameDirectory) == "Xenia") {
                            string[] saves = Array.Empty<string>();

                            // Get all backup directories
                            if (Directory.Exists(saveLocation)) saves = Directory.GetDirectories(saveLocation, "SYS-DATA_back", SearchOption.AllDirectories);

                            foreach (var dir in saves) {
                                // Original save data path
                                string saveFile = Path.Combine(dir.ToString().Remove(dir.Length - 5), Path.GetFileName(dir.ToString().Remove(dir.Length - 5)));

                                // Copy redirected save data back to the mod's directory (keeps user progress)
                                if (File.Exists(saveFile)) {
                                    Console.WriteLine($"Removing: {dir}");
                                    if (savedata != string.Empty) File.Copy(saveFile, Path.Combine(Path.GetDirectoryName(mod.SubItems[6].Text), "savedata.360"), true);
                                }

                                // Recursively erase redirected save data
                                if (Directory.Exists(dir.ToString().Remove(dir.Length - 5))) {
                                    Console.WriteLine($"Removing: {dir}");
                                    Directory.Delete(dir.ToString().Remove(dir.Length - 5), true);
                                }

                                // Restore original save data
                                Directory.Move(dir.ToString(), dir.ToString().Remove(dir.Length - 5));
                            }
                        } else if (Literal.Emulator(Properties.Settings.Default.Path_GameDirectory) == "RPCS3") {
                            string[] saves = Array.Empty<string>();

                            // Original save data path
                            if (Directory.Exists(saveLocation)) saves = Directory.GetFiles(saveLocation, "SYS-DATA_back", SearchOption.AllDirectories);

                            foreach (var file in saves) {
                                string saveFile = Path.Combine(file.ToString().Remove(file.Length - 5), Path.GetFileName(file.ToString().Remove(file.Length - 5)));

                                // Copy redirected save data back to the mod's directory (keeps user progress)
                                if (File.Exists(saveFile)) {
                                    Console.WriteLine($"Removing: {file}");
                                    if (savedata != string.Empty) File.Copy(saveFile, Path.Combine(Path.GetDirectoryName(mod.SubItems[6].Text), "savedata.ps3"), true);
                                }

                                // Erase redirected save data
                                if (File.Exists(file.ToString().Remove(file.Length - 5))) {
                                    Console.WriteLine($"Removing: {file}");
                                    File.Delete(file.ToString().Remove(file.Length - 5));
                                }

                                // Restore original save data
                                File.Move(file.ToString(), file.ToString().Remove(file.Length - 5));
                            }
                        }
                    }
                }
            }
        }
    }

    public static class ZIP
    {
        /// <summary>
        /// Extracts a ZIP file.
        /// </summary>
        public static void InstallFromZip(string ZipPath, string location) {
            try {
                if (File.Exists(ZipPath)) {
                    // Extracts all contents inside of the zip file
                    ZipFile.ExtractToDirectory(ZipPath, location);
                } else {
                    UnifyMessenger.UnifyMessage.ShowDialog($"Failed to extract '{Path.GetFileName(ZipPath)}'...",
                                                           "Extract failed...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch { InstallFromCustomArchive(ZipPath, location); }
        }

        /// <summary>
        /// Extracts a ZIP file with extra parameters.
        /// </summary>
        public static void ExtractToDirectory(this ZipArchive archive, string destinationDirectoryName, bool overwrite) {
            if (!overwrite) {
                archive.ExtractToDirectory(destinationDirectoryName);
                return;
            }

            foreach (ZipArchiveEntry file in archive.Entries) {
                string completeFileName = Path.Combine(destinationDirectoryName, file.FullName);
                string directory = Path.GetDirectoryName(completeFileName);

                if (!Directory.Exists(directory))
                    Directory.CreateDirectory(directory);

                if (file.Name != "")
                    if (Path.GetFileName(completeFileName) != Path.GetFileName(Application.ExecutablePath))
                        file.ExtractToFile(completeFileName, true);
                    else
                        file.ExtractToFile(Path.Combine(destinationDirectoryName, $"{Application.ExecutablePath}.new"), true);
            }
        }

        /// <summary>
        /// Extracts 7Z/RAR files with 7-Zip.
        /// </summary>
        public static void InstallFromCustomArchive(string ArchivePath, string location) {
            if (File.Exists(ArchivePath)) {
                // Extracts the archive to the temp folder.
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo {
                    WindowStyle = ProcessWindowStyle.Hidden,
                    FileName = Program._7Zip,
                    Arguments = $"x -y -o\"{location}\" \"{ArchivePath}\""
                };
                process.StartInfo = startInfo;
                process.Start();
                process.WaitForExit();
            } else {
                UnifyMessenger.UnifyMessage.ShowDialog($"Failed to extract '{Path.GetFileName(ArchivePath)}'...",
                                                       "Extract failed...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
