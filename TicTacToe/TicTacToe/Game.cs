using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TicTacToe
{
  public class Game
  {
    // Game state
    public enum EGameState
    {
      GameState_User_Start,
      GameState_AI_Start
    }
    private EGameState mGameState;
    public EGameState GameState 
    { 
      set 
      {
        mGameState = value;
        UpdatePlayerCellStates();
      }
      get { return mGameState; } 
    }

    public Board mBoard;
    private UserPlayer mUserPlayer;
    private AIPlayer mAIPlayer;
    private int mGamesWon;
    private int mGamesLost;
    private static AutoResetEvent AutoEvent = new AutoResetEvent(false);

    public UpdateFormCallback UpdateCallback { set; get; }
    public EnableBoardCallback EnableBoardCb { set; get; }

    public UpdateLabelCallback UpdateLabelsCallback { set; get; }

    public Game()
    {
      //First instantiate the board
      mBoard = new Board();

      // instantiate the user and the AI
      mUserPlayer = new UserPlayer(ref mBoard);
      mAIPlayer = new AIPlayer(ref mBoard);

      // Start with the user first
      GameState = EGameState.GameState_User_Start;

      mGamesWon = 0;
      mGamesLost = 0;

      // Create a new thread to run the game
      Thread GameThread = new Thread(new ThreadStart(GameRun));
      GameThread.Start();
    }
    public void GameNew()
    {
      // clear out the board
      mBoard.Clear();

      if (mGameState == EGameState.GameState_AI_Start)
      {
        // Randomly pick a board cell
        mAIPlayer.PickRandomBoardCell();
      }
      // Disable the buttons in the forms
      EnableBoardCb(true);

      UpdateCallback(mBoard);
    }

    public void GameEnd(Board.CellState cellState)
    {
      // Disable the buttons in the forms
      EnableBoardCb(false);

      // check if player won
      if (mUserPlayer.AssignedCellState == cellState)
      {
        mGamesWon++;
      }
      else if(mAIPlayer.AssignedCellState == cellState)
      {
        mGamesLost++;
      }
      else
      {
        /* Nothing happens */
      }

    }

    public bool CheckGameEnd(ref Board.CellState inOutCellState)
    {
      bool lGameHasEnded = false;

      // Check horizontal
      for(int i = 0; i < Board.NUM_OF_CELLS; i+=3)
      {
        if(mBoard.GetCell(i) == mBoard.GetCell(i+1) &&
           mBoard.GetCell(i) == mBoard.GetCell(i+2) &&
           mBoard.GetCell(i) != Board.CellState.CellState_None)
        {
          lGameHasEnded = true;
          inOutCellState = mBoard.GetCell(i);
        }
      }

      // Check vertical
      for (int i = 0; i < 3; i++)
      {
        if (mBoard.GetCell(i) == mBoard.GetCell(i + 3) &&
            mBoard.GetCell(i) == mBoard.GetCell(i + 6) &&
           mBoard.GetCell(i) != Board.CellState.CellState_None)
        {
          lGameHasEnded = true;
          inOutCellState = mBoard.GetCell(i);
        }
      }

      // check diagonal
      // Top left to bottom right
      if(mBoard.GetCell(0) == mBoard.GetCell(4) &&
         mBoard.GetCell(0) == mBoard.GetCell(8) &&
         mBoard.GetCell(0) != Board.CellState.CellState_None)
      {
        lGameHasEnded = true;
        inOutCellState = mBoard.GetCell(0);
      }

      // Top right to bottom left
      if (mBoard.GetCell(2) == mBoard.GetCell(4) &&
          mBoard.GetCell(2) == mBoard.GetCell(6) &&
          mBoard.GetCell(2) != Board.CellState.CellState_None)
      {
        lGameHasEnded = true;
        inOutCellState = mBoard.GetCell(2);
      }

      // Check if everything has been filled
      bool filled = true;
      for(int i = 0; i < Board.NUM_OF_CELLS; i++)
      {
        if (mBoard.GetCell(i) == Board.CellState.CellState_None)
        {
          filled = false;
        }
      }

      if (filled == true)
      {
        lGameHasEnded = true;
      }

      return lGameHasEnded;
    }

    public void GameRun()
    {
      while(true)
      {
        // Wait to be signalled
        AutoEvent.WaitOne();

        Board.CellState cellStateInOut = Board.CellState.CellState_None;
        // Check to see if game has ended
        if (CheckGameEnd(ref cellStateInOut) == true)
        {
          GameEnd(cellStateInOut);
        }
        else
        {
          // Let AI Player pick a spot
          mAIPlayer.PickRandomBoardCell();

          // Check to see if game has ended
          if (CheckGameEnd(ref cellStateInOut) == true)
          {
            GameEnd(cellStateInOut);
          }
        }


        // Update board
        UpdateCallback(mBoard);

        UpdateLabelsCallback(mGamesWon, mGamesLost, "");
      }
    }

    public void UserClick(int index)
    {
      mUserPlayer.PickBoardCell(index);

      // Signal that user has picked a spot
      AutoEvent.Set();
    }

    public void UpdatePlayerCellStates()
    {
      // If User is starting then set the User player to X
      // set the AI player to Y
      if(GameState == EGameState.GameState_User_Start)
      {
        mUserPlayer.AssignedCellState = Board.CellState.CellState_X;
        mAIPlayer.AssignedCellState = Board.CellState.CellState_Y;
      }
      // else set the user player to Y
      // set the AI player to X
      else
      {
        mAIPlayer.AssignedCellState = Board.CellState.CellState_X;
        mUserPlayer.AssignedCellState = Board.CellState.CellState_Y;
      }
    }
  }
}
