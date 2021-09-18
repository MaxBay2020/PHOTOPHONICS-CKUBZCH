using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickEvents : MonoBehaviour
{

    private List<string> items = new List<string>();
    private int index;
    private int currentIndex;

    private bool catBool, candleBool, kiteBool, keyBool, umbrellaBool, bikeBool, busBool, zebraBool, zipperBool, chairBool, chickenBool;

    //public GameObject moonTriggerBox, appleTriggerBox, astronautTriggerBox, sunTriggerBox, starTriggerBox, teacherTriggerBox, turtleTriggerBox, doorTriggerBox, dogTriggerBox, elephantTriggerBox, shoesTriggerBox, shirtTriggerBox, shipsTriggerBox;
    public GameObject[] itemTriggers;
    public GameObject[] hints;

    public GameObject catGO, candleGO, kiteGO, keyGO, umbrellaGO, bikeGO, busGO, zebraGO, zipperGO, chairGO, chickenGO;
    public GameObject coloredBg;

    public GameObject letterBox;
    public Sprite cLetter, kLetter, uLetter, bLetter, zLetter, chLetter;


    private void Start()
    {
        items = GameManager._instance.items;
        index = GameManager._instance.index;

        StartCoroutine(SoundPlay(1.0f));
    }

    public void ClickUmbrella()
    {
        umbrellaGO.SetActive(true);

        MoveToNextItem();
        letterBox.GetComponent<Image>().sprite = bLetter;
        SoundManager._instance.bSoundPlay();
    }

    public void ClickCat()
    {
        catGO.SetActive(true);

        catBool = true;
        if (catBool && candleBool )
        {
            MoveToNextItem();
            letterBox.GetComponent<Image>().sprite = kLetter;
            SoundManager._instance.kSoundPlay();
        }
    }

    public void ClickCandle()
    {
        candleGO.SetActive(true);
        
        candleBool = true;
        if (catBool && candleBool)
        {
            MoveToNextItem();
            letterBox.GetComponent<Image>().sprite = kLetter;
            SoundManager._instance.kSoundPlay();
        }
    }

    public void ClickKite()
    {
        kiteGO.SetActive(true);

        kiteBool = true;
        if (kiteBool && keyBool)
        {
            MoveToNextItem();
            letterBox.GetComponent<Image>().sprite = uLetter;
            SoundManager._instance.uSoundPlay();
        }
    }

    public void ClickKey()
    {
        keyGO.SetActive(true);
        keyBool = true;
        if (kiteBool && keyBool)
        {
            MoveToNextItem();
            letterBox.GetComponent<Image>().sprite = uLetter;
            SoundManager._instance.uSoundPlay();
        }
    }



    public void ClickBike()
    {
        bikeGO.SetActive(true);
        bikeBool = true;
        if (bikeBool && busBool)
        {
            MoveToNextItem();
            letterBox.GetComponent<Image>().sprite = zLetter;
            SoundManager._instance.zSoundPlay();
        }
    }

    public void ClickBus()
    {
        busGO.SetActive(true);
        busBool = true;
        if (bikeBool && busBool)
        {
            MoveToNextItem();
            letterBox.GetComponent<Image>().sprite = zLetter;
            SoundManager._instance.zSoundPlay();
        }
    }

    public void ClickZebra()
    {
        zebraGO.SetActive(true);
        zebraBool = true;
        if (zebraBool && zipperBool)
        {
            MoveToNextItem();
            letterBox.GetComponent<Image>().sprite = chLetter;
            SoundManager._instance.chSoundPlay();
        }
    }

    public void ClickZipper()
    {
        zipperGO.SetActive(true);
        zipperBool = true;
        if (zebraBool && zipperBool)
        {
            MoveToNextItem();
            letterBox.GetComponent<Image>().sprite = chLetter;
            SoundManager._instance.chSoundPlay();
        }
    }



    public void ClickChair()
    {
        chairGO.SetActive(true);
        chairBool = true;
        if (chairBool && chickenBool)
        {
            MoveToNextItem();
            SoundManager._instance.CongratulationsSoundPlay();
            StartCoroutine(coloredBgShow(1.0f));
        }
    }

    public void ClickChicken()
    {
        chickenGO.SetActive(true);
        chickenBool = true;
        if (chairBool && chickenBool)
        {
            MoveToNextItem();
            SoundManager._instance.CongratulationsSoundPlay();
            StartCoroutine(coloredBgShow(1.0f));
        }
    }


    IEnumerator coloredBgShow(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        coloredBg.SetActive(true);
    }



    IEnumerator SoundPlay(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        SoundManager._instance.cSoundPlay();
    }

    public void MoveToNextItem()
    {
        currentIndex++;
        for (int i = 0; i < itemTriggers.Length; i++)
        {
            itemTriggers[i].SetActive(i == currentIndex);
        }
    }

    public void HintsDisplay()
    {
        for (int i = 0; i < hints.Length; i++)
        {
            hints[i].SetActive(i == currentIndex);
            StartCoroutine(HintsHide(i));
        }
    }

    IEnumerator HintsHide(int i)
    {
        yield return new WaitForSeconds(3.0f);
        hints[i].SetActive(false);
    }
}
