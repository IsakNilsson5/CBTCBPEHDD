using System.Security.Cryptography;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI numbers;
    [SerializeField] TextMeshProUGUI upgradeI;
    [SerializeField] TextMeshProUGUI upgradeII;
    [SerializeField] TextMeshProUGUI upgradeIII;
    [SerializeField] TextMeshProUGUI upgradeIV;
    [SerializeField] TextMeshProUGUI upgradeV;
    [SerializeField] TextMeshProUGUI upgradeVI;
    [SerializeField] TextMeshProUGUI upgradeVII;
    [SerializeField] TextMeshProUGUI upgradeIIX;
    [SerializeField] TextMeshProUGUI upgradeIX;
    [SerializeField] TextMeshProUGUI upgradeX;
    [SerializeField] TextMeshProUGUI upgradeXI;
    [SerializeField] TextMeshProUGUI time2;
    [SerializeField] TextMeshProUGUI multiply;
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
    [SerializeField] int bestctccost;
    [SerializeField] int bestspammycost;
    [SerializeField] int multipliercost;
    [SerializeField] int greatmultipliercost;
    [SerializeField] int multiplier;
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
        Number = Number + spammy* multiplier;
        Debug.Log(Number);
        numbers.text = Number.ToString();
        CARKEHAnimator.SetTrigger("buttonshake");
    }
    public void Numbersclicked()
    {
        Number = Number + (1 + clarkstoclack) * multiplier;
        Debug.Log(Number);
        numbers.text = Number.ToString();
        CARKEHAnimator.SetTrigger("buttonshake");
    }

    void Start()
    {
        clarkscost = 10;
        upgradeI.text = "10";
        clarkstoclack = 0;
        spammy = 0; spammyobtained = false;
        upgradeII.text = "20";
        spammycost = 20;
        multiplier = 1;
        multiply.text = "1";
        divisiontime = 1;
        upgradeIII.text = "500";
        divisiontimecost = 500;
        upgradeIV.text = "100";
        greatctccost = 100;
        upgradeV.text = "200";
        greatspammycost = 200;
        upgradeVI.text = "1000";
        greaterctccost = 1000;
        upgradeVII.text = "2000";
        greaterspammycost = 2000;
        upgradeIIX.text = "10000";
        bestctccost = 10000;
        upgradeIX.text = "20000";
        bestspammycost = 20000;
        upgradeX.text = "100000";
        multipliercost = 100000;
        upgradeXI.text = "10000000";
        greatmultipliercost = 10000000;

    }

    public void Cloorkietocloork()
    {
        if (Number >= clarkscost)
        {
            Number = Number - clarkscost;
            clarkstoclack = clarkstoclack + 1;
            clarkscost = clarkscost + 10;
            numbers.text = Number.ToString();
            upgradeI.text = clarkscost.ToString();
        }
    }

    public void Spammyobtained()
    {
        if (Number >= spammycost)
        {
            Number = Number - spammycost;
            spammyobtained = true;
            spammy = spammy + 1;
            numbers.text = Number.ToString();
            spammycost = spammycost + 25;
            upgradeII.text = spammycost.ToString();
        }
    }
    public void Divisiontimeobtained()
    {
        if (Number >= divisiontimecost)
        {
            Number = Number - divisiontimecost;
            divisiontime = divisiontime + 1;
            numbers.text = Number.ToString();
            divisiontimecost = divisiontimecost + 1000;
            upgradeIII.text = divisiontimecost.ToString();
            time2.text = (1f / divisiontime).ToString();
        }
    }
    public void Greatcoktocak()
    {
        if (Number >= greatctccost)
        {
            Number = Number - greatctccost;
            numbers.text = Number.ToString();
            clarkstoclack = clarkstoclack + 10;
            greatctccost = greatctccost + 90;
            upgradeIV.text = greatctccost.ToString();
        }
    }
    public void Greatspammyobtained()
    {
        if (Number >= greatspammycost)
        {
            Number = Number - greatspammycost;
            spammyobtained = true;
            spammy = spammy + 10;
            numbers.text = Number.ToString();
            greatspammycost = greatspammycost + 240;
            upgradeV.text = greatspammycost.ToString();
        }
    }
    public void Greatercoktocak()
    {
        if (Number >= greaterctccost)
        {
            Number = Number - greaterctccost;
            numbers.text = Number.ToString();
            clarkstoclack = clarkstoclack + 100;
            greaterctccost = greaterctccost + 800;
            upgradeVI.text = greaterctccost.ToString();
        }
    }
    public void Greaterspammyobtained()
    {
        if (Number >= greaterspammycost)
        {
            Number = Number - greaterspammycost;
            spammyobtained = true;
            spammy = spammy + 100;
            numbers.text = Number.ToString();
            greaterspammycost = greaterspammycost + 2300;
            upgradeVII.text = greaterspammycost.ToString();
        }
    }
    public void Bestcoktocak()
    {
        if (Number >= bestctccost)
        {
            Number = Number - bestctccost;
            clarkstoclack = clarkstoclack + 1000;
            bestctccost = bestctccost + 7000;
            numbers.text = Number.ToString();
            upgradeIIX.text = bestctccost.ToString();
            
        }
    }
    public void Bestspammyobtained()
    {
        if (Number >= bestspammycost)
        {
            Number = Number - bestspammycost;
            spammy = spammy + 1000;
            bestspammycost = bestspammycost + 22000;
            spammyobtained = true;
            numbers.text = Number.ToString();
            upgradeIX.text = bestspammycost.ToString();
        }
    }
    public void Kaioken()
    {
        if (Number >= multipliercost)
        {
            Number = Number - multipliercost;
            multiplier = multiplier + 1;
            multipliercost = multipliercost + 1000000;
            numbers.text = Number.ToString();
            upgradeX.text = multipliercost.ToString();
            multiply.text = multiplier.ToString();

        }
    }
    public void SuperKaioken()
    {
        if (Number >= greatmultipliercost)
        {
            Number = Number - greatmultipliercost;
            multiplier = multiplier + 10;
            greatmultipliercost = multiplier + 10000000;
            numbers.text = Number.ToString();
            upgradeXI.text = greatmultipliercost.ToString();
            multiply.text = multiplier.ToString();
            
        }
    }

    public void Thegreatvictory()
    {
        if (Number >= 1000000000)
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