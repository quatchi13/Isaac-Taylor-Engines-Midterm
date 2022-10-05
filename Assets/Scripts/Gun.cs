using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
  
  [SerializeField]
    private float delay = 5;

    [SerializeField]
    private GameObject bullet;

    private float timeSinceShot = 0;

    // Update is called once per frame
    void Update()
    {
       if(delay != ShootingManager.instance.GetFireRate())
       {
         delay = ShootingManager.instance.GetFireRate();
       }

       if(timeSinceShot > delay)
       {
            Fire();
            timeSinceShot = 0;

       }
       else
       {
            timeSinceShot += Time.deltaTime;
       }
    }


    void Fire()
    {
       Rigidbody bulletRigid =  Instantiate(bullet, transform.position + new Vector3(1,0,0), Quaternion.identity).GetComponent<Rigidbody>();
        bulletRigid.velocity = new Vector3 (0, 0, 5);

    }
}
