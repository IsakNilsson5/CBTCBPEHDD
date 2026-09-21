using System.Security.Cryptography;
using TMPro;
using Unity.VisualScripting;
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
    [SerializeField] TextMeshProUGUI endingtext;
    [SerializeField] int phase;

    float Number;
    [SerializeField] int clarkstoclack;
    [SerializeField] int clarkscost;
    float timer;
    float spammy;
    [SerializeField] int addtime;
    [SerializeField] int addtimecost;
    [SerializeField] Animator GREATERCARKEHAnimator;
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
        GREATERCARKEHAnimator.SetTrigger("buttonshake");
    }

    void Start()
    {
        phase = 1;
        Number = 0;
        clarkscost = 20;
        upgradeItext.text = "20";
        clarkstoclack = 0;
        spammy = 1f;
        addtime = 0;
        upgradeIItext.text = "1000";
        addtimecost = 1000;
        upgradeIIItext.text = "200";    
        badctccost = 200;
        upgradeIVtext.text = "2000";
        worsectccost = 2000;
        upgradeVtext.text = "20000";
        worstctccost = 20000;
        spammytimer = 0f;
        endingtext.text = "50000";
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

    public void Addtimeobtained()
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
        if (Number >= 50000 && phase == 1)
        {
            Number = 0;
            phase = 2;
            spammy = spammy + 20;
            spammytimer = spammytimer + 2;
            endingtext.text = "100000";
            return;
        }
        
        if (Number >= 100000 && phase == 2)
        {
            Number = 0;
            phase = 3;
            spammy = spammy + 30;
            spammytimer = spammytimer + 3;
            addtime = addtime - 1;
            endingtext.text = "500000";
            return;
        }
        
        if (Number >= 500000 && phase == 3)
        {
            Number = 0;
            phase = 3;
            spammy = spammy + (addtime*10);
            spammytimer = spammytimer + addtime;
            addtime = 0;
            endingtext.text = "2000000";
            return;
        }

        if (Number >= 2000000 && phase == 4)
        {

            SceneManager.LoadScene("areyouawinner");
            //achievement obtained! The Great Clicker!
            //if Addtimer = 0, get Achievement "The battle against Time"
            //if clarkstoclack = 0, get achievement "The Greater Clicker!"
            //if Addtimer = 0 and clarkstoclack = 0, get achievement "The Conqueror of CarkyClarkoor"
        }
    }
}