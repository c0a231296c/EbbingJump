using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Normal_buttonController : MonoBehaviour
{    
    public void OnClick()
    {
        SceneManager.LoadScene("SampleScene");
        Debug.Log("Pressed Normal_button");  // ログを出力
    }
}
