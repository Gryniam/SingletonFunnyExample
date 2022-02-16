
namespace Televisor
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
            this.headPanel = new System.Windows.Forms.Panel();
            this.hideLabel = new System.Windows.Forms.Label();
            this.closeLabel = new System.Windows.Forms.Label();
            this.screenPanel = new System.Windows.Forms.Panel();
            this.channelStatusLabel = new System.Windows.Forms.Label();
            this.screenBox = new System.Windows.Forms.PictureBox();
            this.soundStatusLabel = new System.Windows.Forms.Label();
            this.remotePanel = new System.Windows.Forms.Panel();
            this.signalButton = new System.Windows.Forms.Button();
            this.channelRightButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.channelLeftButton = new System.Windows.Forms.Button();
            this.soundDownButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.soundUpButton = new System.Windows.Forms.Button();
            this.tvOnPannel = new System.Windows.Forms.Button();
            this.teleBox = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.headPanel.SuspendLayout();
            this.screenPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.screenBox)).BeginInit();
            this.remotePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teleBox)).BeginInit();
            this.SuspendLayout();
            // 
            // headPanel
            // 
            this.headPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.headPanel.Controls.Add(this.hideLabel);
            this.headPanel.Controls.Add(this.closeLabel);
            this.headPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headPanel.Location = new System.Drawing.Point(0, 0);
            this.headPanel.Name = "headPanel";
            this.headPanel.Size = new System.Drawing.Size(911, 38);
            this.headPanel.TabIndex = 1;
            this.headPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.headPanel_MouseDown);
            this.headPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headPanel_MouseMove);
            // 
            // hideLabel
            // 
            this.hideLabel.AutoSize = true;
            this.hideLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hideLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.hideLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hideLabel.Location = new System.Drawing.Point(0, 0);
            this.hideLabel.Name = "hideLabel";
            this.hideLabel.Size = new System.Drawing.Size(24, 31);
            this.hideLabel.TabIndex = 1;
            this.hideLabel.Text = "-";
            this.hideLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.hideLabel.Click += new System.EventHandler(this.hideLabel_Click);
            // 
            // closeLabel
            // 
            this.closeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.closeLabel.AutoSize = true;
            this.closeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeLabel.Location = new System.Drawing.Point(874, 9);
            this.closeLabel.Name = "closeLabel";
            this.closeLabel.Size = new System.Drawing.Size(25, 24);
            this.closeLabel.TabIndex = 0;
            this.closeLabel.Text = "X";
            this.closeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeLabel.Click += new System.EventHandler(this.closeLabel_Click);
            // 
            // screenPanel
            // 
            this.screenPanel.Controls.Add(this.channelStatusLabel);
            this.screenPanel.Controls.Add(this.screenBox);
            this.screenPanel.Controls.Add(this.soundStatusLabel);
            this.screenPanel.Location = new System.Drawing.Point(66, 166);
            this.screenPanel.Name = "screenPanel";
            this.screenPanel.Size = new System.Drawing.Size(471, 406);
            this.screenPanel.TabIndex = 2;
            // 
            // channelStatusLabel
            // 
            this.channelStatusLabel.AutoSize = true;
            this.channelStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.channelStatusLabel.Location = new System.Drawing.Point(3, 381);
            this.channelStatusLabel.Name = "channelStatusLabel";
            this.channelStatusLabel.Size = new System.Drawing.Size(68, 16);
            this.channelStatusLabel.TabIndex = 9;
            this.channelStatusLabel.Text = "Channel:";
            // 
            // screenBox
            // 
            this.screenBox.Location = new System.Drawing.Point(6, 3);
            this.screenBox.Name = "screenBox";
            this.screenBox.Size = new System.Drawing.Size(462, 353);
            this.screenBox.TabIndex = 0;
            this.screenBox.TabStop = false;
            // 
            // soundStatusLabel
            // 
            this.soundStatusLabel.AutoSize = true;
            this.soundStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.soundStatusLabel.Location = new System.Drawing.Point(3, 359);
            this.soundStatusLabel.Name = "soundStatusLabel";
            this.soundStatusLabel.Size = new System.Drawing.Size(56, 16);
            this.soundStatusLabel.TabIndex = 8;
            this.soundStatusLabel.Text = "Sound:";
            // 
            // remotePanel
            // 
            this.remotePanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.remotePanel.Controls.Add(this.signalButton);
            this.remotePanel.Controls.Add(this.channelRightButton);
            this.remotePanel.Controls.Add(this.label3);
            this.remotePanel.Controls.Add(this.label2);
            this.remotePanel.Controls.Add(this.channelLeftButton);
            this.remotePanel.Controls.Add(this.soundDownButton);
            this.remotePanel.Controls.Add(this.label1);
            this.remotePanel.Controls.Add(this.soundUpButton);
            this.remotePanel.Controls.Add(this.tvOnPannel);
            this.remotePanel.Location = new System.Drawing.Point(671, 44);
            this.remotePanel.Name = "remotePanel";
            this.remotePanel.Size = new System.Drawing.Size(200, 576);
            this.remotePanel.TabIndex = 3;
            // 
            // signalButton
            // 
            this.signalButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.signalButton.Enabled = false;
            this.signalButton.FlatAppearance.BorderSize = 0;
            this.signalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signalButton.Location = new System.Drawing.Point(21, 16);
            this.signalButton.Name = "signalButton";
            this.signalButton.Size = new System.Drawing.Size(16, 14);
            this.signalButton.TabIndex = 8;
            this.signalButton.UseVisualStyleBackColor = false;
            // 
            // channelRightButton
            // 
            this.channelRightButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.channelRightButton.BackgroundImage = global::Televisor.Properties.Resources.Vpravo;
            this.channelRightButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.channelRightButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.channelRightButton.FlatAppearance.BorderSize = 0;
            this.channelRightButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.channelRightButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.channelRightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.channelRightButton.Location = new System.Drawing.Point(131, 417);
            this.channelRightButton.Name = "channelRightButton";
            this.channelRightButton.Size = new System.Drawing.Size(52, 44);
            this.channelRightButton.TabIndex = 7;
            this.channelRightButton.UseVisualStyleBackColor = false;
            this.channelRightButton.Click += new System.EventHandler(this.channelRightButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(67, 464);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(67, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Channel";
            // 
            // channelLeftButton
            // 
            this.channelLeftButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.channelLeftButton.BackgroundImage = global::Televisor.Properties.Resources.Vlivo;
            this.channelLeftButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.channelLeftButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.channelLeftButton.FlatAppearance.BorderSize = 0;
            this.channelLeftButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.channelLeftButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.channelLeftButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.channelLeftButton.Location = new System.Drawing.Point(21, 417);
            this.channelLeftButton.Name = "channelLeftButton";
            this.channelLeftButton.Size = new System.Drawing.Size(52, 44);
            this.channelLeftButton.TabIndex = 5;
            this.channelLeftButton.UseVisualStyleBackColor = false;
            this.channelLeftButton.Click += new System.EventHandler(this.channelLeftButton_Click);
            // 
            // soundDownButton
            // 
            this.soundDownButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.soundDownButton.BackgroundImage = global::Televisor.Properties.Resources.Vnyz;
            this.soundDownButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.soundDownButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.soundDownButton.FlatAppearance.BorderSize = 0;
            this.soundDownButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.soundDownButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.soundDownButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.soundDownButton.Location = new System.Drawing.Point(79, 269);
            this.soundDownButton.Name = "soundDownButton";
            this.soundDownButton.Size = new System.Drawing.Size(52, 44);
            this.soundDownButton.TabIndex = 4;
            this.soundDownButton.UseVisualStyleBackColor = false;
            this.soundDownButton.Click += new System.EventHandler(this.soundDownButton_Click);
            this.soundDownButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.soundDownButton_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(79, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sound";
            // 
            // soundUpButton
            // 
            this.soundUpButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.soundUpButton.BackgroundImage = global::Televisor.Properties.Resources.Vverh;
            this.soundUpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.soundUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.soundUpButton.FlatAppearance.BorderSize = 0;
            this.soundUpButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.soundUpButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.soundUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.soundUpButton.Location = new System.Drawing.Point(79, 183);
            this.soundUpButton.Name = "soundUpButton";
            this.soundUpButton.Size = new System.Drawing.Size(52, 44);
            this.soundUpButton.TabIndex = 1;
            this.soundUpButton.UseVisualStyleBackColor = false;
            this.soundUpButton.Click += new System.EventHandler(this.soundUpButton_Click);
            this.soundUpButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.soundUpButton_MouseDown);
            // 
            // tvOnPannel
            // 
            this.tvOnPannel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tvOnPannel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.tvOnPannel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tvOnPannel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tvOnPannel.Location = new System.Drawing.Point(131, 16);
            this.tvOnPannel.Name = "tvOnPannel";
            this.tvOnPannel.Size = new System.Drawing.Size(52, 44);
            this.tvOnPannel.TabIndex = 0;
            this.tvOnPannel.UseVisualStyleBackColor = false;
            this.tvOnPannel.Click += new System.EventHandler(this.tvOnPannel_Click);
            // 
            // teleBox
            // 
            this.teleBox.Location = new System.Drawing.Point(6, 44);
            this.teleBox.Name = "teleBox";
            this.teleBox.Size = new System.Drawing.Size(630, 576);
            this.teleBox.TabIndex = 0;
            this.teleBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 653);
            this.Controls.Add(this.remotePanel);
            this.Controls.Add(this.screenPanel);
            this.Controls.Add(this.headPanel);
            this.Controls.Add(this.teleBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.headPanel.ResumeLayout(false);
            this.headPanel.PerformLayout();
            this.screenPanel.ResumeLayout(false);
            this.screenPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.screenBox)).EndInit();
            this.remotePanel.ResumeLayout(false);
            this.remotePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teleBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox teleBox;
        private System.Windows.Forms.Panel headPanel;
        private System.Windows.Forms.Label hideLabel;
        private System.Windows.Forms.Label closeLabel;
        private System.Windows.Forms.Panel screenPanel;
        private System.Windows.Forms.Panel remotePanel;
        private System.Windows.Forms.Button tvOnPannel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button soundUpButton;
        private System.Windows.Forms.Button soundDownButton;
        private System.Windows.Forms.Button channelRightButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button channelLeftButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label channelStatusLabel;
        private System.Windows.Forms.Label soundStatusLabel;
        private System.Windows.Forms.PictureBox screenBox;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button signalButton;
    }
}

