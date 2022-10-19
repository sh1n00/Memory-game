using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public class PlayerInfo
    {
        public string name;
        public int score;
    }

    static public List<PlayerInfo> PlayerList = new List<PlayerInfo>();
    private void Start()
    {
        var player1 = new PlayerInfo();
        var player2 = new PlayerInfo();

        player1.name = "Player1";
        player1.score = 0;
        player2.name = "Player2";
        player2.score = 0;


        PlayerList.Add(player1);
        PlayerList.Add(player2);
        Debug.Log(PlayerList[0]);
    }
}
