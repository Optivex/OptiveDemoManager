//What a mess
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
    public partial class OptiveDemoManager : Form
    {
        public OptiveDemoManager() //When the program is launched.
        {
            InitializeComponent();
            ImportSavedSettings();
            Log(""); //Leave a line each time the program is reloaded.
            Log("Program launched.");
            File.SetAttributes("OptiveDemoManager.log", FileAttributes.Hidden); //Make hidden fo cleanliness.
        }

        private void Log(string error)
        {
            if(error == "")
            {
                File.AppendAllText("OptiveDemoManager.log", error + "\n");
            }
            else
            {
                File.AppendAllText("OptiveDemoManager.log", DateTime.Now + ": " + error + "\n");
            }
        }

        private void PasteBothTicks_Click(object sender, EventArgs e) //This is the handy paste both ticks function.
        {
            try
            {
                string BothTicks = Clipboard.GetText(); //Get clipboard to variable.
                BothTicks = BothTicks.Trim(); //Trim spaces on the sides of the string if there are any.
                string part1 = BothTicks.Substring(0, (BothTicks.Length / 2)); //Now we cut the string in half to separate the ticks then trim the extra white spaces:
                string part2 = BothTicks.Substring((BothTicks.Length / 2), BothTicks.Length - (BothTicks.Length / 2));
                part1 = part1.Trim(); //Trim it.
                part2 = part2.Trim(); //^
                if (Convert.ToInt32(part1) > Convert.ToInt32(part2)) //If the start tick is greater than the stop tick then warn the user and stop entering data.
                {
                    MessageLabel.Text = "The start tick you pasted is greater than the stop tick! Check again.";
                }
                else //Otherwise it can do the paste properly.
                {
                    StartTick.Text = part1;
                    StopTick.Text = part2;
                    MessageLabel.Text = "Ticks entered.";
                }
            }
            catch
            {
                MessageLabel.Text = "Ticks were not numeric or something else went wrong.";
            }
        }

        private void ImportSavedSettings()
        {
            MessageLabel.Text = "Backup all demos first! Also run TF2 in windowed for quicker alt tabbing.";

            //Import saved settings for the textboxes on this form.
            if (File.Exists("DemoFileName.txt"))
            {
                DemoFileName.Text = "";
                string CaptureDemoFileName = File.ReadAllText("DemoFileName.txt"); //Read the text file to a string.
                DemoFileName.Text = CaptureDemoFileName; //Replace the path with that of the text file.
            }
            if (File.Exists("StartTick.txt"))
            {
                StartTick.Text = "";
                string CaptureStartTick = File.ReadAllText("StartTick.txt"); //Read the text file to a string.
                StartTick.Text = CaptureStartTick; //Replace the path with that of the text file.
            }
            if (File.Exists("StopTick.txt"))
            {
                StopTick.Text = "";
                string CaptureStopTick = File.ReadAllText("StopTick.txt"); //Read the text file to a string.
                StopTick.Text = CaptureStopTick; //Replace the path with that of the text file.
            }
            if (File.Exists("NewDemoFileName.txt"))
            {
                NewDemoFileName.Text = "";
                string CaptureNewDemoFileName = File.ReadAllText("NewDemoFileName.txt"); //Read the text file to a string.
                NewDemoFileName.Text = CaptureNewDemoFileName; //Replace the path with that of the text file.
            }
            if (File.Exists("NextDemoLocation.txt"))
            {
                NextDemoLocation.Text = "";
                string CaptureNextDemoLocation = File.ReadAllText("NextDemoLocation.txt"); //Read the text file to a string.
                NextDemoLocation.Text = CaptureNextDemoLocation; //Replace the path with that of the text file.
            }
        }

        private void MoveTheDemo() //Function to move and rename the demo if the settings are configured correctly.
        {
            try
            {
                //If the saved settings are there we can move and rename the demo.
                //If there are the required settings stored it can run this process.
                if (File.Exists("DemosFolderPath.txt") & File.Exists("NewDemosFolderPath.txt") & File.Exists("DemoFileName.txt") & File.Exists("NewDemoFileName.txt"))
                {
                    string DemoPath = File.ReadAllText("DemosFolderPath.txt").Trim(); //Read the text file to a string if it's there.
                    string DemoName = File.ReadAllText("DemoFileName.txt").Trim();
                    DemoPath += @"\" + DemoName + ".dem"; //Add name and file extention.

                    string NewDemoPath = File.ReadAllText("NewDemosFolderPath.txt").Trim(); //Read the text file to a string.
                    string NewDemoFileName = File.ReadAllText("NewDemoFileName.txt").Trim(); //Read the text file to a string.
                    NewDemoPath += @"\" + NewDemoFileName + ".dem"; //Add name and file extention.
                    try //Move and rename the demo to the specified location
                    {
                        System.IO.File.Move(DemoPath.Trim(), NewDemoPath.Trim());
                    }
                    catch
                    {
                        Log("'Move and rename the demo to the specified location' did not work check the file paths");
                        Log("DemoPath = " + DemoPath);
                        Log("DemoName = " + DemoName);
                        Log("NewDemoPath = " + NewDemoPath);
                        Log("NewDemoFileName = " + NewDemoFileName);
                    }
                }
                else
                {
                    Log("Some setting files were not found, make sure to save your settings and enter all data correctly.");
                }
            }
            catch
            {
                Log("There was a problem running the MoveTheDemo function (moving and renaming the demo file).");
            }
        }

        private void SaveUserSettings()
        {
            try //This will take the strings in the textboxes and save them to text documents upon closing to be loaded again on launch.
            {
                //NewDemoFileName to new hidden file NewDemoFileName.txt
                File.Delete("NewDemoFileName.txt"); //Delete before creating one. If there was one it should have been loaded into the textbox.
                FileStream fs3 = File.Create("NewDemoFileName.txt"); //Create text file.
                File.SetAttributes("NewDemoFileName.txt", FileAttributes.Hidden); //Make hidden fo cleanliness.
                StreamWriter sw3 = new StreamWriter(fs3); //Start new streamwriter to write to the doc.
                sw3.BaseStream.Seek(0, SeekOrigin.End); //Idk what this does.
                sw3.WriteLine(NewDemoFileName.Text.Trim()); //Write what is in the text box into the doc.
                sw3.Close(); fs3.Close();  //Close when done.

                //NextDemoLocation to new hidden file NextDemoLocation.txt
                File.Delete("NextDemoLocation.txt"); //Delete before creating one. If there was one it should have been loaded into the textbox.
                FileStream fs4 = File.Create("NextDemoLocation.txt"); //Create text file.
                File.SetAttributes("NextDemoLocation.txt", FileAttributes.Hidden); //Make hidden fo cleanliness.
                StreamWriter sw4 = new StreamWriter(fs4); //Start new streamwriter to write to the doc.
                sw4.BaseStream.Seek(0, SeekOrigin.End); //Idk what this does.
                sw4.WriteLine(NextDemoLocation.Text.Trim()); //Write what is in the text box into the doc.
                sw4.Close(); fs4.Close();  //Close when done.

                //StartTick to new hidden file StartTick.txt
                File.Delete("StartTick.txt"); //Delete before creating one. If there was one it should have been loaded into the textbox.
                FileStream fs5 = File.Create("StartTick.txt"); //Create text file.
                File.SetAttributes("StartTick.txt", FileAttributes.Hidden); //Make hidden fo cleanliness.
                StreamWriter sw5 = new StreamWriter(fs5); //Start new streamwriter to write to the doc.
                sw5.BaseStream.Seek(0, SeekOrigin.End); //Idk what this does.
                sw5.WriteLine(StartTick.Text.Trim()); //Write what is in the text box into the doc.
                sw5.Close(); fs5.Close();  //Close when done.

                //StopTick to new hidden file StopTick.txt
                File.Delete("StopTick.txt"); //Delete before creating one. If there was one it should have been loaded into the textbox.
                FileStream fs6 = File.Create("StopTick.txt"); //Create text file.
                File.SetAttributes("StopTick.txt", FileAttributes.Hidden); //Make hidden fo cleanliness.
                StreamWriter sw6 = new StreamWriter(fs6); //Start new streamwriter to write to the doc.
                sw6.BaseStream.Seek(0, SeekOrigin.End); //Idk what this does.
                sw6.WriteLine(StopTick.Text.Trim()); //Write what is in the text box into the doc.
                sw6.Close(); fs6.Close();  //Close when done.

                //DemoFileName to new hidden file DemoFileName.txt
                File.Delete("DemoFileName.txt"); //Delete before creating one. If there was one it should have been loaded into the textbox.
                FileStream fs7 = File.Create("DemoFileName.txt"); //Create text file.
                File.SetAttributes("DemoFileName.txt", FileAttributes.Hidden); //Make hidden fo cleanliness.
                StreamWriter sw7 = new StreamWriter(fs7); //Start new streamwriter to write to the doc.
                sw7.BaseStream.Seek(0, SeekOrigin.End); //Idk what this does.
                sw7.WriteLine(DemoFileName.Text.Trim()); //Write what is in the text box into the doc.
                sw7.Close(); fs7.Close();  //Close when done.
            }
            catch
            {
                Log("There was a problem saving the user settings.");
            }
        }

        private void CreateVDM()
        {
            if (File.Exists("StartTick.txt") & File.Exists("StopTick.txt") & File.Exists("NewDemoFileName.txt")) //If the saved ticks are found we c
            {
                string CaptureStartTick = File.ReadAllText("StartTick.txt").Trim(); //Read the text file to a string.
                string CaptureStopTick = File.ReadAllText("StopTick.txt").Trim(); //^

                if (Convert.ToInt32(CaptureStartTick) > Convert.ToInt32(CaptureStopTick)) //if the start tick is greater than the stop tick:
                {
                    MessageLabel.Text = "The start tick is greater than the stop tick. Check your data and try again.";
                }
                else //Otherwise we can continue and write the VDM file.
                {
                    //Choosing the file path to save the VDM file.
                    //path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); //Get desktop path.
                    string VDMFilePath = File.ReadAllText("NewDemosFolderPath.txt").Trim(); //Read the text file to a string.
                    string NextDemoLocation = File.ReadAllText("NextDemoLocation.txt").Trim(); //Read the text file to a string.
                    string ToggleRecordAlias = "avi_recorder_startstop"; //Default if the saved setting doesn't work.
                    ToggleRecordAlias = File.ReadAllText("ToggleRecordAlias.txt").Trim(); //Read the text file to a string.
                    VDMFilePath += @"\" + NewDemoFileName.Text.Trim() + ".vdm"; //Append VDM file name to this path.

                    File.Create(VDMFilePath).Close(); //Creates the VDM file and closes to erase already existing file with the same name.

                    //New file stream to write to.
                    FileStream fs = new FileStream(VDMFilePath, FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(fs);
                    sw.BaseStream.Seek(0, SeekOrigin.End);
                    //Maths
                    int PlayNextDemoTick = 0, SkipToTick = 0, CommandNumber = 1;

                    try //Try to convert the data and create the new variables.
                    {
                        PlayNextDemoTick = Convert.ToInt32(CaptureStopTick) + 100; //The play next demo playcommand will be a bit after the stop tick
                        SkipToTick = Convert.ToInt32(CaptureStartTick) - 1000; //The skip to tick will skip to 1000 ticks before this will hopefully reduce glitched partcles.
                    }
                    catch
                    {
                        Log("Error converting strings to int or retreiving settings, you must have entered letters in your ticks.");
                        sw.Flush(); sw.Close(); //Stop right there criminal scum.
                        File.Delete(VDMFilePath); //Delete the file because we couldn't process the ticks.
                    }

                    if (PlayNextDemoTick != 0 & (SkipToTick + 100) != 0) //If zero then it means the data was not entered or processed correctly so stop on else.
                    {
                        try //Writing to the file
                        {
                            sw.WriteLine("demoactions");
                            sw.WriteLine("{");
                            sw.WriteLine("	\"" + CommandNumber + "\"");
                            sw.WriteLine("	{");
                            sw.WriteLine("		factory \"PlayCommands\"");
                            sw.WriteLine("		name \"StartRecording\"");
                            sw.WriteLine("		starttick \"" + CaptureStartTick + "\"");
                            sw.WriteLine("		commands \"" + ToggleRecordAlias + "\"");
                            sw.WriteLine("	}");
                            CommandNumber += 1; //If this part is written the command number will go up one.
                            sw.WriteLine("	\"" + CommandNumber + "\"");
                            sw.WriteLine("	{");
                            sw.WriteLine("		factory \"PlayCommands\"");
                            sw.WriteLine("		name \"StopRecording\"");
                            sw.WriteLine("		starttick \"" + CaptureStopTick + "\"");
                            sw.WriteLine("		commands \"" + ToggleRecordAlias + "\"");
                            sw.WriteLine("	}");
                            if (NextDemoLocation != "") //If they entered in a next demo location then write a playdemo command for it.
                            {
                                CommandNumber += 1; //If this part is written the command number will go up one.
                                sw.WriteLine("	\"" + CommandNumber + "\"");
                                sw.WriteLine("	{");
                                sw.WriteLine("		factory \"PlayCommands\"");
                                sw.WriteLine("		name \"PlayNextDemo\"");
                                sw.WriteLine("		starttick \"" + PlayNextDemoTick + "\"");
                                sw.WriteLine("		commands \"playdemo " + NextDemoLocation + "\"");
                                sw.WriteLine("	}");
                            }
                            else //Otherwise they didn't so don't write one and continue.
                            {

                            }
                            if (SkipToTick >= 150) //Otherwise do make a skipahead.
                            {
                                CommandNumber += 1; //If this part is written the command number will go up one.
                                sw.WriteLine("	\"" + CommandNumber + "\"");
                                sw.WriteLine("	{");
                                sw.WriteLine("		factory \"SkipAhead\"");
                                sw.WriteLine("		name \"skipthere\"");
                                sw.WriteLine("		starttick \"100\"");
                                sw.WriteLine("		skiptotick \"" + SkipToTick + "\"");
                                sw.WriteLine("	}");
                            }
                            if (File.Exists("QuitGame.txt")) //If the user wants the demo to quit after recording.
                            {
                                CommandNumber += 1; //If this part is written the command number will go up one.
                                sw.WriteLine("	\"" + CommandNumber + "\"");
                                sw.WriteLine("	{");
                                sw.WriteLine("		factory \"PlayCommands\"");
                                sw.WriteLine("		name \"QuitGame\"");
                                sw.WriteLine("		starttick \"" + (PlayNextDemoTick - 50) + "\"");
                                sw.WriteLine("		commands \"quit" + "\"");
                                sw.WriteLine("	}");
                            }
                            sw.WriteLine("}"); //End the script here.
                        }
                        catch
                        {
                            CommandNumber = 0;
                            Log("There was a problem writing to the vdm file.");
                            sw.Flush(); sw.Close(); //Stop right there criminal scum.
                            File.Delete(VDMFilePath); //Delete the file because we couldn't write properly.
                        }
                        //flush and close the filestream writer at the end of the day
                        sw.Flush(); sw.Close();
                    }
                    else
                    {
                        Log("There was a problem processing the data you entered.");
                        sw.Flush(); sw.Close(); //Stop right there criminal scum.
                        File.Delete(VDMFilePath); //Delete the file because we couldn't process the ticks.
                    }
                }
            }
            else
            {
                Log("The required settings to create the VDM file were not found.");
            }
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            SaveUserSettings(); //Saves the text entered to a text doc to be reloaded on program launch. Must run before other functions because they use it.
            MoveTheDemo(); //Function to move and rename the demo if the settings are there.
            CreateVDM(); //Creates the vdm in the specidied location same name as the demo.
        }

        private void DemoFileNamePlus1_Click(object sender, EventArgs e)
        {
            try // to add 1 to the string in the newdemofilename text field.
            {
                string DemoNameText, PreviousNewDemoName;
                PreviousNewDemoName = NewDemoFileName.Text;
                int DemoNameNumber;

                DemoNameNumber = Convert.ToInt32(string.Join("", NewDemoFileName.Text.ToCharArray().Where(Char.IsDigit))); //Reduce the string to only numbers (no characters/letters) & capture this new number as an integer.
                DemoNameText = string.Join("", NewDemoFileName.Text.ToCharArray().Where(Char.IsLetter));
                DemoNameNumber += 1; //Add 1 to the number.
                NewDemoFileName.Text = DemoNameText + DemoNameNumber;
                MessageLabel.Text = "The new demo name has been changed from " + PreviousNewDemoName + " to " + DemoNameText + DemoNameNumber;
            }
            catch
            {
                MessageLabel.Text = "The new demo name must have a number on the end to add to to use this function.";
            }
            try //To add 1 to the number on the end of playnextdemo if there is one.
            {
                if (NextDemoLocation.Text != "") //Is not nothing.
                {
                    //A pretty lame way to: Remove all numbers from a textbox string and I could have used a loop here for the number but I can't be stuffed atm.
                    NextDemoLocation.Text = NextDemoLocation.Text.Replace("1", "");
                    NextDemoLocation.Text = NextDemoLocation.Text.Replace("2", "");
                    NextDemoLocation.Text = NextDemoLocation.Text.Replace("3", "");
                    NextDemoLocation.Text = NextDemoLocation.Text.Replace("4", "");
                    NextDemoLocation.Text = NextDemoLocation.Text.Replace("5", "");
                    NextDemoLocation.Text = NextDemoLocation.Text.Replace("6", "");
                    NextDemoLocation.Text = NextDemoLocation.Text.Replace("7", "");
                    NextDemoLocation.Text = NextDemoLocation.Text.Replace("8", "");
                    NextDemoLocation.Text = NextDemoLocation.Text.Replace("9", "");
                    NextDemoLocation.Text = NextDemoLocation.Text.Replace("0", "");

                    //Now that the numbers are gone we need to get the numbers from the above textbox and add one to it then stick it back on the end.
                    int DemoNameNumber;
                    DemoNameNumber = Convert.ToInt32(string.Join("", NewDemoFileName.Text.ToCharArray().Where(Char.IsDigit))); //Reduce the string to only numbers (no characters/letters) & capture this new number as an integer.
                    DemoNameNumber += 1; //Add 1 to it.
                    NextDemoLocation.Text = NextDemoLocation.Text + DemoNameNumber; //Append to the end.
                }
                else
                {
                    Log("NextDemoLocation not found, not adding 1 to the textbox string.");
                }
            }
            catch
            {
                Log("Failed to add 1 to the NextDemoLocation textbox.");
            }
        }

        private void ClearNextDemoLocation_Click(object sender, EventArgs e)
        {
            NextDemoLocation.Text = "";
        }

        private void TickClear_Click(object sender, EventArgs e)
        {
            StartTick.Text = "";
            StopTick.Text = "";
            Log("Cleared the tickboxes.");
        }

        private void NewDemoFileNameClear_Click(object sender, EventArgs e)
        {
            NewDemoFileName.Text = "";
        }

        private void DemoFileNameClear_Click(object sender, EventArgs e)
        {
            DemoFileName.Text = "";
        }

        private void DemoFileNamePaste_Click(object sender, EventArgs e)
        {
            DemoFileName.Text = Clipboard.GetText(); //Copy text from Clipboard to variable.
        }

        private void StartTickClear_Click(object sender, EventArgs e)
        {
            StartTick.Text = "";
        }

        private void StopTickClear_Click(object sender, EventArgs e)
        {
            StopTick.Text = "";
        }

        private void IncreaseRange_Click(object sender, EventArgs e)
        {
            try
            {
                int NewStopTick = Convert.ToInt32(StopTick.Text);
                NewStopTick += 100;
                StopTick.Text = Convert.ToString(NewStopTick);
                int NewStartTick = Convert.ToInt32(StartTick.Text);
                NewStartTick -= 100;
                StartTick.Text = Convert.ToString(NewStartTick);
            }
            catch
            {
                MessageLabel.Text = "MATH ERROR";
            }
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            Form2 op = new Form2();
            op.Show();
        }

        private void DemoFileName_TextChanged(object sender, EventArgs e)
        {
            Log("DemoFileName text was changed, updating the playdemo config file.");

            //SAVE THE DemoFileName to new hidden file DemoFileName.txt
            File.Delete("DemoFileName.txt"); //Delete before creating one. If there was one it should have been loaded into the textbox.
            FileStream fs7 = File.Create("DemoFileName.txt"); //Create text file.
            File.SetAttributes("DemoFileName.txt", FileAttributes.Hidden); //Make hidden fo cleanliness.
            StreamWriter sw7 = new StreamWriter(fs7); //Start new streamwriter to write to the doc.
            sw7.BaseStream.Seek(0, SeekOrigin.End); //Idk what this does.
            sw7.WriteLine(DemoFileName.Text.Trim()); //Write what is in the text box into the doc.
            sw7.Close(); fs7.Close();  //Close when done.

            Log("DemoFileName has been saved.");

            string CfgFolderPath = File.ReadAllText("CfgFolderPath.txt").Trim(); //Get the cfg folder path
            string DemoName = File.ReadAllText("DemoFileName.txt").Trim();
            CfgFolderPath += @"\OptivePlayDemo.cfg"; //Append cfg file name to this path.

            string PlayDemoPath = File.ReadAllText("DemosFolderPath.txt").Trim();
            //C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\demos\ds
            string RemoveFromPlayDemoPath = PlayDemoPath.Remove(PlayDemoPath.LastIndexOf("tf\\")); //I want before the tf\ to be removed
            PlayDemoPath = PlayDemoPath.Replace(RemoveFromPlayDemoPath, ""); //Delet this
            PlayDemoPath = PlayDemoPath.Replace("tf\\", ""); //Delet this too
            PlayDemoPath = "playdemo " + PlayDemoPath + @"\" + DemoName;
            Log("PlayDemoPath = " + PlayDemoPath);

            //NextDemoLocation to new hidden file NextDemoLocation.txt
            File.Delete(CfgFolderPath); //Delete before creating one. If there was one it should have been loaded into the textbox.
            FileStream PlayDemoConfigfs = File.Create(CfgFolderPath); //Create text file.
            StreamWriter PlayDemoConfigsw = new StreamWriter(PlayDemoConfigfs); //Start new streamwriter to write to the doc.
            PlayDemoConfigsw.BaseStream.Seek(0, SeekOrigin.End); //Idk what this does.
            PlayDemoConfigsw.WriteLine(PlayDemoPath); //Write what is in the text box into the doc.
            PlayDemoConfigsw.Close(); PlayDemoConfigfs.Close();  //Close when done.
        }

        private void DelCurrentDemo_Click(object sender, EventArgs e)
        {
            DelCurrentDemo.Enabled = false;
            DelCurrentDemoConfirm.Enabled = true;
        }

        private void DelCurrentDemoConfirm_Click(object sender, EventArgs e)
        {
            DelCurrentDemo.Enabled = true;
            DelCurrentDemoConfirm.Enabled = false;
            string DemoPath = File.ReadAllText("DemosFolderPath.txt").Trim(); //Read the text file to a string if it's there.
            string DemoName = File.ReadAllText("DemoFileName.txt").Trim();
            DemoPath += @"\" + DemoName + ".dem"; //Add name and file extention.
            try
            {
                File.Delete(DemoPath);
            }
            catch
            {
                MessageLabel.Text = "Failed to delete the demo, it might not be there.";
            }
        }
    }
}
