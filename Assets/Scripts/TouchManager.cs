using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TouchManager : MonoBehaviour, IDragHandler
{
    private float speedRotateX = 1;
    private float speedRotateY = 1;    

    public void OnDrag(PointerEventData eventData)
    {
        if ((Mathf.Abs(eventData.delta.x)) > (Mathf.Abs(eventData.delta.y)))
        {
            if (eventData.delta.x > 0)
            {
                transform.Rotate(new Vector3(-1 * speedRotateX, 0, 0) * Time.deltaTime * 30);
            }
            else
            {
                transform.Rotate(new Vector3(speedRotateX, 0, 0) * Time.deltaTime * 30);
            }
        }
        else
        {
            if (eventData.delta.y > 0)
            {
                transform.Rotate(new Vector3(0, -1 * speedRotateY, 0) * Time.deltaTime * 30);                
            }
            else
            {
                transform.Rotate(new Vector3(0, speedRotateY, 0) * Time.deltaTime * 30);                
            }
        }
    }
}
