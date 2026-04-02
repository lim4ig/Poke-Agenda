using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pokemon_agenda
{
    public partial class fmCadastroPokemon : Form
    {
        BindingList<Pokemon> listaPokemon = new BindingList<Pokemon>();
        public fmCadastroPokemon()
        {
            InitializeComponent();
            // DataGrindView é um componente que tem a função de mostrar uma tabela, onde cada linha é um item da minha

            Pokemon p1 = new Pokemon("Pikachu", "Elétrico", 5);
            Pokemon p2 = new Pokemon("Charmander", "Fogo", 9);
            Pokemon p3 = new Pokemon("Squirtle", "Água", 29);
            Pokemon p4 = new Pokemon("Bulbasaur", "Grama", 15);

            listaPokemon.Add(p1);
            listaPokemon.Add(p2);
            listaPokemon.Add(p3);
            listaPokemon.Add(p4);

            dgvListaPokemon.DataSource = listaPokemon;
        }

        // Disponivel para limpar os campos do formulário, para evitar a repetição de código.

        private void fnLimparFormularios()
        {
            txtNome.Clear();
            cbTipo.SelectedIndex = -1;
            numNivel.Value = 1;

            txtNome.Focus();
        }
        /* Objetivo da aula: aprender a criar e ultilizar objetos
         * mini game pokemon
         * 1- montar meu time com 6 pokemons
         * 2- treinar esse meu time pokemon (recebe 2 nivel por treino)
         * 3- batalhar com esse pokemon de forma aleatoria
         * sistema vai sortear 1 a 6 pokemons (somente os 151 primeiros)
         */

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nomePokemon = txtNome.Text;
            string tipoPokemon = cbTipo.Text;
            int nivelPokemon = (int)numNivel.Value;

            Pokemon poke = new Pokemon(nomePokemon, tipoPokemon, nivelPokemon);

            listaPokemon.Add(poke);

            if(nomePokemon != string.Empty && tipoPokemon != string.Empty)
            {
                MessageBox.Show($"O Pokémon {nomePokemon} do tipo {tipoPokemon} foi cadastrado com o nível {nivelPokemon}.",
                "Mensagem de Aviso");

                poke.fnDescricao();

                fnLimparFormularios();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos corretamente.", "Mensagem de Aviso");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            fnLimparFormularios();
        }

        private void btnAjuda_Click(object sender, EventArgs e)
        {

        }

        private void dgvListaPokemon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
