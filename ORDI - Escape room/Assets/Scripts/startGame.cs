using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class startGame : MonoBehaviour
{
    public Button Btn;
    public Button EBtn;
    // Start is called before the first frame update
    void Start()
    {
        Btn.onClick.AddListener(start);
        EBtn.onClick.AddListener(exit);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("s")) {

            Application.LoadLevel("Escape Rooms");
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("App quit");
            Application.Quit();            
        }

    }
    void start() {
        Application.LoadLevel("Escape Rooms");
    }
   void exit()
    {
        Debug.Log("App quit");
        Application.Quit();
    }
}
