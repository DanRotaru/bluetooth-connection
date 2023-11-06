namespace Bluetooth
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnConnect = new Button();
            comboBoxDevices = new ComboBox();
            lblStatus = new Label();
            btnDisconnect = new Button();
            updateDevices = new Button();
            SuspendLayout();
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(12, 51);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(178, 34);
            btnConnect.TabIndex = 0;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // comboBoxDevices
            // 
            comboBoxDevices.FormattingEnabled = true;
            comboBoxDevices.Location = new Point(12, 12);
            comboBoxDevices.Name = "comboBoxDevices";
            comboBoxDevices.Size = new Size(350, 33);
            comboBoxDevices.TabIndex = 2;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(12, 98);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(72, 25);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "Status...";
            // 
            // btnDisconnect
            // 
            btnDisconnect.Location = new Point(196, 51);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Size = new Size(126, 34);
            btnDisconnect.TabIndex = 4;
            btnDisconnect.Text = "Disconnect";
            btnDisconnect.UseVisualStyleBackColor = true;
            btnDisconnect.Click += btnDisconnect_Click;
            // 
            // updateDevices
            // 
            updateDevices.Location = new Point(328, 51);
            updateDevices.Name = "updateDevices";
            updateDevices.Size = new Size(34, 34);
            updateDevices.TabIndex = 5;
            updateDevices.Text = "U";
            updateDevices.UseVisualStyleBackColor = true;
            updateDevices.Click += updateDevices_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnConnect;
            ClientSize = new Size(374, 136);
            Controls.Add(updateDevices);
            Controls.Add(btnDisconnect);
            Controls.Add(lblStatus);
            Controls.Add(comboBoxDevices);
            Controls.Add(btnConnect);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Bluetooth";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConnect;
        private ComboBox comboBoxDevices;
        private Label lblStatus;
        private Button btnDisconnect;
        private Button updateDevices;
    }
}