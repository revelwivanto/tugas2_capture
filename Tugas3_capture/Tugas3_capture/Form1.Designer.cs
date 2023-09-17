namespace Tugas3_capture
{
    partial class CameraApp
    {
        private const HorizontalAlignment center = HorizontalAlignment.Center;

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
            listCameraComboBox = new ComboBox();
            startBox = new TextBox();
            captureBox = new TextBox();
            saveBox = new TextBox();
            exitBxox = new TextBox();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // listCameraComboBox
            // 
            listCameraComboBox.FormattingEnabled = true;
            listCameraComboBox.Location = new Point(12, 12);
            listCameraComboBox.Name = "listCameraComboBox";
            listCameraComboBox.Size = new Size(458, 40);
            listCameraComboBox.TabIndex = 0;
            // 
            // startBox
            // 
            startBox.Location = new Point(476, 13);
            startBox.Name = "startBox";
            startBox.Size = new Size(200, 39);
            startBox.TabIndex = 1;
            startBox.Text = "Start";
            startBox.TextAlign = HorizontalAlignment.Center;
            startBox.TextChanged += startBox_TextChanged;
            // 
            // captureBox
            // 
            captureBox.Location = new Point(682, 14);
            captureBox.Name = "captureBox";
            captureBox.Size = new Size(200, 39);
            captureBox.TabIndex = 2;
            captureBox.Text = "Capture";
            captureBox.TextAlign = HorizontalAlignment.Center;
            captureBox.TextChanged += captureBox_TextChanged;
            // 
            // saveBox
            // 
            saveBox.Location = new Point(888, 14);
            saveBox.Name = "saveBox";
            saveBox.Size = new Size(200, 39);
            saveBox.TabIndex = 3;
            saveBox.Text = "Save";
            saveBox.TextAlign = HorizontalAlignment.Center;
            saveBox.TextChanged += saveBox_TextChanged;
            // 
            // exitBxox
            // 
            exitBxox.Location = new Point(1598, 12);
            exitBxox.Name = "exitBxox";
            exitBxox.Size = new Size(119, 39);
            exitBxox.TabIndex = 4;
            exitBxox.Text = "Exit";
            exitBxox.TextAlign = HorizontalAlignment.Center;
            exitBxox.TextChanged += exitBxox_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(846, 458);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(pictureBox2, 1, 0);
            tableLayoutPanel1.Location = new Point(12, 76);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1705, 465);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(855, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(847, 459);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // CameraApp
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1729, 545);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(exitBxox);
            Controls.Add(saveBox);
            Controls.Add(captureBox);
            Controls.Add(startBox);
            Controls.Add(listCameraComboBox);
            Name = "CameraApp";
            Text = "CameraApp";
            Load += CameraApp_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox listCameraComboBox;
        private TextBox startBox;
        private TextBox captureBox;
        private TextBox saveBox;
        private TextBox exitBxox;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox2;
    }
}