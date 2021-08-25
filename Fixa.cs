namespace exercicio_OPP_25_08
{
    public class Fixa : Linha
    {
        private double valor_mensalidade;
        private double franquia_mensal_min;
        private double valor_restante_franquia;
        private bool fatura_paga;


        public Fixa(string nome_titular, int numero_contratacao, int ano_contratacao, double valor_mensalidade, double franquia_mensal_min){
            this.nome_titular = nome_titular;
            this.numero_contratacao = numero_contratacao;
            this.ano_contratacao = ano_contratacao;
            this.valor_mensalidade = valor_mensalidade;
            this.franquia_mensal_min = franquia_mensal_min;
            this.valor_restante_franquia = this.franquia_mensal_min;
            this.fatura_paga = false;
        }


        public string ligar(double duracao_minutos){
            if (fatura_paga){
                if (valor_restante_franquia >= duracao_minutos) {
                    valor_restante_franquia -= duracao_minutos;
                    return "Ligação realizada com sucesso!";
                }
                return "Franquia atual insulficiente!";
            }
            return "Ligação não realizada, a fatura não está paga!";
        }

        public string pagarFatura(){
            valor_restante_franquia = franquia_mensal_min;
            fatura_paga = true;
            return "Fatura paga com sucesso!";
        }
    }
}