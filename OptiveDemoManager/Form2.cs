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

namespace OptiveDemoManager
{
    public partial class Form2 : Form
    {
        public Form2() //When the form loads.
        {
            InitializeComponent();
            MessageLabel.Text = ""; //Initial message.
            //Here starts the process of checking the saved text files around the exe to reload saved settings. Thes is also done when the main process runs while this form is closed.
            if (File.Exists("DemosFolderPath.txt")) //If there is a saved file there it will load it.
            {
                DemosFolderPath.Text = "";
                string CaptureDemosFolderPath = File.ReadAllText("DemosFolderPath.txt").Trim(); //Read the text file to a string. //This is how the main program will grab these strings later.
                DemosFolderPath.Text = CaptureDemosFolderPath; //Replace the path with that of the text file.
            }
            if (File.Exists("NewDemosFolderPath.txt")) //If there is a saved file there it will load it too.
            {
                NewDemosFolderPath.Text = "";
                string CaptureNewDemosFolderPath = File.ReadAllText("NewDemosFolderPath.txt").Trim(); //Read the text file to a string.
                NewDemosFolderPath.Text = CaptureNewDemosFolderPath; //Replace the path with that of the text file.
            }
            if (File.Exists("CfgFolderPath.txt")) //If there is a saved file there it will load it too.
            {
                CfgFolderPath.Text = "";
                string CaptureCfgFolderPath = File.ReadAllText("CfgFolderPath.txt").Trim(); //Read the text file to a string.
                CfgFolderPath.Text = CaptureCfgFolderPath; //Replace the path with that of the text file.
            }
            if (File.Exists("ToggleRecordAlias.txt")) //If there is a saved file there it will load it too.
            {
                ToggleRecordAlias.Text = "";
                string CaptureToggleRecordAlias = File.ReadAllText("ToggleRecordAlias.txt").Trim(); //Read the text file to a string.
                ToggleRecordAlias.Text = CaptureToggleRecordAlias; //Replace the path with that of the text file.
            }
            if (File.Exists("TF2LaunchOptions.txt")) //If there is a saved file there it will load it too.
            {
                TF2LaunchOptions.Text = "";
                string CaptureTF2LaunchOptions = File.ReadAllText("TF2LaunchOptions.txt").Trim(); //Read the text file to a string.
                TF2LaunchOptions.Text = CaptureTF2LaunchOptions; //Replace the path with that of the text file.
            }
            if (File.Exists("QuitGame.txt")) //If there is a saved file there it will load it too.
            {
                QuitGameCheckBox.Checked = true;
            }
            else
            {
                QuitGameCheckBox.Checked = false;
            }
        }

        private void SaveSettings_Click(object sender, EventArgs e)
        {
            //NewDemosFolderPath to new hidden file NewDemosFolderPath.txt
            File.Delete("NewDemosFolderPath.txt"); //Delete before creating one. If there was one it should have been loaded into the program/textbox.
            FileStream fs2 = File.Create("NewDemosFolderPath.txt"); //Create text file.
            File.SetAttributes("NewDemosFolderPath.txt", FileAttributes.Hidden); //Make hidden for cleanliness.
            StreamWriter sw2 = new StreamWriter(fs2); //Start new streamwriter to write to the doc.
            sw2.BaseStream.Seek(0, SeekOrigin.End); //Idk what this does.
            sw2.WriteLine(NewDemosFolderPath.Text.Trim()); //Write what is in the text box into the doc.
            sw2.Close(); fs2.Close();  //Close when done.

            //DemosFolderPath to new hidden file DemosFolderPath.txt
            File.Delete("DemosFolderPath.txt"); //Delete before creating one. If there was one it should have been loaded into the program/textbox.
            FileStream fs = File.Create("DemosFolderPath.txt"); //Create text file.
            File.SetAttributes("DemosFolderPath.txt", FileAttributes.Hidden); //Make hidden fo cleanliness.
            StreamWriter sw = new StreamWriter(fs); //Start new streamwriter to write to the doc.
            sw.BaseStream.Seek(0, SeekOrigin.End); //Idk what this does.
            sw.WriteLine(DemosFolderPath.Text.Trim()); //Write what is in the text box into the doc.
            sw.Close(); fs.Close();  //Close when done.

            //CfgFolderPath to new hidden file CfgFolderPath.txt
            File.Delete("CfgFolderPath.txt"); //Delete before creating one. If there was one it should have been loaded into the program/textbox.
            FileStream fs3 = File.Create("CfgFolderPath.txt"); //Create text file.
            File.SetAttributes("CfgFolderPath.txt", FileAttributes.Hidden); //Make hidden fo cleanliness.
            StreamWriter sw3 = new StreamWriter(fs3); //Start new streamwriter to write to the doc.
            sw3.BaseStream.Seek(0, SeekOrigin.End); //Idk what this does.
            sw3.WriteLine(CfgFolderPath.Text.Trim()); //Write what is in the text box into the doc.
            sw3.Close(); fs3.Close();  //Close when done.

            //ToggleRecordAlias to new hidden file ToggleRecordAlias.txt
            File.Delete("ToggleRecordAlias.txt"); //Delete before creating one. If there was one it should have been loaded into the program/textbox.
            FileStream fs1 = File.Create("ToggleRecordAlias.txt"); //Create text file.
            File.SetAttributes("ToggleRecordAlias.txt", FileAttributes.Hidden); //Make hidden fo cleanliness.
            StreamWriter sw1 = new StreamWriter(fs1); //Start new streamwriter to write to the doc.
            sw1.BaseStream.Seek(0, SeekOrigin.End); //Idk what this does.
            sw1.WriteLine(ToggleRecordAlias.Text.Trim()); //Write what is in the text box into the doc.
            sw1.Close(); fs1.Close();  //Close when done.

            //TF2LaunchOptions to new hidden file TF2LaunchOptions.txt
            File.Delete("TF2LaunchOptions.txt"); //Delete before creating one. If there was one it should have been loaded into the program/textbox.
            FileStream fs4 = File.Create("TF2LaunchOptions.txt"); //Create text file.
            File.SetAttributes("TF2LaunchOptions.txt", FileAttributes.Hidden); //Make hidden fo cleanliness.
            StreamWriter sw4 = new StreamWriter(fs4); //Start new streamwriter to write to the doc.
            sw4.BaseStream.Seek(0, SeekOrigin.End); //Idk what this does.
            sw4.WriteLine(TF2LaunchOptions.Text.Trim()); //Write what is in the text box into the doc.
            sw4.Close(); fs4.Close();  //Close when done.

            if (QuitGameCheckBox.Checked == true) //Save a QuitGame.txt so the main form knows to add this
            {
                File.Delete("QuitGame.txt"); //Delete before creating one. If there was one it should have been loaded into the program/textbox.
                FileStream QuitGamefs = File.Create("QuitGame.txt"); //Create text file.
                File.SetAttributes("QuitGame.txt", FileAttributes.Hidden); //Make hidden fo cleanliness.
                QuitGamefs.Close();  //Close when done.
            }
            else
            {
                File.Delete("QuitGame.txt"); //Delete before creating one. If there was one it should have been loaded into the program/textbox.
            }
            this.Close(); //Close this form.
        }

