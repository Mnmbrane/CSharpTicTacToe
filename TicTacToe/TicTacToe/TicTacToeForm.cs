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
  public delegate void UpdateFormCallback(Board board);
  public delegate void UpdateButtonCallback(Button button, string text);
  public delegate void EnableBoardCallback(bool enable);
  public delegate void UpdateLabelCallback(int GamesWon,
                                           int GamesLost,
                                           string StatusText);
  public partial class TicTacToeForm : Form
  {
    private Game mGame;
    private Button[] btnArray;

    public TicTacToeForm(ref Game game)
    {
      InitializeComponent();

      // Init the button array
      btnArray = new Button[Board.NUM_OF_CELLS]
      {
        btnTopLeft, btnTopMid, btnTopRight,
        btnMidLeft, btnMidMid, btnMidRight,
        btnBotLeft, btnBotMid, btnBotRight
      };

      // Setup the 
      mGame = game;
      game.UpdateCallback = new UpdateFormCallback(UpdateBoard);
      game.EnableBoardCb = new EnableBoardCallback(EnableBoard);
      game.UpdateLabelsCallback = new UpdateLabelCallback(UpdateLabels);
      game.GameNew();
    }

    private void UpdateLabels(int GamesWon, int GamesLost, string StatusText)
    {
      if (lblGamesWon.InvokeRequired || lblGamesLost.InvokeRequired || lblGameStatus.InvokeRequired)
      {
        var d = new UpdateLabelCallback(UpdateLabels);
        lblGamesWon.Invoke(d, new object[] { GamesWon, GamesLost, StatusText });
      }
      else
      {
        lblGamesWon.Text = GamesWon.ToString();
        lblGamesLost.Text = GamesLost.ToString();
        lblGameStatus.Text = StatusText;
      }
    }

    private void EnableBoard(bool enable)
    {
      // Update the Form based on the board passed in
      for (int i = 0; i < btnArray.Length; i++)
      {
        if (btnArray[i].InvokeRequired)
        {
          var d = new EnableBoardCallback(EnableBoard);
          btnArray[i].Invoke(d, new object[] { enable });
        }
        else
        {
          btnArray[i].Enabled = enable;
        }
      }
    }

    // Callback function
    private void UpdateBoard(Board board)
    {

      // Update the Form based on the board passed in
      for(int i = 0; i < btnArray.Length; i++)
      {
        if(board.GetCell(i) == Board.CellState.CellState_X)
        {
          SetText(btnArray[i], "X");
        }
        else if(board.GetCell(i) == Board.CellState.CellState_Y)
        {
          SetText(btnArray[i], "Y");
        }
        else
        {
          SetText(btnArray[i], "");
        }
      }
    }

    private void SetText(Button button, string text)
    {
      if(button.InvokeRequired)
      {
        var d = new UpdateButtonCallback(SetText);
        button.Invoke(d, new object[] { button, text });
      }
      else
      {
        button.Text = text;
      }
    }
    // A button has been clicked by the user
    private void btnClick(object sender, EventArgs e)
    {
      Button button = (Button)sender;
      // Disable the button
      button.Enabled = false;

      // Find button in the array
      for(int i = 0; i < btnArray.Length; i++)
      {
        if(button == btnArray[i])
        {
          // Send the click info to the game engine
          mGame.UserClick(i);
        }
      }
    }

    private void btnNewGame_Click(object sender, EventArgs e)
    {
      mGame.GameNew();
    }
  }
}
