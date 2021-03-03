using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Globalization;

public class Note {
    
    private String text;
    private String date;
    public Note(String text) { 
        this.text = text;
        this.date = dateNow();
    }

    private String dateNow() {
        var culture = new CultureInfo("pt-BR");
        DateTime dateTime = DateTime.Now;
        return dateTime.ToString(culture);
    }


}
