using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScenePooling : MonoBehaviour
{
    [SerializeField] List<GameObject> houses = new();
    GameObject sentHouse;
    float spawnerTime;
    float nextSpawnerTime;
    float houseSpeed;
    int random;
    [SerializeField] Transform SP1,SP2,SP3,SP4,SP5;
    // Start is called before the first frame update
    void Start()
    {
        nextSpawnerTime = 4;
        spawnerTime = nextSpawnerTime;
        houseSpeed = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if(spawnerTime <= 0)
        {
            spawnerTime = nextSpawnerTime;
            RockSpawn();
        }
        else
        {
            spawnerTime -= Time.deltaTime;
        }
    }

    public void RockSpawn()
    {
        
        sentHouse = houses[0];
        houses.RemoveAt(0);
        GetRock();
        
    }
     public void GetRock()
    {
        
        random = Random.Range(0, 4);
        if (random == 0)
        {
            sentHouse.transform.position = SP1.position;
        }
        else if(random == 1)
        {
            sentHouse.transform.position = SP2.position;
        }
        else if(random == 2)
        {
            sentHouse.transform.position = SP3.position;
        }else if(random == 3)
        {
            sentHouse.transform.position = SP4.position;
        }
        else if(random == 4)
        {
            sentHouse.transform.position = SP5.position;
        }
        
        
        sentHouse.SetActive(true);
        sentHouse.GetComponent<Rigidbody>().velocity = Vector3.forward *-1* houseSpeed;
        houses.Add(sentHouse);
    }
}
