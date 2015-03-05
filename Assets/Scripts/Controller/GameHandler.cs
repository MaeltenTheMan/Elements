using UnityEngine;
using System.Collections;

public class GameHandler : MonoBehaviour {

	public PlayingField field;

	public BuildingHolder buildingHolder;

	public UnitHolder unitHolder;

	private string[] playerNames = new string[]{"Malte" , "Patrick"};

	private static int actualRound;


	void Awake() {
		buildingHolder.initialize ();
		unitHolder.initialize ();
		actualRound = 0;
		PlayerHandler.initialize (playerNames);
		ResourceHandler.initialize ();
		field.initialize ();



	}

	// Use this for initialization

	public static void nextTurn()
	{
		ResourceHandler.nextTurn ();
	}

	public int getActualRound()
	{
		return actualRound;
	}
}
