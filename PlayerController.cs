using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //キーボード処理
        if (Keyboard.current != null)
        {
            //Aキーが押されたら右移動+移動方向変更
            if (Keyboard.current.aKey.isPressed)
            {
                transform.Translate(-0.1f, 0, 0);
                transform.localScale = new Vector3(-8, 8, 1);
            }

            //Dキーが押されたら左移動+移動方向変更
            if (Keyboard.current.dKey.isPressed)
            {
                transform.Translate(0.1f, 0, 0);
                transform.localScale = new Vector3(8, 8, 1);
            }
        }
    }
}
