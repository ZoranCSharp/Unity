using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForObjects : MonoBehaviour
{
  
    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit2;

        if(Physics.Raycast(transform.position, -Vector3.up, out hit, 100f)){
            print($"We hit something at {hit.transform.position}");
        }
        else
        {
            print("nothing underneath us");
        }

        if(Physics.Raycast(ray, 100))
        {
            print("hit something with mouse");
        }

        if (Physics.Raycast(ray, out hit2, 100))
        {
            print("hit something with mouse");
            print($"hit {hit.collider.gameObject.name}");
        }
    }
}