        private void SpecifyNewDemosFolder_Click(object sender, EventArgs e)
        {
            try
            {
                var NewDemosFolderDialog = new FolderBrowserDialog(); //What folder to extract demos from.
                NewDemosFolderDialog.ShowDialog();
                NewDemosFolderDialog.Description = "Choose the folder where your demos were recorded to.";
                NewDemosFolderPath.Text = NewDemosFolderDialog.SelectedPath;
            }
            catch
            {
                MessageLabel.Text = "There was a problem fetching the file path for the new demos folder check if the paths are correct.";
            }
        }

        private void ClearNewDemosFolderPath_Click(object sender, EventArgs e)
        {
            NewDemosFolderPath.Text = "";
        }

        private void NewDemosFolderPathPaste_Click(object sender, EventArgs e)
        {
            NewDemosFolderPath.Text = Clipboard.GetText(); //Copy text from Clipboard to variable.
        }

        private void SpecifyDemosFolder_Click(object sender, EventArgs e)
        {
            try //SpecifyDemosFolder
            {
                var DemosFolderDialog = new FolderBrowserDialog(); //What folder to extract demos from.
                DemosFolderDialog.ShowDialog();
                DemosFolderDialog.Description = "Choose the folder where your demos were recorded to.";
                DemosFolderPath.Text = DemosFolderDialog.SelectedPath;
            }
            catch
            {
                MessageLabel.Text = "There was a problem fetching the file path for the demos folder check if the paths are correct.";
            }
        }

        private void ClearDemosFolderPath_Click(object sender, EventArgs e)
        {
            DemosFolderPath.Text = "";
        }

        private void ClearCfgFolderPath_Click(object sender, EventArgs e)
        {
            CfgFolderPath.Text = "";
        }

        private void SpecifyCfgFolder_Click(object sender, EventArgs e)
        {
            try //SpecifyCfgFolder
            {
                var CfgFolderDialog = new FolderBrowserDialog(); //What folder to extract demos from.
                CfgFolderDialog.ShowDialog();
                CfgFolderDialog.Description = "Choose the folder where your demos were recorded to.";
                CfgFolderPath.Text = CfgFolderDialog.SelectedPath;
            }
            catch
            {
                MessageLabel.Text = "There was a problem fetching the file path for the cfg folder check if the paths are correct.";
            }
        }

        private void ToggleRecordAliasClear_Click(object sender, EventArgs e)
        {
            ToggleRecordAlias.Text = "";
        }

        private void ToggleRecordAliasAviRecorder_Click(object sender, EventArgs e)
        {
            ToggleRecordAlias.Text = "avi_recorder_startstop";
        }

        private void TF2LaunchOptionsClear_Click(object sender, EventArgs e)
        {
            TF2LaunchOptions.Text = "";
        }
    }
}
