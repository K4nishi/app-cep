using System.Net;
using Newtonsoft.Json;

namespace App_kunishi
{
    public class CepResponse2
    {//retornado pela AP
        public string logradouro { get; set; }
        public string bairro { get; set; }
        
    }
    public partial class app : Form
    {

        public app()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void input_text_TextChanged(object sender, EventArgs e)
        {
            //caixa de texto
            
        }

       

        private void botao_Click(object sender, EventArgs e)
        {
            if (input_text.Text.Length == 8)
            {
                string cep = input_text.Text;

                //Chamada o cacete da api
                string url = "https://viacep.com.br/ws/" + cep + "/json/";

                //Consome a misera
                var client = new WebClient();
                var response = client.DownloadString(url);

                var result = JsonConvert.DeserializeObject<CepResponse2>(response);

                //Exibe no console
                //Console.WriteLine("Logradouro: " + result.logradouro);
                //Console.WriteLine("Bairro: " + result.bairro);

                //Preenche campos com resultado
                //Console.WriteLine(result.logradouro);
                //Console.WriteLine(result.bairro);

                //Exibe em MessageBox
                string mensagem = "";
                mensagem += "Logradouro: " + result.logradouro + Environment.NewLine;
                mensagem += "Bairro: " + result.bairro;

                MessageBox.Show(mensagem, "Resultado da Consulta");
            }
        }

        private void App_Load(object sender, EventArgs e)
        {

        }

    }
}