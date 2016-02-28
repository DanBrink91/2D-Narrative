using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
	// Target to follow
	public Transform target;
	// Camera Size
	public float scale = 4f;
	// Camera Move Speed
	public float speed = 0.1f;
	Camera myCam;

	// Use this for initialization
	void Start () {
		myCam = GetComponent<Camera> ();
	}
	
	// Update is called once per frame
	void Update () {
		myCam.orthographicSize = (Screen.height / 100f) / scale;

		if (target) {
			transform.position = Vector3.Lerp(transform.position, target.position, speed) + new Vector3(0, 0, -10);
		}
	}
}
