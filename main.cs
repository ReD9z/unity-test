using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class main : MonoBehaviour
{
    [SerializeField] private float animationDuration = 5f;
    public List<GameObject> newList = new List<GameObject>();
    public List<GameObject> lineAnim = new List<GameObject>();
    private LineRenderer lr;

    // Start is called before the first frame update
    void Start()
    {
        lr = GetComponent<LineRenderer>();
        lr.widthMultiplier = 0.3f;
        lr.positionCount = lineAnim.Count;

        for (int i = 0; i < lr.positionCount; i++)
        {
            lr.SetPosition(i, lineAnim[i].transform.position);
        }

        StartCoroutine(AnimateLine());
    }

    private IEnumerator AnimateLine()
    {
        float segmentDuration = animationDuration / lr.positionCount;

        for (int i = 0; i < lr.positionCount - 1; i++)
        {
            float startTime = Time.time;

            Vector3 startPosition = lineAnim[i].transform.position;
            Vector3 endPosition = lineAnim[i + 1].transform.position;

            Vector3 pos = startPosition;
            while (pos != endPosition)
            {
                float t = (Time.time - startTime) / segmentDuration;
                pos = Vector3.Lerp(startPosition, endPosition, t);

                // animate all other points except point at index i
                for (int j = i + 1; j < lr.positionCount; j++)
                    lr.SetPosition(j, pos);

                yield return null;
            }
        }
    }


}
