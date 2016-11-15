#pragma strict
import UnityEngine.UI;
import UnityEngine.Networking;

private var ipText : UI.Text;
private var ipAddress : String;

function Start () {
	ipText = GetComponent(UI.Text);
}

function Update () {
	ipAddress = Network.player.ipAddress;
	ipText.text = "IP Address: " + ipAddress;
}
