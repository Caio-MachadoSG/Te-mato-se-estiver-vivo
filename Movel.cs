using System;
using System.Collections.Generic;

namespace exercicio_OPP_25_08
{
    public class Movel : Linha
    {
        private double quant_atual_saldo;
        private List<string> nova_msg = new List<string>();
        private bool possui_plano;
        private bool sms_disponivel;


        public Movel(string nome_titular, int numero_contratacao, int ano_contratacao, double quant_saldo, bool possui_plano, bool sms_disponivel){
            this.nome_titular = nome_titular;
            this.numero_contratacao = numero_contratacao;
            this.ano_contratacao = ano_contratacao;
            this.quant_atual_saldo = quant_saldo;
            this.possui_plano = possui_plano;
            this.sms_disponivel = sms_disponivel;
        }


        public string recarregar(double valor){
            quant_atual_saldo += valor;
            return "Saldo recarregado em " + valor + "R$!";
        }

        public string navegar(double mb_usado){
            if (possui_plano){
                if (quant_atual_saldo >= (mb_usado * 0.2475)){
                    quant_atual_saldo -= (mb_usado * 0.2475);
                    return "Navegação realizada com sucesso!";
                }
                return "Saldo insulficiente!";
            }
            return "Serviço Indisponível!";
        }

        public void listarMensagens() {
            Console.WriteLine("Listando Menssagens...");
            for (int x = 0; x < nova_msg.Count; x++) {
                Console.WriteLine(x + "º Mensagem:");
                Console.WriteLine(nova_msg[x]);
            }
        }

        public string enviarSms(Movel destinatario, string mensagem){
            if (this.sms_disponivel){
                if (quant_atual_saldo >= 0.10){
                    quant_atual_saldo -= 0.10;
                    destinatario.nova_msg.Add(mensagem);
                    return "Mensagem enviada com sucesso!";
                }
                return "Saldo insulficiente!";
            }
            return "Serviço Indisponivel!";
        }
    }
}