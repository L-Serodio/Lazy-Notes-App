using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;
using System.Text;
using Newtonsoft;
using Newtonsoft.Json;
using System.Globalization;


public class MenuController : MonoBehaviour
{
    
   [SerializeField] private GameObject btnWrite;
   [SerializeField] private InputField noteText;
   [SerializeField] private InputField noteTitle;
   [SerializeField] private GameObject panelForWrite;
   private String textN = "";
   private String titleN = "";
    
    public void createNote() {
        textN = noteText.text;
        titleN = noteTitle.text;
        CultureInfo culture = new CultureInfo("pt-BR");
        DateTime dateTime = DateTime.Now;
        Note note = new Note() {
            title = titleN,
            text = textN,
            date = dateTime.ToString(culture)
        };
        string jsonString = JsonConvert.SerializeObject(note, Formatting.Indented);
        string path =  Application.dataPath + "/Notes/" + note.title +".json";
                
        File.WriteAllText(path, jsonString);
    }

    
    // JsonConvert.DeserializeObject<Note>(File.ReadAllText(path)); 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
