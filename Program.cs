using System;
using System.Collections.Generic;

namespace exercicio_OPP_25_08
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movel> linhas_moveis = new List<Movel>();

            Movel linha_movel_caio = new Movel("caio", 1254, 2012, 200, true, true);
            linhas_moveis.Add(linha_movel_caio);
            Movel linha_movel_roberto = new Movel("roberto", 1234, 2013, 7, false, false);
            linhas_moveis.Add(linha_movel_roberto);

            Fixa linha_fixa_jose = new Fixa("jose", 1597, 2005, 50, 500);
            Fixa linha_fixa_maria = new Fixa("maria", 2556, 2017, 15.2, 50);


            // Métodos Navegar e Enviar SMS // Normais
            linha_movel_caio.navegar(50);
            linha_movel_caio.enviarSms(linhas_moveis[1], "Olá Roberto!");
            linha_movel_roberto.listarMensagens();

            // Métodos Navegar e Enviar SMS // Possíveis Falhas
            linha_movel_roberto.navegar(200);
            linha_movel_roberto.enviarSms(linhas_moveis[0], "Olá, caio");
            linha_movel_caio.navegar(2000);

            // Método recarregar
            linha_movel_caio.recarregar(4000);
            linha_movel_caio.navegar(2000);


            // Métodos 
        }
    }
}
