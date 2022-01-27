using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TeleportMinigame : MonoBehaviour
{
    private Vector3 respawnPosition;
    private GameObject floorOfDeath;
    private bool spremanZaTeleport = false;
    public PlayerMovement playerMovement;
    private bool cekajMalo = false;
    private bool spremanZaPovratak = false;
    private GameObject gumbSpasa;
    private Vector3 returningPosition;
    private bool rutinaZaPovratak = false;
    static public bool Won = false;
    public Canvas Cnv;
    private bool winonce = false;

    // Start is called before the first frame update
    void Start()
    {

        Won = false;
        respawnPosition = new Vector3(31.2479992f, 1.03999996f, 9.46700001f);
        returningPosition = new Vector3(5.30499983f, 1.35000002f, 5.01000023f);

        floorOfDeath = GameObject.Find("PodSmrti");
        gumbSpasa = GameObject.Find("GumbSpasa");
        playerMovement = gameObject.GetComponent<PlayerMovement>();
        cekajMalo = false;
        spremanZaTeleport = true;



        if (!cekajMalo)
        {
            if (spremanZaTeleport)
            {
                StartCoroutine("Teleport");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (this.transform.position.y < -1000)
        {
            StartCoroutine("Teleport");
        }
        if (!cekajMalo) {
            if (spremanZaTeleport)
            {
                StartCoroutine("Teleport");

            }
        }
        if (!rutinaZaPovratak)
        {
            if (spremanZaPovratak)
            {
                Won = true;
                if (winonce == false) { 
                Cnv.transform.GetChild(6).gameObject.GetComponent<Text>().text = Cnv.transform.GetChild(6).gameObject.GetComponent<Text>().text + " 33";
                    winonce = true;
            }
                StartCoroutine("TeleportBack");


            }
        }
    }

     void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.Equals(gumbSpasa))
        {
            spremanZaPovratak = true;
        }


        if (other.gameObject.Equals(floorOfDeath))
            {
                spremanZaTeleport = true;
            }
    }

    IEnumerator TeleportBack()
    {
        cekajMalo = true;
        yield return new WaitForSeconds(0.01f);
        playerMovement.disabled = true;
        yield return new WaitForSeconds(0.01f);
        playerMovement.disabled = false;
        yield return new WaitForSeconds(0.01f);
        gameObject.transform.position = returningPosition;
        yield return new WaitForSeconds(0.01f);
        spremanZaPovratak = false;
        yield return new WaitForSeconds(0.01f);
        rutinaZaPovratak = false;
        yield return new WaitForSeconds(0.01f);
        GetComponent<TeleportMinigame>().enabled = false;
        yield return new WaitForSeconds(0.01f);
        GameObject.Find("SoundManager").GetComponent<AudioSource>().Stop();
        SoundManagerScript.PlaySound("glass1");
    }
    IEnumerator Teleport() {
        cekajMalo = true;
        yield return new WaitForSeconds(0.01f);
        playerMovement.disabled = true;
        yield return new WaitForSeconds(0.01f);
        gameObject.transform.position = respawnPosition;

        yield return new WaitForSeconds(0.01f);

        spremanZaTeleport = false;
        yield return new WaitForSeconds(0.01f);

        playerMovement.disabled = false;
        yield return new WaitForSeconds(0.01f);
        cekajMalo = false;
    }

    IEnumerator StartTeleport()
    {
        yield return new WaitForSeconds(0.01f);
        playerMovement.disabled = true;
        yield return new WaitForSeconds(0.01f);
        gameObject.transform.position = respawnPosition;
        yield return new WaitForSeconds(0.01f);
        playerMovement.disabled = false;
    }
}
