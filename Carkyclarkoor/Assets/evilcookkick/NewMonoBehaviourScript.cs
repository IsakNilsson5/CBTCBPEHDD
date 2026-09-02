using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI clarksText;
    [SerializeField] private int _clarks; // backing field
    [SerializeField] private int clarkstosec;
    [SerializeField] private int clarkstoclack;

    // Implement interface member (adjust signature to match Clarks if different)
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
    public void cloorkietocloork()
    {
        if (Clarks >= 10)
        {
            Clarks = Clarks - 10;
            clarkstoclack = clarkstoclack + 1;
        }
    }
}