using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
  public class UserPlayer : IPlayer
  {
    private Board mBoard;
    public Board.CellState mAssignedCellState { set; get; }
    public UserPlayer(ref Board board)
    {
      mBoard = board;
    }

    public void PickBoardCell(int index)
    {
      mBoard.SetCell(index, mAssignedCellState);
    }
  }
}
