using UnityEngine;
using System.Collections.Generic;

public class GetClickedGameObject : MonoBehaviour
{

    GameObject clickedGameObject;

    static public List<CardInfomation.CardInfo> cardList = new List<CardInfomation.CardInfo>();
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {

            clickedGameObject = null;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit = new RaycastHit();
            if (GetClickedGameObject.cardList.Count < 2)
            {
                if (Physics.Raycast(ray, out hit))
                {
                    clickedGameObject = hit.collider.gameObject;
                    var card = new CardInfomation.CardInfo();
                    card = CardInfomation.GetInfo(clickedGameObject);
                    cardList.Add(card);
                    Debug.Log(card.suit);
                    Debug.Log(card.number.ToString());
                    clickedGameObject.transform.rotation = Quaternion.AngleAxis(0, new Vector3(1, 0, 0));
                }
            }
            

            //var card = new CardInfomation.CardInfo();
            //card = CardInfomation.GetInfo(clickedGameObject.name);
            //Debug.Log(card.suit);
            //Debug.Log(card.number.ToString());
        }
    }
}

   