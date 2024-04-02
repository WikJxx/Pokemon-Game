using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ItemCollector : MonoBehaviour
{

    private int pikachu = 0;
    private int bulbazaur=0;
    private int charmander = 0;
    private int munchlax = 0;
    private int mudkip = 0;
    private int skitty = 0; 
    private int squirtle = 0; 
    private int torchic = 0;
    private int treecko = 0;
    [SerializeField] private Text Pikachus;
    [SerializeField] private Text Bulbazaurus;
    [SerializeField] private Text Charmanderus;
    [SerializeField] private Text Munchlaxus;
    [SerializeField] private Text Mudkipus;
    [SerializeField] private Text Skittus;
    [SerializeField] private Text Squirtleus;
    [SerializeField] private Text Torchixus;
    [SerializeField] private Text Treeckosus;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Pikachu"))
        {
           
            Destroy(collision.gameObject);         
            pikachu++;
            Pikachus.text=("Pikachu's: " + pikachu);
        }
        else if (collision.gameObject.CompareTag("Bulbazaur"))
        {
            Destroy(collision.gameObject);
            bulbazaur++;
            Bulbazaurus.text=("Bulbazaur's: "+bulbazaur);

        }
        else if (collision.gameObject.CompareTag("Charmander"))
        {
            Destroy(collision.gameObject);
            charmander++;
            Charmanderus.text = ("Charmanders's: " + charmander);

        }
        else if (collision.gameObject.CompareTag("Munchlax"))
        {
            Destroy(collision.gameObject);
            munchlax++;
            Munchlaxus.text = ("Munchlax's: " + munchlax);

        }
        else if (collision.gameObject.CompareTag("Skitty"))
        {
            Destroy(collision.gameObject);
            skitty++;
            Skittus.text = ("Skittys's: " + skitty);

        }
        else if (collision.gameObject.CompareTag("Squirtle"))
        {
            Destroy(collision.gameObject);
            squirtle++;
            Squirtleus.text = ("Squirtle's: " + squirtle);

        }
        else if (collision.gameObject.CompareTag("Torchic"))
        {
            Destroy(collision.gameObject);
            torchic++;
            Torchixus.text = ("Torchic's: " + torchic);

        }
        else if (collision.gameObject.CompareTag("Mudkip"))
        {
            Destroy(collision.gameObject);
            mudkip++;
            Mudkipus.text = ("Mudkip's: " + mudkip);
        }
        else 
        {
            Destroy(collision.gameObject);
            treecko++;
            Treeckosus.text = ("Treecko's: " + treecko);

        }


    }
}
