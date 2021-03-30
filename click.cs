using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System.Linq;

public class click : MonoBehaviour, IDragHandler, IEndDragHandler, IBeginDragHandler, IPointerEnterHandler
{
    main main;
    public LineRenderer lr;
    private Vector3 pos;
    void Start()
    {
        //lr = GetComponent<LineRenderer>();
        main = GameObject.FindGameObjectWithTag("line").GetComponent<main>();
        lr.widthMultiplier = 0.3f;
        lr.enabled = false;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        if (!main.newList.Contains(this.gameObject))
        {
            main.newList.Add(this.gameObject);
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        
        lr.enabled = true;
        Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        pos.z = 0;

        lr.SetPosition(0, main.newList.LastOrDefault().transform.position);
        lr.SetPosition(1, pos);

    }

    public void OnEndDrag(PointerEventData eventData)
    {
        lr.SetPosition(0, Vector3.zero);
        lr.SetPosition(1, Vector3.zero);
        lr.enabled = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (eventData.pointerDrag)
        {
            if (!main.newList.Contains(this.gameObject))
            {
                main.newList.Add(this.gameObject);
            }
        }
      
    }
}
