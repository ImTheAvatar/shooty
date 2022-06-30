using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public int num = 2;
    List<GameObject> objects;
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        objects = new List<GameObject>();
        for (int i=0;i<num;i++)
        {
            var go=Instantiate(prefab);
            objects.Add(go);
            go.SetActive(false);
        }
    }

    public GameObject GetObject()
    {
        for(int i=0;i<100;i++)
        {
            if (objects[i].activeInHierarchy==false)
            {
                return objects[i];
            }
        }
        return null;
    }
}
