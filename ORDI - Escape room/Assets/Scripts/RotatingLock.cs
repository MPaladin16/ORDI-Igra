using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotatingLock : MonoBehaviour
{
    // Start is called before the first frame update

    public List<Button> clickButtons;
    public List<Button> rotatingButtons;
    public Canvas CanvasLock;
    public static bool won = false;

    public Button pom;
    void Start()
    {
        Button button0 = CanvasLock.transform.GetChild(1).gameObject.GetComponent<Button>();
        Button button1 = CanvasLock.transform.GetChild(2).gameObject.GetComponent<Button>();
        Button button2 = CanvasLock.transform.GetChild(3).gameObject.GetComponent<Button>();
        Button button3 = CanvasLock.transform.GetChild(4).gameObject.GetComponent<Button>();
        Button button4 = CanvasLock.transform.GetChild(5).gameObject.GetComponent<Button>();
        Button button5 = CanvasLock.transform.GetChild(6).gameObject.GetComponent<Button>();
        Button button6 = CanvasLock.transform.GetChild(7).gameObject.GetComponent<Button>();
        Button button7 = CanvasLock.transform.GetChild(8).gameObject.GetComponent<Button>();
        Button button8 = CanvasLock.transform.GetChild(9).gameObject.GetComponent<Button>();
        Button button9 = CanvasLock.transform.GetChild(10).gameObject.GetComponent<Button>();
        Button button10 = CanvasLock.transform.GetChild(11).gameObject.GetComponent<Button>();
        Button button11 = CanvasLock.transform.GetChild(12).gameObject.GetComponent<Button>();
        Button button12 = CanvasLock.transform.GetChild(13).gameObject.GetComponent<Button>();
        Button button13 = CanvasLock.transform.GetChild(14).gameObject.GetComponent<Button>();
        Button button14 = CanvasLock.transform.GetChild(15).gameObject.GetComponent<Button>();
        Button button15 = CanvasLock.transform.GetChild(16).gameObject.GetComponent<Button>();
        Button button16 = CanvasLock.transform.GetChild(17).gameObject.GetComponent<Button>();
        Button button17 = CanvasLock.transform.GetChild(18).gameObject.GetComponent<Button>();
        Button button18 = CanvasLock.transform.GetChild(19).gameObject.GetComponent<Button>();
        Button button19 = CanvasLock.transform.GetChild(20).gameObject.GetComponent<Button>();
        Button button20 = CanvasLock.transform.GetChild(21).gameObject.GetComponent<Button>();


        clickButtons.Add(button0);
        clickButtons.Add(button1);
        clickButtons.Add(button2);
        rotatingButtons.Add(button3);
        rotatingButtons.Add(button4);
        rotatingButtons.Add(button5);
        rotatingButtons.Add(button6);
        rotatingButtons.Add(button7);
        rotatingButtons.Add(button8);
        rotatingButtons.Add(button9);
        rotatingButtons.Add(button10);
        rotatingButtons.Add(button11);
        rotatingButtons.Add(button12);
        rotatingButtons.Add(button13);
        rotatingButtons.Add(button14);
        rotatingButtons.Add(button15);
        rotatingButtons.Add(button16);
        rotatingButtons.Add(button17);
        rotatingButtons.Add(button18);
        rotatingButtons.Add(button19);
        rotatingButtons.Add(button20);

        foreach (Button btn in rotatingButtons)
        {
            Debug.Log(btn.name);
            btn.GetComponent<Image>().color = Color.red;
        }
        button8.GetComponent<Image>().color = Color.green;
        button7.GetComponent<Image>().color = Color.green;
        button10.GetComponent<Image>().color = Color.green;
        button12.GetComponent<Image>().color = Color.green;
        button14.GetComponent<Image>().color = Color.green;
        button4.GetComponent<Image>().color = Color.green;
        button15.GetComponent<Image>().color = Color.green;
        button17.GetComponent<Image>().color = Color.green;


        button0.onClick.AddListener(BtnClick1);
        button1.onClick.AddListener(BtnClick2);
        button2.onClick.AddListener(BtnClick3);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("t"))
        {
            GameObject.Find("First Person Player").gameObject.GetComponent<PlayerMovement>().enabled = true;
            GameObject.Find("First Person Player").gameObject.transform.GetChild(1)
                .GetComponent<MouseLook>().enabled = true;
            CanvasLock.gameObject.SetActive(false);


        }

        if (rotatingButtons[7].GetComponent<Image>().color == Color.green &&
            rotatingButtons[10].GetComponent<Image>().color == Color.green &&
            rotatingButtons[11].GetComponent<Image>().color == Color.green &&
            rotatingButtons[13].GetComponent<Image>().color == Color.green &&
                rotatingButtons[14].GetComponent<Image>().color == Color.green &&
                rotatingButtons[15].GetComponent<Image>().color == Color.green &&
                rotatingButtons[16].GetComponent<Image>().color == Color.green &&
                rotatingButtons[17].GetComponent<Image>().color == Color.green) {
                    won = true;
            GameObject.Find("Canvas").gameObject.transform.GetChild(6).gameObject.GetComponent<Text>().text = GameObject.Find("Canvas").gameObject.transform.GetChild(6).gameObject.GetComponent<Text>().text + "12";

            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            GameObject.Find("First Person Player").gameObject.GetComponent<PlayerMovement>().enabled = true;
            GameObject.Find("First Person Player").gameObject.transform.GetChild(1).GetComponent<MouseLook>().enabled = true;
            CanvasLock.gameObject.SetActive(false);
            this.gameObject.SetActive(false);
        }
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

    }
    public void BtnClick1(){
        pom.GetComponent<Image>().color = rotatingButtons[1].GetComponent<Image>().color;
        rotatingButtons[1].GetComponent<Image>().color = rotatingButtons[5].GetComponent<Image>().color;
        rotatingButtons[5].GetComponent<Image>().color = rotatingButtons[8].GetComponent<Image>().color;
        rotatingButtons[8].GetComponent<Image>().color = rotatingButtons[12].GetComponent<Image>().color;
        rotatingButtons[12].GetComponent<Image>().color = rotatingButtons[14].GetComponent<Image>().color;
        rotatingButtons[14].GetComponent<Image>().color = rotatingButtons[11].GetComponent<Image>().color;
        rotatingButtons[11].GetComponent<Image>().color = rotatingButtons[7].GetComponent<Image>().color;
        rotatingButtons[7].GetComponent<Image>().color = rotatingButtons[4].GetComponent<Image>().color;
        rotatingButtons[4].GetComponent<Image>().color = pom.GetComponent<Image>().color;
    }
    public void BtnClick2()
    {

        pom.GetComponent<Image>().color = rotatingButtons[0].GetComponent<Image>().color;
        rotatingButtons[0].GetComponent<Image>().color = rotatingButtons[3].GetComponent<Image>().color;
        rotatingButtons[3].GetComponent<Image>().color = rotatingButtons[7].GetComponent<Image>().color;
        rotatingButtons[7].GetComponent<Image>().color = rotatingButtons[10].GetComponent<Image>().color;
        rotatingButtons[10].GetComponent<Image>().color = rotatingButtons[13].GetComponent<Image>().color;
        rotatingButtons[13].GetComponent<Image>().color = rotatingButtons[9].GetComponent<Image>().color;
        rotatingButtons[9].GetComponent<Image>().color = rotatingButtons[6].GetComponent<Image>().color;
        rotatingButtons[6].GetComponent<Image>().color = rotatingButtons[2].GetComponent<Image>().color;
        rotatingButtons[2].GetComponent<Image>().color = pom.GetComponent<Image>().color;
    }
    public void BtnClick3()
    {
        pom.GetComponent<Image>().color = rotatingButtons[11].GetComponent<Image>().color;
        rotatingButtons[11].GetComponent<Image>().color = rotatingButtons[14].GetComponent<Image>().color;
        rotatingButtons[14].GetComponent<Image>().color = rotatingButtons[16].GetComponent<Image>().color;
        rotatingButtons[16].GetComponent<Image>().color = rotatingButtons[17].GetComponent<Image>().color;
        rotatingButtons[17].GetComponent<Image>().color = rotatingButtons[15].GetComponent<Image>().color;
        rotatingButtons[15].GetComponent<Image>().color = rotatingButtons[13].GetComponent<Image>().color;
        rotatingButtons[13].GetComponent<Image>().color = rotatingButtons[10].GetComponent<Image>().color;
        rotatingButtons[10].GetComponent<Image>().color = rotatingButtons[7].GetComponent<Image>().color;
        rotatingButtons[7].GetComponent<Image>().color = pom.GetComponent<Image>().color;
    }
}
