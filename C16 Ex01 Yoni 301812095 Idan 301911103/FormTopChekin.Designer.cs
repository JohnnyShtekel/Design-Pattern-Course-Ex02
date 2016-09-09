namespace C16_Ex01_Yoni_301812095_Idan_301911103
{
    partial class FormTopCheckin
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
            this.listViewCheckins = new System.Windows.Forms.ListView();
            this.columnId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLocation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLikes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewCheckins
            // 
            this.listViewCheckins.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnId,
            this.columnLocation,
            this.columnLikes});
            this.listViewCheckins.FullRowSelect = true;
            this.listViewCheckins.GridLines = true;
            this.listViewCheckins.Location = new System.Drawing.Point(12, 12);
            this.listViewCheckins.MultiSelect = false;
            this.listViewCheckins.Name = "listViewCheckins";
            this.listViewCheckins.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listViewCheckins.Size = new System.Drawing.Size(422, 291);
            this.listViewCheckins.TabIndex = 1;
            this.listViewCheckins.UseCompatibleStateImageBehavior = false;
            this.listViewCheckins.View = System.Windows.Forms.View.Details;
            // 
            // columnId
            // 
            this.columnId.Text = "Id";
            this.columnId.Width = 102;
            // 
            // columnLocation
            // 
            this.columnLocation.Text = "Location";
            this.columnLocation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnLocation.Width = 256;
            // 
            // columnLikes
            // 
            this.columnLikes.Text = "Likes";
            this.columnLikes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FormTopCheckin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 315);
            this.Controls.Add(this.listViewCheckins);
            this.Name = "FormTopCheckin";
            this.Text = "FormRatedChekin";
            this.Shown += new System.EventHandler(this.FormTopCheckin_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewCheckins;
        private System.Windows.Forms.ColumnHeader columnId;
        private System.Windows.Forms.ColumnHeader columnLocation;
        private System.Windows.Forms.ColumnHeader columnLikes;
    }
}