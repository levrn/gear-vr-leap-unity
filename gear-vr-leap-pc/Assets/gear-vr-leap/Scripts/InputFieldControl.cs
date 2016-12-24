using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class InputFieldControl : MonoBehaviour
{
	NetworkManager manager;
	InputField inputText;
	Text placeHolder;
	// Use this for initialization
	void Start()
	{
		GetNecessaryComponents();
		placeHolder.text = LoadLastIP();
		manager.networkAddress = placeHolder.text;
	}

	public void AsTyping()
	{
		inputText.textComponent.text = inputText.text;
		manager.networkAddress = inputText.text;
	}

	void GetNecessaryComponents()
	{
		inputText = GetComponent<InputField>();
		placeHolder = transform.GetChild(0).GetComponent<Text>();
		manager = GameObject.Find("Controller").GetComponent<NetworkManager>();
	}

	public void AfterTyping()
	{
		PlayerPrefs.SetString("IP", inputText.text);
		manager.networkAddress = inputText.text;
	}

	string LoadLastIP()
	{
		string lastIP = PlayerPrefs.GetString("IP", "IP Address: ");
		return lastIP;
	}
}
