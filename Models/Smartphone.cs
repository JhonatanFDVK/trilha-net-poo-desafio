namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private String _modelo;
        private String _IMEI;
        private int _memoria;
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama

        public Smartphone(string numero, String modelo, String IMEI, int memoria)
        {
            Numero = numero;
            _modelo = modelo;
            _IMEI = IMEI;
            _memoria = memoria;
            // TODO: Passar os parâmetros do construtor para as propriedades
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}