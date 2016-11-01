using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;
using System.Collections;
using System.Windows;
using System.Diagnostics;
using System.IO;

namespace MineCraftLauncher
{
    public partial class MineCraftMonitor : Form
    {
        private bool locked = false;
        private string launchSettings;
        private Worker workerObject;
        private Thread workerThread;
        private DateTime restartTime;
        private DateTime crashCheckTime;
        private DateTime nextRestartWarning;
        private bool loading = false;
        public MineCraftMonitor()
        {
            InitializeComponent();
            loading = true;
            workerObject = new Worker();
            workerThread = new Thread(workerObject.DoWork);
            string temp = getTimeString(System.DateTime.Now.AddSeconds(1000000));
            cb64.Checked = Properties.Settings.Default.bit64;
            cbAR.SelectedIndex = Properties.Settings.Default.restartIntervalStep;
            nudAutoRestartInterval.Value = Properties.Settings.Default.restartInterval;
            cbCC.SelectedIndex = Properties.Settings.Default.crashCheckIntervalStep;
            nudCrashCheckInterval.Value = Properties.Settings.Default.crashCheckInterval;
            cbIMS.SelectedIndex = Properties.Settings.Default.initialMemStep;
            nudStartMem.Value = Properties.Settings.Default.initialMem;
            cbMMS.SelectedIndex = Properties.Settings.Default.maxMemStep;
            nudMaxMem.Value = Properties.Settings.Default.maxMem;
            cbRW.SelectedIndex = Properties.Settings.Default.restartWarningStep;
            nudRSW.Value =  Properties.Settings.Default.restartWarning;
            cbWI.SelectedIndex = Properties.Settings.Default.restartWarningIntervalStep;
            nudWI.Value = Properties.Settings.Default.restartWarningInterval;
            tbBackupFolder.Text = Properties.Settings.Default.BackupFolder;
            if (!String.IsNullOrEmpty(Properties.Settings.Default.jarLocation))
            {
                workerObject.ServerFile = Properties.Settings.Default.jarLocation;
                tbJarLoc.Text = Properties.Settings.Default.jarLocation;
            }
            loading = false;
        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            if (locked)
            {
                btnLock.Text = "Lock Settings";
                cbAR.Enabled = true;
                cbCC.Enabled = true;
                cbIMS.Enabled = true;
                cbMMS.Enabled = true;
                cbRW.Enabled = true;
                cbWI.Enabled = true;
                nudAutoRestartInterval.Enabled = true;
                nudCrashCheckInterval.Enabled = true;
                nudMaxMem.Enabled = true;
                nudRSW.Enabled = true;
                nudStartMem.Enabled = true;
                nudWI.Enabled = true;
                cb64.Enabled = true;
                btnSelectJar.Enabled = true;
                locked = false;
            }
            else
            {
                btnLock.Text = "Unlock Settings";
                cbAR.Enabled = false;
                cbCC.Enabled = false;
                cbIMS.Enabled = false;
                cbMMS.Enabled = false;
                cbRW.Enabled = false;
                cbWI.Enabled = false;
                nudAutoRestartInterval.Enabled = false;
                nudCrashCheckInterval.Enabled = false;
                nudMaxMem.Enabled = false;
                nudRSW.Enabled = false;
                nudStartMem.Enabled = false;
                nudWI.Enabled = false;
                cb64.Enabled = false;
                btnSelectJar.Enabled = false;
                locked = true;
            }
        }

        private void btnSelectJar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JAR files (*.jar)|*.jar";
            ofd.FilterIndex = 1;
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                tbJarLoc.Text = ofd.SafeFileName;


