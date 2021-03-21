using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
  public class UserPlayer : Player
  {
    public UserPlayer(ref Board board)
    {
      mBoard = board;
    }
  }
}
