using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemom_Agenda
{
    /// <summary>
    /// Formulário responsável pelo cadastro de Pokémons na aplicação Pokemom Agenda.
    /// </summary>

    public partial class FmCadastroPokemon : Form
    {
        BindingList<Pokemon> listaPokemon = new BindingList<Pokemon>();

        /// <summary>
        /// Inicializa uma nova instância do formulário de cadastro de Pokémon.
        /// </summary>
        public FmCadastroPokemon()
        {   
                InitializeComponent();

                // DataGridView Visualizador organizado de dados

                Pokemon p1 = new Pokemon("Pikachu", "Elétrico", 5);
                Pokemon p2 = new Pokemon("Charmander", "Fogo", 9);
                Pokemon p3 = new Pokemon("Bulbasaur", "Grama", 15);
                Pokemon p4 = new Pokemon("Squirtle", "Água", 29);

                listaPokemon.Add(p1);
                listaPokemon.Add(p2);
                listaPokemon.Add(p3);
                listaPokemon.Add(p4);

                dgvListaPokemon.DataSource = listaPokemon;
            
        }
       
        // criação da função (limpar) com retorno nome.
        // disponibilidade retorno nome ( funções) a funão serve 
        // para reaproveitar códigos, definindo uma função eu posso reutilizar o código
        /// <summary>
        /// Limpa os campos do formulário, redefinindo para os valores padrão.
        /// </summary>
        private void fnLimpar()
        {
            txtNome.Clear();
            cbTipo.SelectedIndex = 1;
            numNivel.Value = 1;
            txtNome.Focus();
        }
        /* objetivo da aula: aprnder a criar e utilizar objetos
         * mini game pokemon
         * 1- montar meu time pokemon (6 POKEMON) -> Listas
         * 2- treinar esse meu time pokemon (a cada treinamento ele recebe 2 nível)
         * 3- batalhar com esse pokemon de forma randoica
         * sistema vai sortear 1 a 6 pokemon (somente os 151 primeiros)
         */
        /// <summary>
        /// Evento acionado ao clicar no botão Salvar. Realiza o cadastro do Pokémon com os dados informados.
        /// </summary>
        /// <param name="sender">Objeto que disparou o evento.</param>
        /// <param name="e">Argumentos do evento.</param>
        public void btnSalvar_Click(object sender, EventArgs e)
        {
            string nomePokemon = txtNome.Text; // textBox
            string tipoPokemon = cbTipo.Text; // comboBox
            int nivelPokemon = (int)numNivel.Value; // numericUpDown

            Pokemon poke = new Pokemon(nomePokemon, tipoPokemon, nivelPokemon);
            listaPokemon.Add(poke); // Adiciona o novo Pokémon à lista

            poke.fnDescricao();

            fnLimpar();
        }

        /// <summary>
        /// Evento acionado ao clicar no botão Limpar. Limpa os campos do formulário.
        /// </summary>
        /// <param name="sender">Objeto que disparou o evento.</param>
        /// <param name="e">Argumentos do evento.</param>
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            fnLimpar();
        }
    }
}
