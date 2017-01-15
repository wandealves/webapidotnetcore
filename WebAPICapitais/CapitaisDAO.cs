using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace WebAPICapitais
{
    public class CapitaisDAO
    {
        private IConfiguration _configuracoes;

        public CapitaisDAO(IConfiguration config)
        {
            this._configuracoes = config;
        }

        public List<Capitais> Obter(string sigla)
        {
            using(SqlConnection conexao = new SqlConnection(this._configuracoes.GetConnectionString("base")))
            {
                return conexao.Query<Capitais>("SELECT SiglaEstado,Estado,NomeCidade,Regiao FROM dbo.Capitais WHERE SiglaEstado=@SIGLA",
                new{SIGLA=sigla}).AsList<Capitais>();
            }
        }
    }
}
