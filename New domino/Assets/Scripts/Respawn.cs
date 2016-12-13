using UnityEngine;
using System.Collections;

public class Respawn : MonoBehaviour {

    public GameObject enemy;
    public float spawnTime;
    public float coolTime;

    void Start()
    {

    }

    void Update()
    {
        spawnTime -= Time.deltaTime;
        if (spawnTime < 0)
        {
            Instantiate(enemy, transform.position, transform.rotation);
            coolTime = Random.Range(3.0f, 10.0f);
            spawnTime = coolTime;
        }
    }
}
