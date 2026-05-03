using UnityEngine;
public class PlayerController : MonoBehaviour
{
    private float speed = 20;
    private float turnSpeed = 120;

    void Start()
    {
        
    }
    
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed * Input.GetAxis("Vertical"));
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * Input.GetAxis("Horizontal"));
    }
}
