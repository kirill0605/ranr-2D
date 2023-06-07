using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class graynd : MonoBehaviour
{
   private GameObject spawnBackgrount;

[SerializeField] private int TimeSpawn = 1;

[SerializeField] private float SpawnRate = 10f;

[SerializeField] private GameObject templateBackground;

private void Start()
{
    InvokeRepeating("Background", TimeSpawn, SpawnRate);
}
    

private void Background()
{
    spawnBackgrount = Instantiate(templateBackground, transform.position,Quaternion.identity) as  GameObject;
} 
}
 
    
