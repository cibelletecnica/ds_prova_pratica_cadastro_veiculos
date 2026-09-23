using MySql.Data.MySqlClient;
using System;

namespace GerenciadorVeiculos
{
    public class VeiculoDAO
    {
        public void Inserir(Veiculo veiculo)
        {
            string tipo = "";
            decimal parametro = 0;

            // Identifica se o objeto é Carro ou Moto
            if (veiculo is Carro carro)
            {
                tipo = "Carro";
                parametro = carro.QuantidadePortas;
            }
            else if (veiculo is Moto moto)
            {
                tipo = "Moto";
                parametro = moto.Cilindradas;
            }

            // Converte os decimais para formato SQL com ponto
            string precoBaseSql = veiculo.PrecoBase.ToString().Replace(",", ".");
            string valorSeguroSql = veiculo.CalcularValorSeguro().ToString().Replace(",", ".");
            string parametroSql = parametro.ToString().Replace(",", ".");

            string sql = $"INSERT INTO veiculos (modelo, tipo, preco_base, valor_seguro, parametro_especifico) " +
                         $"VALUES ('{veiculo.Modelo}', '{tipo}', {precoBaseSql}, {valorSeguroSql}, {parametroSql})";

            using (MySqlConnection conexao = ConexaoBD.ObterConexao())
            {
                using (MySqlCommand comando = new MySqlCommand(sql, conexao))
                {
                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}