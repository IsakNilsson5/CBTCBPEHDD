using TMPro;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI numbersText;
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
        clarkstoclack = 0;
        spammy = 0; spammyobtained = false;
        spammycost = 20;
        divisiontime = 1;
        divisiontimecost = 500;
        greatctccost = 100;
        greatspammycost = 200;
        greaterctccost = 1000;
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
        }
    }
    public void Greatercoktocak()
    {
        if (Number >= greatctccost)
        {
            Number = Number - greaterctccost;
            numbersText.text = Number.ToString();
            clarkstoclack = clarkstoclack + 100;
            greaterctccost = greaterctccost + 800;
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
        }
    }
}