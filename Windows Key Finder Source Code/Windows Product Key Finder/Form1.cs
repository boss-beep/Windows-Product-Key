using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Microsoft.Win32;
using System.Collections;
using System.Management;

//for DLL's  (Mouse drag)
using System.Runtime.InteropServices;


namespace Windows_Product_Key_Finder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //const and dll functions for moving form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
            int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        //Got it from http://geekswithblogs.net/willemf/archive/2006/04/23/76125.aspx
        public static string DecodeProductKey(byte[] digitalProductId)
        {
            // Offset of first byte of encoded product key in 
            //  'DigitalProductIdxxx" REG_BINARY value. Offset = 34H.
            const int keyStartIndex = 52;
            // Offset of last byte of encoded product key in 
            //  'DigitalProductIdxxx" REG_BINARY value. Offset = 43H.
            const int keyEndIndex = keyStartIndex + 15;
            // Possible alpha-numeric characters in product key.
            char[] digits = new char[]
      {
        'B', 'C', 'D', 'F', 'G', 'H', 'J', 'K', 'M', 'P', 'Q', 'R', 
        'T', 'V', 'W', 'X', 'Y', '2', '3', '4', '6', '7', '8', '9',
      };
            // Length of decoded product key
            const int decodeLength = 29;
            // Length of decoded product key in byte-form.
            // Each byte represents 2 chars.
            const int decodeStringLength = 15;
            // Array of containing the decoded product key.
            char[] decodedChars = new char[decodeLength];
            // Extract byte 52 to 67 inclusive.
            ArrayList hexPid = new ArrayList();
            for (int i = keyStartIndex; i <= keyEndIndex; i++)
            {
                hexPid.Add(digitalProductId[i]);
            }
            for (int i = decodeLength - 1; i >= 0; i--)
            {
                // Every sixth char is a separator.
                if ((i + 1) % 6 == 0)
                {
                    decodedChars[i] = '-';
                }
                else
                {
                    // Do the actual decoding.
                    int digitMapIndex = 0;
                    for (int j = decodeStringLength - 1; j >= 0; j--)
                    {
                        int byteValue = (digitMapIndex << 8) | (byte)hexPid[j];
                        hexPid[j] = (byte)(byteValue / 24);
                        digitMapIndex = byteValue % 24;
                        decodedChars[i] = digits[digitMapIndex];
                    }
                }
            }
            return new string(decodedChars);
        }

        //Got ot from http://www.csharphelp.com/board2/read.html?f=1&i=11982&t=11982
        static System.DateTime ToDateTime(string dmtfDate)
        {
            //There is a utility called mgmtclassgen that ships with the .NET SDK that
            //will generate managed code for existing WMI classes. It also generates
            // datetime conversion routines like this one.
            //Thanks to Chetan Parmar and dotnet247.com for the help.
            int year = System.DateTime.Now.Year;
            int month = 1;
            int day = 1;
            int hour = 0;
            int minute = 0;
            int second = 0;
            int millisec = 0;
            string dmtf = dmtfDate;
            string tempString = System.String.Empty;

            if (((System.String.Empty == dmtf) || (dmtf == null)))
            {
                return System.DateTime.MinValue;
            }

            if ((dmtf.Length != 25))
            {
                return System.DateTime.MinValue;
            }

            tempString = dmtf.Substring(0, 4);
            if (("****" != tempString))
            {
                year = System.Int32.Parse(tempString);
            }

            tempString = dmtf.Substring(4, 2);

            if (("**" != tempString))
            {
                month = System.Int32.Parse(tempString);
            }

            tempString = dmtf.Substring(6, 2);

            if (("**" != tempString))
            {
                day = System.Int32.Parse(tempString);
            }

            tempString = dmtf.Substring(8, 2);

            if (("**" != tempString))
            {
                hour = System.Int32.Parse(tempString);
            }

            tempString = dmtf.Substring(10, 2);

            if (("**" != tempString))
            {
                minute = System.Int32.Parse(tempString);
            }

            tempString = dmtf.Substring(12, 2);

            if (("**" != tempString))
            {
                second = System.Int32.Parse(tempString);
            }

            tempString = dmtf.Substring(15, 3);

            if (("***" != tempString))
            {
                millisec = System.Int32.Parse(tempString);
            }

            System.DateTime dateRet = new System.DateTime(year, month, day, hour, minute, second, millisec);

            return dateRet;
        }

        //Used for holding Windows infomation
        ArrayList WindowsCollection = new ArrayList();
        bool windows_getinfo_done = false;
        TextBox myWindowsHtml = new TextBox();

        private void getwindowsinfo()
        {

            WindowsCollection.Clear();
            windows_getinfo_done = false;

            try
            {
                #region Windows Info....

                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");

                Windows myWindows = new Windows();
                foreach (ManagementObject wmi_Windows in searcher.Get())
                {
                    myWindows.Caption = wmi_Windows["Caption"].ToString();
                    myWindows.CountryCode = wmi_Windows["CountryCode"].ToString();
                    #region myWindows.CSDVersion
                    try
                    {
                        myWindows.CSDVersion = wmi_Windows["CSDVersion"].ToString();
                    }
                    catch (NullReferenceException)
                    {
                        myWindows.CSDVersion = "Unknown, or no service pack installed";
                    }
                    #endregion
                    myWindows.Description = wmi_Windows["Description"].ToString();
                    myWindows.RegisteredUser = wmi_Windows["RegisteredUser"].ToString();

                    myWindows.InstallDate = wmi_Windows["InstallDate"].ToString();
                    DateTime dc = ToDateTime(myWindows.InstallDate);
                    myWindows.InstallDate = dc.AddTicks(-TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now).Ticks).ToLocalTime().ToString();

                    #region myWindows.Organization
                    try
                    {
                        myWindows.Organization = wmi_Windows["Organization"].ToString();
                    }
                    catch (NullReferenceException)
                    {
                        myWindows.Organization = "";
                    }
                    #endregion
                    myWindows.SerialNumber = wmi_Windows["SerialNumber"].ToString();
                    myWindows.Version = wmi_Windows["Version"].ToString();
                }

                #region Windows_Productkey_txt.Text
                try
                {
                    //byte[] digitalProductId = null;
                    //RegistryKey hklm = Registry.LocalMachine;
                    //hklm = hklm.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion");
                    //digitalProductId = hklm.GetValue("DigitalProductId") as byte[];
                    //Windows_Productkey_txt.Text = "Product key : " + DecodeProductKey(digitalProductId);
                }
                catch (NullReferenceException)
                {
                    //Windows_Productkey_txt.Text = "Unknown";
                }
                #endregion

                WindowsCollection.Add(myWindows);
                windows_getinfo_done = true;
                #endregion
            }
            catch (Exception i4)
            {
                MessageBox.Show(i4.ToString());
            }

        }

        private void find_txt_Click(object sender, EventArgs e)
        {

            byte[] digitalProductId = null;
            RegistryKey hklm = Registry.LocalMachine;
            hklm = hklm.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion");
            digitalProductId = hklm.GetValue("DigitalProductId") as byte[];

            textBox1.Text = DecodeProductKey(digitalProductId);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getwindowsinfo();

            if (windows_getinfo_done == true)
            {
                foreach (Windows c in WindowsCollection)
                {
                    windows_Caption_txt.Text = c.Caption;
                    windows_verison.Text = "Version : " + c.Version;
                    CSD_version.Text = "CSD Version : " + c.CSDVersion;
                    Install_Date_txt.Text = "Install Date : " + c.InstallDate;
                    Windows_serial_txt.Text = "Serial : " + c.SerialNumber;

                    Registered_User_txt.Text = "Registered User : " + c.RegisteredUser;
                    Windows_Organization_txt.Text = "Organization : " + c.Organization;
                }
            }
            else
            {
                MessageBox.Show("Sorry.. but the program has encountered\n a error and must close.\n\nRemember you must have Administrative Privileges to \nrun the program properly.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            
        }

        private void Close_txt_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Windows Product Key Finder\nVersion 1.0.0.0\n\nMade by ShoXDK", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}