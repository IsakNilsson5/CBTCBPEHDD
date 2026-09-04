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

    private void Update()
    {

        timer += Time.deltaTime;
        if (spammyobtained == true)
        {
            if (timer >= 1)
            {
                timer = 0f;
                Number = Number + spammy;
                Numbersclicked();
            }
        }
    }

    public void Numbersclicked()
    {
        Number = Number + clarkstoclack;
        Debug.Log(Number);
        numbersText.text = Number.ToString();
    }

    void Start()
    {
        clarkscost = 100;
        clarkstoclack = 1;
        spammy = 0; spammyobtained = false;
        spammycost = 10;

    }

    public void Cloorkietocloork()
    {
        if (Number >= clarkscost)
        {
            Number = Number - clarkscost;
            clarkstoclack = clarkstoclack + 1;
            clarkscost = clarkscost + 100;
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
            spammycost = spammycost + 10;
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