using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DotGame : MonoBehaviour
{
    // Start is called before the first frame update
    public Canvas Canvas; 

    public List<Button> buttons;



    void Start()
    {
        Button button0 = Canvas.transform.GetChild(1).gameObject.GetComponent<Button>();
        Button button1 = Canvas.transform.GetChild(2).gameObject.GetComponent<Button>();
        Button button2 = Canvas.transform.GetChild(3).gameObject.GetComponent<Button>();
        Button button3 = Canvas.transform.GetChild(4).gameObject.GetComponent<Button>();
        Button button4 = Canvas.transform.GetChild(5).gameObject.GetComponent<Button>();
        Button button5 = Canvas.transform.GetChild(8).gameObject.GetComponent<Button>();
        Button button6 = Canvas.transform.GetChild(6).gameObject.GetComponent<Button>();
        Button button7 = Canvas.transform.GetChild(9).gameObject.GetComponent<Button>();
        Button button8 = Canvas.transform.GetChild(7).gameObject.GetComponent<Button>();
        Button button9 = Canvas.transform.GetChild(10).gameObject.GetComponent<Button>();
        Button button10 = Canvas.transform.GetChild(13).gameObject.GetComponent<Button>();
        Button button11 = Canvas.transform.GetChild(11).gameObject.GetComponent<Button>();
        Button button12 = Canvas.transform.GetChild(14).gameObject.GetComponent<Button>();
        Button button13 = Canvas.transform.GetChild(12).gameObject.GetComponent<Button>();
        Button button14 = Canvas.transform.GetChild(15).gameObject.GetComponent<Button>();
        Button button15 = Canvas.transform.GetChild(18).gameObject.GetComponent<Button>();
        Button button16 = Canvas.transform.GetChild(16).gameObject.GetComponent<Button>();
        Button button17 = Canvas.transform.GetChild(19).gameObject.GetComponent<Button>();
        Button button18 = Canvas.transform.GetChild(17).gameObject.GetComponent<Button>();
        Button button19 = Canvas.transform.GetChild(20).gameObject.GetComponent<Button>();
        Button button20 = Canvas.transform.GetChild(23).gameObject.GetComponent<Button>();
        Button button21 = Canvas.transform.GetChild(21).gameObject.GetComponent<Button>();
        Button button22 = Canvas.transform.GetChild(24).gameObject.GetComponent<Button>();
        Button button23 = Canvas.transform.GetChild(22).gameObject.GetComponent<Button>();
        Button button24 = Canvas.transform.GetChild(25).gameObject.GetComponent<Button>();

        buttons.Add(button0);
        buttons.Add(button1);
        buttons.Add(button2);
        buttons.Add(button3);
        buttons.Add(button4);
        buttons.Add(button5);
        buttons.Add(button6);
        buttons.Add(button7);
        buttons.Add(button8);
        buttons.Add(button9);
        buttons.Add(button10);
        buttons.Add(button11);
        buttons.Add(button12);
        buttons.Add(button13);
        buttons.Add(button14);
        buttons.Add(button15);
        buttons.Add(button16);
        buttons.Add(button17);
        buttons.Add(button18);
        buttons.Add(button19);
        buttons.Add(button20);
        buttons.Add(button21);
        buttons.Add(button22);
        buttons.Add(button23);
        buttons.Add(button24);

        foreach (Button btn in buttons)
        {
            btn.GetComponent<Image>().color = Color.red;
            btn.onClick.AddListener(() => ChangeColor(btn));
        }


        int xcount = Random.Range(0, 25);
        ChangeColor(buttons[xcount]);
        xcount = Random.Range(0, 25);
        ChangeColor(buttons[xcount]);
        xcount = Random.Range(0, 25);
        ChangeColor(buttons[xcount]);
        xcount = Random.Range(0, 25);
        ChangeColor(buttons[xcount]);
        xcount = Random.Range(0, 25);
        ChangeColor(buttons[xcount]);
        xcount = Random.Range(0, 25);
        ChangeColor(buttons[xcount]);
        xcount = Random.Range(0, 25);
        ChangeColor(buttons[xcount]);
        xcount = Random.Range(0, 25);
        ChangeColor(buttons[xcount]);
        xcount = Random.Range(0, 25);
        ChangeColor(buttons[xcount]);

    }

    // Update is called once per frame
    void Update()
    {
        int done = 0;
        foreach (Button btn in buttons) {
            if (btn.GetComponent<Image>().color == Color.green) {
                done++;
            }
        }
        if (done == 25)
        {

        }

    }

    void ChangeColor(Button btn)
    {
        int y;
        if (btn.name.Length == 10)
        {
            y = int.Parse(btn.name.Substring(8, 1));
        }
        else {
            y = int.Parse(btn.name.Substring(8, 2));
        }
        if (btn.GetComponent<Image>().color == Color.red)
        {
            btn.GetComponent<Image>().color = Color.green;
        }
        else {
            btn.GetComponent<Image>().color = Color.red;
        }
        if (y > 0)
        {
            if (buttons[y - 1] != null)
            {
                if (buttons[y - 1].GetComponent<Image>().color == Color.red)
                {
                    buttons[y - 1].GetComponent<Image>().color = Color.green;
                }
                else
                {
                    buttons[y - 1].GetComponent<Image>().color = Color.red;
                }
            }
        }
        if (y < 24)
        {
            if (buttons[y + 1] != null)
            {
                if (buttons[y + 1].GetComponent<Image>().color == Color.red)
                {
                    buttons[y + 1].GetComponent<Image>().color = Color.green;
                }
                else
                {
                    buttons[y + 1].GetComponent<Image>().color = Color.red;
                }
            }
        }
        if (y > 4)
        {
            if (buttons[y- 5] != null)
            {
                if (buttons[y - 5].GetComponent<Image>().color == Color.red)
                {
                    buttons[y - 5].GetComponent<Image>().color = Color.green;
                }
                else
                {
                    buttons[y - 5].GetComponent<Image>().color = Color.red;
                }
            }
        }
        if (y < 20) { 
            if (buttons[y + 5] != null)
            {
                if (buttons[y + 5].GetComponent<Image>().color == Color.red)
                {
                    buttons[y + 5].GetComponent<Image>().color = Color.green;
                }
                else
                {
                    buttons[y + 5].GetComponent<Image>().color = Color.red;
                }
            } }



    }

}



