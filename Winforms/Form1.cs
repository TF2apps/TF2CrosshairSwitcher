using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Media;


namespace Winforms
{
    public partial class Form1 : Form
    {
        #region --Variables--

        SoundPlayer pearlSound = new SoundPlayer(Properties.Resources.PEARL);

        public string vmtOutput =
            @"""UnlitGeneric""" + "\n" +
            "{" + "\n" +
                @"	""$translucent""	1" + "\n" +
                @"	""$basetexture"" ""vgui\replay\thumbnails\*""" + "\n" +
                @"	""$vertexcolor"" 1" + "\n" +
                @"	""$no_fullbright"" 1" + "\n" +
                @"	""$ignorez"" 1" + "\n" +
            "}";

        public string selectedCrosshair = ""; // Might not need to use this

        public List<string> listPrimary = new List<string>();
        public List<string> listSecondary = new List<string>();
        public List<string> listMelee = new List<string>();
        public List<string> listSpecial = new List<string>();

        public List<string> selectedClasses = new List<string>();

        public int toggleButtonScout = 0;
        public int toggleButtonSoldier = 0;
        public int toggleButtonPyro = 0;
        public int toggleButtonDemo = 0;
        public int toggleButtonHeavy = 0;
        public int toggleButtonEngie = 0;
        public int toggleButtonMedic = 0;
        public int toggleButtonSniper = 0;
        public int toggleButtonSpy = 0;

        public Color colorButtonUnChecked = Color.Gainsboro;
        public Color colorButtonIsChecked = Color.PowderBlue;

        #endregion --Variables--

        public Form1()
        {
            InitializeComponent();

            askDirectory();
        }

        #region --File Menu--

        private void askDirectory() // Ask for the directory location if it doesn't exist already
        {
            if (String.IsNullOrWhiteSpace((string)Properties.Settings.Default["dir"]))
            {
                getDirectory();
            }
            else
                buildCrosshairLists();
        }

        private void getDirectory()
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.Description = @"Please select your ""crosshairs"" folder most likely located in tf/custom." + "\n" + @"This should contain your ""materials"" and ""scripts"" folders.";
            DialogResult res = dlg.ShowDialog();

            if (res == DialogResult.OK)
            {
                Properties.Settings.Default["dir"] = dlg.SelectedPath;
                Properties.Settings.Default.Save();
            }

            buildCrosshairLists();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getDirectory();
        }

        #endregion --File Menu--

        #region --Class Select--
        private void buttonScout_Click(object sender, EventArgs e)
        {
            if (toggleButtonScout == 1) // Set the button to the default, unclicked state
            {
                buttonScout.BackColor = colorButtonUnChecked;
                toggleButtonScout = 0;
                selectedClasses.Remove("SCOUT");
                
            }
            else // Set the button to the clicked state
            {
                buttonScout.BackColor = colorButtonIsChecked;
                toggleButtonScout = 1;
                selectedClasses.Add("SCOUT");
            }

            buildListBoxItems();
            uncheckAllCheckBoxes();
        }

        private void buttonSoldier_Click(object sender, EventArgs e)
        {
            if (toggleButtonSoldier == 1) // Set the button to the default, unclicked state
            {
                buttonSoldier.BackColor = colorButtonUnChecked;
                toggleButtonSoldier = 0;
                selectedClasses.Remove("SOLDIER");
            }
            else // Set the button to the clicked state
            {
                buttonSoldier.BackColor = colorButtonIsChecked;
                toggleButtonSoldier = 1;
                selectedClasses.Add("SOLDIER");
            }

            buildListBoxItems();
            uncheckAllCheckBoxes();
        }

        private void buttonPyro_Click(object sender, EventArgs e)
        {
            if (toggleButtonPyro == 1) // Set the button to the default, unclicked state
            {
                buttonPyro.BackColor = colorButtonUnChecked;
                toggleButtonPyro = 0;
                selectedClasses.Remove("PYRO");
            }
            else // Set the button to the clicked state
            {
                buttonPyro.BackColor = colorButtonIsChecked;
                toggleButtonPyro = 1;
                selectedClasses.Add("PYRO");
            }

            buildListBoxItems();
            uncheckAllCheckBoxes();
        }

        private void buttonDemo_Click(object sender, EventArgs e)
        {
            if (toggleButtonDemo == 1) // Set the button to the default, unclicked state
            {
                buttonDemo.BackColor = colorButtonUnChecked;
                toggleButtonDemo = 0;
                selectedClasses.Remove("DEMOMAN");
            }
            else // Set the button to the clicked state
            {
                buttonDemo.BackColor = colorButtonIsChecked;
                toggleButtonDemo = 1;
                selectedClasses.Add("DEMOMAN");
            }

            buildListBoxItems();
            uncheckAllCheckBoxes();
        }

