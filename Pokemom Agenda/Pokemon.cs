
using System.Windows.Forms;

namespace Pokemom_Agenda
{
    public class Pokemon
    {
        // nome do pokemon
        // tipo do pokemon
        // nivel do pokemon
        // vida do pokemon
        // dano do pokemon
        public string Nome { get; set; }

        public string Tipo { get; set; }

        public int Nivel { get; set; }

        public int Vida { get; set; }

        public int Dano { get; set; }


        // Criação da função de inicialização padrão do meu objeto
        public Pokemon(string nomePokemon, string tipoPokemon, int nivelPokemon)
        {
            //Nome = "Pikachu";
            //Tipo = "Eletrico";
            //Nivel = 5;
            Nome = nomePokemon;
            Tipo = tipoPokemon;
            Nivel = nivelPokemon;
            Vida = 100;
            Dano = 20;
        }
        // public posso usar na função em qualquer espaço do meu projeto
        // private posso usar a função somente nio meu arquivo original
        public void fnDescricao()
        {
            MessageBox.Show($"pokemon: {Nome}, Tipo: {Tipo}," +
                $"Nivel: {Nivel}, Vida: {Vida}, Dano: {Dano}");
        }
    }
}
