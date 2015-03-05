using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour {

	public static SoundManager instance;

	public AudioClip test;

	public AudioSource source;


	// Use this for initialization
	void Start () {
		instance = this;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void playSound(string name)
	{
		switch (name)
		{
		case"test": source.PlayOneShot(test, 10F);
			break;
		default:
			break;

		}
	}




}
