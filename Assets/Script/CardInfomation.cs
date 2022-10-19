using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text.RegularExpressions;
using System;


public class CardInfomation : MonoBehaviour
{
    public string suit;
    public int number;
    public class CardInfo { public GameObject obj; public string suit; public int number; }
    //public Dictionary CardInfo<string suit, int number>;
    // Start is called before the first frame update
    void Start()
    {
        //GetInfo();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    public static CardInfo GetInfo(GameObject obj)
    {
        
        var card = new CardInfo();

        
        string[] arr = obj.name.Split('_');
        if(arr[1] == "PlayingCards")
        {
            card.obj = obj;
            card.suit = Regex.Replace(arr[2], "[0-9]", "");
            int.TryParse(Regex.Replace(arr[2], "[^ 0-9 _]", ""), out card.number);
        }
        else
        {
            Debug.LogError("GameObject is not PlayingCards");
            card.suit = "0";
            card.number = 0;
        }
        
        return card;

    }
    //class CardInfo { public string suit; public int number; }
}
