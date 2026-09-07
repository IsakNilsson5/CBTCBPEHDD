using TMPro;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI numbersText;
    [SerializeField] int Number;
    [SerializeField] int clarkstoclack;
    [SerializeField] int clarkscost;
    [SerializeField] float timer;
    [SerializeField] bool spammyobtained = false;
    [SerializeField] int spammy;
    [SerializeField] int spammycost;
    [SerializeField] int divisiontime;
    [SerializeField] int divisiontimecost;
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
    }
    public void Numbersclicked()
    {
        Number = Number + 1 + clarkstoclack;
        Debug.Log(Number);
        numbersText.text = Number.ToString();
    }

    void Start()
    {
        clarkscost = 10;
        clarkstoclack = 0;
        spammy = 0; spammyobtained = false;
        spammycost = 20;
        divisiontime = 1;
        divisiontimecost = 500;

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

    public void VICTORYYAYAYAYAYAYAYAY()
    {
        if (Number >= 25000)
        {
            Debug.Log("VICTORY");
        }
    }
}