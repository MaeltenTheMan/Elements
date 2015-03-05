using UnityEngine;
using System.Collections;

public class Player{


	private int amountOfResources = 5;
	private int defaultValue = 10;

	private int[] resources;
	private string name;

	public Player(string name)
	{
		this.name = name;
		resources = new int[amountOfResources];
		
		for (int i=0; i<resources.Length; i++)
		{
			resources[i] = defaultValue;
		}
	}

	public int[] getResources()
	{
		return resources;
	}

	public void addResource(int amount, int id)
	{
		resources[id]+=amount;

	}

	public bool loseResource(int amount, int id)
	{
		if (resources[id]<amount) return false;
		else
		{
			resources[id]-=amount;
			return true;
		}
	}

	public string getName()
	{
		return name;
	}

	public bool hasPlayerEnoughRessources(int[] resources)
	{
		for (int i=0; i<resources.Length; i++)
		{
			if (this.resources[i]<resources[i])
			{
				return false;
			}
		}
		return true;
	}
}
