using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Destroy(gameObject, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        //내 위치를 y축으로 0.5f만큼 이동시킨다.
        transform.Translate(0, 0.5f, 0);
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
}
