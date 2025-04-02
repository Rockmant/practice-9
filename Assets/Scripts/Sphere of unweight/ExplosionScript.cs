using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionScript : MonoBehaviour
{
    public float timeExplosion;
    public double power;
    public float radius;
    float time ;
    private Rigidbody[] physicalObject;


    void Start()
    {
         time = timeExplosion;
        physicalObject = FindObjectsOfType<Rigidbody>();
    }
    private void Boom()
    {
        foreach (Rigidbody r in physicalObject)
        {
            double distance = Vector3.Distance(transform.position, r.transform.position);
            if (distance < radius)
            {
                double expPower =  power / (distance*distance+0.5);
                Vector3 direction = r.transform.position - transform.position;
                

                r.AddForce(direction.normalized * ((float)(expPower)), ForceMode.Impulse); //IDE предложила сделать ((float)(expPower)) надеюсь это преобразование


            }
        }
    }

    // Update is called once per frame


    void Update()
    {
        time -= Time.deltaTime;
        if (time < 0)
        {
            Boom();
            time = timeExplosion;
        }
    }
}
