﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace RegisterDll
{
    public partial class frmRegisterDll : Form
    {
        public frmRegisterDll()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "dll files (*.dll)|*.arx|*.dbx|*.crx|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                }
            }
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            RegistryKey localMachine = Registry.LocalMachine;
            RegistryKey applications = localMachine.OpenSubKey("", true);
            RegistryKey myProgram = applications.CreateSubKey
        }
    }
}
