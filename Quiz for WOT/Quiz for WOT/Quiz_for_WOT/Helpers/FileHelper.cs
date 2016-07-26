using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Xamarin.Forms;
using Quiz_for_WOT.Interfaces;

namespace Quiz_for_WOT.Helpers
{
    class FileHelper : IFileHelper
    {
        IFileHelper fileHelper = DependencyService.Get<IFileHelper>();

        public bool Exists(string filename)
        {
            return fileHelper.Exists(filename);
        }

        public void WriteData(string filename, string value)
        {
            fileHelper.WriteData(filename, value);
        }

        public string ReadData(string filename)
        {
            return fileHelper.ReadData(filename);
        }

        public void Delete(string filename)
        {
            fileHelper.Delete(filename);
        }


    }
}
