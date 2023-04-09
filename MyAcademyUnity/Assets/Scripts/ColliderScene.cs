using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderScene : MonoBehaviour
{
    public GameObject wall1;
    public GameObject wall2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            Debug.Log("çalıştı");
            wall1.GetComponent<MeshCollider>().isTrigger = false;
            wall2.GetComponent<MeshCollider>().isTrigger = false;
        }
    }


}
