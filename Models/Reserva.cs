namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // IMPLEMENTADO

            if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                 // IMPLEMENTADO
                throw new Exception (" Ocorreu um erro! O número de hospedes é maior que a capacidade da suíte. ");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        { 
            // IMPLEMENTADO
            int qtdHospedes = Hospedes.Count();
            return qtdHospedes;
        }

        public decimal CalcularValorDiaria()
        {
             // IMPLEMENTADO
            decimal valor = DiasReservados * Suite.ValorDiaria;
           

             // IMPLEMENTADO
            if (DiasReservados >= 10)
            {
                valor -= valor * 0.1m; 
            }

            return valor;
        }
    }
}