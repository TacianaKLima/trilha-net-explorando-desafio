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
            
            // *IMPLEMENTADO*
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
               //*IMPLEMENTADO*
                Console . WriteLine ( " Número de hóspedes é maior que a capacidade " );
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            
            // *IMPLEMENTADO*
            int  numeroH  =  Hospedes . Count;
                
            return numeroH;
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diÃ¡ria
            // CÃ¡lculo: DiasReservados X Suite.ValorDiaria
            // *IMPLEMENTE AQUI*
            decimal valor = DiasReservados  * ( Suite . ValorDiaria );

        
            // *IMPLEMENTADO*
            if (DiasReservados  >=  10)
            {
                valor = 0;
            }

            return valor;
        }
    }
}