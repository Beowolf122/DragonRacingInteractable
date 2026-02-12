using UnityEngine;
using UnityEngine.UIElements;

public class Shift : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Image ScreenSplat;
    public bool Inscreen=false;
    public Vector3 OnScreen = new Vector3(1, 53, 0);
    public Vector3 OffScreen = new Vector3(-1000, 0, 0);
    void Start()
    {
        ScreenSplat = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Inscreen == true) { ScreenSplat.transform.position=OnScreen; }
        else {ScreenSplat.transform.position= OffScreen;
        }
    }
}
