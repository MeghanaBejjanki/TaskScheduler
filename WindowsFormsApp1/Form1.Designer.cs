﻿namespace WindowsFormsApp1
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
            this.DateLabel = new System.Windows.Forms.Label();
            this.DayLabel = new System.Windows.Forms.Label();
            this.YesterdaysScheduleButton = new System.Windows.Forms.Button();
            this.TodaysScheduleButton = new System.Windows.Forms.Button();
            this.AddTaskButton = new System.Windows.Forms.Button();
            this.DeleteTaskButton = new System.Windows.Forms.Button();
            this.TaskListArea = new System.Windows.Forms.RichTextBox();
            this.ChangeDayButton = new System.Windows.Forms.Button();
            this.SerialLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.TaskLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(91, 63);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(45, 17);
            this.DateLabel.TabIndex = 0;
            this.DateLabel.Text = "DATE";
            this.DateLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // DayLabel
            // 
            this.DayLabel.AutoSize = true;
            this.DayLabel.Location = new System.Drawing.Point(324, 63);
            this.DayLabel.Name = "DayLabel";
            this.DayLabel.Size = new System.Drawing.Size(36, 17);
            this.DayLabel.TabIndex = 1;
            this.DayLabel.Text = "DAY";
            this.DayLabel.Click += new System.EventHandler(this.DayLabel_Click);
            // 
            // YesterdaysScheduleButton
            // 
            this.YesterdaysScheduleButton.Location = new System.Drawing.Point(327, 474);
            this.YesterdaysScheduleButton.Name = "YesterdaysScheduleButton";
            this.YesterdaysScheduleButton.Size = new System.Drawing.Size(197, 42);
            this.YesterdaysScheduleButton.TabIndex = 3;
            this.YesterdaysScheduleButton.Text = "DISPLAY YESTERDAY\'S SCHEDULE";
            this.YesterdaysScheduleButton.UseVisualStyleBackColor = true;
            this.YesterdaysScheduleButton.Click += new System.EventHandler(this.YesterdaysScheduleButton_Click);
            // 
            // TodaysScheduleButton
            // 
            this.TodaysScheduleButton.Location = new System.Drawing.Point(94, 474);
            this.TodaysScheduleButton.Name = "TodaysScheduleButton";
            this.TodaysScheduleButton.Size = new System.Drawing.Size(197, 42);
            this.TodaysScheduleButton.TabIndex = 4;
            this.TodaysScheduleButton.Text = "DISPLAY TODAY\'S SCHEDULE";
            this.TodaysScheduleButton.UseVisualStyleBackColor = true;
            this.TodaysScheduleButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddTaskButton
            // 
            this.AddTaskButton.Location = new System.Drawing.Point(94, 554);
            this.AddTaskButton.Name = "AddTaskButton";
            this.AddTaskButton.Size = new System.Drawing.Size(197, 42);
            this.AddTaskButton.TabIndex = 5;
            this.AddTaskButton.Text = "ADD TASK";
            this.AddTaskButton.UseVisualStyleBackColor = true;
            this.AddTaskButton.Click += new System.EventHandler(this.AddTaskButton_Click);
            // 
            // DeleteTaskButton
            // 
            this.DeleteTaskButton.Location = new System.Drawing.Point(327, 554);
            this.DeleteTaskButton.Name = "DeleteTaskButton";
            this.DeleteTaskButton.Size = new System.Drawing.Size(197, 42);
            this.DeleteTaskButton.TabIndex = 6;
            this.DeleteTaskButton.Text = "DELETE TASK";
            this.DeleteTaskButton.UseVisualStyleBackColor = true;
            this.DeleteTaskButton.Click += new System.EventHandler(this.DeleteTaskButton_Click);
            // 
            // TaskListArea
            // 
            this.TaskListArea.Location = new System.Drawing.Point(94, 115);
            this.TaskListArea.Name = "TaskListArea";
            this.TaskListArea.Size = new System.Drawing.Size(650, 339);
            this.TaskListArea.TabIndex = 7;
            this.TaskListArea.Text = "";
            this.TaskListArea.TextChanged += new System.EventHandler(this.TaskListArea_TextChanged);
            // 
            // ChangeDayButton
            // 
            this.ChangeDayButton.Location = new System.Drawing.Point(547, 474);
            this.ChangeDayButton.Name = "ChangeDayButton";
            this.ChangeDayButton.Size = new System.Drawing.Size(197, 42);
            this.ChangeDayButton.TabIndex = 8;
            this.ChangeDayButton.Text = "CHANGE DAY";
            this.ChangeDayButton.UseVisualStyleBackColor = true;
            this.ChangeDayButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // SerialLabel
            // 
            this.SerialLabel.AutoSize = true;
            this.SerialLabel.Location = new System.Drawing.Point(91, 95);
            this.SerialLabel.Name = "SerialLabel";
            this.SerialLabel.Size = new System.Drawing.Size(54, 17);
            this.SerialLabel.TabIndex = 9;
            this.SerialLabel.Text = "SL NO.";
            this.SerialLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(170, 95);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(40, 17);
            this.TimeLabel.TabIndex = 10;
            this.TimeLabel.Text = "TIME";
            // 
            // TaskLabel
            // 
            this.TaskLabel.AutoSize = true;
            this.TaskLabel.Location = new System.Drawing.Point(324, 95);
            this.TaskLabel.Name = "TaskLabel";
            this.TaskLabel.Size = new System.Drawing.Size(44, 17);
            this.TaskLabel.TabIndex = 11;
            this.TaskLabel.Text = "TASK";
            this.TaskLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 585);
            this.Controls.Add(this.TaskLabel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.SerialLabel);
            this.Controls.Add(this.ChangeDayButton);
            this.Controls.Add(this.TaskListArea);
            this.Controls.Add(this.DeleteTaskButton);
            this.Controls.Add(this.AddTaskButton);
            this.Controls.Add(this.TodaysScheduleButton);
            this.Controls.Add(this.YesterdaysScheduleButton);
            this.Controls.Add(this.DayLabel);
            this.Controls.Add(this.DateLabel);
            this.Name = "Form1";
            this.Text = "DISPLAY TODAYS SHCEDULE";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label DayLabel;
        private System.Windows.Forms.Button YesterdaysScheduleButton;
        private System.Windows.Forms.Button TodaysScheduleButton;
        private System.Windows.Forms.Button AddTaskButton;
        private System.Windows.Forms.Button DeleteTaskButton;
        private System.Windows.Forms.RichTextBox TaskListArea;
        private System.Windows.Forms.Button ChangeDayButton;
        private System.Windows.Forms.Label SerialLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label TaskLabel;
    }
}

