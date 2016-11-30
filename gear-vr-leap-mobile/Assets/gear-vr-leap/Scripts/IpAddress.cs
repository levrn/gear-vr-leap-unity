using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class IpAddress : MonoBehaviour {
	Text ipText;
	// Use this for initialization
	void Start () {
		ipText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		ipText.text = "IP Address: " + Network.player.ipAddress;
	}
}
