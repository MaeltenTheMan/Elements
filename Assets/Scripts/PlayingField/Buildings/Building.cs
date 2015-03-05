using UnityEngine;
using System.Collections;

public class Building : MonoBehaviour {


	private Hexagon field;
	private GameObject building;
	private string owner;
	private string type;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void initialize(string owner, Hexagon field, string type, GameObject building)
	{
		this.owner = owner;
		this.field = field;
		this.building = building;
		building.transform.position = field.getObject().transform.position;
		field.build (this);
		this.type = type;

	}

	public string getOwner()
	{
		return owner;
	}

	void OnMouseDown()
	{
		if (owner.Equals(PlayerHandler.getActualPlayer().getName()))
		{

			if (!PlayerHandler.isActionPhase())
			{
				BuildingGUI.activate(this);
			}
			else {
				print("Nur in der Bauphase verfügbar!");
			}
		}
		else
		{
			print ("You dont own this building");
		}
	}

	public Hexagon getField()
	{
		return field;
	}

	public string getType()
	{
		return type;
	}

}
