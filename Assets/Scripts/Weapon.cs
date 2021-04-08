using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform FirePoint;
    public GameObject BulletPrefab;

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.S))
        {
            Shoot();
        } 
    }

    void Shoot()
    {
        Instantiate(BulletPrefab, FirePoint.position, FirePoint.rotation);
    }
}
