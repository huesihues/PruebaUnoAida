using UnityEngine;
using System.Collections;

public class player_movement : MonoBehaviour 
{
	public float speed;
	public static bool caminando = true;
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (caminando) 
		{
		Debug.Log("Ahora estoy caminando");
		}

	
	}
	public void OnTriggerEnter ()
	{
		caminando = false;
	}
	public void OnTriggerExit()
	{
		caminando = true;
	}
}
