using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using OpenHardwareMonitor;
using OpenHardwareMonitor.Hardware;
using Microsoft.Win32;

namespace Monitor1
{
    public partial class Form1 : Form
    {
        Computer myComputer;
        List<string> installs = new List<string>();
        List<string> keys = new List<string>() {
        @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall",
        @"SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall"
};
        public Form1()
        {
            InitializeComponent();
        }
        //Kezdetek -----------------------------------------------------------------------------------------------------
        private void Form1_Load(object sender, EventArgs e)
        {
            myComputer = new Computer()
            {
                CPUEnabled = true,
                RAMEnabled = true,
                GPUEnabled = true,
                HDDEnabled = true,
                MainboardEnabled = true
            };

            myComputer.Open();
            FindInstalls(RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64), keys, installs);
            FindInstalls(RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64), keys, installs);

            installs = installs.Where(s => !string.IsNullOrWhiteSpace(s)).Distinct().ToList();
            installs.Sort();
            foreach(var item in installs)
            {
                listbox.Items.Add(item);
            }
        }
        //Ezen alapul minden -----------------------------------------------------------------------------------------------------
        private void timer1_Tick(object sender, EventArgs e)
        {
            string hardwareName = "";
            string ramname = "";
            string hddname = "";
            string GPUName = "";
            string Motherboard = "";
            float temp = 0, temp1 = 0, temp2 = 0,
            temp3 = 0, temp4 = 0 ; 
            byte count = 0;
            float totalLoad = 0, load1 = 0, load2 = 0, load3 = 0, load4 = 0;

            foreach (var hardwareItem in myComputer.Hardware)
            {
                //Motherboard -----------------------------------------------------------------------------------------------------
                if (hardwareItem.HardwareType == HardwareType.Mainboard)
                {
                    hardwareItem.Update();
                    foreach (IHardware subHardware in hardwareItem.SubHardware)
                    {
                        subHardware.Update();
                    }
                    foreach (var name in hardwareItem.Name)
                    {
                        Motherboard += name;
                    }
                }
             //CPU -----------------------------------------------------------------------------------------------------
                if (hardwareItem.HardwareType == HardwareType.CPU)
                {
                    hardwareItem.Update();
                    foreach (IHardware subHardware in hardwareItem.SubHardware)
                    {
                        subHardware.Update();
                    }
                    foreach (var name in hardwareItem.Name)
                    {
                        hardwareName += name;
                    }
                    foreach (var sensor in hardwareItem.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Load)
                        {
                            temp = sensor.Value.Value;
                        }

                        else if (sensor.SensorType == SensorType.Temperature)
                        {
                            count++;
                            switch (count)
                            {
                                case 1:
                                    load1 = sensor.Value.Value;
                                    break;
                                case 2:
                                    load2 = sensor.Value.Value;
                                    break;
                                case 3:
                                    load3 = sensor.Value.Value;
                                    break;
                                case 4:
                                    load4 = sensor.Value.Value;
                                    break;
                                case 5:
                                    totalLoad = sensor.Value.Value;
                                    break;

                            }
                        }
                    }
                }
            }
            //RAM -----------------------------------------------------------------------------------------------------
            foreach (var hardwareItem in myComputer.Hardware)
            {

                if (hardwareItem.HardwareType == HardwareType.RAM)
                {
                    hardwareItem.Update();
                    foreach (var subHardware in hardwareItem.SubHardware)
                    {
                        subHardware.Update();
                    }
                    foreach (var sensor in hardwareItem.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Load)
                        {
                            temp1 = sensor.Value.Value;
                        }
                        if (sensor.SensorType == SensorType.Data)
                        {
                            temp3 += sensor.Value.Value;
                        }
                    }
                    foreach (var name in hardwareItem.Name)
                    {
                        ramname += name;
                    }
                }
            }
            //GPU -----------------------------------------------------------------------------------------------------
            foreach (var hardwareItem in myComputer.Hardware)
            {
                if (hardwareItem.HardwareType == HardwareType.GpuNvidia)
                {
                    hardwareItem.Update();
                    foreach (IHardware subHardware in hardwareItem.SubHardware)
                    {
                        subHardware.Update();
                    }
                    foreach (var name in hardwareItem.Name)
                    {
                        GPUName += name;
                    }
                    foreach (var sensor in hardwareItem.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Temperature)
                        {
                            temp2 = sensor.Value.Value;
                        }
                        else if (sensor.SensorType == SensorType.SmallData)
                        {
                            temp4 += sensor.Value.Value;
                        }
                    }
                }
            }
            //HDD ---------------------------------------------------------------------------
            foreach (var hardwareItem in myComputer.Hardware)
            {
                if (hardwareItem.HardwareType == HardwareType.HDD)
                {
                    hardwareItem.Update();
                    foreach (var subHardware in hardwareItem.SubHardware)
                    {
                        subHardware.Update();
                    }

                        hddname += String.Format("\n{0}", hardwareItem.Name);
                }
            }
     
            //Kiiratás -----------------------------------------------------------------------------------------------------
            label1_Hardware.Text = "Processor: " + hardwareName;
            label_Memory.Text = "RAM: " + ramname;
            label_Disk.Text = "Meghajtók: " + hddname;
            label1_NVIDIA.Text = "GPU: " + GPUName;
            label_mb.Text = " Alaplap: " + Motherboard;
            label_OS.Text = " Operációs rendszer: " + getOSInfo();

            progressBar_TotalLoad.Value = Convert.ToInt32(Math.Round(totalLoad));
            progressBar_Core1Load.Value = Convert.ToInt32(Math.Round(load1));
            progressBar_Core2Load.Value = Convert.ToInt32(Math.Round(load2));
            progressBar_Core3Load.Value = Convert.ToInt32(Math.Round(load3));
            progressBar_Core4Load.Value = Convert.ToInt32(Math.Round(load4));
            progressBar_RAM.Value = Convert.ToInt32(Math.Round(temp1));
            progressBar_GPU.Value = Convert.ToInt32(Math.Round(temp2));
            

            label_totalLoad.Text = string.Format("{0:0.00}%", totalLoad);
            label_core1Load.Text = string.Format("{0:0.00}%", load1);
            label_core2Load.Text = string.Format("{0:0.00}%", load2);
            label_core3Load.Text = string.Format("{0:0.00}%", load3);
            label_core4Load.Text = string.Format("{0:0.00}%", load4);
            label_RAM.Text = string.Format("{0:0.00}%", temp1);
            label1_GPU.Text = string.Format("{0:0.00}C", temp2);
            label1_RAMGB.Text = string.Format(" Összesen: {0:0.00}GB ", temp3);
            label_GPUGB.Text = string.Format(" Összesen: {0:0.00}MB ", temp4/2);

            progressBar_cpuTemp.Value = Convert.ToInt32(Math.Round(temp));
            label_cpuTemp.Text = string.Format("{0:0.00}%", temp);
        }

        //OPERÁCIÓS RENDSZER -----------------------------------------------------------------------------------------------------
        string getOSInfo()
        {
            System.OperatingSystem os = Environment.OSVersion;
            Version vs = os.Version;
            string operatingSystem = "";

            if (os.Platform == PlatformID.Win32Windows)
            {
                switch (vs.Minor)
                {
                    case 0:
                        operatingSystem = "95";
                        break;
                    case 10:
                        if (vs.Revision.ToString() == "2222A")
                            operatingSystem = "98SE";
                        else
                            operatingSystem = "98";
                        break;
                    case 90:
                        operatingSystem = "Me";
                        break;
                    default:
                        break;
                }
            }
            else if (os.Platform == PlatformID.Win32NT)
            {
                switch (vs.Major)
                {
                    case 3:
                        operatingSystem = "NT 3.51";
                        break;
                    case 4:
                        operatingSystem = "NT 4.0";
                        break;
                    case 5:
                        if (vs.Minor == 0)
                            operatingSystem = "2000";
                        else
                            operatingSystem = "XP";
                        break;
                    case 10:
                        if (vs.Minor == 0)
                            operatingSystem = "Vista";
                        else if (vs.Minor == 1)
                            operatingSystem = "7";
                        else if (vs.Minor == 2)
                            operatingSystem = "8";
                        else
                            operatingSystem = "8.1";
                        break;
                    case 6:
                        operatingSystem = "10";
                        break;
                    default:
                        break;
                }
            }
            if (operatingSystem != "")
            {
                operatingSystem = "Windows " + operatingSystem;
                if (os.ServicePack != "")
                {
                    operatingSystem += " " + os.ServicePack;
                }     
            }
            return operatingSystem;
        }
        private void FindInstalls(RegistryKey regKey, List<string> keys, List<string> installed)
        {
        foreach (string key in keys)
        {
            using (RegistryKey rk = regKey.OpenSubKey(key))
            {
            if (rk == null)
                {
                    continue;
                }
            foreach (string skName in rk.GetSubKeyNames())
            {
                using (RegistryKey sk = rk.OpenSubKey(skName))
            {
                try
                {
                    installed.Add(Convert.ToString(sk.GetValue("DisplayName")));
                }
                catch (Exception ex)
                { }
            }
            }
            }
            }
        }

    }
}


