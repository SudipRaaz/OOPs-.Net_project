using System;
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
        private void updoors_open_Tick(object sender, EventArgs e)
        {
            if (door_upL.Left >= x_doorL_open)
            {
                door_upL.Left -= 1;
                door_upR.Left += 1;
            }
            else
            {
                btn_opendoor.BackColor = Color.White;
                updoors_open.Enabled = false;
                insertdata("Doors opened at FirstFloor");
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
                btn_closedoors.BackColor = Color.White;
                updoors_close.Enabled = false;
                insertdata("Doors closed at FirstFloor");
                if (moving_down == true)
                {
                    lift_display.Image = global::OOPsAssignment.Properties.Resources.down;
                    F_display.Image = global::OOPsAssignment.Properties.Resources.down;
                    G_display.Image = global::OOPsAssignment.Properties.Resources.down;

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
                btn_opendoor.BackColor = Color.White;
                downdoors_open.Enabled = false;
                insertdata("Doors opened at GroundFloor");

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
                btn_closedoors.BackColor = Color.White;
                downdoors_close.Enabled = false;
                insertdata("Doors closed at GroundFloor");
                if (moving_up == true)
                {
                    lift_display.Image = global::OOPsAssignment.Properties.Resources.up;
                    G_display.Image = global::OOPsAssignment.Properties.Resources.up;
                    F_display.Image = global::OOPsAssignment.Properties.Resources.up;

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
                btn_firstFloor.BackColor = Color.White;
                request_G.BackColor = Color.White;
                insertdata("LiftBox at First Floor");
                moving_up = false;
                lift_display.Image = global::OOPsAssignment.Properties.Resources.Red_firstFloorDisplay_;
                G_display.Image = global::OOPsAssignment.Properties.Resources.Red_firstFloorDisplay_;
                F_display.Image = global::OOPsAssignment.Properties.Resources.Red_firstFloorDisplay_;

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
                btn_groundFloor.BackColor = Color.White;
                request_F.BackColor = Color.White;
                insertdata("liftBox at Ground Floor");
                moving_down = false;
                lift_display.Image = global::OOPsAssignment.Properties.Resources.Red_firstFloorDisplay; // resource file name Red_firstFloorDisplay = Red_GroundFloorDisplay
                G_display.Image = global::OOPsAssignment.Properties.Resources.Red_firstFloorDisplay;    // resource file name Red_firstFloorDisplay = Red_GroundFloorDisplay
                F_display.Image = global::OOPsAssignment.Properties.Resources.Red_firstFloorDisplay;    // resource file name Red_firstFloorDisplay = Red_GroundFloorDisplay

                LiftStatus = "GroundFloor";
                go_down.Enabled = false;
                downdoors_open.Enabled = true;
            }
        }

        private void btn_firstFloor_Click(object sender, EventArgs e)
        {
            if (moving_down == false)
            {
                btn_firstFloor.BackColor = Color.Red;
                moving_up = true;
                downdoors_close.Enabled = true;
            }
        }

        private void btn_groundFloor_Click(object sender, EventArgs e)
        {

            if(moving_up == false)
            {
                btn_groundFloor.BackColor = Color.Red;
                moving_down = true;
                updoors_close.Enabled = true;
            }
            
        }

        private void btn_opendoor_Click(object sender, EventArgs e)
        {
            btn_opendoor.BackColor = Color.Orange;
            if (LiftStatus.Equals("GroundFloor")) { downdoors_open.Enabled = true; }
            if (LiftStatus.Equals("FirstFloor")) { updoors_open.Enabled = true; }
        }

        private void btn_closedoors_Click(object sender, EventArgs e)
        {
            btn_closedoors.BackColor = Color.Orange;
            if (LiftStatus.Equals("GroundFloor")) { downdoors_close.Enabled = true; }
            if (LiftStatus.Equals("FirstFloor")) { updoors_close.Enabled = true; }
        }

        private void request_F_Click(object sender, EventArgs e)
        {
            if (LiftStatus.Equals("FirstFloor"))
            {
                request_F.BackColor = Color.Red;
                moving_down = true;
                updoors_close.Enabled = true;
            }
            
        }

        private void request_G_Click(object sender, EventArgs e)
        {
            if (LiftStatus.Equals("GroundFloor"))
            {
                request_G.BackColor = Color.Red;
                moving_up = true;
                downdoors_close.Enabled = true;

            }
        }

        private void btn_log_Click(object sender, EventArgs e)
        {
            MethodCall call = new MethodCall(LoadData);
            call.Invoke();
        }

        private void LoadData()
        {
            try
            {
                logInformation s = new logInformation();
                DataTable dt = s.ViewLog();
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void insertdata(string action)
        {
            string date = DateTime.Now.ToShortDateString();
            string time = DateTime.Now.ToLongTimeString();
            //try
            {
                logInformation s = new logInformation();
                s.SaveLog(action);
            }
            //catch
            {
                MessageBox.Show("Error saving the Log Data","Message",MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            LoadData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appData.Log_Details' table. You can move, or remove it, as needed.
            //this.log_DetailsTableAdapter.Fill(this.appData.Log_Details);
            //LoadData();

        }
    }

}
