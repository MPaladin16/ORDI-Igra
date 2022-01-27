using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CounterGame : MonoBehaviour
{


    public static bool won = false;
    public bool winonce = false;
    public InputField iField;
    private string code;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (won == false)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            GameObject.Find("CanvasCounter").gameObject.transform.GetChild(1).gameObject.SetActive(true);
        }
        code = iField.text;
        if (code == "6636")
        {
            won = true;
            
        }

        if (code == "t")
        {
            code = "";
        }

        if (Input.GetKeyDown("t")) {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            GameObject.Find("First Person Player").gameObject.GetComponent<PlayerMovement>().enabled = true;
            GameObject.Find("First Person Player").gameObject.transform.GetChild(1)
                .GetComponent<MouseLook>().enabled = true;
            GameObject.Find("CanvasCounter").gameObject.transform.GetChild(0).gameObject.SetActive(false);
            GameObject.Find("CanvasCounter").gameObject.transform.GetChild(1).gameObject.SetActive(false);
            GameObject.Find("skripte").gameObject.GetComponent<CounterGame>().enabled = false;

            GameObject.Find("SoundManager").GetComponent<AudioSource>().Stop();
        }

        if (won == true && winonce== false) {
            winonce = true;
            GameObject.Find("Canvas").gameObject.transform.GetChild(6).gameObject.GetComponent<Text>().text = GameObject.Find("Canvas").gameObject.transform.GetChild(6).gameObject.GetComponent<Text>().text + "57";
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(false);
            GameObject.Find("Counter-minigame").gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material.color = Color.green;
            GameObject.Find("First Person Player").gameObject.GetComponent<PlayerMovement>().enabled = true;
            GameObject.Find("First Person Player").gameObject.transform.GetChild(1)
                .GetComponent<MouseLook>().enabled = true;
            GameObject.Find("CanvasCounter").gameObject.transform.GetChild(0).gameObject.SetActive(false);
            GameObject.Find("CanvasCounter").gameObject.transform.GetChild(1).gameObject.SetActive(false);
        }
    }
}
