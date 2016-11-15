#if ENABLE_UNET
using UnityEngine;
namespace UnityEngine.Networking
{
	[AddComponentMenu("Network/NetworkManagerHUD")]
	[RequireComponent(typeof(NetworkManager))]
	[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
	public class NetworkManagerHUD : MonoBehaviour
	{
		GameObject server;
		GameObject client;
		GameObject inputField;
		GameObject joinGame;
		GameObject ipAddressText;
		public ButtonCheck buttonCheck;
		public NetworkManager manager;
		[SerializeField]
		public bool showGUI = true;
		[SerializeField]
		public int offsetX;
		[SerializeField]
		public int offsetY;

		// Runtime variable
		bool showServer = false;

		void Awake()
		{
			server = GameObject.FindGameObjectWithTag("Server");
			client = GameObject.FindGameObjectWithTag("Client");
			ipAddressText = GameObject.Find("IP Address Text");
			inputField = GameObject.Find("IP Address");
			joinGame = GameObject.Find("Join Game");
			buttonCheck = GetComponent<ButtonCheck>();
			manager = GetComponent<NetworkManager>();

			ipAddressText.SetActive(false);
			inputField.SetActive(false);
			joinGame.SetActive(false);
		}

		void Update()
		{
			if (!showGUI)
				return;

			if (!NetworkClient.active && !NetworkServer.active && manager.matchMaker == null)
			{
				if (Input.GetKeyDown(KeyCode.S))
				{
					manager.StartServer();
				}
				if (Input.GetKeyDown(KeyCode.H))
				{
					manager.StartHost();
				}
				if (Input.GetKeyDown(KeyCode.C))
				{
					manager.StartClient();
				}
			}
			if (NetworkServer.active && NetworkClient.active)
			{
				if (Input.GetKeyDown(KeyCode.X))
				{
					manager.StopHost();
				}
			}
		}

		void LateUpdate()
		{
			if (!showGUI)
				return;


			if (!NetworkClient.active && !NetworkServer.active && manager.matchMaker == null)
			{
				if (buttonCheck.CheckObjectPressed() != null && buttonCheck.CheckObjectPressed().tag == "Client")
				{
					client.SetActive(false);
					server.SetActive(false);
					joinGame.SetActive(true);
					inputField.SetActive(true);
				}

				if (buttonCheck.CheckObjectPressed() != null && buttonCheck.CheckObjectPressed() == server)
				{
					manager.StartServer();
					if (server.activeInHierarchy)
					{
						server.SetActive(false);
					}
					client.SetActive(false);
					ipAddressText.SetActive(true);
				}
			}
			else
			{
				if (NetworkServer.active)
				{
					
				}
				if (NetworkClient.active)
				{
					
				}
			}
		}
	}
};
#endif //ENABLE_UNET
