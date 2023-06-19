using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCubeController : MonoBehaviour
{
    //cube���ړ�������R���|�[�l���g������
    private Rigidbody myRigidbody;
    //�O�����̑��x
    private float velocityZ = 16f;
    //����������������W���i�ǉ��j
    private float coefficient = 0.99f;

    private UnityChanController unityChanController;
    // Start is called before the first frame update
    void Start()
    {
        //Rigidbody�R���|�[�l���g���擾�i�ǉ��j
        this.myRigidbody = GetComponent<Rigidbody>();

        unityChanController = GameObject.Find("unitychan").GetComponent<UnityChanController>();
    }

    // Update is called once per frame
    void Update()
    {
        //Unity�����ɑ��x��^����
        this.myRigidbody.velocity = new Vector3(0, 0, velocityZ);

        if (unityChanController.isEnd)
        {
            this.velocityZ *= this.coefficient;
           
            
        }

       
    }
    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
