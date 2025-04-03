namespace MauiAppJogoDaVelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "X";

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            
            Button btn = (Button)sender; // var botao =  sender as Button;

       
            //btn.Text = vez;
            //vez = vez == "X" ? "O" : "X";
            // ? IF e : ELSE

            btn.IsEnabled = false;

            if (vez == "X") //vez.Equals("X")
            {
                btn.Text = "X"; //btn.Text = vez;
                vez = "O";
            } else
                {
                btn.Text = "O";
                vez = "X"; //btn.Text = vez;
            }

            /* Verificando se o X ganhou na 1ª linha */
            if(btn00.Text == "X" && btn01.Text == "X" && btn02.Text == "X" || btn03.Text == "X" && btn04.Text == "X" && btn05.Text == "X" || btn06.Text == "X" && btn07.Text == "X" && btn08.Text == "X")
            { 
                DisplayAlert("Parabéns!", "o X ganhou!", "OK");
                Zerar();
                
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
            }

        } // Fecha método

   

    } // Fecha Classe
} // Fecha Namespace
