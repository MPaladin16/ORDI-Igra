using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{

    public static AudioClip badEnding1, badEnding2, badEnding3, boxes1,boxes2, boxes3, comeBackMommy, count1, count2, count3, count4, dots1, dots2, dots3, dots4, ending, enteringLowPoly, enteringServer, 
                            general1, general2, general3, general4, general5, general6, general7, general8, general9, general10, 
                            general11, general12, general13, general14, general15, general16, general17, general18, general19, general20, general21,
                            glass1, glass2, goodEnding1, goodEnding2, intro1, intro2, intro3, intro4, intro5, intro6, intro7, intro8, intro9, intro10,
                            lab1, lab2, lowPoly1, lowPoly2, lowPoly3, lowPoly4, lowPolyMusic, medieval1, medieval2, medieval3, medieval4, medieval5, medievalMusic,
                            server1, server2, server3, server4, server5, serverMusic;
    static AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {
        badEnding1 = Resources.Load<AudioClip>("BadEnding1");
        badEnding2 = Resources.Load<AudioClip>("BadEnding2");
        badEnding3 = Resources.Load<AudioClip>("BadEnding3");
        boxes1 = Resources.Load<AudioClip>("Boxes1");
        boxes2 = Resources.Load<AudioClip>("Boxes2");
        boxes3 = Resources.Load<AudioClip>("Boxes3");
        comeBackMommy = Resources.Load<AudioClip>("ComeBackMommy");
        count1 = Resources.Load<AudioClip>("Count1");
        count2 = Resources.Load<AudioClip>("Count2");
        count3 = Resources.Load<AudioClip>("Count3");
        count4 = Resources.Load<AudioClip>("Count4");
        dots1 = Resources.Load<AudioClip>("Dots1");
        dots2 = Resources.Load<AudioClip>("Dots2");
        dots3 = Resources.Load<AudioClip>("Dots3");
        dots4 = Resources.Load<AudioClip>("Dots4");
        ending = Resources.Load<AudioClip>("Ending");
        enteringLowPoly = Resources.Load<AudioClip>("EnteringLowPoly");
        enteringServer = Resources.Load<AudioClip>("EnteringServer");
        general1 = Resources.Load<AudioClip>("General1");
        general2 = Resources.Load<AudioClip>("General2");
        general3 = Resources.Load<AudioClip>("General3");
        general4 = Resources.Load<AudioClip>("General4");
        general5 = Resources.Load<AudioClip>("General5");
        general6 = Resources.Load<AudioClip>("General6");
        general7 = Resources.Load<AudioClip>("General7");
        general8 = Resources.Load<AudioClip>("General8");
        general9 = Resources.Load<AudioClip>("General9");
        general10 = Resources.Load<AudioClip>("General10");
        general11 = Resources.Load<AudioClip>("General11");
        general12 = Resources.Load<AudioClip>("General12");
        general13 = Resources.Load<AudioClip>("General13");
        general14 = Resources.Load<AudioClip>("General14");
        general15 = Resources.Load<AudioClip>("General15");
        general16 = Resources.Load<AudioClip>("General16");
        general17 = Resources.Load<AudioClip>("General17");
        general18 = Resources.Load<AudioClip>("General18");
        general19 = Resources.Load<AudioClip>("General19");
        general20 = Resources.Load<AudioClip>("General20");
        general21 = Resources.Load<AudioClip>("General21");
        glass1 = Resources.Load<AudioClip>("Glass1");
        glass2 = Resources.Load<AudioClip>("Glass2");
        goodEnding1 = Resources.Load<AudioClip>("GoodEnding1");
        goodEnding2 = Resources.Load<AudioClip>("GoodEnding2");
        intro1 = Resources.Load<AudioClip>("Intro1");
        intro2 = Resources.Load<AudioClip>("Intro2");
        intro3 = Resources.Load<AudioClip>("Intro3");
        intro4 = Resources.Load<AudioClip>("Intro4");
        intro5 = Resources.Load<AudioClip>("Intro5");
        intro6 = Resources.Load<AudioClip>("Intro6");
        intro7 = Resources.Load<AudioClip>("Intro7");
        intro8 = Resources.Load<AudioClip>("Intro8");
        intro9 = Resources.Load<AudioClip>("Intro9");
        intro10 = Resources.Load<AudioClip>("Intro10");

       
        lab1 = Resources.Load<AudioClip>("Lab1");
        lab2 = Resources.Load<AudioClip>("Lab2");
        lowPoly1 = Resources.Load<AudioClip>("LowPoly1");
        lowPoly2 = Resources.Load<AudioClip>("LowPoly2");
        lowPoly3 = Resources.Load<AudioClip>("LowPoly3");
        lowPoly4 = Resources.Load<AudioClip>("LowPoly4");
        lowPolyMusic = Resources.Load<AudioClip>("LowPolyMusic");

        medieval1 = Resources.Load<AudioClip>("Medieval1");
        medieval2 = Resources.Load<AudioClip>("Medieval2");
        medieval3 = Resources.Load<AudioClip>("Medieval3");
        medieval4 = Resources.Load<AudioClip>("Medieval4");
        medieval5 = Resources.Load<AudioClip>("Medieval5");
        medievalMusic = Resources.Load<AudioClip>("MedievalMusic");

        server1 = Resources.Load<AudioClip>("Server1");
        server2 = Resources.Load<AudioClip>("Server2");
        server3 = Resources.Load<AudioClip>("Server3");
        server4 = Resources.Load<AudioClip>("Server4");
        server5 = Resources.Load<AudioClip>("Server5");
        serverMusic = Resources.Load<AudioClip>("ServerMusic");
        audioSource = GetComponent<AudioSource>();


        SoundManagerScript.PlaySound("intro7");

    }



    // Update is called once per frame
    void Update()
    {

    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "badEnding1":
                audioSource.PlayOneShot(badEnding1);
                break;
            case "badEnding2":
                audioSource.PlayOneShot(badEnding2);
                break;
            case "badEnding3":
                audioSource.PlayOneShot(badEnding3);
                break;
            case "boxes1":
                audioSource.PlayOneShot(boxes1);
                break;
            case "boxes2":
                audioSource.PlayOneShot(boxes2);
                break;
            case "boxes3":
                audioSource.PlayOneShot(boxes3);
                break;
            case "comeBackMommy":
                audioSource.PlayOneShot(comeBackMommy);
                break;
            case "count1":
                audioSource.PlayOneShot(count1);
                break;
            case "count2":
                audioSource.PlayOneShot(count2);
                break;
            case "count3":
                audioSource.PlayOneShot(count3);
                break;
            case "count4":
                audioSource.PlayOneShot(count4);
                break;
            case "dots1":
                audioSource.PlayOneShot(dots1);
                break;
            case "dots2":
                audioSource.PlayOneShot(dots2);
                break;
            case "dots3":
                audioSource.PlayOneShot(dots3);
                break;
            case "dots4":
                audioSource.PlayOneShot(dots4);
                break;
            case "ending":
                audioSource.PlayOneShot(ending);
                break;
            case "enteringLowPoly":
                audioSource.PlayOneShot(enteringLowPoly);
                break;
            case "enteringServer":
                audioSource.PlayOneShot(enteringServer);
                break;
            case "general1":
                audioSource.PlayOneShot(general1);
                break;
            case "general2":
                audioSource.PlayOneShot(general2);
                break;
            case "general3":
                audioSource.PlayOneShot(general3);
                break;
            case "general4":
                audioSource.PlayOneShot(general4);
                break;
            case "general5":
                audioSource.PlayOneShot(general5);
                break;
            case "general6":
                audioSource.PlayOneShot(general6);
                break;
            case "general7":
                audioSource.PlayOneShot(general7);
                break;
            case "general8":
                audioSource.PlayOneShot(general8);
                break;
            case "general9":
                audioSource.PlayOneShot(general9);
                break;
            case "general10":
                audioSource.PlayOneShot(general10);
                break;
            case "general11":
                audioSource.PlayOneShot(general11);
                break;
            case "general12":
                audioSource.PlayOneShot(general12);
                break;
            case "general13":
                audioSource.PlayOneShot(general13);
                break;
            case "general14":
                audioSource.PlayOneShot(general14);
                break;
            case "general15":
                audioSource.PlayOneShot(general15);
                break;
            case "general16":
                audioSource.PlayOneShot(general16);
                break;
            case "general17":
                audioSource.PlayOneShot(general17);
                break;
            case "general18":
                audioSource.PlayOneShot(general18);
                break;
            case "general19":
                audioSource.PlayOneShot(general19);
                break;
            case "general20":
                audioSource.PlayOneShot(general20);
                break;
            case "general21":
                audioSource.PlayOneShot(general21);
                break;
            case "glass1":
                audioSource.PlayOneShot(glass1);
                break;
            case "glass2":
                audioSource.PlayOneShot(glass2);
                break;
            case "goodEnding1":
                audioSource.PlayOneShot(goodEnding1);
                break;
            case "goodEnding2":
                audioSource.PlayOneShot(goodEnding2);
                break;
            case "intro1":
                audioSource.PlayOneShot(intro1);
                break;
            case "intro2":
                audioSource.PlayOneShot(intro2);
                break;
            case "intro3":
                audioSource.PlayOneShot(intro3);
                break;
            case "intro4":
                audioSource.PlayOneShot(intro4);
                break;
            case "intro5":
                audioSource.PlayOneShot(intro5);
                break;
            case "intro6":
                audioSource.PlayOneShot(intro6);
                break;
            case "intro7":
                audioSource.PlayOneShot(intro7);
                break;
            case "intro8":
                audioSource.PlayOneShot(intro8);
                break;
            case "intro9":
                audioSource.PlayOneShot(intro9);
                break;
            case "intro10":
                audioSource.PlayOneShot(intro10);
                break;
            case "lab1":
                audioSource.PlayOneShot(lab1);
                break;
            case "lab2":
                audioSource.PlayOneShot(lab2);
                break;
            case "lowPoly1":
                audioSource.PlayOneShot(lowPoly1);
                break;
            case "lowPoly2":
                audioSource.PlayOneShot(lowPoly2);
                break;
            case "lowPoly3":
                audioSource.PlayOneShot(lowPoly3);
                break;
            case "lowPoly4":
                audioSource.PlayOneShot(lowPoly4);
                break;
            case "lowPolyMusic ":
                audioSource.PlayOneShot(lowPolyMusic);
                break;
            case "medieval1":
                audioSource.PlayOneShot(medieval1);
                break;
            case "medieval2":
                audioSource.PlayOneShot(medieval2);
                break;
            case "medieval3":
                audioSource.PlayOneShot(medieval3);
                break;
            case "medieval4":
                audioSource.PlayOneShot(medieval4);
                break;
            case "medieval5":
                audioSource.PlayOneShot(medieval5);
                break;
            case "medievalMusic":
                audioSource.PlayOneShot(medievalMusic);
                break;
            case "server1":
                audioSource.PlayOneShot(server1);
                break;
            case "server2":
                audioSource.PlayOneShot(server2);
                break;
            case "server3":
                audioSource.PlayOneShot(server3);
                break;
            case "server4":
                audioSource.PlayOneShot(server4);
                break;
            case "server5":
                audioSource.PlayOneShot(server5);
                break;
            case "serverMusic":
                audioSource.PlayOneShot(serverMusic);
                break;
        }
    }
}
