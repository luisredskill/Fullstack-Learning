namespace Ex01.Classes
{
    public class Pessoa
    {
        public string? nome { get; set; }
        public string? Nasc { get; set; }

        public float lerData(string? dataRecebida)
        {
            DateTime dataConvertida;
            if (DateTime.TryParse(dataRecebida, out dataConvertida))
            {
                DateTime hoje = DateTime.Today;
                double anos = (hoje - dataConvertida).TotalDays/365;

                if (anos >= 18)
                {
                    return 1;
                } else if (anos >= 16)
                {
                    return 2;
                } else{
                    return 3;
                }
            } return 4;
        } 
    }
}

