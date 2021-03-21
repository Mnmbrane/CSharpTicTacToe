using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
  public partial class TicTacToeForm : Form
  {
    private Game mGame;
    public TicTacToeForm(ref Game game)
    {
      InitializeComponent();

      mGame = game;

    }
    public void UpdateForm()
    {

    }
    // A button has been clicked by the user
    private void btnClick(object sender, EventArgs e)
    {
      Button button = (Button)sender;
      // Disable the button
      button.Enabled = false;

      // send the button information to the game
      if(button == btnTopLeft)
      {

      }
    }
  }
}
