namespace BakuLondon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ShowImageAndTime(string cityName)
        {
            if (cityName == "baku")
                this.BackgroundImage = Properties.Resources.baku;
            else if (cityName == "london")
                this.BackgroundImage = Properties.Resources.london;

            DateTime currentTime;
            if (cityName == "baku")
                currentTime = TimeZoneInfo.ConvertTime(DateTime.UtcNow, TimeZoneInfo.FindSystemTimeZoneById("Azerbaijan Standard Time"));
            else if (cityName == "london")
                currentTime = TimeZoneInfo.ConvertTime(DateTime.UtcNow, TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time"));
            else
                return;

            MessageBox.Show($"Hal-hazırda {cityName} saatı: {currentTime.ToString("HH:mm:ss")}");
        }

        private void bakuBtn_Click(object sender, EventArgs e)
        {
            ShowImageAndTime("baku");
        }

        private void londonBtn_Click(object sender, EventArgs e)
        {
            ShowImageAndTime("london");
        }
    }
}