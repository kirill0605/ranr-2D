
using UnityEngine;

public class OBJECTSMOVING : MonoBehaviour
{
    [SerializeField] private float TemplateSpeed = 5f;
    void Update()
    {
        transform.position -= new Vector3 (TemplateSpeed *  Time.deltaTime, 0, 0);
    }
}
