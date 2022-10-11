using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Vector3 velocity;

    // 弾のID
    public int Id {get; private set; }
    // 発射したプレイヤーID
    public int OwnerId {get; private set; }
    // 同じ弾の判定用メソッド
    public bool Equal(int id, int ownerId)
    {
        return id == this.Id && ownerId == this.OwnerId;
    }
    
    public void Init(int id, int ownerId, Vector3 origin, float angle)
    {
        Id = id;
        OwnerId = ownerId;
        this.transform.position = origin;
        velocity = 9f * new Vector3(Mathf.Cos(angle), Mathf.Sin(angle));
    }

    private void Update()
    {
        this.transform.Translate(velocity * Time.deltaTime);
    }

    private void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}
