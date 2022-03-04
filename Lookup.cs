using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Geditor.Properties;

namespace Geditor
{
    public partial class Lookup : Form
    {
        //properties
        OpenFileDialog fileDialog = new OpenFileDialog();
        Address globalAddress = new Address();

        //players and events properties
        PersonList personList = new PersonList();
        List<string> pList = new List<string>();
        List<string> eList = new List<string>();

        //binding sources
        BindingSource ebs = new BindingSource();
        public static string selectedEvent = null;

        public Lookup()
        {
            InitializeComponent();
            globalAddress.setFilePath(Settings.Default["DefaultPath"].ToString());
            globalAddress.setUrl(Settings.Default["DefaultUrl"].ToString());
            lbl_Path.Text = globalAddress.getFilePath();
            lbl_Url.Text = globalAddress.getUrl();
            refreshCBX(globalAddress.getUrl());
            //reset selectedevent
            //selectedEvent = null;
        }

        private void refreshCBX(string url)
        {
            eList = personList.LookupFilters(url);
            //set cbx to elist
            cbx_Filter.DataSource = eList;
        }
        private void btn_Page_Click(object sender, EventArgs e)
        {
            //set url
            string strUrl = tbx_url.Text;
            System.Diagnostics.Debug.WriteLine(strUrl);
            refreshCBX(strUrl);
            globalAddress.setUrl(strUrl);
            Settings.Default["DefaultUrl"] = lbl_Url.Text = globalAddress.getUrl();
            Settings.Default.Save();

            //nav same form
            Lookup lookup = new Lookup();
            lookup.Show();
            this.Hide();
        }

        private void btn_File_New_Click(object sender, EventArgs e)
        {
            
            if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                
                string strFileName = fileDialog.FileName;
                MessageBox.Show(strFileName);
                globalAddress.setFilePath(strFileName);
                Settings.Default["DefaultPath"] = lbl_Path.Text = globalAddress.getFilePath();
                Settings.Default.Save();
            }
        }

        private void btn_Casual_Mode_Click(object sender, EventArgs e)
        {

        }

        private void btn_Filter_Click_1(object sender, EventArgs e)
        {
            //selected item from combo box
            selectedEvent = this.cbx_Filter.GetItemText(this.cbx_Filter.SelectedItem);
            lbl_filter.Text = selectedEvent;

            //sample player data
            pList = personList.LookupPlayers(globalAddress.getUrl(), selectedEvent);
            lbl_Sample1.Text = pList[0];
        }

        private void btn_Tournament_Mode_Click(object sender, EventArgs e)
        {
            if (selectedEvent!=null &&(globalAddress.getUrl() != null && globalAddress.getFilePath() != null))
            {
                Form1 TournamentMode = new Form1();
                TournamentMode.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You cannot start Tournament Mode if either the URL, Filter, or Filepath is empty");
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            Settings.Default["DefaultUrl"] = lbl_Url.Text = "https://smash.gg/tournament/doryaville-heist-2-tekken-7/";
            Settings.Default.Save();
        }
    }
}
