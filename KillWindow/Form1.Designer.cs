namespace KillWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnKill = new System.Windows.Forms.Button();
            this.windowName = new System.Windows.Forms.TextBox();
            this.windowsList = new System.Windows.Forms.ListBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cbAuto = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnKill
            // 
            this.btnKill.Location = new System.Drawing.Point(297, 12);
            this.btnKill.Name = "btnKill";
            this.btnKill.Size = new System.Drawing.Size(75, 23);
            this.btnKill.TabIndex = 0;
            this.btnKill.Text = "Kill";
            this.btnKill.UseVisualStyleBackColor = true;
            this.btnKill.Click += new System.EventHandler(this.btnKill_Click);
            // 
            // windowName
            // 
            this.windowName.Location = new System.Drawing.Point(12, 12);
            this.windowName.Multiline = true;
            this.windowName.Name = "windowName";
            this.windowName.Size = new System.Drawing.Size(279, 23);
            this.windowName.TabIndex = 1;
            // 
            // windowsList
            // 
            this.windowsList.FormattingEnabled = true;
            this.windowsList.Location = new System.Drawing.Point(12, 38);
            this.windowsList.Name = "windowsList";
            this.windowsList.Size = new System.Drawing.Size(360, 407);
            this.windowsList.TabIndex = 2;
            this.windowsList.SelectedIndexChanged += new System.EventHandler(this.windowsList_SelectedIndexChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(151, 451);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(221, 30);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh windows list";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cbAuto
            // 
            this.cbAuto.AutoSize = true;
            this.cbAuto.Location = new System.Drawing.Point(12, 451);
            this.cbAuto.Name = "cbAuto";
            this.cbAuto.Size = new System.Drawing.Size(136, 17);
            this.cbAuto.TabIndex = 4;
            this.cbAuto.Text = "Auto close when select";
            this.cbAuto.UseVisualStyleBackColor = true;
            this.cbAuto.CheckedChanged += new System.EventHandler(this.cbAuto_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 493);
            this.Controls.Add(this.cbAuto);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.windowsList);
            this.Controls.Add(this.windowName);
            this.Controls.Add(this.btnKill);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Kill Window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKill;
        private System.Windows.Forms.TextBox windowName;
        private System.Windows.Forms.ListBox windowsList;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox cbAuto;
    }
}

