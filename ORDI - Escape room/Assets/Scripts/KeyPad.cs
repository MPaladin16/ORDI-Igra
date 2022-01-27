using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyPad : MonoBehaviour
{

    public List<Button> btns;
    private InputField iField;
    public static bool won1 = false;
    public static bool won2 = false;
    // Start is called before the first frame update
    void Start()
    {
        btns.Add(this.gameObject.transform.GetChild(2).gameObject.GetComponent<Button>());
        btns.Add(this.gameObject.transform.GetChild(3).gameObject.GetComponent<Button>());
        btns.Add(this.gameObject.transform.GetChild(4).gameObject.GetComponent<Button>());
        btns.Add(this.gameObject.transform.GetChild(5).gameObject.GetComponent<Button>());
        btns.Add(this.gameObject.transform.GetChild(6).gameObject.GetComponent<Button>());
        btns.Add(this.gameObject.transform.GetChild(7).gameObject.GetComponent<Button>());
        btns.Add(this.gameObject.transform.GetChild(8).gameObject.GetComponent<Button>());
        btns.Add(this.gameObject.transform.GetChild(9).gameObject.GetComponent<Button>());
        btns.Add(this.gameObject.transform.GetChild(10).gameObject.GetComponent<Button>());
        btns.Add(this.gameObject.transform.GetChild(11).gameObject.GetComponent<Button>());
        btns.Add(this.gameObject.transform.GetChild(12).gameObject.GetComponent<Button>());
        this.gameObject.transform.GetChild(13).gameObject.SetActive(false);
        iField = this.gameObject.transform.GetChild(0).gameObject.GetComponent<InputField>();
        won1 = false;
        won2 = false;

        foreach (Button btn in btns)
        {
            btn.GetComponent<Image>().color = Color.black;
            btn.gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().color = Color.white;
            btn.onClick.AddListener(() => Clicked(btn));
        }
    }

    // Update is called once per frame
    void Update()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        if (iField.text.Length == 0) {
            this.gameObject.transform.GetChild(13).gameObject.SetActive(true);
        }
        if (iField.text.Length == 1)
        {
            this.gameObject.transform.GetChild(13).gameObject.SetActive(false);
        }

        if (iField.text.Length == 5) {

            if (iField.text == "3412G" && won2 == false && won1 == true)
            {
                this.gameObject.transform.GetChild(13).gameObject.SetActive(false);
                KeyPad.won2 = true;

                this.gameObject.SetActive(false);
                this.gameObject.transform.GetComponent<KeyPad>().enabled = false;
                GameObject.Find("First Person Player").gameObject.GetComponent<PlayerMovement>().enabled = true;
                GameObject.Find("First Person Player").gameObject.transform.GetChild(1)
                    .GetComponent<MouseLook>().enabled = true;
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
                GameObject.Find("Canvas").gameObject.transform.GetChild(6).gameObject.GetComponent<Text>().text = "";

            }
            else if (won2 == false && won1 == true)
            {
                iField.text = "";
                this.gameObject.transform.GetChild(13).gameObject.SetActive(true);
            }


            if (iField.text == "3357G" && won1 == false)
            {
                this.gameObject.transform.GetChild(13).gameObject.SetActive(false);
                KeyPad.won1 = true;

                this.gameObject.SetActive(false);
                this.gameObject.transform.GetComponent<KeyPad>().enabled = false;
                GameObject.Find("First Person Player").gameObject.GetComponent<PlayerMovement>().enabled = true;
                GameObject.Find("First Person Player").gameObject.transform.GetChild(1)
                    .GetComponent<MouseLook>().enabled = true;
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
                GameObject.Find("Canvas").gameObject.transform.GetChild(6).gameObject.GetComponent<Text>().text = "";


            }
            else if(won1 == false) {
                iField.text = "";
                this.gameObject.transform.GetChild(13).gameObject.SetActive(true);
            }


            
        }
        if (iField.text.Contains("G") && won1 == false) {
            iField.text = "";
            this.gameObject.transform.GetChild(13).gameObject.SetActive(true);
        } 
    }
    private string y;
    void Clicked(Button btn) {
        y = btn.name.Substring(6, 1);
        if (y == "C") {
            iField.text = iField.text.Substring(0, iField.text.Length - 1);
        }
        else { 
        iField.text = iField.text + y; }
    }
}
