using UnityEngine;
using UnityEngine.UI;


public class Menu_scroll : MonoBehaviour
{
    public float scrollSpeed = 0.5f;
    private RawImage rawImage;

    void Start()
    {
        rawImage = GetComponent<RawImage>();
    }

    void Update()
    {
        Rect uvRect = rawImage.uvRect;
        uvRect.x += scrollSpeed * Time.deltaTime;
        rawImage.uvRect = uvRect;
    }
}
