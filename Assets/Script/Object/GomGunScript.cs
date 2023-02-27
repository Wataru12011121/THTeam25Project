using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GomGunScript : MonoBehaviour
{
    //飛ばす力
    public float power = 1.0f;
    //offset
    public Vector3 offset = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Playerが当たったら
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            GameObject player = collision.gameObject;

            //SpawnPointにPlayerを合わせる
            player.transform.position = transform.GetChild(0).gameObject.transform.position;

            //Player飛ばす
            player.GetComponent<Rigidbody>().AddForce(Vector3.forward * power);
        }
    }
}
