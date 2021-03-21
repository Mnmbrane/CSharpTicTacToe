using System;
using System.Collections.Generic;
using System.Text;

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

    public Game()
    {
      //First instantiate the board
      mBoard = new Board();

      // instantiate the user and the AI
      mUserPlayer = new UserPlayer(ref mBoard);
      mAIPlayer = new AIPlayer(ref mBoard);

      // Start with the user first
      GameState = EGameState.GameState_User_Start;
    }
    public void GameNew()
    {
      // clear out the board
      mBoard.Clear();
    }

    public void GameEnd()
    {

    }
    public Board GetBoard()
    {
      return mBoard;
    }

    public void UpdatePlayerCellStates()
    {
      // If User is starting then set the User player to X
      // set the AI player to Y
      if(GameState == EGameState.GameState_User_Start)
      {
        mUserPlayer.mAssignedCellState = Board.CellState.CellState_X;
        mAIPlayer.mAssignedCellState = Board.CellState.CellState_Y;
      }
      // else set the user player to Y
      // set the AI player to X
      else
      {
        mAIPlayer.mAssignedCellState = Board.CellState.CellState_X;
        mUserPlayer.mAssignedCellState = Board.CellState.CellState_Y;
      }
    }
  }
}
