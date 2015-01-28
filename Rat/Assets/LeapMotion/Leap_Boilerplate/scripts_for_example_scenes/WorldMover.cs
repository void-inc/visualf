using UnityEngine;
using System.Collections;

public class WorldMover : MonoBehaviour {
	private LeapManager _leapManager;
	public float shootspeed = 2f;
	Rigidbody rb;
	bool shootnow = false;
	Vector3 nozzle;


	public GameObject knife;
	private GameObject direction;



	// Use this for initialization
	void Start () {
		_leapManager = (GameObject.Find("LeapManager")as GameObject).GetComponent(typeof(LeapManager)) as LeapManager;
		rb = gameObject.GetComponent<Rigidbody>();

		Transform[] transforms = GetComponentsInChildren<Transform>();
		foreach (Transform t in transforms)
		{
			if(t.gameObject.name == "direction")
			{
				direction = t.gameObject;
			}
		
		}



	}
	
	// Update is called once per frame
	void Update () {

	
		Quaternion rotation = Quaternion.Euler(Vector3.down * direction.transform.eulerAngles.y);



		if (shootnow == true)
		{
			Instantiate(knife, direction.transform.position, rotation);
		}


		if (rb.transform.position.z >= shootspeed) {
						shootnow = true;
				} else {
			shootnow = false;
				}

		if(_leapManager != null) { 
			if(_leapManager.pointerAvailible)
			{
				this.transform.position = _leapManager.pointerPositionWorld;
				if(!renderer.enabled) { renderer.enabled = true; }
			}
			else
			{
				renderer.enabled = false;
			}
		}
	}
}
