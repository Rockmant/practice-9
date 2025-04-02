using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallInPool : MonoBehaviour
{
    public float startImpulse;// Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(0, 0, startImpulse, ForceMode.Impulse);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
