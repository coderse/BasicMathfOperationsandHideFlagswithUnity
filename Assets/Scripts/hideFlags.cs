using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hideFlags : MonoBehaviour
{
    //Inspector k�sm�na header ekleme
    [Header("buras� benim karakter ayar�m")]
    public string saglik;
    [Header("buras� benim d��man ayar�m")]
    public string dusman_saglik;

    [Tooltip("bu bizim inspectorlar�n �st�ne geldi�imizde not eklememizi saglar")]
    public bool durum;



    [HideInInspector] // bunun alt�ndakiler g�r�nmez inspector k�sm�nda 
                      // ama �st�ndekiler g�r�n�r �rnek; i�inin bittikleri alt�na koyarsan 
                      // kalabal��� kalkar inspector k�sm�nda
    public string ad; 

    void Start()
    {
       
        //hideflag 


        //bunlar bize objeyi tamamen yapt�ktan sonra �zelliklerini di�erleriyle 
        //kar��t�rmayal�m de�i�tirmeyelim gizlemeye yarar

        gameObject.hideFlags = HideFlags.DontSave; //objede oyun esnas�nda yapm�� oldu�umuz de�i�iklikleri kaydetmez 
                                                   //yapt���m�z de�i�iklikleri yeni obje gibi tutar 
                                                   //oyuna kaydedebilmemiz i�in g�sterir bize

        gameObject.hideFlags = HideFlags.NotEditable; //inspactor k�sm� a��k fakat editable de�il..

        gameObject.hideFlags = HideFlags.HideInInspector; //bize objenin inspector k�sm�n�n g�r�nmesini kapat�r
        gameObject.hideFlags = HideFlags.HideInHierarchy; //bize objenin hierarchy k�sm�nda g�r�nmesini kapat�r


        
    }

}
