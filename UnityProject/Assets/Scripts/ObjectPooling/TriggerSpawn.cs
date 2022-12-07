using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSpawn : MonoBehaviour
{

    public Transform enemyPos;
    public GameObject Enemy;

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Player")
        {


            Rigidbody enemyRb = ObjectPooler.instance.SpawnFromPool("Enemy", enemyPos.transform.position, Quaternion.identity).GetComponent<Rigidbody>();

        }

    }

}
