using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JudgeCard : MonoBehaviour
{
    public float waitTime;
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
                Invoke("Judge", waitTime);
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
            //ゲームオブジェクトを無効化
            GetClickedGameObject.cardList[0].obj.SetActive(false);
            GetClickedGameObject.cardList[1].obj.SetActive(false);

            //カードリストから削除
            


            GetClickedGameObject.cardList.Clear();
            Player.PlayerList[TurnChange.Turn].score += 1; 
            Debug.Log(Player.PlayerList[TurnChange.Turn].name);
            Debug.Log(Player.PlayerList[TurnChange.Turn].score);
        }
        else
        {
            ReverseCard.Reverse(GetClickedGameObject.cardList[0].obj);
            ReverseCard.Reverse(GetClickedGameObject.cardList[1].obj);
            GetClickedGameObject.cardList.Clear();

            Debug.Log(TurnChange.Turn);
            Debug.Log(Player.PlayerList);
            Debug.Log(Player.PlayerList[TurnChange.Turn].name);
            Debug.Log(Player.PlayerList[TurnChange.Turn].score);

            TurnChange.Change();

            Debug.Log(Player.PlayerList[TurnChange.Turn].name);
        }
    }
}
