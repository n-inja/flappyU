using UnityEngine;
using System.Collections;

public class script : MonoBehaviour {
    float speed = 5.0f;
    bool isJump = false;

    // Use this for initialization
    void Start () {
        isJump = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (!isJump && Input.GetButton("Fire1"))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed);
        }
        isJump = false;
        if(GetComponent<Rigidbody2D>().velocity.y > 0)
        {
            isJump = true;
        }
	}
}
