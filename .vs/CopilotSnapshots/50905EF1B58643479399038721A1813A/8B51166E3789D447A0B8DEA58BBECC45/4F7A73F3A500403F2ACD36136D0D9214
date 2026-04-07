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
    public partial class FmCadastroPokemon : Form
    {
        public FmCadastroPokemon()
        {
            InitializeComponent();
        }
        // criação da função (limpar) com retorno nome.
        // disponibilidade retorno nome ( funções) a funão serve 
        // para reaproveitar códigos, definindo uma função eu posso reutilizar o código
        private void  fnLimpar()
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
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nomePokemon = txtNome.Text; // textBox
            string tipoPokemon = cbTipo.Text; // comboBox
            int  nivelPokemon = (int) numNivel.Value; // numericUpDown

            Pokemon poke = new Pokemon(nomePokemon, tipoPokemon, nivelPokemon);

            poke.fnDescricao();

            // MessageBox.Show($"o Pokémon {nomePokemon} do tipo {tipoPokemon} " +
            // $"foi cadastrado com o nivel {nivelPokemon}");
            fnLimpar();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            fnLimpar();

        }
    }
}
