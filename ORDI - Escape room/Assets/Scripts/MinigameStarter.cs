using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using UnityEngine.SceneManagement;

public class MinigameStarter : MonoBehaviour
{
    public Canvas Canvas1;
    public Canvas Canvas2;
    public Canvas Canvas3;
    public Canvas InfoCanvas;
    public Canvas CanvasMenu;
    public Canvas CanvasEnd;
    public Canvas CanvasMain;
    public Canvas CanvasLock;
    public Canvas CanvasTouch;
    public Canvas KeyPadCanvas;
    public GameObject Minigame1;
    public GameObject Minigame2;
    public GameObject Minigame3;
    public GameObject Minigame4;
    public GameObject Minigame5;
    private bool allFalse = true;

    private bool doorsOpen1 = false;
    private bool doorsOpen2 = false;
    private bool doorsOpen3 = false;
    public GameObject doors1;
    public GameObject doorsOpened1;
    public GameObject doors2;
    public GameObject doorsOpened2;
    public GameObject doors3;
    public GameObject doorsOpened3;



    private bool entered1 = false;
    private bool entered2 = false;
    private bool entered3 = false;
    private bool entered4 = false;
    private bool entered5 = false;
    private bool menuOpened = false;
    private bool keypad = false;
    private bool Last = false;

