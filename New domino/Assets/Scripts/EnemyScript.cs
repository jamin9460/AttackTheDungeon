using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {

    public GameObject effect;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Ground")
        {
            Destroy(gameObject);
        }
        if(col.gameObject.tag == "Player")
        {
            Application.LoadLevel(0);
        }
        if(col.gameObject.tag == "Bullet")
        {
            Instantiate(effect, transform.position,transform.rotation);
            Destroy(gameObject);
        }
    }
}
