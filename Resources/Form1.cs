using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Toc_Tak_Project.Res
{
    public partial class Form1 : Form
    {
        enPlayerTurn PlayerTurn;
        stGameStatus GameStatus;




        enum enPlayerTurn
        {
            Player1,Player2
        }
        enum enWinner
        {
            Player1,Player2,Dorw
        }
        public struct stGameStatus
        {
            enWinner Winner;
            bool GameOver;
            short CountGame;

        }













 public Form1()
        {
            InitializeComponent();
        }





        void ChangeImage(Button btn)
        {
            if(btn.Tag.ToString()=="?")
            {
                
                switch(PlayerTurn) 
                {
                    case enPlayerTurn.Player1:
                        btn.Image =Res
                        lblPlayerTurn.Text = "Player2";
                        

                        break;
                
                
                 
                
                
                
                
                
                }


















            }





        }












       

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
