using UnityEngine;
using System.Collections;

public class Playerscript : MonoBehaviour {


    public float speed;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// 매 프레임마다 한번씩 실행되는 애
	void Update ()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            LeftMove();
        }
            if(Input.GetKey(KeyCode.RightArrow))
        {
            RightMove();
        }
            if(Input.GetKey(KeyCode.UpArrow))
        {
            FowardMove();
        }
            if (Input.GetKey(KeyCode.DownArrow))
        {
            BackMove();
        }
            if(Input.GetKey(KeyCode.LeftShift))
        {
            speed = 0.02f;
        }
        if(Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = 0.1f;
        }

            if (transform.position.x > 3.0f)
        {
            transform.position = new Vector3(3.0f, 1, 0);
        }
            if (transform.position.x < -3.0f)
        {
            transform.position = new Vector3(-3.0f, 1, 0);
        }
    }

    void LeftMove()
    {
        transform.Translate(-speed, 0, 0);
    }

    void RightMove()
    {
        transform.Translate(speed, 0, 0);
    }

    void FowardMove()
    {
        transform.Translate(0, 0, speed);
    }

    void BackMove()
    {
        transform.Translate(0, 0, -speed);
    }
}
