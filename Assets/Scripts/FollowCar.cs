using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCar : MonoBehaviour
{

    public GameObject car;
    private Vector3 offset = new Vector3(2, 4, -17);
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = car.transform.position+offset;
        
    }
}
