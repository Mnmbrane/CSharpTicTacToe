using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
  public class AIPlayer : Player
  {
    public AIPlayer(ref Board board)
    {
      mBoard = board;
    }

    public void PickRandomBoardCell()
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
      PickBoardCell(availableCells[rand.Next(0, numberOfAvalableCells)]);
    }
  }
}
