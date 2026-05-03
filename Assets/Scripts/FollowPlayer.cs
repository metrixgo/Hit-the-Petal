using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;

    void Start()
    {
        
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + new Vector3(0, 6, -7);
    }
}
