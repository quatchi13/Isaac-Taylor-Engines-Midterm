using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingManager : MonoBehaviour
{
    public static ShootingManager instance;

    private float fireRate = 2;

    // Start is called before the first frame update
    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    public void ChangeFireRate(float newRate)
    {
        fireRate = newRate;
    }

    public float GetFireRate()
    {
        return fireRate;
    }
}
