using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace UnrealModLoader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string gamePath = @"C:\";
        public string modDisabledPath = @"C:\";
        public string selectedGamePath = @"C:\";
        public List<string> filePaths = new List<string>();
        public bool closeAfterLaunch = false;

        private void changePathButton2_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog folderDlg = new CommonOpenFileDialog();
            folderDlg.Title = "Select disabled mods folder.";
            folderDlg.IsFolderPicker = true;
            folderDlg.Multiselect = false;
            CommonFileDialogResult result = folderDlg.ShowDialog();
            if (result == CommonFileDialogResult.Ok)
            {
                textBox1.Text = folderDlg.FileName + "\\";
                modDisabledPath = folderDlg.FileName + "\\";
                modsListBox1.Items.Clear();
                filePaths.Clear();
            }
            if ((gamePath != null && gamePath != @"C:\") && (modDisabledPath != null && modDisabledPath != @"C:\"))
            {
                RefreshList();
            }
        }

        private void changePathButton1_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog folderDlg = new CommonOpenFileDialog();
            folderDlg.Title = "Select game paks folder.";
            folderDlg.IsFolderPicker = true;
            folderDlg.Multiselect = false;
            CommonFileDialogResult result = folderDlg.ShowDialog();
            if (result == CommonFileDialogResult.Ok)
            {
                gamePathText1.Text = folderDlg.FileName + "\\";
                gamePath = folderDlg.FileName + "\\";
                modsListBox1.Items.Clear();
                filePaths.Clear();
            }
            if ((gamePath != null && gamePath != @"C:\") && (modDisabledPath != null && modDisabledPath != @"C:\"))
            {
                RefreshList();
            }
        }

        private void applyButton1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < modsListBox1.Items.Count; i++)
            {
                if (modsListBox1.GetItemCheckState(i) == CheckState.Checked)
                {
                    if (File.Exists(filePaths[i]))
                    {
                        string fileName = Path.GetFileName(filePaths[i]);
                        MoveFile(filePaths[i], gamePath + fileName);
                        modsListBox1.Items[i] = Path.GetFileName(filePaths[i]);
                    }else
                    {
                        MessageBox.Show("Error! File doesn't exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (modsListBox1.GetItemCheckState(i) == CheckState.Unchecked)
                {
                    if (File.Exists(filePaths[i]))
                    {
                        string fileName = Path.GetFileName(filePaths[i]);
                        MoveFile(filePaths[i], modDisabledPath + fileName);
                        modsListBox1.Items[i] = Path.GetFileName(filePaths[i]);
                    }
                    else
                    {
                        MessageBox.Show("Error! File doesn't exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            RefreshList();
            MessageBox.Show("Applied Mods!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void MoveFile(string filePath, string destPath)
        {
            if (Directory.Exists(Path.GetDirectoryName(destPath)) == true && filePath != destPath)
            {
                File.Move(filePath, destPath);
            }
            else if (filePath != destPath)
            {
                MessageBox.Show("Error moving file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void refreshButton1_Click(object sender, EventArgs e)
        {
            RefreshList();
        }
        
        public void RefreshList()
        {
            modsListBox1.Items.Clear();
            filePaths.Clear();
            if (gamePath != null && gamePath != @"C:\")
            {
                string[] filePath = Directory.GetFiles(Path.GetDirectoryName(gamePath));
                foreach (string file in filePath)
                {
                    string fileName = Path.GetFileName(file);
                    if (fileName.StartsWith("pakchunk99-") && fileName.EndsWith(".pak"))
                    {
                        modsListBox1.Items.Add(fileName, true);
                        filePaths.Add(file);
                    }
                }
            }
            else
            {
                MessageBox.Show("Error! Game path is null!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (modDisabledPath != null && modDisabledPath != @"C:\")
            {
                string[] filePath2 = Directory.GetFiles(Path.GetDirectoryName(modDisabledPath));
                foreach (string file in filePath2)
                {
                    string fileName = Path.GetFileName(file);
                    if (fileName.StartsWith("pakchunk99-") && fileName.EndsWith(".pak"))
                    {
                        modsListBox1.Items.Add(fileName, false);
                        filePaths.Add(file);
                    }
                }
            }
            else
            {
                MessageBox.Show("Error! Disabled mods path is null!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog exeDlg = new OpenFileDialog();
            exeDlg.Title = "Select game exe.";
            exeDlg.Multiselect = false;
            exeDlg.Filter = "exe files (*.exe)|*.exe";
            DialogResult result = exeDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBox2.Text = exeDlg.FileName;
                selectedGamePath = exeDlg.FileName;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            closeAfterLaunch = !closeAfterLaunch;
        }

        private void launchGameButton1_Click(object sender, EventArgs e)
        {
            if (File.Exists(selectedGamePath) && selectedGamePath != @"C:\")
            {
                if (Path.GetExtension(selectedGamePath) == ".exe")
                {
                    Process.Start(selectedGamePath);
                    if (closeAfterLaunch == true)
                    {
                        Application.Exit();
                    }
                }
                else
                {
                    MessageBox.Show("Error! File not exe!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error! Game exe doesnt exist or invalid path!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}