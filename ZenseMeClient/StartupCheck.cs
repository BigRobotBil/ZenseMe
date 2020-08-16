using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace ZenseMe.Client
{
    class StartupCheck
    {
        /// <summary>
        /// Check to ensure that various processes/files that would otherwise stop execution are taken care of
        /// </summary>
        public StartupCheck()
        {
            ZenseMeCheck();
            ProcessCheck();
            FileCheck();
        }

        /// <summary>
        /// Prevent dupe launches by checking for ZenseMe
        /// </summary>
        private void ZenseMeCheck()
        {
            if (Process.GetProcessesByName("ZenseMe").Length > 1)
            {
                MessageBox.Show("ZenseMe is already running.", "ZenseMe");
                Environment.Exit(1);
            }
        }

        /// <summary>
        /// Various programs will preemptively block communication with MTP devices, so it's best the user
        /// disables them before actually bringing up ZenseMe
        /// </summary>
        private void ProcessCheck()
        {
            List<string> listOfProcesses = new List<string>();
            listOfProcesses.Add("Zune");
            listOfProcesses.Add("songbird");
            listOfProcesses.Add("MediaGo");
            listOfProcesses.Add("MediaMonkey");

            listOfProcesses.ForEach(delegate (String i)
            {
                if (Process.GetProcessesByName(i).Length == 1)
                {
                    MessageBox.Show("Please close " + i + "before launching ZenseMe.", "ZenseMe");
                    Environment.Exit(1);
                }
            });
        }

        /// <summary>
        /// Verify files we need to start are present.  If any are missing, fail out
        /// </summary>
        private void FileCheck()
        {
            List<string> listOfFiles = new List<string>();
            listOfFiles.Add("./Resources/Interop.PortableDeviceApiLib.dll");
            listOfFiles.Add("./Resources/Interop.PortableDeviceTypesLib.dll");
            listOfFiles.Add("./Resources/System.Data.SQLite.dll");
            listOfFiles.Add("./Resources/ZenseMeResources.dll");
            listOfFiles.Add("ZenseMe.exe.config");

            listOfFiles.ForEach(delegate (String i)
            {
                if (!File.Exists(i))
                {
                    MessageBox.Show("File: " + i + " could not be found.", "ZenseMe");
                    Environment.Exit(1);
                }
            });
        }
    }
}