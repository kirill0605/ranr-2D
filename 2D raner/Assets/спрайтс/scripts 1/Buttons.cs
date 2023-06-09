using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
     public void PlayPressed()
    {
        SceneManager.LoadScene("mainGame");
    }
    
     public void Restart()
    {
        SceneManager.LoadScene("mainGame");
    }
}
