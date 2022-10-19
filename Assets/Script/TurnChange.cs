using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnChange : MonoBehaviour
{
    static public int Turn = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    static public void Change()
    {
        Turn++;
        if(Turn >= Player.PlayerList.Count)
        {
            Turn = 0;
        }
    }
}
