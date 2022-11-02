using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public Camera cam;

    public GameObject obj;
    public Collider collider;
    public int backgroundInt = 690; //Odly specific number needed to keep the size of the object.
    
    


    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetMouseButton(1) && Input.GetKey(KeyCode.LeftShift))
        {
            obj.transform.position = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, backgroundInt));
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit)){
                if(hit.collider == collider) obj.transform.position = Vector3.MoveTowards(transform.position, hit.point, Time.deltaTime);
            }
        }
    }
}
