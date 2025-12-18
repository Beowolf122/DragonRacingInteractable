using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class OnButtonDown : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Image ScreenSplat;
    public float Timer=0;
    public Vector3 Inscreen = new Vector3(0,0,0);
    public Vector3 Offscreen= new Vector3(1000,0,0);
    
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Timer-= Time.deltaTime;
        if (Timer < 0) { ScreenSplat.enabled = false; }
        else { ScreenSplat.enabled = true; }
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        
        Timer = 10f;
        ScreenSplat.enabled=true;
    }
    public void OnMouseDown()
    {
        Timer = 10f;
        ScreenSplat.enabled = true;
    }
}
