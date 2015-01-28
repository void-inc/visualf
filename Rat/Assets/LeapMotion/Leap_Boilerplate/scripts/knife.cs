using UnityEngine;
using System.Collections;

public class knife : MonoBehaviour {


	public GameObject target;
	public float speed = 1f;
	public float maxLifeTime = 0f;
	private float lifeTime = 0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		float delta = Time.deltaTime;
		
		
		lifeTime += delta;
		if (lifeTime > maxLifeTime)
		{
			Destroy(this.gameObject);
		}
		transform.Translate(Vector3.forward * speed * delta);   
	}
	
	void OnCollisionEnter(Collision coll)
	{
		if(coll.gameObject.name == ("draairat"))
		   {
			Debug.Log ("hit!");
			Destroy(this.gameObject);
		}
	}
}