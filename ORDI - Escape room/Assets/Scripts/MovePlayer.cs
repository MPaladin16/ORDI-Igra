using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovePlayer : MonoBehaviour
{
    RectTransform canvas;
    RectTransform button;
    Vector3 startingPosition;
    public float speed;

    public static bool won = false;
    public bool winonce = false;

    bool usedButtonVoiceLine = false;
    bool usedWallVoiceLine = false;


    void Start()
    {
        button = gameObject.GetComponent<RectTransform>();
        canvas = GameObject.Find("CanvasLab").GetComponent<RectTransform>();
        startingPosition = transform.position;
        speed = 3f;
        GameObject.Find("First Person Player").gameObject.GetComponent<PlayerMovement>().enabled = false;
        GameObject.Find("First Person Player").gameObject.transform.GetChild(1)
            .GetComponent<MouseLook>().enabled = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown("t"))
        {
            GameObject.Find("Dodge-minigame").gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material.color = Color.red;
            GameObject.Find("First Person Player").gameObject.GetComponent<PlayerMovement>().enabled = true;
            GameObject.Find("First Person Player").gameObject.transform.GetChild(1)
                .GetComponent<MouseLook>().enabled = true;
            GameObject.Find("CanvasLab").gameObject.SetActive(false);
            gameObject.GetComponent<MovePlayer>().enabled = false;

        }
        if (won == true && winonce == false)
        {
            winonce = true;
            if (GameObject.Find("Canvas").gameObject.transform.GetChild(6).gameObject.GetComponent<Text>().text.Equals("12")) {
                GameObject.Find("Canvas").gameObject.transform.GetChild(6).gameObject.GetComponent<Text>().text = "3412";
            } else {
                GameObject.Find("Canvas").gameObject.transform.GetChild(6).gameObject.GetComponent<Text>().text = GameObject.Find("Canvas").gameObject.transform.GetChild(6).gameObject.GetComponent<Text>().text + "34";
            }

            GameObject.Find("Dodge-minigame").gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material.color = Color.green;
            GameObject.Find("First Person Player").gameObject.GetComponent<PlayerMovement>().enabled = true;
            GameObject.Find("First Person Player").gameObject.transform.GetChild(1)
                .GetComponent<MouseLook>().enabled = true;
            GameObject.Find("CanvasLab").gameObject.SetActive(false);
            gameObject.GetComponent<MovePlayer>().enabled = false;

        }
    }

    void FixedUpdate()
    {


         if(Input.GetKey("w"))
        {
            transform.position = new Vector3(transform.position.x,
                transform.position.y + speed, transform.position.z);
        }
        if (Input.GetKey("s"))
        {
            transform.position = new Vector3(transform.position.x,
                transform.position.y - speed, transform.position.z);
        }
        if (Input.GetKey("a"))
        {
            transform.position = new Vector3(transform.position.x - speed,
                transform.position.y,  transform.position.z);
        }
        if (Input.GetKey("d"))
        {
            transform.position = new Vector3(transform.position.x + speed,
                transform.position.y, transform.position.z);
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.name == "Win")
        {
            won = true;
        }
        if (col.name.Contains("Button")) {
            transform.position = startingPosition;

            if (!usedButtonVoiceLine) {
                GameObject.Find("SoundManager").GetComponent<AudioSource>().Stop();
                SoundManagerScript.PlaySound("boxes2");
                usedButtonVoiceLine = true;
            }

        } else if(col.name.Contains("Wal")) {
            transform.position = startingPosition;
            if (!usedWallVoiceLine) {
                GameObject.Find("SoundManager").GetComponent<AudioSource>().Stop();
                SoundManagerScript.PlaySound("boxes3");
                usedWallVoiceLine = true;
            }

        }
       
    }
}