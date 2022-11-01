using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewObj : MonoBehaviour
{
    public List<GameObject> images;
    public GameObject baseobj;
    // Start is called before the first frame update
    void Start()
    {
        images = new List<GameObject>();

    }

    public void createObj()
    {
        Instantiate(baseobj);
        images.Add(baseobj);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
