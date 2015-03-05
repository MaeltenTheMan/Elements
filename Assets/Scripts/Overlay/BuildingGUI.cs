using UnityEngine;
using System.Collections;

public class BuildingGUI : MonoBehaviour {

	private static int width;

	private static Building building;

	private static string type;

	private static bool isActive, isScrolling;
	// Use this for initialization
	
	private static int x;
	void Start () {
		isActive = false;
		width = Screen.width;
	}
	
	public static void activate(Building arg)
	{
		type = arg.getType ();
		building = arg;
		isActive = true; 
		isScrolling = true;
		x = 0;
	}
	
	public static void deactivate()
	{
		isActive = false;
		isScrolling = false;
	}
	
	void OnGUI()
	{
		if (isActive)
		{
			if (isScrolling)
			{
				x++;
				if (x==150) isScrolling = false;
			}
			GUI.Box (new Rect (width-x, 50, x, 500), "");
			switch (type)
			{
			case "test":
				displayMain();
				break;
			}
		}
	}


	private void displayMain()
	{

		if (GUI.Button (new Rect (width - x + 5, 100, x - 10, 20), "Einheiten bauen"))
		{
			int[] costs = UnitHolder.getCosts(0);
			if (PlayerHandler.getActualPlayer().hasPlayerEnoughRessources(costs) && 
			    building.getField().hasUnitSlot())
			{
				GameObject myObject = UnitHolder.getUnitByName("test");
				Basic unit = myObject.AddComponent<Basic>();
				print(unit);
				myObject.renderer.material = MaterialsUnit.getMaterialByName("red");
				unit.getObject();
				unit.initialize(PlayerHandler.getActualPlayer().getName(), myObject);
				building.getField().addUnit(unit);



			
				PlayerHandler.getActualPlayer().loseResource(2,0);
			}
		}

	}

	private void displayForge()
	{
		GUI.Label (new Rect (width-x+5, 100, x-10, 20), "Werkzeuge bauen");
		GUI.Label (new Rect (width-x+5, 200, x-10, 20), "Rohstoffe umtauschen"); 


	}
}
	

