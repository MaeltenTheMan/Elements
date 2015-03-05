using UnityEngine;
using System.Collections;

public class Hexagon : MonoBehaviour{

	


	private Unit unit;
	private Unit unit2;
	private string type;
	private Building building;
	private int x,y;
	private GameObject myObj;



	public string getType()
	{
		return type;
	}

	public void initialize (string type, int x, int y, GameObject obj)
	{
		this.type = type;
		this.x = x;
		this.y = y;
		myObj = obj;
		myObj.renderer.material = Materials.getMaterial (type);
	}

	public void addUnit(Unit unit)
	{
		if (this.unit == null) 
		{
			this.unit = unit;
			GameObject myObject = unit.getObject();
			myObject.transform.position = new Vector3(myObj.transform.position.x-0.3f, myObj.transform.position.y, myObj.transform.position.z-1);
			}
		else 
		{
			this.unit2=unit;
			GameObject myObject = unit.getObject();
			myObject.transform.position = new Vector3(myObj.transform.position.x+0.3f, myObj.transform.position.y, myObj.transform.position.z-1);
		}



	}

	public void build(Building building)
	{
		this.building = building;
	}

	public bool hasBuilding()
	{
		if (building == null) return false;
		else return true;
	}

	public GameObject getObject()
	{
		return myObj;
	}
	
	public int getY()
	{
		return y;
	}
	
	public int getX()
	{
		return x;
	}

	public Building getBuilding()
	{
		return building;
	}

	public Unit getUnit()
	{
		return unit;
	}

	public bool hasUnitSlot()
	{
		return (unit == null | unit2 == null);
	}

}
