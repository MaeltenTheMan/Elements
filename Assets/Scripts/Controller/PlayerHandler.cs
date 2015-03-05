using UnityEngine;
using System.Collections;

public class PlayerHandler{

	//true if build phase, false if action-phase
	private static bool isBuildPhase;

	private static int actualPlayer, amountOfPlayer;

	private static Player[] player;

	//number of the player who started the round
	private static int number;

	// Use this for initialization


	public static void initialize(string[] playerNames)
	{
		isBuildPhase = true;
		number = 0;
		actualPlayer = 0;
		amountOfPlayer = playerNames.Length;
		player = new Player[playerNames.Length];
		for (int i=0; i<player.Length; i++) {
			player [i] = new Player(playerNames[i]);
			//player [i].initialize (playerNames [i]);
		}
	}

	public static Player getActualPlayer()
	{
		return player [actualPlayer];
	}

	public static void nextPlayer()
	{
		UnitGUI.deactivate ();
		BuildingGUI.deactivate ();
		actualPlayer=(actualPlayer+1)%amountOfPlayer;
		if (actualPlayer==number)
		{
			if (!isBuildPhase)
			{
				GameHandler.nextTurn();
				isBuildPhase = true;
				number= (number+1) %amountOfPlayer;
				actualPlayer= number;
			}
			else
			{
				isBuildPhase = false;
				actualPlayer = number;
			}
		}
	}

	public static Player[] getAllPlayer()
	{
		return player;
	}

	public static bool isActionPhase()
	{
		return !isBuildPhase;
	}

	public static int getAmountOfPlayer()
	{
		return amountOfPlayer;
	}

	public static int getActualPlayerID()
	{
		return number;
	}



}
