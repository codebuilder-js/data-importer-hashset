using System;
using System.Collections.Generic;

class DataImporter {
    private HashSet<string> uniqueEmails = new HashSet<string>();
    
    public void AddEmail(string email) {
        if(uniqueEmails.Add(email)) {
            Console.WriteLine($"E-mail \"{email}\" adicionado.");
        } else {
            Console.WriteLine($"E-mail \"{email}\" já existe. Ignorando duplicata.");
        }
    }
}
