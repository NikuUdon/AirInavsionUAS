using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;

public class SelectOnInput : MonoBehaviour {

	public EventSystem EventSystem;
	public GameObject selectedObject;

	private bool buttonSelected;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetAxisRaw ("Vertical") != 0 && buttonSelected == false){
			EventSystem.SetSelectedGameObject (selectedObject);
			buttonSelected = true;
	}
}
	private void onDisable ()
	{
		buttonSelected = false;
	}
}
