﻿namespace Presentation
{
    partial class frmAddTask
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbCategories = new System.Windows.Forms.ComboBox();
            this.cbPriority = new System.Windows.Forms.ComboBox();
            this.dtmEndDate = new System.Windows.Forms.DateTimePicker();
            this.txtTitle = new System.Windows.Forms.RichTextBox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.toolRefresh = new System.Windows.Forms.ToolTip(this.components);
            this.btnNextWeek = new System.Windows.Forms.Panel();
            this.btnWeekend = new System.Windows.Forms.Panel();
            this.btnTomorrow = new System.Windows.Forms.Panel();
            this.btnToday = new System.Windows.Forms.Panel();
            this.pnlRefresh = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.toolToday = new System.Windows.Forms.ToolTip(this.components);
            this.toolTomorrow = new System.Windows.Forms.ToolTip(this.components);
            this.toolWeekend = new System.Windows.Forms.ToolTip(this.components);
            this.toolNextWeek = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(659, 67);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Honeydew;
            this.panel2.Controls.Add(this.btnNextWeek);
            this.panel2.Controls.Add(this.btnWeekend);
            this.panel2.Controls.Add(this.btnTomorrow);
            this.panel2.Controls.Add(this.btnToday);
            this.panel2.Controls.Add(this.txtDescription);
            this.panel2.Controls.Add(this.pnlRefresh);
            this.panel2.Controls.Add(this.btnAddTask);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.cbCategories);
            this.panel2.Controls.Add(this.cbPriority);
            this.panel2.Controls.Add(this.dtmEndDate);
            this.panel2.Controls.Add(this.txtTitle);
            this.panel2.Location = new System.Drawing.Point(0, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(659, 309);
            this.panel2.TabIndex = 1;
            // 
            // btnAddTask
            // 
            this.btnAddTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTask.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddTask.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnAddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTask.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTask.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnAddTask.Location = new System.Drawing.Point(538, 244);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(92, 32);
            this.btnAddTask.TabIndex = 6;
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnCancel.Location = new System.Drawing.Point(435, 244);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(81, 32);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbCategories
            // 
            this.cbCategories.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategories.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cbCategories.FormattingEnabled = true;
            this.cbCategories.Location = new System.Drawing.Point(389, 178);
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.Size = new System.Drawing.Size(121, 29);
            this.cbCategories.TabIndex = 4;
            this.cbCategories.Text = "Categories";
            // 
            // cbPriority
            // 
            this.cbPriority.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPriority.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cbPriority.FormattingEnabled = true;
            this.cbPriority.Location = new System.Drawing.Point(248, 178);
            this.cbPriority.Name = "cbPriority";
            this.cbPriority.Size = new System.Drawing.Size(121, 29);
            this.cbPriority.TabIndex = 3;
            this.cbPriority.Text = "Priority";
            this.cbPriority.SelectedIndexChanged += new System.EventHandler(this.cbPriority_SelectedIndexChanged);
            // 
            // dtmEndDate
            // 
            this.dtmEndDate.Location = new System.Drawing.Point(12, 182);
            this.dtmEndDate.Name = "dtmEndDate";
            this.dtmEndDate.Size = new System.Drawing.Size(212, 20);
            this.dtmEndDate.TabIndex = 2;
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.Honeydew;
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtTitle.Location = new System.Drawing.Point(12, 15);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(520, 40);
            this.txtTitle.TabIndex = 1;
            this.txtTitle.Text = "";
            this.txtTitle.Click += new System.EventHandler(this.txtTitle_Click);
            this.txtTitle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtTitle_MouseClick);
            this.txtTitle.Leave += new System.EventHandler(this.txtTitle_Leave);
            this.txtTitle.MouseEnter += new System.EventHandler(this.txtTitle_MouseEnter);
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.Honeydew;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.EnableAutoDragDrop = true;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(12, 61);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(520, 107);
            this.txtDescription.TabIndex = 8;
            this.txtDescription.Text = "";
            this.txtDescription.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtDescription_MouseClick);
            this.txtDescription.Leave += new System.EventHandler(this.txtDescription_Leave);
            // 
            // btnNextWeek
            // 
            this.btnNextWeek.BackgroundImage = global::Presentation.Properties.Resources.Nextweek;
            this.btnNextWeek.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextWeek.Location = new System.Drawing.Point(153, 221);
            this.btnNextWeek.Name = "btnNextWeek";
            this.btnNextWeek.Size = new System.Drawing.Size(40, 40);
            this.btnNextWeek.TabIndex = 12;
            this.btnNextWeek.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnNextWeek_MouseClick);
            // 
            // btnWeekend
            // 
            this.btnWeekend.BackgroundImage = global::Presentation.Properties.Resources.Weekend;
            this.btnWeekend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWeekend.Location = new System.Drawing.Point(107, 221);
            this.btnWeekend.Name = "btnWeekend";
            this.btnWeekend.Size = new System.Drawing.Size(40, 40);
            this.btnWeekend.TabIndex = 11;
            this.btnWeekend.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnWeekend_MouseClick);
            // 
            // btnTomorrow
            // 
            this.btnTomorrow.BackgroundImage = global::Presentation.Properties.Resources.Tomorrow;
            this.btnTomorrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTomorrow.Location = new System.Drawing.Point(61, 221);
            this.btnTomorrow.Name = "btnTomorrow";
            this.btnTomorrow.Size = new System.Drawing.Size(40, 40);
            this.btnTomorrow.TabIndex = 10;
            this.btnTomorrow.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnTomorrow_MouseClick);
            // 
            // btnToday
            // 
            this.btnToday.BackgroundImage = global::Presentation.Properties.Resources.Today;
            this.btnToday.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnToday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToday.Location = new System.Drawing.Point(15, 221);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(40, 40);
            this.btnToday.TabIndex = 9;
            this.btnToday.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnToday_MouseClick);
            // 
            // pnlRefresh
            // 
            this.pnlRefresh.BackgroundImage = global::Presentation.Properties.Resources.LogoRefreshPNG;
            this.pnlRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlRefresh.Location = new System.Drawing.Point(556, 15);
            this.pnlRefresh.Name = "pnlRefresh";
            this.pnlRefresh.Size = new System.Drawing.Size(40, 40);
            this.pnlRefresh.TabIndex = 7;
            this.pnlRefresh.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseClick);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::Presentation.Properties.Resources.icons8_close_window_50__2_;
            this.btnClose.Location = new System.Drawing.Point(613, 14);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 26);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 29;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmAddTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 375);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddTask";
            this.Text = "frmAddTask";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbCategories;
        private System.Windows.Forms.ComboBox cbPriority;
        private System.Windows.Forms.DateTimePicker dtmEndDate;
        private System.Windows.Forms.RichTextBox txtTitle;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Panel pnlRefresh;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.ToolTip toolRefresh;
        private System.Windows.Forms.Panel btnTomorrow;
        private System.Windows.Forms.Panel btnToday;
        private System.Windows.Forms.Panel btnNextWeek;
        private System.Windows.Forms.Panel btnWeekend;
        private System.Windows.Forms.ToolTip toolToday;
        private System.Windows.Forms.ToolTip toolTomorrow;
        private System.Windows.Forms.ToolTip toolWeekend;
        private System.Windows.Forms.ToolTip toolNextWeek;
    }
}