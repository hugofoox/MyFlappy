using UnityEngine;

public class camera : MonoBehaviour
{

    public Transform _pivot;

    void Start()
    {
        
    }

    void LateUpdate()
    {
        transform.position = new Vector3(_pivot.position.x, transform.position.y, transform.position.z);
    }
}
