using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using UnityEngine.UI;

public class InputFieldControl : MonoBehaviour {
	NetworkManager manager;
	InputField inputText;
	// Use this for initialization
	void Start () {
		inputText = GetComponent<InputField>();
		manager = GameObject.Find("Controller").GetComponent<NetworkManager>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void AsTyping()
	{
		inputText.textComponent.text = inputText.text;
		manager.networkAddress = inputText.text;
	}

	public void AfterTyping()
	{
		manager.networkAddress = inputText.text;
	}
}
