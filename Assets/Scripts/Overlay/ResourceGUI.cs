using UnityEngine;
using System.Collections;

public class ResourceGUI : MonoBehaviour {

	private int screen = Screen.width;
	private int screenY = Screen.height;

	private static int textureX= 20;
	private int textureY= 20;

	private static int amountX = 60;
	private int amountY= 20;

	private int distance = textureX+amountX;

	public Texture2D res1, res2, res3, res4, res5;
	private Texture2D[] res;

	public Texture2D nextTurn;
	
	private int[] values;
	private int[] income;

	private Player actual;

	private string phase;

	// Use this for initialization
	void Start () {
		res = new Texture2D[5];
		res [0] = res1;
		res [1] = res2;
		res [2] = res3;
		res [3] = res4;
		res [4] = res5;
		actual = PlayerHandler.getActualPlayer ();
		values = actual.getResources ();
		income = ResourceHandler.getIncome ();
		phase = "Bauphase";
	

		}

	void OnGUI()
	{
		
		if (GUI.Button (new Rect (540, 10, 40, 20), "loose")) {
		
			actual.loseResource(10,0);
		}
	
		GUI.Label (new Rect (740, 10, 100, 20), phase);

		if (GUI.Button (new Rect (screen-100, screenY-100, 100, 100), nextTurn)) {
			PlayerHandler.nextPlayer();
			actual = PlayerHandler.getActualPlayer();
			values =actual.getResources();
			phase = PlayerHandler.isActionPhase() ? "Actionphase" : "Bauphase";
		}
		
		for (int i=0; i <5; i++) {
			GUI.Label (new Rect(i*distance+20, 10,  textureX, textureY), res[i]);
			GUI.Label (new Rect(i*distance+20+textureX, 10,  amountX, amountY), values[i].ToString ());
			GUI.Label (new Rect(i*distance+10+textureX, 5+amountY, amountX,  amountY), "+"+income[i].ToString ());
			
		}
		GUI.Label (new Rect (screen - 100, 10, 100, 20), actual.getName ());
		GUI.Box (new Rect (0, 0, 500, 50), "");
		
		
		
		//if (GUI.Button (new Rect (20, 40, 80, 20), "1")) print("1");
		
		//Buttons for actions, otherwise use Gui.Label
		
		
		
		
	}


}
