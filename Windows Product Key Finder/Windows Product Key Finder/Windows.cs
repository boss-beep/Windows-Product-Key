using System;
using System.Collections.Generic;
using System.Text;

namespace Windows_Product_Key_Finder
{
    class Windows
    {
        private string buildNumber = "";
        //private string buildType = null;
        private string caption = "";
        private string countryCode = "";
        private string cSDVersion = "";
        private string description = "";
        private string encryptionLevel = "";
        private string freePhysicalMemory = "";
        //private string freeSpaceInPagingFiles = null;
        private string installDate = "";
        private string lastBootUpTime = "";
        private string numberOfLicensedUsers = "";
        private string organization = "";
        //private string productType = null;
        private string registeredUser = "";
        private string serialNumber = "";
        private string servicePackMajorVersion = "";
        private string servicePackMinorVersion = "";
        private string totalVirtualMemorySize = "";
        private string totalVisibleMemorySize = "";
        private string version = "";
        //private string sizeStoredInPagingFiles = null;



        public string BuildNumber
        {
            get { return buildNumber; }
            set { buildNumber = value; }
        }

        //public string BuildType
        //{
        //    get { return buildType; }
        //    set { buildType = value; }
        //}

        public string Caption
        {
            get { return caption; }
            set { caption = value; }
        }

        public string CountryCode
        {
            get { return countryCode; }
            set { countryCode = value; }
        }

        public string CSDVersion
        {
            get { return cSDVersion; }
            set { cSDVersion = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string EncryptionLevel
        {
            get { return encryptionLevel; }
            set { encryptionLevel = value; }
        }

        public string FreePhysicalMemory
        {
            get { return freePhysicalMemory; }
            set { freePhysicalMemory = value; }
        }

        //public string FreeSpaceInPagingFiles
        //{
        //    get { return freeSpaceInPagingFiles; }
        //    set { freeSpaceInPagingFiles = value; }
        //}

        public string InstallDate
        {
            get { return installDate; }
            set { installDate = value; }
        }

        public string LastBootUpTime
        {
            get { return lastBootUpTime; }
            set { lastBootUpTime = value; }
        }

        public string NumberOfLicensedUsers
        {
            get { return numberOfLicensedUsers; }
            set { numberOfLicensedUsers = value; }
        }

        public string Organization
        {
            get { return organization; }
            set { organization = value; }
        }

        //public string ProductType
        //{
        //    get { return productType; }
        //    set { productType = value; }
        //}

        public string RegisteredUser
        {
            get { return registeredUser; }
            set { registeredUser = value; }
        }

        public string SerialNumber
        {
            get { return serialNumber; }
            set { serialNumber = value; }
        }

        public string ServicePackMajorVersion
        {
            get { return servicePackMajorVersion; }
            set { servicePackMajorVersion = value; }
        }

        public string ServicePackMinorVersion
        {
            get { return servicePackMinorVersion; }
            set { servicePackMinorVersion = value; }
        }

        public string TotalVirtualMemorySize
        {
            get { return totalVirtualMemorySize; }
            set { totalVirtualMemorySize = value; }
        }

        public string TotalVisibleMemorySize
        {
            get { return totalVisibleMemorySize; }
            set { totalVisibleMemorySize = value; }
        }

        public string Version
        {
            get { return version; }
            set { version = value; }
        }

        //public string SizeStoredInPagingFiles
        //{
        //    get { return sizeStoredInPagingFiles; }
        //    set { sizeStoredInPagingFiles = value; }
        //}

    }
}