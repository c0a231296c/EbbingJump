using UnityEngine;

public class Big_EbbinghausController : MonoBehaviour
{
    public GameObject centralCircle;    // 中央の円（的）
    public GameObject surroundCirclePrefab; // 周囲の円のプレハブ
    public int numberOfSurrounds = 8;   // 周囲に配置する数
    public float distanceMultiplier = 2f; // 中心からの距離倍率
    public float surroundSizeRatio = 0.5f; // 周囲の円のサイズ比

    void Start()
    {
        PlaceSurroundingCircles();
    }

    void PlaceSurroundingCircles()
    {
        float centralRadius = centralCircle.transform.localScale.x / 2f;

        for (int i = 0; i < numberOfSurrounds; i++)
        {
            float angle = i * Mathf.PI * 2 / numberOfSurrounds;
            Vector3 offset = new Vector3(
                Mathf.Cos(angle),
                Mathf.Sin(angle),
                0
            ) * centralRadius * distanceMultiplier;

            GameObject circle = Instantiate(surroundCirclePrefab, centralCircle.transform.position + offset, Quaternion.identity, transform);
            circle.transform.localScale = centralCircle.transform.localScale * surroundSizeRatio;
        }
    }
}
