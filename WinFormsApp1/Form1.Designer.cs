namespace WinFormsApp1
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
            this.Manage_Subscription = new System.Windows.Forms.Button();
            this.Publish_Notification = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Manage_Subscription
            // 
            this.Manage_Subscription.Location = new System.Drawing.Point(123, 44);
            this.Manage_Subscription.Name = "Manage_Subscription";
            this.Manage_Subscription.Size = new System.Drawing.Size(174, 29);
            this.Manage_Subscription.TabIndex = 0;
            this.Manage_Subscription.Text = "Manage Subscription";
            this.Manage_Subscription.UseVisualStyleBackColor = true;
            this.Manage_Subscription.Click += new System.EventHandler(this.button1_Click);
            // 
            // Publish_Notification
            // 
            this.Publish_Notification.Location = new System.Drawing.Point(325, 44);
            this.Publish_Notification.Name = "Publish_Notification";
            this.Publish_Notification.Size = new System.Drawing.Size(174, 29);
            this.Publish_Notification.TabIndex = 1;
            this.Publish_Notification.Text = "Publish Notification";
            this.Publish_Notification.UseVisualStyleBackColor = true;
            this.Publish_Notification.Click += new System.EventHandler(this.Publish_Notification_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(528, 44);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(174, 29);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 175);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Publish_Notification);
            this.Controls.Add(this.Manage_Subscription);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button Manage_Subscription;
        private Button Publish_Notification;
        private Button Exit;
    }
}