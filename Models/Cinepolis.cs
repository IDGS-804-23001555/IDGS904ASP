namespace IDGS904ASP.Models
{
    public class Cinepolis
    {
        public string Nombre { get; set; }
        public int Compradores { get; set; }
        public int Boletos { get; set; }
        public bool Cineco { get; set; }
        public double Total { get; set; }

        public void Calcular()
        {
            if (Compradores <= 0 || Boletos <= 0)
            {
                Total = 0;
                return;
            }

            int maxBoletos = Compradores * 7;

            if (Boletos > maxBoletos)
            {
                Total = -1;
                return;
            }

            double subtotal = Boletos * 12;

            if (Boletos > 5)
            {
                subtotal -= subtotal * 0.15;
            }
            else if (Boletos >= 3)
            {
                subtotal -= subtotal * 0.10;
            }

            if (Cineco)
            {
                subtotal -= subtotal * 0.10;
            }

            Total = subtotal;
        }
    }
}