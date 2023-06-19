using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCubeController : MonoBehaviour
{
    //cubeを移動させるコンポーネントを入れる
    private Rigidbody myRigidbody;
    //前方向の速度
    private float velocityZ = 16f;
    //動きを減速させる係数（追加）
    private float coefficient = 0.99f;

    private UnityChanController unityChanController;
    // Start is called before the first frame update
    void Start()
    {
        //Rigidbodyコンポーネントを取得（追加）
        this.myRigidbody = GetComponent<Rigidbody>();

        unityChanController = GameObject.Find("unitychan").GetComponent<UnityChanController>();
    }

    // Update is called once per frame
    void Update()
    {
        //Unityちゃんに速度を与える
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
