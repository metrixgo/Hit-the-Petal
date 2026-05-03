using UnityEngine;

public class SpinX : MonoBehaviour
{
    private float spinSpeed = 3000;

    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Rotate(Vector3.forward * spinSpeed * Time.deltaTime);
    }
}
