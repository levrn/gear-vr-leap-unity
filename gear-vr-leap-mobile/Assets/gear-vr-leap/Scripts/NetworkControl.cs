using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class NetworkControl : MonoBehaviour
{
	public GameObject startServer;
	public GameObject createRoom;
	public GameObject ipText;
	NetworkManager manager;
	NetworkDiscovery discovery;
	// Use this for initialization
	void Start()
	{
		manager = GetComponent<NetworkManager>();
		discovery = GetComponent<NetworkDiscovery>();
		discovery.Initialize();
		createRoom.SetActive(false);
		ipText.SetActive(false);
	}

	// Update is called once per frame
	void Update()
	{
	}

	public void StartServer()
	{
		if (discovery.StartAsServer())
		{
			Debug.Log("Able to send broadcasts.");
			discovery.StartAsServer();
		}
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