                Properties.Settings.Default.jarLocation = ofd.SafeFileName;
                workerObject.ServerFile = ofd.SafeFileName;
                workerObject.ServerPath = Path.GetDirectoryName(ofd.FileName);
                Properties.Settings.Default.ServerPath = Path.GetDirectoryName(ofd.FileName);
                Properties.Settings.Default.Save();

            }
        }
        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);
            DirectoryInfo[] dirs = dir.GetDirectories();

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            // If the destination directory doesn't exist, create it. 
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destDirName, file.Name);
                file.CopyTo(temppath, false);
            }

            // If copying subdirectories, copy them and their contents to new location. 
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                }
            }
        }
        private void cbIMS_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cbIMS.SelectedIndex != -1)
            {
                if (!loading)
                {
                    Properties.Settings.Default.initialMemStep = cbIMS.SelectedIndex;
                    Properties.Settings.Default.Save();
                }
                switch (cbIMS.SelectedIndex)
                {
                    case 0:
                        workerObject.sMemType = "M";
                        break;
                    case 1:
                        workerObject.sMemType = "G";
                        break;
                }
            }
        }

        private void cbMMS_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (cbMMS.SelectedIndex != -1)
            {
                if (!loading)
                {
                    Properties.Settings.Default.maxMemStep = cbMMS.SelectedIndex;
                    Properties.Settings.Default.Save();
                }
                switch (cbMMS.SelectedIndex)
                {
                    case 0:
                        workerObject.mMemType = "M";
                        break;
                    case 1:
                        workerObject.mMemType = "G";
                        break;
                }
            }
        }

        private void nudStartMem_ValueChanged(object sender, EventArgs e)
        {
            if(!loading)
            {
            Properties.Settings.Default.initialMem = (int)nudStartMem.Value;
            Properties.Settings.Default.Save();
            }
            workerObject.sMem = (int)nudStartMem.Value;
        }

        private void nudMaxMem_ValueChanged(object sender, EventArgs e)
        {
            if(!loading)
            {
            Properties.Settings.Default.maxMem = (int)nudMaxMem.Value;
            Properties.Settings.Default.Save();
            }
            workerObject.mMem = (int)nudMaxMem.Value;
        }

        private void nudCrashCheckInterval_ValueChanged(object sender, EventArgs e)
        {
            if(!loading)
            {
            Properties.Settings.Default.crashCheckInterval = ((int)nudCrashCheckInterval.Value);
            Properties.Settings.Default.Save();
            }
            if (workerObject.isworking)
            {
                crashCheckTime = System.DateTime.Now.AddSeconds(getSecondsTime(Properties.Settings.Default.crashCheckInterval, Properties.Settings.Default.crashCheckIntervalStep));
            }
        }

        private void cbCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!loading)
            {
            Properties.Settings.Default.crashCheckIntervalStep = cbCC.SelectedIndex;
            Properties.Settings.Default.Save();
            }
            if (workerObject.isworking)
            {
                crashCheckTime = System.DateTime.Now.AddSeconds(getSecondsTime(Properties.Settings.Default.crashCheckInterval, Properties.Settings.Default.crashCheckIntervalStep));
            }
        }

        private void cbAR_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!loading)
            {
            Properties.Settings.Default.restartIntervalStep = cbAR.SelectedIndex;
            Properties.Settings.Default.Save();
            }
            if (workerObject.isworking)
            {
                long tempseconds = getSecondsTime(Properties.Settings.Default.restartInterval, Properties.Settings.Default.restartIntervalStep) - getSecondsTime(Properties.Settings.Default.restartWarning, Properties.Settings.Default.restartWarningStep);
                nextRestartWarning = System.DateTime.Now.AddSeconds(tempseconds);
                restartTime = System.DateTime.Now.AddSeconds(getSecondsTime(Properties.Settings.Default.restartInterval, Properties.Settings.Default.restartIntervalStep));
            }
        }

        private void nudAutoRestartInterval_ValueChanged(object sender, EventArgs e)
        {
            if(!loading)
            {
            Properties.Settings.Default.restartInterval = ((int)nudAutoRestartInterval.Value);
            Properties.Settings.Default.Save();
            }
            if (workerObject.isworking)
            {
                long tempseconds = getSecondsTime(Properties.Settings.Default.restartInterval, Properties.Settings.Default.restartIntervalStep) - getSecondsTime(Properties.Settings.Default.restartWarning, Properties.Settings.Default.restartWarningStep);
                nextRestartWarning = System.DateTime.Now.AddSeconds(tempseconds);
                restartTime = System.DateTime.Now.AddSeconds(getSecondsTime(Properties.Settings.Default.restartInterval, Properties.Settings.Default.restartIntervalStep));
            }
        }

        private void cbRW_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!loading)
            {
            Properties.Settings.Default.restartWarningStep = cbRW.SelectedIndex;
            Properties.Settings.Default.Save();
            }
        }

        private void nudRSW_ValueChanged(object sender, EventArgs e)
        {
            if(!loading)
            {
            Properties.Settings.Default.restartWarning = ((int)nudRSW.Value);
            Properties.Settings.Default.Save();
            }
        }

        private void cbWI_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!loading)
            {
            Properties.Settings.Default.restartWarningIntervalStep = cbWI.SelectedIndex;
            Properties.Settings.Default.Save();
            }
        }
        private long getSecondsTime(int interval, int step)
        {
            switch (step)
            {
                case 0:
                    return interval;
                    break;
                case 1:
                    return interval * 60;
                    break;
                case 2:
                    return interval * 3600;
                    break;
                case 3:
                    return interval * 86400;
                    break;
            }
            return 0;
        }

        private void nudWI_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.restartWarningInterval = ((int)nudWI.Value);
            Properties.Settings.Default.Save();
        }

        private void cb64_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.bit64 = cb64.Checked;
            Properties.Settings.Default.Save();
            if (cb64.Checked)
            {
                workerObject.bit64 = " -d64";
            }
            else
            {
                workerObject.bit64 = "";
            }
        }

        private string getTimeString(DateTime time)
        {
            TimeSpan temptime = (time - DateTime.Now);
            string timecount = "";
            if (temptime.Days > 0)
            {
                if (temptime.Days > 1)
                {
                    timecount += temptime.Days + " Days ";
                }
                else
                {
                    timecount += temptime.Days + " Day ";
                }
            }
            if (temptime.Hours > 0)
            {
                if (temptime.Hours > 1)
                {
                    timecount += temptime.Hours + " Hours ";
                }
                else
                {
                    timecount += temptime.Hours + " Hour ";
                }
            }
            if (temptime.Minutes > 0)
            {
                if (temptime.Minutes > 1)
                {
                    timecount += temptime.Minutes + " Minutes ";
                }
                else
                {
                    timecount += temptime.Minutes + " Minute ";
                }
            }
            if (temptime.Seconds > 0)
            {
                if (temptime.Seconds > 1)
                {
                    timecount += temptime.Seconds + " Seconds ";
                }
                else
                {
                    timecount += temptime.Seconds + " Second ";
                }
            }
            return timecount;
        }

        private void timerSecondTick_Tick(object sender, EventArgs e)
        {
            tsslCrashCheck.Text = "Next crash check in " + getTimeString(crashCheckTime);
            if (DateTime.Compare(DateTime.Now, nextRestartWarning) > 0)
            {
                nextRestartWarning = DateTime.Now.AddSeconds(getSecondsTime(Properties.Settings.Default.restartWarningInterval, Properties.Settings.Default.restartWarningIntervalStep));
                workerObject.SendCommand("/say Next server restart in " + getTimeString(restartTime));
            }
            if (DateTime.Compare(DateTime.Now, restartTime) > 0)
            {
                if (DateTime.Compare(DateTime.Now.AddSeconds(180), crashCheckTime) > 0)
                {
                    crashCheckTime = System.DateTime.Now.AddSeconds(getSecondsTime(Properties.Settings.Default.crashCheckInterval, Properties.Settings.Default.crashCheckIntervalStep));
                }
                workerObject.SendCommand("/say Restarting server now.");
                long tempseconds = getSecondsTime(Properties.Settings.Default.restartInterval, Properties.Settings.Default.restartIntervalStep) - getSecondsTime(Properties.Settings.Default.restartWarning, Properties.Settings.Default.restartWarningStep);
                nextRestartWarning = System.DateTime.Now.AddSeconds(tempseconds);
                restartTime = System.DateTime.Now.AddSeconds(getSecondsTime(Properties.Settings.Default.restartInterval, Properties.Settings.Default.restartIntervalStep));
                tbConsole.Text += workerObject.StopServer() + "\r\n";
                workerObject.kill();
                string sourceDir = Properties.Settings.Default.ServerPath;
                string destinationDir = Properties.Settings.Default.BackupFolder + "\\" + DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString().Replace(":", "-");
                destinationDir = destinationDir.Replace(",", "");
                if((!string.IsNullOrEmpty(sourceDir))&&(!string.IsNullOrEmpty(destinationDir)))
                {
                    DirectoryCopy(sourceDir, destinationDir, true);
                }
                if (workerThread.ThreadState == System.Threading.ThreadState.Unstarted)
                {
                    workerObject.affinity = Properties.Settings.Default.Affinity;
                    workerThread.Start();
                }
                else
                {
                    workerThread = new Thread(workerObject.DoWork);
                    workerObject._shouldStop = false;
                    workerThread.Start();
                }
            }
            else if (DateTime.Compare(DateTime.Now, crashCheckTime) > 0)
            {
                crashCheckTime = System.DateTime.Now.AddSeconds(getSecondsTime(Properties.Settings.Default.crashCheckInterval, Properties.Settings.Default.crashCheckIntervalStep));
                if (!crashCheck())
                {
                    workerObject.kill();
                    if (workerThread.ThreadState == System.Threading.ThreadState.Unstarted)
                    {
                        workerObject.affinity = Properties.Settings.Default.Affinity;
                        workerThread.Start();
                    }
                    else
                    {
                        workerThread = new Thread(workerObject.DoWork);
                        workerObject._shouldStop = false;
                        workerThread.Start();
                    }
                }
                tbConsole.Text = "";
            }
            tsslRestartTime.Text = "Next server restart in " + getTimeString(restartTime);
        }
        private bool crashCheck()
        {
            TcpClient MinecraftServer = new TcpClient();
            try
            {
                MinecraftServer.Connect("127.0.0.1", 25565);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            workerObject.ServerFile = Properties.Settings.Default.jarLocation;
            workerObject.ServerPath = Properties.Settings.Default.ServerPath;
            long tempseconds = getSecondsTime(Properties.Settings.Default.restartInterval, Properties.Settings.Default.restartIntervalStep) - getSecondsTime(Properties.Settings.Default.restartWarning, Properties.Settings.Default.restartWarningStep);
            nextRestartWarning = System.DateTime.Now.AddSeconds(tempseconds);
            restartTime = System.DateTime.Now.AddSeconds(getSecondsTime(Properties.Settings.Default.restartInterval, Properties.Settings.Default.restartIntervalStep));
            crashCheckTime = System.DateTime.Now.AddSeconds(getSecondsTime(Properties.Settings.Default.crashCheckInterval, Properties.Settings.Default.crashCheckIntervalStep));
            timerSecondTick.Start();
            timerConsoleGrab.Start();
            //Thread.Sleep(5600);
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            
            if (workerThread.ThreadState == System.Threading.ThreadState.Unstarted)
            {
                workerObject.affinity = Properties.Settings.Default.Affinity;
                workerThread.Start();
            }
            else
            {
                workerThread = new Thread(workerObject.DoWork);
                workerObject._shouldStop = false;
                workerThread.Start();
            }
        }

        private void MineCraftMonitor_Load(object sender, EventArgs e)
        {
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnReStart.Enabled = false;
            btnStop.Enabled = false;
            timerSecondTick.Stop();
            tbConsole.Text += workerObject.StopServer() + "\r\n";
            workerObject.kill();
        }

        private void btnReStart_Click(object sender, EventArgs e)
        {
            workerObject.kill();
            timerSecondTick.Stop();
            timerSecondTick.Start();
            timerConsoleGrab.Stop();
            timerConsoleGrab.Start();
            tbConsole.Text = "";
            if (workerThread.ThreadState == System.Threading.ThreadState.Unstarted)
            {
                workerObject.affinity = Properties.Settings.Default.Affinity;
                workerThread.Start();
            }
            else
            {
                workerThread = new Thread(workerObject.DoWork);
                workerObject._shouldStop = false;
                workerThread.Start();
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            //if (workerObject.isworking)
            //{
                workerObject.SendCommand(tbInput.Text);
                tbInput.Text = "";
            //}
        }

        private void timerConsoleGrab_Tick(object sender, EventArgs e)
        {
            tbConsole.AppendText(workerObject.output);
            workerObject.output = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.BackupFolder = fbd.SelectedPath;
                tbBackupFolder.Text = fbd.SelectedPath;
                Properties.Settings.Default.Save();
            }
        }
    }
}

