using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
  public class Board
  {
    public enum CellState
    {
      CellState_None,
      CellState_X,
      CellState_Y
    }

    public const int NUM_OF_CELLS = 9;

    private CellState[] cells;

    public Board()
    {
      // Instantiate the number of cells
      cells = new CellState[NUM_OF_CELLS];
      Array.Clear(cells, 0, NUM_OF_CELLS);
    }

    public void SetCell(int index, CellState state)
    {
      cells[index] = state;
    }
    public CellState GetCell(int index)
    {
      return cells[index];
    }

    public void Clear()
    {
      Array.Clear(cells, 0, NUM_OF_CELLS);
    }
  }
}
