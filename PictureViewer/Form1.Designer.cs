namespace PictureViewer
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            btnOpen = new Button();
            btnShow = new Button();
            btnLeft = new Button();
            btnRight = new Button();
            lblImageName = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(12, 329);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(776, 109);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(179, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(609, 311);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnOpen
            // 
            btnOpen.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOpen.Location = new Point(12, 12);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(156, 63);
            btnOpen.TabIndex = 2;
            btnOpen.Text = "Open File";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnShow
            // 
            btnShow.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShow.Location = new Point(12, 81);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(156, 64);
            btnShow.TabIndex = 3;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // btnLeft
            // 
            btnLeft.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLeft.Location = new Point(12, 265);
            btnLeft.Name = "btnLeft";
            btnLeft.Size = new Size(75, 58);
            btnLeft.TabIndex = 4;
            btnLeft.Text = "<<";
            btnLeft.UseVisualStyleBackColor = true;
            btnLeft.Click += btnLeft_Click;
            // 
            // btnRight
            // 
            btnRight.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRight.Location = new Point(93, 265);
            btnRight.Name = "btnRight";
            btnRight.Size = new Size(75, 58);
            btnRight.TabIndex = 5;
            btnRight.Text = ">>";
            btnRight.UseVisualStyleBackColor = true;
            btnRight.Click += btnRight_Click;
            // 
            // lblImageName
            // 
            lblImageName.BorderStyle = BorderStyle.FixedSingle;
            lblImageName.Font = new Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblImageName.Location = new Point(12, 148);
            lblImageName.Name = "lblImageName";
            lblImageName.Size = new Size(156, 114);
            lblImageName.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblImageName);
            Controls.Add(btnRight);
            Controls.Add(btnLeft);
            Controls.Add(btnShow);
            Controls.Add(btnOpen);
            Controls.Add(pictureBox1);
            Controls.Add(flowLayoutPanel1);
            Name = "Form1";
            Text = "NVT1 Picture Viewer";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox1;
        private Button btnOpen;
        private Button btnShow;
        private Button btnLeft;
        private Button btnRight;
        private Label lblImageName;
    }
}
