using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public Camera cam;

    public GameObject obj;
    public Collider collider;
    public int backgroundInt = 690; //Odly specific number needed to keep the size.
    


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            transform.position = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, backgroundInt));
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit)){
                if(hit.collider == collider) transform.position = Vector3.MoveTowards(transform.position, hit.point, Time.deltaTime);
            }
        }
    }
}
