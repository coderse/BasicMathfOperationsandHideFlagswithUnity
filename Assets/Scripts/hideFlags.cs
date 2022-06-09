using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hideFlags : MonoBehaviour
{
    //Inspector kýsmýna header ekleme
    [Header("burasý benim karakter ayarým")]
    public string saglik;
    [Header("burasý benim düþman ayarým")]
    public string dusman_saglik;

    [Tooltip("bu bizim inspectorlarýn üstüne geldiðimizde not eklememizi saglar")]
    public bool durum;



    [HideInInspector] // bunun altýndakiler görünmez inspector kýsmýnda 
                      // ama üstündekiler görünür örnek; iþinin bittikleri altýna koyarsan 
                      // kalabalýðý kalkar inspector kýsmýnda
    public string ad; 

    void Start()
    {
       
        //hideflag 


        //bunlar bize objeyi tamamen yaptýktan sonra özelliklerini diðerleriyle 
        //karýþtýrmayalým deðiþtirmeyelim gizlemeye yarar

        gameObject.hideFlags = HideFlags.DontSave; //objede oyun esnasýnda yapmýþ olduðumuz deðiþiklikleri kaydetmez 
                                                   //yaptýðýmýz deðiþiklikleri yeni obje gibi tutar 
                                                   //oyuna kaydedebilmemiz için gösterir bize

        gameObject.hideFlags = HideFlags.NotEditable; //inspactor kýsmý açýk fakat editable deðil..

        gameObject.hideFlags = HideFlags.HideInInspector; //bize objenin inspector kýsmýnýn görünmesini kapatýr
        gameObject.hideFlags = HideFlags.HideInHierarchy; //bize objenin hierarchy kýsmýnda görünmesini kapatýr


        
    }

}
