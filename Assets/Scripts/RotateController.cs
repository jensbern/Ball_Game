using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateController : MonoBehaviour {
    float speed = 30;
    public GameObject c;


	// Update is called once per frame
	void Update () {Quaternion rotation = Quaternion.identity;
        if (Input.GetKey(KeyCode.H))
        {
            transform.Rotate(-Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.F))
        {
            transform.Rotate(Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.T))
        {
            transform.Rotate(Vector3.right * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.G))
        {
            transform.Rotate(-Vector3.right * speed * Time.deltaTime);
        }
    }
}
