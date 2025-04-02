using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// ѕри соприкосновении с бандитом бьем
// “ут вопрос почему сила ударов различаетс€? как будто direction.normalized не срабатывет, или OnCollisionEnter срабатывает дважды
public class StrikeSkript : MonoBehaviour
{
    public float kickForce;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        Vector3 direction = collision.transform.position - transform.position;
        if (collision.gameObject.layer == 3 && collision.gameObject.GetComponent<Rigidbody>())
        {
            collision.rigidbody.AddForce(direction.normalized * kickForce, ForceMode.Impulse);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
