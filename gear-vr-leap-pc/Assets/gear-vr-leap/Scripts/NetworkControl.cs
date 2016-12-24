using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class NetworkControl : MonoBehaviour
{
	public GameObject startClient;
	public GameObject joinRoom;
	public GameObject inputField;
	NetworkManager manager;
	// Use this for initialization
	void Start()
	{
		manager = GetComponent<NetworkManager>();
		joinRoom.SetActive(false);
		inputField.SetActive(false);
	}

	// Update is called once per frame
	void Update()
	{

	}


	public void StartClient()
	{
		startClient.SetActive(false);
		joinRoom.SetActive(true);
		inputField.SetActive(true);
	}


	public void JoinRoom()
	{
		if (!NetworkClient.active && !NetworkServer.active && manager.matchMaker == null)
		{
			manager.StartClient();
		}
	}
}
