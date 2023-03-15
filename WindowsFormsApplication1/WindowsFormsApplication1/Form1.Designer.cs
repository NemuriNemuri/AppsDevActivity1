namespace WindowsFormsApplication1
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
            this.submitButton = new System.Windows.Forms.Button();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameInputField = new System.Windows.Forms.TextBox();
            this.lastNameInputField = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.titleText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(79, 250);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(206, 56);
            this.submitButton.TabIndex = 0;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.firstNameLabel.Location = new System.Drawing.Point(76, 147);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.firstNameLabel.TabIndex = 2;
            this.firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.lastNameLabel.Location = new System.Drawing.Point(76, 191);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.lastNameLabel.TabIndex = 3;
            this.lastNameLabel.Text = "Last Name";
            // 
            // firstNameInputField
            // 
            this.firstNameInputField.Location = new System.Drawing.Point(79, 163);
            this.firstNameInputField.Name = "firstNameInputField";
            this.firstNameInputField.Size = new System.Drawing.Size(206, 20);
            this.firstNameInputField.TabIndex = 4;
            this.firstNameInputField.TextChanged += new System.EventHandler(this.firstNameInputField_TextChanged);
            // 
            // lastNameInputField
            // 
            this.lastNameInputField.Location = new System.Drawing.Point(79, 207);
            this.lastNameInputField.Name = "lastNameInputField";
            this.lastNameInputField.Size = new System.Drawing.Size(206, 20);
            this.lastNameInputField.TabIndex = 5;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(79, 312);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(206, 55);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // titleText
            // 
            this.titleText.AutoSize = true;
            this.titleText.BackColor = System.Drawing.Color.Transparent;
            this.titleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleText.Location = new System.Drawing.Point(17, 44);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(352, 39);
            this.titleText.TabIndex = 7;
            this.titleText.Text = "Greetings Generator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Resource1.bgImage;
            this.ClientSize = new System.Drawing.Size(381, 477);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.lastNameInputField);
            this.Controls.Add(this.firstNameInputField);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.submitButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastNameInputField;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox firstNameInputField;
        private System.Windows.Forms.Label titleText;
    }
}

