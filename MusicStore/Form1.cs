using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicStore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //test
            rdoCd.CheckedChanged += RdoCd_CheckedChanged;
            rdoItunes.CheckedChanged += RdoCd_CheckedChanged;
            rdoVinyl.CheckedChanged += RdoCd_CheckedChanged;
        }
        
        private void RdoCd_CheckedChanged(object sender, EventArgs e)
        {
            CheckCheckOut();
        }

        private double GetCostPerOne()
        {
            double cost = 0;
            var button = grpType.Controls.OfType<RadioButton>()
                .FirstOrDefault(n => n.Checked).Text;
            switch (button)
            {
                case "CD":
                    cost = 16.99;
                    break;
                case "iTunes":
                    cost = 11.99;
                    break;
                case "Vinyl":
                    cost = 19.99;
                    break;
            }

            return cost;
        }

        private bool IsClickCheckOut = false;

        /// <summary>
        /// Setup and Clear
        /// </summary>
        void Setup()
        {
            txtMemberNumber.Focus();
            SetEnabled(false);
            LoadData();
            txtMemberNumber.Text = "";
            lstSelections.Items.Clear();
            rdoCd.Checked = true;
            lblDisplay.Text = String.Empty;
        }




        private void SetEnabled(bool enabled)
        {
            grpPurchase.Enabled = enabled;
            grpType.Enabled = enabled;
            grpCheckOut.Enabled = enabled;
            btnClear.Enabled = enabled;
        }

        /// <summary>
        /// Load Available Albums
        /// </summary>
        private void LoadData()
        {
            lstAlbums.Items.Clear();
            foreach (string line in File.ReadAllLines("Albums.txt"))
            {
                if (!string.IsNullOrEmpty(line))
                    lstAlbums.Items.Add(line);
            }
        }

        /// <summary>
        /// The method should be called from both the Form Load and Clear Button Click events.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            Setup();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (ValidMemberNumber(txtMemberNumber.Text.Trim()))
            {
                SetEnabled(true);
            }
            else
            {
                txtMemberNumber.Focus();
                txtMemberNumber.SelectAll();
                MessageBox.Show("Invalid member number", "Invalid data");
            }
        }

        bool ValidMemberNumber(string memberNumber)
        {
            bool result = false;
            Regex regex = new Regex(@"[A]\d{5}$");
            MatchCollection matches = regex.Matches(memberNumber);
            if (matches.Count > 0)
            {
                result = true;
            }
            return result;
        }

        private void lstAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAlbums.SelectedIndex != -1)
            {
                PictureBox1.Enabled = true;
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            var contain = lstSelections.Items.Contains(lstAlbums.SelectedItem);
            if (contain)
            {
                MessageBox.Show("This album has already been selected");
            }
            else
            {
                lstSelections.Items.Add(lstAlbums.SelectedItem);
                CheckCheckOut();
            }
        }

        private void CheckCheckOut()
        {
            if (IsClickCheckOut)
                Calculate();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            if (lstSelections.SelectedItem == null)
            {
                MessageBox.Show("Please select the album you want to remove.", "Error");
            }
            else
            {
                lstSelections.Items.Remove(lstSelections.SelectedItem);
                CheckCheckOut();
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            IsClickCheckOut = true;
            if (lstSelections.Items.Count == 0)
            {
                MessageBox.Show("Please choose at least 1 album to purchase.", "Invalid Selection");
            }
            else
            {
                Calculate();
            }

        }

        private void Calculate()
        {
            int countSelection = lstSelections.Items.Count;
            double resultCost = GetCostPerOne() * countSelection;
            lblDisplay.Text = $"Your total is ${resultCost}";
        }
    }
}
