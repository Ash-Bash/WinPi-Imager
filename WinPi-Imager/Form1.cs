using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinPi_Imager
{
    public partial class Form1 : Form
    {
        private int step = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.RaspiWin_Icon;
            TextBox.BackColor = System.Drawing.SystemColors.Window;
            TextBox.Lines = new string[]{ "Welcome to Windows on Raspberry Pi Imager! This program will image a modified version of Windows on ARM64 to an SD card for use with a Raspberry Pi 3B or 3B+." +
                           " You will need:", "",
                           "- An SD card with at least 16GB capacity",
                           "- A Raspberry Pi 3B or 3B+",
                           "- Time and patience","",
                           "WARNINGS:",
                           "- Imaging Windows to your SD card will take at least an hour.",
                           "- This is NOT Windows 10 IOT. It's a complete copy of Windows 10 on ARM64 with a desktop and *.exe support.",
                           "- Drivers for the Raspberry Pi are still in development. Currently used USB driver isn't that great, it can randomly stop while using it. Currently used SD card driver is " +
                           "slow as high speed is not implemented, but it works with no issues. There are no drivers for anything other than USB and SD card.",
                           "- This tool is still in development as well. If you want to help developing this tool, be sure to check out the repository on Github." };
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
            => NextButton.Enabled = CheckBox.Checked;

        private void NextButton_Click(object sender, EventArgs e)
        {
            step++;
            if (step == 1)
            {
                TextBox.Visible = false;
                TextBox.Enabled = false;
                ComboBox.Enabled = true;
                ComboBox.Visible = true;
                CheckBox.Checked = false;
                CheckBox.Visible = false;
                CheckBox.Enabled = false;
                RefreshDisksButton.Enabled = true;
                RefreshDisksButton.Visible = true;
                ContentLabel.Text = "Please select your SD card. All the data on the SD card will be destroyed and replaced\n" +
                                    "with Windows 10 ARM64 image.";
                RefreshDisks();
            }
        }

        private void RefreshDisks()
        {
            ComboBox.Items.Clear();
            ManagementObjectSearcher win32DiskDrives = new ManagementObjectSearcher("select * from Win32_DiskDrive");
            foreach (ManagementObject win32DiskDrive in win32DiskDrives.Get())
            {
                Int64 size;
                int index = Convert.ToInt32(win32DiskDrive.Properties["Index"].Value);
                string model = win32DiskDrive.Properties["Model"].Value.ToString();
                string mediaType;
                if (win32DiskDrive.Properties["Size"].Value != null)
                {
                    string sizeString = win32DiskDrive.Properties["Size"].Value.ToString();
                    size = Int64.Parse(sizeString) / 1024 / 1024 / 1024;
                }
                else
                {
                    size = 0;
                }

                if (win32DiskDrive.Properties["MediaType"].Value != null)
                {
                    mediaType = win32DiskDrive.Properties["MediaType"].Value.ToString();
                }
                else
                {
                    mediaType = "Unknown Media Type";
                }

                // diskItemsList.Add(new DiskItemObject(index, model, mediaType, size.ToString() + "GB"));
                ComboBox.Items.Add("Disk " + index + " - " + model + " - " + mediaType + " - " + size.ToString() + "GB");
            }

            if (ComboBox.Items.Count > 0)
            {
                ComboBox.SelectedIndex = 0;
                // selectedDisk = diskItemsList.ToArray()[sdCardPathComboBox.SelectedIndex];

            }
        }

        private void RefreshDisksButton_Click(object sender, EventArgs e)
        {
            RefreshDisks();
        }
    }
}
