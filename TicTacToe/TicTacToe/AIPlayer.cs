using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
  public class AIPlayer : IPlayer
  {
    private Board mBoard;
    public Board.CellState mAssignedCellState { set; get; }
    public AIPlayer(ref Board board)
    {
      mBoard = board;
      mAssignedCellState = assignedCellState;
    }

    public void PickBoardCell(int index)
    {
      int numberOfAvalableCells = 0;
      int[] availableCells = new int[Board.NUM_OF_CELLS];

      // Find available cells (state is none)
      for(int i = 0; i < Board.NUM_OF_CELLS; i++)
      {
        if(mBoard.GetCell(i) == Board.CellState.CellState_None)
        {
          availableCells[numberOfAvalableCells] = i;
          numberOfAvalableCells++;
        }
      }
      Random rand = new Random();
      // Pick a random one from
      // 0 <= x < numberOfAvalableCells
      mBoard.SetCell(availableCells[rand.Next(0, numberOfAvalableCells)], mAssignedCellState);
    }
  }
}
