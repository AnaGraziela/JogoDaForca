using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public TMP_InputField dicaInput;
    public TMP_InputField temaInput;
    public TMP_InputField palavra;

    public TextMeshProUGUI dica;
    public TextMeshProUGUI nLetras;
    public TextMeshProUGUI tema;

    public GameObject parte1;
    public GameObject parte2;

    public GameObject erroTema;
    public GameObject erroDica;
    public GameObject erroPalavra;

    public GameObject gameOver;
    public GameObject vitoria;

    public GameObject opcoes;


    public GameObject cabeca;
    public GameObject tronco;
    public GameObject perna1;
    public GameObject perna2;
    public GameObject braco1;
    public GameObject braco2;
    public GameObject olhos;



    public GameObject tracinho;

    public TextMeshProUGUI AparecerLetra;
    public TextMeshProUGUI AparecerLetra1;
    public TextMeshProUGUI AparecerLetra2;
    public TextMeshProUGUI AparecerLetra3;
    public TextMeshProUGUI AparecerLetra4;
    public TextMeshProUGUI AparecerLetra5;
    public TextMeshProUGUI AparecerLetra6;
    public TextMeshProUGUI AparecerLetra7;
    public TextMeshProUGUI AparecerLetra8;
    public TextMeshProUGUI AparecerLetra9;
    public TextMeshProUGUI AparecerLetra10;
    public TextMeshProUGUI AparecerLetra11;
    public TextMeshProUGUI AparecerLetra12;
    public TextMeshProUGUI AparecerLetra13;
    public TextMeshProUGUI AparecerLetra14;
    public TextMeshProUGUI AparecerLetra15;
    public TextMeshProUGUI AparecerLetra16;
    public TextMeshProUGUI AparecerLetra17;
    public TextMeshProUGUI AparecerLetra18;
    public TextMeshProUGUI AparecerLetra19;
    public TextMeshProUGUI AparecerLetra20;
    public TextMeshProUGUI AparecerLetra21;
    public TextMeshProUGUI AparecerLetra22;
    public TextMeshProUGUI AparecerLetra23;
    public TextMeshProUGUI AparecerLetra24;

    private GameObject[] tracos;
    private GameObject cabecaa;
    private GameObject troncoo;
    private GameObject pernaa1;
    private GameObject pernaa2;
    private GameObject bracoo1;
    private GameObject bracoo2;
    private GameObject olhoss;

    private int erros = 0;
    private int contLetra = 0;

    [SerializeField] private string CenaJogo;


    public void SetDicaTema()
    {
        dica.text = dicaInput.text;
        tema.text = temaInput.text;

    }

    public void Alfabeto(string letraDigitada)
    {
        Debug.Log("A letra enviada foi:" + letraDigitada);
        setLetra(letraDigitada);
    }

    public void NLetras()
    {
        int cont = 0;
        char[] vetorP = palavra.text.ToCharArray();

        tracinho.transform.position = new Vector2(-7.2f, -2.8f);
        for (int i = 0; i < vetorP.Length; i++)
        {
            cont++;

        }
        nLetras.text = cont.ToString();
    }

    public void setLetra(string letraDigitada)
    {
        char[] vp = palavra.text.ToCharArray();
        char[] letter = letraDigitada.ToCharArray();
        char letra = char.Parse(letraDigitada); 

        if (palavra.text.Contains(letra))
        {
            for (int c = 0; c < letter.Length; c++)
            {
                for (int i = 0; i < vp.Length; i++)
                {

                    if (vp[i] == letter[c])
                    {
                        Debug.Log("Letra correta, ela é:" + c);
                        Debug.Log("O indice é:" + i);


                        if (i == 0)
                        {
                            AparecerLetra.gameObject.SetActive(true);
                            AparecerLetra.transform.position = new Vector2(-6.2f, -2.3f);
                            AparecerLetra.text = letraDigitada;
                            contLetra++;
                        }
                        if (i == 1)
                        {
                            AparecerLetra1.gameObject.SetActive(true);
                            AparecerLetra1.text = letraDigitada;
                            AparecerLetra1.transform.position = new Vector2(-4.9f, -2.3f);
                            contLetra++;
                        }
                        if (i == 2)
                        {
                            AparecerLetra2.gameObject.SetActive(true);
                            AparecerLetra2.text = letraDigitada;
                            AparecerLetra2.transform.position = new Vector2(-3.6f, -2.3f);
                            contLetra++;
                        }
                        if (i == 3)
                        {
                            AparecerLetra3.gameObject.SetActive(true);
                            AparecerLetra3.text = letraDigitada;
                            AparecerLetra3.transform.position = new Vector2(-2.3f, -2.3f);
                            contLetra++;
                        }
                        if (i == 4)
                        {
                            AparecerLetra4.gameObject.SetActive(true);
                            AparecerLetra4.text = letraDigitada;
                            AparecerLetra4.transform.position = new Vector2(-1f, -2.3f);
                            contLetra++;
                        }
                        if (i == 5)
                        {
                            AparecerLetra5.gameObject.SetActive(true);
                            AparecerLetra5.text = letraDigitada;
                            AparecerLetra5.transform.position = new Vector2(0.3f, -2.3f);
                            contLetra++;
                        }
                        if (i == 6)
                        {
                            AparecerLetra6.gameObject.SetActive(true);
                            AparecerLetra6.text = letraDigitada;
                            AparecerLetra6.transform.position = new Vector2(1.6f, -2.3f);
                            contLetra++;
                        }

                        if (i == 7)
                        {
                            AparecerLetra7.gameObject.SetActive(true);
                            AparecerLetra7.text = letraDigitada;
                            AparecerLetra7.transform.position = new Vector2(2.9f, -2.3f);
                            contLetra++;
                        }
                        if (i == 8)
                        {
                            AparecerLetra8.gameObject.SetActive(true);
                            AparecerLetra8.text = letraDigitada;
                            AparecerLetra8.transform.position = new Vector2(4.2f, -2.3f);
                            contLetra++;
                        }
                        if (i == 9)
                        {
                            AparecerLetra9.gameObject.SetActive(true);
                            AparecerLetra9.text = letraDigitada;
                            AparecerLetra9.transform.position = new Vector2(5.5f, -2.3f);
                            contLetra++;
                        }
                        if (i == 10)
                        {
                            AparecerLetra10.gameObject.SetActive(true);
                            AparecerLetra10.text = letraDigitada;
                            AparecerLetra10.transform.position = new Vector2(-6.2f, -3.5f);
                            contLetra++;
                        }
                        if (i == 11)
                        {
                            AparecerLetra11.gameObject.SetActive(true);
                            AparecerLetra11.text = letraDigitada;
                            AparecerLetra11.transform.position = new Vector2(-4.9f, -3.5f);
                            contLetra++;
                        }
                        if (i == 12)
                        {
                            AparecerLetra12.gameObject.SetActive(true);
                            AparecerLetra12.text = letraDigitada;
                            AparecerLetra12.transform.position = new Vector2(-3.6f, -3.5f);
                            contLetra++;
                        }
                        if (i == 13)
                        {
                            AparecerLetra13.gameObject.SetActive(true);
                            AparecerLetra13.text = letraDigitada;
                            AparecerLetra13.transform.position = new Vector2(-2.3f, -3.5f);
                            contLetra++;


                        }
                        if (i == 14)
                        {
                            AparecerLetra14.gameObject.SetActive(true);
                            AparecerLetra14.text = letraDigitada;
                            AparecerLetra14.transform.position = new Vector2(-1f, -3.5f);
                            contLetra++;
                        }
                        if (i == 15)
                        {
                            AparecerLetra15.gameObject.SetActive(true);
                            AparecerLetra15.text = letraDigitada;
                            AparecerLetra15.transform.position = new Vector2(0.3f, -3.5f);
                            contLetra++;
                        }
                        if (i == 16)
                        {
                            AparecerLetra16.gameObject.SetActive(true);
                            AparecerLetra16.text = letraDigitada;
                            AparecerLetra16.transform.position = new Vector2(1.6f, -3.5f);
                            contLetra++;
                        }
                        if (i == 17)
                        {
                            AparecerLetra17.gameObject.SetActive(true);
                            AparecerLetra17.text = letraDigitada;
                            AparecerLetra17.transform.position = new Vector2(2.9f, -3.5f);
                            contLetra++;
                        }
                        if (i == 18)
                        {
                            AparecerLetra18.gameObject.SetActive(true);
                            AparecerLetra18.text = letraDigitada;
                            AparecerLetra18.transform.position = new Vector2(4.2f, -3.5f);
                            contLetra++;
                        }
                        if (i == 19)
                        {
                            AparecerLetra19.gameObject.SetActive(true);
                            AparecerLetra19.text = letraDigitada;
                            AparecerLetra19.transform.position = new Vector2(5.5f, -3.5f);
                            contLetra++;
                        }
                        if (i == 20)
                        {
                            AparecerLetra20.gameObject.SetActive(true);
                            AparecerLetra20.text = letraDigitada;
                            AparecerLetra20.transform.position = new Vector2(-6.2f, -4.7f);
                            contLetra++;
                        }
                        if (i == 21)
                        {
                            AparecerLetra21.gameObject.SetActive(true);
                            AparecerLetra21.text = letraDigitada;
                            AparecerLetra21.transform.position = new Vector2(-4.9f, -4.7f);
                            contLetra++;
                        }
                        if (i == 22)
                        {
                            AparecerLetra22.gameObject.SetActive(true);
                            AparecerLetra22.text = letraDigitada;
                            AparecerLetra22.transform.position = new Vector2(-3.6f, -4.7f);
                            contLetra++;
                        }
                        if (i == 23)
                        {
                            AparecerLetra23.gameObject.SetActive(true);
                            AparecerLetra23.text = letraDigitada;
                            AparecerLetra23.transform.position = new Vector2(-2.3f, -4.7f);
                            contLetra++;
                        }
                        if (i == 24)
                        {
                            AparecerLetra24.gameObject.SetActive(true);
                            AparecerLetra24.text = letraDigitada;
                            AparecerLetra24.transform.position = new Vector2(-1f, -4.7f);
                            contLetra++;
                        }
                        VerificaVitoria(contLetra, vp);
                    }
                }
            }
        }
        else
        {
            Debug.Log("Letra Incorreta");
            erros++;

            if (erros == 1)
            {
                cabeca.transform.position = new Vector3(-3.5f, 2.32f, 0f);
                cabecaa = Instantiate(cabeca, new Vector3(cabeca.transform.position.x, cabeca.transform.position.y, cabeca.transform.position.z), Quaternion.identity);
            }
            else if (erros == 2)
            {
                tronco.transform.position = new Vector3(-3.5f, 0.67f, 0f);
                troncoo = Instantiate(tronco, new Vector3(tronco.transform.position.x, tronco.transform.position.y, tronco.transform.position.z), Quaternion.identity);

            }
            else if (erros == 3)
            {
                perna1.transform.position = new Vector3(-3.96f, -0.73f, 0f);
                pernaa1 = Instantiate(perna1, new Vector3(perna1.transform.position.x, perna1.transform.position.y, perna1.transform.position.z), Quaternion.identity);

            }
            else if (erros == 4)
            {
                perna2.transform.position = new Vector3(-3.2f, -0.73f, 0f);
                pernaa2 = Instantiate(perna2, new Vector3(perna2.transform.position.x, perna2.transform.position.y, perna2.transform.position.z), Quaternion.identity);
            }
            else if (erros == 5)
            {
                braco1.transform.position = new Vector3(-4.3f, 0.8f, 0f);
                bracoo1 = Instantiate(braco1, new Vector3(braco1.transform.position.x, braco1.transform.position.y, braco1.transform.position.z), Quaternion.identity);


            }
            else if (erros == 6)
            {
                braco2.transform.position = new Vector3(-2.6f, 0.8f, 0f);
                bracoo2 = Instantiate(braco2, new Vector3(braco2.transform.position.x, braco2.transform.position.y, braco2.transform.position.z), Quaternion.identity);

            }
            else if (erros == 7)
            {
                olhos.transform.position = new Vector3(-3.5f, 2.5f, -2f);
                olhoss = Instantiate(olhos, new Vector3(olhos.transform.position.x, olhos.transform.position.y, olhos.transform.position.z), Quaternion.identity);
                InvokeRepeating("Derrota", 0.75f, 1f);

                Debug.Log("-------------------VOCE PERDEUUU----------------------------");
            }

        }

    }
    public void VerificaVitoria(int contLetras, char[] vp)
    {
        if (vp.Length == contLetra)
        {
            InvokeRepeating("Ganhou", 0.75f, 1f);
        }
    }

    public void VerificaTema()
    {
        int cont = 0;
        char[] vt = tema.text.ToCharArray();
        for (int i = 0; i < vt.Length; i++)
        {
            cont++;
        }
        if (cont == 0 || cont > 12)
        {
            erroTema.SetActive(true);
        }
    }
    public void VerificaDica()
    {
        int cont = 0;
        char[] vd = dica.text.ToCharArray();
        for (int i = 0; i < vd.Length; i++)
        {
            cont++;
        }
        if (cont == 0 || cont > 12)
        {
            erroDica.SetActive(true);
        }
    }
    public void VerificaPalavra()
    {
        int cont = 0;
        char[] vp = palavra.text.ToCharArray();
        for (int i = 0; i < vp.Length; i++)
        {
            cont++;
        }
        if (cont == 0 || cont > 25)
        {
            erroPalavra.SetActive(true);
        }
    }
    public void Comecar()
    {
        char[] vetorP = palavra.text.ToCharArray();
        int cont = 0;
        if (erroPalavra.activeSelf || erroTema.activeSelf || erroDica.activeSelf)
        {
            parte1.SetActive(true);
            parte2.SetActive(false);
        }
        else
        {
            parte1.SetActive(false);
            parte2.SetActive(true);
            for (int i = 0; i < vetorP.Length; i++)
            {
                cont++;
            }
            tracos = new GameObject[cont];
            
            tracinho.transform.position = new Vector2(-7.2f, -2.8f);
            for (int i = 0; i < tracos.Length; i++)
            {  
                if (i == 10)
                {
                    tracinho.transform.position = new Vector2(-7.2f, -4f);
                    tracos[i] = Instantiate(tracinho, new Vector2(tracinho.transform.position.x, tracinho.transform.position.y), Quaternion.identity);
                    tracinho.transform.position = new Vector2(tracinho.transform.position.x + 1.3f, tracinho.transform.position.y);
                }
                else if (i == 20)
                {
                    tracinho.transform.position = new Vector2(-7.2f, -5.3f);
                    tracos[i] = Instantiate(tracinho, new Vector2(tracinho.transform.position.x, tracinho.transform.position.y), Quaternion.identity);
                    tracinho.transform.position = new Vector2(tracinho.transform.position.x + 1.3f, tracinho.transform.position.y);
                }
                else
                {
                    tracos[i] = Instantiate(tracinho, new Vector2(tracinho.transform.position.x, tracinho.transform.position.y), Quaternion.identity);
                    tracinho.transform.position = new Vector2(tracinho.transform.position.x + 1.3f, tracinho.transform.position.y);

                }
            }
        }
    }
    public void FecharAvisoTema()
    {
        erroTema.SetActive(false);
    }
    public void FecharAvisoDica()
    {
        erroDica.SetActive(false);
    }
    public void FecharAvisoPalavra()
    {
        erroPalavra.SetActive(false);
    }
    public void Derrota()
    {
        char[] vetorP = palavra.text.ToCharArray();
        for (int i = 0; i < tracos.Length; i++)
        {
            DestroyImmediate(tracos[i]);
        }
        DestroyImmediate(cabecaa);
        DestroyImmediate(troncoo);
        DestroyImmediate(pernaa1);
        DestroyImmediate(pernaa2);
        DestroyImmediate(bracoo1);
        DestroyImmediate(bracoo2);
        DestroyImmediate(olhoss);
        gameOver.SetActive(true);


    }
    public void Reiniciar()
    {
        SceneManager.LoadScene(CenaJogo);
    }
    public void Ganhou()
    {
        char[] vetorP = palavra.text.ToCharArray();
        for (int i = 0; i < tracos.Length; i++)
        {
            DestroyImmediate(tracos[i]);
        }
        DestroyImmediate(cabecaa);
        DestroyImmediate(troncoo);
        DestroyImmediate(pernaa1);
        DestroyImmediate(pernaa2);
        DestroyImmediate(bracoo1);
        DestroyImmediate(bracoo2);
        DestroyImmediate(olhoss);       
        vitoria.SetActive(true);
    }
    public void DisableButton(Button botao)
    {
        botao.interactable = false;
    }
    public void AbrirOpcoes()
    {
        opcoes.SetActive(true);
    }
    public void FecharOpcoes()
    {
        opcoes.SetActive(false);
    }
}

