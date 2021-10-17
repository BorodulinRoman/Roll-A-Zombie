using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	
	public GameObject selectedZombie;
	public List<GameObject> zombies;
	public Vector3 selectedSize;
	public Vector3 defaultSize;

	// Use this for initialization
	void Start () {
		yossi(selectedZombie);
	}
	
	// Update is called once per frame
	void Update () {

	}

	
	void yossi(GameObject newZ)
    {
		newZ.transform.localScale = selectedSize;
	}


}