        private void buttonHeavy_Click(object sender, EventArgs e)
        {
            if (toggleButtonHeavy == 1) // Set the button to the default, unclicked state
            {
                buttonHeavy.BackColor = colorButtonUnChecked;
                toggleButtonHeavy = 0;
                selectedClasses.Remove("HEAVYWEAPONS");
            }
            else
            {
                buttonHeavy.BackColor = colorButtonIsChecked;
                toggleButtonHeavy = 1;
                selectedClasses.Add("HEAVYWEAPONS");
            }

            buildListBoxItems();
            uncheckAllCheckBoxes();
        }

        private void buttonEngie_Click(object sender, EventArgs e)
        {
            if (toggleButtonEngie == 1) // Set the button to the default, unclicked state
            {
                buttonEngie.BackColor = colorButtonUnChecked;
                toggleButtonEngie = 0;
                selectedClasses.Remove("ENGINEER");
            }
            else
            {
                buttonEngie.BackColor = colorButtonIsChecked;
                toggleButtonEngie = 1;
                selectedClasses.Add("ENGINEER");
            }

            buildListBoxItems();
            uncheckAllCheckBoxes();
        }

        private void buttonMedic_Click(object sender, EventArgs e)
        {
            if (toggleButtonMedic == 1) // Set the button to the default, unclicked state
            {
                buttonMedic.BackColor = colorButtonUnChecked;
                toggleButtonMedic = 0;
                selectedClasses.Remove("MEDIC");
            }
            else
            {
                buttonMedic.BackColor = colorButtonIsChecked;
                toggleButtonMedic = 1;
                selectedClasses.Add("MEDIC");
            }

            buildListBoxItems();
            uncheckAllCheckBoxes();
        }

        private void buttonSniper_Click(object sender, EventArgs e)
        {
            if (toggleButtonSniper == 1) // Set the button to the default, unclicked state
            {
                buttonSniper.BackColor = colorButtonUnChecked;
                toggleButtonSniper = 0;
                selectedClasses.Remove("SNIPER");
            }
            else
            {
                buttonSniper.BackColor = colorButtonIsChecked;
                toggleButtonSniper = 1;
                selectedClasses.Add("SNIPER");
            }

            buildListBoxItems();
            uncheckAllCheckBoxes();
        }

        private void buttonSpy_Click(object sender, EventArgs e)
        {
            if (toggleButtonSpy == 1) // Set the button to the default, unclicked state
            {
                buttonSpy.BackColor = colorButtonUnChecked;
                toggleButtonSpy = 0;
                selectedClasses.Remove("SPY");
            }
            else // Set the button to the clicked state
            {
                buttonSpy.BackColor = colorButtonIsChecked;
                toggleButtonSpy = 1;
                selectedClasses.Add("SPY");
            }


            buildListBoxItems();
            uncheckAllCheckBoxes();
        }

        #endregion --Class Select--

        #region --Weapon Select--

        // Buttons //

