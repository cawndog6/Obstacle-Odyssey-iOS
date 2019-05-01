using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class TouchController : MonoBehaviour
{
    public UpHandler UpBtn;
    public DownHandler DownBtn;
    public LeftHandler LBtn;
    public RightHandler RBtn;
    // Start is called before the first frame update
    void Start()
    { 

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touches.Length <= 0) //if no touches
        {
            // do nothing
            return;
        }
        else //if the screen is being touched
        {
            if (UpBtn.BeingPressed())
            {
                //Input
            }
            else if (DownBtn.BeingPressed())
            {

            }
            else if(LBtn.BeingPressed())
            {

            }
            else if (RBtn.BeingPressed())
            {

            }
        }
    }
}
