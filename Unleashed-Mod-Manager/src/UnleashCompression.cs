using System;
using System.IO;
using HedgeLib.Archives;
using System.Diagnostics;
using Unleash.Serialisers;
using Unleash.Environment3;
using Unleash.Globalisation;

namespace Unleash.Compression
{
    class Decompress
    {
        /// <summary>
        /// Decompresses files using XCompression.
        /// </summary>
        public static void XCompression(string filepath) {
            if (Verification.Decompressed(filepath)) {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo {
                    WindowStyle = ProcessWindowStyle.Hidden,
                    FileName = Program.quickbms,
                    Arguments = $"-Y -R \"{Program.xcompress_file}\" \"{filepath}\"",
                    WorkingDirectory = Path.GetDirectoryName(filepath)
                };
                process.StartInfo = startInfo;
                process.Start();
                process.WaitForExit();
            }
        }

        /// <summary>
        /// Decompresses files using SEGS compression.
        /// </summary>
        public static void SEGS(string filepath) {
            if (Verification.Decompressed(filepath)) {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo {
                    WindowStyle = ProcessWindowStyle.Hidden,
                    FileName = Program.quickbms,
                    Arguments = $"-Y -R \"{Program.arcsys}\" \"{filepath}\"",
                    WorkingDirectory = Path.GetDirectoryName(filepath)
                };
                process.StartInfo = startInfo;
                process.Start();
                process.WaitForExit();
            }
        }

        /// <summary>
        /// Decompress file by system.
        /// </summary>
        public static void DecompressBySystem(string file) {
            // Decompress archive before attempting to extract
            if (Literal.System(Properties.Settings.Default.Path_GameDirectory) == "Xbox 360") {
                XCompression(file); XCompression(file);
            } else if (Literal.System(Properties.Settings.Default.Path_GameDirectory) == "PlayStation 3") {
                SEGS(file); SEGS(file);
            } else
                return;
        }
    }

    class Content
    {
        /// <summary>
        /// Gets the AR count from the ARL.
        /// </summary>
        public static uint GetArchiveCount(string arl) {
            using (var stream = File.Open(arl, FileMode.Open, FileAccess.Read)) {
                stream.Position = 0x04;
                return (uint)stream.ReadByte();
            }
        }

        /// <summary>
        /// Merges two archives into a single archive.
        /// </summary>
        public static void Merge(string ar, string merge) {
            GensArchive arc = new GensArchive();
            GensArchive tmpArc = new GensArchive();
            string arl = Paths.ReplaceFilename(ar, $"{Path.GetFileNameWithoutExtension(Path.GetFileNameWithoutExtension(ar))}.arl");

            CreateBackup(ar);
            Decompress.DecompressBySystem(ar);
            Decompress.DecompressBySystem(arl);
            CreateBackup(arl);

            foreach (string split in arc.GetSplitArchivesList(ar)) {
                CreateBackup(split);
                Decompress.DecompressBySystem(split);
            }

            foreach (string split in arc.GetSplitArchivesList(ar))
                arc.Load(split);

            tmpArc.Load(merge);

            foreach (var entry in tmpArc.Data) {
                arc.Data.Remove(arc.Data.Find(x => x.Name.Equals(entry.Name)));
                arc.Data.Add(entry);
            }

            arc.Save(ar, true, 99999999);
        }

        /// <summary>
        /// Creates a backup of the specified file.
        /// </summary>
        public static string CreateBackup(string file) {
            try {
                if (File.Exists(file) && !File.Exists($"{file}_back")) File.Copy(file, $"{file}_back");
                return $"{file}_back";
            } catch {
                return string.Empty;
            }
        }

        /// <summary>
        /// Restores the backup created for the file.
        /// </summary>
        public static void RestoreFromBackup(string file) {
            string originalName = file.Remove(file.Length - 5);

            if (File.Exists(originalName)) {
                if (RushInterface._debug) Console.WriteLine($"Removing: {file}");
                File.Delete(originalName);
            }

            if (File.Exists(file))
                File.Move(file, originalName);
        }
    }
}
