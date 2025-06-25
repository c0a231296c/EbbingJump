using UnityEngine;

public class TargetController : MonoBehaviour
{
    public GameObject player;
    public float yforce = 2.5f; // 必要に応じて微調整

    public float maxScore = 100f;

    public static int totalClicks = 0;
    private static float totalScore = 0f;
    public static float averageScore = 0f;
    void Start()
    {
        this.player = GameObject.Find("Player");
        totalClicks = 0;
        totalScore = 0f;
        averageScore = 0f;
    }
    void OnMouseDown()
    {
        //マウスの位置を取得する処理
        Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPos.z = 0f;

        //距離を測定
        float distance = Vector2.Distance(transform.position, mouseWorldPos);
        //半径取得
        float radius = GetComponent<SpriteRenderer>().bounds.size.x / 2f;
        //相対距離
        float relativeDistance = distance / radius;
        float score;
        if (relativeDistance >= 1f)
        {
            score = 1f;
        }
        else
        {
            float normalized = 1f - relativeDistance;
            score = Mathf.Lerp(1f, maxScore, normalized);
        }


        // スコアを加算して平均を計算
        totalClicks++;
        totalScore += score;
        averageScore = totalScore / totalClicks;

        Debug.Log($"クリック{totalClicks}回目：{score:F1}点！ 平均点：{averageScore:F1}点");
    

        //マウスを押したらジャンプする処理
        Rigidbody2D rb = player.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            // 真上に一定の力をImpulseで加える
            rb.AddForce(Vector2.up * yforce, ForceMode2D.Impulse);
        }
    }
}


