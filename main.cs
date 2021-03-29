using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class main : MonoBehaviour
{
    public List<GameObject> newList = new List<GameObject>();
    //private LineRenderer lr;
    private Vector3 pos;



    // Start is called before the first frame update
    [System.Obsolete]
    void Start()
    {
        //lr = GetComponent<LineRenderer>();
        //lr.SetWidth(0.45f, 0.45f);
        //lr.positionCount = 4;
    }

    // Update is called once per frame
    void Update()
    {
        //lr.enabled = true;
        //Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //pos.z = 0;
        //lr.SetPosition(0, gameObject.transform.position + pos);
        //lr.positionCount = newList.Count;
        //for (int i = 0; i < lr.positionCount; i++)
        //{
        //    lr.SetPosition(i, newList[i].transform.position);
        //}
    }

}
