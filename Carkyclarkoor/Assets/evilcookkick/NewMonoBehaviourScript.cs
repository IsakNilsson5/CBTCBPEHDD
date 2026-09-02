using TMPro;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI clarksText;
    [SerializeField] int _clarks;
    [SerializeField] int clarkstosec;
    [SerializeField] int clarkstoclack;
    [SerializeField] int clarkscost;
    
    public int Clarks
    {   
        get => _clarks;
        set => _clarks = value;
    }

    public void ClarkClacked()
    {
        Clarks = Clarks + 1 + clarkstoclack;
        clarksText.text = Clarks.ToString();
        Debug.Log(Clarks);
    }

        void Start()
    {
        clarkscost = 10;
    }

    public void cloorkietocloork()
    {
        if (Clarks >= clarkscost)
        {
            Clarks = Clarks - clarkscost;
            clarkstoclack = clarkstoclack + 1;
            clarksText.text = Clarks.ToString();
            clarkscost = clarkscost + 5;
        }
    }
}