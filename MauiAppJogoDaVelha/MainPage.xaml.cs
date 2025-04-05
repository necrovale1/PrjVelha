namespace MauiAppJogoDaVelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "X";

        public MainPage()
        {
            InitializeComponent();
          
        }

        int placarX = 0;
        int placarO = 0;
        private async void Button_Clicked(object sender, EventArgs e)
        {
        
            Button btn = (Button)sender; // var botao =  sender as Button;
                //btn.Text = vez;
                //vez = vez == "X" ? "O" : "X";
                // ? IF e : ELSE

                btn.IsEnabled = false;
                btn.Opacity = 0.8; 

            if (vez == "X") //vez.Equals("X")
            {
                btn.Text = "X"; //btn.Text = vez;
                btn.TextColor = Color.FromHex("#7aa9f5");
                btn.BackgroundColor = Color.FromHex("#26354d");
                vez = "O";
            } else
            {
                btn.Text = "O";
                btn.TextColor = Color.FromHex("#f57a97");
                btn.BackgroundColor = Color.FromHex("#4d262f");
                vez = "X"; //btn.Text = vez;
            }



            /* Verificando se o X ganhou na 1ª linha */
            if (btn00.Text == "X" && btn01.Text == "X" && btn02.Text == "X"
            || btn03.Text == "X" && btn04.Text == "X" && btn05.Text == "X"
            || btn06.Text == "X" && btn07.Text == "X" && btn08.Text == "X"  // horizontal

            || btn00.Text == "X" && btn03.Text == "X" && btn06.Text == "X"
            || btn01.Text == "X" && btn04.Text == "X" && btn07.Text == "X"
            || btn02.Text == "X" && btn05.Text == "X" && btn08.Text == "X" // vertical

            || btn00.Text == "X" && btn04.Text == "X" && btn08.Text == "X" // diaognal
            || btn02.Text == "X" && btn04.Text == "X" && btn06.Text == "X")

            {
                placarX++;
                lblX.Text = "X : " + placarX.ToString();
                await this.DisplayAlert("Parabéns!", "O Jogador X ganhou!", "OK"); // espera o click no alert
                Zerar();

            }
            else if (btn00.Text == "O" && btn01.Text == "O" && btn02.Text == "O"
            || btn03.Text == "O" && btn04.Text == "O" && btn05.Text == "O"
            || btn06.Text == "O" && btn07.Text == "O" && btn08.Text == "O"  // horizontal

            || btn00.Text == "O" && btn03.Text == "O" && btn06.Text == "O" // vertical
            || btn01.Text == "O" && btn04.Text == "O" && btn07.Text == "O"
            || btn02.Text == "O" && btn05.Text == "O" && btn08.Text == "O"

            || btn00.Text == "O" && btn04.Text == "O" && btn08.Text == "O" // diaognal
            || btn02.Text == "O" && btn04.Text == "O" && btn06.Text == "O")

            {
                placarO++;
                lblO.Text = "O : " + placarO.ToString();
                await this.DisplayAlert("Parabéns!", "O Jogador O ganhou!", "OK");  // espera o click no alert
                Zerar();

            }
            else { 
                
            }


            void Zerar()
            {
                btn00.Text = "";
                btn01.Text = "";
                btn02.Text = "";
                btn03.Text = "";
                btn04.Text = "";
                btn05.Text = "";
                btn06.Text = "";
                btn07.Text = "";
                btn08.Text = "";

                btn00.IsEnabled = true;
                btn01.IsEnabled = true;
                btn02.IsEnabled = true;
                btn03.IsEnabled = true;
                btn04.IsEnabled = true;
                btn05.IsEnabled = true;
                btn06.IsEnabled = true;
                btn07.IsEnabled = true;
                btn08.IsEnabled = true;

               btn00.BackgroundColor = Color.FromHex("#808080");
               btn00.Opacity = 0.5;

               btn01.BackgroundColor = Color.FromHex("#808080");
               btn01.Opacity = 0.5;

               btn02.BackgroundColor = Color.FromHex("#808080");
               btn02.Opacity = 0.5;

               btn03.BackgroundColor = Color.FromHex("#808080");
               btn03.Opacity = 0.5;

               btn04.BackgroundColor = Color.FromHex("#808080");
               btn04.Opacity = 0.5;

               btn05.BackgroundColor = Color.FromHex("#808080");
               btn05.Opacity = 0.5;

               btn06.BackgroundColor = Color.FromHex("#808080");
               btn06.Opacity = 0.5;

               btn07.BackgroundColor = Color.FromHex("#808080");
               btn07.Opacity = 0.5;

               btn08.BackgroundColor = Color.FromHex("#808080");
               btn08.Opacity = 0.5;

                vez = "X";

            }
        } // Fecha método
    } // Fecha Classe
} // Fecha Namespace
