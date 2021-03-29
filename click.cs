using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class click : MonoBehaviour, IDragHandler, IEndDragHandler, IBeginDragHandler, IPointerEnterHandler
{
    GameObject main;
    //private LineRenderer lr;
    private Vector3 pos;
    private bool drag = false;
    void Start()
    {
        //lr = GetComponent<LineRenderer>();
        //lr.widthMultiplier = 0.3f;
        //lr.enabled = false;
    }


    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("test");
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("lol");

    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("nice");
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Enter");
    }


    //void OnMouseDrag()
    //{
    //drag = true;
    //Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    //pos.z = 0;
    //lr.enabled = true;

    //lr.SetPosition(0, this.gameObject.transform.position);
    //lr.SetPosition(1, pos);
    //Debug.Log("rtwetewt" + this.gameObject.name);
    //}

    //void OnMouseEnter() {
    //Debug.Log(this.gameObject.name);
    //if(drag)
    //{
    //    Debug.Log(this.gameObject.name);
    //    if (!GameObject.FindGameObjectWithTag("line").GetComponent<main>().newList.Contains(this.gameObject))
    //    {
    //        GameObject.FindGameObjectWithTag("line").GetComponent<main>().newList.Add(this.gameObject);
    //    }

    //}
    //}
}