        private void uncheckAllCheckBoxes()
        {
            checkBoxPrimary.Checked = false;
            checkBoxSecondary.Checked = false;
            checkBoxMelee.Checked = false;
            checkBoxSpecial.Checked = false;
        }
        private void checkBoxPrimary_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPrimary.Checked)
            {
                checkBoxPrimary.BackColor = colorButtonIsChecked;
                listBoxPrimary.Enabled = false;
                for (int i = 0; i < listBoxPrimary.Items.Count; i++)
                {
                    listBoxPrimary.SetItemChecked(i, true);
                }
            }
            else if (!checkBoxPrimary.Checked)
            {
                checkBoxPrimary.BackColor = colorButtonUnChecked;
                listBoxPrimary.Enabled = true;
                for (int i = 0; i < listBoxPrimary.Items.Count; i++)
                {
                    listBoxPrimary.SetItemChecked(i, false);
                }
            }
        }
        private void checkBoxSecondary_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSecondary.Checked)
            {
                checkBoxSecondary.BackColor = colorButtonIsChecked;
                listBoxSecondary.Enabled = false;

                for (int i = 0; i < listBoxSecondary.Items.Count; i++)
                {
                    listBoxSecondary.SetItemChecked(i, true);
                }
            }
            else if (!checkBoxSecondary.Checked)
            {
                checkBoxSecondary.BackColor = colorButtonUnChecked;
                listBoxSecondary.Enabled = true;

                for (int i = 0; i < listBoxSecondary.Items.Count; i++)
                {
                    listBoxSecondary.SetItemChecked(i, false);
                }
            }

        }
        private void checkBoxMelee_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMelee.Checked)
            {
                checkBoxMelee.BackColor = colorButtonIsChecked;
                listBoxMelee.Enabled = false;

                for (int i = 0; i < listBoxMelee.Items.Count; i++)
                {
                    listBoxMelee.SetItemChecked(i, true);
                }
            }
            else if (!checkBoxMelee.Checked)
            {
                checkBoxMelee.BackColor = colorButtonUnChecked;
                listBoxMelee.Enabled = true;

                for (int i = 0; i < listBoxMelee.Items.Count; i++)
                {
                    listBoxMelee.SetItemChecked(i, false);
                }
            }
        }
        private void checkBoxSpecial_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSpecial.Checked)
            {
                checkBoxSpecial.BackColor = colorButtonIsChecked;
                listBoxSpecial.Enabled = false;

                for (int i = 0; i < listBoxSpecial.Items.Count; i++)
                {
                    listBoxSpecial.SetItemChecked(i, true);
                }
            }
            else if (!checkBoxSpecial.Checked)
            {
                checkBoxSpecial.BackColor = colorButtonUnChecked;
                listBoxSpecial.Enabled = true;

                for (int i = 0; i < listBoxSpecial.Items.Count; i++)
                {
                    listBoxSpecial.SetItemChecked(i, false);
                }
            }
        }


        #region Class specific functions to build the list box items

        private void clearListBoxItems() // Clears all items in the list boxes for selecting weapons
        {
            listBoxPrimary.Items.Clear();
            listBoxSecondary.Items.Clear();
            listBoxMelee.Items.Clear();
            listBoxSpecial.Items.Clear();
        }
        private void buildListBoxItems() // Calls the build functions  below based on the selected class
        {
            clearListBoxItems();

            foreach (var selection in selectedClasses)
            {
                switch (selection)
                {
                    case "SCOUT":
                        buildScout();
                        break;
                    case "SOLDIER":
                        buildSoldier();
                        break;
                    case "PYRO":
                        buildPyro();
                        break;
                    case "DEMOMAN":
                        buildDemo();
                        break;
                    case "HEAVYWEAPONS":
                        buildHeavy();
                        break;
                    case "ENGINEER":
                        buildEngie();
                        break;
                    case "MEDIC":
                        buildMedic();
                        break;
                    case "SNIPER":
                        buildSniper();
                        break;
                    case "SPY":
                        buildSpy();
                        break;
                    default:
                        break;
                }
            }
        }

        private void buildScout()
        {
            foreach (var weapon in WeaponsDictionaries.scoutPrimaryDictionary.Keys)
            {
                if (!listBoxPrimary.Items.Contains(weapon))
                    listBoxPrimary.Items.Add(weapon, false);
            }

            foreach (var weapon in WeaponsDictionaries.scoutSecondaryDictionary.Keys)
            {
                if (!listBoxSecondary.Items.Contains(weapon))
                    listBoxSecondary.Items.Add(weapon, false);
            }

            foreach (var weapon in WeaponsDictionaries.scoutMeleeDictionary.Keys)
            {
                if (!listBoxMelee.Items.Contains(weapon))
                    listBoxMelee.Items.Add(weapon, false);
            }
        }
        private void buildSoldier()
        {
            foreach (var weapon in WeaponsDictionaries.soldierPrimaryDictionary.Keys)
            {
                if (!listBoxPrimary.Items.Contains(weapon))
                    listBoxPrimary.Items.Add(weapon, false);
            }

            foreach (var weapon in WeaponsDictionaries.soldierSecondaryDictionary.Keys)
            {
                if (!listBoxSecondary.Items.Contains(weapon))
                    listBoxSecondary.Items.Add(weapon, false);
            }

            foreach (var weapon in WeaponsDictionaries.soldierMeleeDictionary.Keys)
            {
                if (!listBoxMelee.Items.Contains(weapon))
                    listBoxMelee.Items.Add(weapon, false);
            }
        }
        private void buildPyro()
        {
            foreach (var weapon in WeaponsDictionaries.pyroPrimaryDictionary.Keys)
            {

                if (!listBoxPrimary.Items.Contains(weapon))
                    listBoxPrimary.Items.Add(weapon, false);
            }

            foreach (var weapon in WeaponsDictionaries.pyroSecondaryDictionary.Keys)
            {
                if (!listBoxSecondary.Items.Contains(weapon))
                    listBoxSecondary.Items.Add(weapon, false);
            }

            foreach (var weapon in WeaponsDictionaries.pyroMeleeDictionary.Keys)
            {
                if (!listBoxMelee.Items.Contains(weapon))
                    listBoxMelee.Items.Add(weapon, false);
            }
        }
        private void buildDemo()
        {
            foreach (var weapon in WeaponsDictionaries.demomanPrimaryDictionary.Keys)
            {
                if (!listBoxPrimary.Items.Contains(weapon))
                    listBoxPrimary.Items.Add(weapon, false);
            }

            foreach (var weapon in WeaponsDictionaries.demomanSecondaryDictionary.Keys)
            {
                if (!listBoxSecondary.Items.Contains(weapon))
                    listBoxSecondary.Items.Add(weapon, false);
            }

            foreach (var weapon in WeaponsDictionaries.demomanMeleeDictionary.Keys)
            {
                if (!listBoxMelee.Items.Contains(weapon))
                    listBoxMelee.Items.Add(weapon, false);
            }
        }
        private void buildHeavy()
        {
            foreach (var weapon in WeaponsDictionaries.heavyPrimaryDictionary.Keys)
            {
                if (!listBoxPrimary.Items.Contains(weapon))
                    listBoxPrimary.Items.Add(weapon, false);
            }

            foreach (var weapon in WeaponsDictionaries.heavySecondaryDictionary.Keys)
            {
                if (!listBoxSecondary.Items.Contains(weapon))
                    listBoxSecondary.Items.Add(weapon, false);
            }

            foreach (var weapon in WeaponsDictionaries.heavyMeleeDictionary.Keys)
            {
                if (!listBoxMelee.Items.Contains(weapon))
                    listBoxMelee.Items.Add(weapon, false);
            }
        }
        private void buildEngie()
        {
            foreach (var weapon in WeaponsDictionaries.engineerPrimaryDictionary.Keys)
            {
                if (!listBoxPrimary.Items.Contains(weapon))
                    listBoxPrimary.Items.Add(weapon, false);
            }

            foreach (var weapon in WeaponsDictionaries.engineerSecondaryDictionary.Keys)
            {
                if (!listBoxSecondary.Items.Contains(weapon))
                    listBoxSecondary.Items.Add(weapon, false);
            }

            foreach (var weapon in WeaponsDictionaries.engineerMeleeDictionary.Keys)
            {
                if (!listBoxMelee.Items.Contains(weapon))
                    listBoxMelee.Items.Add(weapon, false);
            }

            foreach (var weapon in WeaponsDictionaries.engineerSpecialDictionary.Keys)
            {
                if (!listBoxSpecial.Items.Contains(weapon))
                    listBoxSpecial.Items.Add(weapon, false);
            }
        }
        private void buildMedic()
        {
            foreach (var weapon in WeaponsDictionaries.medicPrimaryDictionary.Keys)
            {
                if (!listBoxPrimary.Items.Contains(weapon))
                    listBoxPrimary.Items.Add(weapon, false);
            }

            foreach (var weapon in WeaponsDictionaries.medicSecondaryDictionary.Keys)
            {
                if (!listBoxSecondary.Items.Contains(weapon))
                    listBoxSecondary.Items.Add(weapon, false);
            }

            foreach (var weapon in WeaponsDictionaries.medicMeleeDictionary.Keys)
            {
                if (!listBoxMelee.Items.Contains(weapon))
                    listBoxMelee.Items.Add(weapon, false);
            }
        }
        private void buildSniper()
        {
            foreach (var weapon in WeaponsDictionaries.sniperPrimaryDictionary.Keys)
            {
                if (!listBoxPrimary.Items.Contains(weapon))
                    listBoxPrimary.Items.Add(weapon, false);
            }

            foreach (var weapon in WeaponsDictionaries.sniperSecondaryDictionary.Keys)
            {
                if (!listBoxSecondary.Items.Contains(weapon))
                    listBoxSecondary.Items.Add(weapon, false);
            }

            foreach (var weapon in WeaponsDictionaries.sniperMeleeDictionary.Keys)
            {
                if (!listBoxMelee.Items.Contains(weapon))
                    listBoxMelee.Items.Add(weapon, false);
            }
        }
        private void buildSpy()
        {

            foreach (var weapon in WeaponsDictionaries.spyPrimaryDictionary.Keys)
            {
                if (!listBoxPrimary.Items.Contains(weapon))
                    listBoxPrimary.Items.Add(weapon, false);
            }
            foreach (var weapon in WeaponsDictionaries.spyMeleeDictionary.Keys)
            {
                if (!listBoxMelee.Items.Contains(weapon))
                    listBoxMelee.Items.Add(weapon, false);
            }
            foreach (var weapon in WeaponsDictionaries.spySpecialDictionary.Keys)
            {
                if (!listBoxSpecial.Items.Contains(weapon))
                    listBoxSpecial.Items.Add(weapon, false);
            }
        }

        #endregion Class specific functions to build the list box items

        #endregion --Weapon Select--

        #region --Crosshair Select--

        private void buildCrosshairLists() // Build the crosshair lists from the files in "Stuff"
        {
            foreach (var item in CrosshairLists.crosshairsLeth)
            {
                comboBoxCrosshairsLeth.Items.Add(item);
            }

            foreach (var item in CrosshairLists.crosshairsTobs)
            {
                comboBoxCrosshairsTobs.Items.Add(item);
            }

            foreach (var item in CrosshairLists.crosshairsXhairshadow)
            {
                comboBoxCrosshairsXhairshadow.Items.Add(item);
            }

            foreach (var item in CrosshairLists.crosshairsCPMA)
            {
                comboBoxCrosshairsCPMA.Items.Add(item);
            }

            foreach (var item in CrosshairLists.crosshairsQuake)
            {
                comboBoxCrosshairsQuake.Items.Add(item);
            }

            try
            {
                var directory = Properties.Settings.Default["dir"];

                var filename = directory + @"\custom_crosshairs.txt";
                using (StreamReader reader = File.OpenText(filename))
                {
                    string line = String.Empty;
                    while ((line = reader.ReadLine()) != null)
                    {
                        comboBoxCrosshairsCustom.Items.Add(line);
                    }
                }
            }
            catch
            {
                MessageBox.Show(@"Try re-selecting directory, or making a new ""custom_crosshairs.txt"" file in your crosshairs folder.", "Couldn't find custom_crosshairs.txt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
        }

        private void resetCrosshairSelection() // Resets the crosshair selection
        {
            comboBoxCrosshairsLeth.SelectedIndex = -1;
            comboBoxCrosshairsTobs.SelectedIndex = -1;
            comboBoxCrosshairsXhairshadow.SelectedIndex = -1;
            comboBoxCrosshairsCPMA.SelectedIndex = -1;
            comboBoxCrosshairsQuake.SelectedIndex = -1;
            comboBoxCrosshairsCustom.SelectedIndex = -1;
        }

        // MouseClick Events //

        private void comboBoxCrosshairsLeth_MouseClick(object sender, MouseEventArgs e)
        {
            comboBoxCrosshairsTobs.SelectedIndex = -1;
            comboBoxCrosshairsXhairshadow.SelectedIndex = -1;
            comboBoxCrosshairsCPMA.SelectedIndex = -1;
            comboBoxCrosshairsQuake.SelectedIndex = -1;
            comboBoxCrosshairsCustom.SelectedIndex = -1;
        }

        private void comboBoxCrosshairsTobs_MouseClick(object sender, MouseEventArgs e)
        {
            comboBoxCrosshairsLeth.SelectedIndex = -1;
            comboBoxCrosshairsXhairshadow.SelectedIndex = -1;
            comboBoxCrosshairsCPMA.SelectedIndex = -1;
            comboBoxCrosshairsQuake.SelectedIndex = -1;
            comboBoxCrosshairsCustom.SelectedIndex = -1;
        }

        private void comboBoxCrosshairsXhairshadow_MouseClick(object sender, MouseEventArgs e)
        {
            comboBoxCrosshairsLeth.SelectedIndex = -1;
            comboBoxCrosshairsTobs.SelectedIndex = -1;
            comboBoxCrosshairsCPMA.SelectedIndex = -1;
            comboBoxCrosshairsQuake.SelectedIndex = -1;
            comboBoxCrosshairsCustom.SelectedIndex = -1;
        }

        private void comboBoxCrosshairsCPMA_MouseClick(object sender, MouseEventArgs e)
        {
            comboBoxCrosshairsLeth.SelectedIndex = -1;
            comboBoxCrosshairsTobs.SelectedIndex = -1;
            comboBoxCrosshairsXhairshadow.SelectedIndex = -1;
            comboBoxCrosshairsQuake.SelectedIndex = -1;
            comboBoxCrosshairsCustom.SelectedIndex = -1;
        }

        private void comboBoxCrosshairsQuake_MouseClick(object sender, MouseEventArgs e)
        {
            comboBoxCrosshairsLeth.SelectedIndex = -1;
            comboBoxCrosshairsTobs.SelectedIndex = -1;
            comboBoxCrosshairsXhairshadow.SelectedIndex = -1;
            comboBoxCrosshairsCPMA.SelectedIndex = -1;
            comboBoxCrosshairsCustom.SelectedIndex = -1;
        }

        private void comboBoxCrosshairsCustom_MouseClick(object sender, MouseEventArgs e)
        {
            comboBoxCrosshairsLeth.SelectedIndex = -1;
            comboBoxCrosshairsTobs.SelectedIndex = -1;
            comboBoxCrosshairsXhairshadow.SelectedIndex = -1;
            comboBoxCrosshairsCPMA.SelectedIndex = -1;
            comboBoxCrosshairsQuake.SelectedIndex = -1;
        }

        // Index Changed Events //

        private void comboBoxCrosshairsLeth_SelectedIndexChanged(object sender, EventArgs e)
        {
            setCrosshairImage();
        }

        private void comboBoxCrosshairsTobs_SelectedIndexChanged(object sender, EventArgs e)
        {
            setCrosshairImage();
        }

        private void comboBoxCrosshairsXhairshadow_SelectedIndexChanged(object sender, EventArgs e)
        {
            setCrosshairImage();
        }

        private void comboBoxCrosshairsCPMA_SelectedIndexChanged(object sender, EventArgs e)
        {
            setCrosshairImage();
        }

        private void comboBoxCrosshairsQuake_SelectedIndexChanged(object sender, EventArgs e)
        {
            setCrosshairImage();
        }

        private void comboBoxCrosshairsCustom_SelectedIndexChanged(object sender, EventArgs e)
        {
            setCrosshairImage();
        }

        private void setCrosshairImage()
        {
            if (comboBoxCrosshairsLeth.SelectedIndex != -1)
                selectedCrosshair = (string)comboBoxCrosshairsLeth.SelectedItem;
            else if (comboBoxCrosshairsTobs.SelectedIndex != -1)
                selectedCrosshair = (string)comboBoxCrosshairsTobs.SelectedItem;
            else if (comboBoxCrosshairsXhairshadow.SelectedIndex != -1)
                selectedCrosshair = (string)comboBoxCrosshairsXhairshadow.SelectedItem;
            else if (comboBoxCrosshairsCPMA.SelectedIndex != -1)
                selectedCrosshair = (string)comboBoxCrosshairsCPMA.SelectedItem;
            else if (comboBoxCrosshairsQuake.SelectedIndex != -1)
                selectedCrosshair = (string)comboBoxCrosshairsQuake.SelectedItem;
            else if (comboBoxCrosshairsCustom.SelectedIndex != -1)
                selectedCrosshair = (string)comboBoxCrosshairsCustom.SelectedItem;
            else
                selectedCrosshair = "";

            var imageGet = Properties.Resources.ResourceManager.GetObject(selectedCrosshair, Properties.Resources.Culture);
            pictureBoxCrosshair.Image = (Image)imageGet;
        }

        private void pictureBoxCrosshair_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxCrosshair.BackgroundImage = Properties.Resources.vtfcrosspreviewX;
        }

        private void pictureBoxCrosshair_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxCrosshair.BackgroundImage = null;
        }

        #endregion --Crosshair Select--

        #region --Apply and Reset Buttons--

        private void buttonApply_Click(object sender, EventArgs e)
        {
            if (selectedClasses.Count == 0)
                using (new CenterWinDialog(this))
                {
                    MessageBox.Show("Please select a class", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            else if (listBoxPrimary.SelectedItems.Count == 0 && listBoxSecondary.SelectedItems.Count == 0 && listBoxMelee.SelectedItems.Count == 0 && listBoxSpecial.SelectedItems.Count == 0 && !checkBoxPrimary.Checked && !checkBoxSecondary.Checked && !checkBoxMelee.Checked && !checkBoxSpecial.Checked)
                using (new CenterWinDialog(this))
                {
                    MessageBox.Show("Please select some weapons", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            else if (comboBoxCrosshairsLeth.SelectedIndex == -1 && comboBoxCrosshairsTobs.SelectedIndex == -1 && comboBoxCrosshairsXhairshadow.SelectedIndex == -1 && comboBoxCrosshairsCPMA.SelectedIndex == -1 && comboBoxCrosshairsQuake.SelectedIndex == -1 && comboBoxCrosshairsCustom.SelectedIndex == -1)
                using (new CenterWinDialog(this))
                {
                    MessageBox.Show("Please select a crosshair", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            else
            {
                outputFile();
                labelStatus.Text = "Files created";
                labelStatus.ForeColor = Color.LightBlue;
                pearlSound.Play();
            }
        }

        private void outputFile()
        {
            foreach (var selection in selectedClasses)
            {
                switch (selection)
                {
                    case "SCOUT":
                        outputScout();
                        break;
                    case "SOLDIER":
                        outputSoldier();
                        break;
                    case "PYRO":
                        outputPyro();
                        break;
                    case "DEMOMAN":
                        outputDemo();
                        break;
                    case "HEAVYWEAPONS":
                        outputHeavy();
                        break;
                    case "ENGINEER":
                        outputEngie();
                        break;
                    case "MEDIC":
                        outputMedic();
                        break;
                    case "SNIPER":
                        outputSniper();
                        break;
                    case "SPY":
                        outputSpy();
                        break;
                }
            }
            
        }

        private void outputScout()
        {
            foreach (var item in listBoxPrimary.CheckedItems)
            {
                if (WeaponsDictionaries.scoutPrimaryDictionary.ContainsKey((string)item))
                {
                    var vmtFileName = WeaponsDictionaries.scoutPrimaryDictionary[(string)item];
                    createVmtFile(vmtFileName);
                }
            }

            foreach (var item in listBoxSecondary.CheckedItems)
            {
                if (WeaponsDictionaries.scoutSecondaryDictionary.ContainsKey((string)item))
                {
                    var vmtFileName = WeaponsDictionaries.scoutSecondaryDictionary[(string)item];
                    createVmtFile(vmtFileName);
                }

            }

            foreach (var item in listBoxMelee.CheckedItems)
            {
                if (WeaponsDictionaries.scoutMeleeDictionary.ContainsKey((string)item))
                {
                    var vmtFileName = WeaponsDictionaries.scoutMeleeDictionary[(string)item];
                    createVmtFile(vmtFileName);
                }
            }
        }

        private void outputSoldier()
        {
            foreach (var item in listBoxPrimary.CheckedItems)
            {
                if (WeaponsDictionaries.soldierPrimaryDictionary.ContainsKey((string)item))
                {
                    var vmtFileName = WeaponsDictionaries.soldierPrimaryDictionary[(string)item];
                    createVmtFile(vmtFileName);
                }
            }

            foreach (var item in listBoxSecondary.CheckedItems)
            {
                if (WeaponsDictionaries.soldierSecondaryDictionary.ContainsKey((string)item))
                {
                    var vmtFileName = WeaponsDictionaries.soldierSecondaryDictionary[(string)item];
                    createVmtFile(vmtFileName);
                }

            }

            foreach (var item in listBoxMelee.CheckedItems)
            {
                if (WeaponsDictionaries.soldierMeleeDictionary.ContainsKey((string)item))
                {
                    var vmtFileName = WeaponsDictionaries.soldierMeleeDictionary[(string)item];
                    createVmtFile(vmtFileName);
                }
            }
        }

        private void outputPyro()
        {
            foreach (var item in listBoxPrimary.CheckedItems)
            {
                if (WeaponsDictionaries.pyroPrimaryDictionary.ContainsKey((string)item))
                {
                    var vmtFileName = WeaponsDictionaries.pyroPrimaryDictionary[(string)item];
                    createVmtFile(vmtFileName);
                }
            }

            foreach (var item in listBoxSecondary.CheckedItems)
            {
                if (WeaponsDictionaries.pyroSecondaryDictionary.ContainsKey((string)item))
                {
                    var vmtFileName = WeaponsDictionaries.pyroSecondaryDictionary[(string)item];
                    createVmtFile(vmtFileName);
                }

            }

            foreach (var item in listBoxMelee.CheckedItems)
            {
                if (WeaponsDictionaries.pyroMeleeDictionary.ContainsKey((string)item))
                {
                    var vmtFileName = WeaponsDictionaries.pyroMeleeDictionary[(string)item];
                    createVmtFile(vmtFileName);
                }
            }
        }

        private void outputDemo()
        {
            foreach (var item in listBoxPrimary.CheckedItems)
            {
                if (WeaponsDictionaries.demomanPrimaryDictionary.ContainsKey((string)item))
                {
                    var vmtFileName = WeaponsDictionaries.demomanPrimaryDictionary[(string)item];
                    createVmtFile(vmtFileName);
                }
            }

            foreach (var item in listBoxSecondary.CheckedItems)
            {
                if (WeaponsDictionaries.demomanSecondaryDictionary.ContainsKey((string)item))
                {
                    var vmtFileName = WeaponsDictionaries.demomanSecondaryDictionary[(string)item];
                    createVmtFile(vmtFileName);
                }

            }

            foreach (var item in listBoxMelee.CheckedItems)
            {
                if (WeaponsDictionaries.demomanMeleeDictionary.ContainsKey((string)item))
                {
                    var vmtFileName = WeaponsDictionaries.demomanMeleeDictionary[(string)item];
                    createVmtFile(vmtFileName);
                }
            }
        }

        private void outputHeavy()
        {
            foreach (var item in listBoxPrimary.CheckedItems)
            {
                if (WeaponsDictionaries.heavyPrimaryDictionary.ContainsKey((string)item))
                {
                    var vmtFileName = WeaponsDictionaries.heavyPrimaryDictionary[(string)item];
                    createVmtFile(vmtFileName);
                }
            }

            foreach (var item in listBoxSecondary.CheckedItems)
            {
                if (WeaponsDictionaries.heavySecondaryDictionary.ContainsKey((string)item))
                {
                    var vmtFileName = WeaponsDictionaries.heavySecondaryDictionary[(string)item];
                    createVmtFile(vmtFileName);
                }

            }

            foreach (var item in listBoxMelee.CheckedItems)
            {
                if (WeaponsDictionaries.heavyMeleeDictionary.ContainsKey((string)item))
                {
                    var vmtFileName = WeaponsDictionaries.heavyMeleeDictionary[(string)item];
                    createVmtFile(vmtFileName);
                }
            }
        }

        private void outputEngie()
        {
            foreach (var item in listBoxPrimary.CheckedItems)
            {
                if (WeaponsDictionaries.engineerPrimaryDictionary.ContainsKey((string)item))
                {
                    var vmtFileName = WeaponsDictionaries.engineerPrimaryDictionary[(string)item];
                    createVmtFile(vmtFileName);
                }
            }

            foreach (var item in listBoxSecondary.CheckedItems)
            {
                if (WeaponsDictionaries.engineerSecondaryDictionary.ContainsKey((string)item))
                {
                    var vmtFileName = WeaponsDictionaries.engineerSecondaryDictionary[(string)item];
                    createVmtFile(vmtFileName);
                }

            }

            foreach (var item in listBoxMelee.CheckedItems)
            {
                if (WeaponsDictionaries.engineerMeleeDictionary.ContainsKey((string)item))
                {
                    var vmtFileName = WeaponsDictionaries.engineerMeleeDictionary[(string)item];
                    createVmtFile(vmtFileName);
                }
            }

            foreach (var item in listBoxSpecial.CheckedItems)
            {
                if (WeaponsDictionaries.engineerSpecialDictionary.ContainsKey((string)item))
                {
                    var vmtFileName = WeaponsDictionaries.engineerSpecialDictionary[(string)item];
                    createVmtFile(vmtFileName);
                }
            }
        }

        private void outputMedic()
        {
            foreach (var item in listBoxPrimary.CheckedItems)
            {
                if (WeaponsDictionaries.medicPrimaryDictionary.ContainsKey((string)item))
                {
                    var vmtFileName = WeaponsDictionaries.medicPrimaryDictionary[(string)item];
                    createVmtFile(vmtFileName);
                }
            }

            foreach (var item in listBoxSecondary.CheckedItems)
            {
                if (WeaponsDictionaries.medicSecondaryDictionary.ContainsKey((string)item))
                {
                    var vmtFileName = WeaponsDictionaries.medicSecondaryDictionary[(string)item];
                    createVmtFile(vmtFileName);
                }

            }

            foreach (var item in listBoxMelee.CheckedItems)
            {
                if (WeaponsDictionaries.medicMeleeDictionary.ContainsKey((string)item))
                {
                    var vmtFileName = WeaponsDictionaries.medicMeleeDictionary[(string)item];
                    createVmtFile(vmtFileName);
                }
            }
        }

        private void outputSniper()
        {
            foreach (var item in listBoxPrimary.CheckedItems)
            {
                if (WeaponsDictionaries.sniperPrimaryDictionary.ContainsKey((string)item))
                {
                    var vmtFileName = WeaponsDictionaries.sniperPrimaryDictionary[(string)item];
                    createVmtFile(vmtFileName);
                }
            }

            foreach (var item in listBoxSecondary.CheckedItems)
            {
                if (WeaponsDictionaries.sniperSecondaryDictionary.ContainsKey((string)item))
                {
                    var vmtFileName = WeaponsDictionaries.sniperSecondaryDictionary[(string)item];
                    createVmtFile(vmtFileName);
                }

            }

            foreach (var item in listBoxMelee.CheckedItems)
            {
                if (WeaponsDictionaries.sniperMeleeDictionary.ContainsKey((string)item))
                {
                    var vmtFileName = WeaponsDictionaries.sniperMeleeDictionary[(string)item];
                    createVmtFile(vmtFileName);
                }
            }
        }

        private void outputSpy()
        {
            foreach (var item in listBoxPrimary.CheckedItems)
            {
                if (WeaponsDictionaries.spyPrimaryDictionary.ContainsKey((string)item))
                {
                    var vmtFileName = WeaponsDictionaries.spyPrimaryDictionary[(string)item];
                    createVmtFile(vmtFileName);
                }
            }

            foreach (var item in listBoxMelee.CheckedItems)
            {
                if (WeaponsDictionaries.spyMeleeDictionary.ContainsKey((string)item))
                {
                    var vmtFileName = WeaponsDictionaries.spyMeleeDictionary[(string)item];
                    createVmtFile(vmtFileName);
                }
            }

            foreach (var item in listBoxSecondary.CheckedItems)
            {
                if (WeaponsDictionaries.spySpecialDictionary.ContainsKey((string)item))
                {
                    var vmtFileName = WeaponsDictionaries.spySpecialDictionary[(string)item];
                    createVmtFile(vmtFileName);
                }
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            selectedClasses.Clear();
            clearListBoxItems();

            buttonScout.BackColor = colorButtonUnChecked;
            toggleButtonScout = 0;

            buttonSoldier.BackColor = colorButtonUnChecked;
            toggleButtonSoldier = 0;

            buttonPyro.BackColor = colorButtonUnChecked;
            toggleButtonPyro = 0;

            buttonDemo.BackColor = colorButtonUnChecked;
            toggleButtonDemo = 0;

            buttonHeavy.BackColor = colorButtonUnChecked;
            toggleButtonHeavy = 0;

            buttonEngie.BackColor = colorButtonUnChecked;
            toggleButtonEngie = 0;

            buttonMedic.BackColor = colorButtonUnChecked;
            toggleButtonMedic = 0;

            buttonSniper.BackColor = colorButtonUnChecked;
            toggleButtonSniper = 0;

            buttonSpy.BackColor = colorButtonUnChecked;
            toggleButtonSpy = 0;

            checkBoxPrimary.Checked = false;
            checkBoxSecondary.Checked = false;
            checkBoxMelee.Checked = false;
            checkBoxSpecial.Checked = false;

            resetCrosshairSelection();
            labelStatus.Text = "Waiting for input";
            labelStatus.ForeColor = Color.WhiteSmoke;
        }

        private void createVmtFile(string weapon)
        {
            var newOutput = vmtOutput.Replace("*", selectedCrosshair);
            var fileLocation = (string)Properties.Settings.Default["dir"] + @"\materials\vgui\replay\thumbnails\" + weapon;
            File.WriteAllText(fileLocation, newOutput);
        }

        #endregion --Apply and Reset Buttons--
    }
}
