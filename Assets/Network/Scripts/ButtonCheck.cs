using UnityEngine;
using System.Collections;

public class ButtonCheck : MonoBehaviour
{
	GameObject touchedObject;
	Camera cameraComp;

	// Use this for initialization
	void Start()
	{
		cameraComp = GameObject.Find("Camera").GetComponent<Camera>();
	}

	// Update is called once per frame
	void Update()
	{

	}
	public GameObject CheckObjectPressed()
	{
		if (Input.GetMouseButtonUp(0))
		{
			Ray ray = cameraComp.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;

			if (Physics.Raycast(ray, out hit))
			{
				Debug.Log(hit.transform.name);
				touchedObject = hit.transform.gameObject;
			}
			return touchedObject;
		}
		else {
			return null;
		}
	}
}