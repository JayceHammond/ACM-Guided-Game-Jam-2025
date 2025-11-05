using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OutOfBoundsChecker : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(0);
        }

        if (col.gameObject.CompareTag("Consumable"))
        {
            Destroy(col.gameObject);
        }
    }
}