namespace MineCraftLauncher
{
    public class Worker
    {
        // This method will be called when the thread is started.
        public Worker()
        {
            isworking = false;
            _shouldStop = false;
            hasstarted = false;
            waskilled = false;
            output = "";
        }
        private bool shouldreset;
        private bool waskilled;
        public bool isreading
        {
            get;
            set;
        }
        public int affinity { get; set; }
        public void SetAffinity(int affin)
        {
            affinity = affin;
            if (hasstarted)
            {
                ServerProc.ProcessorAffinity = (IntPtr)affinity;
            }
        }
        public bool hasstarted
        {
            get;
            set;
        }
        public string StopServer()
        {
            try
            {
                ServerProc.StandardInput.WriteLine("stop");
                ServerProc.WaitForExit(10000);
                if (!ServerProc.HasExited)
                {
                    kill();
                    return "ERROR: The Server didn't want to Stop !\r\n";
                }
                else
                {

                    return "Server has stopped.";
                }
            }
            catch {
                return "Exception thrown when trying to stop server.";
            }
        }
        public void kill()
        {
            if (hasstarted)
            {
                waskilled = true;
                ServerProc.Kill();
            }

            try
            {
                foreach (Process proc in Process.GetProcessesByName("java"))
                {
                    proc.Kill();
                }
            }
            catch (Exception ex)
            {
                output += ex.ToString();
            }
        }
        public string output
        {
            get;
            set;
        }
        public string error
        {
            get;
            set;
        }
        void p_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            output += "\n" + e.Data;
        }

