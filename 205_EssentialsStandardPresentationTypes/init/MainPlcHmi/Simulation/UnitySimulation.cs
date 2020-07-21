using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Timers;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using MainPlc;

namespace MainPlcHmi.Simulation
{
    public class UnitySimulation  
    {               
        public UnitySimulation()
        {
            this.StartSimulation();            
        }
                     
        public void StartSimulation()
        {                       
            if (System.ComponentModel.LicenseManager.UsageMode != System.ComponentModel.LicenseUsageMode.Designtime)
            {
                try
                {                    
                    foreach (var runningProcess in Process.GetProcesses().Where(p => p.ProcessName == "201_Essentials_Attributes"))
                    {
                        runningProcess.Kill();
                    }

                    var execassemblypath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

                    var simulationExePath = Path.Combine(execassemblypath, @"..\..\..\..\UnityProjectExecutable\201_Essentials_Attributes.exe"); 
                    simulationExePath = Path.GetFullPath(simulationExePath);
                    var process = new Process();
                    process.StartInfo.FileName = simulationExePath;
                    string ams_id = Convert.ToString(Entry.MainPlc.Connector.Online.Parameters[0]);
                    int ads_port = Convert.ToInt16(Entry.MainPlc.Connector.Online.Parameters[1]);
                    process.StartInfo.Arguments = Environment.CommandLine + " " + "ams_id=" + ams_id + " " + "ads_port=" + ads_port.ToString();
                    process.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;

                    process.Start();
                     process.WaitForInputIdle();                                        
                }
                catch (Exception ex)
                {
                    MessageBox.Show("WPF: " + ex.Message);
                }               
            }
        }        
    }
}
