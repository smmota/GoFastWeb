namespace GoFast.UI.Shared.DTO.ViewModels
{
    public class CarroViewModel
    {
        public string Placa { get; set; }

        public string Modelo { get; set; }

        public DateTime AnoFabricacao { get; set; }

        public DocumentoCarroViewModel DocumentoCarro { get; set; }

        public CarroViewModel(string placa, string modelo, DateTime anoFabricacao, DocumentoCarroViewModel documentoCarro)
        {
            Placa = placa;
            Modelo = modelo;
            AnoFabricacao = anoFabricacao;
            DocumentoCarro = documentoCarro;
        }

        public CarroViewModel()
        {
        }
    }
}
