using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// ��� ��������������� � �������� ����
// ��� ������ ������ ���� ������ �����������? ��� ����� direction.normalized �� ����������, ��� OnCollisionEnter ����������� ������
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
