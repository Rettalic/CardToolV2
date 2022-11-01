using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateNewObject : MonoBehaviour
{
    public GameObject prefab;
    public List<GameObject> prefabList;
    public Vector3 position;
    public float addPos;

    // Start is called before the first frame update
    void Start()
    {
        prefabList = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        position = new Vector3(position.x, position.y, position.z); 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab);
            prefabList.Add(prefab);
            prefab.transform.position = position;
        }
    }
}
