using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class NetworkControl : MonoBehaviour
{
	public GameObject startServer;
	public GameObject startClient;
	public GameObject createRoom;
	public GameObject joinRoom;
	public GameObject ipText;
	public GameObject inputField;
	NetworkManager manager;
	// Use this for initialization
	void Start()
	{
		manager = GetComponent<NetworkManager>();
		createRoom.SetActive(false);
		joinRoom.SetActive(false);
		ipText.SetActive(false);
		inputField.SetActive(false);
	}

	// Update is called once per frame
	void Update()
	{

	}

	public void StartServer()
	{
		startServer.SetActive(false);
		startClient.SetActive(false);
		createRoom.SetActive(true);
		ipText.SetActive(true);
	}

	public void StartClient()
	{
		startServer.SetActive(false);
		startClient.SetActive(false);
		joinRoom.SetActive(true);
		inputField.SetActive(true);
	}

	public void CreateRoom()
	{
		if (!NetworkClient.active && !NetworkServer.active && manager.matchMaker == null)
		{
			manager.StartServer();
		}
	}

	public void JoinRoom()
	{
		if (!NetworkClient.active && !NetworkServer.active && manager.matchMaker == null)
		{
			manager.StartClient();
		}
	}
}
