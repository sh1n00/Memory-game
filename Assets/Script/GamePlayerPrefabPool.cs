using Photon.Pun;
using UnityEngine;

// IPunPrefabPoolインターフェースを実装する
public class GamePlayerPrefabPool : MonoBehaviour, IPunPrefabPool
{
    [SerializeField]
    private GamePlayerPrefabPool gamePlayerPrefab = default;

    private void Start()
    {
        // ネットワークオブジェクトの生成・破棄を行う処理を、このクラスの処理に差し替える
        PhotonNetwork.PrefabPool = this;
    }

    GameObject IPunPrefabPool.Instantiate(string prefabId, Vector3 position, Quaternion rotation)
    {
        switch (prefabId)
        {
            case "GamePlayer":
                var player = Instantiate(gamePlayerPrefab, position, rotation);
                // 生成されたネットワークオブジェクトは非アクティブ状態で返す必要がある
                // （その後、PhotonNetworkの内部で正しく初期化されてから自動的にアクティブ状態に戻される）
                player.gameObject.SetActive(false);
                return player.gameObject;
        }
        return null;
    }

    void IPunPrefabPool.Destroy(GameObject gameObject)
    {
        Destroy(gameObject);
    }
}