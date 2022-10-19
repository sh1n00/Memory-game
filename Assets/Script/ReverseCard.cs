using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ReverseCard : MonoBehaviour, IPointerClickHandler
{
    //float angularSpeed = 180f;クリックするたびに回転するコード  
    public void OnPointerClick(PointerEventData eventData)
    {
       // transform.eulerAngles += angularSpeed * Vector3.forward;クリックするたびに回転するコード
        transform.rotation = Quaternion.AngleAxis(0, new Vector3(1, 0, 0));
        Debug.Log("Click");
    }
    public static void Reverse(GameObject card)
    {
        card.transform.eulerAngles += 180f * Vector3.forward;

    }
}