using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JudgeCard : MonoBehaviour
{
    float angularSpeed = 180f;
    bool frag = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GetClickedGameObject.cardList.Count >= 2)
        {
            if (frag == true)
            {
                Invoke("Judge", 5f);
                frag = false;
            }
        }
        else
        {
            frag = true;
        }
    }

    void Judge()
    {
        
        
        if (GetClickedGameObject.cardList[0].number == GetClickedGameObject.cardList[1].number)
        {
            GetClickedGameObject.cardList.Clear();
            Debug.Log("get point");
        }
        else
        {
            ReverseCard.Reverse(GetClickedGameObject.cardList[0].obj);
            ReverseCard.Reverse(GetClickedGameObject.cardList[1].obj);
            GetClickedGameObject.cardList.Clear();

            Debug.Log("sadfadf");
        }
            
        
        
    }
}
