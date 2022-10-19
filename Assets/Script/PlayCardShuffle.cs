using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayCardShuffle : MonoBehaviour
{
    //public List<GameObject> ObjectList = new List<GameObject>();
    public Transform AllCard;
    private int ObjectCount;
    public Transform[] cardList;
    // Start is called before the first frame update
    void Start()
    {
        var cardList = GetChildren(AllCard);
        Shuffle(cardList);
        Placement(cardList);

        //var allCard = new CardInfomation.CardInfo();
        //for(var i = 0; i < cardList.Length; ++i)
        //{
        //    Debug.Log(cardList[i]);
        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static Transform[] GetChildren(Transform parent)
    {
        var children = new Transform[parent.childCount];

        for(var i = 0; i < children.Length; ++i)
        {
            children[i] = parent.GetChild(i);
        }
        return children;
    }
    private void Shuffle(Transform[] cardList)
    {
        int n = cardList.Length;
        while(n > 1)
        {
            n--;
            int k = Random.Range(0, n + 1);

            var temp = cardList[k];
            cardList[k] = cardList[n];
            cardList[n] = temp;

        }
    }
    private void Placement(Transform[] cardList)
    {
        int n = cardList.Length;
        float iniX = -0.4f;
        float iniY = 0f;
        float iniZ = 0.165f;
        var x = iniX;
        var y = iniY;
        var z = iniZ;


        while(n > 0)
        {
            n--;

            if (x > 0.445f)
            {
                x = iniX;
                z -= 0.11f;
            }
            cardList[n].position = new Vector3(x, y, z);
            cardList[n].rotation = Quaternion.AngleAxis(180, new Vector3(1, 0, 0));
            x += 0.065f;
            
        }
    }
}
