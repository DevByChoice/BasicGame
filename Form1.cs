using BasicGame.PlayerCharacter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Management.Instrumentation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicGame
{
    public partial class Form1 : Form
    {
        private PlayerCharacter.PlayerCharacter Player = new PlayerCharacter.PlayerCharacter();
        private Image Model;
        public Form1()
        {
            InitializeComponent();
        }

        
        bool state = false;

        private async void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();
            this.pb_Player.BackColor = Color.Transparent;
            this.btn_Pause.Visible = false;
            this.btn_Settings.Visible = false;
            await WindowManipulation();
            await BackgroundManipulation();
            this.Show();
        }

        private async void btn_Play_Click(object sender, EventArgs e)
        {
            await ButtonDisplay();
            float health = 100;
            float sheild = 100;
            string[] abilities = new string[99];
            string[] buffs = new string[99];
            string[] pets = new string[99];

            Player = Player.ArmCharacter(Player, health, sheild, abilities, buffs, pets);
        }
        private async void OnValueGenerated(string value)
        {
            Player.SetClass(Player, value);
            Player = Player.GetGear(Player, 0, value);
            string _modelPath = Player.GetModel();
            string ModelPath = System.IO.Path.Combine(Application.StartupPath, @"PlayerCharacter\Characters\First\" + _modelPath );
            Model = Image.FromFile(ModelPath);
            int ModelWidth = Model.Width / 2;
            int ModelHeight = Model.Height / 2;
            await FormatImage(ModelWidth, ModelHeight);
            

            int centerX = (this.ClientSize.Width - pb_Player.Width) / 2;
            int bottomY = this.ClientSize.Height - pb_Player.Height;

            this.pb_Player.Location = new System.Drawing.Point(centerX, bottomY);
        }
        private void btn_Setup_Click(object sender, EventArgs e)
        {
            state = true;
            this.btn_Play.Enabled = state;

            Armoury armoury = new Armoury();
            armoury.Show();
            armoury.ValueGenerated += OnValueGenerated;

        }
        private async Task BackgroundManipulation()
        {
            string backgroundPath = System.IO.Path.Combine(Application.StartupPath, @"Level\Background\Background.png");
            /*Comeback to add new array sorting through the list of backgrounds that can be selected*/
            await Task.Run(() =>
            {
                this.Invoke((Action)(() =>
                {

                    this.BackgroundImage = Image.FromFile(backgroundPath);
                    this.BackgroundImageLayout = ImageLayout.Stretch;
                }));
            });
        }
        private async Task WindowManipulation()
        {
            await Task.Run(() =>
            {
                this.Invoke((Action)(() =>
                {
                    this.AutoSize = true;
                    this.WindowState = FormWindowState.Maximized;
                }));
            });
        }
        public Image RemoveWhiteBackground(Image OriginalImage)
        {
            Bitmap bitmap = new Bitmap(OriginalImage.Width, OriginalImage.Height, PixelFormat.Format32bppArgb);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.DrawImage(OriginalImage, 0, 0);
            }
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    Color pixelColor = bitmap.GetPixel(x, y);

                    if (pixelColor.R >= 200 && pixelColor.G >= 200 && pixelColor.B >= 200)
                    {
                        bitmap.SetPixel(x, y, Color.FromArgb(0, pixelColor.R, pixelColor.G, pixelColor.B));
                    }
                }
            }
            return bitmap;
        }
        public Image ResizeImage(Image originalImage, int width, int height)
        {
            Bitmap resizedImage = new Bitmap(width, height);
            using (Graphics graphics = Graphics.FromImage(resizedImage))
            {
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                graphics.DrawImage(originalImage, 0, 0, width, height);
            }
            return resizedImage;
        }
        public async Task FormatImage(int ModelWidth, int ModelHeight)
        {
            await Task.Run(() =>
            {
                this.Invoke((Action)(() =>
                {
                    Model = ResizeImage(Model, ModelWidth, ModelHeight);
                    Model = RemoveWhiteBackground(Model);
                    this.pb_Player.Image = Model;
                    this.pb_Player.Width = Model.Width;
                    this.pb_Player.Height = Model.Height;
                }));
            });
        }
        public async Task ButtonDisplay()
        {
            await Task.Run(() => 
            {
                this.Invoke((Action)(() => 
                {
                    this.btn_Play.Visible = false;
                    this.btn_Setup.Visible = false;
                    this.btn_Settings.Visible = true;
                    this.btn_Pause.Visible = true;
                    this.lbl_Health.Visible = true;
                    this.lbl_xp.Visible = true;
                    this.pb_Health.Visible = true;
                    this.pb_Xp.Visible = true;
                    this.lbl_class.Visible = true;
                    this.lbl_class1.Visible = true;
                    this.lbl_class1.Text = Player.GetClass();
                    this.pb_Health.Value = 100;
                    this.lbl_class1.BackColor = Color.Transparent;
                    this.lbl_class1.ForeColor = Color.Gold;

                }));
            });
        }

    }
}
