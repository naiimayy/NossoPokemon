using Model;
using Repository.DataBase;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class PokemonRepository : IPokemonRepository
    {
        public bool Alterar(Pokemon pokemon)
        {
            throw new NotImplementedException();
        }

        public bool Apagar(int id)
        {
            throw new NotImplementedException();
        }

        public int Inserir(Pokemon pokemon)
        {
            SqlCommand comando = Conexao.AbrirConexao();
            comando.CommandText = "INSERT INTO pokemons (id_categoria, nome) OUTPUT INSERTED.ID VALUES(@ID_CATEGORIA, @NOME)";
            comando.Parameters.AddWithValue("@ID_CATEGORIA", pokemon.IdCategoria);
            comando.Parameters.AddWithValue("@NOME", pokemon.Nome);
            int id = Convert.ToInt32(comando.ExecuteScalar());
            comando.Connection.Close();
            return id;
        }

        public Pokemon ObterPeloId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Pokemon> ObterTodos(int id)
        {
            throw new NotImplementedException();
        }
    }
}
