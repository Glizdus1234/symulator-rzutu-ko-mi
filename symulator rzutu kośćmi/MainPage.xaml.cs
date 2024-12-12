namespace symulator_rzutu_kośćmi
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }

        private void DiceRoll(object sender, EventArgs e)
        {
            int[] dice = new int[5];
            Random r = new Random();
            for (int i = 0; i < 5; i++)
            {
                dice[i] = r.Next(1, 7);
            }
            Kość0.Source = "k6_" + dice[0] + ".png";
            Kość1.Source = "k6_" + dice[1] + ".png";
            Kość2.Source = "k6_" + dice[2] + ".png";
            Kość3.Source = "k6_" + dice[3] + ".png";
            Kość4.Source = "k6_" + dice[4] + ".png";
        }

        private void ResetGry(object sender, EventArgs e)
        {
            Kość0.Source = "k6_0.png";
            Kość1.Source = "k6_0.png";
            Kość2.Source = "k6_0.png";
            Kość3.Source = "k6_0.png";
            Kość4.Source = "k6_0.png";
        }
    }

}
