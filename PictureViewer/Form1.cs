namespace PictureViewer
{
    using System;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;
    public partial class Form1 : Form
    {
        private string[] imageFiles;  // Mang cac file anh
        private int currentIndex = -1; // Chi so anh hien tai
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void ShowImageAtIndex(int index)
        {
            if (index >= 0 && index < imageFiles.Length)//Neu anh nam trong mang tu 0 den n-1
            {
                pictureBox1.Image = Image.FromFile(imageFiles[index]); // Hien thi anh
                lblImageName.Text = Path.GetFileName(imageFiles[index]); // Hien thi ten file
            }
        }
        private void Thumbnail_Click(object sender, EventArgs e)
        {
            PictureBox clickedThumbnail = sender as PictureBox;
            currentIndex = flowLayoutPanel1.Controls.IndexOf(clickedThumbnail); // Xac dinh vi tri cua thumbnail trong FlowLayoutPanel
            ShowImageAtIndex(currentIndex); // Hien thi anh tuong ung
        }

        private void LoadThumbnails()
        {
            flowLayoutPanel1.Controls.Clear(); // Xoa cac thumbnail truoc do

            foreach (string file in imageFiles)
            {
                PictureBox thumbnail = new PictureBox();
                thumbnail.Image = Image.FromFile(file); // Load anh tu file
                thumbnail.SizeMode = PictureBoxSizeMode.Zoom; // Can chinh kich thuoc
                thumbnail.Size = new Size(100, 100); // Kich thuoc thumbnail

                thumbnail.Click += Thumbnail_Click; // Them su kien click cho moi thumbnail

                flowLayoutPanel1.Controls.Add(thumbnail); // Them vao FlowLayoutPanel
            }

            // Dat chi so anh dau tien
            if (imageFiles.Length > 0)
            {
                currentIndex = 0;
                ShowImageAtIndex(currentIndex); // Hien thi anh dau tien
            }
        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = true; // Cho phep chon nhieu anh
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imageFiles = openFileDialog.FileNames; // Luu cac file anh da chon
                    LoadThumbnails(); // Load cac thumbnail vao FlowLayoutPanel
                }
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                ShowImageAtIndex(currentIndex); // Hien thi anh truoc do
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if(currentIndex != -1)
                if (currentIndex < imageFiles.Length - 1)
                {
                    currentIndex++;
                    ShowImageAtIndex(currentIndex); // Hien thi anh tiep theo
                }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Left:
                    btnLeft.PerformClick(); // Kich hoat nut Left
                    return true;
                case Keys.Right:
                    btnRight.PerformClick(); // Kich hoat nut Right
                    return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if(currentIndex >= 0 && currentIndex < imageFiles.Length)
    {
                Form fullScreen = new Form(); // Tao form moi de phong to hinh anh
                fullScreen.WindowState = FormWindowState.Maximized;
                PictureBox fullImage = new PictureBox();
                fullImage.Image = Image.FromFile(imageFiles[currentIndex]);
                fullImage.Dock = DockStyle.Fill;
                fullImage.SizeMode = PictureBoxSizeMode.Zoom;
                fullScreen.Controls.Add(fullImage);
                fullScreen.ShowDialog(); // Hien thi form phong to
            }
        }
    }
}
