using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreUI : MonoBehaviour
{
    public Transform AllCard;

    public TextMeshProUGUI Player1;
    public TextMeshProUGUI Player2;

    private bool flag = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Player1.text = Player.PlayerList[0].name + ":" + Player.PlayerList[0].score.ToString();
        Player2.text = Player.PlayerList[1].name + ":" + Player.PlayerList[1].score.ToString();
        var allCard = PlayCardShuffle.GetChildren(AllCard);
        //for (var i = 0; i < allCard.Length; ++i)
        //{
        //    if (!allCard[i].gameObject.activeSelf)
        //    {
               
        //        break;
        //    }
        //}
    }
}
