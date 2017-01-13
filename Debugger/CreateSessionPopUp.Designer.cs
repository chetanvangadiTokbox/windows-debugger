namespace Debugger
{
    partial class CreateSessionPopup
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sesssionTypeCheckbox = new System.Windows.Forms.CheckBox();
            this.connectionEventSupressCheckbox = new System.Windows.Forms.CheckBox();
            this.envComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.create = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "P2P Session";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Environment";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(106, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(325, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Connection Event Supressed";
            // 
            // sesssionTypeCheckbox
            // 
            this.sesssionTypeCheckbox.AutoSize = true;
            this.sesssionTypeCheckbox.Location = new System.Drawing.Point(609, 68);
            this.sesssionTypeCheckbox.Name = "sesssionTypeCheckbox";
            this.sesssionTypeCheckbox.Size = new System.Drawing.Size(22, 21);
            this.sesssionTypeCheckbox.TabIndex = 3;
            this.sesssionTypeCheckbox.UseVisualStyleBackColor = true;
            // 
            // connectionEventSupressCheckbox
            // 
            this.connectionEventSupressCheckbox.AutoSize = true;
            this.connectionEventSupressCheckbox.Location = new System.Drawing.Point(609, 241);
            this.connectionEventSupressCheckbox.Name = "connectionEventSupressCheckbox";
            this.connectionEventSupressCheckbox.Size = new System.Drawing.Size(22, 21);
            this.connectionEventSupressCheckbox.TabIndex = 4;
            this.connectionEventSupressCheckbox.UseVisualStyleBackColor = true;
            // 
            // envComboBox
            // 
            this.envComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.envComboBox.FormattingEnabled = true;
            this.envComboBox.Location = new System.Drawing.Point(609, 140);
            this.envComboBox.Name = "envComboBox";
            this.envComboBox.Size = new System.Drawing.Size(121, 32);
            this.envComboBox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(111, 355);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // create
            // 
            this.create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.create.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.create.Location = new System.Drawing.Point(609, 355);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(120, 40);
            this.create.TabIndex = 7;
            this.create.Text = "Create";
            this.create.UseVisualStyleBackColor = false;
            this.create.Click += new System.EventHandler(this.create_session);
            // 
            // CreateSessionPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(861, 588);
            this.Controls.Add(this.create);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.envComboBox);
            this.Controls.Add(this.connectionEventSupressCheckbox);
            this.Controls.Add(this.sesssionTypeCheckbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "CreateSessionPopUp";
            this.Text = "CreateSessionPopUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox sesssionTypeCheckbox;
        private System.Windows.Forms.CheckBox connectionEventSupressCheckbox;
        private System.Windows.Forms.ComboBox envComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button create;
    }
}