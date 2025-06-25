using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearZoneController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("触れた相手：" + collision.gameObject.name);
        if (collision.gameObject.name == "Player")
        {
            Debug.Log("クリア");
            SceneManager.LoadScene("ClearScene");
        }
    }
}
