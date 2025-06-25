using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class ClearSceneDirector : MonoBehaviour
{
    GameObject score;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.score = GameObject.Find("Score");
    }

    // Update is called once per frame
    void Update()
    {
        float averageScore = TargetController.averageScore;
        this.score.GetComponent<TextMeshProUGUI>().text = "Score:" + averageScore.ToString("F2");
        if (Keyboard.current.rKey.wasPressedThisFrame)
        {
            SceneManager.LoadScene("StartScene");
        }
    }
}
