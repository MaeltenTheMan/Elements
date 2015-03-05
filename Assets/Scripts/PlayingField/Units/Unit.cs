using UnityEngine;
using System.Collections;

public abstract class Unit : MonoBehaviour {


	private string owner;
	private GameObject myObj;
	protected abstract void playSound();
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void initialize(string owner, GameObject obj)
	{
		this.owner = owner;
		this.myObj = obj;
		playSound ();
	}

	void onMouseDown()
	{
		print ("MOuse down");
		print (owner);
	}

	public GameObject getObject()
	{
		return this.myObj;
	}
}
