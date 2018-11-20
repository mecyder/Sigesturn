using BLL;
using Entities;
using System;
using System.Windows.Forms;

namespace Requestclient
{
    public partial class Form1 : Form
    {
        private asingTurnToEmploye asingTurn = null;
        private Tbl_Turns turn = null;

        public Form1()
        {
            InitializeComponent();
            asingTurn = new asingTurnToEmploye();
            loadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            callNextTurn();
        }

        private void callNextTurn()
        {
            var result = asingTurn.createRequesClient();
            if (result)
            {
                loadData();
                if (turn != null)
                {
                    update(turn);
                }
            }
            else
            {
                MessageBox.Show("No existen más turnos para atender");
            }
        }

        public void loadData()
        {
            turn = asingTurn.getLastTurn();
            var value = turn == null ? 0 : turn.turnID;
            var nextTurn = value > 0 ? value + 1 : 0;
            var lastTurn = turn == null ? string.Empty : turn.description_Turn;
            lblCurrentTurn.Text = lastTurn.ToString();
            lblNextTurn.Text = nextTurn.ToString();
        }

        public bool update(Tbl_Turns turn)
        {
            return asingTurn.update(turn);
        }
    }
}