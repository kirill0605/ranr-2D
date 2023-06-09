using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrountSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] templatePlatforms;
    
    
   private void Start()
    {
      InvokeRepeating("Platforms", 1, 2.5f);
    } 
   
    private void Platforms()
    {
      Instantiate(templatePlatforms[Random.Range(0,templatePlatforms.Length)],transform.position,Quaternion.identity);
    }
}