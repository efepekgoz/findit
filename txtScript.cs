using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class txtScript : MonoBehaviour
{
    
    KarakterKontrol karakterkontrol;
    public GameObject karakter;

    public Text text;
    public List<string> cisimler = new List<string> { "Sofa","Drum","Vase","Chairs","Oven","Pan","Dining Table","Fridge","Book","Washing Machine","Carpet","Towel","Sink","Closet","Bath","Television","Mirror","Wardrobe","Chess","Laptop","Lamp","Bed"};
    public string cevap;
    public int gecici;
    public int currentScore;
    public Text scoreText;
    public AudioSource audioSource;
    
    
    void Awake()
    {
        karakterkontrol = karakter.GetComponent<KarakterKontrol>();
    }
    
    public void SkorAyarla()
    {
        scoreText.text = "Score: " + currentScore;
        audioSource.Play();
    }
    
    void Start()
    {
        randomize();
        currentScore = 0;
        
         
    }

   public void randomize()
    {
        int index = Random.Range(0, cisimler.Count);
        text.text = cisimler[index];
        cevap = cisimler[index];
        gecici = index;
    }
    public void compare()
    {
        if (karakterkontrol.hitPoint.collider.name == cevap)
        {
            Debug.Log("True");
            
            cisimler.RemoveAt(gecici);
            randomize();
            currentScore = currentScore + 10;
            SkorAyarla();
        }
    }
      

   
    void Update()
    {
        compare();
        


    }
}
