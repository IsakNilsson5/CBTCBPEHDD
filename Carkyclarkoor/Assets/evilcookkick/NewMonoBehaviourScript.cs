using System.Security.Cryptography;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI numbersText;
    [SerializeField] TextMeshProUGUI upgradeItext;
    [SerializeField] TextMeshProUGUI upgradeIItext;
    [SerializeField] TextMeshProUGUI upgradeIIItext;
    [SerializeField] TextMeshProUGUI upgradeIVtext;
    [SerializeField] TextMeshProUGUI upgradeVtext;
    [SerializeField] TextMeshProUGUI upgradeVItext;
    [SerializeField] TextMeshProUGUI upgradeVIItext;
    [SerializeField] int Number;
    [SerializeField] int clarkstoclack;
    [SerializeField] int clarkscost;
    float timer;
    [SerializeField] bool spammyobtained = false;
    [SerializeField] int spammy;
    [SerializeField] int spammycost;
    [SerializeField] int divisiontime;
    [SerializeField] int divisiontimecost;
    [SerializeField] Animator CARKEHAnimator;
    [SerializeField] int greatctccost;
    [SerializeField] int greatspammycost;
    [SerializeField] int greaterctccost;
    [SerializeField] int greaterspammycost;
    private void Update()
    {

        timer += Time.deltaTime;
        if (spammyobtained == true)
        {
            if (timer >= 1f / divisiontime)
            {
                timer = 0f;
                Numbersclickedseconds();
            }
        }
    }


    public void Numbersclickedseconds()
    {
        Number = Number + spammy;
        Debug.Log(Number);
        numbersText.text = Number.ToString();
        CARKEHAnimator.SetTrigger("buttonshake");
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
        clarkscost = 10;
        upgradeItext.text = "10";
        clarkstoclack = 0;
        spammy = 0; spammyobtained = false;
        upgradeIItext.text = "20";
        spammycost = 20;
        divisiontime = 1;
        upgradeIIItext.text = "500";  // x^2 + x + 2x + 2 smthin like this
        divisiontimecost = 500;
        upgradeIVtext.text = "100";
        greatctccost = 100;
        upgradeVtext.text = "200";
        greatspammycost = 200;
        upgradeVItext.text = "1000";
        greaterctccost = 1000;
        upgradeVIItext.text = "2000";
        greaterspammycost = 2000;

    }

    public void Cloorkietocloork()
    {
        if (Number >= clarkscost)
        {
            Number = Number - clarkscost;
            clarkstoclack = clarkstoclack + 1;
            clarkscost = clarkscost + 10;
            numbersText.text = Number.ToString();
            upgradeItext.text = clarkscost.ToString();
        }
    }

    public void Spammyobtained()
    {
        if (Number >= spammycost)
        {
            Number = Number - spammycost;
            spammyobtained = true;
            spammy = spammy + 1;
            numbersText.text = Number.ToString();
            spammycost = spammycost + 25;
            upgradeIItext.text = spammycost.ToString();
        }
    }
    public void Divisiontimeobtained()
    {
        if (Number >= divisiontimecost)
        {
            Number = Number - divisiontimecost;
            divisiontime = divisiontime + 1;
            numbersText.text = Number.ToString();
            divisiontimecost = divisiontimecost + 1000;
            upgradeIIItext.text = divisiontimecost.ToString();
        }
    }
    public void Greatcoktocak()
    {
        if (Number >= greatctccost)
        {
            Number = Number - greatctccost;
            numbersText.text = Number.ToString();
            clarkstoclack = clarkstoclack + 10;
            greatctccost = greatctccost + 90;
            upgradeIVtext.text = greatctccost.ToString();
        }
    }
    public void Greatspammyobtained()
    {
        if (Number >= greatspammycost)
        {
            Number = Number - greatspammycost;
            spammyobtained = true;
            spammy = spammy + 10;
            numbersText.text = Number.ToString();
            greatspammycost = greatspammycost + 240;
            upgradeVtext.text = greatspammycost.ToString();
        }
    }
    public void Greatercoktocak()
    {
        if (Number >= greaterctccost)
        {
            Number = Number - greaterctccost;
            numbersText.text = Number.ToString();
            clarkstoclack = clarkstoclack + 100;
            greaterctccost = greaterctccost + 800;
            upgradeVItext.text = greaterctccost.ToString();
        }
    }
    public void Greaterspammyobtained()
    {
        if (Number >= greaterspammycost)
        {
            Number = Number - greaterspammycost;
            spammyobtained = true;
            spammy = spammy + 100;
            numbersText.text = Number.ToString();
            greaterspammycost = greaterspammycost + 2300;
            upgradeVIItext.text = greaterspammycost.ToString();
        }
    }
    public void Thegreatvictory()
    {
        if (Number >= 250000)
        {
            SceneManager.LoadScene("areyouawinner");
            //Achievement obtained! "A Winner nontheless."
            //if Divisiontimer = 1, get achievement "One second at a time"
            //if spammyobtained = false, get another Achievement "Full of energy!"
            //if clarkstoclack = 0, get another Achievement "The Persistent Clicker!"
            //if clarkstoclack is 0 and spammyobtained = false, get another Achievement "The goat of Clickers"
        }
    }
}