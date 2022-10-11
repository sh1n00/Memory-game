using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class AvatarFireBullet : MonoBehaviourPunCallbacks
{
    [SerializeField]
    private Bullet bulletPrefab = default;

    private int nextBulletId = 0;

    // Update is called once per frame
    private void Update()
    {
        if (photonView.IsMine)
        {
            if (Input.GetMouseButtonDown(0))
            {
                var mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                var direction = mousePosition - transform.position;
                float angle = Mathf.Atan2(direction.y, direction.x);

                photonView.RPC(nameof(FireBullet), RpcTarget.All, nextBulletId++, angle);

            }
        }
    }

    [PunRPC]
    private void FireBullet(int id, float angle)
    {
        var bullet = Instantiate(bulletPrefab);
        bullet.Init(id, photonView.OwnerActorNr, this.transform.position, angle);
    }
}
