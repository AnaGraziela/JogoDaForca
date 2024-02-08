using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SomController : MonoBehaviour
{
    [SerializeField] private AudioSource fundoMusical;

    [SerializeField] private Sprite somLigado;
    [SerializeField] private Sprite somDesligado;
    
    [SerializeField] private Image muteImage;

    private bool estadoSom = true;
    public void LigarDesligarSom()
    {
        estadoSom = !estadoSom;
        fundoMusical.enabled = estadoSom;

        if (estadoSom)
        {
            muteImage.sprite = somLigado;
        }
        else{
            muteImage.sprite = somDesligado;
        }
    }
    public void VolumeMusical(float value)
    {
        fundoMusical.volume = value;
    }
}
