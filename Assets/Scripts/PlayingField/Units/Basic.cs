using UnityEngine;
using System.Collections;

public class Basic : Unit {


	public int x, y;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown()
	{
		if (PlayerHandler.isActionPhase())
		{
			UnitGUI.activate ();
		}
		else
		{
			print ("Das geht nur in der Actionphase!");
		}
	}

	protected override void playSound()
	{
		SoundManager.instance.playSound ("test");
	}

}
