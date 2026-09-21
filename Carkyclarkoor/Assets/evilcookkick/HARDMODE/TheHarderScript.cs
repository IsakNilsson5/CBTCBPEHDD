using System.Security.Cryptography;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HarderScript : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI numbersText;
    [SerializeField] TextMeshProUGUI upgradeItext;
    [SerializeField] TextMeshProUGUI upgradeIItext;
    [SerializeField] TextMeshProUGUI upgradeIIItext;
    [SerializeField] TextMeshProUGUI upgradeIVtext;
    [SerializeField] TextMeshProUGUI upgradeVtext;

    float Number;
    [SerializeField] int clarkstoclack;
    [SerializeField] int clarkscost;
    float timer;
    float spammy;
    [SerializeField] int addtime;
    [SerializeField] int addtimecost;
    [SerializeField] Animator CARKEHAnimator;
    [SerializeField] int worsectccost;
    [SerializeField] int badctccost;
    [SerializeField] int worstctccost;
    float spammytimer;
    private void Update()
    {

        timer += Time.deltaTime;

            if (timer >= (1f-spammytimer) + addtime)
            {
                timer = 0f;
                Numbersclickedseconds();
            }
    }


    public void Numbersclickedseconds()
    {
        Number = Number - (int) spammy;
        Debug.Log(Number);
        numbersText.text = Number.ToString();
    }
    public void Numbersclicked()
    {
        Number = Number + 1 + clarkstoclack;
        Debug.Log(Number);
        numbersText.text = Number.ToString();
        CARKEHAnimator.SetTrigger("buttonshake");
    }

    void Start()
    {
        Number = 0; 
        clarkscost = 20;
        upgradeItext.text = "20";
        clarkstoclack = 0;
        spammy = 1f;
        addtime = 1;
        upgradeIItext.text = "1000";
        addtimecost = 1000;
        upgradeIIItext.text = "200";
        badctccost = 200;
        upgradeIVtext.text = "2000";
        worsectccost = 2000;
        upgradeVtext.text = "20000";
        worstctccost = 20000;
        spammytimer = 0f;

    }

    public void Cloorkietocloork()
    {
        if (Number >= clarkscost)
        {
            Number = Number - clarkscost;
            clarkstoclack = clarkstoclack + 1;
            clarkscost = clarkscost + 20;
            numbersText.text = Number.ToString();
            upgradeItext.text = clarkscost.ToString();
        }
    }

    public void Divisiontimeobtained()
    {
        if (Number >= addtimecost)
        {
            Number = Number - addtimecost;
            addtime = addtime + 1;
            numbersText.text = Number.ToString();
            addtimecost = addtimecost + 2000;
            upgradeIItext.text = addtimecost.ToString();
            spammytimer = spammytimer + -0.001f;
            spammy = spammy - 1f;
        }
    }
    public void Badcoktocak()
    {
        if (Number >= badctccost)
        {
            Number = Number - badctccost;
            numbersText.text = Number.ToString();
            clarkstoclack = clarkstoclack + 9;
            worsectccost = worsectccost + 200;
            upgradeIIItext.text = worsectccost.ToString();
            spammytimer = spammytimer + 0.01f;
            spammy = spammy + 1f;
        }
    }

    public void Worsecoktocak()
    {
        if (Number >= worsectccost)
        {
            Number = Number - worsectccost;
            numbersText.text = Number.ToString();
            clarkstoclack = clarkstoclack + 80;
            worsectccost = worsectccost + 2000;
            upgradeIVtext.text = worsectccost.ToString();
            spammytimer = spammytimer + 0.1f;
            spammy = spammy + 10f;

        }
    }
    public void Worstcoktocak()
    {
        if (Number >= worstctccost)
        {
            Number = Number - worstctccost;
            numbersText.text = Number.ToString();
            clarkstoclack = clarkstoclack + 700;
            worstctccost = worstctccost + 20000;
            upgradeVtext.text = worstctccost.ToString();
            spammytimer = spammytimer + 1f;
            spammy = spammy + 100f;
        }
    }
    public void Thegreatvictory()
    {
        if (Number >= 250000)
        {
            SceneManager.LoadScene("areyouawinner");
        }
    }
}