    private List<bool> info = new List<bool>();

    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("skripte").gameObject.GetComponent<DotGame>().enabled = false;
        GameObject.Find("skripte").gameObject.GetComponent<CounterGame>().enabled = false;
        GameObject.Find("skripte").gameObject.GetComponent<DodgeGame>().enabled = false;
        GameObject.Find("Dot-Minigame-Start").gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material.color = Color.red;
        GameObject.Find("Counter-minigame").gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material.color = Color.red;
        GameObject.Find("Dodge-minigame").gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material.color = Color.red;
        GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(false);
        foreach (int value in Enumerable.Range(1, 15))
        {
            info.Add(false);
        }
    }

    // Update is called once per frame
    void Update()
    {

        //Doors

        if (CounterGame.won && doorsOpen1 == false && TeleportMinigame.Won && KeyPad.won1) {
            doorsOpen1 = true;
            doors1.gameObject.SetActive(false);
            doorsOpened1.gameObject.SetActive(true);
        }
        if (DotGame.won && doorsOpen2 == false && LabGameMovePlayer.won)
        {
            doorsOpen2 = true;
            doors2.gameObject.SetActive(false);
            doorsOpened2.gameObject.SetActive(true);
        }
        if (MovePlayer.won && doorsOpen3 == false && RotatingLock.won && KeyPad.won2)
        {
            doorsOpen3 = true;
            doors3.gameObject.SetActive(false);
            doorsOpened3.gameObject.SetActive(false);
        }





        //Inspect

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        if (entered1 == true && Input.GetKeyDown("e")) {
            GetComponent<PlayerMovement>().enabled = false;
            this.transform.GetChild(1).GetComponent<MouseLook>().enabled = false;
            GameObject.Find("skripte").gameObject.GetComponent<DotGame>().enabled = true;
            GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(false);
            Canvas1.gameObject.SetActive(true);

            int ranNum = Random.Range(1, 4);
            string ranDots = "dots" + ranNum.ToString();
            GameObject.Find("SoundManager").GetComponent<AudioSource>().Stop();
            SoundManagerScript.PlaySound(ranDots);
        }

        foreach (bool b in info)
        {
            if (b)
            {
                allFalse = false;
                break;
            }
            else
            {
                allFalse = true;
            }
        }
        if (Input.GetKeyDown(KeyCode.Escape) && menuOpened == false &&
            entered1 == false && entered2 == false && entered3 == false &&
            allFalse == true
            ) {
            GetComponent<PlayerMovement>().enabled = false;
            this.transform.GetChild(1).GetComponent<MouseLook>().enabled = false;
            menuOpened = true;
            CanvasMenu.gameObject.SetActive(true);
            CanvasMenu.gameObject.transform.GetChild(0).gameObject.SetActive(true);
            CanvasMenu.gameObject.transform.GetChild(1).gameObject.SetActive(true);
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }


        if (entered2 == true && Input.GetKeyDown("e"))
        {
            GetComponent<PlayerMovement>().enabled = false;
            this.transform.GetChild(1).GetComponent<MouseLook>().enabled = false;
            GameObject.Find("skripte").gameObject.GetComponent<CounterGame>().enabled = true;
            GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(false);
            Canvas2.gameObject.transform.GetChild(0).gameObject.SetActive(true);
            Canvas2.gameObject.transform.GetChild(1).gameObject.SetActive(true);

            int ranNum = Random.Range(1, 4);
            string ranCount = "count" + ranNum.ToString();

            GameObject.Find("SoundManager").GetComponent<AudioSource>().Stop();
            SoundManagerScript.PlaySound(ranCount);

        }

        if (Last == true && Input.GetKeyDown("e")) {

            KeyPadCanvas.gameObject.SetActive(true);
            KeyPadCanvas.gameObject.transform.GetComponent<KeyPad>().enabled = true;
            GetComponent<PlayerMovement>().enabled = false;
            this.transform.GetChild(1).GetComponent<MouseLook>().enabled = false;
            GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(false);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;

        }

        if (entered3 == true && Input.GetKeyDown("e"))
        {
            GetComponent<PlayerMovement>().enabled = false;
            this.transform.GetChild(1).GetComponent<MouseLook>().enabled = false;
            GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(false);
            Canvas3.gameObject.transform.GetChild(3).GetComponent<MovePlayer>().enabled = true;
            Canvas3.gameObject.SetActive(true);

            GameObject.Find("SoundManager").GetComponent<AudioSource>().Stop();
            SoundManagerScript.PlaySound("boxes1");
        }
        if (entered4 == true && Input.GetKeyDown("e"))
        {
            GetComponent<PlayerMovement>().enabled = false;
            this.transform.GetChild(1).GetComponent<MouseLook>().enabled = false;
            GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(false);
            CanvasLock.gameObject.SetActive(true);

            GameObject.Find("SoundManager").GetComponent<AudioSource>().Stop();
            SoundManagerScript.PlaySound("server3");
        }

        if (entered5 == true && Input.GetKeyDown("e") && LabGameMovePlayer.won == false)
        {
            GetComponent<PlayerMovement>().enabled = false;
            this.transform.GetChild(1).GetComponent<MouseLook>().enabled = false;
            GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(false);
            CanvasTouch.gameObject.SetActive(true);

            GameObject.Find("SoundManager").GetComponent<AudioSource>().Stop();
            //sound za taj game
        }

        if (Input.GetKeyDown("e") && info[5]== true)
        {
            if (TeleportMinigame.Won == false)
            {
                GetComponent<TeleportMinigame>().enabled = true;

                GameObject.Find("SoundManager").GetComponent<AudioSource>().Stop();
                SoundManagerScript.PlaySound("glass2");
            }
        }


            foreach (int value in Enumerable.Range(1, 15)) {
            if (info[value - 1] == true && Input.GetKeyDown("t"))
            {
                GetComponent<PlayerMovement>().enabled = true;
                this.transform.GetChild(1).GetComponent<MouseLook>().enabled = true;
                GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(true);
                InfoCanvas.gameObject.transform.GetChild(value).gameObject.SetActive(false);
                KeyPadCanvas.gameObject.SetActive(false);
                KeyPadCanvas.gameObject.transform.GetComponent<KeyPad>().enabled = false;
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
            }

            if (info[value - 1] == true && Input.GetKeyDown("e"))
            {
                if (info[5] == true && TeleportMinigame.Won == false) { }
                else
                {
                    if (info[10] == true &&
                        !KeyPad.won1)
                    { //keypad

                        KeyPadCanvas.gameObject.SetActive(true);
                        KeyPadCanvas.gameObject.transform.GetComponent<KeyPad>().enabled = true;
                        GetComponent<PlayerMovement>().enabled = false;
                        this.transform.GetChild(1).GetComponent<MouseLook>().enabled = false;
                        GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(false);
                        Cursor.visible = true;
                        Cursor.lockState = CursorLockMode.None;


                    }
                    else
                    {
                        info[10] = false;
                        GetComponent<PlayerMovement>().enabled = false;
                        this.transform.GetChild(1).GetComponent<MouseLook>().enabled = false;
                        GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(false);
                        if (value != 11) { 
                        InfoCanvas.gameObject.transform.GetChild(value).gameObject.SetActive(true);
                    }
                }
                }
            }


        }

        if (Input.GetKeyDown("r") && menuOpened == true)
        {
            GetComponent<PlayerMovement>().enabled = true;
            this.transform.GetChild(1).GetComponent<MouseLook>().enabled = true;
            menuOpened = false;
            CanvasMenu.gameObject.SetActive(false);
            CanvasMenu.gameObject.transform.GetChild(0).gameObject.SetActive(false);
            CanvasMenu.gameObject.transform.GetChild(1).gameObject.SetActive(false);
        }
        if (Input.GetKeyDown("x") && menuOpened == true)
        {
            GetComponent<PlayerMovement>().enabled = false;
            this.transform.GetChild(1).GetComponent<MouseLook>().enabled = false;
            menuOpened = false;
            Application.LoadLevel("Start");
        }



    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "EndGame") {
            CanvasEnd.gameObject.SetActive(true);

            CanvasEnd.gameObject.transform.GetChild(1).gameObject.transform.GetChild(0).gameObject.transform.GetComponent<Text>().text = CanvasEnd.gameObject.transform.GetChild(1).gameObject.transform.GetChild(0).gameObject.transform.GetComponent<Text>().text +
                "\n" + "Your Score is" + "\n" + CanvasMain.gameObject.transform.GetChild(2).gameObject.GetComponent<Text>().text;

            CanvasMain.GetComponent<Timer>().enabled = false;
            
        }
        if (other.gameObject == Minigame1 && DotGame.won == false)
        {
            GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(true);
            entered1 = true;

        }
        if (other.gameObject == Minigame2 && CounterGame.won == false)
        {
            GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(true);
            entered2 = true;
        }

        if (other.gameObject == Minigame3 && MovePlayer.won == false)
        {
            GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(true);
            entered3 = true;
        }
        if (other.gameObject == Minigame4 && RotatingLock.won == false)
        {
            GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(true);
            entered4 = true;
        }
        if (other.gameObject == Minigame5 && LabGameMovePlayer.won == false)
        {
            GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(true);
            entered5 = true;
        }
        if (other.gameObject.name.Contains("axe")) {
            GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(true);
            info[0] = true;
        }
        if (other.gameObject.name.Contains("shield"))
        {
            GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(true);
            info[1] = true;
        }
        if (other.gameObject.name.Contains("glass"))
        {
            GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(true);
            info[2] = true;
        }
        if (other.gameObject.name.Contains("jug"))
        {
            GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(true);
            info[3] = true;
        }
        if (other.gameObject.name.Contains("Plate"))
        {
            GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(true);
            info[4] = true;
        }
        if (other.gameObject.name.Contains("bookcase"))
        {
 
            GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(true);
            info[5] = true;
        }
       
        if (other.gameObject.name.Contains("Fireplace"))
        {
            GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(true);
            info[6] = true;
        }
        if (other.gameObject.name.Contains("Curtain"))
        {
            GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(true);
            info[7] = true;
        }
        if (other.gameObject.name.Contains("Flower"))
        {
            GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(true);
            info[8] = true;
        }
        if (other.gameObject.name.Contains("Stove"))
        {
            GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(true);
            info[9] = true;
        }
        if (other.gameObject.name.Contains("door1"))
        {
            GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(true);
            info[10] = true;
        }
        if (other.gameObject.name.Contains("display"))
        {
            GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(true);
            info[11] = true;
        }
        if (other.gameObject.name.Contains("pc"))
        {
            GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(true);
            info[12] = true;
        }
        if (other.gameObject.name.Contains("server"))
        {
            GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(true);
            info[13] = true;
        }
        if (other.gameObject.name.Contains("fire_"))
        {
            GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(true);
            info[14] = true;
        }
        if (other.gameObject.name.Contains("tabletLast"))
        {
            GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(true);
            Last = true;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == Minigame1)
        {
            GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(false);
            entered1 = false;
        }
        if (other.gameObject == Minigame2)
        {
            GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(false);
            GameObject.Find("CanvasCounter").gameObject.transform.GetChild(1).gameObject.SetActive(false);
            entered2 = false;
        }
        if(other.gameObject == Minigame3)
        {
            GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(false);
            Canvas3.gameObject.SetActive(false);
            entered3 = false;
        }
        if (other.gameObject == Minigame4)
        {
            GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(false);
            Canvas3.gameObject.SetActive(false);
            entered4 = false;
        }
        if (other.gameObject == Minigame5)
        {
            GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(false);
            Canvas3.gameObject.SetActive(false);
            entered5 = false;
        }
        if (other.gameObject.name.Contains("axe"))
        {
            GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(false);
            info[0] = false;
        }
        if (other.gameObject.name.Contains("shield"))
        {
            GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(false);
            info[1] = false;
        }
        if (other.gameObject.name.Contains("glass"))
        {
            GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(false);
            info[2] = false;
        }
        if (other.gameObject.name.Contains("jug"))
        {
            GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(false);
            info[3] = false;
        }
        if (other.gameObject.name.Contains("Plate"))
        {
            GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(false);
            info[4] = false;
        }
        if (other.gameObject.name.Contains("bookcase"))
        {
            GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(false);
            info[5] = false;
        }
        if (other.gameObject.name.Contains("Fireplace"))
        {
            GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(false);
            info[6] = false;
        }
        if (other.gameObject.name.Contains("Curtain"))
        {
            GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(false);
            info[7] = false;
        }
        if (other.gameObject.name.Contains("Flower"))
        {
            GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(false);
            info[8] = false;
        }
        if (other.gameObject.name.Contains("Stove"))
        {
            GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(false);
            info[9] = false;
        }
        if (other.gameObject.name.Contains("door1"))
        {
            GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(false);
            info[10] = false;
        }
        if (other.gameObject.name.Contains("display"))
        {
            GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(false);
            info[11] = false;
        }
        if (other.gameObject.name.Contains("pc"))
        {
            GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(false);
            info[12] = false;
        }
        if (other.gameObject.name.Contains("server"))
        {
            GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(false);
            info[13] = false;
        }
        if (other.gameObject.name.Contains("fire_"))
        {
            GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(false);
            info[14] = false;
        }
        if (other.gameObject.name.Contains("tabletLast"))
        {
            GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(false);
            Last = false;
        }
    }


}