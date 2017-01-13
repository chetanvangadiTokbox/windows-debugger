namespace Debugger
{
    partial class PublisherSettingsPopup
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
            this.label1 = new System.Windows.Forms.Label();
            this.resolutionCombobox = new System.Windows.Forms.ComboBox();
            this.framerateComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.audioCheckBox = new System.Windows.Forms.CheckBox();
            this.videoCheckbox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.setPublisher = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resolution";
            // 
            // resolutionCombobox
            // 
            this.resolutionCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resolutionCombobox.Enabled = false;
            this.resolutionCombobox.FormattingEnabled = true;
            this.resolutionCombobox.Location = new System.Drawing.Point(476, 52);
            this.resolutionCombobox.Name = "resolutionCombobox";
            this.resolutionCombobox.Size = new System.Drawing.Size(121, 32);
            this.resolutionCombobox.TabIndex = 1;
            // 
            // framerateComboBox
            // 
            this.framerateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.framerateComboBox.Enabled = false;
            this.framerateComboBox.FormattingEnabled = true;
            this.framerateComboBox.Location = new System.Drawing.Point(476, 146);
            this.framerateComboBox.Name = "framerateComboBox";
            this.framerateComboBox.Size = new System.Drawing.Size(121, 32);
            this.framerateComboBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F);
            this.label2.Location = new System.Drawing.Point(83, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Framerate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F);
            this.label3.Location = new System.Drawing.Point(83, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Audio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F);
            this.label4.Location = new System.Drawing.Point(83, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "Video";
            // 
            // audioCheckBox
            // 
            this.audioCheckBox.AutoSize = true;
            this.audioCheckBox.Checked = true;
            this.audioCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.audioCheckBox.Location = new System.Drawing.Point(476, 230);
            this.audioCheckBox.Name = "audioCheckBox";
            this.audioCheckBox.Size = new System.Drawing.Size(22, 21);
            this.audioCheckBox.TabIndex = 6;
            this.audioCheckBox.UseVisualStyleBackColor = true;
            // 
            // videoCheckbox
            // 
            this.videoCheckbox.AutoSize = true;
            this.videoCheckbox.Checked = true;
            this.videoCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.videoCheckbox.Location = new System.Drawing.Point(476, 303);
            this.videoCheckbox.Name = "videoCheckbox";
            this.videoCheckbox.Size = new System.Drawing.Size(22, 21);
            this.videoCheckbox.TabIndex = 7;
            this.videoCheckbox.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(83, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 40);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // setPublisher
            // 
            this.setPublisher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.setPublisher.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.setPublisher.Location = new System.Drawing.Point(476, 388);
            this.setPublisher.Name = "setPublisher";
            this.setPublisher.Size = new System.Drawing.Size(120, 40);
            this.setPublisher.TabIndex = 9;
            this.setPublisher.Text = "Set";
            this.setPublisher.UseVisualStyleBackColor = false;
            this.setPublisher.Click += new System.EventHandler(this.publish_button_click);
            // 
            // PublishPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(734, 563);
            this.Controls.Add(this.setPublisher);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.videoCheckbox);
            this.Controls.Add(this.audioCheckBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.framerateComboBox);
            this.Controls.Add(this.resolutionCombobox);
            this.Controls.Add(this.label1);
            this.Name = "PublishPopup";
            this.Text = "PublishPopup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox resolutionCombobox;
        private System.Windows.Forms.ComboBox framerateComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox audioCheckBox;
        private System.Windows.Forms.CheckBox videoCheckbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button setPublisher;
    }
}