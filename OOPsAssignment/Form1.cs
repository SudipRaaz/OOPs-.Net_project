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
        int x_doorL_open = 126;

        int y_liftDown = 462;
        int y_liftUp = 85;

        bool moving_up = false;
        bool moving_down = false;

        String LiftStatus = "GroundFloor";

        public Form1()
        {
            InitializeComponent();
        }

        public void loadcomponent() => InitializeComponent();
        
        public delegate void MethodCall();
        private void updoors_open_Tick(object sender, EventArgs e) // timer event
        {
            if (door_upL.Left >= x_doorL_open) // if door is closed
            {
                MethodCall updoor = new MethodCall(updoors_openMethod);
                updoor.Invoke();
            }
            else
            {
                btn_opendoor.BackColor = Color.White;
                updoors_open.Enabled = false;
                insertdata("Doors opened at FirstFloor");
            }
        }

        private void updoors_openMethod() // animate method to open the doors
        {
            door_upL.Left -= 1;
            door_upR.Left += 1;
        }

        private void updoors_close_Tick(object sender, EventArgs e) // timer event
        {
            if (door_upL.Left <= x_doorL_close) // if door is open
            {
                MethodCall updoor = new MethodCall(updoors_closeMethod);
                updoor.Invoke();
            }
            else
            {
                btn_closedoors.BackColor = Color.White;
                updoors_close.Enabled = false;
                insertdata("Doors closed at FirstFloor");
                if (moving_down == true) // if also moving down
                {
                    lift_display.Image = global::OOPsAssignment.Properties.Resources.down;
                    F_display.Image = global::OOPsAssignment.Properties.Resources.down;
                    G_display.Image = global::OOPsAssignment.Properties.Resources.down;

                    go_down.Enabled = true;
                }
            }
        }

        private void updoors_closeMethod() // animate method to close the doors 
        {
            door_upL.Left += 1;
            door_upR.Left -= 1;
        }

        private void downdoors_open_Tick(object sender, EventArgs e) // timer event
        {
            if (door_downL.Left >= x_doorL_open)
            {
                MethodCall downdoor = new MethodCall(downdoors_openMethod);
                downdoor.Invoke();
            }
            else
            {
                btn_opendoor.BackColor = Color.White;
                downdoors_open.Enabled = false;
                insertdata("Doors opened at GroundFloor");

            }
        }

        private void downdoors_openMethod() // animate method to open down doors
        {
            door_downL.Left -= 1;
            door_downR.Left += 1;
        }

        private void downdoors_close_Tick(object sender, EventArgs e) // timer event
        {
            if (door_downL.Left <= x_doorL_close) // if lift doors are open
            {
                MethodCall downdoor = new MethodCall(downdoors_closeMethod);
                downdoor.Invoke();
            }
            else
            {
                btn_closedoors.BackColor = Color.White;
                downdoors_close.Enabled = false;
                insertdata("Doors closed at GroundFloor");
                if (moving_up == true) // if also moving up
                {
                    lift_display.Image = global::OOPsAssignment.Properties.Resources.up;
                    G_display.Image = global::OOPsAssignment.Properties.Resources.up;
                    F_display.Image = global::OOPsAssignment.Properties.Resources.up;

                    go_up.Enabled = true;
                }
            }
        }

        private void downdoors_closeMethod() // animation method to close down doors
        {
            door_downL.Left += 1;
            door_downR.Left -= 1;
        }

        private void go_up_Tick(object sender, EventArgs e) // timer event
        {
            if (liftbox.Top != y_liftUp)
            {
                MethodCall movingUp = new MethodCall(liftUp);
                movingUp.Invoke();
            }
            else
            {
                btn_firstFloor.BackColor = Color.White; // changing button color
                request_G.BackColor = Color.White; // changing button color
                insertdata("LiftBox at First Floor"); // inserting into database 
                moving_up = false; // updating moving up status as false
                liftbox.Image = Properties.Resources.inside_life; // changing image resource
                lift_display.Image = global::OOPsAssignment.Properties.Resources.Red_firstFloorDisplay_;
                G_display.Image = global::OOPsAssignment.Properties.Resources.Red_firstFloorDisplay_;
                F_display.Image = global::OOPsAssignment.Properties.Resources.Red_firstFloorDisplay_;

                LiftStatus = "FirstFloor"; // updating liftStaus
                go_up.Enabled = false;
                updoors_open.Enabled = true;
            }
        }

        private void liftUp() // method to animate liftbox moving down
        {
            liftbox.Top -= 1;
            liftbox.Image = Properties.Resources.closed_door_without_frame;
        }

        private void go_down_Tick(object sender, EventArgs e) // timer event 
        {
            if (liftbox.Top != y_liftDown) // moving the lift
            {
                MethodCall movingUp = new MethodCall(liftDown);
                movingUp.Invoke();
            }
            else
            {
                btn_groundFloor.BackColor = Color.White;
                request_F.BackColor = Color.White;
                insertdata("liftBox at Ground Floor");
                moving_down = false;
                liftbox.Image = Properties.Resources.inside_life;
                lift_display.Image = global::OOPsAssignment.Properties.Resources.Red_firstFloorDisplay; // resource file name Red_firstFloorDisplay = Red_GroundFloorDisplay
                G_display.Image = global::OOPsAssignment.Properties.Resources.Red_firstFloorDisplay;    // resource file name Red_firstFloorDisplay = Red_GroundFloorDisplay
                F_display.Image = global::OOPsAssignment.Properties.Resources.Red_firstFloorDisplay;    // resource file name Red_firstFloorDisplay = Red_GroundFloorDisplay

                LiftStatus = "GroundFloor";
                go_down.Enabled = false;
                downdoors_open.Enabled = true;
            }
        }

        private void liftDown() // method to animate liftbox moving up
        {
            liftbox.Top += 1;
            liftbox.Image = Properties.Resources.closed_door_without_frame;
        }

        private void btn_firstFloor_Click(object sender, EventArgs e) // assigning button event 
        {
            if (moving_down == false) // if the lift isnot moving down
            {
                btn_firstFloor.BackColor = Color.Red;
                moving_up = true;
                downdoors_close.Enabled = true;
            }
        }

        private void btn_groundFloor_Click(object sender, EventArgs e) // assigning button event 
        {

            if(moving_up == false) // if the lift isnot moving up
            {
                btn_groundFloor.BackColor = Color.Red;
                moving_down = true;
                updoors_close.Enabled = true;
            }
            
        }

        private void btn_opendoor_Click(object sender, EventArgs e) // assigning button event 
        {
            btn_opendoor.BackColor = Color.Orange;
            switch (LiftStatus)
            {
                case "GroundFloor":
                    downdoors_open.Enabled = true;
                    break;
                case "FirstFloor":
                    updoors_open.Enabled = true;
                    break;

            }
            //if (LiftStatus.Equals("GroundFloor")) { downdoors_open.Enabled = true; }
            //if (LiftStatus.Equals("FirstFloor")) { updoors_open.Enabled = true; }
        }

        private void btn_closedoors_Click(object sender, EventArgs e) // assigning button event 
        {
            btn_closedoors.BackColor = Color.Orange;
            switch (LiftStatus)
            {
                case "GroundFloor":
                    downdoors_close.Enabled = true;
                    break;
                case "FirstFloor":
                    updoors_close.Enabled = true;
                    break;
            }
            //if (LiftStatus.Equals("GroundFloor")) { downdoors_close.Enabled = true; }
            //if (LiftStatus.Equals("FirstFloor")) { updoors_close.Enabled = true; }
        }

        private void request_F_Click(object sender, EventArgs e) // request first floor event
        {
            if (LiftStatus.Equals("FirstFloor")) // if lift is at first floor
            {
                request_F.BackColor = Color.Red; // btn color change
                moving_down = true;
                updoors_close.Enabled = true;
            }
            
        }

        private void request_G_Click(object sender, EventArgs e)  // request button event
        {
            if (LiftStatus.Equals("GroundFloor")) // if lift is at ground floor
            {
                request_G.BackColor = Color.Red; // button color
                moving_up = true;
                downdoors_close.Enabled = true;

            }
        }

        private void btn_log_Click(object sender, EventArgs e)  // using delegate
        {
            dataGridView1.DataSource = null;
        }

        private void LoadData() // loading the data into datagridview table
        {
            try
            {
                logInformation s = new logInformation();
                DataTable dt = s.ViewLog();
                dataGridView1.DataSource = dt; // initializing the datagrid table source
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
        }

        private void insertdata(string action) // adding data to data base
        {
            //exception handling
            try
            {
                logInformation s = new logInformation(); //creating object of logInformation class and calling a method from  it
                s.SaveLog(action); 
            }
            catch(Exception ex)
            {
                // displaying error message
                MessageBox.Show(ex.Message ,"Message",MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            LoadData();
        }

        
        private void Form1_Load(object sender, EventArgs e) // load the data when the form loads
        {
            // TODO: This line of code loads data into the 'appData.Log_Details' table. You can move, or remove it, as needed.
            //this.log_DetailsTableAdapter.Fill(this.appData.Log_Details);
            //LoadData();

        }  

        private void exit_Click(object sender, EventArgs e) // button event
        {
            Application.ExitThread(); // close the software
        }
    }

}