        private void ServerProc_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            output += e.Data + "\r\n";
        }

        private void ServerProc_Exited(object sender, EventArgs e)
        {
            // The order of these 2 lines is very important, reversing them will cause an exception
            // and you wont be able to read from the stream when you start the Process again !
        }
        public void SendCommand(string command)
        {
            try
            {
                ServerProc.StandardInput.WriteLine(command);
            }
            catch
            {
            }
        }
        public int sMem
        {
            get;
            set;
        }
        public string bit64 { get; set; }
        public int mMem { get; set; }
        public string sMemType { get; set; }
        public string mMemType { get; set; }
        public string ServerFile { get; set; }
        public string ServerPath { get; set; }
        private Process ServerProc;
        public void DoWork()
        {
            try
            {

                var startInfo = new ProcessStartInfo("java", "-Xmx" + mMem + "" + mMemType + " -Xms" + sMem + sMemType + " -XX:PermSize=128m -jar " + ServerFile + " nogui");
                // Replace the following with the location of your Minecraft Server
                startInfo.WorkingDirectory = ServerPath;
                // Notice that the Minecraft Server uses the Standard Error instead of the Standard Output
                startInfo.RedirectStandardInput = startInfo.RedirectStandardError = true;
                startInfo.UseShellExecute = false; // Necessary for Standard Stream Redirection
                startInfo.CreateNoWindow = true; // You can do either this or open it with "javaw" instead of "java"

                ServerProc = new Process();
                ServerProc.StartInfo = startInfo;
                ServerProc.EnableRaisingEvents = true;
                ServerProc.ErrorDataReceived += new DataReceivedEventHandler(ServerProc_ErrorDataReceived);
                ServerProc.Exited += new EventHandler(ServerProc_Exited);
                ServerProc.Start();
                isworking = true;
                ServerProc.BeginErrorReadLine();
                ServerProc.WaitForExit();
                isworking = false;
            }
            catch (Exception ex)
            {
                output += "FileName:\t" + ServerProc.StartInfo.FileName + "\r\n";
                output += "Arguments:\t" + ServerProc.StartInfo.Arguments + "\r\n";
                output += ex.ToString();
            }
        }
        public void RequestStop()
        {
            _shouldStop = true;
        }
        // Volatile is used as hint to the compiler that this data
        // member will be accessed by multiple threads.
        public bool _shouldStop
        {
            get;
            set;
        }
        public volatile bool isworking;
    }
}
