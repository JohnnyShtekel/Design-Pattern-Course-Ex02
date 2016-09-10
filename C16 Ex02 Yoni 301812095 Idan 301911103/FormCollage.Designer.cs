namespace C16_Ex01_Yoni_301812095_Idan_301911103
{
    partial class FormCollage
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
            this.radioButtonOldCollage = new System.Windows.Forms.RadioButton();
            this.radioButtunResentCollage = new System.Windows.Forms.RadioButton();
            this.buttonCreateCollage = new System.Windows.Forms.Button();
            this.labelCollageTitle = new System.Windows.Forms.Label();
            this.pictureBoxCollage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCollage)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButtonOldCollage
            // 
            this.radioButtonOldCollage.AutoSize = true;
            this.radioButtonOldCollage.Location = new System.Drawing.Point(172, 12);
            this.radioButtonOldCollage.Name = "radioButtonOldCollage";
            this.radioButtonOldCollage.Size = new System.Drawing.Size(79, 17);
            this.radioButtonOldCollage.TabIndex = 0;
            this.radioButtonOldCollage.TabStop = true;
            this.radioButtonOldCollage.Tag = "1";
            this.radioButtonOldCollage.Text = "Old Collage";
            this.radioButtonOldCollage.UseVisualStyleBackColor = true;
            // 
            // radioButtunResentCollage
            // 
            this.radioButtunResentCollage.AutoSize = true;
            this.radioButtunResentCollage.Location = new System.Drawing.Point(52, 12);
            this.radioButtunResentCollage.Name = "radioButtunResentCollage";
            this.radioButtunResentCollage.Size = new System.Drawing.Size(97, 17);
            this.radioButtunResentCollage.TabIndex = 1;
            this.radioButtunResentCollage.TabStop = true;
            this.radioButtunResentCollage.Tag = "0";
            this.radioButtunResentCollage.Text = "Resent Collage";
            this.radioButtunResentCollage.UseVisualStyleBackColor = true;
            // 
            // buttonCreateCollage
            // 
            this.buttonCreateCollage.Location = new System.Drawing.Point(398, 12);
            this.buttonCreateCollage.Name = "buttonCreateCollage";
            this.buttonCreateCollage.Size = new System.Drawing.Size(306, 78);
            this.buttonCreateCollage.TabIndex = 3;
            this.buttonCreateCollage.Text = "Create Collage";
            this.buttonCreateCollage.UseVisualStyleBackColor = true;
            this.buttonCreateCollage.Click += new System.EventHandler(this.buttonCreateCollage_Click);
            // 
            // labelCollageTitle
            // 
            this.labelCollageTitle.AutoSize = true;
            this.labelCollageTitle.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCollageTitle.Location = new System.Drawing.Point(162, 112);
            this.labelCollageTitle.Name = "labelCollageTitle";
            this.labelCollageTitle.Size = new System.Drawing.Size(360, 57);
            this.labelCollageTitle.TabIndex = 4;
            this.labelCollageTitle.Text = "Choose your collage :)";
            // 
            // pictureBoxCollage
            // 
            this.pictureBoxCollage.Location = new System.Drawing.Point(156, 192);
            this.pictureBoxCollage.Name = "pictureBoxCollage";
            this.pictureBoxCollage.Size = new System.Drawing.Size(340, 204);
            this.pictureBoxCollage.TabIndex = 5;
            this.pictureBoxCollage.TabStop = false;
            // 
            // FormCollage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 430);
            this.Controls.Add(this.pictureBoxCollage);
            this.Controls.Add(this.labelCollageTitle);
            this.Controls.Add(this.buttonCreateCollage);
            this.Controls.Add(this.radioButtunResentCollage);
            this.Controls.Add(this.radioButtonOldCollage);
            this.Name = "FormCollage";
            this.Text = "FormCollage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCollage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonOldCollage;
        private System.Windows.Forms.RadioButton radioButtunResentCollage;
        private System.Windows.Forms.Button buttonCreateCollage;
        private System.Windows.Forms.Label labelCollageTitle;
        private System.Windows.Forms.PictureBox pictureBoxCollage;
    }
}