using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float initialTime;
    public GameObject Num;
    private bool started = false;
    public float StartTime = 400;
    public float TimePerLvl = 60;
    private float StartTimeTxt;
    public static bool AddFirst = false;
    public static bool AddSecond = false;
    public Canvas CanvasMain, CanvasEnd, CanvasLab;
    public static bool completed = false;
    public static int roomsCompleted = 0;

    int generalVoiceLineNumber;
    // Start is called before the first frame update
    void Start()
    {
        Num = this.gameObject.transform.GetChild(2).gameObject;
        AddFirst = true;
        AddSecond = true;

        generalVoiceLineNumber = 1;
        InvokeRepeating("PlayClipAndChange", 60.0f, 35.0f);
    }

    void PlayClipAndChange()
    {
        if (generalVoiceLineNumber < 21 && !GameObject.Find("SoundManager").GetComponent<AudioSource>().isPlaying)
        {
            string name = "general" + generalVoiceLineNumber.ToString();
            generalVoiceLineNumber++;
            GameObject.Find("SoundManager").GetComponent<AudioSource>().Stop();
            SoundManagerScript.PlaySound(name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w") || Input.GetKeyDown("s") || Input.GetKeyDown("a") || Input.GetKeyDown("d") || Input.GetKeyDown("x")) {
            if (started == false) {
                initialTime = Time.time; }
            started = true;
        }
        if (started == true && !(StartTimeTxt < 0) && !completed)
        {
            float TimeTaken = Time.time - initialTime;
            StartTimeTxt = StartTime - TimeTaken + roomsCompleted * TimePerLvl;
            Num.GetComponent<Text>().text = StartTimeTxt.ToString("f2");
        }
        // Debug.Log(AddFirst);
        if (DotGame.won && roomsCompleted == 1 && LabGameMovePlayer.won) {
            roomsCompleted = roomsCompleted + 1;
            StartTimeTxt = StartTimeTxt + TimePerLvl;
            AddFirst = false; }

        if (CounterGame.won && roomsCompleted == 1 && TeleportMinigame.Won) {
            StartTimeTxt = StartTimeTxt + TimePerLvl;
            AddSecond = false;
        }

        if (StartTimeTxt < 0) {
            CanvasEnd.gameObject.SetActive(true);

            CanvasEnd.gameObject.transform.GetChild(1).gameObject.transform.GetChild(0).gameObject.transform.GetComponent<Text>().text =
                "\n" + "Game Over!" + "\n \n" + "I guess you suck!" + "\n \n" + "X to Exit";
            
            GameObject.Find("First Person Player").gameObject.GetComponent<PlayerMovement>().enabled = false;
            GameObject.Find("First Person Player").gameObject.transform.GetChild(1)
                .GetComponent<MouseLook>().enabled = false;

            CanvasLab.gameObject.transform.GetChild(3).gameObject.GetComponent<MovePlayer>().enabled = false;
            GameObject.Find("skripte").gameObject.GetComponent<DotGame>().enabled = false;
            GameObject.Find("skripte").gameObject.GetComponent<CounterGame>().enabled = false;
            if (Input.GetKeyDown("x")) {

                Application.LoadLevel("Start");
            }
        }
    }
}
