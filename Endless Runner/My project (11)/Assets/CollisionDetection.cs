using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDetection : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
       if(other.gameObject.CompareTag("Obstacle"))
       {
           SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
       }
    }
    

}
