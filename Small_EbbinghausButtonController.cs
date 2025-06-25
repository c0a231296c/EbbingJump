using UnityEngine;
using UnityEngine.SceneManagement;

public class Small_EbbinghausButtonController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void OnClick()
    {
        SceneManager.LoadScene("small_EbbinghausScene");
        //SceneManager.LoadScene("SampleScene");
        Debug.Log("Pressed Big_Ebbinghaus_button");  // ログを出力
    }
}
