using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class NetworkControl : MonoBehaviour
{
	public GameObject startServer;
	public GameObject createRoom;
	public GameObject ipText;
	NetworkManager manager;
	// Use this for initialization
	void Start()
	{
		manager = GetComponent<NetworkManager>();
		createRoom.SetActive(false);
		ipText.SetActive(false);
	}

	// Update is called once per frame
	void Update()
	{
	}

	public void StartServer()
	{
		startServer.SetActive(false);
		createRoom.SetActive(true);
		ipText.SetActive(true);
	}


	public void CreateRoom()
	{
		if (!NetworkClient.active && !NetworkServer.active && manager.matchMaker == null)
		{
			manager.StartServer();
		}
	}

}
