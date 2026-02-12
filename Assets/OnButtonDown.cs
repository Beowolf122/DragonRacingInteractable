using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class OnButtonDown : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Image ScreenSplat;
    Shift shift;
    public float Timer=0;
    OnButtonDown onButtonDown;
    
    void Start()
    {
        shift = FindFirstObjectByType<Shift>();
        onButtonDown = GetComponent<OnButtonDown>();
    }

    // Update is called once per frame
    void Update()
    {
        Timer-= Time.deltaTime;
        if (Timer < 0) {
        shift.Inscreen = false;
        }
        else { 
        shift.Inscreen = true;
        }
        
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        
        Timer = 10f;
        shift.Inscreen =true;
        Debug.Log("PointerClicked");
    }
    public void OnMouseDown()
    {
        Timer = 10f;
        shift.Inscreen = true;
        Debug.Log("MouseClicked");
    }
    public void OnButtonClick() {
        Timer = 10f;
        shift.Inscreen = true;
        Debug.Log("MouseClicked");
    }

}
