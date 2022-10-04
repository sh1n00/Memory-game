using UnityEngine;

public class GetClickedGameObject : MonoBehaviour
{

    GameObject clickedGameObject;

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {

            clickedGameObject = null;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit = new RaycastHit();

            if (Physics.Raycast(ray, out hit))
            {
                clickedGameObject = hit.collider.gameObject;
                var card = new CardInfomation.CardInfo();
                card = CardInfomation.GetInfo(clickedGameObject.name);
                Debug.Log(card.suit);
                Debug.Log(card.number.ToString());
            }

            //var card = new CardInfomation.CardInfo();
            //card = CardInfomation.GetInfo(clickedGameObject.name);
            //Debug.Log(card.suit);
            //Debug.Log(card.number.ToString());
        }
    }
}

   