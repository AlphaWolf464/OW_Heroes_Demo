using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hero_Menu : MonoBehaviour
{
	Camera MainCamera;
	Camera HestiaCamera;
    // Start is called before the first frame update
    void Start()
    {
	MainCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
	HestiaCamera = GameObject.FindGameObjectWithTag("Hestia_Camera").GetComponent<Camera>();
		if (!(SceneManager.GetActiveScene().name == "Menu"))
		{
			SceneManager.LoadScene("Menu");
		}
		HestiaCamera.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	public void ChooseHestia()
	{
		SceneManager.LoadScene("Game");
		GameObject.FindGameObjectWithTag("Game_Lower_Floor").GetComponent<CharacterInfo>().CurrentCharacter = "Hestia";
		GameObject.FindGameObjectWithTag("Hestia").transform.position = new Vector3((float)-3.5, (float)2.5, (float)-3.5);
	}
}
