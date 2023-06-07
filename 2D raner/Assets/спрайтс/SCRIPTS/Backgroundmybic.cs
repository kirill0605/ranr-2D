
using UnityEngine;

public class Backgroundmybic : MonoBehaviour
{
    [SerializeField] private float BackgroundSpeed = 2f;
    private void Update()
    {
       transform.position -= new Vector3 (BackgroundSpeed *  Time.deltaTime, 0, 0);
       Debug.Log(transform.position);
    }
}
