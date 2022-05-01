using System;
using System.Diagnostics;

namespace Roblox_Force_Closer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("closerblox.cmd");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("closerbloxstudio.cmd");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("C:/Program Files (x86)/Microsoft/Edge/Application/msedge.exe","https://github.com/BossGamerDEV/Roblox-Force-Closer");
        }
    }
}