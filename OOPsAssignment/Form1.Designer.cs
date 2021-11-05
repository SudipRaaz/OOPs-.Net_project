﻿
namespace OOPsAssignment
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.updoors_open = new System.Windows.Forms.Timer(this.components);
            this.updoors_close = new System.Windows.Forms.Timer(this.components);
            this.downdoors_open = new System.Windows.Forms.Timer(this.components);
            this.downdoors_close = new System.Windows.Forms.Timer(this.components);
            this.go_up = new System.Windows.Forms.Timer(this.components);
            this.go_down = new System.Windows.Forms.Timer(this.components);
            this.btn_opendoor = new System.Windows.Forms.Button();
            this.btn_closedoors = new System.Windows.Forms.Button();
            this.btn_groundFloor = new System.Windows.Forms.Button();
            this.btn_firstFloor = new System.Windows.Forms.Button();
            this.door_downR = new System.Windows.Forms.PictureBox();
            this.door_upR = new System.Windows.Forms.PictureBox();
            this.door_downL = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.door_upL = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.liftbox = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lift_display = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.door_downR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door_upR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door_downL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door_upL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liftbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lift_display)).BeginInit();
            this.SuspendLayout();
            // 
            // updoors_open
            // 
            this.updoors_open.Interval = 1;
            this.updoors_open.Tick += new System.EventHandler(this.updoors_open_Tick);
            // 
            // updoors_close
            // 
            this.updoors_close.Interval = 1;
            this.updoors_close.Tick += new System.EventHandler(this.updoors_close_Tick);
            // 
            // downdoors_open
            // 
            this.downdoors_open.Interval = 1;
            this.downdoors_open.Tick += new System.EventHandler(this.downdoors_open_Tick);
            // 
            // downdoors_close
            // 
            this.downdoors_close.Interval = 1;
            this.downdoors_close.Tick += new System.EventHandler(this.downdoors_close_Tick);
            // 
            // go_up
            // 
            this.go_up.Interval = 1;
            this.go_up.Tick += new System.EventHandler(this.go_up_Tick);
            // 
            // go_down
            // 
            this.go_down.Interval = 1;
            this.go_down.Tick += new System.EventHandler(this.go_down_Tick);
            // 
            // btn_opendoor
            // 
            this.btn_opendoor.BackgroundImage = global::OOPsAssignment.Properties.Resources.open_door;
            this.btn_opendoor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_opendoor.Location = new System.Drawing.Point(752, 705);
            this.btn_opendoor.Name = "btn_opendoor";
            this.btn_opendoor.Size = new System.Drawing.Size(64, 57);
            this.btn_opendoor.TabIndex = 7;
            this.btn_opendoor.UseVisualStyleBackColor = true;
            this.btn_opendoor.Click += new System.EventHandler(this.btn_opendoor_Click);
            // 
            // btn_closedoors
            // 
            this.btn_closedoors.BackgroundImage = global::OOPsAssignment.Properties.Resources.close_door;
            this.btn_closedoors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_closedoors.Location = new System.Drawing.Point(632, 705);
            this.btn_closedoors.Name = "btn_closedoors";
            this.btn_closedoors.Size = new System.Drawing.Size(69, 57);
            this.btn_closedoors.TabIndex = 6;
            this.btn_closedoors.UseVisualStyleBackColor = true;
            this.btn_closedoors.Click += new System.EventHandler(this.btn_closedoors_Click);
            // 
            // btn_groundFloor
            // 
            this.btn_groundFloor.BackgroundImage = global::OOPsAssignment.Properties.Resources.groundFloor;
            this.btn_groundFloor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_groundFloor.Location = new System.Drawing.Point(694, 626);
            this.btn_groundFloor.Name = "btn_groundFloor";
            this.btn_groundFloor.Size = new System.Drawing.Size(58, 57);
            this.btn_groundFloor.TabIndex = 5;
            this.btn_groundFloor.UseVisualStyleBackColor = true;
            this.btn_groundFloor.Click += new System.EventHandler(this.btn_groundFloor_Click);
            // 
            // btn_firstFloor
            // 
            this.btn_firstFloor.AutoSize = true;
            this.btn_firstFloor.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_firstFloor.BackgroundImage = global::OOPsAssignment.Properties.Resources.firstFloor;
            this.btn_firstFloor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_firstFloor.Location = new System.Drawing.Point(694, 552);
            this.btn_firstFloor.Name = "btn_firstFloor";
            this.btn_firstFloor.Size = new System.Drawing.Size(58, 57);
            this.btn_firstFloor.TabIndex = 4;
            this.btn_firstFloor.UseVisualStyleBackColor = false;
            this.btn_firstFloor.Click += new System.EventHandler(this.btn_firstFloor_Click);
            // 
            // door_downR
            // 
            this.door_downR.Image = global::OOPsAssignment.Properties.Resources.door_panel_R;
            this.door_downR.Location = new System.Drawing.Point(368, 569);
            this.door_downR.Name = "door_downR";
            this.door_downR.Size = new System.Drawing.Size(103, 337);
            this.door_downR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.door_downR.TabIndex = 3;
            this.door_downR.TabStop = false;
            // 
            // door_upR
            // 
            this.door_upR.Image = global::OOPsAssignment.Properties.Resources.door_panel_R;
            this.door_upR.Location = new System.Drawing.Point(368, 105);
            this.door_upR.Name = "door_upR";
            this.door_upR.Size = new System.Drawing.Size(103, 337);
            this.door_upR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.door_upR.TabIndex = 3;
            this.door_upR.TabStop = false;
            // 
            // door_downL
            // 
            this.door_downL.Image = global::OOPsAssignment.Properties.Resources.door_panel;
            this.door_downL.Location = new System.Drawing.Point(268, 569);
            this.door_downL.Name = "door_downL";
            this.door_downL.Size = new System.Drawing.Size(103, 337);
            this.door_downL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.door_downL.TabIndex = 2;
            this.door_downL.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::OOPsAssignment.Properties.Resources.display;
            this.pictureBox6.Location = new System.Drawing.Point(320, 494);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(100, 38);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 1;
            this.pictureBox6.TabStop = false;
            // 
            // door_upL
            // 
            this.door_upL.Image = global::OOPsAssignment.Properties.Resources.door_panel;
            this.door_upL.Location = new System.Drawing.Point(268, 105);
            this.door_upL.Name = "door_upL";
            this.door_upL.Size = new System.Drawing.Size(103, 337);
            this.door_upL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.door_upL.TabIndex = 2;
            this.door_upL.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::OOPsAssignment.Properties.Resources.display;
            this.pictureBox2.Location = new System.Drawing.Point(320, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // liftbox
            // 
            this.liftbox.Image = global::OOPsAssignment.Properties.Resources.inside_life;
            this.liftbox.Location = new System.Drawing.Point(268, 569);
            this.liftbox.Name = "liftbox";
            this.liftbox.Size = new System.Drawing.Size(203, 337);
            this.liftbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.liftbox.TabIndex = 8;
            this.liftbox.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::OOPsAssignment.Properties.Resources.door_frame;
            this.pictureBox5.Location = new System.Drawing.Point(252, 550);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(237, 356);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OOPsAssignment.Properties.Resources.door_frame;
            this.pictureBox1.Location = new System.Drawing.Point(252, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 356);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::OOPsAssignment.Properties.Resources.button_wall_container;
            this.pictureBox3.Location = new System.Drawing.Point(600, 154);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(239, 733);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // lift_display
            // 
            this.lift_display.BackColor = System.Drawing.SystemColors.Desktop;
            this.lift_display.Location = new System.Drawing.Point(650, 213);
            this.lift_display.Name = "lift_display";
            this.lift_display.Size = new System.Drawing.Size(142, 291);
            this.lift_display.TabIndex = 10;
            this.lift_display.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1540, 940);
            this.Controls.Add(this.lift_display);
            this.Controls.Add(this.btn_opendoor);
            this.Controls.Add(this.btn_closedoors);
            this.Controls.Add(this.btn_groundFloor);
            this.Controls.Add(this.btn_firstFloor);
            this.Controls.Add(this.door_downR);
            this.Controls.Add(this.door_upR);
            this.Controls.Add(this.door_downL);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.door_upL);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.liftbox);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.door_downR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door_upR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door_downL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door_upL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liftbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lift_display)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox door_upL;
        private System.Windows.Forms.PictureBox door_upR;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox door_downL;
        private System.Windows.Forms.PictureBox door_downR;
        private System.Windows.Forms.Button btn_firstFloor;
        private System.Windows.Forms.Button btn_groundFloor;
        private System.Windows.Forms.Button btn_closedoors;
        private System.Windows.Forms.Button btn_opendoor;
        private System.Windows.Forms.Timer updoors_open;
        private System.Windows.Forms.Timer updoors_close;
        private System.Windows.Forms.Timer downdoors_open;
        private System.Windows.Forms.Timer downdoors_close;
        private System.Windows.Forms.Timer go_up;
        private System.Windows.Forms.Timer go_down;
        private System.Windows.Forms.PictureBox liftbox;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox lift_display;
    }
}

