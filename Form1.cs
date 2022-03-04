using Geditor.Properties;
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

namespace Geditor
{
    public partial class Form1 : Form
    {
        //main
        Address address = new Address();
        BindingSource bs = new BindingSource();

        //players and events properties
        PersonList personList = new PersonList();
        List<string> pList = new List<string>();
        List<string> eList = new List<string>();
        List<string> pList2 = new List<string>();

        //properties
        Stage stage = new Stage(0, 0, 0);
        Person player1 = new Person("Player1");
        Person player2 = new Person("Player2");
        Score score1 = new Score(0);
        Score score2 = new Score(0);
        Strim strim = new Strim();

        //variables
        int scoreKeep1 = 0;
        int scoreKeep2 = 0;
        int roundKeep = 0;
        Boolean isSwapped = false;

        public Form1()
        {
            InitializeComponent();
            address.setFilePath(Settings.Default["DefaultPath"].ToString());
            address.setUrl(Settings.Default["DefaultUrl"].ToString());
            refreshCBX(address.getUrl());
            System.Diagnostics.Debug.WriteLine("New url " + address.getUrl());

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refreshCBX(address.getUrl());
        }

        private void refreshCBX(string url)
        {
            cbx_Players2.BindingContext = new BindingContext();
            pList = personList.LookupPlayers(url, Lookup.selectedEvent);
            System.Diagnostics.Debug.WriteLine("New selected event: "+ Lookup.selectedEvent);
            //set cbx to elist
            cbx_Players1.DataSource = cbx_Players2.DataSource = pList;
        }
        public static string getBetween(string strSource, string strStart, string strEnd)
        {
            if (strSource.Contains(strStart) && strSource.Contains(strEnd))
            {
                int Start, End;
                Start = strSource.IndexOf(strStart, 0) + strStart.Length;
                End = strSource.IndexOf(strEnd, Start);
                return strSource.Substring(Start, End - Start);
            }
            return "";
        }

        private void update()
        {
            strim.setStrim(score1, score2, player1, player2, stage);
            lbl_Score1.Text = score1.ToStringg();
            lbl_Score2.Text = score2.ToStringg();
            lbl_Player1.Text = player1.ToStringg();
            lbl_Player2.Text = player2.ToStringg();
            lbl_Stage.Text = stage.ToStringg();
            strim.WriteStrim(address);
            System.Diagnostics.Debug.WriteLine(strim.ToStringg());
        }

        //buttons

        //SCORE BUTTONS************************************************
        private void btn_Score_Add_Click(object sender, EventArgs e)
        {
            scoreKeep1++;
            score1.setScore(scoreKeep1);
            update();
        }

        private void btn_Score2_Add_Click(object sender, EventArgs e)
        {
            scoreKeep2++;
            score2.setScore(scoreKeep2);
            update();
        }
        //SWAPPP
        private void btn_Swap_Click(object sender, EventArgs e)
        {
            Person p1 = player1;
            Person p2 = player2;
            Score s1 = score1;
            Score s2 = score2;
            if (isSwapped == false)
            {
                //attributes swap
                player1 = p2;
                player2 = p1;
                score1 = s2;
                score2 = s1;
                //colors swap
                btn_Swap.BackColor = Color.Indigo;
                btn_Swap.ForeColor = Color.White;
                lbl_Player1.ForeColor = Color.OrangeRed;
                lbl_Player2.ForeColor = Color.DodgerBlue;
                lbl_Score1.ForeColor = Color.OrangeRed;
                lbl_Score2.ForeColor = Color.DodgerBlue;
                //label swap
                lbl_Player1.Text = s2.ToString();
                lbl_Player2.Text = s1.ToString();

                update();
                isSwapped = true;
            }

            else
            {
                //attributes swap
                player1 = p1;
                player2 = p2;
                score1 = s1;
                score2 = s2;
                //colors swap
                btn_Swap.BackColor = Color.White;
                btn_Swap.ForeColor = Color.Indigo;
                lbl_Player2.ForeColor = Color.OrangeRed;
                lbl_Player1.ForeColor = Color.DodgerBlue;
                lbl_Score1.ForeColor = Color.DodgerBlue;
                lbl_Score2.ForeColor = Color.OrangeRed;
                //label swap
                lbl_Player1.Text = s1.ToString();
                lbl_Player2.Text = s2.ToString();
                update();
                isSwapped = false;
            }

        }

        private void btn_Score_Reset_Click(object sender, EventArgs e)
        {
            scoreKeep1 = scoreKeep2 = 0;
            score1.setScore(scoreKeep1);
            score2.setScore(scoreKeep2);
            update();
        }
        //*************************************************************
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            player1.setName("Player1");
            player2.setName("Player2");
            update();
        }

        private void cbx_Players1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //selected item from combo box
            player1.setName(this.cbx_Players1.GetItemText(this.cbx_Players1.SelectedItem));
            update();
        }

        private void cbx_Players2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //selected item from combo box
            player2.setName(this.cbx_Players2.GetItemText(this.cbx_Players2.SelectedItem));
            update();
        }
        //STAGE BUTTONS************************************************
        private void button6_Click(object sender, EventArgs e)
        {
            stage.setSide(1);
            update();
        }

        private void btn_Round_Click(object sender, EventArgs e)
        {
            stage.setLeg(1);
            update();
        }

        private void btn_Stage_Subtract_Click(object sender, EventArgs e)
        {
            roundKeep=0;
            stage.setRound(roundKeep);
            update();
        }

        private void btn_Stage_Add_Click(object sender, EventArgs e)
        {
            roundKeep++;
            stage.setRound(roundKeep);
            update();
        }

        private void btn_Quarters_Click(object sender, EventArgs e)
        {
            stage.setLeg(2);
            update();
        }

        private void btn_Semis_Click(object sender, EventArgs e)
        {
            stage.setLeg(3);
            update();
        }

        private void btn_Finals_Click(object sender, EventArgs e)
        {
            stage.setLeg(4);
            update();
        }

        private void btn_Winners_Click(object sender, EventArgs e)
        {
            stage.setSide(2);
            update();
        }

        private void btn_Stage_Reset_Click(object sender, EventArgs e)
        {
            stage.setSide(0);
            stage.setLeg(0);
            stage.setRound(0);
            update();
        }
        //MISC BUTTONS************************************************
        private void btn_Reset_All_Click(object sender, EventArgs e)
        {
            Lookup back = new Lookup();
            back.Show();
            this.Hide();
        }
        private void btn_Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for supporting this app, feel free to follow me @RL7_slimkat and The Heist Series @seriesheist on twitter/youtube/twitch. Have a good one!");
        }
    }
    }

