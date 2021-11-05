﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPsAssignment
{
    public partial class Form1 : Form
    {
        int x_doorL_close = 200;
        int x_doorR_close = 436;
        int x_doorL_open = 126;
        int x_doorR_open = 506;

        int y_liftDown = 462;
        int y_liftUp = 85;

        bool moving_up = false;
        bool moving_down = false;

        String LiftStatus = "GroundFloor";

        public Form1()
        {
            InitializeComponent();
        }

        private void updoors_open_Tick(object sender, EventArgs e)
        {
            if (door_upL.Left >= x_doorL_open)
            {
                door_upL.Left -= 1;
                door_upR.Left += 1;
            }
            else
            {
                updoors_open.Enabled = false;

            }
        }

        private void updoors_close_Tick(object sender, EventArgs e)
        {
            if (door_upL.Left <= x_doorL_close)
            {
                door_upL.Left += 1;
                door_upR.Left -= 1;
            }
            else
            {
                updoors_close.Enabled = false;
                if (moving_down == true)
                {
                    go_down.Enabled = true;
                }
            }
        }

        private void downdoors_open_Tick(object sender, EventArgs e)
        {
            if (door_downL.Left >= x_doorL_open)
            {
                door_downL.Left -= 1;
                door_downR.Left += 1;
            }
            else
            {
                downdoors_open.Enabled = false;
                
            }
        }

        private void downdoors_close_Tick(object sender, EventArgs e)
        {
            if (door_downL.Left <= x_doorL_close)
            {
                door_downL.Left += 1;
                door_downR.Left -= 1;
            }
            else
            {
                downdoors_close.Enabled = false;
                if (moving_up == true)
                {
                    go_up.Enabled = true;
                }
            }
        }

       

        private void go_up_Tick(object sender, EventArgs e)
        {
            if (liftbox.Top != y_liftUp)
            {
                liftbox.Top -= 1;
            }
            else
            {
                lift_display.Image = Properties.Resources.inside_life;
                moving_up = false;
                LiftStatus = "FirstFloor";
                go_up.Enabled = false;
                updoors_open.Enabled = true;
            }
        }

        private void go_down_Tick(object sender, EventArgs e)
        {
            if (liftbox.Top != y_liftDown)
            {
                liftbox.Top += 1;
            }
            else
            {
                moving_down = false;
                LiftStatus = "GroundFloor";
                go_down.Enabled = false;
                downdoors_open.Enabled = true;
            }
        }

        private void btn_firstFloor_Click(object sender, EventArgs e)
        {
            moving_up = true;
            downdoors_close.Enabled = true;
        }

        private void btn_groundFloor_Click(object sender, EventArgs e)
        {
            moving_down = true;
            updoors_close.Enabled = true;
        }

        private void btn_opendoor_Click(object sender, EventArgs e)
        {
            if (LiftStatus == "GroundFloor") { downdoors_open.Enabled = true; }
            if (LiftStatus == "FirstFloor") { updoors_open.Enabled = true; }
        }

        private void btn_closedoors_Click(object sender, EventArgs e)
        {
            if (LiftStatus == "GroundFloor") { downdoors_close.Enabled = true; }
            if (LiftStatus == "FirstFloor") { updoors_close.Enabled = true; }

        }
    }
}
