using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fruits_Combinations : MonoBehaviour
{
    // contadores de colisão
    private int cer_c,moran_c,maca_c,Kiwi_c,banana_c,laran_c,aba_c;
    public GameObject[] fruits;

    [Header("UI de pontos")]
    [SerializeField]
    private Text PUI;
    private int pontos;
    private Audio_M AM;
    [SerializeField]
    private AudioClip POP_Clip;

    private void Start()
    {
        AM = FindObjectOfType<Audio_M>();
    }

    public void C_fruta(string tag,Transform PosI)
    {
        if(tag == "Cereja")
        {
            cer_c++;
        }else if(tag == "Morango")
        {
            moran_c++;
        }else if( tag == "Maçã")
        {
            maca_c++;
        }else if (tag == "Kiwi")
        {
            Kiwi_c++;
        }else if(tag == "Banana")
        {
            banana_c++;
        }else if( tag == "Laranja")
        {
            laran_c++;
        }else if(tag == "Abacaxi")
        {
            aba_c++;
        }
        instanciarF(PosI);
    }

    void instanciarF(Transform IP)
    {
        if(cer_c == 2)
        {
            Instantiate(fruits[0],IP.position,Quaternion.identity);
            addPoints(2);
            cer_c = 0;
        }
        else if (moran_c == 2)
        {
            Instantiate(fruits[1], IP.position, Quaternion.identity);
            addPoints(2);
            moran_c = 0;
        }
        else if (maca_c == 2)
        {
            Instantiate(fruits[2], IP.position, Quaternion.identity);
            addPoints(4);
            maca_c = 0;
        }
        else if(Kiwi_c == 2)
        {
            Instantiate(fruits[3], IP.position, Quaternion.identity);
            addPoints(6);
            Kiwi_c = 0;
        }
        else if(banana_c == 2)
        {
            Instantiate(fruits[4], IP.position, Quaternion.identity);
            addPoints(8);
            banana_c = 0;
        }
        else if (laran_c == 2)
        {
            Instantiate(fruits[5], IP.position, Quaternion.identity);
            addPoints(10);
            laran_c = 0;
        }
        else if (aba_c == 2)
        {
            Instantiate(fruits[6], IP.position, Quaternion.identity);
            addPoints(12);
            aba_c = 0;
        }
        AM.PlayAudio(POP_Clip);
    }
    void addPoints(int p)
    {
        pontos += p;
        PUI.text = "Points: " + pontos;
    }
}
