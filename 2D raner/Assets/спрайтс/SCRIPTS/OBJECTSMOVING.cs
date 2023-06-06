
using UnityEngine;

public class OBJECTSMOVING : MonoBehaviour
{
    [SerializeField] private float speed = -0.05f;
    void Update()
    {
        transform.Translate( Vector3.right * speed); 
    }
}
