using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pokemon_agenda
{
    public class Pokemon
    {
        // nome do pokemon
        // tipo do pokemon
        // nivel do pokemon
        // vida do pokemon
        // dano do pokemon

        //get set
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public int Nivel { get; set; }
        public int Vida { get; set; }  
        public int Dano { get; set; }


        // Criação da função de inicialização padrão do meu objeto.


        /// <summary>
        /// Inicializa o construtor da minha classe padrão de <c>Pokémon</c>.
        /// <paramref name="nomePokemon"/>, <paramref name="tipoPokemon"/>, <paramref name="nivelPokemon"/>
        /// <list type="bullet">
        /// <item>nomePokemon: Utilizado para saber o nome do Pokémon</item>
        /// <item>tipoPokemon: Utilizado para saber o tipo do Pokémon</item>
        /// <item>nivelPokemon: Utilizado para saber o nível do Pokémon</item>
        /// </list>
        /// </summary>
        /// <returns>
        /// A função <see cref="fnDescricao"/> não retorna nada.
        /// </returns>
        /// <param name="nomePokemon">Vai ser o nome que o Pokémon vai ser chamado.</param>
        /// <param name="tipoPokemon">Define o tipo do elemento que o Pokémon possui afinidade.</param>
        /// <param name="nivelPokemon">Define o nível atual do Pokémon.</param>
        public Pokemon(string nomePokemon, string tipoPokemon, int nivelPokemon)
        {
            Nome = nomePokemon;
            Tipo = tipoPokemon;
            Nivel = nivelPokemon;
            Vida = 100 + (nivelPokemon * 2);
            Dano = 20 + nivelPokemon;
        }

        /// <summary>
        /// Mostra uma mensagem com todas as informações sobre o <c>Pokémon</c> escolhido.
        /// <list type="bullet">
        /// <item>Nome do Pokémon</item>
        /// <item>Tipo do Pokémon</item>
        /// <item>Nível do Pokémon</item>
        /// <item>Vida do Pokémon</item>
        /// <item>Ataque do Pokémon</item>
        /// </list>
        /// </summary>
        /// <returns>Essa função não retorna nada.</returns>
        public void fnDescricao()
        {
            MessageBox.Show($"Pokémon: {Nome}\nTipo: {Tipo}\nNível: {Nivel}\nVida: {Vida}\n" +
                $"Ataque: {Dano}", "Informações");
        }
    }
}
