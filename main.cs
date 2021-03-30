using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class main : MonoBehaviour
{
    public List<GameObject> newList = new List<GameObject>();
    private LineRenderer lr;
    private Vector3 pos;


    // Start is called before the first frame update
    void Start()
    {
        lr = GetComponent<LineRenderer>();
        lr.widthMultiplier = 0.3f;
        lr.positionCount = newList.Count;
    }

    // Update is called once per frame
    void Update()
    {
        lr.positionCount = newList.Count;
        for (int i = 0; i < lr.positionCount; i++)
        {
            lr.SetPosition(i, newList[i].transform.position);
        }
    }

}
