using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
  public abstract class Player
  {
    protected Board mBoard;
    public Board.CellState AssignedCellState { set; get; }
    public void PickBoardCell(int index)
    {
      mBoard.SetCell(index, AssignedCellState);
    }
  }
}
