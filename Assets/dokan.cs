using UnityEngine;
using System.Collections;

public class dokan : MonoBehaviour {
    float speed = 0.1f;
    int ran = 114514;
    System.Random r = new System.Random(1);
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Transform>().position = new Vector2(GetComponent<Transform>().position.x - speed, GetComponent<Transform>().position.y);
        int a = r.Next(-2500, 2500);
        if(GetComponent<Transform>().position.x < -11.0f)
        {
            float f = r.Next(-2500, 2500)/1000.0f;
            GetComponent<Transform>().position = new Vector2(11.0f, f);
        }
	}
}
