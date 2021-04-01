using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System.Linq;

public class click : MonoBehaviour, IDragHandler, IEndDragHandler, IBeginDragHandler, IPointerEnterHandler
{
    main main;
    private LineRenderer lr;
    private Vector3 pos;
    void Start()
    {
        lr = GetComponent<LineRenderer>();
        main = GameObject.FindGameObjectWithTag("line").GetComponent<main>();
        lr.widthMultiplier = 0.3f;
    }

    public void addToList(main main, GameObject gameObject)
    {
        if (!main.newList.Contains(gameObject))
        {
            main.newList.Add(gameObject);
        }
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        addToList(main, this.gameObject);
    }

    public void OnDrag(PointerEventData eventData)
    {
        pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        pos.z = 0;
        lr.SetPosition(0, main.newList.LastOrDefault().transform.position);
        lr.SetPosition(1, pos);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        lr.SetPosition(0, Vector3.zero);
        lr.SetPosition(1, Vector3.zero);
        //main.newList.Clear();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        addToList(main, this.gameObject);
    }
}
