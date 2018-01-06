using UnityEngine;
using System.Collections;

public class deletecylinder : MonoBehaviour {

    public GameObject mycilender;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.D))
            Destroy(GetComponent<MeshRenderer>());
    }
}
