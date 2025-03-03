using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform playerHead;
    public float distanceBehind = 2.81f; // ระยะห่างจากหัวผู้เล่น (ด้านหลัง)
    public float height = 0.61f; // ความสูงของกล้องจากพื้น

    private void LateUpdate()
    {
        Vector3 behindPosition = playerHead.position - playerHead.forward * distanceBehind;
        behindPosition.y = playerHead.position.y + height;
        transform.position = behindPosition;
        transform.LookAt(playerHead);
    }
}